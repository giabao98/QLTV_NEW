<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuyDinhTheLoaiSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuyDinhTheLoaiSach))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabTheLoai = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbTenTheLoai = New System.Windows.Forms.TextBox()
        Me.lbTenLoaiDocGia = New System.Windows.Forms.Label()
        Me.txbMaTheLoai = New System.Windows.Forms.TextBox()
        Me.lbMaLoaiDocGia = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvTheLoaiSach = New System.Windows.Forms.DataGridView()
        Me.MatheloaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TentheloaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblTHELOAIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TVDataBsDataSet6 = New QLyGUI.TVDataBsDataSet6()
        Me.tabNamXuatBan = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateNamXB = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txbSoLuong = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbKhoangNamXB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TblTHELOAITableAdapter = New QLyGUI.TVDataBsDataSet6TableAdapters.tblTHELOAITableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabTheLoai.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTheLoaiSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTHELOAIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDataBsDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNamXuatBan.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabTheLoai)
        Me.TabControl1.Controls.Add(Me.tabNamXuatBan)
        Me.TabControl1.Location = New System.Drawing.Point(-2, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(569, 509)
        Me.TabControl1.TabIndex = 0
        '
        'tabTheLoai
        '
        Me.tabTheLoai.Controls.Add(Me.GroupBox3)
        Me.tabTheLoai.Controls.Add(Me.GroupBox2)
        Me.tabTheLoai.Controls.Add(Me.GroupBox1)
        Me.tabTheLoai.Controls.Add(Me.dgvTheLoaiSach)
        Me.tabTheLoai.Location = New System.Drawing.Point(4, 25)
        Me.tabTheLoai.Name = "tabTheLoai"
        Me.tabTheLoai.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTheLoai.Size = New System.Drawing.Size(561, 480)
        Me.tabTheLoai.TabIndex = 0
        Me.tabTheLoai.Text = "Thể Loại"
        Me.tabTheLoai.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Location = New System.Drawing.Point(397, 81)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(160, 171)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chức năng"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(24, 123)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 37)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightGreen
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(24, 79)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 37)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "Cập nhật"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightGreen
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(24, 34)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 37)
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.txbTenTheLoai)
        Me.GroupBox2.Controls.Add(Me.lbTenLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.txbMaTheLoai)
        Me.GroupBox2.Controls.Add(Me.lbMaLoaiDocGia)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 81)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(385, 171)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin chi tiết"
        '
        'txbTenTheLoai
        '
        Me.txbTenTheLoai.Location = New System.Drawing.Point(136, 86)
        Me.txbTenTheLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txbTenTheLoai.Name = "txbTenTheLoai"
        Me.txbTenTheLoai.Size = New System.Drawing.Size(205, 22)
        Me.txbTenTheLoai.TabIndex = 21
        '
        'lbTenLoaiDocGia
        '
        Me.lbTenLoaiDocGia.AutoSize = True
        Me.lbTenLoaiDocGia.Location = New System.Drawing.Point(8, 90)
        Me.lbTenLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTenLoaiDocGia.Name = "lbTenLoaiDocGia"
        Me.lbTenLoaiDocGia.Size = New System.Drawing.Size(87, 17)
        Me.lbTenLoaiDocGia.TabIndex = 20
        Me.lbTenLoaiDocGia.Text = "Tên thể loại:"
        '
        'txbMaTheLoai
        '
        Me.txbMaTheLoai.Location = New System.Drawing.Point(136, 43)
        Me.txbMaTheLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txbMaTheLoai.Name = "txbMaTheLoai"
        Me.txbMaTheLoai.Size = New System.Drawing.Size(205, 22)
        Me.txbMaTheLoai.TabIndex = 19
        '
        'lbMaLoaiDocGia
        '
        Me.lbMaLoaiDocGia.AutoSize = True
        Me.lbMaLoaiDocGia.Location = New System.Drawing.Point(8, 47)
        Me.lbMaLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaLoaiDocGia.Name = "lbMaLoaiDocGia"
        Me.lbMaLoaiDocGia.Size = New System.Drawing.Size(81, 17)
        Me.lbMaLoaiDocGia.TabIndex = 18
        Me.lbMaLoaiDocGia.Text = "Mã thể loại:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(553, 74)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(106, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quy Định Thể Loại Sách"
        '
        'dgvTheLoaiSach
        '
        Me.dgvTheLoaiSach.AllowUserToAddRows = False
        Me.dgvTheLoaiSach.AllowUserToDeleteRows = False
        Me.dgvTheLoaiSach.AutoGenerateColumns = False
        Me.dgvTheLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTheLoaiSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatheloaiDataGridViewTextBoxColumn, Me.TentheloaiDataGridViewTextBoxColumn})
        Me.dgvTheLoaiSach.DataSource = Me.TblTHELOAIBindingSource
        Me.dgvTheLoaiSach.Location = New System.Drawing.Point(4, 259)
        Me.dgvTheLoaiSach.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTheLoaiSach.Name = "dgvTheLoaiSach"
        Me.dgvTheLoaiSach.ReadOnly = True
        Me.dgvTheLoaiSach.Size = New System.Drawing.Size(553, 214)
        Me.dgvTheLoaiSach.TabIndex = 42
        '
        'MatheloaiDataGridViewTextBoxColumn
        '
        Me.MatheloaiDataGridViewTextBoxColumn.DataPropertyName = "matheloai"
        Me.MatheloaiDataGridViewTextBoxColumn.HeaderText = "Mã Thể Loại"
        Me.MatheloaiDataGridViewTextBoxColumn.Name = "MatheloaiDataGridViewTextBoxColumn"
        Me.MatheloaiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TentheloaiDataGridViewTextBoxColumn
        '
        Me.TentheloaiDataGridViewTextBoxColumn.DataPropertyName = "tentheloai"
        Me.TentheloaiDataGridViewTextBoxColumn.HeaderText = "Tên Thể Loại"
        Me.TentheloaiDataGridViewTextBoxColumn.Name = "TentheloaiDataGridViewTextBoxColumn"
        Me.TentheloaiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblTHELOAIBindingSource
        '
        Me.TblTHELOAIBindingSource.DataMember = "tblTHELOAI"
        Me.TblTHELOAIBindingSource.DataSource = Me.TVDataBsDataSet6
        '
        'TVDataBsDataSet6
        '
        Me.TVDataBsDataSet6.DataSetName = "TVDataBsDataSet6"
        Me.TVDataBsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tabNamXuatBan
        '
        Me.tabNamXuatBan.BackColor = System.Drawing.Color.LightSeaGreen
        Me.tabNamXuatBan.Controls.Add(Me.GroupBox4)
        Me.tabNamXuatBan.Controls.Add(Me.GroupBox5)
        Me.tabNamXuatBan.Controls.Add(Me.GroupBox6)
        Me.tabNamXuatBan.Location = New System.Drawing.Point(4, 25)
        Me.tabNamXuatBan.Name = "tabNamXuatBan"
        Me.tabNamXuatBan.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNamXuatBan.Size = New System.Drawing.Size(561, 480)
        Me.tabNamXuatBan.TabIndex = 1
        Me.tabNamXuatBan.Text = "Năm Xuất Bản"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox4.Controls.Add(Me.btnUpdateNamXB)
        Me.GroupBox4.Location = New System.Drawing.Point(397, 144)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(160, 183)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Chức năng"
        '
        'btnUpdateNamXB
        '
        Me.btnUpdateNamXB.BackColor = System.Drawing.Color.LightGreen
        Me.btnUpdateNamXB.Image = CType(resources.GetObject("btnUpdateNamXB.Image"), System.Drawing.Image)
        Me.btnUpdateNamXB.Location = New System.Drawing.Point(27, 71)
        Me.btnUpdateNamXB.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateNamXB.Name = "btnUpdateNamXB"
        Me.btnUpdateNamXB.Size = New System.Drawing.Size(111, 37)
        Me.btnUpdateNamXB.TabIndex = 32
        Me.btnUpdateNamXB.Text = "Cập nhật"
        Me.btnUpdateNamXB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateNamXB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateNamXB.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox5.Controls.Add(Me.txbSoLuong)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txbKhoangNamXB)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 144)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(385, 183)
        Me.GroupBox5.TabIndex = 43
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Thông tin chi tiết"
        '
        'txbSoLuong
        '
        Me.txbSoLuong.Location = New System.Drawing.Point(158, 102)
        Me.txbSoLuong.Margin = New System.Windows.Forms.Padding(4)
        Me.txbSoLuong.Name = "txbSoLuong"
        Me.txbSoLuong.Size = New System.Drawing.Size(205, 22)
        Me.txbSoLuong.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Số lượng sách tối đa:"
        '
        'txbKhoangNamXB
        '
        Me.txbKhoangNamXB.Location = New System.Drawing.Point(158, 58)
        Me.txbKhoangNamXB.Margin = New System.Windows.Forms.Padding(4)
        Me.txbKhoangNamXB.Name = "txbKhoangNamXB"
        Me.txbKhoangNamXB.Size = New System.Drawing.Size(205, 22)
        Me.txbKhoangNamXB.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 61)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Số Năm:"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(553, 117)
        Me.GroupBox6.TabIndex = 42
        Me.GroupBox6.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(56, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(420, 36)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Khoảng Cách Năm Xuất Bản"
        '
        'TblTHELOAITableAdapter
        '
        Me.TblTHELOAITableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(76, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(384, 36)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Và Số Lượng Sách Tối Đa"
        '
        'frmQuyDinhTheLoaiSach
        '
        Me.AcceptButton = Me.btnUpdateNamXB
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 505)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmQuyDinhTheLoaiSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Quy định thể loại sách và năm xuất bản"
        Me.TabControl1.ResumeLayout(False)
        Me.tabTheLoai.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTheLoaiSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTHELOAIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDataBsDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNamXuatBan.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabTheLoai As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txbTenTheLoai As TextBox
    Friend WithEvents lbTenLoaiDocGia As Label
    Friend WithEvents txbMaTheLoai As TextBox
    Friend WithEvents lbMaLoaiDocGia As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvTheLoaiSach As DataGridView
    Friend WithEvents TblTHELOAIBindingSource As BindingSource
    Friend WithEvents TVDataBsDataSet6 As TVDataBsDataSet6
    Friend WithEvents tabNamXuatBan As TabPage
    Friend WithEvents TblTHELOAITableAdapter As TVDataBsDataSet6TableAdapters.tblTHELOAITableAdapter
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnUpdateNamXB As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txbKhoangNamXB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MatheloaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TentheloaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txbSoLuong As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
