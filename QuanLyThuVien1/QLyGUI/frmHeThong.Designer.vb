<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeThong
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
        Me.btnTaoTaiKhoan = New System.Windows.Forms.Button()
        Me.btnDoiMatKhau = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTaoTaiKhoan
        '
        Me.btnTaoTaiKhoan.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnTaoTaiKhoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnTaoTaiKhoan.Location = New System.Drawing.Point(18, 124)
        Me.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan"
        Me.btnTaoTaiKhoan.Size = New System.Drawing.Size(243, 81)
        Me.btnTaoTaiKhoan.TabIndex = 0
        Me.btnTaoTaiKhoan.Text = "Tạo Tài Khoản"
        Me.btnTaoTaiKhoan.UseVisualStyleBackColor = False
        '
        'btnDoiMatKhau
        '
        Me.btnDoiMatKhau.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnDoiMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnDoiMatKhau.Location = New System.Drawing.Point(288, 124)
        Me.btnDoiMatKhau.Name = "btnDoiMatKhau"
        Me.btnDoiMatKhau.Size = New System.Drawing.Size(243, 81)
        Me.btnDoiMatKhau.TabIndex = 1
        Me.btnDoiMatKhau.Text = "Đổi Mật Khẩu"
        Me.btnDoiMatKhau.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDoiMatKhau)
        Me.GroupBox1.Controls.Add(Me.btnTaoTaiKhoan)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 217)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 108)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(151, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HỆ THỐNG"
        '
        'frmHeThong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(567, 235)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHeThong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmHeThong"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTaoTaiKhoan As Button
    Friend WithEvents btnDoiMatKhau As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
End Class
