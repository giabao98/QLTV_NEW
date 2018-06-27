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
        Me.gbThayDoiQuyDinh.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbThayDoiQuyDinh
        '
        Me.lbThayDoiQuyDinh.AutoSize = True
        Me.lbThayDoiQuyDinh.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThayDoiQuyDinh.Location = New System.Drawing.Point(124, 9)
        Me.lbThayDoiQuyDinh.Name = "lbThayDoiQuyDinh"
        Me.lbThayDoiQuyDinh.Size = New System.Drawing.Size(262, 36)
        Me.lbThayDoiQuyDinh.TabIndex = 0
        Me.lbThayDoiQuyDinh.Text = "Thay đổi quy định"
        '
        'gbThayDoiQuyDinh
        '
        Me.gbThayDoiQuyDinh.Controls.Add(Me.btnLoaiDocGia)
        Me.gbThayDoiQuyDinh.Location = New System.Drawing.Point(12, 48)
        Me.gbThayDoiQuyDinh.Name = "gbThayDoiQuyDinh"
        Me.gbThayDoiQuyDinh.Size = New System.Drawing.Size(523, 390)
        Me.gbThayDoiQuyDinh.TabIndex = 1
        Me.gbThayDoiQuyDinh.TabStop = False
        '
        'btnLoaiDocGia
        '
        Me.btnLoaiDocGia.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnLoaiDocGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoaiDocGia.Location = New System.Drawing.Point(6, 19)
        Me.btnLoaiDocGia.Name = "btnLoaiDocGia"
        Me.btnLoaiDocGia.Size = New System.Drawing.Size(97, 64)
        Me.btnLoaiDocGia.TabIndex = 0
        Me.btnLoaiDocGia.Text = "Loại đọc giả"
        Me.btnLoaiDocGia.UseVisualStyleBackColor = False
        '
        'frmThayDoiQuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(547, 450)
        Me.Controls.Add(Me.gbThayDoiQuyDinh)
        Me.Controls.Add(Me.lbThayDoiQuyDinh)
        Me.Name = "frmThayDoiQuyDinh"
        Me.Text = "ThayDoiQuyDinh"
        Me.gbThayDoiQuyDinh.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbThayDoiQuyDinh As Label
    Friend WithEvents gbThayDoiQuyDinh As GroupBox
    Friend WithEvents btnLoaiDocGia As Button
End Class
