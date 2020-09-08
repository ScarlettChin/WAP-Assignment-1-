Public Class frmStudentEdit

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMainMenu.switchPanel(frmStudentView)
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            frmStudentView.StudentTableAdapter.UpdateQuery(txtStudentName.Text, Integer.Parse(txtAge.Text), comboGender.SelectedItem, comboCourse.SelectedItem, txtStudentId.Text)
            frmStudentView.StudentTableAdapter.Fill(frmStudentView.LibraryDatabaseDataSet1.Student)

            'update user table
            UserTableAdapter.UpdateStudentQuery(txtUsername.Text, txtPassword.Text, 1, txtStudentId.Text)

            MessageBox.Show("Update student succesfully", "Success")
            frmMainMenu.switchPanel(frmStudentView)
        Catch ex As Exception
            MessageBox.Show("Something wrong")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            frmStudentView.StudentTableAdapter.DeleteQuery(txtStudentId.Text)
            frmStudentView.StudentTableAdapter.Fill(frmStudentView.LibraryDatabaseDataSet1.Student)
            MessageBox.Show("Student deleted succesfully", "Success")
            frmMainMenu.switchPanel(frmStudentView)
        Catch ex As Exception
            MessageBox.Show("Something wrong")
        End Try
    End Sub

    Private Sub frmStudentEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.LibraryDatabaseDataSet1.User)

    End Sub

End Class