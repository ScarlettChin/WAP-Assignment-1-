<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnBook
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnFine = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtFine = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAccessionNo = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtIssueDate = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtIssueTo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IssueBookDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.grpBox.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.IssueBookDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.grpBox)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 554)
        Me.Panel1.TabIndex = 0
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.Label1)
        Me.grpBox.Controls.Add(Me.Label2)
        Me.grpBox.Controls.Add(Me.Label3)
        Me.grpBox.Controls.Add(Me.Label4)
        Me.grpBox.Controls.Add(Me.btnSearch)
        Me.grpBox.Controls.Add(Me.btnReturn)
        Me.grpBox.Controls.Add(Me.btnFine)
        Me.grpBox.Controls.Add(Me.DateTimePicker2)
        Me.grpBox.Controls.Add(Me.Label5)
        Me.grpBox.Controls.Add(Me.DateTimePicker1)
        Me.grpBox.Controls.Add(Me.txtFine)
        Me.grpBox.Controls.Add(Me.Label6)
        Me.grpBox.Controls.Add(Me.Label7)
        Me.grpBox.Controls.Add(Me.Label8)
        Me.grpBox.Controls.Add(Me.txtAccessionNo)
        Me.grpBox.Controls.Add(Me.txtBookName)
        Me.grpBox.Controls.Add(Me.txtIssueDate)
        Me.grpBox.Controls.Add(Me.txtCategory)
        Me.grpBox.Controls.Add(Me.txtIssueTo)
        Me.grpBox.Location = New System.Drawing.Point(377, 130)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(395, 328)
        Me.grpBox.TabIndex = 27
        Me.grpBox.TabStop = False
        Me.grpBox.Text = "Return Book Detail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(29, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Accession No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(29, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Book Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(29, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(29, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Issue To"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(313, 26)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(176, 258)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(102, 42)
        Me.btnReturn.TabIndex = 18
        Me.btnReturn.Text = "Return Book"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnFine
        '
        Me.btnFine.Location = New System.Drawing.Point(32, 258)
        Me.btnFine.Name = "btnFine"
        Me.btnFine.Size = New System.Drawing.Size(102, 42)
        Me.btnFine.TabIndex = 19
        Me.btnFine.Text = "Pay Fine"
        Me.btnFine.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(175, 183)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(29, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Issue Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(176, 158)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(199, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'txtFine
        '
        Me.txtFine.Location = New System.Drawing.Point(175, 209)
        Me.txtFine.Name = "txtFine"
        Me.txtFine.Size = New System.Drawing.Size(100, 20)
        Me.txtFine.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(29, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Return Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(29, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Current Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(29, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fine"
        '
        'txtAccessionNo
        '
        Me.txtAccessionNo.Location = New System.Drawing.Point(176, 27)
        Me.txtAccessionNo.Name = "txtAccessionNo"
        Me.txtAccessionNo.Size = New System.Drawing.Size(122, 20)
        Me.txtAccessionNo.TabIndex = 9
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(176, 53)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(122, 20)
        Me.txtBookName.TabIndex = 10
        '
        'txtIssueDate
        '
        Me.txtIssueDate.Location = New System.Drawing.Point(176, 132)
        Me.txtIssueDate.Name = "txtIssueDate"
        Me.txtIssueDate.Size = New System.Drawing.Size(122, 20)
        Me.txtIssueDate.TabIndex = 15
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(176, 79)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(122, 20)
        Me.txtCategory.TabIndex = 11
        '
        'txtIssueTo
        '
        Me.txtIssueTo.Location = New System.Drawing.Point(176, 105)
        Me.txtIssueTo.Name = "txtIssueTo"
        Me.txtIssueTo.Size = New System.Drawing.Size(122, 20)
        Me.txtIssueTo.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.IssueBookDataGridView)
        Me.Panel2.Controls.Add(Me.btnResult)
        Me.Panel2.Controls.Add(Me.txtResult)
        Me.Panel2.Location = New System.Drawing.Point(25, 130)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 328)
        Me.Panel2.TabIndex = 25
        '
        'IssueBookDataGridView
        '
        Me.IssueBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssueBookDataGridView.Location = New System.Drawing.Point(14, 68)
        Me.IssueBookDataGridView.Name = "IssueBookDataGridView"
        Me.IssueBookDataGridView.Size = New System.Drawing.Size(293, 187)
        Me.IssueBookDataGridView.TabIndex = 2
        '
        'btnResult
        '
        Me.btnResult.Location = New System.Drawing.Point(218, 25)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(89, 23)
        Me.btnResult.TabIndex = 1
        Me.btnResult.Text = "Search Acc.No"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(14, 27)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(162, 20)
        Me.txtResult.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(790, 52)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "RETURN BOOK"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 515)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReturnBook"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IssueBookDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents grpBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnFine As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtFine As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAccessionNo As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtIssueDate As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtIssueTo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IssueBookDataGridView As DataGridView
    Friend WithEvents btnResult As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label9 As Label
End Class
