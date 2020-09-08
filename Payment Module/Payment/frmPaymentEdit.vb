Public Class frmPaymentEdit
    Public IsPay As Boolean
    Const decLateReturn As Decimal = 2D
    Const decDmgBook As Decimal = 15D
    Const decLostBook As Decimal = 50D
    Dim decTotalPay As Decimal
    Dim isPaid As Boolean

    Private Sub CalLateReturn(ByVal intDays As Integer)
        decTotalPay = intDays * decLateReturn
        lblTotalPay.Text = decTotalPay.ToString("C2")
    End Sub

    Private Sub CalDmgBook()
        decTotalPay = decDmgBook
        lblTotalPay.Text = decTotalPay.ToString("C2")
    End Sub

    Private Sub CalLostBook()
        decTotalPay = decLostBook
        lblTotalPay.Text = decTotalPay.ToString("C2")
    End Sub

    Private Sub CalChange(ByVal decPaid As Decimal)
        Dim decChange As Decimal

        decChange = decTotalPay - decPaid
        decChange = Math.Abs(decChange)
        If (decPaid < decTotalPay) Then
            MessageBox.Show(“Please input the valid paid value.", “Error", MessageBoxButtons.OK)
            txtPaid.Focus()
            txtPaid.SelectAll()
            lblChange.Text = ""
        Else
            lblChange.Text = decChange.ToString("C2")
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intDays As Integer
        If (cboFineType.SelectedIndex = 0) Then

            Try
                intDays = Integer.Parse(txtDays.Text)
                CalLateReturn(intDays)
            Catch ex As Exception
                MessageBox.Show(“Please enter a valid input.", “Error", MessageBoxButtons.OK)
                txtDays.SelectAll()
                txtDays.Focus()
            End Try

        ElseIf (cboFineType.SelectedIndex = 1) Then

            CalDmgBook()

        ElseIf (cboFineType.SelectedIndex = 2) Then

            CalLostBook()

        ElseIf (cboFineType.SelectedIndex <= -1) Then

            MessageBox.Show(“Please select the payment type to calculate", “Error", MessageBoxButtons.OK)
            cboFineType.Select()

        End If

    End Sub

    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        txtISBN.Clear()
        cboFineType.SelectedIndex = -1
        txtDays.Clear()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim decPaid As Decimal

        If (lblTotalPay.Text = "") Then
            MessageBox.Show(“Please calculate the total payment.", “Error", MessageBoxButtons.OK)
            cboFineType.Select()
        Else
            Try
                decPaid = Decimal.Parse(txtPaid.Text)
                CalChange(decPaid)
                isPaid = True
            Catch ex As Exception
                MessageBox.Show(“Please input the valid paid value.", “Error", MessageBoxButtons.OK)
                txtPaid.Focus()
                txtPaid.SelectAll()
            End Try
        End If

    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        lblTotalPay.Text = ""
        txtPaid.Clear()
        lblChange.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtID.Clear()
        txtISBN.Clear()
        cboFineType.SelectedIndex = -1
        txtDays.Clear()
        lblTotalPay.Text = ""
        txtPaid.Clear()
        lblChange.Text = ""
        frmMainMenu.switchPanel(frmPaymentView)
    End Sub

    Private Sub btnAddSave_Click(sender As Object, e As EventArgs) Handles btnAddSave.Click

        If (txtID.Text = "") Then
            MessageBox.Show("Please make sure you fill the student ID before you save the records.", " Error", MessageBoxButtons.OK)
            txtID.Focus()
        ElseIf (txtISBN.Text = "") Then
            MessageBox.Show("Please make sure you fill in the book ID before you save the records.", " Error", MessageBoxButtons.OK)
            txtISBN.Focus()
        ElseIf (lblChange.Text = "") Then
            MessageBox.Show("Please make sure you have calculated and received the payment before you save the data.", " Error", MessageBoxButtons.OK)
        Else
            PaymentTableAdapter.UpdateQuery(txtIssueId.Text, txtISBN.Text, cboFineType.SelectedItem, txtDays.Text, txtID.Text, lblTotalPay.Text,
                                            isPaid, DateTime.Now, frmMainMenu.LibrarianId, lblPaymentId.Text)
            frmPaymentView.PaymentTableAdapter.Fill(frmPaymentView.LibraryDatabaseDataSet1.Payment)
            frmMainMenu.switchPanel(frmPaymentView)
            MessageBox.Show("The record has been Saved!", "Payment Record", MessageBoxButtons.OK)
            btnAddSave.Text = "&Add"
        End If
    End Sub

End Class