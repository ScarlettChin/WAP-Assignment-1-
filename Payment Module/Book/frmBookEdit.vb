Public Class frmBookEdit

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.Student' table. You can move, or remove it, as needed.
        Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.MultiSelect = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim dlgResult As DialogResult
        'dlgResult = MessageBox.Show("Do you really want to edit this record?", "Edit", MessageBoxButtons.YesNo)
        'If dlgResult = DialogResult.Yes Then
        '    txtISBN.ReadOnly = True
        '    txtName.ReadOnly = True
        '    txtAuthor.ReadOnly = True
        '    cmbCategory.Enabled = False
        '    txtPublisher.ReadOnly = True
        '    txtPrice.ReadOnly = True
        '    btnSave.Enabled = False
        'Else
        'End If
        Try
            frmBookView.BookTableAdapter.UpdateQuery(txtName.Text, txtAuthor.Text, cmbCategory.Text, txtPublisher.Text, Decimal.Parse(txtPrice.Text), txtStatus.Text, txtStudentId.Text, txtISBN.Text)
            frmBookView.BookTableAdapter.Fill(frmBookView.LibraryDatabaseDataSet1.Book)
            MessageBox.Show("Update book succesfully", "Success")
            frmMainMenu.switchPanel(frmBookView)
        Catch ex As Exception
            MessageBox.Show("Something wrong")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMainMenu.switchPanel(frmBookView)
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtStudentId.Text = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            frmBookView.BookTableAdapter.DeleteQuery(txtISBN.Text)
            frmBookView.BookTableAdapter.Fill(frmBookView.LibraryDatabaseDataSet1.Book)
            MessageBox.Show("Deleted book succesfully", "Success")
            frmMainMenu.switchPanel(frmBookView)
        Catch ex As Exception
            MessageBox.Show("Something wrong")
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Try
            frmBookView.BookTableAdapter.UpdateQuery(txtName.Text, txtAuthor.Text, cmbCategory.Text, txtPublisher.Text, Decimal.Parse(txtPrice.Text), "Available", "", Integer.Parse(txtISBN.Text))
            frmBookView.BookTableAdapter.Fill(frmBookView.LibraryDatabaseDataSet1.Book)
            MessageBox.Show("Book succesfully returned", "Success")
            frmMainMenu.switchPanel(frmBookView)
        Catch ex As Exception
            MessageBox.Show("Something wrong")
        End Try
    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click
        Try
            frmBookView.BookTableAdapter.UpdateQuery(txtName.Text, txtAuthor.Text, cmbCategory.Text, txtPublisher.Text, Decimal.Parse(txtPrice.Text), "Borrowed", txtStudentId.Text, Integer.Parse(txtISBN.Text))
            frmBookView.BookTableAdapter.Fill(frmBookView.LibraryDatabaseDataSet1.Book)
            MessageBox.Show("Book succesfully issued", "Success")
            frmMainMenu.switchPanel(frmBookView)
        Catch ex As Exception
            MessageBox.Show("Something wrong")
        End Try
    End Sub

End Class