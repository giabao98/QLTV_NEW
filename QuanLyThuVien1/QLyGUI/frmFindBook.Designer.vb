<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindBook
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvBookInfo = New System.Windows.Forms.DataGridView()
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
        Me.TVDataBsDataSet = New QLyGUI.TVDataBsDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbFind = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbFindCategory = New System.Windows.Forms.ComboBox()
        Me.TblSACHTableAdapter = New QLyGUI.TVDataBsDataSetTableAdapters.tblSACHTableAdapter()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvBookInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSACHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDataBsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.dgvBookInfo)
        Me.GroupBox4.Location = New System.Drawing.Point(-5, 217)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(969, 474)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(359, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Thông tin sách"
        '
        'dgvBookInfo
        '
        Me.dgvBookInfo.AutoGenerateColumns = False
        Me.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MasachDataGridViewTextBoxColumn, Me.TensachDataGridViewTextBoxColumn, Me.MatheloaiDataGridViewTextBoxColumn, Me.MatacgiaDataGridViewTextBoxColumn, Me.NamxuatbanDataGridViewTextBoxColumn, Me.ManhaxuatbanDataGridViewTextBoxColumn, Me.NgaynhapDataGridViewTextBoxColumn, Me.TrigiaDataGridViewTextBoxColumn, Me.MatinhtrangDataGridViewTextBoxColumn, Me.SoluongDataGridViewTextBoxColumn})
        Me.dgvBookInfo.DataSource = Me.TblSACHBindingSource
        Me.dgvBookInfo.Location = New System.Drawing.Point(17, 55)
        Me.dgvBookInfo.Name = "dgvBookInfo"
        Me.dgvBookInfo.RowTemplate.Height = 24
        Me.dgvBookInfo.Size = New System.Drawing.Size(930, 407)
        Me.dgvBookInfo.TabIndex = 0
        '
        'MasachDataGridViewTextBoxColumn
        '
        Me.MasachDataGridViewTextBoxColumn.DataPropertyName = "masach"
        Me.MasachDataGridViewTextBoxColumn.HeaderText = "Mã sách"
        Me.MasachDataGridViewTextBoxColumn.Name = "MasachDataGridViewTextBoxColumn"
        Me.MasachDataGridViewTextBoxColumn.Width = 90
        '
        'TensachDataGridViewTextBoxColumn
        '
        Me.TensachDataGridViewTextBoxColumn.DataPropertyName = "tensach"
        Me.TensachDataGridViewTextBoxColumn.HeaderText = "Tên sách"
        Me.TensachDataGridViewTextBoxColumn.Name = "TensachDataGridViewTextBoxColumn"
        '
        'MatheloaiDataGridViewTextBoxColumn
        '
        Me.MatheloaiDataGridViewTextBoxColumn.DataPropertyName = "matheloai"
        Me.MatheloaiDataGridViewTextBoxColumn.HeaderText = "Mã thể loại"
        Me.MatheloaiDataGridViewTextBoxColumn.Name = "MatheloaiDataGridViewTextBoxColumn"
        '
        'MatacgiaDataGridViewTextBoxColumn
        '
        Me.MatacgiaDataGridViewTextBoxColumn.DataPropertyName = "matacgia"
        Me.MatacgiaDataGridViewTextBoxColumn.HeaderText = "Mã tác giả"
        Me.MatacgiaDataGridViewTextBoxColumn.Name = "MatacgiaDataGridViewTextBoxColumn"
        '
        'NamxuatbanDataGridViewTextBoxColumn
        '
        Me.NamxuatbanDataGridViewTextBoxColumn.DataPropertyName = "namxuatban"
        Me.NamxuatbanDataGridViewTextBoxColumn.HeaderText = "Năm xuất bản"
        Me.NamxuatbanDataGridViewTextBoxColumn.Name = "NamxuatbanDataGridViewTextBoxColumn"
        '
        'ManhaxuatbanDataGridViewTextBoxColumn
        '
        Me.ManhaxuatbanDataGridViewTextBoxColumn.DataPropertyName = "manhaxuatban"
        Me.ManhaxuatbanDataGridViewTextBoxColumn.HeaderText = "Mã nhà xuất bản"
        Me.ManhaxuatbanDataGridViewTextBoxColumn.Name = "ManhaxuatbanDataGridViewTextBoxColumn"
        '
        'NgaynhapDataGridViewTextBoxColumn
        '
        Me.NgaynhapDataGridViewTextBoxColumn.DataPropertyName = "ngaynhap"
        Me.NgaynhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập"
        Me.NgaynhapDataGridViewTextBoxColumn.Name = "NgaynhapDataGridViewTextBoxColumn"
        '
        'TrigiaDataGridViewTextBoxColumn
        '
        Me.TrigiaDataGridViewTextBoxColumn.DataPropertyName = "trigia"
        Me.TrigiaDataGridViewTextBoxColumn.HeaderText = "Trị giá"
        Me.TrigiaDataGridViewTextBoxColumn.Name = "TrigiaDataGridViewTextBoxColumn"
        '
        'MatinhtrangDataGridViewTextBoxColumn
        '
        Me.MatinhtrangDataGridViewTextBoxColumn.DataPropertyName = "matinhtrang"
        Me.MatinhtrangDataGridViewTextBoxColumn.HeaderText = "Mã tình trạng"
        Me.MatinhtrangDataGridViewTextBoxColumn.Name = "MatinhtrangDataGridViewTextBoxColumn"
        '
        'SoluongDataGridViewTextBoxColumn
        '
        Me.SoluongDataGridViewTextBoxColumn.DataPropertyName = "soluong"
        Me.SoluongDataGridViewTextBoxColumn.HeaderText = "Số lượng"
        Me.SoluongDataGridViewTextBoxColumn.Name = "SoluongDataGridViewTextBoxColumn"
        '
        'TblSACHBindingSource
        '
        Me.TblSACHBindingSource.DataMember = "tblSACH"
        Me.TblSACHBindingSource.DataSource = Me.TVDataBsDataSet
        '
        'TVDataBsDataSet
        '
        Me.TVDataBsDataSet.DataSetName = "TVDataBsDataSet"
        Me.TVDataBsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(-5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(969, 208)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.btnFind)
        Me.GroupBox3.Location = New System.Drawing.Point(668, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 166)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Tomato
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(158, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 70)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Đóng"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(24, 21)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(102, 69)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "Tìm kiếm"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txbFind)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbbFindCategory)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 167)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'txbFind
        '
        Me.txbFind.Location = New System.Drawing.Point(162, 61)
        Me.txbFind.Name = "txbFind"
        Me.txbFind.Size = New System.Drawing.Size(342, 22)
        Me.txbFind.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tìm theo:"
        '
        'cbbFindCategory
        '
        Me.cbbFindCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbFindCategory.FormattingEnabled = True
        Me.cbbFindCategory.Items.AddRange(New Object() {"masach", "tensach", "matheloai", "matacgia", "trigia", "matinhtrang", "soluong"})
        Me.cbbFindCategory.Location = New System.Drawing.Point(162, 21)
        Me.cbbFindCategory.Name = "cbbFindCategory"
        Me.cbbFindCategory.Size = New System.Drawing.Size(173, 24)
        Me.cbbFindCategory.TabIndex = 0
        '
        'TblSACHTableAdapter
        '
        Me.TblSACHTableAdapter.ClearBeforeFill = True
        '
        'frmFindBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 691)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFindBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tìm Sách"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvBookInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSACHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDataBsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvBookInfo As DataGridView
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
    Friend WithEvents TblSACHBindingSource As BindingSource
    Friend WithEvents TVDataBsDataSet As TVDataBsDataSet
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txbFind As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbbFindCategory As ComboBox
    Friend WithEvents TblSACHTableAdapter As TVDataBsDataSetTableAdapters.tblSACHTableAdapter
End Class
