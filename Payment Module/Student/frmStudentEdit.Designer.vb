<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentEdit
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim StudentIdLabel As System.Windows.Forms.Label
        Dim StudentNameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.comboGender = New System.Windows.Forms.ComboBox()
        Me.comboCourse = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.LibraryDatabaseDataSet1 = New Payment_Module.LibraryDatabaseDataSet1()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New Payment_Module.LibraryDatabaseDataSet1TableAdapters.UserTableAdapter()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        StudentIdLabel = New System.Windows.Forms.Label()
        StudentNameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        CType(Me.LibraryDatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(413, 84)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 13)
        Label1.TabIndex = 111
        Label1.Text = "Username:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(413, 134)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 13)
        Label2.TabIndex = 113
        Label2.Text = "Pasword:"
        '
        'StudentIdLabel
        '
        StudentIdLabel.AutoSize = True
        StudentIdLabel.Location = New System.Drawing.Point(41, 84)
        StudentIdLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        StudentIdLabel.Name = "StudentIdLabel"
        StudentIdLabel.Size = New System.Drawing.Size(59, 13)
        StudentIdLabel.TabIndex = 99
        StudentIdLabel.Text = "Student Id:"
        '
        'StudentNameLabel
        '
        StudentNameLabel.AutoSize = True
        StudentNameLabel.Location = New System.Drawing.Point(41, 134)
        StudentNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        StudentNameLabel.Name = "StudentNameLabel"
        StudentNameLabel.Size = New System.Drawing.Size(78, 13)
        StudentNameLabel.TabIndex = 101
        StudentNameLabel.Text = "Student Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(41, 184)
        AgeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 103
        AgeLabel.Text = "Age:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(41, 234)
        GenderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 105
        GenderLabel.Text = "Gender:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(41, 284)
        CourseLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(43, 13)
        CourseLabel.TabIndex = 107
        CourseLabel.Text = "Course:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(505, 81)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(249, 20)
        Me.txtUsername.TabIndex = 112
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(505, 131)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(249, 20)
        Me.txtPassword.TabIndex = 114
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(598, 355)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(76, 31)
        Me.btnUpdate.TabIndex = 110
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnCancel.Location = New System.Drawing.Point(678, 355)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(76, 31)
        Me.btnCancel.TabIndex = 109
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(133, 81)
        Me.txtStudentId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(249, 20)
        Me.txtStudentId.TabIndex = 100
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(133, 131)
        Me.txtStudentName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(249, 20)
        Me.txtStudentName.TabIndex = 102
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(133, 181)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(249, 20)
        Me.txtAge.TabIndex = 104
        '
        'comboGender
        '
        Me.comboGender.FormattingEnabled = True
        Me.comboGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.comboGender.Location = New System.Drawing.Point(133, 231)
        Me.comboGender.Margin = New System.Windows.Forms.Padding(2)
        Me.comboGender.Name = "comboGender"
        Me.comboGender.Size = New System.Drawing.Size(249, 21)
        Me.comboGender.TabIndex = 106
        '
        'comboCourse
        '
        Me.comboCourse.FormattingEnabled = True
        Me.comboCourse.Items.AddRange(New Object() {"DIB", "DCO", "DHT", "DIT"})
        Me.comboCourse.Location = New System.Drawing.Point(133, 282)
        Me.comboCourse.Margin = New System.Windows.Forms.Padding(2)
        Me.comboCourse.Name = "comboCourse"
        Me.comboCourse.Size = New System.Drawing.Size(249, 21)
        Me.comboCourse.TabIndex = 108
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(871, 52)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Edit Student"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(518, 355)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(76, 31)
        Me.btnDelete.TabIndex = 116
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
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
        'frmStudentEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 531)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(StudentIdLabel)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(StudentNameLabel)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.comboGender)
        Me.Controls.Add(CourseLabel)
        Me.Controls.Add(Me.comboCourse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudentEdit"
        Me.Text = "frmStudentEdit"
        CType(Me.LibraryDatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents comboGender As ComboBox
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents LibraryDatabaseDataSet1 As LibraryDatabaseDataSet1
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As LibraryDatabaseDataSet1TableAdapters.UserTableAdapter
End Class
