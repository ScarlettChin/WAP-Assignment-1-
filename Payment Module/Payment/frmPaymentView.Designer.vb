<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.buttonAddBooks = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearchValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PaymentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FineTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverduePeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsPaidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibrarianIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDatabaseDataSet1 = New Payment_Module.LibraryDatabaseDataSet1()
        Me.PaymentTableAdapter = New Payment_Module.LibraryDatabaseDataSet1TableAdapters.PaymentTableAdapter()
        Me.MoreDetails = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label8.Size = New System.Drawing.Size(1032, 52)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Payment"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.buttonAddBooks)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearchValue)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 52)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1032, 93)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Payment"
        '
        'buttonAddBooks
        '
        Me.buttonAddBooks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAddBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.buttonAddBooks.Location = New System.Drawing.Point(921, 49)
        Me.buttonAddBooks.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonAddBooks.Name = "buttonAddBooks"
        Me.buttonAddBooks.Size = New System.Drawing.Size(83, 33)
        Me.buttonAddBooks.TabIndex = 39
        Me.buttonAddBooks.Text = "&Add Payments"
        Me.buttonAddBooks.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.btnSearch.Location = New System.Drawing.Point(291, 40)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(83, 31)
        Me.btnSearch.TabIndex = 35
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearchValue
        '
        Me.txtSearchValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchValue.Location = New System.Drawing.Point(95, 46)
        Me.txtSearchValue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchValue.Name = "txtSearchValue"
        Me.txtSearchValue.Size = New System.Drawing.Size(172, 19)
        Me.txtSearchValue.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentIdDataGridViewTextBoxColumn, Me.IssueIdDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.FineTypeDataGridViewTextBoxColumn, Me.OverduePeriodDataGridViewTextBoxColumn, Me.StudentIdDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.IsPaidDataGridViewCheckBoxColumn, Me.PaymentDateDataGridViewTextBoxColumn, Me.LibrarianIdDataGridViewTextBoxColumn, Me.MoreDetails})
        Me.DataGridView1.DataSource = Me.PaymentBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1032, 524)
        Me.DataGridView1.TabIndex = 40
        '
        'PaymentIdDataGridViewTextBoxColumn
        '
        Me.PaymentIdDataGridViewTextBoxColumn.DataPropertyName = "PaymentId"
        Me.PaymentIdDataGridViewTextBoxColumn.HeaderText = "PaymentId"
        Me.PaymentIdDataGridViewTextBoxColumn.Name = "PaymentIdDataGridViewTextBoxColumn"
        Me.PaymentIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IssueIdDataGridViewTextBoxColumn
        '
        Me.IssueIdDataGridViewTextBoxColumn.DataPropertyName = "IssueId"
        Me.IssueIdDataGridViewTextBoxColumn.HeaderText = "IssueId"
        Me.IssueIdDataGridViewTextBoxColumn.Name = "IssueIdDataGridViewTextBoxColumn"
        Me.IssueIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FineTypeDataGridViewTextBoxColumn
        '
        Me.FineTypeDataGridViewTextBoxColumn.DataPropertyName = "FineType"
        Me.FineTypeDataGridViewTextBoxColumn.HeaderText = "FineType"
        Me.FineTypeDataGridViewTextBoxColumn.Name = "FineTypeDataGridViewTextBoxColumn"
        Me.FineTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OverduePeriodDataGridViewTextBoxColumn
        '
        Me.OverduePeriodDataGridViewTextBoxColumn.DataPropertyName = "OverduePeriod"
        Me.OverduePeriodDataGridViewTextBoxColumn.HeaderText = "OverduePeriod"
        Me.OverduePeriodDataGridViewTextBoxColumn.Name = "OverduePeriodDataGridViewTextBoxColumn"
        Me.OverduePeriodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentIdDataGridViewTextBoxColumn
        '
        Me.StudentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId"
        Me.StudentIdDataGridViewTextBoxColumn.HeaderText = "StudentId"
        Me.StudentIdDataGridViewTextBoxColumn.Name = "StudentIdDataGridViewTextBoxColumn"
        Me.StudentIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsPaidDataGridViewCheckBoxColumn
        '
        Me.IsPaidDataGridViewCheckBoxColumn.DataPropertyName = "IsPaid"
        Me.IsPaidDataGridViewCheckBoxColumn.HeaderText = "IsPaid"
        Me.IsPaidDataGridViewCheckBoxColumn.Name = "IsPaidDataGridViewCheckBoxColumn"
        Me.IsPaidDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate"
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        Me.PaymentDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LibrarianIdDataGridViewTextBoxColumn
        '
        Me.LibrarianIdDataGridViewTextBoxColumn.DataPropertyName = "LibrarianId"
        Me.LibrarianIdDataGridViewTextBoxColumn.HeaderText = "LibrarianId"
        Me.LibrarianIdDataGridViewTextBoxColumn.Name = "LibrarianIdDataGridViewTextBoxColumn"
        Me.LibrarianIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.LibraryDatabaseDataSet1
        '
        'LibraryDatabaseDataSet1
        '
        Me.LibraryDatabaseDataSet1.DataSetName = "LibraryDatabaseDataSet1"
        Me.LibraryDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'MoreDetails
        '
        Me.MoreDetails.HeaderText = "More Details"
        Me.MoreDetails.Name = "MoreDetails"
        Me.MoreDetails.ReadOnly = True
        '
        'frmPaymentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 669)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPaymentView"
        Me.Text = "frmPaymentView"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents buttonAddBooks As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LibraryDatabaseDataSet1 As LibraryDatabaseDataSet1
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As LibraryDatabaseDataSet1TableAdapters.PaymentTableAdapter
    Friend WithEvents PaymentIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FineTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OverduePeriodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsPaidDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibrarianIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoreDetails As DataGridViewButtonColumn
End Class
