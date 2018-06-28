<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiDocGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoaiDocGia))
        Me.dgvLoaiDocGia = New System.Windows.Forms.DataGridView()
        Me.MaloaidocgiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenloaidocgiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblLOAIDOCGIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TVDataBsDataSet4 = New QLyGUI.TVDataBsDataSet4()
        Me.Delete_button = New System.Windows.Forms.Button()
        Me.Update_button = New System.Windows.Forms.Button()
        Me.Add_button = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbTenLoaiDocGia = New System.Windows.Forms.TextBox()
        Me.lbTenLoaiDocGia = New System.Windows.Forms.Label()
        Me.txbMaLoaiDocGia = New System.Windows.Forms.TextBox()
        Me.lbMaLoaiDocGia = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TblLOAIDOCGIATableAdapter = New QLyGUI.TVDataBsDataSet4TableAdapters.tblLOAIDOCGIATableAdapter()
        CType(Me.dgvLoaiDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLOAIDOCGIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVDataBsDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLoaiDocGia
        '
        Me.dgvLoaiDocGia.AllowUserToAddRows = False
        Me.dgvLoaiDocGia.AllowUserToDeleteRows = False
        Me.dgvLoaiDocGia.AutoGenerateColumns = False
        Me.dgvLoaiDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoaiDocGia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaloaidocgiaDataGridViewTextBoxColumn, Me.TenloaidocgiaDataGridViewTextBoxColumn})
        Me.dgvLoaiDocGia.DataSource = Me.TblLOAIDOCGIABindingSource
        Me.dgvLoaiDocGia.Location = New System.Drawing.Point(15, 223)
        Me.dgvLoaiDocGia.Name = "dgvLoaiDocGia"
        Me.dgvLoaiDocGia.ReadOnly = True
        Me.dgvLoaiDocGia.Size = New System.Drawing.Size(415, 105)
        Me.dgvLoaiDocGia.TabIndex = 38
        '
        'MaloaidocgiaDataGridViewTextBoxColumn
        '
        Me.MaloaidocgiaDataGridViewTextBoxColumn.DataPropertyName = "maloaidocgia"
        Me.MaloaidocgiaDataGridViewTextBoxColumn.HeaderText = "Mã loại đọc giả"
        Me.MaloaidocgiaDataGridViewTextBoxColumn.Name = "MaloaidocgiaDataGridViewTextBoxColumn"
        Me.MaloaidocgiaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaloaidocgiaDataGridViewTextBoxColumn.Width = 120
        '
        'TenloaidocgiaDataGridViewTextBoxColumn
        '
        Me.TenloaidocgiaDataGridViewTextBoxColumn.DataPropertyName = "tenloaidocgia"
        Me.TenloaidocgiaDataGridViewTextBoxColumn.HeaderText = "Tên loại đọc giả"
        Me.TenloaidocgiaDataGridViewTextBoxColumn.Name = "TenloaidocgiaDataGridViewTextBoxColumn"
        Me.TenloaidocgiaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenloaidocgiaDataGridViewTextBoxColumn.Width = 120
        '
        'TblLOAIDOCGIABindingSource
        '
        Me.TblLOAIDOCGIABindingSource.DataMember = "tblLOAIDOCGIA"
        Me.TblLOAIDOCGIABindingSource.DataSource = Me.TVDataBsDataSet4
        '
        'TVDataBsDataSet4
        '
        Me.TVDataBsDataSet4.DataSetName = "TVDataBsDataSet4"
        Me.TVDataBsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Delete_button
        '
        Me.Delete_button.BackColor = System.Drawing.Color.LightCoral
        Me.Delete_button.Image = CType(resources.GetObject("Delete_button.Image"), System.Drawing.Image)
        Me.Delete_button.Location = New System.Drawing.Point(18, 100)
        Me.Delete_button.Name = "Delete_button"
        Me.Delete_button.Size = New System.Drawing.Size(83, 30)
        Me.Delete_button.TabIndex = 33
        Me.Delete_button.Text = "Xóa"
        Me.Delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Delete_button.UseVisualStyleBackColor = False
        '
        'Update_button
        '
        Me.Update_button.BackColor = System.Drawing.Color.LightGreen
        Me.Update_button.Image = CType(resources.GetObject("Update_button.Image"), System.Drawing.Image)
        Me.Update_button.Location = New System.Drawing.Point(18, 64)
        Me.Update_button.Name = "Update_button"
        Me.Update_button.Size = New System.Drawing.Size(83, 30)
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
        Me.Add_button.Location = New System.Drawing.Point(18, 28)
        Me.Add_button.Name = "Add_button"
        Me.Add_button.Size = New System.Drawing.Size(83, 30)
        Me.Add_button.TabIndex = 31
        Me.Add_button.Text = "Thêm"
        Me.Add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Add_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Add_button.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Controls.Add(Me.Delete_button)
        Me.GroupBox3.Controls.Add(Me.Update_button)
        Me.GroupBox3.Controls.Add(Me.Add_button)
        Me.GroupBox3.Location = New System.Drawing.Point(310, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(120, 139)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chức năng"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.txbTenLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.lbTenLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.txbMaLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.lbMaLoaiDocGia)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 139)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin chi tiết"
        '
        'txbTenLoaiDocGia
        '
        Me.txbTenLoaiDocGia.Location = New System.Drawing.Point(102, 70)
        Me.txbTenLoaiDocGia.Name = "txbTenLoaiDocGia"
        Me.txbTenLoaiDocGia.Size = New System.Drawing.Size(155, 20)
        Me.txbTenLoaiDocGia.TabIndex = 21
        '
        'lbTenLoaiDocGia
        '
        Me.lbTenLoaiDocGia.AutoSize = True
        Me.lbTenLoaiDocGia.Location = New System.Drawing.Point(6, 73)
        Me.lbTenLoaiDocGia.Name = "lbTenLoaiDocGia"
        Me.lbTenLoaiDocGia.Size = New System.Drawing.Size(84, 13)
        Me.lbTenLoaiDocGia.TabIndex = 20
        Me.lbTenLoaiDocGia.Text = "Tên loại đọc giả"
        '
        'txbMaLoaiDocGia
        '
        Me.txbMaLoaiDocGia.Location = New System.Drawing.Point(102, 35)
        Me.txbMaLoaiDocGia.Name = "txbMaLoaiDocGia"
        Me.txbMaLoaiDocGia.Size = New System.Drawing.Size(155, 20)
        Me.txbMaLoaiDocGia.TabIndex = 19
        '
        'lbMaLoaiDocGia
        '
        Me.lbMaLoaiDocGia.AutoSize = True
        Me.lbMaLoaiDocGia.Location = New System.Drawing.Point(6, 38)
        Me.lbMaLoaiDocGia.Name = "lbMaLoaiDocGia"
        Me.lbMaLoaiDocGia.Size = New System.Drawing.Size(80, 13)
        Me.lbMaLoaiDocGia.TabIndex = 18
        Me.lbMaLoaiDocGia.Text = "Mã loại độc giả"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(133, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loại đọc giả"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 60)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'TblLOAIDOCGIATableAdapter
        '
        Me.TblLOAIDOCGIATableAdapter.ClearBeforeFill = True
        '
        'frmLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 339)
        Me.Controls.Add(Me.dgvLoaiDocGia)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLoaiDocGia"
        Me.Text = "frmLoaiDocGia"
        CType(Me.dgvLoaiDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLOAIDOCGIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVDataBsDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLoaiDocGia As DataGridView
    Friend WithEvents Delete_button As Button
    Friend WithEvents Update_button As Button
    Friend WithEvents Add_button As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbMaLoaiDocGia As Label
    Friend WithEvents TVDataBsDataSet4 As TVDataBsDataSet4
    Friend WithEvents TblLOAIDOCGIABindingSource As BindingSource
    Friend WithEvents TblLOAIDOCGIATableAdapter As TVDataBsDataSet4TableAdapters.tblLOAIDOCGIATableAdapter
    Friend WithEvents txbMaLoaiDocGia As TextBox
    Friend WithEvents txbTenLoaiDocGia As TextBox
    Friend WithEvents lbTenLoaiDocGia As Label
    Friend WithEvents MaloaidocgiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenloaidocgiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
