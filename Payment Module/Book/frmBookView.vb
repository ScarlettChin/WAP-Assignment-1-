Public Class frmBookView

    Private Sub frmBookView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.LibraryDatabaseDataSet1.Book)
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.Book' table. You can move, or remove it, as needed.
        Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.MultiSelect = False
        If statusComboBox.Items.Count > 0 Then
            statusComboBox.SelectedIndex = 0    ' The first item has index 0 '

        End If
        If frmMainMenu.Role = 1 Then
            DataGridView1.Columns("Action").Visible = False
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        'If e.RowIndex >= 0 Then
        '    Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        '    If row.Cells(4).Value.ToString = "Borrowed" Then
        '        btnReturn.Text = "Return"
        '    Else
        '        btnReturn.Text = "Borrow"
        '    End If
        'End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If statusComboBox.SelectedItem = "All" Then
            BookTableAdapter.SearchByBookNameOnly(Me.LibraryDatabaseDataSet1.Book, "%" + txtName.Text + "%")
        Else
            BookTableAdapter.SearchBy(Me.LibraryDatabaseDataSet1.Book, "%" + txtName.Text + "%", statusComboBox.SelectedItem)

        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            'TODO - Button Clicked - Execute Code Here
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            frmBookEdit.txtISBN.Text = row.Cells(0).Value.ToString
            frmBookEdit.txtName.Text = row.Cells(1).Value.ToString
            frmBookEdit.txtAuthor.Text = row.Cells(2).Value.ToString
            frmBookEdit.cmbCategory.Text = row.Cells(3).Value.ToString
            frmBookEdit.txtPublisher.Text = row.Cells(4).Value.ToString
            frmBookEdit.txtPrice.Text = Math.Round(row.Cells(5).Value, 2).ToString
            frmBookEdit.txtStatus.Text = row.Cells(6).Value.ToString
            frmBookEdit.txtStudentId.Text = row.Cells(7).Value.ToString

            If row.Cells(6).Value.ToString = "Available" Then
                frmBookEdit.StudentTableAdapter.Fill(frmBookEdit.LibraryDatabaseDataSet1.Student)
                frmBookEdit.btnReturn.Visible = False
                frmBookEdit.btnIssue.Visible = True
                frmBookEdit.DataGridView1.Enabled = True
            Else
                frmBookEdit.btnReturn.Visible = True
                frmBookEdit.btnIssue.Visible = False
                frmBookEdit.DataGridView1.Enabled = False
                frmBookEdit.txtStatus.ReadOnly = True
                frmBookEdit.StudentTableAdapter.FillByStudentId(frmBookEdit.LibraryDatabaseDataSet1.Student, row.Cells(7).Value.ToString)
            End If

            frmMainMenu.switchPanel(frmBookEdit)
        End If

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonAddBooks.Click
        frmMainMenu.switchPanel(frmBookCreate)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BookBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles BookBindingSource.CurrentChanged

    End Sub

End Class