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
        Me.btnBookUpdate = New System.Windows.Forms.Button()
        Me.btnReaderManagement = New System.Windows.Forms.Button()
        Me.btnAuthorManagement = New System.Windows.Forms.Button()
        Me.btnBorrowBook = New System.Windows.Forms.Button()
        Me.btnFindBook = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBookUpdate
        '
        Me.btnBookUpdate.Location = New System.Drawing.Point(32, 148)
        Me.btnBookUpdate.Name = "btnBookUpdate"
        Me.btnBookUpdate.Size = New System.Drawing.Size(182, 126)
        Me.btnBookUpdate.TabIndex = 0
        Me.btnBookUpdate.Text = "Cập nhật sách"
        Me.btnBookUpdate.UseVisualStyleBackColor = True
        '
        'btnReaderManagement
        '
        Me.btnReaderManagement.Location = New System.Drawing.Point(227, 148)
        Me.btnReaderManagement.Name = "btnReaderManagement"
        Me.btnReaderManagement.Size = New System.Drawing.Size(182, 126)
        Me.btnReaderManagement.TabIndex = 1
        Me.btnReaderManagement.Text = "Quản lý độc giả"
        Me.btnReaderManagement.UseVisualStyleBackColor = True
        '
        'btnAuthorManagement
        '
        Me.btnAuthorManagement.Location = New System.Drawing.Point(427, 148)
        Me.btnAuthorManagement.Name = "btnAuthorManagement"
        Me.btnAuthorManagement.Size = New System.Drawing.Size(182, 126)
        Me.btnAuthorManagement.TabIndex = 2
        Me.btnAuthorManagement.Text = "Quản lý tác giả"
        Me.btnAuthorManagement.UseVisualStyleBackColor = True
        '
        'btnBorrowBook
        '
        Me.btnBorrowBook.Location = New System.Drawing.Point(32, 293)
        Me.btnBorrowBook.Name = "btnBorrowBook"
        Me.btnBorrowBook.Size = New System.Drawing.Size(182, 126)
        Me.btnBorrowBook.TabIndex = 3
        Me.btnBorrowBook.Text = "Mượn trả sách"
        Me.btnBorrowBook.UseVisualStyleBackColor = True
        '
        'btnFindBook
        '
        Me.btnFindBook.Location = New System.Drawing.Point(227, 293)
        Me.btnFindBook.Name = "btnFindBook"
        Me.btnFindBook.Size = New System.Drawing.Size(182, 126)
        Me.btnFindBook.TabIndex = 4
        Me.btnFindBook.Text = "Tìm kiếm"
        Me.btnFindBook.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(427, 293)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(182, 58)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Đăng xuất"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font(".VnTime", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 70)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Quản lý thư viện"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(427, 357)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(182, 62)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Đóng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 460)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBookUpdate As Button
    Friend WithEvents btnReaderManagement As Button
    Friend WithEvents btnAuthorManagement As Button
    Friend WithEvents btnBorrowBook As Button
    Friend WithEvents btnFindBook As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
End Class
