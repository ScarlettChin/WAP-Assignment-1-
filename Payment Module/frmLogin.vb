Public Class frmLogin
    Dim at, dot, len, d As Integer
    Dim pwd As String
    Dim uname As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        uname = txtUsername.Text
        pwd = txtPassword.Text
        at = uname.IndexOf("@")
        dot = uname.IndexOf(".")
        len = pwd.Length

        For i = 0 To len - 1
            If Asc((pwd.Substring(i, 1))) >= 48 And Asc((pwd.Substring(i, 1))) <= 57 Then
            ElseIf Asc((pwd.ToUpper.Substring(i, 1))) <= 90 And Asc((pwd.ToUpper.Substring(i, 1))) Then
            Else
                d = d + 1
            End If

        Next
        If uname = "" Then
            MsgBox("Username should not be blank", MsgBoxStyle.Critical)
            Return
        ElseIf pwd = "" Then
            MsgBox("Password should not be blank", MsgBoxStyle.Critical)
            Return
        ElseIf d > 0 Then
            MsgBox("Password should not contain any special characters", MsgBoxStyle.Critical)
            Return
        Else
            MsgBox("Login Successfull", MsgBoxStyle.Information)
        End If
        Dim loginData As DataTable = UserTableAdapter.Login(txtUsername.Text)
        If loginData.Rows.Count = 0 Then
            MessageBox.Show("Incorrect username")
        Else
            If loginData.Rows(0).Item(2).ToString().Equals(txtPassword.Text) Then
                frmMainMenu.Role = loginData.Rows(0).Item(3).ToString
                frmMainMenu.LibrarianId = loginData.Rows(0).Item(5).ToString
                frmMainMenu.Show()
                LoginTransactionsTableAdapter.InsertQuery(txtUsername.Text, frmMainMenu.Role, loginData.Rows(0).Item(4).ToString, loginData.Rows(0).Item(5).ToString, DateTime.Now)
                Me.Close()
            Else
                MessageBox.Show("Incorrect password")
            End If
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDatabaseDataSet1.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.LibraryDatabaseDataSet1.User)

    End Sub

End Class