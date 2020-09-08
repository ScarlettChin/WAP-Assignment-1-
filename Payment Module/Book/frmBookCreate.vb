Public Class frmBookCreate

    Private Sub frmBookCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookDataSet1.Book' table. You can move, or remove it, as needed.
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            frmBookView.BookTableAdapter.InsertQuery(txtName.Text, txtAuthor.Text, cmbCategory.Text, txtPublisher.Text, Decimal.Parse(txtPrice.Text), "Available")
            frmBookView.BookTableAdapter.Fill(frmBookView.LibraryDatabaseDataSet1.Book)

            MessageBox.Show("Create new book succesfully", "Success")
            frmMainMenu.switchPanel(frmBookView)
        Catch ex As Exception
            MessageBox.Show("Something wrong")
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMainMenu.switchPanel(frmBookView)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        'validation data

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

End Class