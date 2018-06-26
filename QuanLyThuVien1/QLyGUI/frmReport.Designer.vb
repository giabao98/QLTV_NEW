<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabReportReader = New System.Windows.Forms.TabPage()
        Me.tabReportBook = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvReaderReport = New System.Windows.Forms.DataGridView()
        Me.rbtnSoLanDGMuonSach = New System.Windows.Forms.RadioButton()
        Me.rbtnDGKhongMuonSach = New System.Windows.Forms.RadioButton()
        Me.rbtnDGMuonSachQuaHan = New System.Windows.Forms.RadioButton()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.dgvBookReport = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReport1 = New System.Windows.Forms.Button()
        Me.rbtnSachChuaDuocMuon = New System.Windows.Forms.RadioButton()
        Me.rbtnSoLanSachMuon = New System.Windows.Forms.RadioButton()
        Me.rbtnSachHong = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tabReportReader.SuspendLayout()
        Me.tabReportBook.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvReaderReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBookReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabReportReader)
        Me.TabControl1.Controls.Add(Me.tabReportBook)
        Me.TabControl1.Location = New System.Drawing.Point(-2, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(872, 596)
        Me.TabControl1.TabIndex = 0
        '
        'tabReportReader
        '
        Me.tabReportReader.Controls.Add(Me.dgvReaderReport)
        Me.tabReportReader.Controls.Add(Me.GroupBox1)
        Me.tabReportReader.Location = New System.Drawing.Point(4, 25)
        Me.tabReportReader.Name = "tabReportReader"
        Me.tabReportReader.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReportReader.Size = New System.Drawing.Size(864, 567)
        Me.tabReportReader.TabIndex = 0
        Me.tabReportReader.Text = "Độc Giả"
        Me.tabReportReader.UseVisualStyleBackColor = True
        '
        'tabReportBook
        '
        Me.tabReportBook.Controls.Add(Me.dgvBookReport)
        Me.tabReportBook.Controls.Add(Me.GroupBox2)
        Me.tabReportBook.Location = New System.Drawing.Point(4, 25)
        Me.tabReportBook.Name = "tabReportBook"
        Me.tabReportBook.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReportBook.Size = New System.Drawing.Size(864, 567)
        Me.tabReportBook.TabIndex = 1
        Me.tabReportBook.Text = "Tình trạng sách"
        Me.tabReportBook.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReport)
        Me.GroupBox1.Controls.Add(Me.rbtnDGMuonSachQuaHan)
        Me.GroupBox1.Controls.Add(Me.rbtnDGKhongMuonSach)
        Me.GroupBox1.Controls.Add(Me.rbtnSoLanDGMuonSach)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dgvReaderReport
        '
        Me.dgvReaderReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReaderReport.Location = New System.Drawing.Point(10, 130)
        Me.dgvReaderReport.Name = "dgvReaderReport"
        Me.dgvReaderReport.RowTemplate.Height = 24
        Me.dgvReaderReport.Size = New System.Drawing.Size(843, 427)
        Me.dgvReaderReport.TabIndex = 1
        '
        'rbtnSoLanDGMuonSach
        '
        Me.rbtnSoLanDGMuonSach.AutoSize = True
        Me.rbtnSoLanDGMuonSach.Location = New System.Drawing.Point(6, 46)
        Me.rbtnSoLanDGMuonSach.Name = "rbtnSoLanDGMuonSach"
        Me.rbtnSoLanDGMuonSach.Size = New System.Drawing.Size(211, 21)
        Me.rbtnSoLanDGMuonSach.TabIndex = 0
        Me.rbtnSoLanDGMuonSach.TabStop = True
        Me.rbtnSoLanDGMuonSach.Text = "Số lần mượn của các độc giả"
        Me.rbtnSoLanDGMuonSach.UseVisualStyleBackColor = True
        '
        'rbtnDGKhongMuonSach
        '
        Me.rbtnDGKhongMuonSach.AutoSize = True
        Me.rbtnDGKhongMuonSach.Location = New System.Drawing.Point(231, 46)
        Me.rbtnDGKhongMuonSach.Name = "rbtnDGKhongMuonSach"
        Me.rbtnDGKhongMuonSach.Size = New System.Drawing.Size(193, 21)
        Me.rbtnDGKhongMuonSach.TabIndex = 1
        Me.rbtnDGKhongMuonSach.TabStop = True
        Me.rbtnDGKhongMuonSach.Text = "Độc giả không mượn sách"
        Me.rbtnDGKhongMuonSach.UseVisualStyleBackColor = True
        '
        'rbtnDGMuonSachQuaHan
        '
        Me.rbtnDGMuonSachQuaHan.AutoSize = True
        Me.rbtnDGMuonSachQuaHan.Location = New System.Drawing.Point(438, 46)
        Me.rbtnDGMuonSachQuaHan.Name = "rbtnDGMuonSachQuaHan"
        Me.rbtnDGMuonSachQuaHan.Size = New System.Drawing.Size(206, 21)
        Me.rbtnDGMuonSachQuaHan.TabIndex = 2
        Me.rbtnDGMuonSachQuaHan.TabStop = True
        Me.rbtnDGMuonSachQuaHan.Text = "Độc giả mượn sách quá hạn"
        Me.rbtnDGMuonSachQuaHan.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(649, 8)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(194, 110)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "Báo Cáo"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'dgvBookReport
        '
        Me.dgvBookReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookReport.Location = New System.Drawing.Point(10, 130)
        Me.dgvBookReport.Name = "dgvBookReport"
        Me.dgvBookReport.RowTemplate.Height = 24
        Me.dgvBookReport.Size = New System.Drawing.Size(843, 427)
        Me.dgvBookReport.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReport1)
        Me.GroupBox2.Controls.Add(Me.rbtnSachChuaDuocMuon)
        Me.GroupBox2.Controls.Add(Me.rbtnSoLanSachMuon)
        Me.GroupBox2.Controls.Add(Me.rbtnSachHong)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(844, 118)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btnReport1
        '
        Me.btnReport1.Location = New System.Drawing.Point(649, 8)
        Me.btnReport1.Name = "btnReport1"
        Me.btnReport1.Size = New System.Drawing.Size(194, 110)
        Me.btnReport1.TabIndex = 3
        Me.btnReport1.Text = "Báo Cáo"
        Me.btnReport1.UseVisualStyleBackColor = True
        '
        'rbtnSachChuaDuocMuon
        '
        Me.rbtnSachChuaDuocMuon.AutoSize = True
        Me.rbtnSachChuaDuocMuon.Location = New System.Drawing.Point(397, 46)
        Me.rbtnSachChuaDuocMuon.Name = "rbtnSachChuaDuocMuon"
        Me.rbtnSachChuaDuocMuon.Size = New System.Drawing.Size(221, 21)
        Me.rbtnSachChuaDuocMuon.TabIndex = 2
        Me.rbtnSachChuaDuocMuon.TabStop = True
        Me.rbtnSachChuaDuocMuon.Text = "Sách chưa được mượn lần nào"
        Me.rbtnSachChuaDuocMuon.UseVisualStyleBackColor = True
        '
        'rbtnSoLanSachMuon
        '
        Me.rbtnSoLanSachMuon.AutoSize = True
        Me.rbtnSoLanSachMuon.Location = New System.Drawing.Point(197, 46)
        Me.rbtnSoLanSachMuon.Name = "rbtnSoLanSachMuon"
        Me.rbtnSoLanSachMuon.Size = New System.Drawing.Size(177, 21)
        Me.rbtnSoLanSachMuon.TabIndex = 1
        Me.rbtnSoLanSachMuon.TabStop = True
        Me.rbtnSoLanSachMuon.Text = "Số lần sách được mượn"
        Me.rbtnSoLanSachMuon.UseVisualStyleBackColor = True
        '
        'rbtnSachHong
        '
        Me.rbtnSachHong.AutoSize = True
        Me.rbtnSachHong.Location = New System.Drawing.Point(15, 46)
        Me.rbtnSachHong.Name = "rbtnSachHong"
        Me.rbtnSachHong.Size = New System.Drawing.Size(159, 21)
        Me.rbtnSachHong.TabIndex = 0
        Me.rbtnSachHong.TabStop = True
        Me.rbtnSachHong.Text = "Thông tin sách hỏng"
        Me.rbtnSachHong.UseVisualStyleBackColor = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 592)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmReport"
        Me.Text = "frmReport"
        Me.TabControl1.ResumeLayout(False)
        Me.tabReportReader.ResumeLayout(False)
        Me.tabReportBook.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvReaderReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBookReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabReportReader As TabPage
    Friend WithEvents dgvReaderReport As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReport As Button
    Friend WithEvents rbtnDGMuonSachQuaHan As RadioButton
    Friend WithEvents rbtnDGKhongMuonSach As RadioButton
    Friend WithEvents rbtnSoLanDGMuonSach As RadioButton
    Friend WithEvents tabReportBook As TabPage
    Friend WithEvents dgvBookReport As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnReport1 As Button
    Friend WithEvents rbtnSachChuaDuocMuon As RadioButton
    Friend WithEvents rbtnSoLanSachMuon As RadioButton
    Friend WithEvents rbtnSachHong As RadioButton
End Class
