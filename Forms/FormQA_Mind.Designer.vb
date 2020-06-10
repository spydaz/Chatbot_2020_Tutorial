<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQA_Mind
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim QUESTIONLabel As System.Windows.Forms.Label
        Dim AnswerLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormQA_Mind))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QAMINDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QAMINDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MindQADataSet = New Chatbot_2020_Tutorial.MindQADataSet()
        Me.QAMINDTableAdapter = New Chatbot_2020_Tutorial.MindQADataSetTableAdapters.QAMINDTableAdapter()
        Me.TableAdapterManager = New Chatbot_2020_Tutorial.MindQADataSetTableAdapters.TableAdapterManager()
        Me.QAMINDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QAMINDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.QUESTIONTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        QUESTIONLabel = New System.Windows.Forms.Label()
        AnswerLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QAMINDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QAMINDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MindQADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QAMINDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QAMINDBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'QUESTIONLabel
        '
        QUESTIONLabel.AutoSize = True
        QUESTIONLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        QUESTIONLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QUESTIONLabel.ForeColor = System.Drawing.Color.White
        QUESTIONLabel.Location = New System.Drawing.Point(16, 65)
        QUESTIONLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QUESTIONLabel.Name = "QUESTIONLabel"
        QUESTIONLabel.Size = New System.Drawing.Size(132, 25)
        QUESTIONLabel.TabIndex = 2
        QUESTIONLabel.Text = "QUESTION:"
        '
        'AnswerLabel
        '
        AnswerLabel.AutoSize = True
        AnswerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        AnswerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AnswerLabel.ForeColor = System.Drawing.Color.White
        AnswerLabel.Location = New System.Drawing.Point(16, 97)
        AnswerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AnswerLabel.Name = "AnswerLabel"
        AnswerLabel.Size = New System.Drawing.Size(91, 25)
        AnswerLabel.TabIndex = 4
        AnswerLabel.Text = "Answer:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.QAMINDDataGridView)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 149)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1067, 400)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'QAMINDDataGridView
        '
        Me.QAMINDDataGridView.AutoGenerateColumns = False
        Me.QAMINDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QAMINDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.QAMINDDataGridView.DataSource = Me.QAMINDBindingSource
        Me.QAMINDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QAMINDDataGridView.Location = New System.Drawing.Point(4, 19)
        Me.QAMINDDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.QAMINDDataGridView.Name = "QAMINDDataGridView"
        Me.QAMINDDataGridView.RowHeadersWidth = 51
        Me.QAMINDDataGridView.Size = New System.Drawing.Size(1059, 377)
        Me.QAMINDDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "QUESTION"
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "QUESTION"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Answer"
        Me.DataGridViewTextBoxColumn2.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Answer"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'QAMINDBindingSource
        '
        Me.QAMINDBindingSource.DataMember = "QAMIND"
        Me.QAMINDBindingSource.DataSource = Me.MindQADataSet
        '
        'MindQADataSet
        '
        Me.MindQADataSet.DataSetName = "MindQADataSet"
        Me.MindQADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QAMINDTableAdapter
        '
        Me.QAMINDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GeneralQuestionsTableAdapter = Nothing
        Me.TableAdapterManager.MindQATableAdapter = Nothing
        Me.TableAdapterManager.QAMINDTableAdapter = Me.QAMINDTableAdapter
        Me.TableAdapterManager.UpdateOrder = Chatbot_2020_Tutorial.MindQADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QAMINDBindingNavigator
        '
        Me.QAMINDBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QAMINDBindingNavigator.BindingSource = Me.QAMINDBindingSource
        Me.QAMINDBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.QAMINDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QAMINDBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.QAMINDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QAMINDBindingNavigatorSaveItem})
        Me.QAMINDBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.QAMINDBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.QAMINDBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.QAMINDBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.QAMINDBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.QAMINDBindingNavigator.Name = "QAMINDBindingNavigator"
        Me.QAMINDBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.QAMINDBindingNavigator.Size = New System.Drawing.Size(1067, 31)
        Me.QAMINDBindingNavigator.TabIndex = 1
        Me.QAMINDBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(56, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'QAMINDBindingNavigatorSaveItem
        '
        Me.QAMINDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QAMINDBindingNavigatorSaveItem.Image = CType(resources.GetObject("QAMINDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QAMINDBindingNavigatorSaveItem.Name = "QAMINDBindingNavigatorSaveItem"
        Me.QAMINDBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.QAMINDBindingNavigatorSaveItem.Text = "Save Data"
        '
        'QUESTIONTextBox
        '
        Me.QUESTIONTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QUESTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QAMINDBindingSource, "QUESTION", True))
        Me.QUESTIONTextBox.Location = New System.Drawing.Point(150, 65)
        Me.QUESTIONTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QUESTIONTextBox.Name = "QUESTIONTextBox"
        Me.QUESTIONTextBox.Size = New System.Drawing.Size(889, 22)
        Me.QUESTIONTextBox.TabIndex = 3
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnswerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QAMINDBindingSource, "Answer", True))
        Me.AnswerTextBox.Location = New System.Drawing.Point(150, 97)
        Me.AnswerTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(889, 22)
        Me.AnswerTextBox.TabIndex = 5
        '
        'FormQA_Mind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chatbot_2020_Tutorial.My.Resources.Resources.BluPrint
        Me.ClientSize = New System.Drawing.Size(1067, 549)
        Me.Controls.Add(QUESTIONLabel)
        Me.Controls.Add(Me.QUESTIONTextBox)
        Me.Controls.Add(AnswerLabel)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.QAMINDBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormQA_Mind"
        Me.Text = "Question & Answers QA_MIND"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.QAMINDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QAMINDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MindQADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QAMINDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QAMINDBindingNavigator.ResumeLayout(False)
        Me.QAMINDBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MindQADataSet As MindQADataSet
    Friend WithEvents QAMINDBindingSource As BindingSource
    Friend WithEvents QAMINDTableAdapter As MindQADataSetTableAdapters.QAMINDTableAdapter
    Friend WithEvents TableAdapterManager As MindQADataSetTableAdapters.TableAdapterManager
    Friend WithEvents QAMINDBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents QAMINDBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents QUESTIONTextBox As TextBox
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents QAMINDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
