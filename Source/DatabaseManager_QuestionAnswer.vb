

Module DatabaseManager_QuestionAnswer
    ''' <summary>
    ''' Gets a response From the Question and Answer Database
    ''' Checking Both Tables
    ''' </summary>
    ''' <param name="UserInput"></param>
    ''' <param name="Response"></param>
    ''' <returns></returns>
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
    ''' <summary>
    ''' Check MIND_QA TABLE - Given Question Answer is determined
    ''' </summary>
    ''' <param name="Question"></param>
    ''' <param name="Answer"></param>
    ''' <returns>If true Answer is populated</returns>
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
    ''' <summary>
    ''' Check MINDQA - Given Question Answer is populated
    ''' </summary>
    ''' <param name="Question"></param>
    ''' <param name="Answer"></param>
    ''' <returns>If True Answer is populated</returns>
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
    ''' <summary>
    ''' Used to retrive Table from QA TABLES
    ''' </summary>
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
