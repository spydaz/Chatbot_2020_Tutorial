Imports AI_Contracts
Imports System.Reflection
Public Class FormPluginManager

    Private Sub FormPluginManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRefference(Application.StartupPath & "\AI_CONTRACTS.DLL")
        LoadPlugins()
    End Sub

    'MAIN CHANGES (PLUGIN to DEVICE to TEST to UPDATE)
    ''' <summary>
    ''' Buttons
    ''' </summary>
#Region "Buttons"
    Private Sub ListBoxPlugins_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPlugins.SelectedIndexChanged
        If ListBoxPlugins.SelectedItem IsNot Nothing Then
            For Each item In Plugins
                If item.PluginName = ListBoxPlugins.SelectedItem Then
                    RichTextBoxInfo.Text = item.Info
                End If
            Next
        End If
    End Sub

#Region "Toolstrip"
    Private Sub ToolStripButtonNewPlugin_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNewPlugin.Click
        AddTab(TabDocumentBrowser, TabPages, My.Settings.SamplePlugin, "Sample Plugin")
        TextBoxPluginFileName.Text = "default Plugin"

    End Sub
    Private Sub ToolStripButtonCloseTab_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCloseTab.Click
        RemoveTab(TabDocumentBrowser, TabPages)
    End Sub
    Private Sub ToolStripButtonLoadPlugin_Click(sender As Object, e As EventArgs) Handles ToolStripButtonLoadPlugin.Click
        On Error Resume Next
        AddTab(TabDocumentBrowser, TabPages, LoadScript, "Default")

    End Sub
    Private Sub ToolStripButtonSavePlugin_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSavePlugin.Click
        On Error Resume Next
        SaveScript(GetCurrentTabText(TabDocumentBrowser))
    End Sub
#End Region

#End Region
#Region "TAB FUNCTIONS"
#Region "TabFunctions"
    ''' <summary>
    ''' Current number of tabpages
    ''' </summary>
    Public TabPages As Integer = 0
    ''' <summary>
    ''' Checks if tab is web or text
    ''' </summary>
    ''' <returns></returns>
    Public Function IsWebTab() As Boolean
        IsWebTab = False
        If TabDocumentBrowser.SelectedTab.Text = "Browser" Then Return True
    End Function
    ''' <summary>
    ''' Checks if tab is web or text
    ''' </summary>
    ''' <returns></returns>
    Public Function IsTextTab() As Boolean
        IsTextTab = False
        If TabDocumentBrowser.SelectedTab.Text = "TextBox" Then Return True
    End Function
    ''' <summary>
    ''' Adds new tab with data
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Tabcount">number of pages</param>
    ''' <param name="Text">data</param>
    ''' <param name="Title">title</param>
    Public Sub AddTab(ByRef Sender As TabControl, ByRef Tabcount As Integer, ByRef Text As String, ByRef Title As String)
        Dim Body As New RichTextBox
        Body.Font = New Font(Sender.Font.Name, 12, FontStyle.Regular)
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill

        Body.Text = Text
        Dim NewPage As New TabPage()
        Tabcount += 1
        Body.ForeColor = Color.MidnightBlue

        Dim DocumentText As String = Title & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)

        Sender.TabPages.Add(NewPage)
        NewPage.Text = "TextBox"
        Body.ContextMenuStrip = rcMenu
        Sender.SelectedTab = NewPage
    End Sub
    ''' <summary>
    ''' Adds a current new tab(document)
    ''' </summary>
    ''' <param name="Sender">tab control</param>
    ''' <param name="Tabcount">tab count</param>
    Public Sub AddTab(ByRef Sender As TabControl, ByRef Tabcount As Integer)
        Dim Body As New RichTextBox
        Body.Font = New Font(Sender.Font.Name, 12, FontStyle.Regular)
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill
        Dim NewPage As New TabPage()
        Tabcount += 1
        Body.ForeColor = Color.MidnightBlue

        Dim DocumentText As String = "Document " & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)

        Sender.TabPages.Add(NewPage)
        NewPage.Text = "TextBox"
        Body.ContextMenuStrip = rcMenu
        Sender.SelectedTab = NewPage
    End Sub
    ''' <summary>
    ''' Closes current tab Unsaved
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Tabcount">number of current pages</param>
    Public Sub RemoveTab(ByRef Sender As TabControl, ByRef Tabcount As Integer)
        If Sender.SelectedTab.Name <> "VBWORKSPACE" = True Then

            If Not Sender.TabPages.Count = 1 Then
                Sender.TabPages.Remove(Sender.SelectedTab)
                Tabcount -= 1
            Else
                Sender.TabPages.Remove(Sender.SelectedTab)
                AddTab(Sender, Tabcount)
            End If
        End If
    End Sub
    ''' <summary>
    ''' Closes all tabs
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Tabcount">number of tabs</param>
    Public Sub RemoveAllTabs(ByRef Sender As TabControl, ByRef Tabcount As Integer)

        For Each Page As TabPage In Sender.TabPages
            Sender.TabPages.Remove(Page)
        Next
        Tabcount = 0
        AddTab(Sender, Tabcount)
    End Sub
    ''' <summary>
    ''' removes all tabs except current
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="TabCount">number of tabs</param>
    Public Sub RemoveAllTabsButThis(ByRef Sender As TabControl, ByRef TabCount As Integer)
        For Each Page As TabPage In Sender.TabPages
            If Not Page.Name = Sender.SelectedTab.Name Then
                Sender.TabPages.Remove(Page)
                TabCount = 0 + 1
            Else
            End If
        Next
    End Sub
    ''' <summary>
    ''' Returns text held in current tab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <returns>text</returns>
    Public Function GetCurrentTabText(ByRef Sender As TabControl) As String
        If IsTextTab() = True Then
            Return CType(Sender.SelectedTab.Controls.Item("Body"), RichTextBox).Text
        Else
        End If
        Return Nothing
    End Function
    ''' <summary>
    ''' Returns text held in current tab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <returns>text</returns>
    Public Function GetCurrentTabRichTextBox(ByRef Sender As TabControl) As RichTextBox
        If IsTextTab() = True Then
            Return CType(Sender.SelectedTab.Controls.Item("Body"), RichTextBox)
        Else
        End If
        Return Nothing
    End Function
    ''' <summary>
    ''' saves data in current tab to file
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Filename">filename</param>
    Public Sub SaveCurrentTab(ByRef Sender As TabControl, ByRef Filename As String)
        If IsTextTab() = True Then
            GetCurrentTabRichTextBox(Sender).SaveFile(Filename, RichTextBoxStreamType.RichText)
        Else
        End If
    End Sub
    ''' <summary>
    ''' loads file data into current tab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Filename">data file</param>
    Public Sub Open(ByRef Sender As TabControl, ByRef Filename As String)

        GetCurrentTabRichTextBox(Sender).LoadFile(Filename, RichTextBoxStreamType.PlainText)

    End Sub
    ''' <summary>
    ''' opens file in new tab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Tabcount">number of tabs</param>
    ''' <param name="Filename">file location</param>
    Public Sub OpenNewTab(ByRef Sender As TabControl, ByRef Tabcount As Integer, Filename As String)

        Dim Body As New RichTextBox
        Body.Font = New Font(TabDocumentBrowser.Font.Name, 12, FontStyle.Regular)
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill
        Body.ForeColor = Color.MidnightBlue


        Dim NewPage As New TabPage()
        Tabcount += 1

        Dim DocumentText As String = "Document " & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)
        Body.LoadFile(Filename, RichTextBoxStreamType.PlainText)
        Sender.TabPages.Add(NewPage)
        NewPage.Text = "TextBox"
    End Sub
    ''' <summary>
    ''' adds Webtab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Tabcount">number of pages</param>
    ''' <param name="Source">html source text</param>
    Public Sub AddWebSourceTab(ByRef Sender As TabControl, ByRef Tabcount As Integer, ByRef Source As String)

        Dim Body As New System.Windows.Forms.WebBrowser
        Body.Font = New Font(TabDocumentBrowser.Font.Name, 12, FontStyle.Regular)
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill
        Body.ScriptErrorsSuppressed = True
        Dim NewPage As New TabPage()
        Tabcount += 1

        Body.DocumentText = Source
        Body.Refresh()
        Dim DocumentText As String = "Document " & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)
        Body.Tag = TAB()
        NewPage.Text = "Browser"
        Sender.TabPages.Add(NewPage)
        Sender.SelectedTab = NewPage

    End Sub


#End Region
#Region "Load/Save Web/Text Tabs"

    ''' <summary>
    ''' Loads text file to new tab
    ''' </summary>
    ''' <returns></returns>
    Public Function LoadText() As String

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
                AddTab(TabDocumentBrowser, TabPages, txt, Scriptfile)
            Catch ex As Exception

                MsgBox(ex.ToString,, "Error")
            End Try
        End If
        Return txt
    End Function
    ''' <summary>
    ''' Loads vb file to new tab
    ''' </summary>
    ''' <returns></returns>
    Public Function LoadScript() As String

        Dim Scriptfile As String = ""
        Dim Ofile As New OpenFileDialog
        With Ofile
            .Filter = "Script files (*.vb)|*.vb"

            If (.ShowDialog() = DialogResult.OK) Then
                Scriptfile = .FileName
            End If
        End With
        Dim txt As String = ""
        If Scriptfile IsNot "" Then


            Try
                txt = My.Computer.FileSystem.ReadAllText(Scriptfile)
                AddTab(TabDocumentBrowser, TabPages, txt, Scriptfile)
            Catch ex As Exception

                MsgBox(ex.ToString,, "Error")
            End Try
        Else
        End If

        Return txt
    End Function
    ''' <summary>
    ''' loads webtab from file
    ''' </summary>
    ''' <returns></returns>
    Public Function LoadHTML() As String

        Dim Scriptfile As String = ""
        Dim Ofile As New OpenFileDialog
        With Ofile
            .Filter = "Html Source files (*.htm)|*.htm"

            If (.ShowDialog() = DialogResult.OK) Then
                Scriptfile = .FileName
            End If
        End With
        Dim txt As String = ""
        If Scriptfile IsNot "" Then
            Try
                txt = My.Computer.FileSystem.ReadAllText(Scriptfile)
                AddTab(TabDocumentBrowser, TabPages, txt, Scriptfile)
                AddWebSourceTab(TabDocumentBrowser, TabPages, txt)
            Catch ex As Exception

                MsgBox(ex.ToString,, "Error")
            End Try
        End If
        Return txt
    End Function
    ''' <summary>
    ''' Returns brainfile path and loads script in new tab
    ''' </summary>
    ''' <returns></returns>
    Public Function LoadbrainScript() As String

        Dim Scriptfile As String = ""
        Dim Ofile As New OpenFileDialog
        With Ofile
            .Filter = "BrainScript files (*.Aib)|*.Aib"

            If (.ShowDialog() = DialogResult.OK) Then
                Scriptfile = .FileName
            End If
        End With
        Dim txt As String = ""
        If Scriptfile IsNot "" Then
            Try
                txt = My.Computer.FileSystem.ReadAllText(Scriptfile)
                AddTab(TabDocumentBrowser, TabPages, txt, Scriptfile)
            Catch ex As Exception
                MsgBox(ex.ToString,, "Error")
            End Try
        End If
        Return Scriptfile
    End Function
    ''' <summary>
    ''' load text File
    ''' </summary>
    ''' <param name="Path">Filename</param>
    ''' <returns></returns>
    Public Function LoadScript(ByRef Path As String) As String
        Dim Scriptfile As String = Path

        Dim txt As String = ""
        Try
            txt = My.Computer.FileSystem.ReadAllText(Scriptfile)
        Catch ex As Exception

            MsgBox(ex.ToString,, "Error")
        End Try
        Return txt
    End Function
    ''' <summary>
    ''' save html
    ''' </summary>
    ''' <param name="Script"></param>
    Public Sub SaveHtml(ByRef Script As String)
        Try
            Dim ScriptFile As String = ""
            Dim S As New SaveFileDialog
            With S
                .Filter = "Html Source (*.htm)|*.htm"
                If (.ShowDialog() = DialogResult.OK) Then
                    ScriptFile = .FileName
                End If
            End With
            My.Computer.FileSystem.WriteAllText(ScriptFile, Script, True)
        Catch ex As Exception
            MsgBox(ex.ToString,, "error")
        End Try
    End Sub
    ''' <summary>
    ''' saves text file
    ''' </summary>
    ''' <param name="Script"></param>
    Public Sub SaveText(ByRef Script As String)
        Try
            Dim ScriptFile As String = ""
            Dim S As New SaveFileDialog
            With S
                .Filter = "Text File (*.txt)|*.txt"
                If (.ShowDialog() = DialogResult.OK) Then
                    ScriptFile = .FileName
                End If
            End With
            My.Computer.FileSystem.WriteAllText(ScriptFile, Script, True)
        Catch ex As Exception
            MsgBox(ex.ToString,, "error")
        End Try
    End Sub
    ''' <summary>
    ''' Save VB
    ''' </summary>
    ''' <param name="Script"></param>
    Public Sub SaveScript(ByRef Script As String)
        Try
            Dim ScriptFile As String = ""
            Dim S As New SaveFileDialog
            With S
                .Filter = "Script File (*.vb)|*.vb"
                If (.ShowDialog() = DialogResult.OK) Then
                    ScriptFile = .FileName
                End If
            End With
            My.Computer.FileSystem.WriteAllText(ScriptFile, Script, True)
        Catch ex As Exception
            MsgBox(ex.ToString,, "error")
        End Try
    End Sub
    ''' <summary>
    ''' Sav AIB
    ''' </summary>
    ''' <param name="Script"></param>
    Public Sub SaveBrainScript(ByRef Script As String)
        Try
            Dim ScriptFile As String = ""
            Dim S As New SaveFileDialog
            With S
                .Filter = "brain Script File (*.aib)|*.aib"
                If (.ShowDialog() = DialogResult.OK) Then
                    ScriptFile = .FileName
                End If
            End With
            My.Computer.FileSystem.WriteAllText(ScriptFile, Script, True)
        Catch ex As Exception
            MsgBox(ex.ToString,, "error")
        End Try
    End Sub

