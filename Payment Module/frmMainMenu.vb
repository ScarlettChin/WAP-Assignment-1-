Imports FontAwesome.Sharp

Public Class frmMainMenu

    Private currentbtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Public Role As Integer
    Public LibrarianId As Integer

    Public Sub switchPanel(ByVal panel As Form)

        palHome.Controls.Clear()
        panel.TopLevel = False
        palHome.Controls.Add(panel)
        panel.WindowState = FormWindowState.Maximized
        panel.Show()
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        switchPanel(frmBookView)
        If Role = 1 Then
            IconButtonLibrarian.Visible = False
            IconButtonStudent.Visible = False
            IconButtonPayment.Visible = False
            IconButtonLoginReport.Visible = False
        ElseIf Role = 2 Then
            IconButtonLibrarian.Visible = False
            IconButtonStudent.Visible = True
            IconButtonPayment.Visible = True
            IconButtonLoginReport.Visible = True
        Else
            IconButtonLibrarian.Visible = True
            IconButtonStudent.Visible = True
            IconButtonPayment.Visible = True
            IconButtonLoginReport.Visible = True
        End If
    End Sub

    Private Sub IconButtonStudent_Click_1(sender As Object, e As EventArgs) Handles IconButtonStudent.Click
        'activateButton(sender, Color.FromArgb(250, 156, 29))
        switchPanel(frmStudentView)
    End Sub

    Private Sub IconButtonLibrarian_Click(sender As Object, e As EventArgs) Handles IconButtonLibrarian.Click
        'activateButton(sender, Color.FromArgb(250, 156, 29))
        switchPanel(frmLibrarianView)
    End Sub

    Private Sub IconButtonBook_Click(sender As Object, e As EventArgs) Handles IconButtonBook.Click
        'activateButton(sender, Color.FromArgb(250, 156, 29))
        switchPanel(frmBookView)
    End Sub

    Private Sub IconButtonLogOut_Click(sender As Object, e As EventArgs) Handles IconButtonLogOut.Click
        Dim login As New frmLogin
        login.Show()
        Me.Close()
    End Sub

    Private Sub activateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'button
            currentbtn = CType(senderBtn, IconButton)
            currentbtn.BackColor = Color.FromArgb(74, 76, 78)
            currentbtn.ForeColor = customColor
            currentbtn.IconColor = customColor

            'LeftBorderButton
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentbtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

        End If
    End Sub

    Private Sub DisableButton()
        If currentbtn IsNot Nothing Then
            'button
            currentbtn.BackColor = Color.FromArgb(74, 76, 78)
            currentbtn.ForeColor = Color.Gainsboro
            currentbtn.IconColor = Color.Gainsboro
        End If
    End Sub

    Private Sub IconButtonLoginReport_Click(sender As Object, e As EventArgs) Handles IconButtonLoginReport.Click
        switchPanel(frmLoginReportView)
    End Sub

    Private Sub IconButtonPayment_Click(sender As Object, e As EventArgs) Handles IconButtonPayment.Click
        switchPanel(frmPaymentView)
    End Sub


End Class