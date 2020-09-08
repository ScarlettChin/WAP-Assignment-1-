Public Class frmPaymentCreate
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Clear()
    End Sub

    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        txtIssueId.Clear()
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

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        If (lblChange.Text = "") Then
            MessageBox.Show("Please make sure you have insert the valid input and calculated the total payment to generate the receipt", " Error", MessageBoxButtons.OK)

            If (cboFineType.SelectedIndex <= -1) Then
                cboFineType.Select()
            ElseIf (txtDays.Text = "") Then
                txtDays.Focus()
            ElseIf (lblChange.Text = "") Then
                txtPaid.Focus()
                txtPaid.SelectAll()
            End If
            'ElseIf (txtPaid.Text = "" Or (txtPaid.Text < lblTotalPay.Text)) Then
            '    MessageBox.Show("Please make sure you have calculated and insert the valid input to generate the receipt", " Error", MessageBoxButtons.OK)
            '    txtPaid.Focus()
            '    txtPaid.SelectAll()
        Else
            'Generate Receipt
            PrintDocument1.Print()
            With PrintPreviewDialog1
                .Document = PrintDocument1
                .ShowDialog()
            End With
            'MessageBox.Show("Receipt have been generated", "Receipt Generated", MessageBoxButtons.OK)
        End If
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
            PaymentTableAdapter.InsertQuery(txtIssueId.Text, txtISBN.Text, cboFineType.SelectedItem, txtDays.Text, txtID.Text, lblTotalPay.Text,
                                            isPaid, DateTime.Now, frmMainMenu.LibrarianId)
            frmPaymentView.PaymentTableAdapter.Fill(frmPaymentView.LibraryDatabaseDataSet1.Payment)
            frmMainMenu.switchPanel(frmPaymentView)
            MessageBox.Show("The record has been Saved!", "Payment Record", MessageBoxButtons.OK)
            btnAddSave.Text = "&Add"
        End If

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

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        lblTotalPay.Text = ""
        txtPaid.Clear()
        lblChange.Text = ""
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub frmPaymentCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.LibraryDatabaseDataSet1.Payment)

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fntHeading As New Font("Arial", 20, FontStyle.Bold)
        Dim fntDetail As New Font("Arial", 14, FontStyle.Bold)
        Dim sngLineHeight As Single = fntDetail.GetHeight + 2
        Dim sngHorizontalLocation As Single = e.MarginBounds.Left
        Dim sngVerticalLocation As Single = e.MarginBounds.Top
        Dim sngDetailXLoca As Single = e.MarginBounds.Left
        Dim sngDetailYLoca As Single = e.MarginBounds.Top
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)

        'Set up Header
        'sngHorizontalLocation += 6
        sngHorizontalLocation += 220
        e.Graphics.DrawString("TARUC Library", fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        sngHorizontalLocation -= 48
        sngVerticalLocation += 25
        e.Graphics.DrawString("----------------------------------", fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        sngHorizontalLocation += 35
        sngVerticalLocation += 25
        e.Graphics.DrawString("Payment Receipt", fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        sngHorizontalLocation -= 35
        sngVerticalLocation += 25
        e.Graphics.DrawString("----------------------------------", fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        sngHorizontalLocation -= 35
        sngVerticalLocation += 50
        e.Graphics.DrawString("Date : " & DateTime.Now, fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        sngHorizontalLocation -= 150
        sngVerticalLocation += 60
        sngVerticalLocation += 60
        e.Graphics.DrawString("[Description]" + vbTab + vbTab + "[Day(s)]" + vbTab + vbTab + "[Total]", fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        sngVerticalLocation += 25
        e.Graphics.DrawString(cboFineType.Text + vbTab + vbTab + txtDays.Text + vbTab + vbTab + lblTotalPay.Text, fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        sngVerticalLocation += 25
        'e.Graphics.DrawString(txtDays.Text & "Day(s)", fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        'sngVerticalLocation += 25
        e.Graphics.DrawString("---------------------------------------------------------------------------", fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        sngVerticalLocation += 25
        e.Graphics.DrawString("Total Amount" + vbTab + vbTab + vbTab + vbTab + lblTotalPay.Text, fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        sngVerticalLocation += 25
        e.Graphics.DrawString("Paid" + vbTab + vbTab + vbTab + vbTab + vbTab & "RM" & txtPaid.Text, fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        sngVerticalLocation += 25
        e.Graphics.DrawString("Change" + vbTab + vbTab + vbTab + vbTab + vbTab & lblChange.Text, fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
        sngVerticalLocation += 25
        e.Graphics.DrawString("---------------------------------------------------------------------------", fntHeading, Brushes.Black, sngHorizontalLocation, sngVerticalLocation)
    End Sub

End Class