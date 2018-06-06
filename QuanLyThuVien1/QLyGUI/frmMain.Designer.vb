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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnBookUpdate = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReaderManagement
        '
        Me.btnReaderManagement.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnReaderManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReaderManagement.Image = CType(resources.GetObject("btnReaderManagement.Image"), System.Drawing.Image)
        Me.btnReaderManagement.Location = New System.Drawing.Point(219, 125)
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
        Me.btnAuthorManagement.Location = New System.Drawing.Point(24, 270)
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
        Me.btnBorrowBook.Location = New System.Drawing.Point(419, 125)
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
        Me.btnFindBook.Location = New System.Drawing.Point(219, 270)
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
        Me.btnLogout.Location = New System.Drawing.Point(419, 270)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(182, 58)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Đăng xuất"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font(".VnTime", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 12)
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
        Me.btnClose.Location = New System.Drawing.Point(419, 334)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(182, 62)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Đóng"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(619, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(431, 665)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(339, 470)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 10
        '
        'btnBookUpdate
        '
        Me.btnBookUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnBookUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookUpdate.Location = New System.Drawing.Point(24, 125)
        Me.btnBookUpdate.Name = "btnBookUpdate"
        Me.btnBookUpdate.Size = New System.Drawing.Size(182, 126)
        Me.btnBookUpdate.TabIndex = 0
        Me.btnBookUpdate.Text = "Cập nhật sách"
        Me.btnBookUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBookUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBookUpdate.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1062, 710)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnFindBook)
        Me.Controls.Add(Me.btnBorrowBook)
        Me.Controls.Add(Me.btnAuthorManagement)
        Me.Controls.Add(Me.btnReaderManagement)
        Me.Controls.Add(Me.btnBookUpdate)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents btnBookUpdate As Button
End Class
