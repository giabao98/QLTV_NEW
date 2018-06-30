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
        Me.btnQuyDinhMuonSach = New System.Windows.Forms.Button()
        Me.btnQuyDinhDocGia = New System.Windows.Forms.Button()
        Me.btnQuyDinhTheLoaiSach = New System.Windows.Forms.Button()
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
        Me.gbThayDoiQuyDinh.Controls.Add(Me.btnQuyDinhMuonSach)
        Me.gbThayDoiQuyDinh.Controls.Add(Me.btnQuyDinhDocGia)
        Me.gbThayDoiQuyDinh.Controls.Add(Me.btnQuyDinhTheLoaiSach)
        Me.gbThayDoiQuyDinh.Location = New System.Drawing.Point(16, 59)
        Me.gbThayDoiQuyDinh.Margin = New System.Windows.Forms.Padding(4)
        Me.gbThayDoiQuyDinh.Name = "gbThayDoiQuyDinh"
        Me.gbThayDoiQuyDinh.Padding = New System.Windows.Forms.Padding(4)
        Me.gbThayDoiQuyDinh.Size = New System.Drawing.Size(456, 120)
        Me.gbThayDoiQuyDinh.TabIndex = 1
        Me.gbThayDoiQuyDinh.TabStop = False
        '
        'btnQuyDinhMuonSach
        '
        Me.btnQuyDinhMuonSach.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnQuyDinhMuonSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuyDinhMuonSach.Location = New System.Drawing.Point(165, 23)
        Me.btnQuyDinhMuonSach.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuyDinhMuonSach.Name = "btnQuyDinhMuonSach"
        Me.btnQuyDinhMuonSach.Size = New System.Drawing.Size(129, 79)
        Me.btnQuyDinhMuonSach.TabIndex = 2
        Me.btnQuyDinhMuonSach.Text = "Mượn sách"
        Me.btnQuyDinhMuonSach.UseVisualStyleBackColor = False
        '
        'btnQuyDinhDocGia
        '
        Me.btnQuyDinhDocGia.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnQuyDinhDocGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuyDinhDocGia.Location = New System.Drawing.Point(25, 23)
        Me.btnQuyDinhDocGia.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuyDinhDocGia.Name = "btnQuyDinhDocGia"
        Me.btnQuyDinhDocGia.Size = New System.Drawing.Size(129, 79)
        Me.btnQuyDinhDocGia.TabIndex = 1
        Me.btnQuyDinhDocGia.Text = "Tuổi đọc giả và hạn sử dụng thẻ"
        Me.btnQuyDinhDocGia.UseVisualStyleBackColor = False
        '
        'btnQuyDinhTheLoaiSach
        '
        Me.btnQuyDinhTheLoaiSach.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnQuyDinhTheLoaiSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuyDinhTheLoaiSach.Location = New System.Drawing.Point(305, 23)
        Me.btnQuyDinhTheLoaiSach.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuyDinhTheLoaiSach.Name = "btnQuyDinhTheLoaiSach"
        Me.btnQuyDinhTheLoaiSach.Size = New System.Drawing.Size(129, 79)
        Me.btnQuyDinhTheLoaiSach.TabIndex = 0
        Me.btnQuyDinhTheLoaiSach.Text = "Thể loại sách và năm xuất bản"
        Me.btnQuyDinhTheLoaiSach.UseVisualStyleBackColor = False
        '
        'frmThayDoiQuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(488, 199)
        Me.Controls.Add(Me.gbThayDoiQuyDinh)
        Me.Controls.Add(Me.lbThayDoiQuyDinh)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmThayDoiQuyDinh"
        Me.Text = "ThayDoiQuyDinh"
        Me.gbThayDoiQuyDinh.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbThayDoiQuyDinh As Label
    Friend WithEvents gbThayDoiQuyDinh As GroupBox
    Friend WithEvents btnQuyDinhTheLoaiSach As Button
    Friend WithEvents btnQuyDinhMuonSach As Button
    Friend WithEvents btnQuyDinhDocGia As Button
End Class
