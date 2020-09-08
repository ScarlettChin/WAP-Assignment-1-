<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.palHome = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconButtonLogOut = New FontAwesome.Sharp.IconButton()
        Me.IconButtonLoginReport = New FontAwesome.Sharp.IconButton()
        Me.IconButtonPayment = New FontAwesome.Sharp.IconButton()
        Me.IconButtonStudent = New FontAwesome.Sharp.IconButton()
        Me.IconButtonLibrarian = New FontAwesome.Sharp.IconButton()
        Me.IconButtonBook = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'palHome
        '
        Me.palHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.palHome.Location = New System.Drawing.Point(173, 0)
        Me.palHome.Name = "palHome"
        Me.palHome.Size = New System.Drawing.Size(917, 596)
        Me.palHome.TabIndex = 33
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconButtonLogOut)
        Me.PanelMenu.Controls.Add(Me.IconButtonLoginReport)
        Me.PanelMenu.Controls.Add(Me.IconButtonPayment)
        Me.PanelMenu.Controls.Add(Me.IconButtonStudent)
        Me.PanelMenu.Controls.Add(Me.IconButtonLibrarian)
        Me.PanelMenu.Controls.Add(Me.IconButtonBook)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(173, 596)
        Me.PanelMenu.TabIndex = 32
        '
        'IconButtonLogOut
        '
        Me.IconButtonLogOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonLogOut.FlatAppearance.BorderSize = 0
        Me.IconButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonLogOut.ForeColor = System.Drawing.Color.Black
        Me.IconButtonLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.IconButtonLogOut.IconColor = System.Drawing.Color.Black
        Me.IconButtonLogOut.IconSize = 32
        Me.IconButtonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonLogOut.Location = New System.Drawing.Point(0, 387)
        Me.IconButtonLogOut.Margin = New System.Windows.Forms.Padding(2)
        Me.IconButtonLogOut.Name = "IconButtonLogOut"
        Me.IconButtonLogOut.Padding = New System.Windows.Forms.Padding(8, 0, 15, 0)
        Me.IconButtonLogOut.Rotation = 0R
        Me.IconButtonLogOut.Size = New System.Drawing.Size(173, 53)
        Me.IconButtonLogOut.TabIndex = 15
        Me.IconButtonLogOut.Text = "Log Out"
        Me.IconButtonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonLogOut.UseVisualStyleBackColor = True
        '
        'IconButtonLoginReport
        '
        Me.IconButtonLoginReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonLoginReport.FlatAppearance.BorderSize = 0
        Me.IconButtonLoginReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonLoginReport.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonLoginReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonLoginReport.ForeColor = System.Drawing.Color.Black
        Me.IconButtonLoginReport.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows
        Me.IconButtonLoginReport.IconColor = System.Drawing.Color.Black
        Me.IconButtonLoginReport.IconSize = 32
        Me.IconButtonLoginReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonLoginReport.Location = New System.Drawing.Point(0, 333)
        Me.IconButtonLoginReport.Margin = New System.Windows.Forms.Padding(2)
        Me.IconButtonLoginReport.Name = "IconButtonLoginReport"
        Me.IconButtonLoginReport.Padding = New System.Windows.Forms.Padding(8, 0, 15, 0)
        Me.IconButtonLoginReport.Rotation = 0R
        Me.IconButtonLoginReport.Size = New System.Drawing.Size(173, 54)
        Me.IconButtonLoginReport.TabIndex = 16
        Me.IconButtonLoginReport.Text = "Login Report"
        Me.IconButtonLoginReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonLoginReport.UseVisualStyleBackColor = True
        '
        'IconButtonPayment
        '
        Me.IconButtonPayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonPayment.FlatAppearance.BorderSize = 0
        Me.IconButtonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonPayment.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonPayment.ForeColor = System.Drawing.Color.Black
        Me.IconButtonPayment.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave
        Me.IconButtonPayment.IconColor = System.Drawing.Color.Black
        Me.IconButtonPayment.IconSize = 32
        Me.IconButtonPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPayment.Location = New System.Drawing.Point(0, 279)
        Me.IconButtonPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.IconButtonPayment.Name = "IconButtonPayment"
        Me.IconButtonPayment.Padding = New System.Windows.Forms.Padding(8, 0, 15, 0)
        Me.IconButtonPayment.Rotation = 0R
        Me.IconButtonPayment.Size = New System.Drawing.Size(173, 54)
        Me.IconButtonPayment.TabIndex = 14
        Me.IconButtonPayment.Text = "Payment"
        Me.IconButtonPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonPayment.UseVisualStyleBackColor = True
        '
        'IconButtonStudent
        '
        Me.IconButtonStudent.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonStudent.FlatAppearance.BorderSize = 0
        Me.IconButtonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonStudent.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonStudent.ForeColor = System.Drawing.Color.Black
        Me.IconButtonStudent.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconButtonStudent.IconColor = System.Drawing.Color.Black
        Me.IconButtonStudent.IconSize = 32
        Me.IconButtonStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonStudent.Location = New System.Drawing.Point(0, 219)
        Me.IconButtonStudent.Margin = New System.Windows.Forms.Padding(2)
        Me.IconButtonStudent.Name = "IconButtonStudent"
        Me.IconButtonStudent.Padding = New System.Windows.Forms.Padding(8, 0, 15, 0)
        Me.IconButtonStudent.Rotation = 0R
        Me.IconButtonStudent.Size = New System.Drawing.Size(173, 60)
        Me.IconButtonStudent.TabIndex = 12
        Me.IconButtonStudent.Text = "Student"
        Me.IconButtonStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonStudent.UseVisualStyleBackColor = True
        '
        'IconButtonLibrarian
        '
        Me.IconButtonLibrarian.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonLibrarian.FlatAppearance.BorderSize = 0
        Me.IconButtonLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonLibrarian.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonLibrarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonLibrarian.ForeColor = System.Drawing.Color.Black
        Me.IconButtonLibrarian.IconChar = FontAwesome.Sharp.IconChar.UserTie
        Me.IconButtonLibrarian.IconColor = System.Drawing.Color.Black
        Me.IconButtonLibrarian.IconSize = 32
        Me.IconButtonLibrarian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonLibrarian.Location = New System.Drawing.Point(0, 165)
        Me.IconButtonLibrarian.Margin = New System.Windows.Forms.Padding(2)
        Me.IconButtonLibrarian.Name = "IconButtonLibrarian"
        Me.IconButtonLibrarian.Padding = New System.Windows.Forms.Padding(8, 0, 15, 0)
        Me.IconButtonLibrarian.Rotation = 0R
        Me.IconButtonLibrarian.Size = New System.Drawing.Size(173, 54)
        Me.IconButtonLibrarian.TabIndex = 9
        Me.IconButtonLibrarian.Text = "Librarian"
        Me.IconButtonLibrarian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonLibrarian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonLibrarian.UseVisualStyleBackColor = True
        '
        'IconButtonBook
        '
        Me.IconButtonBook.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonBook.FlatAppearance.BorderSize = 0
        Me.IconButtonBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonBook.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonBook.ForeColor = System.Drawing.Color.Black
        Me.IconButtonBook.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.IconButtonBook.IconColor = System.Drawing.Color.Black
        Me.IconButtonBook.IconSize = 32
        Me.IconButtonBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonBook.Location = New System.Drawing.Point(0, 114)
        Me.IconButtonBook.Margin = New System.Windows.Forms.Padding(2)
        Me.IconButtonBook.Name = "IconButtonBook"
        Me.IconButtonBook.Padding = New System.Windows.Forms.Padding(8, 0, 15, 0)
        Me.IconButtonBook.Rotation = 0R
        Me.IconButtonBook.Size = New System.Drawing.Size(173, 51)
        Me.IconButtonBook.TabIndex = 4
        Me.IconButtonBook.Text = "Book"
        Me.IconButtonBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonBook.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 114)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1090, 596)
        Me.Controls.Add(Me.palHome)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "frmMainMenu"
        Me.Text = "TARUC Library System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents palHome As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents IconButtonBook As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconButtonLogOut As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonPayment As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonStudent As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonLibrarian As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonLoginReport As FontAwesome.Sharp.IconButton
End Class
