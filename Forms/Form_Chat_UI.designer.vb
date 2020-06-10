Imports System.Windows.Forms


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Chat_UI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Chat_UI))
        Me.TextIn = New System.Windows.Forms.TextBox()
        Me.TextOut = New System.Windows.Forms.TextBox()
        Me.Button_Enter = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonCreatePlugin = New System.Windows.Forms.Button()
        Me.ButtonMindQA = New System.Windows.Forms.Button()
        Me.ButtonQA_Mind = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextIn
        '
        Me.TextIn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextIn.Location = New System.Drawing.Point(17, 242)
        Me.TextIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextIn.Name = "TextIn"
        Me.TextIn.Size = New System.Drawing.Size(677, 38)
        Me.TextIn.TabIndex = 0
        '
        'TextOut
        '
        Me.TextOut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextOut.BackColor = System.Drawing.SystemColors.Info
        Me.TextOut.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextOut.Location = New System.Drawing.Point(299, 23)
        Me.TextOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextOut.Multiline = True
        Me.TextOut.Name = "TextOut"
        Me.TextOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextOut.Size = New System.Drawing.Size(513, 197)
        Me.TextOut.TabIndex = 1
        '
        'Button_Enter
        '
        Me.Button_Enter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Enter.BackColor = System.Drawing.Color.DimGray
        Me.Button_Enter.BackgroundImage = CType(resources.GetObject("Button_Enter.BackgroundImage"), System.Drawing.Image)
        Me.Button_Enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Enter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Enter.Location = New System.Drawing.Point(713, 236)
        Me.Button_Enter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_Enter.Name = "Button_Enter"
        Me.Button_Enter.Size = New System.Drawing.Size(100, 34)
        Me.Button_Enter.TabIndex = 2
        Me.Button_Enter.Text = "Talk"
        Me.Button_Enter.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.BackgroundImage = Global.Chatbot_2020_Tutorial.My.Resources.Resources.Logo_UFP
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(279, 207)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.ButtonCreatePlugin)
        Me.GroupBox2.Controls.Add(Me.ButtonMindQA)
        Me.GroupBox2.Controls.Add(Me.ButtonQA_Mind)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(0, 290)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(827, 52)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tools"
        '
        'ButtonCreatePlugin
        '
        Me.ButtonCreatePlugin.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCreatePlugin.ForeColor = System.Drawing.Color.Black
        Me.ButtonCreatePlugin.Location = New System.Drawing.Point(17, 17)
        Me.ButtonCreatePlugin.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCreatePlugin.Name = "ButtonCreatePlugin"
        Me.ButtonCreatePlugin.Size = New System.Drawing.Size(139, 28)
        Me.ButtonCreatePlugin.TabIndex = 8
        Me.ButtonCreatePlugin.Text = "Create Plug-in"
        Me.ButtonCreatePlugin.UseVisualStyleBackColor = True
        '
        'ButtonMindQA
        '
        Me.ButtonMindQA.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMindQA.ForeColor = System.Drawing.Color.Black
        Me.ButtonMindQA.Location = New System.Drawing.Point(272, 17)
        Me.ButtonMindQA.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonMindQA.Name = "ButtonMindQA"
        Me.ButtonMindQA.Size = New System.Drawing.Size(100, 28)
        Me.ButtonMindQA.TabIndex = 8
        Me.ButtonMindQA.Text = "Mind QA"
        Me.ButtonMindQA.UseVisualStyleBackColor = True
        '
        'ButtonQA_Mind
        '
        Me.ButtonQA_Mind.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQA_Mind.ForeColor = System.Drawing.Color.Black
        Me.ButtonQA_Mind.Location = New System.Drawing.Point(164, 17)
        Me.ButtonQA_Mind.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonQA_Mind.Name = "ButtonQA_Mind"
        Me.ButtonQA_Mind.Size = New System.Drawing.Size(100, 28)
        Me.ButtonQA_Mind.TabIndex = 8
        Me.ButtonQA_Mind.Text = "QA Mind"
        Me.ButtonQA_Mind.UseVisualStyleBackColor = True
        '
        'Form_Chat_UI
        '
        Me.AcceptButton = Me.Button_Enter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Chatbot_2020_Tutorial.My.Resources.Resources.BluPrint
        Me.ClientSize = New System.Drawing.Size(827, 342)
        Me.Controls.Add(Me.TextIn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Enter)
        Me.Controls.Add(Me.TextOut)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Chat_UI"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Chat_UI"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextIn As TextBox
    Friend WithEvents TextOut As TextBox
    Friend WithEvents Button_Enter As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonCreatePlugin As Button
    Friend WithEvents ButtonMindQA As Button
    Friend WithEvents ButtonQA_Mind As Button
End Class
