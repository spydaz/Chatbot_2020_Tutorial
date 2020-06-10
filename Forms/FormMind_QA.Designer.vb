<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMind_QA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMind_QA))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MindQADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MindQABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MindQADataSet = New Chatbot_2020_Tutorial.MindQADataSet()
        Me.MindQATableAdapter = New Chatbot_2020_Tutorial.MindQADataSetTableAdapters.MindQATableAdapter()
        Me.TableAdapterManager = New Chatbot_2020_Tutorial.MindQADataSetTableAdapters.TableAdapterManager()
        Me.MindQABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MindQABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.QUESTIONTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        QUESTIONLabel = New System.Windows.Forms.Label()
        AnswerLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MindQADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MindQABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MindQADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MindQABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MindQABindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'QUESTIONLabel
        '
        QUESTIONLabel.AutoSize = True
        QUESTIONLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        QUESTIONLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QUESTIONLabel.ForeColor = System.Drawing.Color.Snow
        QUESTIONLabel.Location = New System.Drawing.Point(13, 70)
        QUESTIONLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QUESTIONLabel.Name = "QUESTIONLabel"
        QUESTIONLabel.Size = New System.Drawing.Size(132, 25)
        QUESTIONLabel.TabIndex = 4
        QUESTIONLabel.Text = "QUESTION:"
        '
        'AnswerLabel
        '
        AnswerLabel.AutoSize = True
        AnswerLabel.BackColor = System.Drawing.Color.Black
        AnswerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AnswerLabel.ForeColor = System.Drawing.Color.Snow
        AnswerLabel.Location = New System.Drawing.Point(13, 102)
        AnswerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AnswerLabel.Name = "AnswerLabel"
        AnswerLabel.Size = New System.Drawing.Size(91, 25)
        AnswerLabel.TabIndex = 6
        AnswerLabel.Text = "Answer:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.MindQADataGridView)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 165)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1179, 447)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'MindQADataGridView
        '
        Me.MindQADataGridView.AutoGenerateColumns = False
        Me.MindQADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MindQADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.MindQADataGridView.DataSource = Me.MindQABindingSource
        Me.MindQADataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MindQADataGridView.Location = New System.Drawing.Point(4, 19)
        Me.MindQADataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.MindQADataGridView.Name = "MindQADataGridView"
        Me.MindQADataGridView.RowHeadersWidth = 51
        Me.MindQADataGridView.Size = New System.Drawing.Size(1171, 424)
        Me.MindQADataGridView.TabIndex = 0
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
        'MindQABindingSource
        '
        Me.MindQABindingSource.DataMember = "MindQA"
        Me.MindQABindingSource.DataSource = Me.MindQADataSet
        '
        'MindQADataSet
        '
        Me.MindQADataSet.DataSetName = "MindQADataSet"
        Me.MindQADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MindQATableAdapter
        '
        Me.MindQATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GeneralQuestionsTableAdapter = Nothing
        Me.TableAdapterManager.MindQATableAdapter = Me.MindQATableAdapter
        Me.TableAdapterManager.QAMINDTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Chatbot_2020_Tutorial.MindQADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MindQABindingNavigator
        '
        Me.MindQABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MindQABindingNavigator.BindingSource = Me.MindQABindingSource
        Me.MindQABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MindQABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MindQABindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MindQABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MindQABindingNavigatorSaveItem})
        Me.MindQABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MindQABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MindQABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MindQABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MindQABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MindQABindingNavigator.Name = "MindQABindingNavigator"
        Me.MindQABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MindQABindingNavigator.Size = New System.Drawing.Size(1179, 31)
        Me.MindQABindingNavigator.TabIndex = 2
        Me.MindQABindingNavigator.Text = "BindingNavigator1"
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
        'MindQABindingNavigatorSaveItem
        '
        Me.MindQABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MindQABindingNavigatorSaveItem.Image = CType(resources.GetObject("MindQABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MindQABindingNavigatorSaveItem.Name = "MindQABindingNavigatorSaveItem"
        Me.MindQABindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.MindQABindingNavigatorSaveItem.Text = "Save Data"
        '
        'QUESTIONTextBox
        '
        Me.QUESTIONTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QUESTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MindQABindingSource, "QUESTION", True))
        Me.QUESTIONTextBox.Location = New System.Drawing.Point(167, 73)
        Me.QUESTIONTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QUESTIONTextBox.Name = "QUESTIONTextBox"
        Me.QUESTIONTextBox.Size = New System.Drawing.Size(968, 22)
        Me.QUESTIONTextBox.TabIndex = 5
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnswerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MindQABindingSource, "Answer", True))
        Me.AnswerTextBox.Location = New System.Drawing.Point(167, 105)
        Me.AnswerTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(968, 22)
        Me.AnswerTextBox.TabIndex = 7
        '
        'FormMind_QA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chatbot_2020_Tutorial.My.Resources.Resources.BluPrint
        Me.ClientSize = New System.Drawing.Size(1179, 612)
        Me.Controls.Add(QUESTIONLabel)
        Me.Controls.Add(Me.QUESTIONTextBox)
        Me.Controls.Add(AnswerLabel)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.MindQABindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMind_QA"
        Me.Text = "Question & Answers MindQA"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.MindQADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MindQABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MindQADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MindQABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MindQABindingNavigator.ResumeLayout(False)
        Me.MindQABindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MindQADataSet As MindQADataSet
    Friend WithEvents MindQABindingSource As BindingSource
    Friend WithEvents MindQATableAdapter As MindQADataSetTableAdapters.MindQATableAdapter
    Friend WithEvents TableAdapterManager As MindQADataSetTableAdapters.TableAdapterManager
    Friend WithEvents MindQABindingNavigator As BindingNavigator
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
    Friend WithEvents MindQABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MindQADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents QUESTIONTextBox As TextBox
    Friend WithEvents AnswerTextBox As TextBox
End Class
