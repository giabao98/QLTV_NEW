<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoiMatKhau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDoiMatKhau))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbHanSuDung = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbTuoiToiDa = New System.Windows.Forms.TextBox()
        Me.lbTenLoaiDocGia = New System.Windows.Forms.Label()
        Me.txbTuoiToiThieu = New System.Windows.Forms.TextBox()
        Me.lbMaLoaiDocGia = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Location = New System.Drawing.Point(406, 94)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(160, 183)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chức năng"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.txbHanSuDung)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txbTuoiToiDa)
        Me.GroupBox2.Controls.Add(Me.lbTenLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.txbTuoiToiThieu)
        Me.GroupBox2.Controls.Add(Me.lbMaLoaiDocGia)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 94)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(385, 183)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin chi tiết"
        '
        'txbHanSuDung
        '
        Me.txbHanSuDung.Location = New System.Drawing.Point(160, 130)
        Me.txbHanSuDung.Margin = New System.Windows.Forms.Padding(4)
        Me.txbHanSuDung.Name = "txbHanSuDung"
        Me.txbHanSuDung.Size = New System.Drawing.Size(205, 22)
        Me.txbHanSuDung.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nhập lại mật khẩu mới:"
        '
        'txbTuoiToiDa
        '
        Me.txbTuoiToiDa.Location = New System.Drawing.Point(160, 87)
        Me.txbTuoiToiDa.Margin = New System.Windows.Forms.Padding(4)
        Me.txbTuoiToiDa.Name = "txbTuoiToiDa"
        Me.txbTuoiToiDa.Size = New System.Drawing.Size(205, 22)
        Me.txbTuoiToiDa.TabIndex = 21
        '
        'lbTenLoaiDocGia
        '
        Me.lbTenLoaiDocGia.AutoSize = True
        Me.lbTenLoaiDocGia.Location = New System.Drawing.Point(8, 90)
        Me.lbTenLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTenLoaiDocGia.Name = "lbTenLoaiDocGia"
        Me.lbTenLoaiDocGia.Size = New System.Drawing.Size(98, 17)
        Me.lbTenLoaiDocGia.TabIndex = 20
        Me.lbTenLoaiDocGia.Text = "Mật Khẩu mới:"
        '
        'txbTuoiToiThieu
        '
        Me.txbTuoiToiThieu.Location = New System.Drawing.Point(160, 44)
        Me.txbTuoiToiThieu.Margin = New System.Windows.Forms.Padding(4)
        Me.txbTuoiToiThieu.Name = "txbTuoiToiThieu"
        Me.txbTuoiToiThieu.Size = New System.Drawing.Size(205, 22)
        Me.txbTuoiToiThieu.TabIndex = 19
        '
        'lbMaLoaiDocGia
        '
        Me.lbMaLoaiDocGia.AutoSize = True
        Me.lbMaLoaiDocGia.Location = New System.Drawing.Point(8, 47)
        Me.lbMaLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaLoaiDocGia.Name = "lbMaLoaiDocGia"
        Me.lbMaLoaiDocGia.Size = New System.Drawing.Size(120, 17)
        Me.lbMaLoaiDocGia.TabIndex = 18
        Me.lbMaLoaiDocGia.Text = "Mật khẩu hiện tại:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(553, 74)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(175, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đổi mật khẩu"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightGreen
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(25, 73)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 37)
        Me.btnUpdate.TabIndex = 33
        Me.btnUpdate.Text = "Cập nhật"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'frmDoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 289)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDoiMatKhau"
        Me.Text = "frmDoiMatKhau"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txbHanSuDung As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbTuoiToiDa As TextBox
    Friend WithEvents lbTenLoaiDocGia As Label
    Friend WithEvents txbTuoiToiThieu As TextBox
    Friend WithEvents lbMaLoaiDocGia As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
End Class
