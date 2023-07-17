<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sinh_Viên
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
        Me.txtmasv = New System.Windows.Forms.TextBox()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmalop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtngaysinh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgioitinh = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sinh Viên"
        '
        'txtmasv
        '
        Me.txtmasv.Location = New System.Drawing.Point(146, 30)
        Me.txtmasv.Multiline = True
        Me.txtmasv.Name = "txtmasv"
        Me.txtmasv.Size = New System.Drawing.Size(109, 22)
        Me.txtmasv.TabIndex = 1
        '
        'txthoten
        '
        Me.txthoten.Location = New System.Drawing.Point(146, 79)
        Me.txthoten.Multiline = True
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(109, 22)
        Me.txthoten.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Họ Tên"
        '
        'txtmalop
        '
        Me.txtmalop.Location = New System.Drawing.Point(146, 127)
        Me.txtmalop.Multiline = True
        Me.txtmalop.Name = "txtmalop"
        Me.txtmalop.Size = New System.Drawing.Size(109, 22)
        Me.txtmalop.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mã Lớp"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(418, 127)
        Me.txtdiachi.Multiline = True
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(109, 22)
        Me.txtdiachi.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(308, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Địa Chỉ"
        '
        'txtngaysinh
        '
        Me.txtngaysinh.Location = New System.Drawing.Point(418, 79)
        Me.txtngaysinh.Multiline = True
        Me.txtngaysinh.Name = "txtngaysinh"
        Me.txtngaysinh.Size = New System.Drawing.Size(109, 22)
        Me.txtngaysinh.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ngày Sinh"
        '
        'txtgioitinh
        '
        Me.txtgioitinh.Location = New System.Drawing.Point(418, 30)
        Me.txtgioitinh.Multiline = True
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(109, 22)
        Me.txtgioitinh.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Giới Tính"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(775, 77)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(683, 77)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(775, 33)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(683, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(39, 170)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(907, 254)
        Me.DataGridView1.TabIndex = 16
        '
        'Sinh_Viên
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(993, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtngaysinh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtgioitinh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtmalop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmasv)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Sinh_Viên"
        Me.Text = "Sinh_Viên"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtmasv As TextBox
    Friend WithEvents txthoten As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmalop As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdiachi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtngaysinh As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtgioitinh As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
