<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuyDinhMuonSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuyDinhMuonSach))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Update_button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbTenLoaiDocGia = New System.Windows.Forms.TextBox()
        Me.lbTenLoaiDocGia = New System.Windows.Forms.Label()
        Me.txbMaLoaiDocGia = New System.Windows.Forms.TextBox()
        Me.lbMaLoaiDocGia = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Controls.Add(Me.Update_button)
        Me.GroupBox3.Location = New System.Drawing.Point(406, 94)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(160, 147)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chức năng"
        '
        'Update_button
        '
        Me.Update_button.BackColor = System.Drawing.Color.LightGreen
        Me.Update_button.Image = CType(resources.GetObject("Update_button.Image"), System.Drawing.Image)
        Me.Update_button.Location = New System.Drawing.Point(28, 47)
        Me.Update_button.Margin = New System.Windows.Forms.Padding(4)
        Me.Update_button.Name = "Update_button"
        Me.Update_button.Size = New System.Drawing.Size(111, 37)
        Me.Update_button.TabIndex = 32
        Me.Update_button.Text = "Cập nhật"
        Me.Update_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Update_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Update_button.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.txbTenLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.lbTenLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.txbMaLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.lbMaLoaiDocGia)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 94)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(385, 147)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin chi tiết"
        '
        'txbTenLoaiDocGia
        '
        Me.txbTenLoaiDocGia.Location = New System.Drawing.Point(162, 85)
        Me.txbTenLoaiDocGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txbTenLoaiDocGia.Name = "txbTenLoaiDocGia"
        Me.txbTenLoaiDocGia.Size = New System.Drawing.Size(205, 22)
        Me.txbTenLoaiDocGia.TabIndex = 21
        '
        'lbTenLoaiDocGia
        '
        Me.lbTenLoaiDocGia.AutoSize = True
        Me.lbTenLoaiDocGia.Location = New System.Drawing.Point(8, 90)
        Me.lbTenLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTenLoaiDocGia.Name = "lbTenLoaiDocGia"
        Me.lbTenLoaiDocGia.Size = New System.Drawing.Size(142, 17)
        Me.lbTenLoaiDocGia.TabIndex = 20
        Me.lbTenLoaiDocGia.Text = "Số ngày mượn tối đa:"
        '
        'txbMaLoaiDocGia
        '
        Me.txbMaLoaiDocGia.Location = New System.Drawing.Point(162, 42)
        Me.txbMaLoaiDocGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txbMaLoaiDocGia.Name = "txbMaLoaiDocGia"
        Me.txbMaLoaiDocGia.Size = New System.Drawing.Size(205, 22)
        Me.txbMaLoaiDocGia.TabIndex = 19
        '
        'lbMaLoaiDocGia
        '
        Me.lbMaLoaiDocGia.AutoSize = True
        Me.lbMaLoaiDocGia.Location = New System.Drawing.Point(8, 47)
        Me.lbMaLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaLoaiDocGia.Name = "lbMaLoaiDocGia"
        Me.lbMaLoaiDocGia.Size = New System.Drawing.Size(146, 17)
        Me.lbMaLoaiDocGia.TabIndex = 18
        Me.lbMaLoaiDocGia.Text = "Số lượng mượn tối đa:"
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
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(137, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quy định mượn sách"
        '
        'frmQuyDinhMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 250)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQuyDinhMuonSach"
        Me.Text = "frmQuy"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Update_button As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txbTenLoaiDocGia As TextBox
    Friend WithEvents lbTenLoaiDocGia As Label
    Friend WithEvents txbMaLoaiDocGia As TextBox
    Friend WithEvents lbMaLoaiDocGia As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class
