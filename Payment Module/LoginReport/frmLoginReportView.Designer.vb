<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginReportView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginReportView))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibrarianIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastLoginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDatabaseDataSet1 = New Payment_Module.LibraryDatabaseDataSet1()
        Me.LoginTransactionsTableAdapter = New Payment_Module.LibraryDatabaseDataSet1TableAdapters.LoginTransactionsTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.Label8.Size = New System.Drawing.Size(1090, 52)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Login Report"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.RoleIdDataGridViewTextBoxColumn, Me.StudentIdDataGridViewTextBoxColumn, Me.LibrarianIdDataGridViewTextBoxColumn, Me.LastLoginDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LoginTransactionsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1090, 615)
        Me.DataGridView1.TabIndex = 38
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RoleIdDataGridViewTextBoxColumn
        '
        Me.RoleIdDataGridViewTextBoxColumn.DataPropertyName = "RoleId"
        Me.RoleIdDataGridViewTextBoxColumn.HeaderText = "RoleId"
        Me.RoleIdDataGridViewTextBoxColumn.Name = "RoleIdDataGridViewTextBoxColumn"
        Me.RoleIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentIdDataGridViewTextBoxColumn
        '
        Me.StudentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId"
        Me.StudentIdDataGridViewTextBoxColumn.HeaderText = "StudentId"
        Me.StudentIdDataGridViewTextBoxColumn.Name = "StudentIdDataGridViewTextBoxColumn"
        Me.StudentIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LibrarianIdDataGridViewTextBoxColumn
        '
        Me.LibrarianIdDataGridViewTextBoxColumn.DataPropertyName = "LibrarianId"
        Me.LibrarianIdDataGridViewTextBoxColumn.HeaderText = "LibrarianId"
        Me.LibrarianIdDataGridViewTextBoxColumn.Name = "LibrarianIdDataGridViewTextBoxColumn"
        Me.LibrarianIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastLoginDataGridViewTextBoxColumn
        '
        Me.LastLoginDataGridViewTextBoxColumn.DataPropertyName = "LastLogin"
        Me.LastLoginDataGridViewTextBoxColumn.HeaderText = "LastLogin"
        Me.LastLoginDataGridViewTextBoxColumn.Name = "LastLoginDataGridViewTextBoxColumn"
        Me.LastLoginDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoginTransactionsBindingSource
        '
        Me.LoginTransactionsBindingSource.DataMember = "LoginTransactions"
        Me.LoginTransactionsBindingSource.DataSource = Me.LibraryDatabaseDataSet1
        '
        'LibraryDatabaseDataSet1
        '
        Me.LibraryDatabaseDataSet1.DataSetName = "LibraryDatabaseDataSet1"
        Me.LibraryDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginTransactionsTableAdapter
        '
        Me.LoginTransactionsTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 625)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1090, 42)
        Me.Panel1.TabIndex = 39
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(953, 7)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(110, 23)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print Login Report"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmLoginReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 667)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoginReportView"
        Me.Text = "LoginReportView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LibraryDatabaseDataSet1 As LibraryDatabaseDataSet1
    Friend WithEvents LoginTransactionsBindingSource As BindingSource
    Friend WithEvents LoginTransactionsTableAdapter As LibraryDatabaseDataSet1TableAdapters.LoginTransactionsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibrarianIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastLoginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
