<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThayDoiQuyDinh
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
        Me.lbThayDoiQuyDinh = New System.Windows.Forms.Label()
        Me.gbThayDoiQuyDinh = New System.Windows.Forms.GroupBox()
        Me.btnLoaiDocGia = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gbThayDoiQuyDinh.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbThayDoiQuyDinh
        '
        Me.lbThayDoiQuyDinh.AutoSize = True
        Me.lbThayDoiQuyDinh.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThayDoiQuyDinh.Location = New System.Drawing.Point(96, 9)
        Me.lbThayDoiQuyDinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbThayDoiQuyDinh.Name = "lbThayDoiQuyDinh"
        Me.lbThayDoiQuyDinh.Size = New System.Drawing.Size(330, 45)
        Me.lbThayDoiQuyDinh.TabIndex = 0
        Me.lbThayDoiQuyDinh.Text = "Thay đổi quy định"
        '
        'gbThayDoiQuyDinh
        '
        Me.gbThayDoiQuyDinh.Controls.Add(Me.Button2)
        Me.gbThayDoiQuyDinh.Controls.Add(Me.Button1)
        Me.gbThayDoiQuyDinh.Controls.Add(Me.btnLoaiDocGia)
        Me.gbThayDoiQuyDinh.Location = New System.Drawing.Point(16, 59)
        Me.gbThayDoiQuyDinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbThayDoiQuyDinh.Name = "gbThayDoiQuyDinh"
        Me.gbThayDoiQuyDinh.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbThayDoiQuyDinh.Size = New System.Drawing.Size(456, 134)
        Me.gbThayDoiQuyDinh.TabIndex = 1
        Me.gbThayDoiQuyDinh.TabStop = False
        '
        'btnLoaiDocGia
        '
        Me.btnLoaiDocGia.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnLoaiDocGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoaiDocGia.Location = New System.Drawing.Point(8, 23)
        Me.btnLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLoaiDocGia.Name = "btnLoaiDocGia"
        Me.btnLoaiDocGia.Size = New System.Drawing.Size(129, 79)
        Me.btnLoaiDocGia.TabIndex = 0
        Me.btnLoaiDocGia.Text = "Loại đọc giả"
        Me.btnLoaiDocGia.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(157, 23)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 79)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Loại đọc giả"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(314, 23)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 79)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Loại đọc giả"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmThayDoiQuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(488, 228)
        Me.Controls.Add(Me.gbThayDoiQuyDinh)
        Me.Controls.Add(Me.lbThayDoiQuyDinh)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmThayDoiQuyDinh"
        Me.Text = "ThayDoiQuyDinh"
        Me.gbThayDoiQuyDinh.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbThayDoiQuyDinh As Label
    Friend WithEvents gbThayDoiQuyDinh As GroupBox
    Friend WithEvents btnLoaiDocGia As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
