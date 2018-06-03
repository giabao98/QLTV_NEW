<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapthe
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
        Me.btLapthe = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
        '
        'btLapthe
        '
        Me.btLapthe.Location = New System.Drawing.Point(133, 401)
        Me.btLapthe.Name = "btLapthe"
        Me.btLapthe.Size = New System.Drawing.Size(75, 23)
        Me.btLapthe.TabIndex = 30
        Me.btLapthe.Text = "Lập thẻ"
        Me.btLapthe.UseVisualStyleBackColor = True
        '
        'dtpNgayLapThe
        '
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(95, 353)
        Me.dtpNgayLapThe.Name = "dtpNgayLapThe"
        Me.dtpNgayLapThe.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayLapThe.TabIndex = 29
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Location = New System.Drawing.Point(95, 305)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgaySinh.TabIndex = 28
        '
        'cbLoaiDocGia
        '
        Me.cbLoaiDocGia.FormattingEnabled = True
        Me.cbLoaiDocGia.Location = New System.Drawing.Point(95, 255)
        Me.cbLoaiDocGia.Name = "cbLoaiDocGia"
        Me.cbLoaiDocGia.Size = New System.Drawing.Size(200, 21)
        Me.cbLoaiDocGia.TabIndex = 27
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(95, 206)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(200, 20)
        Me.txbEmail.TabIndex = 26
        '
        'txbDiaChi
        '
        Me.txbDiaChi.Location = New System.Drawing.Point(95, 158)
        Me.txbDiaChi.Name = "txbDiaChi"
        Me.txbDiaChi.Size = New System.Drawing.Size(200, 20)
        Me.txbDiaChi.TabIndex = 25
        '
        'txbTenDocGia
        '
        Me.txbTenDocGia.Location = New System.Drawing.Point(95, 115)
        Me.txbTenDocGia.Name = "txbTenDocGia"
        Me.txbTenDocGia.Size = New System.Drawing.Size(200, 20)
        Me.txbTenDocGia.TabIndex = 24
        '
        'txbMaDocGia
        '
        Me.txbMaDocGia.Location = New System.Drawing.Point(95, 64)
        Me.txbMaDocGia.Name = "txbMaDocGia"
        Me.txbMaDocGia.Size = New System.Drawing.Size(200, 20)
        Me.txbMaDocGia.TabIndex = 23
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Location = New System.Drawing.Point(12, 161)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(40, 13)
        Me.lbDiaChi.TabIndex = 22
        Me.lbDiaChi.Text = "Địa chỉ"
        '
        'lbNgayLapThe
        '
        Me.lbNgayLapThe.AutoSize = True
        Me.lbNgayLapThe.Location = New System.Drawing.Point(12, 359)
        Me.lbNgayLapThe.Name = "lbNgayLapThe"
        Me.lbNgayLapThe.Size = New System.Drawing.Size(67, 13)
        Me.lbNgayLapThe.TabIndex = 21
        Me.lbNgayLapThe.Text = "Ngày lập thẻ"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(12, 209)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(32, 13)
        Me.lbEmail.TabIndex = 20
        Me.lbEmail.Text = "Email"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(12, 311)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(54, 13)
        Me.lbNgaySinh.TabIndex = 19
        Me.lbNgaySinh.Text = "Ngày sinh"
        '
        'lbLoaiDocGia
        '
        Me.lbLoaiDocGia.AutoSize = True
        Me.lbLoaiDocGia.Location = New System.Drawing.Point(12, 258)
        Me.lbLoaiDocGia.Name = "lbLoaiDocGia"
        Me.lbLoaiDocGia.Size = New System.Drawing.Size(66, 13)
        Me.lbLoaiDocGia.TabIndex = 18
        Me.lbLoaiDocGia.Text = "Loại độc giả"
        '
        'lbTenDocGia
        '
        Me.lbTenDocGia.AutoSize = True
        Me.lbTenDocGia.Location = New System.Drawing.Point(12, 115)
        Me.lbTenDocGia.Name = "lbTenDocGia"
        Me.lbTenDocGia.Size = New System.Drawing.Size(65, 13)
        Me.lbTenDocGia.TabIndex = 17
        Me.lbTenDocGia.Text = "Tên độc giả"
        '
        'lbMaDocGia
        '
        Me.lbMaDocGia.AutoSize = True
        Me.lbMaDocGia.Location = New System.Drawing.Point(12, 66)
        Me.lbMaDocGia.Name = "lbMaDocGia"
        Me.lbMaDocGia.Size = New System.Drawing.Size(61, 13)
        Me.lbMaDocGia.TabIndex = 16
        Me.lbMaDocGia.Text = "Mã độc giả"
        '
        'frmLapthe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 450)
        Me.Controls.Add(Me.btLapthe)
        Me.Controls.Add(Me.dtpNgayLapThe)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.cbLoaiDocGia)
        Me.Controls.Add(Me.txbEmail)
        Me.Controls.Add(Me.txbDiaChi)
        Me.Controls.Add(Me.txbTenDocGia)
        Me.Controls.Add(Me.txbMaDocGia)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.lbNgayLapThe)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.lbLoaiDocGia)
        Me.Controls.Add(Me.lbTenDocGia)
        Me.Controls.Add(Me.lbMaDocGia)
        Me.Name = "frmLapthe"
        Me.Text = "frmLapthe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btLapthe As Button
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
End Class
