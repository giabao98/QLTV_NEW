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
        Me.tabctrFindReader = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvReaderInfo = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txbFind = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbKind = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgvReaderInfo1 = New System.Windows.Forms.DataGridView()
        Me.label10 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txbCreateDay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbAddress = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.txbKindReaderCode = New System.Windows.Forms.TextBox()
        Me.txbReaderName = New System.Windows.Forms.TextBox()
        Me.mtxbBirthDay = New System.Windows.Forms.MaskedTextBox()
        Me.txbReaderCode = New System.Windows.Forms.TextBox()
        Me.btnClose1 = New System.Windows.Forms.Button()
        Me.btnFind1 = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.tabctrFindReader.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvReaderInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvReaderInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabctrFindReader
        '
        Me.tabctrFindReader.Controls.Add(Me.TabPage1)
        Me.tabctrFindReader.Controls.Add(Me.TabPage2)
        Me.tabctrFindReader.Location = New System.Drawing.Point(0, -3)
        Me.tabctrFindReader.Name = "tabctrFindReader"
        Me.tabctrFindReader.SelectedIndex = 0
        Me.tabctrFindReader.Size = New System.Drawing.Size(964, 654)
        Me.tabctrFindReader.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(956, 625)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tìm kiếm cơ bản"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.dgvReaderInfo)
        Me.GroupBox4.Location = New System.Drawing.Point(-4, 158)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(962, 467)
        Me.GroupBox4.TabIndex = 3
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
        Me.dgvReaderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReaderInfo.Location = New System.Drawing.Point(17, 55)
        Me.dgvReaderInfo.Name = "dgvReaderInfo"
        Me.dgvReaderInfo.RowTemplate.Height = 24
        Me.dgvReaderInfo.Size = New System.Drawing.Size(930, 399)
        Me.dgvReaderInfo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 147)
        Me.GroupBox1.TabIndex = 2
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
        Me.GroupBox2.Controls.Add(Me.cbbKind)
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
        'cbbKind
        '
        Me.cbbKind.FormattingEnabled = True
        Me.cbbKind.Location = New System.Drawing.Point(162, 21)
        Me.cbbKind.Name = "cbbKind"
        Me.cbbKind.Size = New System.Drawing.Size(173, 24)
        Me.cbbKind.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(956, 625)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tìm kiếm nâng cao"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvReaderInfo1)
        Me.GroupBox5.Controls.Add(Me.label10)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 206)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(947, 407)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'dgvReaderInfo1
        '
        Me.dgvReaderInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReaderInfo1.Location = New System.Drawing.Point(7, 58)
        Me.dgvReaderInfo1.Name = "dgvReaderInfo1"
        Me.dgvReaderInfo1.RowTemplate.Height = 24
        Me.dgvReaderInfo1.Size = New System.Drawing.Size(933, 342)
        Me.dgvReaderInfo1.TabIndex = 2
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.DodgerBlue
        Me.label10.Location = New System.Drawing.Point(327, 19)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(283, 36)
        Me.label10.TabIndex = 1
        Me.label10.Text = "Thông Tin Độc Giả"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txbCreateDay)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.txbAddress)
        Me.GroupBox6.Controls.Add(Me.txbEmail)
        Me.GroupBox6.Controls.Add(Me.txbKindReaderCode)
        Me.GroupBox6.Controls.Add(Me.txbReaderName)
        Me.GroupBox6.Controls.Add(Me.mtxbBirthDay)
        Me.GroupBox6.Controls.Add(Me.txbReaderCode)
        Me.GroupBox6.Controls.Add(Me.btnClose1)
        Me.GroupBox6.Controls.Add(Me.btnFind1)
        Me.GroupBox6.Controls.Add(Me.label9)
        Me.GroupBox6.Controls.Add(Me.label8)
        Me.GroupBox6.Controls.Add(Me.label7)
        Me.GroupBox6.Controls.Add(Me.label6)
        Me.GroupBox6.Controls.Add(Me.label5)
        Me.GroupBox6.Controls.Add(Me.label4)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(947, 207)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'txbCreateDay
        '
        Me.txbCreateDay.Location = New System.Drawing.Point(152, 162)
        Me.txbCreateDay.Margin = New System.Windows.Forms.Padding(4)
        Me.txbCreateDay.Name = "txbCreateDay"
        Me.txbCreateDay.Size = New System.Drawing.Size(289, 22)
        Me.txbCreateDay.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Ngày Lập Thẻ:"
        '
        'txbAddress
        '
        Me.txbAddress.Location = New System.Drawing.Point(590, 117)
        Me.txbAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txbAddress.Name = "txbAddress"
        Me.txbAddress.Size = New System.Drawing.Size(311, 22)
        Me.txbAddress.TabIndex = 12
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(590, 70)
        Me.txbEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(311, 22)
        Me.txbEmail.TabIndex = 11
        '
        'txbKindReaderCode
        '
        Me.txbKindReaderCode.Location = New System.Drawing.Point(590, 23)
        Me.txbKindReaderCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txbKindReaderCode.Name = "txbKindReaderCode"
        Me.txbKindReaderCode.Size = New System.Drawing.Size(311, 22)
        Me.txbKindReaderCode.TabIndex = 10
        '
        'txbReaderName
        '
        Me.txbReaderName.Location = New System.Drawing.Point(152, 70)
        Me.txbReaderName.Margin = New System.Windows.Forms.Padding(4)
        Me.txbReaderName.Name = "txbReaderName"
        Me.txbReaderName.Size = New System.Drawing.Size(289, 22)
        Me.txbReaderName.TabIndex = 9
        '
        'mtxbBirthDay
        '
        Me.mtxbBirthDay.Location = New System.Drawing.Point(152, 117)
        Me.mtxbBirthDay.Margin = New System.Windows.Forms.Padding(4)
        Me.mtxbBirthDay.Mask = "00/00/0000"
        Me.mtxbBirthDay.Name = "mtxbBirthDay"
        Me.mtxbBirthDay.Size = New System.Drawing.Size(289, 22)
        Me.mtxbBirthDay.TabIndex = 8
        Me.mtxbBirthDay.ValidatingType = GetType(Date)
        '
        'txbReaderCode
        '
        Me.txbReaderCode.Location = New System.Drawing.Point(152, 23)
        Me.txbReaderCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txbReaderCode.Name = "txbReaderCode"
        Me.txbReaderCode.Size = New System.Drawing.Size(289, 22)
        Me.txbReaderCode.TabIndex = 7
        '
        'btnClose1
        '
        Me.btnClose1.BackColor = System.Drawing.Color.Tomato
        Me.btnClose1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose1.Location = New System.Drawing.Point(801, 151)
        Me.btnClose1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose1.Name = "btnClose1"
        Me.btnClose1.Size = New System.Drawing.Size(100, 47)
        Me.btnClose1.TabIndex = 6
        Me.btnClose1.Text = "Thoát"
        Me.btnClose1.UseVisualStyleBackColor = False
        '
        'btnFind1
        '
        Me.btnFind1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFind1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind1.Location = New System.Drawing.Point(691, 151)
        Me.btnFind1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind1.Name = "btnFind1"
        Me.btnFind1.Size = New System.Drawing.Size(102, 47)
        Me.btnFind1.TabIndex = 5
        Me.btnFind1.Text = "Tìm kiếm"
        Me.btnFind1.UseVisualStyleBackColor = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(520, 123)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(62, 17)
        Me.label9.TabIndex = 4
        Me.label9.Text = "Địa Chỉ:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(532, 75)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(50, 17)
        Me.label8.TabIndex = 3
        Me.label8.Text = "Email:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(488, 28)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(94, 17)
        Me.label7.TabIndex = 3
        Me.label7.Text = "Mã Loại ĐG:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(66, 123)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(78, 17)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Ngày Sinh:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(81, 74)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(63, 17)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Họ Tên:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(53, 28)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(91, 17)
        Me.label4.TabIndex = 0
        Me.label4.Text = "Mã Độc Giả:"
        '
        'frmFindReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 646)
        Me.Controls.Add(Me.tabctrFindReader)
        Me.Name = "frmFindReader"
        Me.Text = "Tìm Đọc Giả"
        Me.tabctrFindReader.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvReaderInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvReaderInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabctrFindReader As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
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
    Friend WithEvents cbbKind As ComboBox
    Private WithEvents GroupBox5 As GroupBox
    Friend WithEvents dgvReaderInfo1 As DataGridView
    Private WithEvents label10 As Label
    Private WithEvents GroupBox6 As GroupBox
    Private WithEvents txbAddress As TextBox
    Private WithEvents txbEmail As TextBox
    Private WithEvents txbKindReaderCode As TextBox
    Private WithEvents txbReaderName As TextBox
    Private WithEvents mtxbBirthDay As MaskedTextBox
    Private WithEvents txbReaderCode As TextBox
    Private WithEvents btnClose1 As Button
    Private WithEvents btnFind1 As Button
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents txbCreateDay As TextBox
    Private WithEvents Label3 As Label
End Class
