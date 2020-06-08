Public Class Extensions_Files
    ''' <summary>
    ''' Loads Json Text to String With OpenFileDialog
    ''' </summary>
    ''' <returns></returns>
    Public Function OpenJsonFile() As String

        Dim Scriptfile As String = ""
        Dim Ofile As New OpenFileDialog
        With Ofile
            .Filter = "Json files (*.Json)|*.Json"

            If (.ShowDialog() = DialogResult.OK) Then
                Scriptfile = .FileName
            End If
        End With
        Dim txt As String = ""
        If Scriptfile IsNot "" Then
            Try
                txt = My.Computer.FileSystem.ReadAllText(Scriptfile)
            Catch ex As Exception
                MsgBox(ex.ToString,, "Error")
            End Try
        End If
        Return txt
    End Function
    ''' <summary>
    ''' Save Json
    ''' </summary>
    ''' <param name="Script"></param>
    Public Sub SaveScriptAsJson(ByRef Script As String)
        Try
            Dim ScriptFile As String = ""
            Dim S As New SaveFileDialog
            With S
                .Filter = "Json Script File (*.Json)|*.Json"
                If (.ShowDialog() = DialogResult.OK) Then
                    ScriptFile = .FileName
                End If
            End With
            My.Computer.FileSystem.WriteAllText(ScriptFile, Script, False)
        Catch ex As Exception
            MsgBox(ex.ToString,, "error")
        End Try
    End Sub
    ''' <summary>
    ''' Loads Html Text to String With OpenFileDialog
    ''' </summary>
    ''' <returns></returns>
    Public Function OpenHtmlFile() As String

        Dim Scriptfile As String = ""
        Dim Ofile As New OpenFileDialog
        With Ofile
            .Filter = "Html files (*.Html)|*.Html"

            If (.ShowDialog() = DialogResult.OK) Then
                Scriptfile = .FileName
            End If
        End With
        Dim txt As String = ""
        If Scriptfile IsNot "" Then
            Try
                txt = My.Computer.FileSystem.ReadAllText(Scriptfile)
            Catch ex As Exception
                MsgBox(ex.ToString,, "Error")
            End Try
        End If
        Return txt
    End Function
    ''' <summary>
    ''' Save Html
    ''' </summary>
    ''' <param name="Script"></param>
    Public Sub SaveScriptAsHtml(ByRef Script As String)
        Try
            Dim ScriptFile As String = ""
            Dim S As New SaveFileDialog
            With S
                .Filter = "Html Script File (*.Html)|*.Html"
                If (.ShowDialog() = DialogResult.OK) Then
                    ScriptFile = .FileName
                End If
            End With
            My.Computer.FileSystem.WriteAllText(ScriptFile, Script, False)
        Catch ex As Exception
            MsgBox(ex.ToString,, "error")
        End Try
    End Sub
    ''' <summary>
    ''' Loads  Text to String With OpenFileDialog
    ''' </summary>
    ''' <returns></returns>
    Public Function OpenTextFile() As String

        Dim Scriptfile As String = ""
        Dim Ofile As New OpenFileDialog
        With Ofile
            .Filter = "txt files (*.txt)|*.txt"

            If (.ShowDialog() = DialogResult.OK) Then
                Scriptfile = .FileName
            End If
        End With
        Dim txt As String = ""
        If Scriptfile IsNot "" Then
            Try
                txt = My.Computer.FileSystem.ReadAllText(Scriptfile)
            Catch ex As Exception
                MsgBox(ex.ToString,, "Error")
            End Try
        End If
        Return txt
    End Function
    ''' <summary>
    ''' Save TXT
    ''' </summary>
    ''' <param name="Script"></param>
    Public Sub SaveScriptAsText(ByRef Script As String)
        Try
            Dim ScriptFile As String = ""
            Dim S As New SaveFileDialog
            With S
                .Filter = "text File (*.txt)|*.txt"
                If (.ShowDialog() = DialogResult.OK) Then
                    ScriptFile = .FileName
                End If
            End With
            My.Computer.FileSystem.WriteAllText(ScriptFile, Script, False)
        Catch ex As Exception
            MsgBox(ex.ToString,, "error")
        End Try
    End Sub
    ''' <summary>
    ''' Loads VB Text to String With OpenFileDialog
    ''' </summary>
    ''' <returns></returns>
    Public Function OpenVBFile() As String

        Dim Scriptfile As String = ""
        Dim Ofile As New OpenFileDialog
        With Ofile
            .Filter = "vb files (*.vb)|*.vb"

            If (.ShowDialog() = DialogResult.OK) Then
                Scriptfile = .FileName
            End If
        End With
        Dim txt As String = ""
        If Scriptfile IsNot "" Then
            Try
                txt = My.Computer.FileSystem.ReadAllText(Scriptfile)
            Catch ex As Exception
                MsgBox(ex.ToString,, "Error")
            End Try
        End If
        Return txt
    End Function
    ''' <summary>
    ''' Save VB
    ''' </summary>
    ''' <param name="Script"></param>
    Public Sub SaveScriptAsVB(ByRef Script As String)
        Try
            Dim ScriptFile As String = ""
            Dim S As New SaveFileDialog
            With S
                .Filter = "VB File (*.vb)|*.vb"
                If (.ShowDialog() = DialogResult.OK) Then
                    ScriptFile = .FileName
                End If
            End With
            My.Computer.FileSystem.WriteAllText(ScriptFile, Script, False)
        Catch ex As Exception
            MsgBox(ex.ToString,, "error")
        End Try
    End Sub
End Class


