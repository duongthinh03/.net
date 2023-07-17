<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttaikhoan = New System.Windows.Forms.TextBox()
        Me.txtMaukhau = New System.Windows.Forms.TextBox()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tài khoản"
        '
        'txttaikhoan
        '
        Me.txttaikhoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttaikhoan.Location = New System.Drawing.Point(155, 39)
        Me.txttaikhoan.Multiline = True
        Me.txttaikhoan.Name = "txttaikhoan"
        Me.txttaikhoan.Size = New System.Drawing.Size(334, 30)
        Me.txttaikhoan.TabIndex = 1
        '
        'txtMaukhau
        '
        Me.txtMaukhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaukhau.Location = New System.Drawing.Point(155, 114)
        Me.txtMaukhau.Multiline = True
        Me.txtMaukhau.Name = "txtMaukhau"
        Me.txtMaukhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMaukhau.Size = New System.Drawing.Size(334, 30)
        Me.txtMaukhau.TabIndex = 3
        '
        'btndangnhap
        '
        Me.btndangnhap.Location = New System.Drawing.Point(278, 196)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(95, 51)
        Me.btndangnhap.TabIndex = 4
        Me.btndangnhap.Text = "Đăng nhập"
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnthoat.Location = New System.Drawing.Point(403, 196)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(86, 51)
        Me.btnthoat.TabIndex = 5
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mật khẩu"
        '
        'Form1
        '
        Me.AcceptButton = Me.btndangnhap
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.CancelButton = Me.btnthoat
        Me.ClientSize = New System.Drawing.Size(535, 287)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.txtMaukhau)
        Me.Controls.Add(Me.txttaikhoan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txttaikhoan As TextBox
    Friend WithEvents txtMaukhau As TextBox
    Friend WithEvents btndangnhap As Button
    Friend WithEvents btnthoat As Button
    Friend WithEvents Label2 As Label
End Class
