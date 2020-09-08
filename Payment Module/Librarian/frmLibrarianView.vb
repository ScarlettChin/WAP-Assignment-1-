Public Class frmLibrarianView

    Private Sub frmLibrarianView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.Librarian' table. You can move, or remove it, as needed.
        Me.LibrarianTableAdapter.Fill(Me.LibraryDatabaseDataSet1.Librarian)
        Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.MultiSelect = False

    End Sub

    Private Sub btnAddStudents_Click(sender As Object, e As EventArgs) Handles btnAddStudents.Click
        frmMainMenu.switchPanel(frmLibrarianCreate)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LibrarianTableAdapter.SearchBy(LibraryDatabaseDataSet1.Librarian, "%" + txtName.Text + "%")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            'TODO - Button Clicked - Execute Code Here
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            frmLibrarianUpdate.txtLibrarianId.Text = row.Cells(0).Value.ToString
            frmLibrarianUpdate.txtName.Text = row.Cells(1).Value.ToString
            frmLibrarianUpdate.txtAddress.Text = row.Cells(2).Value.ToString
            frmLibrarianUpdate.dtpBirthDate.Text = row.Cells(3).Value.ToString
            frmLibrarianUpdate.txtEmail.Text = row.Cells(4).Value.ToString
            frmLibrarianUpdate.txtIc.Text = row.Cells(5).Value.ToString
            frmLibrarianUpdate.txtPhoneNumber.Text = row.Cells(6).Value.ToString
            frmLibrarianUpdate.comboGender.Text = row.Cells(7).Value.ToString
            frmLibrarianUpdate.comboStatus.Text = row.Cells(8).Value.ToString
            frmLibrarianUpdate.txtSalary.Text = row.Cells(9).Value.ToString
            frmLibrarianUpdate.comboPosition.Text = row.Cells(10).Value.ToString
            frmLibrarianUpdate.comboWorkLocation.Text = row.Cells(11).Value.ToString
            frmLibrarianUpdate.dtpHireDate.Value = row.Cells(12).Value.ToString
            If row.Cells(13).Value.ToString <> "" Then
                frmLibrarianUpdate.dtpLeaveDate.Value = row.Cells(13).Value.ToString
            End If

            Dim userData As DataTable = frmLibrarianUpdate.UserTableAdapter.GetDataByLibrarianId(row.Cells(0).Value.ToString)
            If userData.Rows.Count > 0 Then
                frmLibrarianUpdate.txtUsername.Text = userData.Rows(0).Item(1).ToString()
                frmLibrarianUpdate.txtPassword.Text = userData.Rows(0).Item(2).ToString()
            End If

            frmMainMenu.switchPanel(frmLibrarianUpdate)
        End If

    End Sub

End Class