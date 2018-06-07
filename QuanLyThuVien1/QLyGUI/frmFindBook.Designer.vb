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
        Me.tabctrFindBook = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvBookInfo = New System.Windows.Forms.DataGridView()
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
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.label10 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txbAuthorCode = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txbProducer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbAmount = New System.Windows.Forms.TextBox()
        Me.txbPublishingYear = New System.Windows.Forms.TextBox()
        Me.txbKindCode = New System.Windows.Forms.TextBox()
        Me.txbBookName = New System.Windows.Forms.TextBox()
        Me.mtxbInputDay = New System.Windows.Forms.MaskedTextBox()
        Me.txbBookCode = New System.Windows.Forms.TextBox()
        Me.btnClose1 = New System.Windows.Forms.Button()
        Me.btnFind1 = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.tabctrFindBook.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvBookInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabctrFindBook
        '
        Me.tabctrFindBook.Controls.Add(Me.TabPage1)
        Me.tabctrFindBook.Controls.Add(Me.TabPage2)
        Me.tabctrFindBook.Location = New System.Drawing.Point(-2, -1)
        Me.tabctrFindBook.Name = "tabctrFindBook"
        Me.tabctrFindBook.SelectedIndex = 0
        Me.tabctrFindBook.Size = New System.Drawing.Size(966, 694)
        Me.tabctrFindBook.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(958, 665)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tìm kiếm cơ bản"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.dgvBookInfo)
        Me.GroupBox4.Location = New System.Drawing.Point(-4, 156)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(961, 509)
        Me.GroupBox4.TabIndex = 1
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
        Me.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookInfo.Location = New System.Drawing.Point(17, 55)
        Me.dgvBookInfo.Name = "dgvBookInfo"
        Me.dgvBookInfo.RowTemplate.Height = 24
        Me.dgvBookInfo.Size = New System.Drawing.Size(930, 444)
        Me.dgvBookInfo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(955, 147)
        Me.GroupBox1.TabIndex = 0
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
        Me.Label1.Location = New System.Drawing.Point(36, 18)
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
        Me.TabPage2.Size = New System.Drawing.Size(958, 665)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tìm kiếm nâng cao"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvBook)
        Me.GroupBox5.Controls.Add(Me.label10)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 240)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(947, 425)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'dgvBook
        '
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Location = New System.Drawing.Point(7, 58)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.RowTemplate.Height = 24
        Me.dgvBook.Size = New System.Drawing.Size(933, 364)
        Me.dgvBook.TabIndex = 2
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.DodgerBlue
        Me.label10.Location = New System.Drawing.Point(351, 19)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(241, 36)
        Me.label10.TabIndex = 1
        Me.label10.Text = "Thông Tin Sách"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txbAuthorCode)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.txbProducer)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.txbAmount)
        Me.GroupBox6.Controls.Add(Me.txbPublishingYear)
        Me.GroupBox6.Controls.Add(Me.txbKindCode)
        Me.GroupBox6.Controls.Add(Me.txbBookName)
        Me.GroupBox6.Controls.Add(Me.mtxbInputDay)
        Me.GroupBox6.Controls.Add(Me.txbBookCode)
        Me.GroupBox6.Controls.Add(Me.btnClose1)
        Me.GroupBox6.Controls.Add(Me.btnFind1)
        Me.GroupBox6.Controls.Add(Me.label9)
        Me.GroupBox6.Controls.Add(Me.label8)
        Me.GroupBox6.Controls.Add(Me.label7)
        Me.GroupBox6.Controls.Add(Me.label6)
        Me.GroupBox6.Controls.Add(Me.label5)
        Me.GroupBox6.Controls.Add(Me.label4)
        Me.GroupBox6.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(947, 243)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        '
        'txbAuthorCode
        '
        Me.txbAuthorCode.Location = New System.Drawing.Point(157, 162)
        Me.txbAuthorCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txbAuthorCode.Name = "txbAuthorCode"
        Me.txbAuthorCode.Size = New System.Drawing.Size(289, 22)
        Me.txbAuthorCode.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 165)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 19)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Mã Tác Giả:"
        '
        'txbProducer
        '
        Me.txbProducer.Location = New System.Drawing.Point(157, 117)
        Me.txbProducer.Margin = New System.Windows.Forms.Padding(4)
        Me.txbProducer.Name = "txbProducer"
        Me.txbProducer.Size = New System.Drawing.Size(289, 22)
        Me.txbProducer.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Mã Nhà Xuất Bản:"
        '
        'txbAmount
        '
        Me.txbAmount.Location = New System.Drawing.Point(603, 117)
        Me.txbAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txbAmount.Name = "txbAmount"
        Me.txbAmount.Size = New System.Drawing.Size(311, 22)
        Me.txbAmount.TabIndex = 12
        '
        'txbPublishingYear
        '
        Me.txbPublishingYear.Location = New System.Drawing.Point(603, 70)
        Me.txbPublishingYear.Margin = New System.Windows.Forms.Padding(4)
        Me.txbPublishingYear.Name = "txbPublishingYear"
        Me.txbPublishingYear.Size = New System.Drawing.Size(311, 22)
        Me.txbPublishingYear.TabIndex = 11
        '
        'txbKindCode
        '
        Me.txbKindCode.Location = New System.Drawing.Point(603, 23)
        Me.txbKindCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txbKindCode.Name = "txbKindCode"
        Me.txbKindCode.Size = New System.Drawing.Size(311, 22)
        Me.txbKindCode.TabIndex = 10
        '
        'txbBookName
        '
        Me.txbBookName.Location = New System.Drawing.Point(157, 70)
        Me.txbBookName.Margin = New System.Windows.Forms.Padding(4)
        Me.txbBookName.Name = "txbBookName"
        Me.txbBookName.Size = New System.Drawing.Size(289, 22)
        Me.txbBookName.TabIndex = 9
        '
        'mtxbInputDay
        '
        Me.mtxbInputDay.Location = New System.Drawing.Point(603, 162)
        Me.mtxbInputDay.Margin = New System.Windows.Forms.Padding(4)
        Me.mtxbInputDay.Mask = "00/00/0000"
        Me.mtxbInputDay.Name = "mtxbInputDay"
        Me.mtxbInputDay.Size = New System.Drawing.Size(311, 22)
        Me.mtxbInputDay.TabIndex = 8
        Me.mtxbInputDay.ValidatingType = GetType(Date)
        '
        'txbBookCode
        '
        Me.txbBookCode.Location = New System.Drawing.Point(157, 23)
        Me.txbBookCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txbBookCode.Name = "txbBookCode"
        Me.txbBookCode.Size = New System.Drawing.Size(289, 22)
        Me.txbBookCode.TabIndex = 7
        '
        'btnClose1
        '
        Me.btnClose1.BackColor = System.Drawing.Color.Tomato
        Me.btnClose1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose1.Location = New System.Drawing.Point(817, 192)
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
        Me.btnFind1.Location = New System.Drawing.Point(707, 192)
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
        Me.label9.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(510, 120)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(85, 19)
        Me.label9.TabIndex = 4
        Me.label9.Text = "Số Lượng:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(474, 73)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(121, 19)
        Me.label8.TabIndex = 3
        Me.label8.Text = "Năm Xuất Bản:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(487, 26)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(108, 19)
        Me.label7.TabIndex = 3
        Me.label7.Text = "Mã Thể Loại:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(501, 165)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(94, 19)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Ngày Nhập:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(69, 73)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(80, 19)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Tên Sách:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(69, 26)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(77, 19)
        Me.label4.TabIndex = 0
        Me.label4.Text = "Mã Sách:"
        '
        'frmFindBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 691)
        Me.Controls.Add(Me.tabctrFindBook)
        Me.Name = "frmFindBook"
        Me.Text = "Tìm Sách"
        Me.tabctrFindBook.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvBookInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabctrFindBook As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvBookInfo As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txbFind As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbbKind As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents GroupBox5 As GroupBox
    Friend WithEvents dgvBook As DataGridView
    Private WithEvents label10 As Label
    Private WithEvents GroupBox6 As GroupBox
    Private WithEvents txbAmount As TextBox
    Private WithEvents txbPublishingYear As TextBox
    Private WithEvents txbKindCode As TextBox
    Private WithEvents txbBookName As TextBox
    Private WithEvents mtxbInputDay As MaskedTextBox
    Private WithEvents txbBookCode As TextBox
    Private WithEvents btnClose1 As Button
    Private WithEvents btnFind1 As Button
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents txbAuthorCode As TextBox
    Private WithEvents Label11 As Label
    Private WithEvents txbProducer As TextBox
    Private WithEvents Label3 As Label
End Class
