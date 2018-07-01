<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindReader
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
        Me.dgvReaderInfo = New System.Windows.Forms.DataGridView()
        Me.MadocgiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaidocgiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaysinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiachiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaylaptheDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblDOCGIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TVDataBsDataSet3 = New QLyGUI.TVDataBsDataSet3()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbFind = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbFindCategory = New System.Windows.Forms.ComboBox()
        Me.TblDOCGIATableAdapter = New QLyGUI.TVDataBsDataSet3TableAdapters.tblDOCGIATableAdapter()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvReaderInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDOCGIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDataBsDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.dgvReaderInfo)
        Me.GroupBox4.Location = New System.Drawing.Point(-3, 166)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(962, 467)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(362, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Thông tin độc giả"
        '
        'dgvReaderInfo
        '
        Me.dgvReaderInfo.AutoGenerateColumns = False
        Me.dgvReaderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReaderInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MadocgiaDataGridViewTextBoxColumn, Me.HotenDataGridViewTextBoxColumn, Me.LoaidocgiaDataGridViewTextBoxColumn, Me.NgaysinhDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DiachiDataGridViewTextBoxColumn, Me.NgaylaptheDataGridViewTextBoxColumn})
        Me.dgvReaderInfo.DataSource = Me.TblDOCGIABindingSource
        Me.dgvReaderInfo.Location = New System.Drawing.Point(17, 55)
        Me.dgvReaderInfo.Name = "dgvReaderInfo"
        Me.dgvReaderInfo.RowTemplate.Height = 24
        Me.dgvReaderInfo.Size = New System.Drawing.Size(930, 399)
        Me.dgvReaderInfo.TabIndex = 0
        '
        'MadocgiaDataGridViewTextBoxColumn
        '
        Me.MadocgiaDataGridViewTextBoxColumn.DataPropertyName = "madocgia"
        Me.MadocgiaDataGridViewTextBoxColumn.HeaderText = "Mã độc giả"
        Me.MadocgiaDataGridViewTextBoxColumn.Name = "MadocgiaDataGridViewTextBoxColumn"
        Me.MadocgiaDataGridViewTextBoxColumn.Width = 120
        '
        'HotenDataGridViewTextBoxColumn
        '
        Me.HotenDataGridViewTextBoxColumn.DataPropertyName = "hoten"
        Me.HotenDataGridViewTextBoxColumn.HeaderText = "Họ tên"
        Me.HotenDataGridViewTextBoxColumn.Name = "HotenDataGridViewTextBoxColumn"
        Me.HotenDataGridViewTextBoxColumn.Width = 150
        '
        'LoaidocgiaDataGridViewTextBoxColumn
        '
        Me.LoaidocgiaDataGridViewTextBoxColumn.DataPropertyName = "loaidocgia"
        Me.LoaidocgiaDataGridViewTextBoxColumn.HeaderText = "Loại độc giả"
        Me.LoaidocgiaDataGridViewTextBoxColumn.Name = "LoaidocgiaDataGridViewTextBoxColumn"
        '
        'NgaysinhDataGridViewTextBoxColumn
        '
        Me.NgaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh"
        Me.NgaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh"
        Me.NgaysinhDataGridViewTextBoxColumn.Name = "NgaysinhDataGridViewTextBoxColumn"
        Me.NgaysinhDataGridViewTextBoxColumn.Width = 120
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'DiachiDataGridViewTextBoxColumn
        '
        Me.DiachiDataGridViewTextBoxColumn.DataPropertyName = "diachi"
        Me.DiachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ"
        Me.DiachiDataGridViewTextBoxColumn.Name = "DiachiDataGridViewTextBoxColumn"
        Me.DiachiDataGridViewTextBoxColumn.Width = 150
        '
        'NgaylaptheDataGridViewTextBoxColumn
        '
        Me.NgaylaptheDataGridViewTextBoxColumn.DataPropertyName = "ngaylapthe"
        Me.NgaylaptheDataGridViewTextBoxColumn.HeaderText = "Ngày lập thẻ"
        Me.NgaylaptheDataGridViewTextBoxColumn.Name = "NgaylaptheDataGridViewTextBoxColumn"
        '
        'TblDOCGIABindingSource
        '
        Me.TblDOCGIABindingSource.DataMember = "tblDOCGIA"
        Me.TblDOCGIABindingSource.DataSource = Me.TVDataBsDataSet3
        '
        'TVDataBsDataSet3
        '
        Me.TVDataBsDataSet3.DataSetName = "TVDataBsDataSet3"
        Me.TVDataBsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 147)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.btnFind)
        Me.GroupBox3.Location = New System.Drawing.Point(668, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 105)
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
        Me.GroupBox2.Size = New System.Drawing.Size(593, 107)
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
        Me.Label1.Location = New System.Drawing.Point(25, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tìm theo:"
        '
        'cbbFindCategory
        '
        Me.cbbFindCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbFindCategory.FormattingEnabled = True
        Me.cbbFindCategory.Items.AddRange(New Object() {"madocgia", "hoten", "loaidocgia", "email", "diachi"})
        Me.cbbFindCategory.Location = New System.Drawing.Point(162, 21)
        Me.cbbFindCategory.Name = "cbbFindCategory"
        Me.cbbFindCategory.Size = New System.Drawing.Size(173, 24)
        Me.cbbFindCategory.TabIndex = 0
        '
        'TblDOCGIATableAdapter
        '
        Me.TblDOCGIATableAdapter.ClearBeforeFill = True
        '
        'frmFindReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 646)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFindReader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tìm Đọc Giả"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvReaderInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDOCGIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDataBsDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvReaderInfo As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txbFind As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbbFindCategory As ComboBox
    Friend WithEvents TVDataBsDataSet3 As TVDataBsDataSet3
    Friend WithEvents TblDOCGIABindingSource As BindingSource
    Friend WithEvents TblDOCGIATableAdapter As TVDataBsDataSet3TableAdapters.tblDOCGIATableAdapter
    Friend WithEvents MadocgiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HotenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoaidocgiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaysinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiachiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaylaptheDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
