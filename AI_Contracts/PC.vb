'PLUGINS CAN BE EXECUTED BY THIS NAMESPACE -
'SUBSCRIBERS TO THE AI-CONTRACTS IPLUGIN INTERFACE
Public Class PluginCompiler

    ''' <summary>
    ''' PReloaded with assemblies standard
    ''' </summary>
    ''' <remarks></remarks>
    Public Assemblies As List(Of String) = GetAssemblies()
    Private CmbCompileType As String = CompileType
    Private CmbLang As String = Lang
    Private FirstLoad As Boolean = True
    ''' <summary>
    ''' Resources files
    ''' </summary>
    ''' <remarks></remarks>
    Private ImageResources As New List(Of String)
    Private txtCodeBlock As String = Codeblock
    Public Enum CompilerType
        DLL
        MEM
        EXE
    End Enum
    Public Enum LanguageType
        VisualBasic
        CSharp
        Jscript
        VisualC
    End Enum
    Public Property Codeblock As String
        Get
            Return txtCodeBlock
        End Get
        Set(value As String)
            txtCodeBlock = value
        End Set
    End Property
    Public Property CompileType As String
        Get
            Return CmbCompileType
        End Get
        Set(value As String)
            CmbCompileType = value
        End Set
    End Property
    Public Property Lang As String
        Get
            Return CmbLang
        End Get
        Set(value As String)
            CmbLang = value
        End Set
    End Property
    Public Sub AddAssemblie(ByRef Path As String)
        Assemblies.Add(Path)
    End Sub
    Public Function AddEmbeddedImages(ByRef Settings As CodeDom.Compiler.CompilerParameters) As CodeDom.Compiler.CompilerParameters
        If ImageResources.Count > 0 Then
            For Each item In ImageResources
                Settings.EmbeddedResources.Add(item)
            Next
        End If
        Return Settings
    End Function
    Public Sub AddResourceFile(ByRef path As String)
        ImageResources.Add(path)
    End Sub
    ''' <summary>
    ''' An Attempt will be made to ADD AI_Contracts to Assemblie, IF Not Previoulsy added
    ''' </summary>
    ''' <param name="Codeblock">Script</param>
    ''' <param name="Filename">Save path/filename</param>
    Public Sub CompilePlugin(ByRef Codeblock As String, ByRef Filename As String)
        Try
            If Assemblies.Contains(("AI_CONTRACTS.dll")) = False Then Assemblies.Add("AI_CONTRACTS.dll")
        Catch ex As Exception
        End Try

        ConsoleCodeCompile(Codeblock, Filename, "DLL", "VisualBasic")


    End Sub
    ''' <summary>
    ''' Compile Plugins from text
    ''' </summary>
    ''' <param name="CodeBlock"></param>
    ''' <param name="CompileType">Default Visual Basic</param>
    ''' <param name="Lang"></param>
    ''' <param name="Filename"></param>
    ''' <remarks></remarks>
    Public Sub ConsoleCodeCompile(ByRef CodeBlock As String, ByRef Filename As String,
                                  Optional ByRef CompileType As String = "DLL",
                                  Optional ByRef Lang As String = "VisualBasic")
        'The CreateProvider method returns a CodeDomProvider instance for the specificed language name.
        'This instance is later used when we have finished specifying the parmameter values.
        Dim Compiler As CodeDom.Compiler.CodeDomProvider = CodeDom.Compiler.CodeDomProvider.CreateProvider(Lang)
        'Optionally, this could be called Parameters.
        'Think of parameters as settings or specific values passed to a method (later passsed to CompileAssemblyFromSource method).
        Dim Settings As New CodeDom.Compiler.CompilerParameters
        'The CompileAssemblyFromSource method returns a CompilerResult that will be stored in this variable.
        Dim Result As CodeDom.Compiler.CompilerResults = Nothing
        Dim ExecuteableName As String = ""
        Dim assembl As List(Of String) = Assemblies
        Select Case Lang
            Case "VisualBasic"
                For Each str As String In assembl
                    Settings.ReferencedAssemblies.Add(str)
                Next

                Settings.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
                'Settings.ReferencedAssemblies.Add("AI_CONTRACTS.dll")
            Case "CSharp"
                'Set assemblies referenced by the source code.
                For Each str As String In assembl
                    Settings.ReferencedAssemblies.Add(str)
                Next
                Settings.ReferencedAssemblies.Add("AI_CONTRACTS.dll")
               ' Settings.ReferencedAssemblies.Add("Microsoft.CSharp.dll")
            Case "Jscript"
                For Each str As String In assembl
                    Settings.ReferencedAssemblies.Add(str)
                Next
                '   Settings.ReferencedAssemblies.Add("AI_CONTRACTS.dll")
                Settings.ReferencedAssemblies.Add("Microsoft.Jscript.dll")
            Case "VisualC"
                For Each str As String In assembl
                    Settings.ReferencedAssemblies.Add(str)
                Next
                '      Settings.ReferencedAssemblies.Add("AI_CONTRACTS.dll")
                Settings.ReferencedAssemblies.Add("Microsoft.VisualC.dll")
        End Select
        Select Case CompileType
            Case "EXE"
                ''Dim S As New SaveFileDialog
                ''With S

                ''    .Filter = "Executable (*.exe)|*.exe"
                ''    If (.ShowDialog() = DialogResult.OK) Then
                ''        ExecuteableName = .FileName
                ''    End If
                ''End With

                ExecuteableName = Filename

                'Library type options : /target:library, /target:win, /target:winexe
                'Generates an executable instead of a class library.
                'Compiles in memory.
                Settings.GenerateInMemory = False
                Settings.GenerateExecutable = True
                Settings.CompilerOptions = " /target:winexe"
                'Set the assembly file name / path
                Settings.OutputAssembly = ExecuteableName
                'Read the documentation for the result again variable.
                'Calls the CompileAssemblyFromSource that will compile the specified source code using the parameters specified in the settings variable.
                Result = Compiler.CompileAssemblyFromSource(Settings, CodeBlock)
            Case "MEM"
                'Compiles in memory.
                Settings.GenerateInMemory = True
                'Read the documentation for the result again variable.
                'Calls the CompileAssemblyFromSource that will compile the specified source code using the parameters specified in the settings variable.
                Result = Compiler.CompileAssemblyFromSource(Settings, CodeBlock)
                'Creates assembly
                Dim objAssembly As System.Reflection.Assembly = Result.CompiledAssembly
                Dim objTheClass As Object = objAssembly.CreateInstance("MainClass")
                If objTheClass Is Nothing Then
                    MsgBox("Can't load class...")
                    Exit Sub
                End If
                'Trys to excute
                Try
                    objTheClass.GetType.InvokeMember("ExecuteCode",
                        System.Reflection.BindingFlags.InvokeMethod, Nothing, objTheClass, Nothing)
                Catch ex As Exception
                    MsgBox("Error:" & ex.Message)
                End Try
            Case "DLL"

                ''Dim S As New SaveFileDialog
                ''With S
                ''    .Filter = "Executable (*.Dll)|*.Dll"
                ''    If (.ShowDialog() = DialogResult.OK) Then
                ''        ExecuteableName = .FileName
                ''    End If
                ''End With
                ExecuteableName = Filename

                'Library type options : /target:library, /target:win, /target:winexe
                'Generates an executable instead of a class library.
                'Compiles in memory.
                Settings.GenerateInMemory = False
                Settings.GenerateExecutable = False
                Settings.CompilerOptions = " /target:library"
                'Set the assembly file name / path
                Settings.OutputAssembly = ExecuteableName
                'Read the documentation for the result again variable.
                'Calls the CompileAssemblyFromSource that will compile the specified source code using the parameters specified in the settings variable.
                Result = Compiler.CompileAssemblyFromSource(Settings, CodeBlock)
        End Select
        'Determines if we have any errors when compiling if so loops through all of the CompileErrors in the Reults variable and displays their ErrorText property.
        If (Result.Errors.Count <> 0) Then
            MessageBox.Show("Exception Occured!", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            For Each E As CodeDom.Compiler.CompilerError In Result.Errors
                MessageBox.Show(E.ErrorText)
            Next
        ElseIf (Result.Errors.Count = 0) And CompileType = "EXE" Or CompileType = "DLL" Then
            MsgBox("file saved at " & ExecuteableName)
        End If
    End Sub
    Public Function GetAssemblies() As List(Of String)
        'Set assemblies referenced by the source code.
        Assemblies = New List(Of String) From {
                "System.dll",
                "System.Windows.Forms.dll"
             }
        Return Assemblies
    End Function
End Class