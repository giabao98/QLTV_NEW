<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuonTraSach
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMuonTraSach))
        Me.txbGhiChu = New System.Windows.Forms.TextBox()
        Me.dtpNgayTra = New System.Windows.Forms.DateTimePicker()
        Me.txbSoLuongmuon = New System.Windows.Forms.TextBox()
        Me.dtpNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.txbTacGia = New System.Windows.Forms.TextBox()
        Me.cbTheLoai = New System.Windows.Forms.ComboBox()
        Me.cbXacNhanTra = New System.Windows.Forms.ComboBox()
        Me.txbTenSach = New System.Windows.Forms.TextBox()
        Me.cbMaSach = New System.Windows.Forms.ComboBox()
        Me.txbTenDocGia = New System.Windows.Forms.TextBox()
        Me.dgvPhieuMuonTra = New System.Windows.Forms.DataGridView()
        Me.maphieumuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.madocgia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hoten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.masach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tensach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matheloai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matacgia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ngaymuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.soluongmuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ngaytra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xacnhantra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ghichu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblCHITIETPHIEUMUONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TVDataBsDataSet5 = New QLyGUI.TVDataBsDataSet5()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.cbMaDocGia = New System.Windows.Forms.ComboBox()
        Me.txbMaPhieuMuon = New System.Windows.Forms.TextBox()
        Me.lbMaPhieuMuon = New System.Windows.Forms.Label()
        Me.lbGhiChu = New System.Windows.Forms.Label()
        Me.lbXacNhanTra = New System.Windows.Forms.Label()
        Me.lbNgaytra = New System.Windows.Forms.Label()
        Me.lbAuthor = New System.Windows.Forms.Label()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.lbSoLuongmuon = New System.Windows.Forms.Label()
        Me.lbNgayMuon = New System.Windows.Forms.Label()
        Me.lbTheLoai = New System.Windows.Forms.Label()
        Me.lbReaderID = New System.Windows.Forms.Label()
        Me.lbMaSach = New System.Windows.Forms.Label()
        Me.lbReaderName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbTenSach = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TblCHITIETPHIEUMUONTableAdapter = New QLyGUI.TVDataBsDataSet5TableAdapters.tblCHITIETPHIEUMUONTableAdapter()
        Me.MaphieumuonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhichuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaymuonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoluongmuonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaytraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XacnhantraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MadocgiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TensachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatheloaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatacgiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPhieuMuonTra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCHITIETPHIEUMUONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDataBsDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbGhiChu
        '
        Me.txbGhiChu.Location = New System.Drawing.Point(539, 148)
        Me.txbGhiChu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbGhiChu.Multiline = True
        Me.txbGhiChu.Name = "txbGhiChu"
        Me.txbGhiChu.Size = New System.Drawing.Size(241, 86)
        Me.txbGhiChu.TabIndex = 44
        '
        'dtpNgayTra
        '
        Me.dtpNgayTra.Location = New System.Drawing.Point(539, 79)
        Me.dtpNgayTra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpNgayTra.Name = "dtpNgayTra"
        Me.dtpNgayTra.Size = New System.Drawing.Size(241, 22)
        Me.dtpNgayTra.TabIndex = 42
        '
        'txbSoLuongmuon
        '
        Me.txbSoLuongmuon.Location = New System.Drawing.Point(539, 47)
        Me.txbSoLuongmuon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbSoLuongmuon.Name = "txbSoLuongmuon"
        Me.txbSoLuongmuon.Size = New System.Drawing.Size(241, 22)
        Me.txbSoLuongmuon.TabIndex = 41
        '
        'dtpNgayMuon
        '
        Me.dtpNgayMuon.Location = New System.Drawing.Point(539, 15)
        Me.dtpNgayMuon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpNgayMuon.Name = "dtpNgayMuon"
        Me.dtpNgayMuon.Size = New System.Drawing.Size(241, 22)
        Me.dtpNgayMuon.TabIndex = 40
        '
        'txbTacGia
        '
        Me.txbTacGia.Location = New System.Drawing.Point(141, 210)
        Me.txbTacGia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbTacGia.Name = "txbTacGia"
        Me.txbTacGia.Size = New System.Drawing.Size(241, 22)
        Me.txbTacGia.TabIndex = 39
        '
        'cbTheLoai
        '
        Me.cbTheLoai.FormattingEnabled = True
        Me.cbTheLoai.Location = New System.Drawing.Point(141, 177)
        Me.cbTheLoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Size = New System.Drawing.Size(241, 24)
        Me.cbTheLoai.TabIndex = 38
        '
        'cbXacNhanTra
        '
        Me.cbXacNhanTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbXacNhanTra.FormattingEnabled = True
        Me.cbXacNhanTra.Items.AddRange(New Object() {"Đã Trả", "Chưa Trả"})
        Me.cbXacNhanTra.Location = New System.Drawing.Point(539, 114)
        Me.cbXacNhanTra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbXacNhanTra.Name = "cbXacNhanTra"
        Me.cbXacNhanTra.Size = New System.Drawing.Size(241, 24)
        Me.cbXacNhanTra.TabIndex = 43
        '
        'txbTenSach
        '
        Me.txbTenSach.Location = New System.Drawing.Point(141, 146)
        Me.txbTenSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbTenSach.Name = "txbTenSach"
        Me.txbTenSach.Size = New System.Drawing.Size(241, 22)
        Me.txbTenSach.TabIndex = 37
        '
        'cbMaSach
        '
        Me.cbMaSach.FormattingEnabled = True
        Me.cbMaSach.Location = New System.Drawing.Point(141, 113)
        Me.cbMaSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMaSach.Name = "cbMaSach"
        Me.cbMaSach.Size = New System.Drawing.Size(241, 24)
        Me.cbMaSach.TabIndex = 36
        '
        'txbTenDocGia
        '
        Me.txbTenDocGia.Location = New System.Drawing.Point(141, 81)
        Me.txbTenDocGia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbTenDocGia.Name = "txbTenDocGia"
        Me.txbTenDocGia.Size = New System.Drawing.Size(241, 22)
        Me.txbTenDocGia.TabIndex = 35
        '
        'dgvPhieuMuonTra
        '
        Me.dgvPhieuMuonTra.AllowUserToDeleteRows = False
        Me.dgvPhieuMuonTra.AutoGenerateColumns = False
        Me.dgvPhieuMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhieuMuonTra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.maphieumuon, Me.madocgia, Me.hoten, Me.masach, Me.tensach, Me.matheloai, Me.matacgia, Me.ngaymuon, Me.soluongmuon, Me.ngaytra, Me.xacnhantra, Me.ghichu, Me.MaphieumuonDataGridViewTextBoxColumn, Me.MasachDataGridViewTextBoxColumn, Me.GhichuDataGridViewTextBoxColumn, Me.NgaymuonDataGridViewTextBoxColumn, Me.SoluongmuonDataGridViewTextBoxColumn, Me.NgaytraDataGridViewTextBoxColumn, Me.XacnhantraDataGridViewTextBoxColumn, Me.MadocgiaDataGridViewTextBoxColumn, Me.HotenDataGridViewTextBoxColumn, Me.TensachDataGridViewTextBoxColumn, Me.MatheloaiDataGridViewTextBoxColumn, Me.MatacgiaDataGridViewTextBoxColumn})
        Me.dgvPhieuMuonTra.DataSource = Me.TblCHITIETPHIEUMUONBindingSource
        Me.dgvPhieuMuonTra.Location = New System.Drawing.Point(16, 335)
        Me.dgvPhieuMuonTra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvPhieuMuonTra.Name = "dgvPhieuMuonTra"
        Me.dgvPhieuMuonTra.ReadOnly = True
        Me.dgvPhieuMuonTra.Size = New System.Drawing.Size(1000, 239)
        Me.dgvPhieuMuonTra.TabIndex = 14
        '
        'maphieumuon
        '
        Me.maphieumuon.DataPropertyName = "maphieumuon"
        Me.maphieumuon.HeaderText = "Mã phiếu mượn"
        Me.maphieumuon.Name = "maphieumuon"
        Me.maphieumuon.ReadOnly = True
        '
        'madocgia
        '
        Me.madocgia.DataPropertyName = "madocgia"
        Me.madocgia.HeaderText = "Mã đọc giả"
        Me.madocgia.Name = "madocgia"
        Me.madocgia.ReadOnly = True
        '
        'hoten
        '
        Me.hoten.DataPropertyName = "hoten"
        Me.hoten.HeaderText = "Họ tên"
        Me.hoten.Name = "hoten"
        Me.hoten.ReadOnly = True
        '
        'masach
        '
        Me.masach.DataPropertyName = "masach"
        Me.masach.HeaderText = "Mã sách"
        Me.masach.Name = "masach"
        Me.masach.ReadOnly = True
        '
        'tensach
        '
        Me.tensach.DataPropertyName = "tensach"
        Me.tensach.HeaderText = "Tên sách"
        Me.tensach.Name = "tensach"
        Me.tensach.ReadOnly = True
        '
        'matheloai
        '
        Me.matheloai.DataPropertyName = "matheloai"
        Me.matheloai.HeaderText = "Mã thể loại"
        Me.matheloai.Name = "matheloai"
        Me.matheloai.ReadOnly = True
        '
        'matacgia
        '
        Me.matacgia.DataPropertyName = "matacgia"
        Me.matacgia.HeaderText = "Mã tác giả"
        Me.matacgia.Name = "matacgia"
        Me.matacgia.ReadOnly = True
        '
        'ngaymuon
        '
        Me.ngaymuon.DataPropertyName = "ngaymuon"
        Me.ngaymuon.HeaderText = "Ngày mượn"
        Me.ngaymuon.Name = "ngaymuon"
        Me.ngaymuon.ReadOnly = True
        '
        'soluongmuon
        '
        Me.soluongmuon.DataPropertyName = "soluongmuon"
        Me.soluongmuon.HeaderText = "Số lượng mượn"
        Me.soluongmuon.Name = "soluongmuon"
        Me.soluongmuon.ReadOnly = True
        '
        'ngaytra
        '
        Me.ngaytra.DataPropertyName = "ngaytra"
        Me.ngaytra.HeaderText = "Ngày trả"
        Me.ngaytra.Name = "ngaytra"
        Me.ngaytra.ReadOnly = True
        '
        'xacnhantra
        '
        Me.xacnhantra.DataPropertyName = "xacnhantra"
        Me.xacnhantra.HeaderText = "Xác nhận trả"
        Me.xacnhantra.Name = "xacnhantra"
        Me.xacnhantra.ReadOnly = True
        '
        'ghichu
        '
        Me.ghichu.DataPropertyName = "ghichu"
        Me.ghichu.HeaderText = "Ghi chú"
        Me.ghichu.Name = "ghichu"
        Me.ghichu.ReadOnly = True
        '
        'TblCHITIETPHIEUMUONBindingSource
        '
        Me.TblCHITIETPHIEUMUONBindingSource.DataMember = "tblCHITIETPHIEUMUON"
        Me.TblCHITIETPHIEUMUONBindingSource.DataSource = Me.TVDataBsDataSet5
        '
        'TVDataBsDataSet5
        '
        Me.TVDataBsDataSet5.DataSetName = "TVDataBsDataSet5"
        Me.TVDataBsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btDelete
        '
        Me.btDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btDelete.Image = CType(resources.GetObject("btDelete.Image"), System.Drawing.Image)
        Me.btDelete.Location = New System.Drawing.Point(57, 148)
        Me.btDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(117, 37)
        Me.btDelete.TabIndex = 2
        Me.btDelete.Text = "Xóa phiếu"
        Me.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btDelete.UseVisualStyleBackColor = False
        '
        'cbMaDocGia
        '
        Me.cbMaDocGia.FormattingEnabled = True
        Me.cbMaDocGia.Location = New System.Drawing.Point(141, 48)
        Me.cbMaDocGia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMaDocGia.Name = "cbMaDocGia"
        Me.cbMaDocGia.Size = New System.Drawing.Size(241, 24)
        Me.cbMaDocGia.TabIndex = 34
        '
        'txbMaPhieuMuon
        '
        Me.txbMaPhieuMuon.Location = New System.Drawing.Point(141, 16)
        Me.txbMaPhieuMuon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbMaPhieuMuon.Name = "txbMaPhieuMuon"
        Me.txbMaPhieuMuon.Size = New System.Drawing.Size(241, 22)
        Me.txbMaPhieuMuon.TabIndex = 33
        '
        'lbMaPhieuMuon
        '
        Me.lbMaPhieuMuon.AutoSize = True
        Me.lbMaPhieuMuon.Location = New System.Drawing.Point(23, 20)
        Me.lbMaPhieuMuon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaPhieuMuon.Name = "lbMaPhieuMuon"
        Me.lbMaPhieuMuon.Size = New System.Drawing.Size(105, 17)
        Me.lbMaPhieuMuon.TabIndex = 32
        Me.lbMaPhieuMuon.Text = "Mã phiếu mượn"
        '
        'lbGhiChu
        '
        Me.lbGhiChu.AutoSize = True
        Me.lbGhiChu.Location = New System.Drawing.Point(431, 150)
        Me.lbGhiChu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbGhiChu.Name = "lbGhiChu"
        Me.lbGhiChu.Size = New System.Drawing.Size(57, 17)
        Me.lbGhiChu.TabIndex = 23
        Me.lbGhiChu.Text = "Ghi chú"
        '
        'lbXacNhanTra
        '
        Me.lbXacNhanTra.AutoSize = True
        Me.lbXacNhanTra.Location = New System.Drawing.Point(427, 118)
        Me.lbXacNhanTra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbXacNhanTra.Name = "lbXacNhanTra"
        Me.lbXacNhanTra.Size = New System.Drawing.Size(89, 17)
        Me.lbXacNhanTra.TabIndex = 19
        Me.lbXacNhanTra.Text = "Xác nhận trả"
        '
        'lbNgaytra
        '
        Me.lbNgaytra.AutoSize = True
        Me.lbNgaytra.Location = New System.Drawing.Point(427, 85)
        Me.lbNgaytra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgaytra.Name = "lbNgaytra"
        Me.lbNgaytra.Size = New System.Drawing.Size(62, 17)
        Me.lbNgaytra.TabIndex = 18
        Me.lbNgaytra.Text = "Ngày trả"
        '
        'lbAuthor
        '
        Me.lbAuthor.AutoSize = True
        Me.lbAuthor.Location = New System.Drawing.Point(23, 214)
        Me.lbAuthor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAuthor.Name = "lbAuthor"
        Me.lbAuthor.Size = New System.Drawing.Size(55, 17)
        Me.lbAuthor.TabIndex = 11
        Me.lbAuthor.Text = "Tác giả"
        '
        'btUpdate
        '
        Me.btUpdate.BackColor = System.Drawing.Color.LightGreen
        Me.btUpdate.Image = CType(resources.GetObject("btUpdate.Image"), System.Drawing.Image)
        Me.btUpdate.Location = New System.Drawing.Point(57, 94)
        Me.btUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(117, 37)
        Me.btUpdate.TabIndex = 1
        Me.btUpdate.Text = "Cập nhật"
        Me.btUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btUpdate.UseVisualStyleBackColor = False
        '
        'btAdd
        '
        Me.btAdd.BackColor = System.Drawing.Color.LightGreen
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.Location = New System.Drawing.Point(57, 39)
        Me.btAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(117, 37)
        Me.btAdd.TabIndex = 0
        Me.btAdd.Text = "Xác nhận"
        Me.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'lbSoLuongmuon
        '
        Me.lbSoLuongmuon.AutoSize = True
        Me.lbSoLuongmuon.Location = New System.Drawing.Point(427, 53)
        Me.lbSoLuongmuon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSoLuongmuon.Name = "lbSoLuongmuon"
        Me.lbSoLuongmuon.Size = New System.Drawing.Size(103, 17)
        Me.lbSoLuongmuon.TabIndex = 6
        Me.lbSoLuongmuon.Text = "Số lượng mượn"
        '
        'lbNgayMuon
        '
        Me.lbNgayMuon.AutoSize = True
        Me.lbNgayMuon.Location = New System.Drawing.Point(427, 20)
        Me.lbNgayMuon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgayMuon.Name = "lbNgayMuon"
        Me.lbNgayMuon.Size = New System.Drawing.Size(80, 17)
        Me.lbNgayMuon.TabIndex = 5
        Me.lbNgayMuon.Text = "Ngày mượn"
        '
        'lbTheLoai
        '
        Me.lbTheLoai.AutoSize = True
        Me.lbTheLoai.Location = New System.Drawing.Point(23, 182)
        Me.lbTheLoai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTheLoai.Name = "lbTheLoai"
        Me.lbTheLoai.Size = New System.Drawing.Size(59, 17)
        Me.lbTheLoai.TabIndex = 4
        Me.lbTheLoai.Text = "Thể loại"
        '
        'lbReaderID
        '
        Me.lbReaderID.AutoSize = True
        Me.lbReaderID.Location = New System.Drawing.Point(23, 52)
        Me.lbReaderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbReaderID.Name = "lbReaderID"
        Me.lbReaderID.Size = New System.Drawing.Size(77, 17)
        Me.lbReaderID.TabIndex = 0
        Me.lbReaderID.Text = "Mã đọc giả"
        '
        'lbMaSach
        '
        Me.lbMaSach.AutoSize = True
        Me.lbMaSach.Location = New System.Drawing.Point(23, 117)
        Me.lbMaSach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaSach.Name = "lbMaSach"
        Me.lbMaSach.Size = New System.Drawing.Size(61, 17)
        Me.lbMaSach.TabIndex = 2
        Me.lbMaSach.Text = "Mã sách"
        '
        'lbReaderName
        '
        Me.lbReaderName.AutoSize = True
        Me.lbReaderName.Location = New System.Drawing.Point(23, 85)
        Me.lbReaderName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbReaderName.Name = "lbReaderName"
        Me.lbReaderName.Size = New System.Drawing.Size(83, 17)
        Me.lbReaderName.TabIndex = 1
        Me.lbReaderName.Text = "Tên đọc giả"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.txbGhiChu)
        Me.GroupBox1.Controls.Add(Me.cbXacNhanTra)
        Me.GroupBox1.Controls.Add(Me.dtpNgayTra)
        Me.GroupBox1.Controls.Add(Me.txbSoLuongmuon)
        Me.GroupBox1.Controls.Add(Me.dtpNgayMuon)
        Me.GroupBox1.Controls.Add(Me.txbTacGia)
        Me.GroupBox1.Controls.Add(Me.cbTheLoai)
        Me.GroupBox1.Controls.Add(Me.txbTenSach)
        Me.GroupBox1.Controls.Add(Me.cbMaSach)
        Me.GroupBox1.Controls.Add(Me.txbTenDocGia)
        Me.GroupBox1.Controls.Add(Me.cbMaDocGia)
        Me.GroupBox1.Controls.Add(Me.txbMaPhieuMuon)
        Me.GroupBox1.Controls.Add(Me.lbMaPhieuMuon)
        Me.GroupBox1.Controls.Add(Me.lbGhiChu)
        Me.GroupBox1.Controls.Add(Me.lbXacNhanTra)
        Me.GroupBox1.Controls.Add(Me.lbNgaytra)
        Me.GroupBox1.Controls.Add(Me.lbAuthor)
        Me.GroupBox1.Controls.Add(Me.lbSoLuongmuon)
        Me.GroupBox1.Controls.Add(Me.lbNgayMuon)
        Me.GroupBox1.Controls.Add(Me.lbTheLoai)
        Me.GroupBox1.Controls.Add(Me.lbTenSach)
        Me.GroupBox1.Controls.Add(Me.lbReaderID)
        Me.GroupBox1.Controls.Add(Me.lbMaSach)
        Me.GroupBox1.Controls.Add(Me.lbReaderName)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 82)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(789, 245)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'lbTenSach
        '
        Me.lbTenSach.AutoSize = True
        Me.lbTenSach.Location = New System.Drawing.Point(23, 150)
        Me.lbTenSach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTenSach.Name = "lbTenSach"
        Me.lbTenSach.Size = New System.Drawing.Size(67, 17)
        Me.lbTenSach.TabIndex = 3
        Me.lbTenSach.Text = "Tên sách"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Controls.Add(Me.btDelete)
        Me.GroupBox3.Controls.Add(Me.btUpdate)
        Me.GroupBox3.Controls.Add(Me.btAdd)
        Me.GroupBox3.Location = New System.Drawing.Point(813, 85)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(203, 242)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1000, 62)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(313, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(378, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Chi tiết phiếu mượn trả sách"
        '
        'TblCHITIETPHIEUMUONTableAdapter
        '
        Me.TblCHITIETPHIEUMUONTableAdapter.ClearBeforeFill = True
        '
        'MaphieumuonDataGridViewTextBoxColumn
        '
        Me.MaphieumuonDataGridViewTextBoxColumn.DataPropertyName = "maphieumuon"
        Me.MaphieumuonDataGridViewTextBoxColumn.HeaderText = "maphieumuon"
        Me.MaphieumuonDataGridViewTextBoxColumn.Name = "MaphieumuonDataGridViewTextBoxColumn"
        Me.MaphieumuonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MasachDataGridViewTextBoxColumn
        '
        Me.MasachDataGridViewTextBoxColumn.DataPropertyName = "masach"
        Me.MasachDataGridViewTextBoxColumn.HeaderText = "masach"
        Me.MasachDataGridViewTextBoxColumn.Name = "MasachDataGridViewTextBoxColumn"
        Me.MasachDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GhichuDataGridViewTextBoxColumn
        '
        Me.GhichuDataGridViewTextBoxColumn.DataPropertyName = "ghichu"
        Me.GhichuDataGridViewTextBoxColumn.HeaderText = "ghichu"
        Me.GhichuDataGridViewTextBoxColumn.Name = "GhichuDataGridViewTextBoxColumn"
        Me.GhichuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NgaymuonDataGridViewTextBoxColumn
        '
        Me.NgaymuonDataGridViewTextBoxColumn.DataPropertyName = "ngaymuon"
        Me.NgaymuonDataGridViewTextBoxColumn.HeaderText = "ngaymuon"
        Me.NgaymuonDataGridViewTextBoxColumn.Name = "NgaymuonDataGridViewTextBoxColumn"
        Me.NgaymuonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoluongmuonDataGridViewTextBoxColumn
        '
        Me.SoluongmuonDataGridViewTextBoxColumn.DataPropertyName = "soluongmuon"
        Me.SoluongmuonDataGridViewTextBoxColumn.HeaderText = "soluongmuon"
        Me.SoluongmuonDataGridViewTextBoxColumn.Name = "SoluongmuonDataGridViewTextBoxColumn"
        Me.SoluongmuonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NgaytraDataGridViewTextBoxColumn
        '
        Me.NgaytraDataGridViewTextBoxColumn.DataPropertyName = "ngaytra"
        Me.NgaytraDataGridViewTextBoxColumn.HeaderText = "ngaytra"
        Me.NgaytraDataGridViewTextBoxColumn.Name = "NgaytraDataGridViewTextBoxColumn"
        Me.NgaytraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'XacnhantraDataGridViewTextBoxColumn
        '
        Me.XacnhantraDataGridViewTextBoxColumn.DataPropertyName = "xacnhantra"
        Me.XacnhantraDataGridViewTextBoxColumn.HeaderText = "xacnhantra"
        Me.XacnhantraDataGridViewTextBoxColumn.Name = "XacnhantraDataGridViewTextBoxColumn"
        Me.XacnhantraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MadocgiaDataGridViewTextBoxColumn
        '
        Me.MadocgiaDataGridViewTextBoxColumn.DataPropertyName = "madocgia"
        Me.MadocgiaDataGridViewTextBoxColumn.HeaderText = "madocgia"
        Me.MadocgiaDataGridViewTextBoxColumn.Name = "MadocgiaDataGridViewTextBoxColumn"
        Me.MadocgiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HotenDataGridViewTextBoxColumn
        '
        Me.HotenDataGridViewTextBoxColumn.DataPropertyName = "hoten"
        Me.HotenDataGridViewTextBoxColumn.HeaderText = "hoten"
        Me.HotenDataGridViewTextBoxColumn.Name = "HotenDataGridViewTextBoxColumn"
        Me.HotenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TensachDataGridViewTextBoxColumn
        '
        Me.TensachDataGridViewTextBoxColumn.DataPropertyName = "tensach"
        Me.TensachDataGridViewTextBoxColumn.HeaderText = "tensach"
        Me.TensachDataGridViewTextBoxColumn.Name = "TensachDataGridViewTextBoxColumn"
        Me.TensachDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatheloaiDataGridViewTextBoxColumn
        '
        Me.MatheloaiDataGridViewTextBoxColumn.DataPropertyName = "matheloai"
        Me.MatheloaiDataGridViewTextBoxColumn.HeaderText = "matheloai"
        Me.MatheloaiDataGridViewTextBoxColumn.Name = "MatheloaiDataGridViewTextBoxColumn"
        Me.MatheloaiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatacgiaDataGridViewTextBoxColumn
        '
        Me.MatacgiaDataGridViewTextBoxColumn.DataPropertyName = "matacgia"
        Me.MatacgiaDataGridViewTextBoxColumn.HeaderText = "matacgia"
        Me.MatacgiaDataGridViewTextBoxColumn.Name = "MatacgiaDataGridViewTextBoxColumn"
        Me.MatacgiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmMuonTraSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 624)
        Me.Controls.Add(Me.dgvPhieuMuonTra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMuonTraSach"
        Me.Text = "frmMuonTraSach"
        CType(Me.dgvPhieuMuonTra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCHITIETPHIEUMUONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDataBsDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txbGhiChu As TextBox
    Friend WithEvents dtpNgayTra As DateTimePicker
    Friend WithEvents txbSoLuongmuon As TextBox
    Friend WithEvents dtpNgayMuon As DateTimePicker
    Friend WithEvents txbTacGia As TextBox
    Friend WithEvents cbTheLoai As ComboBox
    Friend WithEvents cbXacNhanTra As ComboBox
    Friend WithEvents txbTenSach As TextBox
    Friend WithEvents cbMaSach As ComboBox
    Friend WithEvents txbTenDocGia As TextBox
    Friend WithEvents dgvPhieuMuonTra As DataGridView
    Friend WithEvents btDelete As Button
    Friend WithEvents cbMaDocGia As ComboBox
    Friend WithEvents txbMaPhieuMuon As TextBox
    Friend WithEvents lbMaPhieuMuon As Label
    Friend WithEvents lbGhiChu As Label
    Friend WithEvents lbXacNhanTra As Label
    Friend WithEvents lbNgaytra As Label
    Friend WithEvents lbAuthor As Label
    Friend WithEvents btUpdate As Button
    Friend WithEvents btAdd As Button
    Friend WithEvents lbSoLuongmuon As Label
    Friend WithEvents lbNgayMuon As Label
    Friend WithEvents lbTheLoai As Label
    Friend WithEvents lbReaderID As Label
    Friend WithEvents lbMaSach As Label
    Friend WithEvents lbReaderName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbTenSach As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents Label3 As Label
    Friend WithEvents TVDataBsDataSet5 As TVDataBsDataSet5
    Friend WithEvents TblCHITIETPHIEUMUONBindingSource As BindingSource
    Friend WithEvents TblCHITIETPHIEUMUONTableAdapter As TVDataBsDataSet5TableAdapters.tblCHITIETPHIEUMUONTableAdapter
    Friend WithEvents maphieumuon As DataGridViewTextBoxColumn
    Friend WithEvents madocgia As DataGridViewTextBoxColumn
    Friend WithEvents hoten As DataGridViewTextBoxColumn
    Friend WithEvents masach As DataGridViewTextBoxColumn
    Friend WithEvents tensach As DataGridViewTextBoxColumn
    Friend WithEvents matheloai As DataGridViewTextBoxColumn
    Friend WithEvents matacgia As DataGridViewTextBoxColumn
    Friend WithEvents ngaymuon As DataGridViewTextBoxColumn
    Friend WithEvents soluongmuon As DataGridViewTextBoxColumn
    Friend WithEvents ngaytra As DataGridViewTextBoxColumn
    Friend WithEvents xacnhantra As DataGridViewTextBoxColumn
    Friend WithEvents ghichu As DataGridViewTextBoxColumn
    Friend WithEvents MaphieumuonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MasachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GhichuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaymuonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoluongmuonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaytraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents XacnhantraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MadocgiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HotenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TensachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatheloaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatacgiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
