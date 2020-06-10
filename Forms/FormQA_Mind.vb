Public Class FormQA_Mind
    Private Sub QAMINDBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles QAMINDBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.QAMINDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MindQADataSet)

    End Sub

    Private Sub FormQA_Mind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MindQADataSet.QAMIND' table. You can move, or remove it, as needed.
        Me.QAMINDTableAdapter.Fill(Me.MindQADataSet.QAMIND)

    End Sub
End Class