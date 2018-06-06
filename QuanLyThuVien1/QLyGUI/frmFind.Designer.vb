<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Me.txbFindTenMaSach = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.rbtnMaSach = New System.Windows.Forms.RadioButton()
        Me.rbtnTenSach = New System.Windows.Forms.RadioButton()
        Me.txbFindTenTacGia = New System.Windows.Forms.TextBox()
        Me.txbFindTheLoai = New System.Windows.Forms.TextBox()
        Me.txbFindMaTacGia = New System.Windows.Forms.TextBox()
        Me.txbFindTinhTrang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbFindTenMaSach
        '
        Me.txbFindTenMaSach.Location = New System.Drawing.Point(93, 26)
        Me.txbFindTenMaSach.Multiline = True
        Me.txbFindTenMaSach.Name = "txbFindTenMaSach"
        Me.txbFindTenMaSach.Size = New System.Drawing.Size(412, 39)
        Me.txbFindTenMaSach.TabIndex = 0
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(229, 258)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(142, 59)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "Tìm kiếm "
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'rbtnMaSach
        '
        Me.rbtnMaSach.AutoSize = True
        Me.rbtnMaSach.Location = New System.Drawing.Point(528, 44)
        Me.rbtnMaSach.Name = "rbtnMaSach"
        Me.rbtnMaSach.Size = New System.Drawing.Size(82, 21)
        Me.rbtnMaSach.TabIndex = 2
        Me.rbtnMaSach.TabStop = True
        Me.rbtnMaSach.Text = "Mã sách"
        Me.rbtnMaSach.UseVisualStyleBackColor = True
        '
        'rbtnTenSach
        '
        Me.rbtnTenSach.AutoSize = True
        Me.rbtnTenSach.Location = New System.Drawing.Point(630, 44)
        Me.rbtnTenSach.Name = "rbtnTenSach"
        Me.rbtnTenSach.Size = New System.Drawing.Size(88, 21)
        Me.rbtnTenSach.TabIndex = 3
        Me.rbtnTenSach.TabStop = True
        Me.rbtnTenSach.Text = "Tên sách"
        Me.rbtnTenSach.UseVisualStyleBackColor = True
        '
        'txbFindTenTacGia
        '
        Me.txbFindTenTacGia.Location = New System.Drawing.Point(93, 89)
        Me.txbFindTenTacGia.Multiline = True
        Me.txbFindTenTacGia.Name = "txbFindTenTacGia"
        Me.txbFindTenTacGia.Size = New System.Drawing.Size(278, 39)
        Me.txbFindTenTacGia.TabIndex = 6
        '
        'txbFindTheLoai
        '
        Me.txbFindTheLoai.Location = New System.Drawing.Point(93, 190)
        Me.txbFindTheLoai.Multiline = True
        Me.txbFindTheLoai.Name = "txbFindTheLoai"
        Me.txbFindTheLoai.Size = New System.Drawing.Size(278, 39)
        Me.txbFindTheLoai.TabIndex = 7
        '
        'txbFindMaTacGia
        '
        Me.txbFindMaTacGia.Location = New System.Drawing.Point(504, 89)
        Me.txbFindMaTacGia.Multiline = True
        Me.txbFindMaTacGia.Name = "txbFindMaTacGia"
        Me.txbFindMaTacGia.Size = New System.Drawing.Size(278, 39)
        Me.txbFindMaTacGia.TabIndex = 8
        '
        'txbFindTinhTrang
        '
        Me.txbFindTinhTrang.Location = New System.Drawing.Point(504, 190)
        Me.txbFindTinhTrang.Multiline = True
        Me.txbFindTinhTrang.Name = "txbFindTinhTrang"
        Me.txbFindTinhTrang.Size = New System.Drawing.Size(278, 39)
        Me.txbFindTinhTrang.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Label3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(436, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(436, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Label6"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(640, 258)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(142, 59)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Kết thúc"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 332)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(761, 227)
        Me.DataGridView1.TabIndex = 16
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 580)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbFindTinhTrang)
        Me.Controls.Add(Me.txbFindMaTacGia)
        Me.Controls.Add(Me.txbFindTheLoai)
        Me.Controls.Add(Me.txbFindTenTacGia)
        Me.Controls.Add(Me.rbtnTenSach)
        Me.Controls.Add(Me.rbtnMaSach)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txbFindTenMaSach)
        Me.Name = "frmFind"
        Me.Text = "frmFind"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbFindTenMaSach As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents rbtnMaSach As RadioButton
    Friend WithEvents rbtnTenSach As RadioButton
    Friend WithEvents txbFindTenTacGia As TextBox
    Friend WithEvents txbFindTheLoai As TextBox
    Friend WithEvents txbFindMaTacGia As TextBox
    Friend WithEvents txbFindTinhTrang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
