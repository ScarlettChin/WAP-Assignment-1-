Public Class frmDeleteStudent
    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

    End Sub

    Private Sub frmDeleteStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDatabaseDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.StudentDatabaseDataSet.Table)

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        TableBindingSource.MoveFirst()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If TableBindingSource.Position = TableBindingSource.Count - 1 Then
            TableBindingSource.MoveFirst()
        Else
            TableBindingSource.MoveNext()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If TableBindingSource.Position = 0 Then
            TableBindingSource.MoveLast()
        Else
            TableBindingSource.MovePrevious()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        TableBindingSource.MoveLast()
    End Sub

    Private Sub btnDeleteCancel_Click(sender As Object, e As EventArgs) Handles btnDeleteCancel.Click
        Dim dlgChosen As DialogResult
        If btnDeleteCancel.Text = "&Delete" Then
            dlgChosen = MessageBox.Show("Do you really want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If dlgChosen = DialogResult.Yes Then
                TableBindingSource.EndEdit()
                TableBindingSource.RemoveCurrent()
                TableTableAdapter.Update(StudentDatabaseDataSet.Table)
            End If
        ElseIf btnDeleteCancel.Text = "&Cancel" Then
            TableBindingSource.CancelEdit()
            btnFirst.Enabled = True
            btnNext.Enabled = True
            btnLast.Enabled = True
            btnPrevious.Enabled = True
            btnDeleteCancel.Text = "&Delete"
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

End Class