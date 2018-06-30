<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaoTaiKhoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTaoTaiKhoan))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbNhapLaiMatKhau = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbMatKhau = New System.Windows.Forms.TextBox()
        Me.lbTenLoaiDocGia = New System.Windows.Forms.Label()
        Me.txbTenTaiKhoan = New System.Windows.Forms.TextBox()
        Me.lbMaLoaiDocGia = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Location = New System.Drawing.Point(406, 94)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(160, 207)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chức năng"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.txbNhapLaiMatKhau)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txbMatKhau)
        Me.GroupBox2.Controls.Add(Me.lbTenLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.txbTenTaiKhoan)
        Me.GroupBox2.Controls.Add(Me.lbMaLoaiDocGia)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 94)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(385, 207)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin chi tiết"
        '
        'txbNhapLaiMatKhau
        '
        Me.txbNhapLaiMatKhau.Location = New System.Drawing.Point(136, 129)
        Me.txbNhapLaiMatKhau.Margin = New System.Windows.Forms.Padding(4)
        Me.txbNhapLaiMatKhau.Name = "txbNhapLaiMatKhau"
        Me.txbNhapLaiMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbNhapLaiMatKhau.Size = New System.Drawing.Size(205, 22)
        Me.txbNhapLaiMatKhau.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nhập lại mật khẩu"
        '
        'txbMatKhau
        '
        Me.txbMatKhau.Location = New System.Drawing.Point(136, 86)
        Me.txbMatKhau.Margin = New System.Windows.Forms.Padding(4)
        Me.txbMatKhau.Name = "txbMatKhau"
        Me.txbMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbMatKhau.Size = New System.Drawing.Size(205, 22)
        Me.txbMatKhau.TabIndex = 21
        '
        'lbTenLoaiDocGia
        '
        Me.lbTenLoaiDocGia.AutoSize = True
        Me.lbTenLoaiDocGia.Location = New System.Drawing.Point(8, 90)
        Me.lbTenLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTenLoaiDocGia.Name = "lbTenLoaiDocGia"
        Me.lbTenLoaiDocGia.Size = New System.Drawing.Size(72, 17)
        Me.lbTenLoaiDocGia.TabIndex = 20
        Me.lbTenLoaiDocGia.Text = "Mật Khẩu:"
        '
        'txbTenTaiKhoan
        '
        Me.txbTenTaiKhoan.Location = New System.Drawing.Point(136, 43)
        Me.txbTenTaiKhoan.Margin = New System.Windows.Forms.Padding(4)
        Me.txbTenTaiKhoan.Name = "txbTenTaiKhoan"
        Me.txbTenTaiKhoan.Size = New System.Drawing.Size(205, 22)
        Me.txbTenTaiKhoan.TabIndex = 19
        '
        'lbMaLoaiDocGia
        '
        Me.lbMaLoaiDocGia.AutoSize = True
        Me.lbMaLoaiDocGia.Location = New System.Drawing.Point(8, 47)
        Me.lbMaLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaLoaiDocGia.Name = "lbMaLoaiDocGia"
        Me.lbMaLoaiDocGia.Size = New System.Drawing.Size(106, 17)
        Me.lbMaLoaiDocGia.TabIndex = 18
        Me.lbMaLoaiDocGia.Text = "Tên Tài Khoản:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(553, 74)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(177, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tạo tài khoản"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightGreen
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(25, 78)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 37)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Tạo"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(136, 170)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 21)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Hiện Mật Khẩu"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmTaoTaiKhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 314)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTaoTaiKhoan"
        Me.Text = "frmTaoTaiKhoan"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txbNhapLaiMatKhau As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbMatKhau As TextBox
    Friend WithEvents lbTenLoaiDocGia As Label
    Friend WithEvents txbTenTaiKhoan As TextBox
    Friend WithEvents lbMaLoaiDocGia As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
