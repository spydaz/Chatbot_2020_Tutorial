

Module QuestionAnswer
    Public Function GetQAResponse(ByRef UserInput As String, ByRef Response As String) As Boolean
        GetQAResponse = False
        If DetectAnswerMindQA(UCase(UserInput), Response) = True Then
            Return True
        Else
        End If

        If DetectAnswerQAMind(UCase(UserInput), Response) = True Then
            Return True
        Else
        End If

    End Function

    Public Function DetectAnswerMindQA(ByRef Question As String, ByRef Answer As String) As Boolean
        Dim Knowledge As List(Of TopicQuestion) = GetMindQA()
        DetectAnswerMindQA = False
        For Each item In Knowledge
            If UCase(item.Question) Like UCase(Question) = True Then
                Answer = item.Topic
                Return True
            Else
            End If
        Next
    End Function
    Public Function DetectAnswerQAMind(ByRef Question As String, ByRef Answer As String) As Boolean
        Dim Knowledge As List(Of TopicQuestion) = GetQAMind()
        DetectAnswerQAMind = False
        For Each item In Knowledge
            If UCase(item.Question) Like UCase(Question) = True Then
                Answer = item.Topic
                Return True
            Else
            End If
        Next
    End Function
    Private Function GetMindQA() As List(Of TopicQuestion)
        Dim DbSubjectLst As New List(Of TopicQuestion)
        Const SQL As String = "SELECT *  FROM MINDQA"
        Using conn = New System.Data.OleDb.OleDbConnection(My.Settings.MindQAConnectionString)
            Using cmd = New OleDb.OleDbCommand(SQL, conn)
                conn.Open()
                Try
                    Dim dr = cmd.ExecuteReader()
                    While dr.Read()
                        Dim NewKnowledge As TopicQuestion
                        NewKnowledge.Question = dr("QUESTION").ToString()
                        NewKnowledge.Topic = dr("Answer").ToString()
                        DbSubjectLst.Add(NewKnowledge)
                    End While
                Catch e As Exception
                    ' Do some logging or something.
                    MessageBox.Show("There was an error accessing your data. MINDQA: " & e.ToString())
                End Try
            End Using
        End Using
        Return DbSubjectLst
    End Function
    Private Structure TopicQuestion
        ''' <summary>
        ''' Question Associated with topic (can be used as a Flat response) or Can be used to
        ''' learn new information from multiple sources
        ''' </summary>
        ''' <remarks></remarks>
        Public Question As String
        ''' <summary>
        ''' Topic of Associated Question
        ''' </summary>
        ''' <remarks></remarks>
        Public Topic As String
    End Structure
    Private Function GetQAMind() As List(Of TopicQuestion)
        Dim DbSubjectLst As New List(Of TopicQuestion)
        Const SQL As String = "SELECT * FROM QAMIND"
        Using conn = New System.Data.OleDb.OleDbConnection(My.Settings.MindQAConnectionString)
            Using cmd = New System.Data.OleDb.OleDbCommand(SQL, conn)
                conn.Open()
                Try
                    Dim dr = cmd.ExecuteReader()
                    While dr.Read()
                        Dim NewKnowledge As TopicQuestion
                        NewKnowledge.Question = dr("QUESTION").ToString()
                        NewKnowledge.Topic = dr("ANSWER").ToString()
                        DbSubjectLst.Add(NewKnowledge)
                    End While
                Catch e As Exception
                    ' Do some logging or something.
                    MessageBox.Show("There was an error accessing your data. QA-MIND: " & e.ToString())
                End Try
            End Using
        End Using
        Return DbSubjectLst
    End Function
End Module
