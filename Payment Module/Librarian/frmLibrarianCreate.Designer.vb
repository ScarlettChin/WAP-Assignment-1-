<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLibrarianCreate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.comboGender = New System.Windows.Forms.ComboBox()
        Me.txtIc = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpHireDate = New System.Windows.Forms.DateTimePicker()
        Me.comboPosition = New System.Windows.Forms.ComboBox()
        Me.comboWorkLocation = New System.Windows.Forms.ComboBox()
        Me.LibraryDatabaseDataSet1 = New Payment_Module.LibraryDatabaseDataSet1()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New Payment_Module.LibraryDatabaseDataSet1TableAdapters.UserTableAdapter()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.LibraryDatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(428, 281)
        Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(58, 13)
        Label4.TabIndex = 184
        Label4.Text = "Username:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(428, 326)
        Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(51, 13)
        Label5.TabIndex = 186
        Label5.Text = "Pasword:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(21, 100)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 13)
        Label1.TabIndex = 202
        Label1.Text = "Name:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(21, 187)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(48, 13)
        Label2.TabIndex = 204
        Label2.Text = "Address:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(21, 236)
        Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(45, 13)
        Label7.TabIndex = 205
        Label7.Text = "Gender:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(21, 285)
        Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(57, 13)
        Label8.TabIndex = 206
        Label8.Text = "Birth Date:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(21, 329)
        Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(76, 13)
        Label3.TabIndex = 207
        Label3.Text = "Email Address:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(21, 375)
        Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(81, 13)
        Label9.TabIndex = 208
        Label9.Text = "Phone Number:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(428, 100)
        Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(49, 13)
        Label10.TabIndex = 209
        Label10.Text = "Positions"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(428, 144)
        Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(77, 13)
        Label11.TabIndex = 210
        Label11.Text = "Work Location"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(428, 191)
        Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(36, 13)
        Label13.TabIndex = 211
        Label13.Text = "Salary"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(428, 240)
        Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(52, 13)
        Label14.TabIndex = 212
        Label14.Text = "Hire Date"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(21, 146)
        Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(20, 13)
        Label6.TabIndex = 213
        Label6.Text = "IC:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(707, 427)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 28)
        Me.btnCancel.TabIndex = 183
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(630, 427)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 28)
        Me.btnAdd.TabIndex = 181
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(1056, 52)
        Me.Label12.TabIndex = 165
        Me.Label12.Text = "Create Librarian"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(104, 97)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(249, 20)
        Me.txtName.TabIndex = 189
        '
        'comboGender
        '
        Me.comboGender.DisplayMember = "MALE"
        Me.comboGender.FormattingEnabled = True
        Me.comboGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.comboGender.Location = New System.Drawing.Point(104, 233)
        Me.comboGender.Margin = New System.Windows.Forms.Padding(2)
        Me.comboGender.Name = "comboGender"
        Me.comboGender.Size = New System.Drawing.Size(249, 21)
        Me.comboGender.TabIndex = 190
        Me.comboGender.ValueMember = "MALE"
        '
        'txtIc
        '
        Me.txtIc.Location = New System.Drawing.Point(104, 143)
        Me.txtIc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIc.Name = "txtIc"
        Me.txtIc.Size = New System.Drawing.Size(249, 20)
        Me.txtIc.TabIndex = 191
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(104, 184)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(249, 20)
        Me.txtAddress.TabIndex = 192
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(104, 326)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(249, 20)
        Me.txtEmail.TabIndex = 193
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(104, 368)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(249, 20)
        Me.txtPhoneNumber.TabIndex = 194
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(530, 323)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(249, 20)
        Me.txtPassword.TabIndex = 195
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(530, 278)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(249, 20)
        Me.txtUsername.TabIndex = 196
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(530, 188)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(249, 20)
        Me.txtSalary.TabIndex = 197
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Location = New System.Drawing.Point(104, 281)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(249, 20)
        Me.dtpBirthDate.TabIndex = 198
        '
        'dtpHireDate
        '
        Me.dtpHireDate.Location = New System.Drawing.Point(530, 234)
        Me.dtpHireDate.Name = "dtpHireDate"
        Me.dtpHireDate.Size = New System.Drawing.Size(249, 20)
        Me.dtpHireDate.TabIndex = 199
        '
        'comboPosition
        '
        Me.comboPosition.DisplayMember = "Librarian"
        Me.comboPosition.FormattingEnabled = True
        Me.comboPosition.Items.AddRange(New Object() {"Librarian", "Manager"})
        Me.comboPosition.Location = New System.Drawing.Point(530, 96)
        Me.comboPosition.Margin = New System.Windows.Forms.Padding(2)
        Me.comboPosition.Name = "comboPosition"
        Me.comboPosition.Size = New System.Drawing.Size(249, 21)
        Me.comboPosition.TabIndex = 200
        Me.comboPosition.ValueMember = "Librarian"
        '
        'comboWorkLocation
        '
        Me.comboWorkLocation.DisplayMember = "Kuala Lumpur"
        Me.comboWorkLocation.FormattingEnabled = True
        Me.comboWorkLocation.Items.AddRange(New Object() {"Kuala Lumpur", "Penang", "Perak", "Johor", "Pahang", "Sabah"})
        Me.comboWorkLocation.Location = New System.Drawing.Point(530, 141)
        Me.comboWorkLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.comboWorkLocation.Name = "comboWorkLocation"
        Me.comboWorkLocation.Size = New System.Drawing.Size(249, 21)
        Me.comboWorkLocation.TabIndex = 201
        Me.comboWorkLocation.ValueMember = "Kuala Lumpur"
        '
        'LibraryDatabaseDataSet1
        '
        Me.LibraryDatabaseDataSet1.DataSetName = "LibraryDatabaseDataSet1"
        Me.LibraryDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.LibraryDatabaseDataSet1
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'frmLibrarianCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 675)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.comboWorkLocation)
        Me.Controls.Add(Me.comboPosition)
        Me.Controls.Add(Me.dtpHireDate)
        Me.Controls.Add(Me.dtpBirthDate)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtIc)
        Me.Controls.Add(Me.comboGender)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLibrarianCreate"
        Me.Text = "frmLibrarianCreate"
        CType(Me.LibraryDatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents comboGender As ComboBox
    Friend WithEvents txtIc As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents dtpHireDate As DateTimePicker
    Friend WithEvents comboPosition As ComboBox
    Friend WithEvents comboWorkLocation As ComboBox
    Friend WithEvents LibraryDatabaseDataSet1 As LibraryDatabaseDataSet1
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As LibraryDatabaseDataSet1TableAdapters.UserTableAdapter
End Class
