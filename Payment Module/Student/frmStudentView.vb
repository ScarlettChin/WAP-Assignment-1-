Public Class frmStudentView

    Private Sub frmStudentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.LibraryDatabaseDataSet1.Student)
        Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.MultiSelect = False
    End Sub

    Private Sub btnAddStudents_Click(sender As Object, e As EventArgs) Handles btnAddStudents.Click
        frmMainMenu.switchPanel(frmStudentCreate)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            'TODO - Button Clicked - Execute Code Here
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            frmStudentEdit.txtStudentId.Text = row.Cells(0).Value.ToString
            frmStudentEdit.txtStudentName.Text = row.Cells(1).Value.ToString
            frmStudentEdit.txtAge.Text = row.Cells(2).Value.ToString
            frmStudentEdit.comboGender.Text = row.Cells(3).Value.ToString
            frmStudentEdit.comboCourse.Text = row.Cells(4).Value.ToString

            Dim userData As DataTable = frmStudentEdit.UserTableAdapter.GetDataByStudentId(row.Cells(0).Value.ToString)
            If userData.Rows.Count > 0 Then
                frmStudentEdit.txtUsername.Text = userData.Rows(0).Item(1).ToString()
                frmStudentEdit.txtPassword.Text = userData.Rows(0).Item(2).ToString()
            End If

            frmMainMenu.switchPanel(frmStudentEdit)
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        StudentTableAdapter.SearchBy(LibraryDatabaseDataSet1.Student, "%" + txtStudentName.Text + "%")
    End Sub

End Class