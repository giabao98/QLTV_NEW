<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnReaderManagement = New System.Windows.Forms.Button()
        Me.btnAuthorManagement = New System.Windows.Forms.Button()
        Me.btnBorrowBook = New System.Windows.Forms.Button()
        Me.btnFindBook = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBookUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReaderManagement
        '
        Me.btnReaderManagement.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnReaderManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReaderManagement.Image = CType(resources.GetObject("btnReaderManagement.Image"), System.Drawing.Image)
        Me.btnReaderManagement.Location = New System.Drawing.Point(201, 31)
        Me.btnReaderManagement.Name = "btnReaderManagement"
        Me.btnReaderManagement.Size = New System.Drawing.Size(182, 126)
        Me.btnReaderManagement.TabIndex = 1
        Me.btnReaderManagement.Text = "Quản lý độc giả"
        Me.btnReaderManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReaderManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReaderManagement.UseVisualStyleBackColor = False
        '
        'btnAuthorManagement
        '
        Me.btnAuthorManagement.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAuthorManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuthorManagement.Image = CType(resources.GetObject("btnAuthorManagement.Image"), System.Drawing.Image)
        Me.btnAuthorManagement.Location = New System.Drawing.Point(6, 176)
        Me.btnAuthorManagement.Name = "btnAuthorManagement"
        Me.btnAuthorManagement.Size = New System.Drawing.Size(182, 126)
        Me.btnAuthorManagement.TabIndex = 2
        Me.btnAuthorManagement.Text = "Thay đổi quy định"
        Me.btnAuthorManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAuthorManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAuthorManagement.UseVisualStyleBackColor = False
        '
        'btnBorrowBook
        '
        Me.btnBorrowBook.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnBorrowBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowBook.Image = CType(resources.GetObject("btnBorrowBook.Image"), System.Drawing.Image)
        Me.btnBorrowBook.Location = New System.Drawing.Point(401, 31)
        Me.btnBorrowBook.Name = "btnBorrowBook"
        Me.btnBorrowBook.Size = New System.Drawing.Size(182, 126)
        Me.btnBorrowBook.TabIndex = 3
        Me.btnBorrowBook.Text = "Mượn trả sách"
        Me.btnBorrowBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrowBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBorrowBook.UseVisualStyleBackColor = False
        '
        'btnFindBook
        '
        Me.btnFindBook.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFindBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindBook.Image = CType(resources.GetObject("btnFindBook.Image"), System.Drawing.Image)
        Me.btnFindBook.Location = New System.Drawing.Point(201, 176)
        Me.btnFindBook.Name = "btnFindBook"
        Me.btnFindBook.Size = New System.Drawing.Size(182, 126)
        Me.btnFindBook.TabIndex = 4
        Me.btnFindBook.Text = "Tìm kiếm"
        Me.btnFindBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFindBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnFindBook.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(11, 21)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(182, 127)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Hệ thống"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font(".VnTime", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 70)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Quản lý thư viện"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(11, 164)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(182, 126)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Đóng"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(619, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(431, 675)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnBookUpdate
        '
        Me.btnBookUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnBookUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookUpdate.Image = CType(resources.GetObject("btnBookUpdate.Image"), System.Drawing.Image)
        Me.btnBookUpdate.Location = New System.Drawing.Point(6, 31)
        Me.btnBookUpdate.Name = "btnBookUpdate"
        Me.btnBookUpdate.Size = New System.Drawing.Size(182, 126)
        Me.btnBookUpdate.TabIndex = 0
        Me.btnBookUpdate.Text = "Quản lý sách"
        Me.btnBookUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBookUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBookUpdate.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnReaderManagement)
        Me.GroupBox1.Controls.Add(Me.btnBookUpdate)
        Me.GroupBox1.Controls.Add(Me.btnAuthorManagement)
        Me.GroupBox1.Controls.Add(Me.btnBorrowBook)
        Me.GroupBox1.Controls.Add(Me.btnFindBook)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 311)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(83, 395)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnLogout)
        Me.GroupBox2.Location = New System.Drawing.Point(411, 389)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 298)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(401, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 126)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Báo cáo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 619)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(383, 68)
        Me.TextBox1.TabIndex = 11
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1062, 710)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReaderManagement As Button
    Friend WithEvents btnAuthorManagement As Button
    Friend WithEvents btnBorrowBook As Button
    Friend WithEvents btnFindBook As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBookUpdate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
End Class
