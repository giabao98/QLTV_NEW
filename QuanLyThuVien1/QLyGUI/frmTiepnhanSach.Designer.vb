<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiepnhanSach
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
        Me.lbTenSach = New System.Windows.Forms.Label()
        Me.lbTacGia = New System.Windows.Forms.Label()
        Me.lbNamXuatBan = New System.Windows.Forms.Label()
        Me.lbNhaXuatBan = New System.Windows.Forms.Label()
        Me.lbNgayNhap = New System.Windows.Forms.Label()
        Me.lbTriGia = New System.Windows.Forms.Label()
        Me.lbTheLoai = New System.Windows.Forms.Label()
        Me.txbTheNameOfBook = New System.Windows.Forms.TextBox()
        Me.cbTheKindOfBook = New System.Windows.Forms.ComboBox()
        Me.cbAuthor = New System.Windows.Forms.ComboBox()
        Me.txbPublishingYear = New System.Windows.Forms.TextBox()
        Me.txbPublishingHouse = New System.Windows.Forms.TextBox()
        Me.tbValue = New System.Windows.Forms.TextBox()
        Me.dtpReceiptDate = New System.Windows.Forms.DateTimePicker()
        Me.btThemSach = New System.Windows.Forms.Button()
        Me.txbBookID = New System.Windows.Forms.TextBox()
        Me.lbMaSach = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbTenSach
        '
        Me.lbTenSach.AutoSize = True
        Me.lbTenSach.Location = New System.Drawing.Point(40, 29)
        Me.lbTenSach.Name = "lbTenSach"
        Me.lbTenSach.Size = New System.Drawing.Size(52, 13)
        Me.lbTenSach.TabIndex = 0
        Me.lbTenSach.Text = "Tên sách"
        '
        'lbTacGia
        '
        Me.lbTacGia.AutoSize = True
        Me.lbTacGia.Location = New System.Drawing.Point(40, 173)
        Me.lbTacGia.Name = "lbTacGia"
        Me.lbTacGia.Size = New System.Drawing.Size(43, 13)
        Me.lbTacGia.TabIndex = 2
        Me.lbTacGia.Text = "Tác giả"
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
        'lbNhaXuatBan
        '
        Me.lbNhaXuatBan.AutoSize = True
        Me.lbNhaXuatBan.Location = New System.Drawing.Point(40, 273)
        Me.lbNhaXuatBan.Name = "lbNhaXuatBan"
        Me.lbNhaXuatBan.Size = New System.Drawing.Size(71, 13)
        Me.lbNhaXuatBan.TabIndex = 4
        Me.lbNhaXuatBan.Text = "Nhà xuất bản"
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
        'lbTheLoai
        '
        Me.lbTheLoai.AutoSize = True
        Me.lbTheLoai.Location = New System.Drawing.Point(40, 123)
        Me.lbTheLoai.Name = "lbTheLoai"
        Me.lbTheLoai.Size = New System.Drawing.Size(45, 13)
        Me.lbTheLoai.TabIndex = 7
        Me.lbTheLoai.Text = "Thể loại"
        '
        'txbTheNameOfBook
        '
        Me.txbTheNameOfBook.Location = New System.Drawing.Point(140, 26)
        Me.txbTheNameOfBook.Name = "txbTheNameOfBook"
        Me.txbTheNameOfBook.Size = New System.Drawing.Size(200, 20)
        Me.txbTheNameOfBook.TabIndex = 8
        '
        'cbTheKindOfBook
        '
        Me.cbTheKindOfBook.FormattingEnabled = True
        Me.cbTheKindOfBook.Location = New System.Drawing.Point(140, 120)
        Me.cbTheKindOfBook.Name = "cbTheKindOfBook"
        Me.cbTheKindOfBook.Size = New System.Drawing.Size(200, 21)
        Me.cbTheKindOfBook.TabIndex = 9
        '
        'cbAuthor
        '
        Me.cbAuthor.FormattingEnabled = True
        Me.cbAuthor.Location = New System.Drawing.Point(140, 170)
        Me.cbAuthor.Name = "cbAuthor"
        Me.cbAuthor.Size = New System.Drawing.Size(200, 21)
        Me.cbAuthor.TabIndex = 10
        '
        'txbPublishingYear
        '
        Me.txbPublishingYear.Location = New System.Drawing.Point(140, 220)
        Me.txbPublishingYear.Name = "txbPublishingYear"
        Me.txbPublishingYear.Size = New System.Drawing.Size(200, 20)
        Me.txbPublishingYear.TabIndex = 11
        '
        'txbPublishingHouse
        '
        Me.txbPublishingHouse.Location = New System.Drawing.Point(140, 270)
        Me.txbPublishingHouse.Name = "txbPublishingHouse"
        Me.txbPublishingHouse.Size = New System.Drawing.Size(200, 20)
        Me.txbPublishingHouse.TabIndex = 12
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
        Me.btThemSach.Location = New System.Drawing.Point(140, 419)
        Me.btThemSach.Name = "btThemSach"
        Me.btThemSach.Size = New System.Drawing.Size(75, 23)
        Me.btThemSach.TabIndex = 15
        Me.btThemSach.Text = "Thêm sách"
        Me.btThemSach.UseVisualStyleBackColor = True
        '
        'txbBookID
        '
        Me.txbBookID.Location = New System.Drawing.Point(140, 70)
        Me.txbBookID.Name = "txbBookID"
        Me.txbBookID.Size = New System.Drawing.Size(200, 20)
        Me.txbBookID.TabIndex = 16
        '
        'lbMaSach
        '
        Me.lbMaSach.AutoSize = True
        Me.lbMaSach.Location = New System.Drawing.Point(40, 73)
        Me.lbMaSach.Name = "lbMaSach"
        Me.lbMaSach.Size = New System.Drawing.Size(48, 13)
        Me.lbMaSach.TabIndex = 17
        Me.lbMaSach.Text = "Mã sách"
        '
        'frmTiepnhanSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 454)
        Me.Controls.Add(Me.lbMaSach)
        Me.Controls.Add(Me.txbBookID)
        Me.Controls.Add(Me.btThemSach)
        Me.Controls.Add(Me.dtpReceiptDate)
        Me.Controls.Add(Me.tbValue)
        Me.Controls.Add(Me.txbPublishingHouse)
        Me.Controls.Add(Me.txbPublishingYear)
        Me.Controls.Add(Me.cbAuthor)
        Me.Controls.Add(Me.cbTheKindOfBook)
        Me.Controls.Add(Me.txbTheNameOfBook)
        Me.Controls.Add(Me.lbTheLoai)
        Me.Controls.Add(Me.lbTriGia)
        Me.Controls.Add(Me.lbNgayNhap)
        Me.Controls.Add(Me.lbNhaXuatBan)
        Me.Controls.Add(Me.lbNamXuatBan)
        Me.Controls.Add(Me.lbTacGia)
        Me.Controls.Add(Me.lbTenSach)
        Me.Name = "frmTiepnhanSach"
        Me.Text = "tiepnhanSach"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTenSach As Label
    Friend WithEvents lbTacGia As Label
    Friend WithEvents lbNamXuatBan As Label
    Friend WithEvents lbNhaXuatBan As Label
    Friend WithEvents lbNgayNhap As Label
    Friend WithEvents lbTriGia As Label
    Friend WithEvents lbTheLoai As Label
    Friend WithEvents txbTheNameOfBook As TextBox
    Friend WithEvents cbTheKindOfBook As ComboBox
    Friend WithEvents cbAuthor As ComboBox
    Friend WithEvents txbPublishingYear As TextBox
    Friend WithEvents txbPublishingHouse As TextBox
    Friend WithEvents tbValue As TextBox
    Friend WithEvents dtpReceiptDate As DateTimePicker
    Friend WithEvents btThemSach As Button
    Friend WithEvents txbBookID As TextBox
    Friend WithEvents lbMaSach As Label
End Class
