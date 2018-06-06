<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLapthe
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
        Me.Add_button = New System.Windows.Forms.Button()
        Me.dtpNgayLapThe = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.cbLoaiDocGia = New System.Windows.Forms.ComboBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.txbDiaChi = New System.Windows.Forms.TextBox()
        Me.txbTenDocGia = New System.Windows.Forms.TextBox()
        Me.txbMaDocGia = New System.Windows.Forms.TextBox()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.lbNgayLapThe = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbLoaiDocGia = New System.Windows.Forms.Label()
        Me.lbTenDocGia = New System.Windows.Forms.Label()
        Me.lbMaDocGia = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Delete_button = New System.Windows.Forms.Button()
        Me.Update_button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Add_button
        '
        Me.Add_button.Location = New System.Drawing.Point(28, 19)
        Me.Add_button.Name = "Add_button"
        Me.Add_button.Size = New System.Drawing.Size(75, 23)
        Me.Add_button.TabIndex = 30
        Me.Add_button.Text = "Lập thẻ"
        Me.Add_button.UseVisualStyleBackColor = True
        '
        'dtpNgayLapThe
        '
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(415, 83)
        Me.dtpNgayLapThe.Name = "dtpNgayLapThe"
        Me.dtpNgayLapThe.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayLapThe.TabIndex = 29
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Location = New System.Drawing.Point(415, 53)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgaySinh.TabIndex = 28
        '
        'cbLoaiDocGia
        '
        Me.cbLoaiDocGia.FormattingEnabled = True
        Me.cbLoaiDocGia.Location = New System.Drawing.Point(415, 25)
        Me.cbLoaiDocGia.Name = "cbLoaiDocGia"
        Me.cbLoaiDocGia.Size = New System.Drawing.Size(200, 21)
        Me.cbLoaiDocGia.TabIndex = 27
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(89, 118)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(200, 20)
        Me.txbEmail.TabIndex = 26
        '
        'txbDiaChi
        '
        Me.txbDiaChi.Location = New System.Drawing.Point(89, 86)
        Me.txbDiaChi.Name = "txbDiaChi"
        Me.txbDiaChi.Size = New System.Drawing.Size(200, 20)
        Me.txbDiaChi.TabIndex = 25
        '
        'txbTenDocGia
        '
        Me.txbTenDocGia.Location = New System.Drawing.Point(89, 56)
        Me.txbTenDocGia.Name = "txbTenDocGia"
        Me.txbTenDocGia.Size = New System.Drawing.Size(200, 20)
        Me.txbTenDocGia.TabIndex = 24
        '
        'txbMaDocGia
        '
        Me.txbMaDocGia.Location = New System.Drawing.Point(89, 25)
        Me.txbMaDocGia.Name = "txbMaDocGia"
        Me.txbMaDocGia.Size = New System.Drawing.Size(200, 20)
        Me.txbMaDocGia.TabIndex = 23
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Location = New System.Drawing.Point(6, 89)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(40, 13)
        Me.lbDiaChi.TabIndex = 22
        Me.lbDiaChi.Text = "Địa chỉ"
        '
        'lbNgayLapThe
        '
        Me.lbNgayLapThe.AutoSize = True
        Me.lbNgayLapThe.Location = New System.Drawing.Point(332, 89)
        Me.lbNgayLapThe.Name = "lbNgayLapThe"
        Me.lbNgayLapThe.Size = New System.Drawing.Size(67, 13)
        Me.lbNgayLapThe.TabIndex = 21
        Me.lbNgayLapThe.Text = "Ngày lập thẻ"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(6, 121)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(32, 13)
        Me.lbEmail.TabIndex = 20
        Me.lbEmail.Text = "Email"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(332, 59)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(54, 13)
        Me.lbNgaySinh.TabIndex = 19
        Me.lbNgaySinh.Text = "Ngày sinh"
        '
        'lbLoaiDocGia
        '
        Me.lbLoaiDocGia.AutoSize = True
        Me.lbLoaiDocGia.Location = New System.Drawing.Point(332, 28)
        Me.lbLoaiDocGia.Name = "lbLoaiDocGia"
        Me.lbLoaiDocGia.Size = New System.Drawing.Size(66, 13)
        Me.lbLoaiDocGia.TabIndex = 18
        Me.lbLoaiDocGia.Text = "Loại độc giả"
        '
        'lbTenDocGia
        '
        Me.lbTenDocGia.AutoSize = True
        Me.lbTenDocGia.Location = New System.Drawing.Point(6, 56)
        Me.lbTenDocGia.Name = "lbTenDocGia"
        Me.lbTenDocGia.Size = New System.Drawing.Size(65, 13)
        Me.lbTenDocGia.TabIndex = 17
        Me.lbTenDocGia.Text = "Tên độc giả"
        '
        'lbMaDocGia
        '
        Me.lbMaDocGia.AutoSize = True
        Me.lbMaDocGia.Location = New System.Drawing.Point(6, 27)
        Me.lbMaDocGia.Name = "lbMaDocGia"
        Me.lbMaDocGia.Size = New System.Drawing.Size(61, 13)
        Me.lbMaDocGia.TabIndex = 16
        Me.lbMaDocGia.Text = "Mã độc giả"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 60)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(296, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quản lý đọc giả"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbMaDocGia)
        Me.GroupBox2.Controls.Add(Me.lbTenDocGia)
        Me.GroupBox2.Controls.Add(Me.lbEmail)
        Me.GroupBox2.Controls.Add(Me.dtpNgayLapThe)
        Me.GroupBox2.Controls.Add(Me.lbDiaChi)
        Me.GroupBox2.Controls.Add(Me.dtpNgaySinh)
        Me.GroupBox2.Controls.Add(Me.txbMaDocGia)
        Me.GroupBox2.Controls.Add(Me.cbLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.txbTenDocGia)
        Me.GroupBox2.Controls.Add(Me.lbNgayLapThe)
        Me.GroupBox2.Controls.Add(Me.txbEmail)
        Me.GroupBox2.Controls.Add(Me.lbNgaySinh)
        Me.GroupBox2.Controls.Add(Me.txbDiaChi)
        Me.GroupBox2.Controls.Add(Me.lbLoaiDocGia)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(628, 150)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Delete_button)
        Me.GroupBox3.Controls.Add(Me.Update_button)
        Me.GroupBox3.Controls.Add(Me.Add_button)
        Me.GroupBox3.Location = New System.Drawing.Point(646, 84)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(136, 144)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Delete_button
        '
        Me.Delete_button.Location = New System.Drawing.Point(28, 105)
        Me.Delete_button.Name = "Delete_button"
        Me.Delete_button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_button.TabIndex = 2
        Me.Delete_button.Text = "Xóa"
        Me.Delete_button.UseVisualStyleBackColor = True
        '
        'Update_button
        '
        Me.Update_button.Location = New System.Drawing.Point(28, 64)
        Me.Update_button.Name = "Update_button"
        Me.Update_button.Size = New System.Drawing.Size(75, 23)
        Me.Update_button.TabIndex = 1
        Me.Update_button.Text = "Sửa"
        Me.Update_button.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 234)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(770, 204)
        Me.DataGridView1.TabIndex = 34
        '
        'frmLapthe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLapthe"
        Me.Text = "frmLapthe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Add_button As Button
    Friend WithEvents dtpNgayLapThe As DateTimePicker
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents cbLoaiDocGia As ComboBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents txbDiaChi As TextBox
    Friend WithEvents txbTenDocGia As TextBox
    Friend WithEvents txbMaDocGia As TextBox
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents lbNgayLapThe As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lbLoaiDocGia As Label
    Friend WithEvents lbTenDocGia As Label
    Friend WithEvents lbMaDocGia As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Delete_button As Button
    Friend WithEvents Update_button As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