#End Region
#End Region
    ''' <summary>
    ''' Right Click Menu 
    ''' </summary>
#Region "RightClickMenu"
    Private Sub Undo()
        If GetCurrentTabRichTextBox(TabDocumentBrowser).CanUndo = True Then
            GetCurrentTabRichTextBox(TabDocumentBrowser).Undo()
        End If
    End Sub
    Private Sub AddScriptTab()
        AddTab(TabDocumentBrowser, TabPages)
    End Sub
    Private Sub Redo()
        If GetCurrentTabRichTextBox(TabDocumentBrowser).CanRedo = True Then

            GetCurrentTabRichTextBox(TabDocumentBrowser).Redo()

        End If
    End Sub
    Private Sub Cut()
        If GetCurrentTabRichTextBox(TabDocumentBrowser).SelectedText IsNot Nothing Then
            GetCurrentTabRichTextBox(TabDocumentBrowser).Cut()
        End If
    End Sub
    Private Sub Copy()
        If GetCurrentTabRichTextBox(TabDocumentBrowser).SelectedText IsNot Nothing Then
            GetCurrentTabRichTextBox(TabDocumentBrowser).Copy()
        End If
    End Sub
    Private Sub Paste()
        If GetCurrentTabRichTextBox(TabDocumentBrowser) IsNot Nothing Then
            GetCurrentTabRichTextBox(TabDocumentBrowser).Paste()
        End If

    End Sub
    Private Sub SelectAll()
        If GetCurrentTabRichTextBox(TabDocumentBrowser) IsNot Nothing Then
            GetCurrentTabRichTextBox(TabDocumentBrowser).SelectAll()
        End If

    End Sub
    Private Sub UndoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Undo()
    End Sub
    Private Sub RedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        Redo()
    End Sub
    Private Sub CutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Cut()
    End Sub
    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Copy()
    End Sub
    Private Sub PasteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Paste()
    End Sub
    Private Sub NewScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewScriptToolStripMenuItem.Click
        AddScriptTab()
    End Sub
















#End Region
    ''' <summary>
    ''' Plugins
    ''' </summary>
