Public Class frmLibrarianCreate

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMainMenu.switchPanel(frmLibrarianView)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            frmLibrarianView.LibrarianTableAdapter.InsertQuery(txtName.Text, txtAddress.Text, dtpBirthDate.Value, txtEmail.Text, txtIc.Text, txtPhoneNumber.Text,
            comboGender.SelectedItem, "Active", txtSalary.Text, comboPosition.SelectedItem, comboWorkLocation.SelectedItem, dtpHireDate.Value)
            frmLibrarianView.LibrarianTableAdapter.Fill(frmLibrarianView.LibraryDatabaseDataSet1.Librarian)
            Dim dataLibrarian As DataTable = frmLibrarianView.LibrarianTableAdapter.GetData()

            Dim librarianId As Integer = dataLibrarian.AsEnumerable.Last().Item(0)

            If comboPosition.SelectedItem = "Manager" Then
                UserTableAdapter.InsertQuery(txtUsername.Text, txtPassword.Text, 0, Nothing, librarianId)
            Else
                UserTableAdapter.InsertQuery(txtUsername.Text, txtPassword.Text, 2, Nothing, librarianId)
            End If

            'add into user table

            MessageBox.Show("Create new librarian succesfully", "Success")
            frmMainMenu.switchPanel(frmLibrarianView)
        Catch ex As Exception
            MessageBox.Show("Something wrong")
        End Try
    End Sub

    Private Sub frmLibrarianCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.User' table. You can move, or remove it, as needed.

    End Sub

End Class