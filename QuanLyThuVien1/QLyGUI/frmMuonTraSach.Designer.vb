<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuonTraSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMuonTraSach))
        Me.Muonsach_TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDayCreate = New System.Windows.Forms.DateTimePicker()
        Me.txtNumbers = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.cbBookKindID = New System.Windows.Forms.ComboBox()
        Me.lbAuthor = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.cbBookID = New System.Windows.Forms.ComboBox()
        Me.txtReaderName = New System.Windows.Forms.TextBox()
        Me.cbReaderID = New System.Windows.Forms.ComboBox()
        Me.lbSoLuong = New System.Windows.Forms.Label()
        Me.lbNgayMuon = New System.Windows.Forms.Label()
        Me.lbTheLoai = New System.Windows.Forms.Label()
        Me.lbTenSach = New System.Windows.Forms.Label()
        Me.lbReaderID = New System.Windows.Forms.Label()
        Me.lbMaSach = New System.Windows.Forms.Label()
        Me.lbReaderName = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.cbStatusID = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Muonsach_TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Muonsach_TabControl
        '
        Me.Muonsach_TabControl.Controls.Add(Me.TabPage1)
        Me.Muonsach_TabControl.Controls.Add(Me.TabPage2)
        Me.Muonsach_TabControl.Location = New System.Drawing.Point(12, 12)
        Me.Muonsach_TabControl.Name = "Muonsach_TabControl"
        Me.Muonsach_TabControl.SelectedIndex = 0
        Me.Muonsach_TabControl.Size = New System.Drawing.Size(766, 483)
        Me.Muonsach_TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(758, 457)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mượn sách"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 256)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(750, 204)
        Me.DataGridView1.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Controls.Add(Me.btDelete)
        Me.GroupBox3.Controls.Add(Me.btUpdate)
        Me.GroupBox3.Controls.Add(Me.btAdd)
        Me.GroupBox3.Location = New System.Drawing.Point(604, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(152, 187)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'btDelete
        '
        Me.btDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btDelete.Image = CType(resources.GetObject("btDelete.Image"), System.Drawing.Image)
        Me.btDelete.Location = New System.Drawing.Point(43, 137)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(88, 30)
        Me.btDelete.TabIndex = 2
        Me.btDelete.Text = "Xóa phiếu"
        Me.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btDelete.UseVisualStyleBackColor = False
        '
        'btUpdate
        '
        Me.btUpdate.BackColor = System.Drawing.Color.LightGreen
        Me.btUpdate.Image = CType(resources.GetObject("btUpdate.Image"), System.Drawing.Image)
        Me.btUpdate.Location = New System.Drawing.Point(43, 76)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(88, 30)
        Me.btUpdate.TabIndex = 1
        Me.btUpdate.Text = "Thay đổi"
        Me.btUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btUpdate.UseVisualStyleBackColor = False
        '
        'btAdd
        '
        Me.btAdd.BackColor = System.Drawing.Color.LightGreen
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.Location = New System.Drawing.Point(43, 19)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(88, 30)
        Me.btAdd.TabIndex = 0
        Me.btAdd.Text = "Xác nhận"
        Me.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(750, 50)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(235, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Chi tiết phiếu mượn sách"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.cbStatusID)
        Me.GroupBox1.Controls.Add(Me.lbStatus)
        Me.GroupBox1.Controls.Add(Me.dtpDayCreate)
        Me.GroupBox1.Controls.Add(Me.txtNumbers)
        Me.GroupBox1.Controls.Add(Me.txtAuthor)
        Me.GroupBox1.Controls.Add(Me.cbBookKindID)
        Me.GroupBox1.Controls.Add(Me.lbAuthor)
        Me.GroupBox1.Controls.Add(Me.txtBookName)
        Me.GroupBox1.Controls.Add(Me.cbBookID)
        Me.GroupBox1.Controls.Add(Me.txtReaderName)
        Me.GroupBox1.Controls.Add(Me.cbReaderID)
        Me.GroupBox1.Controls.Add(Me.lbSoLuong)
        Me.GroupBox1.Controls.Add(Me.lbNgayMuon)
        Me.GroupBox1.Controls.Add(Me.lbTheLoai)
        Me.GroupBox1.Controls.Add(Me.lbTenSach)
        Me.GroupBox1.Controls.Add(Me.lbReaderID)
        Me.GroupBox1.Controls.Add(Me.lbMaSach)
        Me.GroupBox1.Controls.Add(Me.lbReaderName)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 189)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'dtpDayCreate
        '
        Me.dtpDayCreate.Location = New System.Drawing.Point(404, 44)
        Me.dtpDayCreate.Name = "dtpDayCreate"
        Me.dtpDayCreate.Size = New System.Drawing.Size(182, 20)
        Me.dtpDayCreate.TabIndex = 15
        '
        'txtNumbers
        '
        Me.txtNumbers.Location = New System.Drawing.Point(404, 84)
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.Size = New System.Drawing.Size(182, 20)
        Me.txtNumbers.TabIndex = 14
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(404, 9)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(182, 20)
        Me.txtAuthor.TabIndex = 13
        '
        'cbBookKindID
        '
        Me.cbBookKindID.FormattingEnabled = True
        Me.cbBookKindID.Location = New System.Drawing.Point(106, 156)
        Me.cbBookKindID.Name = "cbBookKindID"
        Me.cbBookKindID.Size = New System.Drawing.Size(182, 21)
        Me.cbBookKindID.TabIndex = 12
        '
        'lbAuthor
        '
        Me.lbAuthor.AutoSize = True
        Me.lbAuthor.Location = New System.Drawing.Point(337, 16)
        Me.lbAuthor.Name = "lbAuthor"
        Me.lbAuthor.Size = New System.Drawing.Size(43, 13)
        Me.lbAuthor.TabIndex = 11
        Me.lbAuthor.Text = "Tác giả"
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(106, 121)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(182, 20)
        Me.txtBookName.TabIndex = 10
        '
        'cbBookID
        '
        Me.cbBookID.FormattingEnabled = True
        Me.cbBookID.Location = New System.Drawing.Point(106, 84)
        Me.cbBookID.Name = "cbBookID"
        Me.cbBookID.Size = New System.Drawing.Size(182, 21)
        Me.cbBookID.TabIndex = 9
        '
        'txtReaderName
        '
        Me.txtReaderName.Location = New System.Drawing.Point(106, 48)
        Me.txtReaderName.Name = "txtReaderName"
        Me.txtReaderName.Size = New System.Drawing.Size(182, 20)
        Me.txtReaderName.TabIndex = 8
        '
        'cbReaderID
        '
        Me.cbReaderID.FormattingEnabled = True
        Me.cbReaderID.Location = New System.Drawing.Point(106, 13)
        Me.cbReaderID.Name = "cbReaderID"
        Me.cbReaderID.Size = New System.Drawing.Size(182, 21)
        Me.cbReaderID.TabIndex = 7
        '
        'lbSoLuong
        '
        Me.lbSoLuong.AutoSize = True
        Me.lbSoLuong.Location = New System.Drawing.Point(337, 90)
        Me.lbSoLuong.Name = "lbSoLuong"
        Me.lbSoLuong.Size = New System.Drawing.Size(49, 13)
        Me.lbSoLuong.TabIndex = 6
        Me.lbSoLuong.Text = "Số lượng"
        '
        'lbNgayMuon
        '
        Me.lbNgayMuon.AutoSize = True
        Me.lbNgayMuon.Location = New System.Drawing.Point(337, 51)
        Me.lbNgayMuon.Name = "lbNgayMuon"
        Me.lbNgayMuon.Size = New System.Drawing.Size(61, 13)
        Me.lbNgayMuon.TabIndex = 5
        Me.lbNgayMuon.Text = "Ngày mượn"
        '
        'lbTheLoai
        '
        Me.lbTheLoai.AutoSize = True
        Me.lbTheLoai.Location = New System.Drawing.Point(35, 159)
        Me.lbTheLoai.Name = "lbTheLoai"
        Me.lbTheLoai.Size = New System.Drawing.Size(45, 13)
        Me.lbTheLoai.TabIndex = 4
        Me.lbTheLoai.Text = "Thể loại"
        '
        'lbTenSach
        '
        Me.lbTenSach.AutoSize = True
        Me.lbTenSach.Location = New System.Drawing.Point(35, 124)
        Me.lbTenSach.Name = "lbTenSach"
        Me.lbTenSach.Size = New System.Drawing.Size(52, 13)
        Me.lbTenSach.TabIndex = 3
        Me.lbTenSach.Text = "Tên sách"
        '
        'lbReaderID
        '
        Me.lbReaderID.AutoSize = True
        Me.lbReaderID.Location = New System.Drawing.Point(35, 16)
        Me.lbReaderID.Name = "lbReaderID"
        Me.lbReaderID.Size = New System.Drawing.Size(61, 13)
        Me.lbReaderID.TabIndex = 0
        Me.lbReaderID.Text = "Mã đọc giả"
        '
        'lbMaSach
        '
        Me.lbMaSach.AutoSize = True
        Me.lbMaSach.Location = New System.Drawing.Point(35, 90)
        Me.lbMaSach.Name = "lbMaSach"
        Me.lbMaSach.Size = New System.Drawing.Size(48, 13)
        Me.lbMaSach.TabIndex = 2
        Me.lbMaSach.Text = "Mã sách"
        '
        'lbReaderName
        '
        Me.lbReaderName.AutoSize = True
        Me.lbReaderName.Location = New System.Drawing.Point(35, 51)
        Me.lbReaderName.Name = "lbReaderName"
        Me.lbReaderName.Size = New System.Drawing.Size(65, 13)
        Me.lbReaderName.TabIndex = 1
        Me.lbReaderName.Text = "Tên đọc giả"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(758, 457)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Trả sách"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(5, 248)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(751, 210)
        Me.DataGridView2.TabIndex = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Location = New System.Drawing.Point(603, 61)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(152, 181)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(43, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Xóa phiếu"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(43, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Thay đổi"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGreen
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(43, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 30)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Xác nhận"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(750, 50)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(235, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chi tiết phiếu trả sách"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.ComboBox1)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.TextBox3)
        Me.GroupBox6.Controls.Add(Me.ComboBox2)
        Me.GroupBox6.Controls.Add(Me.TextBox4)
        Me.GroupBox6.Controls.Add(Me.ComboBox3)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Location = New System.Drawing.Point(5, 59)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(592, 183)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(404, 45)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(182, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(404, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(182, 20)
        Me.TextBox2.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(106, 154)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tác giả"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(106, 121)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(182, 20)
        Me.TextBox3.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(106, 84)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(106, 48)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(182, 20)
        Me.TextBox4.TabIndex = 8
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(106, 13)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox3.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(337, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ngày mượn"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Thể loại"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Tên sách"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Mã đọc giả"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Mã sách"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Tên đọc giả"
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(337, 124)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(55, 13)
        Me.lbStatus.TabIndex = 16
        Me.lbStatus.Text = "Tình trạng"
        '
        'cbStatusID
        '
        Me.cbStatusID.FormattingEnabled = True
        Me.cbStatusID.Location = New System.Drawing.Point(404, 121)
        Me.cbStatusID.Name = "cbStatusID"
        Me.cbStatusID.Size = New System.Drawing.Size(182, 21)
        Me.cbStatusID.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Label4"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(404, 118)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(182, 20)
        Me.DateTimePicker2.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(337, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Ngày mượn"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(404, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(182, 20)
        Me.TextBox1.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(337, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Label12"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(404, 154)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(182, 20)
        Me.TextBox5.TabIndex = 21
        '
        'frmMuonTraSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 507)
        Me.Controls.Add(Me.Muonsach_TabControl)
        Me.Name = "frmMuonTraSach"
        Me.Text = "frmMuonTraSach"
        Me.Muonsach_TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Muonsach_TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbReaderName As Label
    Friend WithEvents lbReaderID As Label
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbMaSach As Label
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents cbBookID As ComboBox
    Friend WithEvents txtReaderName As TextBox
    Friend WithEvents cbReaderID As ComboBox
    Friend WithEvents lbSoLuong As Label
    Friend WithEvents lbNgayMuon As Label
    Friend WithEvents lbTheLoai As Label
    Friend WithEvents lbTenSach As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpDayCreate As DateTimePicker
    Friend WithEvents txtNumbers As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents cbBookKindID As ComboBox
    Friend WithEvents lbAuthor As Label
    Friend WithEvents btDelete As Button
    Friend WithEvents btUpdate As Button
    Friend WithEvents btAdd As Button
    Friend WithEvents cbStatusID As ComboBox
    Friend WithEvents lbStatus As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Public WithEvents Label1 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
