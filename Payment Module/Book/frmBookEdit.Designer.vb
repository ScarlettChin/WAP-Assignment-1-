<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookEdit
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
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim Book_NameLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim PublisherLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDatabaseDataSet1 = New Payment_Module.LibraryDatabaseDataSet1()
        Me.StudentTableAdapter = New Payment_Module.LibraryDatabaseDataSet1TableAdapters.StudentTableAdapter()
        ISBNLabel = New System.Windows.Forms.Label()
        Book_NameLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        PublisherLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(23, 29)
        ISBNLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 0
        ISBNLabel.Text = "ISBN:"
        '
        'Book_NameLabel
        '
        Book_NameLabel.AutoSize = True
        Book_NameLabel.Location = New System.Drawing.Point(23, 66)
        Book_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Book_NameLabel.Name = "Book_NameLabel"
        Book_NameLabel.Size = New System.Drawing.Size(66, 13)
        Book_NameLabel.TabIndex = 2
        Book_NameLabel.Text = "Book Name:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(23, 103)
        AuthorLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(41, 13)
        AuthorLabel.TabIndex = 4
        AuthorLabel.Text = "Author:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(23, 140)
        CategoryLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 6
        CategoryLabel.Text = "Category:"
        '
        'PublisherLabel
        '
        PublisherLabel.AutoSize = True
        PublisherLabel.Location = New System.Drawing.Point(23, 177)
        PublisherLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PublisherLabel.Name = "PublisherLabel"
        PublisherLabel.Size = New System.Drawing.Size(53, 13)
        PublisherLabel.TabIndex = 8
        PublisherLabel.Text = "Publisher:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(23, 214)
        PriceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 10
        PriceLabel.Text = "Price:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(216, 333)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 28)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "&Update"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(67, 332)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(70, 29)
        Me.btnReturn.TabIndex = 38
        Me.btnReturn.Text = "&Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.lblStudentId)
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Controls.Add(Me.btnReturn)
        Me.GroupBox1.Controls.Add(Me.txtStudentId)
        Me.GroupBox1.Controls.Add(Me.cmbCategory)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnIssue)
        Me.GroupBox1.Controls.Add(ISBNLabel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtISBN)
        Me.GroupBox1.Controls.Add(Book_NameLabel)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(AuthorLabel)
        Me.GroupBox1.Controls.Add(Me.txtAuthor)
        Me.GroupBox1.Controls.Add(CategoryLabel)
        Me.GroupBox1.Controls.Add(PublisherLabel)
        Me.GroupBox1.Controls.Add(Me.txtPublisher)
        Me.GroupBox1.Controls.Add(PriceLabel)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 52)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(387, 948)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(142, 333)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(71, 28)
        Me.btnDelete.TabIndex = 45
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Location = New System.Drawing.Point(25, 251)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(56, 13)
        Me.lblStudentId.TabIndex = 44
        Me.lblStudentId.Text = "Student Id"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(91, 287)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(121, 20)
        Me.txtStatus.TabIndex = 43
        Me.txtStatus.Visible = False
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(92, 248)
        Me.txtStudentId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(121, 20)
        Me.txtStudentId.TabIndex = 41
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Romance", "Science fiction", "Action", "Children's Book", "Mystery", "Inspire"})
        Me.cmbCategory.Location = New System.Drawing.Point(91, 137)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(122, 21)
        Me.cmbCategory.TabIndex = 25
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(291, 333)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 28)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnIssue
        '
        Me.btnIssue.Location = New System.Drawing.Point(66, 332)
        Me.btnIssue.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(70, 29)
        Me.btnIssue.TabIndex = 39
        Me.btnIssue.Text = "&Issue"
        Me.btnIssue.UseVisualStyleBackColor = True
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(92, 26)
        Me.txtISBN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.ReadOnly = True
        Me.txtISBN.Size = New System.Drawing.Size(121, 20)
        Me.txtISBN.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(92, 63)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 3
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(92, 100)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(121, 20)
        Me.txtAuthor.TabIndex = 5
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(92, 177)
        Me.txtPublisher.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(121, 20)
        Me.txtPublisher.TabIndex = 9
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(92, 214)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1000, 52)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Book Details"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIdDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(387, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(613, 948)
        Me.DataGridView1.TabIndex = 45
        '
        'StudentIdDataGridViewTextBoxColumn
        '
        Me.StudentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId"
        Me.StudentIdDataGridViewTextBoxColumn.HeaderText = "StudentId"
        Me.StudentIdDataGridViewTextBoxColumn.Name = "StudentIdDataGridViewTextBoxColumn"
        Me.StudentIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        Me.StudentNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        Me.CourseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.LibraryDatabaseDataSet1
        '
        'LibraryDatabaseDataSet1
        '
        Me.LibraryDatabaseDataSet1.DataSetName = "LibraryDatabaseDataSet1"
        Me.LibraryDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'frmBookEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 1000)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBookEdit"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnIssue As Button
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblStudentId As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LibraryDatabaseDataSet1 As LibraryDatabaseDataSet1
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As LibraryDatabaseDataSet1TableAdapters.StudentTableAdapter
    Friend WithEvents StudentIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
End Class
