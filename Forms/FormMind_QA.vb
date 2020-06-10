Public Class FormMind_QA
    Private Sub MindQABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MindQABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MindQABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MindQADataSet)

    End Sub

    Private Sub FormDataEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MindQADataSet.MindQA' table. You can move, or remove it, as needed.
        Me.MindQATableAdapter.Fill(Me.MindQADataSet.MindQA)

    End Sub
End Class