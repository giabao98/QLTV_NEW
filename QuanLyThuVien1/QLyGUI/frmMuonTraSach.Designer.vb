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
        Me.TVDataBsDataSet5 = New QLyGUI.TVDataBsDataSet5()
        Me.TblCHITIETPHIEUMUONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCHITIETPHIEUMUONTableAdapter = New QLyGUI.TVDataBsDataSet5TableAdapters.tblCHITIETPHIEUMUONTableAdapter()
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
        CType(Me.dgvPhieuMuonTra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TVDataBsDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCHITIETPHIEUMUONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbGhiChu
        '
        Me.txbGhiChu.Location = New System.Drawing.Point(404, 120)
        Me.txbGhiChu.Multiline = True
        Me.txbGhiChu.Name = "txbGhiChu"
        Me.txbGhiChu.Size = New System.Drawing.Size(182, 71)
        Me.txbGhiChu.TabIndex = 44
        '
        'dtpNgayTra
        '
        Me.dtpNgayTra.Location = New System.Drawing.Point(404, 64)
        Me.dtpNgayTra.Name = "dtpNgayTra"
        Me.dtpNgayTra.Size = New System.Drawing.Size(182, 20)
        Me.dtpNgayTra.TabIndex = 42
        '
        'txbSoLuongmuon
        '
        Me.txbSoLuongmuon.Location = New System.Drawing.Point(404, 38)
        Me.txbSoLuongmuon.Name = "txbSoLuongmuon"
        Me.txbSoLuongmuon.Size = New System.Drawing.Size(182, 20)
        Me.txbSoLuongmuon.TabIndex = 41
        '
        'dtpNgayMuon
        '
        Me.dtpNgayMuon.Location = New System.Drawing.Point(404, 12)
        Me.dtpNgayMuon.Name = "dtpNgayMuon"
        Me.dtpNgayMuon.Size = New System.Drawing.Size(182, 20)
        Me.dtpNgayMuon.TabIndex = 40
        '
        'txbTacGia
        '
        Me.txbTacGia.Location = New System.Drawing.Point(106, 171)
        Me.txbTacGia.Name = "txbTacGia"
        Me.txbTacGia.Size = New System.Drawing.Size(182, 20)
        Me.txbTacGia.TabIndex = 39
        '
        'cbTheLoai
        '
        Me.cbTheLoai.FormattingEnabled = True
        Me.cbTheLoai.Location = New System.Drawing.Point(106, 144)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Size = New System.Drawing.Size(182, 21)
        Me.cbTheLoai.TabIndex = 38
        '
        'cbXacNhanTra
        '
        Me.cbXacNhanTra.FormattingEnabled = True
        Me.cbXacNhanTra.Location = New System.Drawing.Point(404, 93)
        Me.cbXacNhanTra.Name = "cbXacNhanTra"
        Me.cbXacNhanTra.Size = New System.Drawing.Size(182, 21)
        Me.cbXacNhanTra.TabIndex = 43
        '
        'txbTenSach
        '
        Me.txbTenSach.Location = New System.Drawing.Point(106, 119)
        Me.txbTenSach.Name = "txbTenSach"
        Me.txbTenSach.Size = New System.Drawing.Size(182, 20)
        Me.txbTenSach.TabIndex = 37
        '
        'cbMaSach
        '
        Me.cbMaSach.FormattingEnabled = True
        Me.cbMaSach.Location = New System.Drawing.Point(106, 92)
        Me.cbMaSach.Name = "cbMaSach"
        Me.cbMaSach.Size = New System.Drawing.Size(182, 21)
        Me.cbMaSach.TabIndex = 36
        '
        'txbTenDocGia
        '
        Me.txbTenDocGia.Location = New System.Drawing.Point(106, 66)
        Me.txbTenDocGia.Name = "txbTenDocGia"
        Me.txbTenDocGia.Size = New System.Drawing.Size(182, 20)
        Me.txbTenDocGia.TabIndex = 35
        '
        'dgvPhieuMuonTra
        '
        Me.dgvPhieuMuonTra.AllowUserToDeleteRows = False
        Me.dgvPhieuMuonTra.AutoGenerateColumns = False
        Me.dgvPhieuMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhieuMuonTra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.maphieumuon, Me.madocgia, Me.hoten, Me.masach, Me.tensach, Me.matheloai, Me.matacgia, Me.ngaymuon, Me.soluongmuon, Me.ngaytra, Me.xacnhantra, Me.ghichu})
        Me.dgvPhieuMuonTra.DataSource = Me.TblCHITIETPHIEUMUONBindingSource
        Me.dgvPhieuMuonTra.Location = New System.Drawing.Point(12, 272)
        Me.dgvPhieuMuonTra.Name = "dgvPhieuMuonTra"
        Me.dgvPhieuMuonTra.ReadOnly = True
        Me.dgvPhieuMuonTra.Size = New System.Drawing.Size(750, 194)
        Me.dgvPhieuMuonTra.TabIndex = 14
        '
        'btDelete
        '
        Me.btDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btDelete.Image = CType(resources.GetObject("btDelete.Image"), System.Drawing.Image)
        Me.btDelete.Location = New System.Drawing.Point(43, 120)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(88, 30)
        Me.btDelete.TabIndex = 2
        Me.btDelete.Text = "Xóa phiếu"
        Me.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btDelete.UseVisualStyleBackColor = False
        '
        'cbMaDocGia
        '
        Me.cbMaDocGia.FormattingEnabled = True
        Me.cbMaDocGia.Location = New System.Drawing.Point(106, 39)
        Me.cbMaDocGia.Name = "cbMaDocGia"
        Me.cbMaDocGia.Size = New System.Drawing.Size(182, 21)
        Me.cbMaDocGia.TabIndex = 34
        '
        'txbMaPhieuMuon
        '
        Me.txbMaPhieuMuon.Location = New System.Drawing.Point(106, 13)
        Me.txbMaPhieuMuon.Name = "txbMaPhieuMuon"
        Me.txbMaPhieuMuon.Size = New System.Drawing.Size(182, 20)
        Me.txbMaPhieuMuon.TabIndex = 33
        '
        'lbMaPhieuMuon
        '
        Me.lbMaPhieuMuon.AutoSize = True
        Me.lbMaPhieuMuon.Location = New System.Drawing.Point(17, 16)
        Me.lbMaPhieuMuon.Name = "lbMaPhieuMuon"
        Me.lbMaPhieuMuon.Size = New System.Drawing.Size(80, 13)
        Me.lbMaPhieuMuon.TabIndex = 32
        Me.lbMaPhieuMuon.Text = "Mã phiếu mượn"
        '
        'lbGhiChu
        '
        Me.lbGhiChu.AutoSize = True
        Me.lbGhiChu.Location = New System.Drawing.Point(323, 122)
        Me.lbGhiChu.Name = "lbGhiChu"
        Me.lbGhiChu.Size = New System.Drawing.Size(44, 13)
        Me.lbGhiChu.TabIndex = 23
        Me.lbGhiChu.Text = "Ghi chú"
        '
        'lbXacNhanTra
        '
        Me.lbXacNhanTra.AutoSize = True
        Me.lbXacNhanTra.Location = New System.Drawing.Point(320, 96)
        Me.lbXacNhanTra.Name = "lbXacNhanTra"
        Me.lbXacNhanTra.Size = New System.Drawing.Size(68, 13)
        Me.lbXacNhanTra.TabIndex = 19
        Me.lbXacNhanTra.Text = "Xác nhận trả"
        '
        'lbNgaytra
        '
        Me.lbNgaytra.AutoSize = True
        Me.lbNgaytra.Location = New System.Drawing.Point(320, 69)
        Me.lbNgaytra.Name = "lbNgaytra"
        Me.lbNgaytra.Size = New System.Drawing.Size(47, 13)
        Me.lbNgaytra.TabIndex = 18
        Me.lbNgaytra.Text = "Ngày trả"
        '
        'lbAuthor
        '
        Me.lbAuthor.AutoSize = True
        Me.lbAuthor.Location = New System.Drawing.Point(17, 174)
        Me.lbAuthor.Name = "lbAuthor"
        Me.lbAuthor.Size = New System.Drawing.Size(43, 13)
        Me.lbAuthor.TabIndex = 11
        Me.lbAuthor.Text = "Tác giả"
        '
        'btUpdate
        '
        Me.btUpdate.BackColor = System.Drawing.Color.LightGreen
        Me.btUpdate.Image = CType(resources.GetObject("btUpdate.Image"), System.Drawing.Image)
        Me.btUpdate.Location = New System.Drawing.Point(43, 76)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(88, 30)
        Me.btUpdate.TabIndex = 1
        Me.btUpdate.Text = "Cập nhật"
        Me.btUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btUpdate.UseVisualStyleBackColor = False
        '
        'btAdd
        '
        Me.btAdd.BackColor = System.Drawing.Color.LightGreen
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.Location = New System.Drawing.Point(43, 32)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(88, 30)
        Me.btAdd.TabIndex = 0
        Me.btAdd.Text = "Xác nhận"
        Me.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'lbSoLuongmuon
        '
        Me.lbSoLuongmuon.AutoSize = True
        Me.lbSoLuongmuon.Location = New System.Drawing.Point(320, 43)
        Me.lbSoLuongmuon.Name = "lbSoLuongmuon"
        Me.lbSoLuongmuon.Size = New System.Drawing.Size(78, 13)
        Me.lbSoLuongmuon.TabIndex = 6
        Me.lbSoLuongmuon.Text = "Số lượng mượn"
        '
        'lbNgayMuon
        '
        Me.lbNgayMuon.AutoSize = True
        Me.lbNgayMuon.Location = New System.Drawing.Point(320, 16)
        Me.lbNgayMuon.Name = "lbNgayMuon"
        Me.lbNgayMuon.Size = New System.Drawing.Size(61, 13)
        Me.lbNgayMuon.TabIndex = 5
        Me.lbNgayMuon.Text = "Ngày mượn"
        '
        'lbTheLoai
        '
        Me.lbTheLoai.AutoSize = True
        Me.lbTheLoai.Location = New System.Drawing.Point(17, 148)
        Me.lbTheLoai.Name = "lbTheLoai"
        Me.lbTheLoai.Size = New System.Drawing.Size(45, 13)
        Me.lbTheLoai.TabIndex = 4
        Me.lbTheLoai.Text = "Thể loại"
        '
        'lbReaderID
        '
        Me.lbReaderID.AutoSize = True
        Me.lbReaderID.Location = New System.Drawing.Point(17, 42)
        Me.lbReaderID.Name = "lbReaderID"
        Me.lbReaderID.Size = New System.Drawing.Size(61, 13)
        Me.lbReaderID.TabIndex = 0
        Me.lbReaderID.Text = "Mã đọc giả"
        '
        'lbMaSach
        '
        Me.lbMaSach.AutoSize = True
        Me.lbMaSach.Location = New System.Drawing.Point(17, 95)
        Me.lbMaSach.Name = "lbMaSach"
        Me.lbMaSach.Size = New System.Drawing.Size(48, 13)
        Me.lbMaSach.TabIndex = 2
        Me.lbMaSach.Text = "Mã sách"
        '
        'lbReaderName
        '
        Me.lbReaderName.AutoSize = True
        Me.lbReaderName.Location = New System.Drawing.Point(17, 69)
        Me.lbReaderName.Name = "lbReaderName"
        Me.lbReaderName.Size = New System.Drawing.Size(65, 13)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 199)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'lbTenSach
        '
        Me.lbTenSach.AutoSize = True
        Me.lbTenSach.Location = New System.Drawing.Point(17, 122)
        Me.lbTenSach.Name = "lbTenSach"
        Me.lbTenSach.Size = New System.Drawing.Size(52, 13)
        Me.lbTenSach.TabIndex = 3
        Me.lbTenSach.Text = "Tên sách"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Controls.Add(Me.btDelete)
        Me.GroupBox3.Controls.Add(Me.btUpdate)
        Me.GroupBox3.Controls.Add(Me.btAdd)
        Me.GroupBox3.Location = New System.Drawing.Point(610, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(152, 197)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(750, 50)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(235, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Chi tiết phiếu mượn trả sách"
        '
        'TVDataBsDataSet5
        '
        Me.TVDataBsDataSet5.DataSetName = "TVDataBsDataSet5"
        Me.TVDataBsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCHITIETPHIEUMUONBindingSource
        '
        Me.TblCHITIETPHIEUMUONBindingSource.DataMember = "tblCHITIETPHIEUMUON"
        Me.TblCHITIETPHIEUMUONBindingSource.DataSource = Me.TVDataBsDataSet5
        '
        'TblCHITIETPHIEUMUONTableAdapter
        '
        Me.TblCHITIETPHIEUMUONTableAdapter.ClearBeforeFill = True
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
        'frmMuonTraSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 507)
        Me.Controls.Add(Me.dgvPhieuMuonTra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMuonTraSach"
        Me.Text = "frmMuonTraSach"
        CType(Me.dgvPhieuMuonTra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TVDataBsDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCHITIETPHIEUMUONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
