Public Class frmPaymentView

    Private Sub frmPaymentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.LibraryDatabaseDataSet1.Payment)
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.Payment1' table. You can move, or remove it, as needed.
        Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.MultiSelect = False

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.PaymentTableAdapter.SearchBy(Me.LibraryDatabaseDataSet1.Payment, txtSearchValue.Text)
    End Sub

    Private Sub buttonAddBooks_Click(sender As Object, e As EventArgs) Handles buttonAddBooks.Click
        frmMainMenu.switchPanel(frmPaymentCreate)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            'TODO - Button Clicked - Execute Code Here
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            frmPaymentEdit.lblPaymentId.Text = row.Cells(0).Value.ToString
            frmPaymentEdit.txtIssueId.Text = row.Cells(1).Value.ToString
            frmPaymentEdit.txtISBN.Text = row.Cells(2).Value.ToString
            frmPaymentEdit.cboFineType.SelectedItem = row.Cells(3).Value.ToString
            frmPaymentEdit.cboFineType.Text = row.Cells(3).Value.ToString
            frmPaymentEdit.txtDays.Text = row.Cells(4).Value.ToString
            frmPaymentEdit.txtID.Text = row.Cells(5).Value.ToString
            'frmPaymentEdit.lblTotalPay.Text = Math.Round(row.Cells(6).Value, 2).ToString
            frmPaymentEdit.IsPay = row.Cells(7).Value.ToString
            frmPaymentEdit.DateTimePicker1.Text = row.Cells(8).Value.ToString
            frmPaymentEdit.lblLibrarianId.Text = row.Cells(9).Value.ToString

            frmMainMenu.switchPanel(frmPaymentEdit)
        End If

    End Sub

End Class