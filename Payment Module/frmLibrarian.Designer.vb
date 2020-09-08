<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLibrarian
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lstDepartment = New System.Windows.Forms.ListBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.lstWorkLocation = New System.Windows.Forms.ListBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPostal = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFristName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.dtpStart)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btnDisplay)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnCreate)
        Me.Panel1.Controls.Add(Me.lstDepartment)
        Me.Panel1.Controls.Add(Me.txtEmployeeID)
        Me.Panel1.Controls.Add(Me.lstWorkLocation)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.dtpBirthDate)
        Me.Panel1.Controls.Add(Me.radFemale)
        Me.Panel1.Controls.Add(Me.radMale)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtPostal)
        Me.Panel1.Controls.Add(Me.txtState)
        Me.Panel1.Controls.Add(Me.txtCity)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtAddress1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtFristName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 554)
        Me.Panel1.TabIndex = 0
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "dd-MM-yyyy"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(244, 484)
        Me.dtpStart.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(112, 20)
        Me.dtpStart.TabIndex = 90
        Me.dtpStart.UseWaitCursor = True
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(159, 483)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 19)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Start Date :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.UseWaitCursor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(549, 169)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(56, 24)
        Me.btnDisplay.TabIndex = 88
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        Me.btnDisplay.UseWaitCursor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(549, 128)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(56, 24)
        Me.btnUpdate.TabIndex = 87
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.UseWaitCursor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(549, 85)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(56, 24)
        Me.btnCreate.TabIndex = 86
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        Me.btnCreate.UseWaitCursor = True
        '
        'lstDepartment
        '
        Me.lstDepartment.FormattingEnabled = True
        Me.lstDepartment.Items.AddRange(New Object() {"Administration Departments", "System Departments", "Acquisitions Departments"})
        Me.lstDepartment.Location = New System.Drawing.Point(244, 407)
        Me.lstDepartment.Margin = New System.Windows.Forms.Padding(2)
        Me.lstDepartment.Name = "lstDepartment"
        Me.lstDepartment.Size = New System.Drawing.Size(188, 30)
        Me.lstDepartment.TabIndex = 85
        Me.lstDepartment.UseWaitCursor = True
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(244, 376)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(188, 20)
        Me.txtEmployeeID.TabIndex = 84
        Me.txtEmployeeID.UseWaitCursor = True
        '
        'lstWorkLocation
        '
        Me.lstWorkLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWorkLocation.FormattingEnabled = True
        Me.lstWorkLocation.Items.AddRange(New Object() {"WangsaMaju", "KLCC", "Kepong", "Cheras"})
        Me.lstWorkLocation.Location = New System.Drawing.Point(244, 450)
        Me.lstWorkLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.lstWorkLocation.Name = "lstWorkLocation"
        Me.lstWorkLocation.Size = New System.Drawing.Size(188, 30)
        Me.lstWorkLocation.TabIndex = 83
        Me.lstWorkLocation.UseWaitCursor = True
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(154, 450)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 22)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "Work Loccation :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.UseWaitCursor = True
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(159, 407)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 19)
        Me.Label19.TabIndex = 81
        Me.Label19.Text = "Department :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label19.UseWaitCursor = True
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(159, 376)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 19)
        Me.Label20.TabIndex = 80
        Me.Label20.Text = "Employee ID :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.UseWaitCursor = True
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthDate.Location = New System.Drawing.Point(244, 286)
        Me.dtpBirthDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(112, 20)
        Me.dtpBirthDate.TabIndex = 79
        Me.dtpBirthDate.UseWaitCursor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(299, 258)
        Me.radFemale.Margin = New System.Windows.Forms.Padding(2)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(59, 17)
        Me.radFemale.TabIndex = 78
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        Me.radFemale.UseWaitCursor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(244, 258)
        Me.radMale.Margin = New System.Windows.Forms.Padding(2)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(48, 17)
        Me.radMale.TabIndex = 77
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        Me.radMale.UseWaitCursor = True
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(187, 256)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 19)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Gender :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.UseWaitCursor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(365, 110)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Last Name"
        Me.Label15.UseWaitCursor = True
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Location = New System.Drawing.Point(367, 90)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(112, 20)
        Me.txtLastName.TabIndex = 74
        Me.txtLastName.UseWaitCursor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(244, 110)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Frist Name"
        Me.Label14.UseWaitCursor = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(159, 285)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 19)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Birth Date :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.UseWaitCursor = True
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(244, 343)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(112, 20)
        Me.txtPhone.TabIndex = 71
        Me.txtPhone.UseWaitCursor = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(153, 342)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 19)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Phone Number :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(242, 235)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 19)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Postal"
        Me.Label8.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(365, 194)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "State"
        Me.Label7.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(244, 194)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 19)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "City"
        Me.Label6.UseWaitCursor = True
        '
        'txtPostal
        '
        Me.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostal.Location = New System.Drawing.Point(244, 215)
        Me.txtPostal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPostal.Name = "txtPostal"
        Me.txtPostal.Size = New System.Drawing.Size(112, 20)
        Me.txtPostal.TabIndex = 66
        Me.txtPostal.UseWaitCursor = True
        '
        'txtState
        '
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState.Location = New System.Drawing.Point(367, 173)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(112, 20)
        Me.txtState.TabIndex = 65
        Me.txtState.UseWaitCursor = True
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Location = New System.Drawing.Point(244, 173)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(112, 20)
        Me.txtCity.TabIndex = 64
        Me.txtCity.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(244, 152)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 19)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Street Address"
        Me.Label5.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(158, 54)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 22)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Librarian Information :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.UseWaitCursor = True
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(244, 313)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(234, 20)
        Me.txtEmail.TabIndex = 61
        Me.txtEmail.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(159, 312)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Email Address :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.UseWaitCursor = True
        '
        'txtAddress1
        '
        Me.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress1.Location = New System.Drawing.Point(244, 132)
        Me.txtAddress1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress1.Multiline = True
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(234, 18)
        Me.txtAddress1.TabIndex = 59
        Me.txtAddress1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(159, 131)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Address :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.UseWaitCursor = True
        '
        'txtFristName
        '
        Me.txtFristName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFristName.Location = New System.Drawing.Point(244, 90)
        Me.txtFristName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFristName.Name = "txtFristName"
        Me.txtFristName.Size = New System.Drawing.Size(112, 20)
        Me.txtFristName.TabIndex = 57
        Me.txtFristName.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(159, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Name :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.UseWaitCursor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(790, 52)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "LIBRARIAN"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLibrarian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 515)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLibrarian"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents lstDepartment As ListBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lstWorkLocation As ListBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPostal As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFristName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
End Class
