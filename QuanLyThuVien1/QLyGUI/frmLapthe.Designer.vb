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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLapthe))
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
        Me.Add_button = New System.Windows.Forms.Button()
        Me.dgvDocGia = New System.Windows.Forms.DataGridView()
        Me.MadocgiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaidocgiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaysinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiachiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaylaptheDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblDOCGIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TVDataBsDataSet1 = New QLyGUI.TVDataBsDataSet1()
        Me.TblDOCGIATableAdapter = New QLyGUI.TVDataBsDataSet1TableAdapters.tblDOCGIATableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDOCGIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDataBsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpNgayLapThe
        '
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(553, 102)
        Me.dtpNgayLapThe.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayLapThe.Name = "dtpNgayLapThe"
        Me.dtpNgayLapThe.Size = New System.Drawing.Size(265, 22)
        Me.dtpNgayLapThe.TabIndex = 29
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Location = New System.Drawing.Point(553, 65)
        Me.dtpNgaySinh.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(265, 22)
        Me.dtpNgaySinh.TabIndex = 28
        '
        'cbLoaiDocGia
        '
        Me.cbLoaiDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoaiDocGia.FormattingEnabled = True
        Me.cbLoaiDocGia.Items.AddRange(New Object() {"X", "Y"})
        Me.cbLoaiDocGia.Location = New System.Drawing.Point(553, 31)
        Me.cbLoaiDocGia.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLoaiDocGia.Name = "cbLoaiDocGia"
        Me.cbLoaiDocGia.Size = New System.Drawing.Size(265, 24)
        Me.cbLoaiDocGia.TabIndex = 27
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(119, 145)
        Me.txbEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(265, 22)
        Me.txbEmail.TabIndex = 26
        '
        'txbDiaChi
        '
        Me.txbDiaChi.Location = New System.Drawing.Point(119, 106)
        Me.txbDiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txbDiaChi.Name = "txbDiaChi"
        Me.txbDiaChi.Size = New System.Drawing.Size(265, 22)
        Me.txbDiaChi.TabIndex = 25
        '
        'txbTenDocGia
        '
        Me.txbTenDocGia.Location = New System.Drawing.Point(119, 69)
        Me.txbTenDocGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txbTenDocGia.Name = "txbTenDocGia"
        Me.txbTenDocGia.Size = New System.Drawing.Size(265, 22)
        Me.txbTenDocGia.TabIndex = 24
        '
        'txbMaDocGia
        '
        Me.txbMaDocGia.Location = New System.Drawing.Point(119, 31)
        Me.txbMaDocGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txbMaDocGia.Name = "txbMaDocGia"
        Me.txbMaDocGia.Size = New System.Drawing.Size(265, 22)
        Me.txbMaDocGia.TabIndex = 23
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Location = New System.Drawing.Point(8, 110)
        Me.lbDiaChi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(51, 17)
        Me.lbDiaChi.TabIndex = 22
        Me.lbDiaChi.Text = "Địa chỉ"
        '
        'lbNgayLapThe
        '
        Me.lbNgayLapThe.AutoSize = True
        Me.lbNgayLapThe.Location = New System.Drawing.Point(443, 110)
        Me.lbNgayLapThe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgayLapThe.Name = "lbNgayLapThe"
        Me.lbNgayLapThe.Size = New System.Drawing.Size(88, 17)
        Me.lbNgayLapThe.TabIndex = 21
        Me.lbNgayLapThe.Text = "Ngày lập thẻ"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(8, 149)
        Me.lbEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(42, 17)
        Me.lbEmail.TabIndex = 20
        Me.lbEmail.Text = "Email"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(443, 73)
        Me.lbNgaySinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(71, 17)
        Me.lbNgaySinh.TabIndex = 19
        Me.lbNgaySinh.Text = "Ngày sinh"
        '
        'lbLoaiDocGia
        '
        Me.lbLoaiDocGia.AutoSize = True
        Me.lbLoaiDocGia.Location = New System.Drawing.Point(443, 34)
        Me.lbLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLoaiDocGia.Name = "lbLoaiDocGia"
        Me.lbLoaiDocGia.Size = New System.Drawing.Size(85, 17)
        Me.lbLoaiDocGia.TabIndex = 18
        Me.lbLoaiDocGia.Text = "Loại độc giả"
        '
        'lbTenDocGia
        '
        Me.lbTenDocGia.AutoSize = True
        Me.lbTenDocGia.Location = New System.Drawing.Point(8, 69)
        Me.lbTenDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTenDocGia.Name = "lbTenDocGia"
        Me.lbTenDocGia.Size = New System.Drawing.Size(83, 17)
        Me.lbTenDocGia.TabIndex = 17
        Me.lbTenDocGia.Text = "Tên độc giả"
        '
        'lbMaDocGia
        '
        Me.lbMaDocGia.AutoSize = True
        Me.lbMaDocGia.Location = New System.Drawing.Point(8, 33)
        Me.lbMaDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaDocGia.Name = "lbMaDocGia"
        Me.lbMaDocGia.Size = New System.Drawing.Size(77, 17)
        Me.lbMaDocGia.TabIndex = 16
        Me.lbMaDocGia.Text = "Mã độc giả"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1027, 74)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(395, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quản lý đọc giả"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
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
        Me.GroupBox2.Location = New System.Drawing.Point(16, 96)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(837, 185)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin chi tiết"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Controls.Add(Me.Delete_button)
        Me.GroupBox3.Controls.Add(Me.Update_button)
        Me.GroupBox3.Controls.Add(Me.Add_button)
        Me.GroupBox3.Location = New System.Drawing.Point(861, 96)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(181, 185)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chức năng"
        '
        'Delete_button
        '
        Me.Delete_button.BackColor = System.Drawing.Color.LightCoral
        Me.Delete_button.Image = CType(resources.GetObject("Delete_button.Image"), System.Drawing.Image)
        Me.Delete_button.Location = New System.Drawing.Point(32, 138)
        Me.Delete_button.Margin = New System.Windows.Forms.Padding(4)
        Me.Delete_button.Name = "Delete_button"
        Me.Delete_button.Size = New System.Drawing.Size(117, 37)
        Me.Delete_button.TabIndex = 33
        Me.Delete_button.Text = "Xóa thẻ"
        Me.Delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Delete_button.UseVisualStyleBackColor = False
        '
        'Update_button
        '
        Me.Update_button.BackColor = System.Drawing.Color.LightGreen
        Me.Update_button.Image = CType(resources.GetObject("Update_button.Image"), System.Drawing.Image)
        Me.Update_button.Location = New System.Drawing.Point(32, 89)
        Me.Update_button.Margin = New System.Windows.Forms.Padding(4)
        Me.Update_button.Name = "Update_button"
        Me.Update_button.Size = New System.Drawing.Size(117, 37)
        Me.Update_button.TabIndex = 32
        Me.Update_button.Text = "Cập nhật"
        Me.Update_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Update_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Update_button.UseVisualStyleBackColor = False
        '
        'Add_button
        '
        Me.Add_button.BackColor = System.Drawing.Color.LightGreen
        Me.Add_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_button.Image = CType(resources.GetObject("Add_button.Image"), System.Drawing.Image)
        Me.Add_button.Location = New System.Drawing.Point(32, 34)
        Me.Add_button.Margin = New System.Windows.Forms.Padding(4)
        Me.Add_button.Name = "Add_button"
        Me.Add_button.Size = New System.Drawing.Size(117, 37)
        Me.Add_button.TabIndex = 31
        Me.Add_button.Text = "Lập thẻ"
        Me.Add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Add_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Add_button.UseVisualStyleBackColor = False
        '
        'dgvDocGia
        '
        Me.dgvDocGia.AllowUserToAddRows = False
        Me.dgvDocGia.AllowUserToDeleteRows = False
        Me.dgvDocGia.AutoGenerateColumns = False
        Me.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocGia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MadocgiaDataGridViewTextBoxColumn, Me.HotenDataGridViewTextBoxColumn, Me.LoaidocgiaDataGridViewTextBoxColumn, Me.NgaysinhDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DiachiDataGridViewTextBoxColumn, Me.NgaylaptheDataGridViewTextBoxColumn})
        Me.dgvDocGia.DataSource = Me.TblDOCGIABindingSource
        Me.dgvDocGia.Location = New System.Drawing.Point(16, 288)
        Me.dgvDocGia.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDocGia.Name = "dgvDocGia"
        Me.dgvDocGia.ReadOnly = True
        Me.dgvDocGia.Size = New System.Drawing.Size(1027, 251)
        Me.dgvDocGia.TabIndex = 34
        '
        'MadocgiaDataGridViewTextBoxColumn
        '
        Me.MadocgiaDataGridViewTextBoxColumn.DataPropertyName = "madocgia"
        Me.MadocgiaDataGridViewTextBoxColumn.HeaderText = "Mã đọc giả"
        Me.MadocgiaDataGridViewTextBoxColumn.Name = "MadocgiaDataGridViewTextBoxColumn"
        Me.MadocgiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HotenDataGridViewTextBoxColumn
        '
        Me.HotenDataGridViewTextBoxColumn.DataPropertyName = "hoten"
        Me.HotenDataGridViewTextBoxColumn.HeaderText = "Họ tên"
        Me.HotenDataGridViewTextBoxColumn.Name = "HotenDataGridViewTextBoxColumn"
        Me.HotenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoaidocgiaDataGridViewTextBoxColumn
        '
        Me.LoaidocgiaDataGridViewTextBoxColumn.DataPropertyName = "loaidocgia"
        Me.LoaidocgiaDataGridViewTextBoxColumn.HeaderText = "Loại đọc giả"
        Me.LoaidocgiaDataGridViewTextBoxColumn.Name = "LoaidocgiaDataGridViewTextBoxColumn"
        Me.LoaidocgiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NgaysinhDataGridViewTextBoxColumn
        '
        Me.NgaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh"
        Me.NgaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh"
        Me.NgaysinhDataGridViewTextBoxColumn.Name = "NgaysinhDataGridViewTextBoxColumn"
        Me.NgaysinhDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiachiDataGridViewTextBoxColumn
        '
        Me.DiachiDataGridViewTextBoxColumn.DataPropertyName = "diachi"
        Me.DiachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ"
        Me.DiachiDataGridViewTextBoxColumn.Name = "DiachiDataGridViewTextBoxColumn"
        Me.DiachiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NgaylaptheDataGridViewTextBoxColumn
        '
        Me.NgaylaptheDataGridViewTextBoxColumn.DataPropertyName = "ngaylapthe"
        Me.NgaylaptheDataGridViewTextBoxColumn.HeaderText = "Ngày lập thẻ"
        Me.NgaylaptheDataGridViewTextBoxColumn.Name = "NgaylaptheDataGridViewTextBoxColumn"
        Me.NgaylaptheDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblDOCGIABindingSource
        '
        Me.TblDOCGIABindingSource.DataMember = "tblDOCGIA"
        Me.TblDOCGIABindingSource.DataSource = Me.TVDataBsDataSet1
        '
        'TVDataBsDataSet1
        '
        Me.TVDataBsDataSet1.DataSetName = "TVDataBsDataSet1"
        Me.TVDataBsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDOCGIATableAdapter
        '
        Me.TblDOCGIATableAdapter.ClearBeforeFill = True
        '
        'frmLapthe
        '
        Me.AcceptButton = Me.Update_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 554)
        Me.Controls.Add(Me.dgvDocGia)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmLapthe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lập thẻ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDOCGIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDataBsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents dgvDocGia As DataGridView
    Friend WithEvents Delete_button As Button
    Friend WithEvents Update_button As Button
    Friend WithEvents Add_button As Button
    Friend WithEvents TVDataBsDataSet1 As TVDataBsDataSet1
    Friend WithEvents TblDOCGIABindingSource As BindingSource
    Friend WithEvents TblDOCGIATableAdapter As TVDataBsDataSet1TableAdapters.tblDOCGIATableAdapter
    Friend WithEvents MadocgiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HotenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoaidocgiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaysinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiachiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaylaptheDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
