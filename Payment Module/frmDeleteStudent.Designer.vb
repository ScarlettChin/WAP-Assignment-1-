﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDeleteStudent
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
        Dim StudentIdLabel As System.Windows.Forms.Label
        Dim StudentNameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Me.StudentDatabaseDataSet = New Payment_Module.StudentDatabaseDataSet()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New Payment_Module.StudentDatabaseDataSetTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New Payment_Module.StudentDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.StudentIdTextBox = New System.Windows.Forms.TextBox()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.CourseComboBox = New System.Windows.Forms.ComboBox()
        Me.TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeleteCancel = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        StudentIdLabel = New System.Windows.Forms.Label()
        StudentNameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        CType(Me.StudentDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentIdLabel
        '
        StudentIdLabel.AutoSize = True
        StudentIdLabel.Location = New System.Drawing.Point(65, 69)
        StudentIdLabel.Name = "StudentIdLabel"
        StudentIdLabel.Size = New System.Drawing.Size(76, 17)
        StudentIdLabel.TabIndex = 1
        StudentIdLabel.Text = "Student Id:"
        '
        'StudentNameLabel
        '
        StudentNameLabel.AutoSize = True
        StudentNameLabel.Location = New System.Drawing.Point(65, 97)
        StudentNameLabel.Name = "StudentNameLabel"
        StudentNameLabel.Size = New System.Drawing.Size(102, 17)
        StudentNameLabel.TabIndex = 3
        StudentNameLabel.Text = "Student Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(65, 125)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(37, 17)
        AgeLabel.TabIndex = 5
        AgeLabel.Text = "Age:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(65, 153)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(60, 17)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(65, 184)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(57, 17)
        CourseLabel.TabIndex = 9
        CourseLabel.Text = "Course:"
        '
        'StudentDatabaseDataSet
        '
        Me.StudentDatabaseDataSet.DataSetName = "StudentDatabaseDataSet"
        Me.StudentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.StudentDatabaseDataSet
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Payment_Module.StudentDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentIdTextBox
        '
        Me.StudentIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "StudentId", True))
        Me.StudentIdTextBox.Location = New System.Drawing.Point(173, 66)
        Me.StudentIdTextBox.Name = "StudentIdTextBox"
        Me.StudentIdTextBox.Size = New System.Drawing.Size(253, 22)
        Me.StudentIdTextBox.TabIndex = 2
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "StudentName", True))
        Me.StudentNameTextBox.Location = New System.Drawing.Point(173, 94)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(253, 22)
        Me.StudentNameTextBox.TabIndex = 4
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(173, 122)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(253, 22)
        Me.AgeTextBox.TabIndex = 6
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(173, 150)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(253, 24)
        Me.GenderComboBox.TabIndex = 8
        '
        'CourseComboBox
        '
        Me.CourseComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Course", True))
        Me.CourseComboBox.FormattingEnabled = True
        Me.CourseComboBox.Location = New System.Drawing.Point(173, 181)
        Me.CourseComboBox.Name = "CourseComboBox"
        Me.CourseComboBox.Size = New System.Drawing.Size(253, 24)
        Me.CourseComboBox.TabIndex = 10
        '
        'TableDataGridView
        '
        Me.TableDataGridView.AutoGenerateColumns = False
        Me.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TableDataGridView.DataSource = Me.TableBindingSource
        Me.TableDataGridView.Location = New System.Drawing.Point(12, 387)
        Me.TableDataGridView.Name = "TableDataGridView"
        Me.TableDataGridView.RowHeadersWidth = 51
        Me.TableDataGridView.RowTemplate.Height = 24
        Me.TableDataGridView.Size = New System.Drawing.Size(776, 220)
        Me.TableDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentId"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StudentName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StudentName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Course"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Course"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'btnDeleteCancel
        '
        Me.btnDeleteCancel.Location = New System.Drawing.Point(551, 84)
        Me.btnDeleteCancel.Name = "btnDeleteCancel"
        Me.btnDeleteCancel.Size = New System.Drawing.Size(82, 42)
        Me.btnDeleteCancel.TabIndex = 21
        Me.btnDeleteCancel.Text = "&Delete"
        Me.btnDeleteCancel.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(465, 296)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(77, 36)
        Me.btnLast.TabIndex = 20
        Me.btnLast.Text = "&Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(378, 296)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(82, 36)
        Me.btnPrevious.TabIndex = 19
        Me.btnPrevious.Text = "&Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(297, 296)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(76, 36)
        Me.btnNext.TabIndex = 18
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(213, 296)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(80, 36)
        Me.btnFirst.TabIndex = 17
        Me.btnFirst.Text = "&First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(551, 157)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(87, 48)
        Me.btnReturn.TabIndex = 23
        Me.btnReturn.Text = "&Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmDeleteStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 619)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnDeleteCancel)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.TableDataGridView)
        Me.Controls.Add(StudentIdLabel)
        Me.Controls.Add(Me.StudentIdTextBox)
        Me.Controls.Add(StudentNameLabel)
        Me.Controls.Add(Me.StudentNameTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(CourseLabel)
        Me.Controls.Add(Me.CourseComboBox)
        Me.Name = "frmDeleteStudent"
        Me.Text = "frmDeleteStudent"
        CType(Me.StudentDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentDatabaseDataSet As StudentDatabaseDataSet
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As StudentDatabaseDataSetTableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As StudentDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentIdTextBox As TextBox
    Friend WithEvents StudentNameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents CourseComboBox As ComboBox
    Friend WithEvents TableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteCancel As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnReturn As Button
End Class