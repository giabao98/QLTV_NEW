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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTiepnhanSach))
        Me.lbMaSach = New System.Windows.Forms.Label()
        Me.lbHienTrang = New System.Windows.Forms.Label()
        Me.lbTenSach = New System.Windows.Forms.Label()
        Me.btThemSach = New System.Windows.Forms.Button()
        Me.lbMaTheLoai = New System.Windows.Forms.Label()
        Me.lbTriGia = New System.Windows.Forms.Label()
        Me.lbNgayNhap = New System.Windows.Forms.Label()
        Me.lbMaNhaXuatBan = New System.Windows.Forms.Label()
        Me.lbNamXuatBan = New System.Windows.Forms.Label()
        Me.lbTacGia = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNumbers = New System.Windows.Forms.TextBox()
        Me.cbStatusID = New System.Windows.Forms.ComboBox()
        Me.txbValue = New System.Windows.Forms.TextBox()
        Me.dtpReceiptDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpPublishingYear = New System.Windows.Forms.DateTimePicker()
        Me.cbBookKindID = New System.Windows.Forms.ComboBox()
        Me.txbBookName = New System.Windows.Forms.TextBox()
        Me.Soluong_Label = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Delete_button = New System.Windows.Forms.Button()
        Me.Update_button = New System.Windows.Forms.Button()
        Me.Add_button = New System.Windows.Forms.Button()
        Me.dgvSach = New System.Windows.Forms.DataGridView()
        Me.TblSACHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TVDataBsDataSet2 = New QLyGUI.TVDataBsDataSet2()
        Me.TblSACHTableAdapter = New QLyGUI.TVDataBsDataSet2TableAdapters.tblSACHTableAdapter()
        Me.cbBookID = New System.Windows.Forms.TextBox()
        Me.cbAuthorID = New System.Windows.Forms.TextBox()
        Me.cbPublishingHouseID = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSACHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDataBsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbMaSach
        '
        Me.lbMaSach.AutoSize = True
        Me.lbMaSach.Location = New System.Drawing.Point(8, 32)
        Me.lbMaSach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaSach.Name = "lbMaSach"
        Me.lbMaSach.Size = New System.Drawing.Size(61, 17)
        Me.lbMaSach.TabIndex = 17
        Me.lbMaSach.Text = "Mã sách"
        '
        'lbHienTrang
        '
        Me.lbHienTrang.AutoSize = True
        Me.lbHienTrang.Location = New System.Drawing.Point(437, 150)
        Me.lbHienTrang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHienTrang.Name = "lbHienTrang"
        Me.lbHienTrang.Size = New System.Drawing.Size(74, 17)
        Me.lbHienTrang.TabIndex = 20
        Me.lbHienTrang.Text = "Hiện trạng"
        '
        'lbTenSach
        '
        Me.lbTenSach.AutoSize = True
        Me.lbTenSach.Location = New System.Drawing.Point(8, 71)
        Me.lbTenSach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTenSach.Name = "lbTenSach"
        Me.lbTenSach.Size = New System.Drawing.Size(67, 17)
        Me.lbTenSach.TabIndex = 0
        Me.lbTenSach.Text = "Tên sách"
        '
        'btThemSach
        '
        Me.btThemSach.Location = New System.Drawing.Point(1297, 575)
        Me.btThemSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btThemSach.Name = "btThemSach"
        Me.btThemSach.Size = New System.Drawing.Size(100, 28)
        Me.btThemSach.TabIndex = 15
        Me.btThemSach.Text = "Thêm sách"
        Me.btThemSach.UseVisualStyleBackColor = True
        '
        'lbMaTheLoai
        '
        Me.lbMaTheLoai.AutoSize = True
        Me.lbMaTheLoai.Location = New System.Drawing.Point(8, 110)
        Me.lbMaTheLoai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaTheLoai.Name = "lbMaTheLoai"
        Me.lbMaTheLoai.Size = New System.Drawing.Size(59, 17)
        Me.lbMaTheLoai.TabIndex = 7
        Me.lbMaTheLoai.Text = "Thể loại"
        '
        'lbTriGia
        '
        Me.lbTriGia.AutoSize = True
        Me.lbTriGia.Location = New System.Drawing.Point(437, 110)
        Me.lbTriGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTriGia.Name = "lbTriGia"
        Me.lbTriGia.Size = New System.Drawing.Size(48, 17)
        Me.lbTriGia.TabIndex = 6
        Me.lbTriGia.Text = "Trị giá"
        '
        'lbNgayNhap
        '
        Me.lbNgayNhap.AutoSize = True
        Me.lbNgayNhap.Location = New System.Drawing.Point(437, 71)
        Me.lbNgayNhap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgayNhap.Name = "lbNgayNhap"
        Me.lbNgayNhap.Size = New System.Drawing.Size(77, 17)
        Me.lbNgayNhap.TabIndex = 5
        Me.lbNgayNhap.Text = "Ngày nhập"
        '
        'lbMaNhaXuatBan
        '
        Me.lbMaNhaXuatBan.AutoSize = True
        Me.lbMaNhaXuatBan.Location = New System.Drawing.Point(8, 194)
        Me.lbMaNhaXuatBan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaNhaXuatBan.Name = "lbMaNhaXuatBan"
        Me.lbMaNhaXuatBan.Size = New System.Drawing.Size(115, 17)
        Me.lbMaNhaXuatBan.TabIndex = 4
        Me.lbMaNhaXuatBan.Text = "Mã Nhà xuất bản"
        '
        'lbNamXuatBan
        '
        Me.lbNamXuatBan.AutoSize = True
        Me.lbNamXuatBan.Location = New System.Drawing.Point(437, 32)
        Me.lbNamXuatBan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNamXuatBan.Name = "lbNamXuatBan"
        Me.lbNamXuatBan.Size = New System.Drawing.Size(95, 17)
        Me.lbNamXuatBan.TabIndex = 3
        Me.lbNamXuatBan.Text = "Năm xuất bản"
        '
        'lbTacGia
        '
        Me.lbTacGia.AutoSize = True
        Me.lbTacGia.Location = New System.Drawing.Point(8, 150)
        Me.lbTacGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTacGia.Name = "lbTacGia"
        Me.lbTacGia.Size = New System.Drawing.Size(78, 17)
        Me.lbTacGia.TabIndex = 2
        Me.lbTacGia.Text = "Mã Tác giả"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1027, 68)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(400, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quản lý sách"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.cbPublishingHouseID)
        Me.GroupBox2.Controls.Add(Me.cbAuthorID)
        Me.GroupBox2.Controls.Add(Me.cbBookID)
        Me.GroupBox2.Controls.Add(Me.txtNumbers)
        Me.GroupBox2.Controls.Add(Me.cbStatusID)
        Me.GroupBox2.Controls.Add(Me.txbValue)
        Me.GroupBox2.Controls.Add(Me.dtpReceiptDate)
        Me.GroupBox2.Controls.Add(Me.dtpPublishingYear)
        Me.GroupBox2.Controls.Add(Me.cbBookKindID)
        Me.GroupBox2.Controls.Add(Me.txbBookName)
        Me.GroupBox2.Controls.Add(Me.Soluong_Label)
        Me.GroupBox2.Controls.Add(Me.lbMaSach)
        Me.GroupBox2.Controls.Add(Me.lbTenSach)
        Me.GroupBox2.Controls.Add(Me.lbHienTrang)
        Me.GroupBox2.Controls.Add(Me.lbTriGia)
        Me.GroupBox2.Controls.Add(Me.lbMaTheLoai)
        Me.GroupBox2.Controls.Add(Me.lbTacGia)
        Me.GroupBox2.Controls.Add(Me.lbNgayNhap)
        Me.GroupBox2.Controls.Add(Me.lbNamXuatBan)
        Me.GroupBox2.Controls.Add(Me.lbMaNhaXuatBan)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 90)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(852, 233)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nhập đầy đủ các thông tin"
        '
        'txtNumbers
        '
        Me.txtNumbers.Location = New System.Drawing.Point(571, 187)
        Me.txtNumbers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.Size = New System.Drawing.Size(265, 22)
        Me.txtNumbers.TabIndex = 38
        '
        'cbStatusID
        '
        Me.cbStatusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatusID.FormattingEnabled = True
        Me.cbStatusID.Items.AddRange(New Object() {"Mới", "Cũ", "Đã Hỏng"})
        Me.cbStatusID.Location = New System.Drawing.Point(571, 146)
        Me.cbStatusID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbStatusID.Name = "cbStatusID"
        Me.cbStatusID.Size = New System.Drawing.Size(265, 24)
        Me.cbStatusID.TabIndex = 37
        '
        'txbValue
        '
        Me.txbValue.Location = New System.Drawing.Point(571, 107)
        Me.txbValue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbValue.Name = "txbValue"
        Me.txbValue.Size = New System.Drawing.Size(265, 22)
        Me.txbValue.TabIndex = 36
        '
        'dtpReceiptDate
        '
        Me.dtpReceiptDate.Location = New System.Drawing.Point(571, 68)
        Me.dtpReceiptDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpReceiptDate.Name = "dtpReceiptDate"
        Me.dtpReceiptDate.Size = New System.Drawing.Size(265, 22)
        Me.dtpReceiptDate.TabIndex = 35
        '
        'dtpPublishingYear
        '
        Me.dtpPublishingYear.Location = New System.Drawing.Point(571, 28)
        Me.dtpPublishingYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpPublishingYear.Name = "dtpPublishingYear"
        Me.dtpPublishingYear.Size = New System.Drawing.Size(265, 22)
        Me.dtpPublishingYear.TabIndex = 34
        '
        'cbBookKindID
        '
        Me.cbBookKindID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBookKindID.FormattingEnabled = True
        Me.cbBookKindID.Location = New System.Drawing.Point(141, 106)
        Me.cbBookKindID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbBookKindID.Name = "cbBookKindID"
        Me.cbBookKindID.Size = New System.Drawing.Size(265, 24)
        Me.cbBookKindID.TabIndex = 26
        '
        'txbBookName
        '
        Me.txbBookName.Location = New System.Drawing.Point(141, 68)
        Me.txbBookName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbBookName.Name = "txbBookName"
        Me.txbBookName.Size = New System.Drawing.Size(265, 22)
        Me.txbBookName.TabIndex = 25
        '
        'Soluong_Label
        '
        Me.Soluong_Label.AutoSize = True
        Me.Soluong_Label.Location = New System.Drawing.Point(437, 191)
        Me.Soluong_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Soluong_Label.Name = "Soluong_Label"
        Me.Soluong_Label.Size = New System.Drawing.Size(64, 17)
        Me.Soluong_Label.TabIndex = 22
        Me.Soluong_Label.Text = "Số lượng"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Controls.Add(Me.Delete_button)
        Me.GroupBox3.Controls.Add(Me.Update_button)
        Me.GroupBox3.Controls.Add(Me.Add_button)
        Me.GroupBox3.Location = New System.Drawing.Point(876, 90)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(167, 233)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chức năng"
        '
        'Delete_button
        '
        Me.Delete_button.BackColor = System.Drawing.Color.LightCoral
        Me.Delete_button.Image = CType(resources.GetObject("Delete_button.Image"), System.Drawing.Image)
        Me.Delete_button.Location = New System.Drawing.Point(28, 150)
        Me.Delete_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Delete_button.Name = "Delete_button"
        Me.Delete_button.Size = New System.Drawing.Size(117, 37)
        Me.Delete_button.TabIndex = 2
        Me.Delete_button.Text = "Xóa sách"
        Me.Delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Delete_button.UseVisualStyleBackColor = False
        '
        'Update_button
        '
        Me.Update_button.BackColor = System.Drawing.Color.LightGreen
        Me.Update_button.Image = CType(resources.GetObject("Update_button.Image"), System.Drawing.Image)
        Me.Update_button.Location = New System.Drawing.Point(28, 98)
        Me.Update_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Update_button.Name = "Update_button"
        Me.Update_button.Size = New System.Drawing.Size(117, 37)
        Me.Update_button.TabIndex = 1
        Me.Update_button.Text = "Cập nhật"
        Me.Update_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Update_button.UseVisualStyleBackColor = False
        '
        'Add_button
        '
        Me.Add_button.BackColor = System.Drawing.Color.LightGreen
        Me.Add_button.Image = CType(resources.GetObject("Add_button.Image"), System.Drawing.Image)
        Me.Add_button.Location = New System.Drawing.Point(28, 50)
        Me.Add_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Add_button.Name = "Add_button"
        Me.Add_button.Size = New System.Drawing.Size(117, 37)
        Me.Add_button.TabIndex = 0
        Me.Add_button.Text = "Thêm sách"
        Me.Add_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Add_button.UseVisualStyleBackColor = False
        '
        'dgvSach
        '
        Me.dgvSach.AllowUserToDeleteRows = False
        Me.dgvSach.AutoGenerateColumns = False
        Me.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgvSach.DataSource = Me.TblSACHBindingSource
        Me.dgvSach.Location = New System.Drawing.Point(16, 330)
        Me.dgvSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvSach.Name = "dgvSach"
        Me.dgvSach.ReadOnly = True
        Me.dgvSach.Size = New System.Drawing.Size(1027, 347)
        Me.dgvSach.TabIndex = 25
        '
        'TblSACHBindingSource
        '
        Me.TblSACHBindingSource.DataMember = "tblSACH"
        Me.TblSACHBindingSource.DataSource = Me.TVDataBsDataSet2
        '
        'TVDataBsDataSet2
        '
        Me.TVDataBsDataSet2.DataSetName = "TVDataBsDataSet2"
        Me.TVDataBsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSACHTableAdapter
        '
        Me.TblSACHTableAdapter.ClearBeforeFill = True
        '
        'cbBookID
        '
        Me.cbBookID.Location = New System.Drawing.Point(141, 30)
        Me.cbBookID.Margin = New System.Windows.Forms.Padding(4)
        Me.cbBookID.Name = "cbBookID"
        Me.cbBookID.Size = New System.Drawing.Size(265, 22)
        Me.cbBookID.TabIndex = 39
        '
        'cbAuthorID
        '
        Me.cbAuthorID.Location = New System.Drawing.Point(141, 147)
        Me.cbAuthorID.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAuthorID.Name = "cbAuthorID"
        Me.cbAuthorID.Size = New System.Drawing.Size(265, 22)
        Me.cbAuthorID.TabIndex = 40
        '
        'cbPublishingHouseID
        '
        Me.cbPublishingHouseID.Location = New System.Drawing.Point(141, 191)
        Me.cbPublishingHouseID.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPublishingHouseID.Name = "cbPublishingHouseID"
        Me.cbPublishingHouseID.Size = New System.Drawing.Size(265, 22)
        Me.cbPublishingHouseID.TabIndex = 41
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "masach"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã sách"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tensach"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tên sách"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "matheloai"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Thể loại"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "matacgia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Mã Tác giả"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "namxuatban"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Năm xuất bản"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "manhaxuatban"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Mã Nhà xuất bản"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ngaynhap"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ngày nhập"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "trigia"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Trị Giá"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "matinhtrang"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tình Trạng"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "soluong"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Số lượng"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'frmTiepnhanSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 690)
        Me.Controls.Add(Me.dgvSach)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btThemSach)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmTiepnhanSach"
        Me.Text = "Tiếp Nhận Sách"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSACHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDataBsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbMaSach As Label
    Friend WithEvents lbHienTrang As Label
    Friend WithEvents lbTenSach As Label
    Friend WithEvents btThemSach As Button
    Friend WithEvents lbMaTheLoai As Label
    Friend WithEvents lbTriGia As Label
    Friend WithEvents lbNgayNhap As Label
    Friend WithEvents lbMaNhaXuatBan As Label
    Friend WithEvents lbNamXuatBan As Label
    Friend WithEvents lbTacGia As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Add_button As Button
    Friend WithEvents Delete_button As Button
    Friend WithEvents Update_button As Button
    Friend WithEvents dgvSach As DataGridView
    Friend WithEvents Soluong_Label As Label
    Friend WithEvents cbBookKindID As ComboBox
    Friend WithEvents txbBookName As TextBox
    Friend WithEvents dtpPublishingYear As DateTimePicker
    Friend WithEvents txtNumbers As TextBox
    Friend WithEvents cbStatusID As ComboBox
    Friend WithEvents txbValue As TextBox
    Friend WithEvents dtpReceiptDate As DateTimePicker
    Friend WithEvents MasachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TensachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatheloaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatacgiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamxuatbanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManhaxuatbanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaynhapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrigiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatinhtrangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoluongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TVDataBsDataSet2 As TVDataBsDataSet2
    Friend WithEvents TblSACHBindingSource As BindingSource
    Friend WithEvents TblSACHTableAdapter As TVDataBsDataSet2TableAdapters.tblSACHTableAdapter
    Friend WithEvents cbPublishingHouseID As TextBox
    Friend WithEvents cbAuthorID As TextBox
    Friend WithEvents cbBookID As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
