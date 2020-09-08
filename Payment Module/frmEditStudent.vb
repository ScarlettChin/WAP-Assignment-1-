Public Class frmEditStudent

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

    End Sub

    Private Sub frmEditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click
        If btnEditSave.Text = "&Edit" Then
            StudentNameTextBox.ReadOnly = False
            StudentIdTextBox.ReadOnly = False
            AgeTextBox.ReadOnly = False
            GenderComboBox.Enabled = True
            CourseComboBox.Enabled = True
            btnFirst.Enabled = False
            btnNext.Enabled = False
            btnLast.Enabled = False
            btnPrevious.Enabled = False
            btnReturn.Enabled = False
            btnEditSave.Text = "&Save"
        Else
            btnEditSave.Text = "&Edit"
            StudentNameTextBox.ReadOnly = True
            StudentIdTextBox.ReadOnly = True
            AgeTextBox.ReadOnly = True
            GenderComboBox.Enabled = False
            CourseComboBox.Enabled = False
            btnFirst.Enabled = True
            btnNext.Enabled = True
            btnLast.Enabled = True
            btnPrevious.Enabled = True
            btnReturn.Enabled = True
            TableBindingSource.EndEdit()
            TableTableAdapter.Update(StudentDatabaseDataSet)
            MessageBox.Show("Do you really want to Edit this record?", "Edit Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnEditSave.Text = "&Edit"
        StudentNameTextBox.ReadOnly = True
        StudentIdTextBox.ReadOnly = True
        AgeTextBox.ReadOnly = True
        GenderComboBox.Enabled = False
        CourseComboBox.Enabled = False
        btnFirst.Enabled = True
        btnNext.Enabled = True
        btnLast.Enabled = True
        btnPrevious.Enabled = True
        btnReturn.Enabled = True
        TableBindingSource.CancelEdit()
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
End Class