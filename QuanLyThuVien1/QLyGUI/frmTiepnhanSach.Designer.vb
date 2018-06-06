<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTiepnhanSach
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
        Me.lbMaSach = New System.Windows.Forms.Label()
        Me.cbStatusID = New System.Windows.Forms.ComboBox()
        Me.lbMaHienTrang = New System.Windows.Forms.Label()
        Me.cbPublishingHouseID = New System.Windows.Forms.ComboBox()
        Me.cbBookID = New System.Windows.Forms.ComboBox()
        Me.lbTenSach = New System.Windows.Forms.Label()
        Me.btThemSach = New System.Windows.Forms.Button()
        Me.dtpReceiptDate = New System.Windows.Forms.DateTimePicker()
        Me.txbValue = New System.Windows.Forms.TextBox()
        Me.txbPublishingYear = New System.Windows.Forms.TextBox()
        Me.cbAuthorID = New System.Windows.Forms.ComboBox()
        Me.cbBookKindID = New System.Windows.Forms.ComboBox()
        Me.txbBookName = New System.Windows.Forms.TextBox()
        Me.lbMaTheLoai = New System.Windows.Forms.Label()
        Me.lbTriGia = New System.Windows.Forms.Label()
        Me.lbNgayNhap = New System.Windows.Forms.Label()
        Me.lbMaNhaXuatBan = New System.Windows.Forms.Label()
        Me.lbNamXuatBan = New System.Windows.Forms.Label()
        Me.lbMaTacGia = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Add_button = New System.Windows.Forms.Button()
        Me.Update_button = New System.Windows.Forms.Button()
        Me.Delete_button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbMaSach
        '
        Me.lbMaSach.AutoSize = True
        Me.lbMaSach.Location = New System.Drawing.Point(6, 26)
        Me.lbMaSach.Name = "lbMaSach"
        Me.lbMaSach.Size = New System.Drawing.Size(48, 13)
        Me.lbMaSach.TabIndex = 17
        Me.lbMaSach.Text = "Mã sách"
        '
        'cbStatusID
        '
        Me.cbStatusID.FormattingEnabled = True
        Me.cbStatusID.Location = New System.Drawing.Point(428, 119)
        Me.cbStatusID.Name = "cbStatusID"
        Me.cbStatusID.Size = New System.Drawing.Size(200, 21)
        Me.cbStatusID.TabIndex = 21
        '
        'lbMaHienTrang
        '
        Me.lbMaHienTrang.AutoSize = True
        Me.lbMaHienTrang.Location = New System.Drawing.Point(328, 122)
        Me.lbMaHienTrang.Name = "lbMaHienTrang"
        Me.lbMaHienTrang.Size = New System.Drawing.Size(72, 13)
        Me.lbMaHienTrang.TabIndex = 20
        Me.lbMaHienTrang.Text = "Mã hiện trạng"
        '
        'cbPublishingHouseID
        '
        Me.cbPublishingHouseID.FormattingEnabled = True
        Me.cbPublishingHouseID.Location = New System.Drawing.Point(106, 155)
        Me.cbPublishingHouseID.Name = "cbPublishingHouseID"
        Me.cbPublishingHouseID.Size = New System.Drawing.Size(200, 21)
        Me.cbPublishingHouseID.TabIndex = 19
        '
        'cbBookID
        '
        Me.cbBookID.FormattingEnabled = True
        Me.cbBookID.Location = New System.Drawing.Point(106, 23)
        Me.cbBookID.Name = "cbBookID"
        Me.cbBookID.Size = New System.Drawing.Size(200, 21)
        Me.cbBookID.TabIndex = 18
        '
        'lbTenSach
        '
        Me.lbTenSach.AutoSize = True
        Me.lbTenSach.Location = New System.Drawing.Point(6, 58)
        Me.lbTenSach.Name = "lbTenSach"
        Me.lbTenSach.Size = New System.Drawing.Size(52, 13)
        Me.lbTenSach.TabIndex = 0
        Me.lbTenSach.Text = "Tên sách"
        '
        'btThemSach
        '
        Me.btThemSach.Location = New System.Drawing.Point(973, 467)
        Me.btThemSach.Name = "btThemSach"
        Me.btThemSach.Size = New System.Drawing.Size(75, 23)
        Me.btThemSach.TabIndex = 15
        Me.btThemSach.Text = "Thêm sách"
        Me.btThemSach.UseVisualStyleBackColor = True
        '
        'dtpReceiptDate
        '
        Me.dtpReceiptDate.Location = New System.Drawing.Point(428, 52)
        Me.dtpReceiptDate.Name = "dtpReceiptDate"
        Me.dtpReceiptDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpReceiptDate.TabIndex = 14
        '
        'txbValue
        '
        Me.txbValue.Location = New System.Drawing.Point(428, 86)
        Me.txbValue.Name = "txbValue"
        Me.txbValue.Size = New System.Drawing.Size(200, 20)
        Me.txbValue.TabIndex = 13
        '
        'txbPublishingYear
        '
        Me.txbPublishingYear.Location = New System.Drawing.Point(428, 23)
        Me.txbPublishingYear.Name = "txbPublishingYear"
        Me.txbPublishingYear.Size = New System.Drawing.Size(200, 20)
        Me.txbPublishingYear.TabIndex = 11
        '
        'cbAuthorID
        '
        Me.cbAuthorID.FormattingEnabled = True
        Me.cbAuthorID.Location = New System.Drawing.Point(106, 119)
        Me.cbAuthorID.Name = "cbAuthorID"
        Me.cbAuthorID.Size = New System.Drawing.Size(200, 21)
        Me.cbAuthorID.TabIndex = 10
        '
        'cbBookKindID
        '
        Me.cbBookKindID.FormattingEnabled = True
        Me.cbBookKindID.Location = New System.Drawing.Point(106, 86)
        Me.cbBookKindID.Name = "cbBookKindID"
        Me.cbBookKindID.Size = New System.Drawing.Size(200, 21)
        Me.cbBookKindID.TabIndex = 9
        '
        'txbBookName
        '
        Me.txbBookName.Location = New System.Drawing.Point(106, 55)
        Me.txbBookName.Name = "txbBookName"
        Me.txbBookName.Size = New System.Drawing.Size(200, 20)
        Me.txbBookName.TabIndex = 8
        '
        'lbMaTheLoai
        '
        Me.lbMaTheLoai.AutoSize = True
        Me.lbMaTheLoai.Location = New System.Drawing.Point(6, 89)
        Me.lbMaTheLoai.Name = "lbMaTheLoai"
        Me.lbMaTheLoai.Size = New System.Drawing.Size(59, 13)
        Me.lbMaTheLoai.TabIndex = 7
        Me.lbMaTheLoai.Text = "Mã thể loại"
        '
        'lbTriGia
        '
        Me.lbTriGia.AutoSize = True
        Me.lbTriGia.Location = New System.Drawing.Point(328, 89)
        Me.lbTriGia.Name = "lbTriGia"
        Me.lbTriGia.Size = New System.Drawing.Size(36, 13)
        Me.lbTriGia.TabIndex = 6
        Me.lbTriGia.Text = "Trị giá"
        '
        'lbNgayNhap
        '
        Me.lbNgayNhap.AutoSize = True
        Me.lbNgayNhap.Location = New System.Drawing.Point(328, 58)
        Me.lbNgayNhap.Name = "lbNgayNhap"
        Me.lbNgayNhap.Size = New System.Drawing.Size(59, 13)
        Me.lbNgayNhap.TabIndex = 5
        Me.lbNgayNhap.Text = "Ngày nhập"
        '
        'lbMaNhaXuatBan
        '
        Me.lbMaNhaXuatBan.AutoSize = True
        Me.lbMaNhaXuatBan.Location = New System.Drawing.Point(6, 158)
        Me.lbMaNhaXuatBan.Name = "lbMaNhaXuatBan"
        Me.lbMaNhaXuatBan.Size = New System.Drawing.Size(87, 13)
        Me.lbMaNhaXuatBan.TabIndex = 4
        Me.lbMaNhaXuatBan.Text = "Mã nhà xuất bản"
        '
        'lbNamXuatBan
        '
        Me.lbNamXuatBan.AutoSize = True
        Me.lbNamXuatBan.Location = New System.Drawing.Point(328, 26)
        Me.lbNamXuatBan.Name = "lbNamXuatBan"
        Me.lbNamXuatBan.Size = New System.Drawing.Size(73, 13)
        Me.lbNamXuatBan.TabIndex = 3
        Me.lbNamXuatBan.Text = "Năm xuất bản"
        '
        'lbMaTacGia
        '
        Me.lbMaTacGia.AutoSize = True
        Me.lbMaTacGia.Location = New System.Drawing.Point(6, 122)
        Me.lbMaTacGia.Name = "lbMaTacGia"
        Me.lbMaTacGia.Size = New System.Drawing.Size(57, 13)
        Me.lbMaTacGia.TabIndex = 2
        Me.lbMaTacGia.Text = "Mã tác giả"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 55)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quản lý sách"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbMaSach)
        Me.GroupBox2.Controls.Add(Me.cbBookID)
        Me.GroupBox2.Controls.Add(Me.cbStatusID)
        Me.GroupBox2.Controls.Add(Me.lbTenSach)
        Me.GroupBox2.Controls.Add(Me.lbMaHienTrang)
        Me.GroupBox2.Controls.Add(Me.txbBookName)
        Me.GroupBox2.Controls.Add(Me.cbPublishingHouseID)
        Me.GroupBox2.Controls.Add(Me.txbValue)
        Me.GroupBox2.Controls.Add(Me.dtpReceiptDate)
        Me.GroupBox2.Controls.Add(Me.lbTriGia)
        Me.GroupBox2.Controls.Add(Me.lbMaTheLoai)
        Me.GroupBox2.Controls.Add(Me.cbBookKindID)
        Me.GroupBox2.Controls.Add(Me.lbMaTacGia)
        Me.GroupBox2.Controls.Add(Me.lbNgayNhap)
        Me.GroupBox2.Controls.Add(Me.cbAuthorID)
        Me.GroupBox2.Controls.Add(Me.txbPublishingYear)
        Me.GroupBox2.Controls.Add(Me.lbNamXuatBan)
        Me.GroupBox2.Controls.Add(Me.lbMaNhaXuatBan)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(639, 189)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nhập đầy đủ các thông tin"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Delete_button)
        Me.GroupBox3.Controls.Add(Me.Update_button)
        Me.GroupBox3.Controls.Add(Me.Add_button)
        Me.GroupBox3.Location = New System.Drawing.Point(657, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(125, 189)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chức năng"
        '
        'Add_button
        '
        Me.Add_button.Location = New System.Drawing.Point(21, 41)
        Me.Add_button.Name = "Add_button"
        Me.Add_button.Size = New System.Drawing.Size(88, 30)
        Me.Add_button.TabIndex = 0
        Me.Add_button.Text = "Thêm"
        Me.Add_button.UseVisualStyleBackColor = True
        '
        'Update_button
        '
        Me.Update_button.Location = New System.Drawing.Point(21, 80)
        Me.Update_button.Name = "Update_button"
        Me.Update_button.Size = New System.Drawing.Size(88, 30)
        Me.Update_button.TabIndex = 1
        Me.Update_button.Text = "Sửa"
        Me.Update_button.UseVisualStyleBackColor = True
        '
        'Delete_button
        '
        Me.Delete_button.Location = New System.Drawing.Point(21, 122)
        Me.Delete_button.Name = "Delete_button"
        Me.Delete_button.Size = New System.Drawing.Size(88, 30)
        Me.Delete_button.TabIndex = 2
        Me.Delete_button.Text = "Xóa"
        Me.Delete_button.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(770, 226)
        Me.DataGridView1.TabIndex = 25
        '
        'frmTiepnhanSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 561)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btThemSach)
        Me.Name = "frmTiepnhanSach"
        Me.Text = "tiepnhanSach"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbMaSach As Label
    Friend WithEvents cbStatusID As ComboBox
    Friend WithEvents lbMaHienTrang As Label
    Friend WithEvents cbPublishingHouseID As ComboBox
    Friend WithEvents cbBookID As ComboBox
    Friend WithEvents lbTenSach As Label
    Friend WithEvents btThemSach As Button
    Friend WithEvents dtpReceiptDate As DateTimePicker
    Friend WithEvents txbValue As TextBox
    Friend WithEvents txbPublishingYear As TextBox
    Friend WithEvents cbAuthorID As ComboBox
    Friend WithEvents cbBookKindID As ComboBox
    Friend WithEvents txbBookName As TextBox
    Friend WithEvents lbMaTheLoai As Label
    Friend WithEvents lbTriGia As Label
    Friend WithEvents lbNgayNhap As Label
    Friend WithEvents lbMaNhaXuatBan As Label
    Friend WithEvents lbNamXuatBan As Label
    Friend WithEvents lbMaTacGia As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Add_button As Button
    Friend WithEvents Delete_button As Button
    Friend WithEvents Update_button As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
