Public Class frmStudentCreate

    Private Sub frmStudentCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.LibraryDatabaseDataSet1.User)
        'TODO: This line of code loads data into the 'StudentDatabaseDataSet.Table' table. You can move, or remove it, as needed.

    End Sub

    Private Sub btnAddCreate_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMainMenu.switchPanel(frmStudentView)

    End Sub

    Private Sub btnAdd_Click_(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            frmStudentView.StudentTableAdapter.InsertQuery(txtStudentId.Text, txtStudentName.Text, Integer.Parse(txtAge.Text), comboGender.SelectedItem, comboCourse.SelectedItem)
            frmStudentView.StudentTableAdapter.Fill(frmStudentView.LibraryDatabaseDataSet1.Student)

            'add into user table
            UserTableAdapter.InsertQuery(txtUsername.Text, txtPassword.Text, 1, txtStudentId.Text, 0)

            MessageBox.Show("Create new student succesfully", "Success")
            frmMainMenu.switchPanel(frmStudentView)
        Catch ex As Exception
            MessageBox.Show("Something wrong")
        End Try
    End Sub

End Class