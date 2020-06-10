<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPluginManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPluginManager))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TabDocumentBrowser = New System.Windows.Forms.TabControl()
        Me.VBWORKSPACE = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxHistoryChat = New System.Windows.Forms.RichTextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxResponse = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBoxPrevResponse = New System.Windows.Forms.TextBox()
        Me.TextBoxPrevUserInput = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.TextBoxUserinput = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.ToolStripMainMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonNewPlugin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonLoadPlugin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonSavePlugin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonCompilePlugin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonCloseTab = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.rcMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ButtonSendQuery = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonRemoveRefference = New System.Windows.Forms.Button()
        Me.ComboBoxRefferences = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPluginFileName = New System.Windows.Forms.TextBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.TreeViewObjectSyntax = New System.Windows.Forms.TreeView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxInfo = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBoxPlugins = New System.Windows.Forms.ListBox()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabDocumentBrowser.SuspendLayout()
        Me.VBWORKSPACE.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.ToolStripMainMenu.SuspendLayout()
        Me.rcMenu.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Chatbot_2020_Tutorial.My.Resources.Resources.Bar2
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.GroupBox15)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1141, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Plugins"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TabDocumentBrowser)
        Me.GroupBox5.Controls.Add(Me.ToolStripMainMenu)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(0, 319)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox5.Size = New System.Drawing.Size(1141, 448)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Scripts"
        '
        'TabDocumentBrowser
        '
        Me.TabDocumentBrowser.Controls.Add(Me.VBWORKSPACE)
        Me.TabDocumentBrowser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabDocumentBrowser.Location = New System.Drawing.Point(4, 58)
        Me.TabDocumentBrowser.Name = "TabDocumentBrowser"
        Me.TabDocumentBrowser.SelectedIndex = 0
        Me.TabDocumentBrowser.Size = New System.Drawing.Size(1133, 385)
        Me.TabDocumentBrowser.TabIndex = 1
        '
        'VBWORKSPACE
        '
        Me.VBWORKSPACE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VBWORKSPACE.Controls.Add(Me.GroupBox9)
        Me.VBWORKSPACE.Controls.Add(Me.GroupBox8)
        Me.VBWORKSPACE.Controls.Add(Me.GroupBox7)
        Me.VBWORKSPACE.Location = New System.Drawing.Point(4, 32)
        Me.VBWORKSPACE.Name = "VBWORKSPACE"
        Me.VBWORKSPACE.Padding = New System.Windows.Forms.Padding(3)
        Me.VBWORKSPACE.Size = New System.Drawing.Size(1125, 349)
        Me.VBWORKSPACE.TabIndex = 0
        Me.VBWORKSPACE.Text = "DevCenter"
        Me.VBWORKSPACE.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Black
        Me.GroupBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox9.Controls.Add(Me.GroupBox13)
        Me.GroupBox9.Controls.Add(Me.GroupBox12)
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(305, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(644, 343)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Test Script"
        '
        'GroupBox13
        '
        Me.GroupBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox13.Controls.Add(Me.RichTextBoxHistoryChat)
        Me.GroupBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox13.ForeColor = System.Drawing.Color.White
        Me.GroupBox13.Location = New System.Drawing.Point(3, 26)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(432, 225)
        Me.GroupBox13.TabIndex = 2
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "History"
        '
        'RichTextBoxHistoryChat
        '
        Me.RichTextBoxHistoryChat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxHistoryChat.Location = New System.Drawing.Point(3, 26)
        Me.RichTextBoxHistoryChat.Name = "RichTextBoxHistoryChat"
        Me.RichTextBoxHistoryChat.Size = New System.Drawing.Size(426, 196)
        Me.RichTextBoxHistoryChat.TabIndex = 0
        Me.RichTextBoxHistoryChat.Text = ""
        '
        'GroupBox12
        '
        Me.GroupBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox12.Controls.Add(Me.Label5)
        Me.GroupBox12.Controls.Add(Me.Label4)
        Me.GroupBox12.Controls.Add(Me.Label3)
        Me.GroupBox12.Controls.Add(Me.Label2)
        Me.GroupBox12.Controls.Add(Me.TextBoxResponse)
        Me.GroupBox12.Controls.Add(Me.TextBox1)
        Me.GroupBox12.Controls.Add(Me.TextBoxPrevResponse)
        Me.GroupBox12.Controls.Add(Me.TextBoxPrevUserInput)
        Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox12.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox12.Location = New System.Drawing.Point(435, 26)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(206, 225)
        Me.GroupBox12.TabIndex = 1
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Variables"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PrevUserInput"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PrevResponse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "UserInput"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Response"
        '
        'TextBoxResponse
        '
        Me.TextBoxResponse.Location = New System.Drawing.Point(3, 197)
        Me.TextBoxResponse.Name = "TextBoxResponse"
        Me.TextBoxResponse.Size = New System.Drawing.Size(200, 28)
        Me.TextBoxResponse.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 149)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 28)
        Me.TextBox1.TabIndex = 0
        '
        'TextBoxPrevResponse
        '
        Me.TextBoxPrevResponse.Location = New System.Drawing.Point(3, 95)
        Me.TextBoxPrevResponse.Name = "TextBoxPrevResponse"
        Me.TextBoxPrevResponse.Size = New System.Drawing.Size(200, 28)
        Me.TextBoxPrevResponse.TabIndex = 0
        '
        'TextBoxPrevUserInput
        '
        Me.TextBoxPrevUserInput.Location = New System.Drawing.Point(3, 46)
        Me.TextBoxPrevUserInput.Name = "TextBoxPrevUserInput"
        Me.TextBoxPrevUserInput.Size = New System.Drawing.Size(200, 28)
        Me.TextBoxPrevUserInput.TabIndex = 0
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Black
        Me.GroupBox10.Controls.Add(Me.TextBoxUserinput)
        Me.GroupBox10.Controls.Add(Me.GroupBox11)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox10.ForeColor = System.Drawing.Color.White
        Me.GroupBox10.Location = New System.Drawing.Point(3, 251)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(638, 89)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Userinput"
        '
        'TextBoxUserinput
        '
        Me.TextBoxUserinput.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxUserinput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxUserinput.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUserinput.Location = New System.Drawing.Point(3, 45)
        Me.TextBoxUserinput.Name = "TextBoxUserinput"
        Me.TextBoxUserinput.Size = New System.Drawing.Size(491, 41)
        Me.TextBoxUserinput.TabIndex = 1
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.Black
        Me.GroupBox11.Controls.Add(Me.ButtonSendQuery)
        Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox11.Location = New System.Drawing.Point(494, 26)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(141, 60)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        '
        'ToolStripMainMenu
        '
        Me.ToolStripMainMenu.AutoSize = False
        Me.ToolStripMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripMainMenu.ImageScalingSize = New System.Drawing.Size(60, 60)
        Me.ToolStripMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripSeparator5, Me.ToolStripButtonNewPlugin, Me.ToolStripSeparator1, Me.ToolStripButtonLoadPlugin, Me.ToolStripSplitButton1, Me.ToolStripButtonSavePlugin, Me.ToolStripSeparator2, Me.ToolStripButtonCompilePlugin, Me.ToolStripSeparator3, Me.ToolStripButtonCloseTab, Me.ToolStripSeparator4, Me.ToolStripButtonHelp, Me.ToolStripSeparator6, Me.ToolStripLabel2})
        Me.ToolStripMainMenu.Location = New System.Drawing.Point(4, 28)
        Me.ToolStripMainMenu.Name = "ToolStripMainMenu"
        Me.ToolStripMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripMainMenu.Size = New System.Drawing.Size(1133, 30)
        Me.ToolStripMainMenu.TabIndex = 0
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(0, 27)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonNewPlugin
        '
        Me.ToolStripButtonNewPlugin.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonNewPlugin.Image = Global.Chatbot_2020_Tutorial.My.Resources.Resources.Blue_end_left
        Me.ToolStripButtonNewPlugin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNewPlugin.Name = "ToolStripButtonNewPlugin"
        Me.ToolStripButtonNewPlugin.Size = New System.Drawing.Size(165, 27)
        Me.ToolStripButtonNewPlugin.Text = "New Plugin"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonLoadPlugin
        '
        Me.ToolStripButtonLoadPlugin.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonLoadPlugin.Image = Global.Chatbot_2020_Tutorial.My.Resources.Resources.Blue_end_left
        Me.ToolStripButtonLoadPlugin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonLoadPlugin.Name = "ToolStripButtonLoadPlugin"
        Me.ToolStripButtonLoadPlugin.Size = New System.Drawing.Size(166, 27)
        Me.ToolStripButtonLoadPlugin.Text = "Load Plugin"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonSavePlugin
        '
        Me.ToolStripButtonSavePlugin.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonSavePlugin.Image = Global.Chatbot_2020_Tutorial.My.Resources.Resources.Blue_end_left
        Me.ToolStripButtonSavePlugin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSavePlugin.Name = "ToolStripButtonSavePlugin"
        Me.ToolStripButtonSavePlugin.Size = New System.Drawing.Size(168, 27)
        Me.ToolStripButtonSavePlugin.Text = "Save Plugin"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonCompilePlugin
        '
        Me.ToolStripButtonCompilePlugin.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonCompilePlugin.Image = Global.Chatbot_2020_Tutorial.My.Resources.Resources.Blue_end_left
        Me.ToolStripButtonCompilePlugin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCompilePlugin.Name = "ToolStripButtonCompilePlugin"
        Me.ToolStripButtonCompilePlugin.Size = New System.Drawing.Size(191, 27)
        Me.ToolStripButtonCompilePlugin.Text = "Compile Plugin"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonCloseTab
        '
        Me.ToolStripButtonCloseTab.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonCloseTab.Image = Global.Chatbot_2020_Tutorial.My.Resources.Resources.Blue_end_left
        Me.ToolStripButtonCloseTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCloseTab.Name = "ToolStripButtonCloseTab"
        Me.ToolStripButtonCloseTab.Size = New System.Drawing.Size(157, 27)
        Me.ToolStripButtonCloseTab.Text = "Close Tab"
        Me.ToolStripButtonCloseTab.ToolTipText = "Close Tab"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonHelp
        '
        Me.ToolStripButtonHelp.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonHelp.Image = Global.Chatbot_2020_Tutorial.My.Resources.Resources.Blue_end_left
        Me.ToolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonHelp.Name = "ToolStripButtonHelp"
        Me.ToolStripButtonHelp.Size = New System.Drawing.Size(117, 27)
        Me.ToolStripButtonHelp.Text = "Help"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(0, 27)
        '
        'rcMenu
        '
        Me.rcMenu.BackColor = System.Drawing.SystemColors.ControlDark
        Me.rcMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.rcMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.NewScriptToolStripMenuItem})
        Me.rcMenu.Name = "rcMenu"
        Me.rcMenu.Size = New System.Drawing.Size(164, 186)
        '
        'ButtonSendQuery
        '
        Me.ButtonSendQuery.BackgroundImage = CType(resources.GetObject("ButtonSendQuery.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSendQuery.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonSendQuery.FlatAppearance.BorderSize = 0
        Me.ButtonSendQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSendQuery.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSendQuery.Image = CType(resources.GetObject("ButtonSendQuery.Image"), System.Drawing.Image)
        Me.ButtonSendQuery.Location = New System.Drawing.Point(3, 26)
        Me.ButtonSendQuery.Name = "ButtonSendQuery"
        Me.ButtonSendQuery.Size = New System.Drawing.Size(130, 31)
        Me.ButtonSendQuery.TabIndex = 2
        Me.ButtonSendQuery.Text = "Query"
        Me.ButtonSendQuery.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Black
        Me.GroupBox8.BackgroundImage = Global.Chatbot_2020_Tutorial.My.Resources.Resources.Right
        Me.GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox8.Location = New System.Drawing.Point(949, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(173, 343)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Black
        Me.GroupBox7.BackgroundImage = Global.Chatbot_2020_Tutorial.My.Resources.Resources.Bar2
        Me.GroupBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox7.Controls.Add(Me.GroupBox14)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(302, 343)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Scripts"
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.Black
        Me.GroupBox14.BackgroundImage = Global.Chatbot_2020_Tutorial.My.Resources.Resources.Left
        Me.GroupBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox14.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox14.ForeColor = System.Drawing.Color.White
        Me.GroupBox14.Location = New System.Drawing.Point(139, 26)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(160, 314)
        Me.GroupBox14.TabIndex = 0
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Current Script"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = Global.Chatbot_2020_Tutorial.My.Resources.Resources.BluPrint
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TextBoxPluginFileName)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(0, 226)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(1141, 93)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Compile Options"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Controls.Add(Me.ButtonAdd)
        Me.GroupBox6.Controls.Add(Me.ButtonRemoveRefference)
        Me.GroupBox6.Controls.Add(Me.ComboBoxRefferences)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(521, 32)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(616, 56)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Refferences"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackgroundImage = CType(resources.GetObject("ButtonAdd.BackgroundImage"), System.Drawing.Image)
        Me.ButtonAdd.FlatAppearance.BorderSize = 0
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Image = CType(resources.GetObject("ButtonAdd.Image"), System.Drawing.Image)
        Me.ButtonAdd.Location = New System.Drawing.Point(332, 11)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(130, 46)
        Me.ButtonAdd.TabIndex = 1
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonRemoveRefference
        '
        Me.ButtonRemoveRefference.BackgroundImage = CType(resources.GetObject("ButtonRemoveRefference.BackgroundImage"), System.Drawing.Image)
        Me.ButtonRemoveRefference.FlatAppearance.BorderSize = 0
        Me.ButtonRemoveRefference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRemoveRefference.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveRefference.Image = CType(resources.GetObject("ButtonRemoveRefference.Image"), System.Drawing.Image)
        Me.ButtonRemoveRefference.Location = New System.Drawing.Point(480, 11)
        Me.ButtonRemoveRefference.Name = "ButtonRemoveRefference"
        Me.ButtonRemoveRefference.Size = New System.Drawing.Size(130, 46)
        Me.ButtonRemoveRefference.TabIndex = 1
        Me.ButtonRemoveRefference.Text = "Remove"
        Me.ButtonRemoveRefference.UseVisualStyleBackColor = True
        '
        'ComboBoxRefferences
        '
        Me.ComboBoxRefferences.Dock = System.Windows.Forms.DockStyle.Left
        Me.ComboBoxRefferences.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxRefferences.FormattingEnabled = True
        Me.ComboBoxRefferences.Location = New System.Drawing.Point(3, 26)
        Me.ComboBoxRefferences.Name = "ComboBoxRefferences"
        Me.ComboBoxRefferences.Size = New System.Drawing.Size(303, 31)
        Me.ComboBoxRefferences.TabIndex = 0
        Me.ComboBoxRefferences.Tag = "refferences for Compiler"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plugin Name"
        '
        'TextBoxPluginFileName
        '
        Me.TextBoxPluginFileName.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPluginFileName.Location = New System.Drawing.Point(12, 50)
        Me.TextBoxPluginFileName.Name = "TextBoxPluginFileName"
        Me.TextBoxPluginFileName.Size = New System.Drawing.Size(452, 30)
        Me.TextBoxPluginFileName.TabIndex = 0
        Me.TextBoxPluginFileName.Tag = "Plugin Name"
        '
        'GroupBox15
        '
        Me.GroupBox15.BackgroundImage = CType(resources.GetObject("GroupBox15.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox15.Controls.Add(Me.TreeViewObjectSyntax)
        Me.GroupBox15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox15.ForeColor = System.Drawing.Color.White
        Me.GroupBox15.Location = New System.Drawing.Point(310, 32)
        Me.GroupBox15.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox15.Size = New System.Drawing.Size(441, 189)
        Me.GroupBox15.TabIndex = 2
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Refference Browser"
        '
        'TreeViewObjectSyntax
        '
        Me.TreeViewObjectSyntax.BackColor = System.Drawing.SystemColors.Info
        Me.TreeViewObjectSyntax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewObjectSyntax.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewObjectSyntax.Location = New System.Drawing.Point(4, 32)
        Me.TreeViewObjectSyntax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreeViewObjectSyntax.Name = "TreeViewObjectSyntax"
        Me.TreeViewObjectSyntax.Size = New System.Drawing.Size(433, 152)
        Me.TreeViewObjectSyntax.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.RichTextBoxInfo)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(751, 32)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(386, 189)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Info"
        '
        'RichTextBoxInfo
        '
        Me.RichTextBoxInfo.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxInfo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxInfo.Location = New System.Drawing.Point(4, 32)
        Me.RichTextBoxInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RichTextBoxInfo.Name = "RichTextBoxInfo"
        Me.RichTextBoxInfo.Size = New System.Drawing.Size(378, 152)
        Me.RichTextBoxInfo.TabIndex = 0
        Me.RichTextBoxInfo.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.ListBoxPlugins)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(4, 32)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(306, 189)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Plugins"
        '
        'ListBoxPlugins
        '
        Me.ListBoxPlugins.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxPlugins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxPlugins.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPlugins.FormattingEnabled = True
        Me.ListBoxPlugins.ItemHeight = 23
        Me.ListBoxPlugins.Location = New System.Drawing.Point(4, 32)
        Me.ListBoxPlugins.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBoxPlugins.Name = "ListBoxPlugins"
        Me.ListBoxPlugins.Size = New System.Drawing.Size(298, 152)
        Me.ListBoxPlugins.TabIndex = 0
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UndoToolStripMenuItem.BackgroundImage = CType(resources.GetObject("UndoToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.UndoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UndoToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UndoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RedoToolStripMenuItem.BackgroundImage = CType(resources.GetObject("RedoToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.RedoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RedoToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CutToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CutToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CutToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CopyToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CopyToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CopyToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PasteToolStripMenuItem.BackgroundImage = CType(resources.GetObject("PasteToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PasteToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SelectAllToolStripMenuItem.BackgroundImage = CType(resources.GetObject("SelectAllToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.SelectAllToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SelectAllToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectAllToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'NewScriptToolStripMenuItem
        '
        Me.NewScriptToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NewScriptToolStripMenuItem.BackgroundImage = CType(resources.GetObject("NewScriptToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.NewScriptToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewScriptToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewScriptToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NewScriptToolStripMenuItem.Name = "NewScriptToolStripMenuItem"
        Me.NewScriptToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.NewScriptToolStripMenuItem.Text = "New Script"
        '
        'FormPluginManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1141, 767)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPluginManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plugin Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TabDocumentBrowser.ResumeLayout(False)
        Me.VBWORKSPACE.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.ToolStripMainMenu.ResumeLayout(False)
        Me.ToolStripMainMenu.PerformLayout()
        Me.rcMenu.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RichTextBoxInfo As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBoxPlugins As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TabDocumentBrowser As TabControl
    Friend WithEvents VBWORKSPACE As TabPage
    Friend WithEvents ToolStripMainMenu As ToolStrip
    Friend WithEvents ToolStripButtonNewPlugin As ToolStripButton
    Friend WithEvents ToolStripButtonLoadPlugin As ToolStripButton
    Friend WithEvents ToolStripButtonSavePlugin As ToolStripButton
    Friend WithEvents ToolStripButtonCloseTab As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripButtonCompilePlugin As ToolStripButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ButtonRemoveRefference As Button
    Friend WithEvents ComboBoxRefferences As ComboBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents TextBoxUserinput As TextBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents ButtonSendQuery As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxResponse As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBoxPrevResponse As TextBox
    Friend WithEvents TextBoxPrevUserInput As TextBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents RichTextBoxHistoryChat As RichTextBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButtonHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents rcMenu As ContextMenuStrip
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPluginFileName As TextBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents TreeViewObjectSyntax As TreeView
End Class