#Region "Plugins"
    Public Plugins As New List(Of IPlugin)

    Public Sub LoadPlugins()
        ListBoxPlugins.Items.Clear()
        Plugins = ScanPlugins()
        If Plugins IsNot Nothing Then
            If Plugins.Count > 0 Then
                For Each item In Plugins
                    ListBoxPlugins.Items.Add(item.PluginName)
                Next
            Else
            End If
        Else
        End If
    End Sub
#End Region
    ''' <summary>
    ''' Compiler Functions
    ''' </summary>
#Region "Compiler"
    Public MyCompiler As New PluginCompiler
    'MAIN CHANGES (PLUGIN to DEVICE to TEST to UPDATE)
    ''' <summary>
    ''' Req Filename for plugin to be compiled
    ''' </summary>
    Public PluginFile As String = ""
    'Code to be compiled
    Public Code As String = ""
    Private Sub ToolStripButtonCompilePlugin_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCompilePlugin.Click
        Code = GetCurrentTabText(TabDocumentBrowser)
        PluginFile = Application.StartupPath & "\Plugins\" & TextBoxPluginFileName.Text & ".dll"
        If Code IsNot "" Then
            For Each item In Assemblies
                MyCompiler.AddAssemblie(item)
            Next
            MyCompiler.CompilePlugin(Code, PluginFile)
        Else
        End If
    End Sub
