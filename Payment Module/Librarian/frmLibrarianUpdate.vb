Public Class frmLibrarianUpdate

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMainMenu.switchPanel(frmLibrarianView)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            frmLibrarianView.LibrarianTableAdapter.DeleteQuery(txtLibrarianId.Text)
            frmLibrarianView.LibrarianTableAdapter.Fill(frmLibrarianView.LibraryDatabaseDataSet1.Librarian)
            MessageBox.Show("Delete librarian succesfully", "Success")
            frmMainMenu.switchPanel(frmLibrarianView)
        Catch ex As Exception
            MessageBox.Show("Something wrong")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If comboStatus.SelectedItem = "Resigned" Then
                frmLibrarianView.LibrarianTableAdapter.UpdateQuery(txtName.Text, txtAddress.Text, dtpBirthDate.Value, txtEmail.Text, txtIc.Text, txtPhoneNumber.Text,
            comboGender.Text, comboStatus.Text, txtSalary.Text, comboPosition.Text, comboWorkLocation.Text, dtpHireDate.Value, dtpLeaveDate.Value, txtLibrarianId.Text)
            Else
                frmLibrarianView.LibrarianTableAdapter.UpdateQuery1(txtName.Text, txtAddress.Text, dtpBirthDate.Value, txtEmail.Text, txtIc.Text, txtPhoneNumber.Text,
            comboGender.Text, comboStatus.Text, txtSalary.Text, comboPosition.Text, comboWorkLocation.Text, dtpHireDate.Value, txtLibrarianId.Text)

            End If

            If comboPosition.SelectedItem = "Manager" Then
                UserTableAdapter.UpdateLibrarianQuery(txtUsername.Text, txtPassword.Text, 0, txtLibrarianId.Text)
            Else
                UserTableAdapter.UpdateLibrarianQuery(txtUsername.Text, txtPassword.Text, 2, txtLibrarianId.Text)
            End If
            'update user table

            frmLibrarianView.LibrarianTableAdapter.Fill(frmLibrarianView.LibraryDatabaseDataSet1.Librarian)
            MessageBox.Show("Updated librarian succesfully", "Success")
            frmMainMenu.switchPanel(frmLibrarianView)
        Catch ex As Exception
            MessageBox.Show("Something wrong")
        End Try
    End Sub

    Private Sub frmLibrarianUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.LibraryDatabaseDataSet1.User)

    End Sub

End Class