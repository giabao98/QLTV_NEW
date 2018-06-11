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
        Me.lbMaHienTrang = New System.Windows.Forms.Label()
        Me.lbTenSach = New System.Windows.Forms.Label()
        Me.btThemSach = New System.Windows.Forms.Button()
        Me.lbMaTheLoai = New System.Windows.Forms.Label()
        Me.lbTriGia = New System.Windows.Forms.Label()
        Me.lbNgayNhap = New System.Windows.Forms.Label()
        Me.lbMaNhaXuatBan = New System.Windows.Forms.Label()
        Me.lbNamXuatBan = New System.Windows.Forms.Label()
        Me.lbMaTacGia = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNumbers = New System.Windows.Forms.TextBox()
        Me.cbStatusID = New System.Windows.Forms.ComboBox()
        Me.txbValue = New System.Windows.Forms.TextBox()
        Me.dtpReceiptDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpPublishingYear = New System.Windows.Forms.DateTimePicker()
        Me.cbPublishingHouseID = New System.Windows.Forms.ComboBox()
        Me.cbAuthorID = New System.Windows.Forms.ComboBox()
        Me.cbBookKindID = New System.Windows.Forms.ComboBox()
        Me.txbBookName = New System.Windows.Forms.TextBox()
        Me.cbBookID = New System.Windows.Forms.ComboBox()
        Me.Soluong_Label = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Delete_button = New System.Windows.Forms.Button()
        Me.Update_button = New System.Windows.Forms.Button()
        Me.Add_button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MasachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TensachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatheloaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatacgiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamxuatbanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManhaxuatbanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaynhapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrigiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatinhtrangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoluongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSACHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TVDataBsDataSet2 = New QLyGUI.TVDataBsDataSet2()
        Me.TblSACHTableAdapter = New QLyGUI.TVDataBsDataSet2TableAdapters.tblSACHTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSACHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDataBsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lbMaHienTrang
        '
        Me.lbMaHienTrang.AutoSize = True
        Me.lbMaHienTrang.Location = New System.Drawing.Point(328, 122)
        Me.lbMaHienTrang.Name = "lbMaHienTrang"
        Me.lbMaHienTrang.Size = New System.Drawing.Size(72, 13)
        Me.lbMaHienTrang.TabIndex = 20
        Me.lbMaHienTrang.Text = "Mã hiện trạng"
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
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
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
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.txtNumbers)
        Me.GroupBox2.Controls.Add(Me.cbStatusID)
        Me.GroupBox2.Controls.Add(Me.txbValue)
        Me.GroupBox2.Controls.Add(Me.dtpReceiptDate)
        Me.GroupBox2.Controls.Add(Me.dtpPublishingYear)
        Me.GroupBox2.Controls.Add(Me.cbPublishingHouseID)
        Me.GroupBox2.Controls.Add(Me.cbAuthorID)
        Me.GroupBox2.Controls.Add(Me.cbBookKindID)
        Me.GroupBox2.Controls.Add(Me.txbBookName)
        Me.GroupBox2.Controls.Add(Me.cbBookID)
        Me.GroupBox2.Controls.Add(Me.Soluong_Label)
        Me.GroupBox2.Controls.Add(Me.lbMaSach)
        Me.GroupBox2.Controls.Add(Me.lbTenSach)
        Me.GroupBox2.Controls.Add(Me.lbMaHienTrang)
        Me.GroupBox2.Controls.Add(Me.lbTriGia)
        Me.GroupBox2.Controls.Add(Me.lbMaTheLoai)
        Me.GroupBox2.Controls.Add(Me.lbMaTacGia)
        Me.GroupBox2.Controls.Add(Me.lbNgayNhap)
        Me.GroupBox2.Controls.Add(Me.lbNamXuatBan)
        Me.GroupBox2.Controls.Add(Me.lbMaNhaXuatBan)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(639, 189)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nhập đầy đủ các thông tin"
        '
        'txtNumbers
        '
        Me.txtNumbers.Location = New System.Drawing.Point(428, 152)
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.Size = New System.Drawing.Size(200, 20)
        Me.txtNumbers.TabIndex = 38
        '
        'cbStatusID
        '
        Me.cbStatusID.FormattingEnabled = True
        Me.cbStatusID.Location = New System.Drawing.Point(428, 119)
        Me.cbStatusID.Name = "cbStatusID"
        Me.cbStatusID.Size = New System.Drawing.Size(200, 21)
        Me.cbStatusID.TabIndex = 37
        '
        'txbValue
        '
        Me.txbValue.Location = New System.Drawing.Point(428, 87)
        Me.txbValue.Name = "txbValue"
        Me.txbValue.Size = New System.Drawing.Size(200, 20)
        Me.txbValue.TabIndex = 36
        '
        'dtpReceiptDate
        '
        Me.dtpReceiptDate.Location = New System.Drawing.Point(428, 55)
        Me.dtpReceiptDate.Name = "dtpReceiptDate"
        Me.dtpReceiptDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpReceiptDate.TabIndex = 35
        '
        'dtpPublishingYear
        '
        Me.dtpPublishingYear.Location = New System.Drawing.Point(428, 23)
        Me.dtpPublishingYear.Name = "dtpPublishingYear"
        Me.dtpPublishingYear.Size = New System.Drawing.Size(200, 20)
        Me.dtpPublishingYear.TabIndex = 34
        '
        'cbPublishingHouseID
        '
        Me.cbPublishingHouseID.FormattingEnabled = True
        Me.cbPublishingHouseID.Location = New System.Drawing.Point(106, 152)
        Me.cbPublishingHouseID.Name = "cbPublishingHouseID"
        Me.cbPublishingHouseID.Size = New System.Drawing.Size(200, 21)
        Me.cbPublishingHouseID.TabIndex = 28
        '
        'cbAuthorID
        '
        Me.cbAuthorID.FormattingEnabled = True
        Me.cbAuthorID.Location = New System.Drawing.Point(106, 119)
        Me.cbAuthorID.Name = "cbAuthorID"
        Me.cbAuthorID.Size = New System.Drawing.Size(200, 21)
        Me.cbAuthorID.TabIndex = 27
        '
        'cbBookKindID
        '
        Me.cbBookKindID.FormattingEnabled = True
        Me.cbBookKindID.Location = New System.Drawing.Point(106, 86)
        Me.cbBookKindID.Name = "cbBookKindID"
        Me.cbBookKindID.Size = New System.Drawing.Size(200, 21)
        Me.cbBookKindID.TabIndex = 26
        '
        'txbBookName
        '
        Me.txbBookName.Location = New System.Drawing.Point(106, 55)
        Me.txbBookName.Name = "txbBookName"
        Me.txbBookName.Size = New System.Drawing.Size(200, 20)
        Me.txbBookName.TabIndex = 25
        '
        'cbBookID
        '
        Me.cbBookID.FormattingEnabled = True
        Me.cbBookID.Location = New System.Drawing.Point(106, 23)
        Me.cbBookID.Name = "cbBookID"
        Me.cbBookID.Size = New System.Drawing.Size(200, 21)
        Me.cbBookID.TabIndex = 24
        '
        'Soluong_Label
        '
        Me.Soluong_Label.AutoSize = True
        Me.Soluong_Label.Location = New System.Drawing.Point(328, 155)
        Me.Soluong_Label.Name = "Soluong_Label"
        Me.Soluong_Label.Size = New System.Drawing.Size(49, 13)
        Me.Soluong_Label.TabIndex = 22
        Me.Soluong_Label.Text = "Số lượng"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
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
        'Delete_button
        '
        Me.Delete_button.BackColor = System.Drawing.Color.LightCoral
        Me.Delete_button.Image = CType(resources.GetObject("Delete_button.Image"), System.Drawing.Image)
        Me.Delete_button.Location = New System.Drawing.Point(21, 122)
        Me.Delete_button.Name = "Delete_button"
        Me.Delete_button.Size = New System.Drawing.Size(88, 30)
        Me.Delete_button.TabIndex = 2
        Me.Delete_button.Text = "Xóa sách"
        Me.Delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Delete_button.UseVisualStyleBackColor = False
        '
        'Update_button
        '
        Me.Update_button.BackColor = System.Drawing.Color.LightGreen
        Me.Update_button.Image = CType(resources.GetObject("Update_button.Image"), System.Drawing.Image)
        Me.Update_button.Location = New System.Drawing.Point(21, 80)
        Me.Update_button.Name = "Update_button"
        Me.Update_button.Size = New System.Drawing.Size(88, 30)
        Me.Update_button.TabIndex = 1
        Me.Update_button.Text = "Cập nhật"
        Me.Update_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Update_button.UseVisualStyleBackColor = False
        '
        'Add_button
        '
        Me.Add_button.BackColor = System.Drawing.Color.LightGreen
        Me.Add_button.Image = CType(resources.GetObject("Add_button.Image"), System.Drawing.Image)
        Me.Add_button.Location = New System.Drawing.Point(21, 41)
        Me.Add_button.Name = "Add_button"
        Me.Add_button.Size = New System.Drawing.Size(88, 30)
        Me.Add_button.TabIndex = 0
        Me.Add_button.Text = "Thêm sách"
        Me.Add_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Add_button.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MasachDataGridViewTextBoxColumn, Me.TensachDataGridViewTextBoxColumn, Me.MatheloaiDataGridViewTextBoxColumn, Me.MatacgiaDataGridViewTextBoxColumn, Me.NamxuatbanDataGridViewTextBoxColumn, Me.ManhaxuatbanDataGridViewTextBoxColumn, Me.NgaynhapDataGridViewTextBoxColumn, Me.TrigiaDataGridViewTextBoxColumn, Me.MatinhtrangDataGridViewTextBoxColumn, Me.SoluongDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblSACHBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(770, 226)
        Me.DataGridView1.TabIndex = 25
        '
        'MasachDataGridViewTextBoxColumn
        '
        Me.MasachDataGridViewTextBoxColumn.DataPropertyName = "masach"
        Me.MasachDataGridViewTextBoxColumn.HeaderText = "Mã sách"
        Me.MasachDataGridViewTextBoxColumn.Name = "MasachDataGridViewTextBoxColumn"
        Me.MasachDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TensachDataGridViewTextBoxColumn
        '
        Me.TensachDataGridViewTextBoxColumn.DataPropertyName = "tensach"
        Me.TensachDataGridViewTextBoxColumn.HeaderText = "Tên sách"
        Me.TensachDataGridViewTextBoxColumn.Name = "TensachDataGridViewTextBoxColumn"
        Me.TensachDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatheloaiDataGridViewTextBoxColumn
        '
        Me.MatheloaiDataGridViewTextBoxColumn.DataPropertyName = "matheloai"
        Me.MatheloaiDataGridViewTextBoxColumn.HeaderText = "Mã thể loại"
        Me.MatheloaiDataGridViewTextBoxColumn.Name = "MatheloaiDataGridViewTextBoxColumn"
        Me.MatheloaiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatacgiaDataGridViewTextBoxColumn
        '
        Me.MatacgiaDataGridViewTextBoxColumn.DataPropertyName = "matacgia"
        Me.MatacgiaDataGridViewTextBoxColumn.HeaderText = "Mã tác giả"
        Me.MatacgiaDataGridViewTextBoxColumn.Name = "MatacgiaDataGridViewTextBoxColumn"
        Me.MatacgiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamxuatbanDataGridViewTextBoxColumn
        '
        Me.NamxuatbanDataGridViewTextBoxColumn.DataPropertyName = "namxuatban"
        Me.NamxuatbanDataGridViewTextBoxColumn.HeaderText = "Năm xuất bản"
        Me.NamxuatbanDataGridViewTextBoxColumn.Name = "NamxuatbanDataGridViewTextBoxColumn"
        Me.NamxuatbanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ManhaxuatbanDataGridViewTextBoxColumn
        '
        Me.ManhaxuatbanDataGridViewTextBoxColumn.DataPropertyName = "manhaxuatban"
        Me.ManhaxuatbanDataGridViewTextBoxColumn.HeaderText = "Mã nhà xuất bản"
        Me.ManhaxuatbanDataGridViewTextBoxColumn.Name = "ManhaxuatbanDataGridViewTextBoxColumn"
        Me.ManhaxuatbanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NgaynhapDataGridViewTextBoxColumn
        '
        Me.NgaynhapDataGridViewTextBoxColumn.DataPropertyName = "ngaynhap"
        Me.NgaynhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập"
        Me.NgaynhapDataGridViewTextBoxColumn.Name = "NgaynhapDataGridViewTextBoxColumn"
        Me.NgaynhapDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrigiaDataGridViewTextBoxColumn
        '
        Me.TrigiaDataGridViewTextBoxColumn.DataPropertyName = "trigia"
        Me.TrigiaDataGridViewTextBoxColumn.HeaderText = "Trị giá"
        Me.TrigiaDataGridViewTextBoxColumn.Name = "TrigiaDataGridViewTextBoxColumn"
        Me.TrigiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatinhtrangDataGridViewTextBoxColumn
        '
        Me.MatinhtrangDataGridViewTextBoxColumn.DataPropertyName = "matinhtrang"
        Me.MatinhtrangDataGridViewTextBoxColumn.HeaderText = "Mã tình trạng"
        Me.MatinhtrangDataGridViewTextBoxColumn.Name = "MatinhtrangDataGridViewTextBoxColumn"
        Me.MatinhtrangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoluongDataGridViewTextBoxColumn
        '
        Me.SoluongDataGridViewTextBoxColumn.DataPropertyName = "soluong"
        Me.SoluongDataGridViewTextBoxColumn.HeaderText = "Số lượng"
        Me.SoluongDataGridViewTextBoxColumn.Name = "SoluongDataGridViewTextBoxColumn"
        Me.SoluongDataGridViewTextBoxColumn.ReadOnly = True
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
        CType(Me.TblSACHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDataBsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbMaSach As Label
    Friend WithEvents lbMaHienTrang As Label
    Friend WithEvents lbTenSach As Label
    Friend WithEvents btThemSach As Button
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
    Friend WithEvents Soluong_Label As Label
    Friend WithEvents cbBookKindID As ComboBox
    Friend WithEvents txbBookName As TextBox
    Friend WithEvents cbBookID As ComboBox
    Friend WithEvents cbPublishingHouseID As ComboBox
    Friend WithEvents cbAuthorID As ComboBox
    Friend WithEvents dtpPublishingYear As DateTimePicker
    Friend WithEvents txtNumbers As TextBox
    Friend WithEvents cbStatusID As ComboBox
    Friend WithEvents txbValue As TextBox
    Friend WithEvents dtpReceiptDate As DateTimePicker
    Friend WithEvents TVDataBsDataSet2 As TVDataBsDataSet2
    Friend WithEvents TblSACHBindingSource As BindingSource
    Friend WithEvents TblSACHTableAdapter As TVDataBsDataSet2TableAdapters.tblSACHTableAdapter
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
End Class