#End Region
    ''' <summary>
    ''' Refferences
    ''' </summary>
#Region "Reffs"
    Public Sub LoadRefference(ByRef Filename As String)
        AddAssembly(Filename)

    End Sub


#Region "Dll Refferences"
    Private LoadedTypes As New List(Of Type)
    ''' <summary>
    ''' Removes assemblies from Compiler
    ''' </summary>
    ''' <param name="Path">Location of Assembly</param>
    Public Sub RemoveAssemblie(ByRef Path As String)
        Assemblies.Remove(Path)
        ComboBoxRefferences.Items.Remove(Path)
        Dim ass As Assembly = Assembly.LoadFrom(Path)
        Dim typ() As Type = ass.GetTypes()
        For Each t In typ
            LoadedTypes.Remove(t)
        Next
        TreeViewObjectSyntax.Nodes.Clear()
        UpdateTreeViewControl(TreeViewObjectSyntax, LoadedTypes)
    End Sub
    ''' <summary>
    ''' Adds assemblie to combo
    ''' </summary>
    ''' <param name="Path"></param>
    Public Sub AddAssembly(ByRef Path As String)
        On Error Resume Next
        Dim Found As Boolean = False
        For Each item In Assemblies
            If item = Path = True Then
                Found = True
            Else

            End If
        Next
        If Found = False Then


            Assemblies.Add(Path)
            ComboBoxRefferences.Items.Add(Path)

            Dim ass As Assembly = Assembly.LoadFrom(Path)
            Dim typ() As Type = ass.GetTypes()
            For Each t In typ
                LoadedTypes.Add(t)
            Next
            TreeViewObjectSyntax.Nodes.Clear()
            UpdateTreeViewControl(TreeViewObjectSyntax, LoadedTypes)
        Else
        End If
    End Sub
    Private Sub ButtonAddAssemblies_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim Scriptfile As String = ""
        Dim Ofile As New OpenFileDialog
        With Ofile
            .Filter = "DLL Assembly files (*.DLL)|*.dll"

            If (.ShowDialog() = DialogResult.OK) Then
                Scriptfile = .FileName
            End If
        End With

        AddAssembly(Scriptfile)
    End Sub
    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemoveRefference.Click
        RemoveAssemblie(ComboBoxRefferences.SelectedItem)
    End Sub




    Public Assemblies As New List(Of String)
#End Region


#End Region
#Region "ObjectBrowser"
    Private Sub TreeViewObjectSyntax_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewObjectSyntax.AfterSelect
        Dim Str As String = ""
        Str = TreeViewObjectSyntax.SelectedNode.ToString & vbNewLine
        RichTextBoxInfo.Text = If(Str.Contains("Syntax: ") = True, Str.ExtractStringBetween("Syntax: ", " #").Replace("Syntax:", ""), Str.Replace("TreeNode:", ""))
    End Sub
    Public Function GetMethodsList(ByRef Types As List(Of Type)) As List(Of MethodItem)
        Dim Lst As New List(Of MethodItem)
        'Dim Types As List(Of Type) = TypeReader.Addtypes
        For Each MyType As Type In Types
            Dim NewItem As New MethodItem
            ' Get the public methods.
            Dim myArrayMethodInfo As MethodInfo() = MyType.GetMethods((BindingFlags.Public Or
                                                                      BindingFlags.Instance Or
                                                                      BindingFlags.DeclaredOnly Or
                                                                    BindingFlags.Static))

            Dim i As Integer
            For i = 0 To myArrayMethodInfo.Length - 1
                Dim myMethodInfo As MethodInfo = myArrayMethodInfo(i)
                NewItem.TypeName = MyType.FullName
                NewItem.TypeMethod = myMethodInfo.Name
                NewItem.TypeMethodInfo = myMethodInfo
                Lst.Add(NewItem)
            Next i
        Next
        Return Lst
    End Function
    Public Sub UpdateTreeViewControl(ByRef TrContol As TreeView, Types As List(Of Type))

        Dim nTypes As List(Of MethodItem) = GetMethodsList(Types)


        Dim Lst As New List(Of String)
        For Each mtype As MethodItem In nTypes

            If Lst.Contains(mtype.TypeName) Then
            Else
                Lst.Add(mtype.TypeName)
            End If
        Next
        For Each str As String In Lst
            Dim node As New System.Windows.Forms.TreeNode
            node.Text = str
            For Each mytype As MethodItem In nTypes
                If mytype.TypeName = str Then
                    node.Nodes.Add("<" & mytype.TypeMethod & ">" & " Syntax:  " & vbNewLine & mytype.TypeMethodInfo.ToString & " #")

                End If
            Next
            TrContol.Nodes.Add(node)
        Next
    End Sub
    Public Structure MethodItem
        Public TypeMethod As String
        Public TypeMethodInfo As MethodInfo
        Public TypeName As String
    End Structure


#End Region
End Class

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
    Public Sub CompilePlugin(ByRef Codeblock As String, ByRef Filename As String)
        ConsoleCodeCompile(Codeblock, Filename, "DLL", "VisualBasic")
    End Sub
    ''' <summary>
    ''' Compile Plugins from text
    ''' </summary>
    ''' <param name="CodeBlock"></param>
    ''' <param name="CompileType"></param>
    ''' <param name="Lang"></param>
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
            Case "CSharp"
                'Set assemblies referenced by the source code.
                For Each str As String In assembl
                    Settings.ReferencedAssemblies.Add(str)
                Next

                Settings.ReferencedAssemblies.Add("Microsoft.CSharp.dll")
            Case "Jscript"
                For Each str As String In assembl
                    Settings.ReferencedAssemblies.Add(str)
                Next

                Settings.ReferencedAssemblies.Add("Microsoft.Jscript.dll")
            Case "VisualC"
                For Each str As String In assembl
                    Settings.ReferencedAssemblies.Add(str)
                Next

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
