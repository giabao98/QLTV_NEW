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
        Me.dgvBookReport = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.rbtnBaoCaoTre = New System.Windows.Forms.RadioButton()
        Me.rbtnBaoCaoTheLoai = New System.Windows.Forms.RadioButton()
        Me.lbTongSoLuotMuon = New System.Windows.Forms.Label()
        CType(Me.dgvBookReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBookReport
        '
        Me.dgvBookReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookReport.Location = New System.Drawing.Point(12, 140)
        Me.dgvBookReport.Name = "dgvBookReport"
        Me.dgvBookReport.RowTemplate.Height = 24
        Me.dgvBookReport.Size = New System.Drawing.Size(843, 426)
        Me.dgvBookReport.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReport)
        Me.GroupBox2.Controls.Add(Me.rbtnBaoCaoTre)
        Me.GroupBox2.Controls.Add(Me.rbtnBaoCaoTheLoai)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(844, 88)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(649, 8)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(194, 80)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "Báo Cáo"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'rbtnBaoCaoTre
        '
        Me.rbtnBaoCaoTre.AutoSize = True
        Me.rbtnBaoCaoTre.Location = New System.Drawing.Point(378, 26)
        Me.rbtnBaoCaoTre.Name = "rbtnBaoCaoTre"
        Me.rbtnBaoCaoTre.Size = New System.Drawing.Size(103, 21)
        Me.rbtnBaoCaoTre.TabIndex = 1
        Me.rbtnBaoCaoTre.TabStop = True
        Me.rbtnBaoCaoTre.Text = "Sách trả trễ"
        Me.rbtnBaoCaoTre.UseVisualStyleBackColor = True
        '
        'rbtnBaoCaoTheLoai
        '
        Me.rbtnBaoCaoTheLoai.AutoSize = True
        Me.rbtnBaoCaoTheLoai.Location = New System.Drawing.Point(63, 26)
        Me.rbtnBaoCaoTheLoai.Name = "rbtnBaoCaoTheLoai"
        Me.rbtnBaoCaoTheLoai.Size = New System.Drawing.Size(243, 21)
        Me.rbtnBaoCaoTheLoai.TabIndex = 0
        Me.rbtnBaoCaoTheLoai.TabStop = True
        Me.rbtnBaoCaoTheLoai.Text = "Tình hình mượn sách theo thể loại" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbtnBaoCaoTheLoai.UseVisualStyleBackColor = True
        '
        'lbTongSoLuotMuon
        '
        Me.lbTongSoLuotMuon.AutoSize = True
        Me.lbTongSoLuotMuon.Location = New System.Drawing.Point(12, 103)
        Me.lbTongSoLuotMuon.Name = "lbTongSoLuotMuon"
        Me.lbTongSoLuotMuon.Size = New System.Drawing.Size(0, 17)
        Me.lbTongSoLuotMuon.TabIndex = 6
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 592)
        Me.Controls.Add(Me.lbTongSoLuotMuon)
        Me.Controls.Add(Me.dgvBookReport)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmReport"
        Me.Text = "frmReport"
        CType(Me.dgvBookReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBookReport As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnReport As Button
    Friend WithEvents rbtnBaoCaoTre As RadioButton
    Friend WithEvents rbtnBaoCaoTheLoai As RadioButton
    Friend WithEvents lbTongSoLuotMuon As Label
End Class
