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
        Me.lbTenSach = New System.Windows.Forms.Label()
        Me.lbMaTacGia = New System.Windows.Forms.Label()
        Me.lbNamXuatBan = New System.Windows.Forms.Label()
        Me.lbMaNhaXuatBan = New System.Windows.Forms.Label()
        Me.lbNgayNhap = New System.Windows.Forms.Label()
        Me.lbTriGia = New System.Windows.Forms.Label()
        Me.lbMaTheLoai = New System.Windows.Forms.Label()
        Me.txbBookName = New System.Windows.Forms.TextBox()
        Me.cbBookKindID = New System.Windows.Forms.ComboBox()
        Me.cbAuthorID = New System.Windows.Forms.ComboBox()
        Me.txbPublishingYear = New System.Windows.Forms.TextBox()
        Me.tbValue = New System.Windows.Forms.TextBox()
        Me.dtpReceiptDate = New System.Windows.Forms.DateTimePicker()
        Me.btThemSach = New System.Windows.Forms.Button()
        Me.lbMaSach = New System.Windows.Forms.Label()
        Me.cbBookID = New System.Windows.Forms.ComboBox()
        Me.cbPublishingHouseID = New System.Windows.Forms.ComboBox()
        Me.lbMaHienTrang = New System.Windows.Forms.Label()
        Me.cbStatusID = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbTenSach
        '
        Me.lbTenSach.AutoSize = True
        Me.lbTenSach.Location = New System.Drawing.Point(40, 73)
        Me.lbTenSach.Name = "lbTenSach"
        Me.lbTenSach.Size = New System.Drawing.Size(52, 13)
        Me.lbTenSach.TabIndex = 0
        Me.lbTenSach.Text = "Tên sách"
        '
        'lbMaTacGia
        '
        Me.lbMaTacGia.AutoSize = True
        Me.lbMaTacGia.Location = New System.Drawing.Point(40, 173)
        Me.lbMaTacGia.Name = "lbMaTacGia"
        Me.lbMaTacGia.Size = New System.Drawing.Size(57, 13)
        Me.lbMaTacGia.TabIndex = 2
        Me.lbMaTacGia.Text = "Mã tác giả"
        '
        'lbNamXuatBan
        '
        Me.lbNamXuatBan.AutoSize = True
        Me.lbNamXuatBan.Location = New System.Drawing.Point(40, 223)
        Me.lbNamXuatBan.Name = "lbNamXuatBan"
        Me.lbNamXuatBan.Size = New System.Drawing.Size(73, 13)
        Me.lbNamXuatBan.TabIndex = 3
        Me.lbNamXuatBan.Text = "Năm xuất bản"
        '
        'lbMaNhaXuatBan
        '
        Me.lbMaNhaXuatBan.AutoSize = True
        Me.lbMaNhaXuatBan.Location = New System.Drawing.Point(40, 273)
        Me.lbMaNhaXuatBan.Name = "lbMaNhaXuatBan"
        Me.lbMaNhaXuatBan.Size = New System.Drawing.Size(87, 13)
        Me.lbMaNhaXuatBan.TabIndex = 4
        Me.lbMaNhaXuatBan.Text = "Mã nhà xuất bản"
        '
        'lbNgayNhap
        '
        Me.lbNgayNhap.AutoSize = True
        Me.lbNgayNhap.Location = New System.Drawing.Point(40, 323)
        Me.lbNgayNhap.Name = "lbNgayNhap"
        Me.lbNgayNhap.Size = New System.Drawing.Size(59, 13)
        Me.lbNgayNhap.TabIndex = 5
        Me.lbNgayNhap.Text = "Ngày nhập"
        '
        'lbTriGia
        '
        Me.lbTriGia.AutoSize = True
        Me.lbTriGia.Location = New System.Drawing.Point(40, 371)
        Me.lbTriGia.Name = "lbTriGia"
        Me.lbTriGia.Size = New System.Drawing.Size(36, 13)
        Me.lbTriGia.TabIndex = 6
        Me.lbTriGia.Text = "Trị giá"
        '
        'lbMaTheLoai
        '
        Me.lbMaTheLoai.AutoSize = True
        Me.lbMaTheLoai.Location = New System.Drawing.Point(40, 123)
        Me.lbMaTheLoai.Name = "lbMaTheLoai"
        Me.lbMaTheLoai.Size = New System.Drawing.Size(59, 13)
        Me.lbMaTheLoai.TabIndex = 7
        Me.lbMaTheLoai.Text = "Mã thể loại"
        '
        'txbBookName
        '
        Me.txbBookName.Location = New System.Drawing.Point(140, 70)
        Me.txbBookName.Name = "txbBookName"
        Me.txbBookName.Size = New System.Drawing.Size(200, 20)
        Me.txbBookName.TabIndex = 8
        '
        'cbBookKindID
        '
        Me.cbBookKindID.FormattingEnabled = True
        Me.cbBookKindID.Location = New System.Drawing.Point(140, 120)
        Me.cbBookKindID.Name = "cbBookKindID"
        Me.cbBookKindID.Size = New System.Drawing.Size(200, 21)
        Me.cbBookKindID.TabIndex = 9
        '
        'cbAuthorID
        '
        Me.cbAuthorID.FormattingEnabled = True
        Me.cbAuthorID.Location = New System.Drawing.Point(140, 170)
        Me.cbAuthorID.Name = "cbAuthorID"
        Me.cbAuthorID.Size = New System.Drawing.Size(200, 21)
        Me.cbAuthorID.TabIndex = 10
        '
        'txbPublishingYear
        '
        Me.txbPublishingYear.Location = New System.Drawing.Point(140, 220)
        Me.txbPublishingYear.Name = "txbPublishingYear"
        Me.txbPublishingYear.Size = New System.Drawing.Size(200, 20)
        Me.txbPublishingYear.TabIndex = 11
        '
        'tbValue
        '
        Me.tbValue.Location = New System.Drawing.Point(140, 368)
        Me.tbValue.Name = "tbValue"
        Me.tbValue.Size = New System.Drawing.Size(200, 20)
        Me.tbValue.TabIndex = 13
        '
        'dtpReceiptDate
        '
        Me.dtpReceiptDate.Location = New System.Drawing.Point(140, 317)
        Me.dtpReceiptDate.Name = "dtpReceiptDate"
        Me.dtpReceiptDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpReceiptDate.TabIndex = 14
        '
        'btThemSach
        '
        Me.btThemSach.Location = New System.Drawing.Point(140, 487)
        Me.btThemSach.Name = "btThemSach"
        Me.btThemSach.Size = New System.Drawing.Size(75, 23)
        Me.btThemSach.TabIndex = 15
        Me.btThemSach.Text = "Thêm sách"
        Me.btThemSach.UseVisualStyleBackColor = True
        '
        'lbMaSach
        '
        Me.lbMaSach.AutoSize = True
        Me.lbMaSach.Location = New System.Drawing.Point(40, 29)
        Me.lbMaSach.Name = "lbMaSach"
        Me.lbMaSach.Size = New System.Drawing.Size(48, 13)
        Me.lbMaSach.TabIndex = 17
        Me.lbMaSach.Text = "Mã sách"
        '
        'cbBookID
        '
        Me.cbBookID.FormattingEnabled = True
        Me.cbBookID.Location = New System.Drawing.Point(140, 26)
        Me.cbBookID.Name = "cbBookID"
        Me.cbBookID.Size = New System.Drawing.Size(200, 21)
        Me.cbBookID.TabIndex = 18
        '
        'cbPublishingHouseID
        '
        Me.cbPublishingHouseID.FormattingEnabled = True
        Me.cbPublishingHouseID.Location = New System.Drawing.Point(140, 270)
        Me.cbPublishingHouseID.Name = "cbPublishingHouseID"
        Me.cbPublishingHouseID.Size = New System.Drawing.Size(200, 21)
        Me.cbPublishingHouseID.TabIndex = 19
        '
        'lbMaHienTrang
        '
        Me.lbMaHienTrang.AutoSize = True
        Me.lbMaHienTrang.Location = New System.Drawing.Point(40, 428)
        Me.lbMaHienTrang.Name = "lbMaHienTrang"
        Me.lbMaHienTrang.Size = New System.Drawing.Size(72, 13)
        Me.lbMaHienTrang.TabIndex = 20
        Me.lbMaHienTrang.Text = "Mã hiện trạng"
        '
        'cbStatusID
        '
        Me.cbStatusID.FormattingEnabled = True
        Me.cbStatusID.Location = New System.Drawing.Point(140, 425)
        Me.cbStatusID.Name = "cbStatusID"
        Me.cbStatusID.Size = New System.Drawing.Size(200, 21)
        Me.cbStatusID.TabIndex = 21
        '
        'frmTiepnhanSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 522)
        Me.Controls.Add(Me.cbStatusID)
        Me.Controls.Add(Me.lbMaHienTrang)
        Me.Controls.Add(Me.cbPublishingHouseID)
        Me.Controls.Add(Me.cbBookID)
        Me.Controls.Add(Me.lbMaSach)
        Me.Controls.Add(Me.btThemSach)
        Me.Controls.Add(Me.dtpReceiptDate)
        Me.Controls.Add(Me.tbValue)
        Me.Controls.Add(Me.txbPublishingYear)
        Me.Controls.Add(Me.cbAuthorID)
        Me.Controls.Add(Me.cbBookKindID)
        Me.Controls.Add(Me.txbBookName)
        Me.Controls.Add(Me.lbMaTheLoai)
        Me.Controls.Add(Me.lbTriGia)
        Me.Controls.Add(Me.lbNgayNhap)
        Me.Controls.Add(Me.lbMaNhaXuatBan)
        Me.Controls.Add(Me.lbNamXuatBan)
        Me.Controls.Add(Me.lbMaTacGia)
        Me.Controls.Add(Me.lbTenSach)
        Me.Name = "frmTiepnhanSach"
        Me.Text = "tiepnhanSach"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTenSach As Label
    Friend WithEvents lbMaTacGia As Label
    Friend WithEvents lbNamXuatBan As Label
    Friend WithEvents lbMaNhaXuatBan As Label
    Friend WithEvents lbNgayNhap As Label
    Friend WithEvents lbTriGia As Label
    Friend WithEvents lbMaTheLoai As Label
    Friend WithEvents txbBookName As TextBox
    Friend WithEvents cbBookKindID As ComboBox
    Friend WithEvents cbAuthorID As ComboBox
    Friend WithEvents txbPublishingYear As TextBox
    Friend WithEvents tbValue As TextBox
    Friend WithEvents dtpReceiptDate As DateTimePicker
    Friend WithEvents btThemSach As Button
    Friend WithEvents lbMaSach As Label
    Friend WithEvents cbBookID As ComboBox
    Friend WithEvents cbPublishingHouseID As ComboBox
    Friend WithEvents lbMaHienTrang As Label
    Friend WithEvents cbStatusID As ComboBox
End Class
