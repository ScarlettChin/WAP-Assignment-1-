Public Class frmLoginReportView
    Private Sub LoginReportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.LoginTransactions' table. You can move, or remove it, as needed.
        Me.LoginTransactionsTableAdapter.Fill(Me.LibraryDatabaseDataSet1.LoginTransactions)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
        With PrintPreviewDialog1
            .Document = PrintDocument1
            .ShowDialog()
        End With
    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fntPrint As New Font("Arial", 12)
        Dim fntHeading As New Font("Modern No. 20", 20, FontStyle.Bold)
        Dim sngLineHeight As Single = fntPrint.GetHeight
        Dim sngHori As Single = e.MarginBounds.Left
        Dim sngverti As Single = e.MarginBounds.Top
        Dim sngXLocation As Single = e.MarginBounds.Left
        Dim sngYLocation As Single = e.MarginBounds.Top
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine & "Prepared by TARUC", DateTime.Now)

        e.Graphics.DrawImage(My.Resources.TARC_LOGO, 100, 10, 80, 100)
        sngHori += 200
        e.Graphics.DrawString("Login Transaction", fntHeading, Brushes.DarkBlue, sngHori, sngverti)

        sngHori += 10
        sngverti += 50
        e.Graphics.DrawString(subHeader, fntPrint, Brushes.Black, sngHori, sngverti)
        sngverti += 50
        sngHori -= 300
        e.Graphics.DrawString("        ID        " + "          USERNAME           " + "           ROLE ID          " + "        STUDENT ID   " + vbTab + "        LIBRARIAN ID        " + "              LAST LOGIN ", fntPrint, Brushes.Black, sngHori, sngverti)
        sngverti += 10
        e.Graphics.DrawString("--------------------" + "    -------------------" + "   ---------------------------" + "   --------------" + "      --------------------------" + "          -----------------", fntPrint, Brushes.Black, sngHori, sngverti)
        sngverti += 20

        For i As Integer = 0 To LibraryDatabaseDataSet1.LoginTransactions.Count - 1
            e.Graphics.DrawString(LibraryDatabaseDataSet1.Tables("LoginTransaction").Rows(i).Item(1).ToString, fntPrint, Brushes.Black, sngHori, sngverti)
            e.Graphics.DrawString(LibraryDatabaseDataSet1.Tables("LoginTransaction").Rows(i).Item(2).ToString, fntPrint, Brushes.Black, sngHori + 70, sngverti)
            e.Graphics.DrawString(LibraryDatabaseDataSet1.Tables("LoginTransaction").Rows(i).Item(9).ToString, fntPrint, Brushes.Black, sngHori + 135, sngverti)
            e.Graphics.DrawString(LibraryDatabaseDataSet1.Tables("LoginTransaction").Rows(i).Item(12).ToString, fntPrint, Brushes.Black, sngHori + 275, sngverti)
            e.Graphics.DrawString(LibraryDatabaseDataSet1.Tables("LoginTransaction").Rows(i).Item(16).ToString, fntPrint, Brushes.Black, sngHori + 445, sngverti)
            e.Graphics.DrawString(LibraryDatabaseDataSet1.Tables("LoginTransaction").Rows(i).Item(14).ToString, fntPrint, Brushes.Black, sngHori + 535, sngverti)
            e.Graphics.DrawString(LibraryDatabaseDataSet1.Tables("LoginTransaction").Rows(i).Item(15).ToString, fntPrint, Brushes.Black, sngHori + 760, sngverti)

            sngverti += 50


        Next




    End Sub

End Class