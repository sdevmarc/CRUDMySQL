<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAttendance = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idnumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_FN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_yearlevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAttendance
        '
        Me.dgvAttendance.AllowUserToAddRows = False
        Me.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAttendance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAttendance.ColumnHeadersHeight = 30
        Me.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAttendance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_idnumber, Me.col_LN, Me.col_FN, Me.col_course, Me.col_yearlevel, Me.col_address})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAttendance.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAttendance.EnableHeadersVisualStyles = False
        Me.dgvAttendance.Location = New System.Drawing.Point(0, 0)
        Me.dgvAttendance.Name = "dgvAttendance"
        Me.dgvAttendance.RowHeadersVisible = False
        Me.dgvAttendance.Size = New System.Drawing.Size(1062, 421)
        Me.dgvAttendance.TabIndex = 4
        '
        'col_id
        '
        Me.col_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_id.HeaderText = "#"
        Me.col_id.Name = "col_id"
        Me.col_id.Width = 40
        '
        'col_idnumber
        '
        Me.col_idnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_idnumber.HeaderText = "ID NUMBER"
        Me.col_idnumber.Name = "col_idnumber"
        '
        'col_LN
        '
        Me.col_LN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_LN.HeaderText = "LASTNAME"
        Me.col_LN.Name = "col_LN"
        '
        'col_FN
        '
        Me.col_FN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_FN.HeaderText = "FIRSTNAME"
        Me.col_FN.Name = "col_FN"
        '
        'col_course
        '
        Me.col_course.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_course.HeaderText = "COURSE"
        Me.col_course.Name = "col_course"
        '
        'col_yearlevel
        '
        Me.col_yearlevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_yearlevel.HeaderText = "YEAR LEVEL"
        Me.col_yearlevel.Name = "col_yearlevel"
        '
        'col_address
        '
        Me.col_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_address.HeaderText = "ADDRESS"
        Me.col_address.Name = "col_address"
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 421)
        Me.Controls.Add(Me.dgvAttendance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(5, 96)
        Me.Name = "Attendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Attendance"
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_idnumber As DataGridViewTextBoxColumn
    Friend WithEvents col_LN As DataGridViewTextBoxColumn
    Friend WithEvents col_FN As DataGridViewTextBoxColumn
    Friend WithEvents col_course As DataGridViewTextBoxColumn
    Friend WithEvents col_yearlevel As DataGridViewTextBoxColumn
    Friend WithEvents col_address As DataGridViewTextBoxColumn
End Class
