<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Me.btnFindBook = New System.Windows.Forms.Button()
        Me.btnFindReader = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFindBook
        '
        Me.btnFindBook.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFindBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindBook.Location = New System.Drawing.Point(43, 35)
        Me.btnFindBook.Name = "btnFindBook"
        Me.btnFindBook.Size = New System.Drawing.Size(249, 125)
        Me.btnFindBook.TabIndex = 0
        Me.btnFindBook.Text = "Tìm kiếm sách"
        Me.btnFindBook.UseVisualStyleBackColor = False
        '
        'btnFindReader
        '
        Me.btnFindReader.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFindReader.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindReader.Location = New System.Drawing.Point(43, 196)
        Me.btnFindReader.Name = "btnFindReader"
        Me.btnFindReader.Size = New System.Drawing.Size(249, 125)
        Me.btnFindReader.TabIndex = 1
        Me.btnFindReader.Text = "Tìm kiếm độc giả"
        Me.btnFindReader.UseVisualStyleBackColor = False
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(340, 378)
        Me.Controls.Add(Me.btnFindReader)
        Me.Controls.Add(Me.btnFindBook)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Loại tìm kiếm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFindBook As Button
    Friend WithEvents btnFindReader As Button
End Class
