<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lớp
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
        Me.txtmalop = New System.Windows.Forms.TextBox()
        Me.txttenlop = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtmanganh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnamnhaphoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txthedt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtkhoahoc = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(49, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Lớp"
        '
        'txtmalop
        '
        Me.txtmalop.Location = New System.Drawing.Point(126, 21)
        Me.txtmalop.Multiline = True
        Me.txtmalop.Name = "txtmalop"
        Me.txtmalop.Size = New System.Drawing.Size(109, 22)
        Me.txtmalop.TabIndex = 1
        '
        'txttenlop
        '
        Me.txttenlop.Location = New System.Drawing.Point(126, 53)
        Me.txttenlop.Multiline = True
        Me.txttenlop.Name = "txttenlop"
        Me.txttenlop.Size = New System.Drawing.Size(109, 22)
        Me.txttenlop.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(49, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(53, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Tên lớp"
        '
        'txtmanganh
        '
        Me.txtmanganh.Location = New System.Drawing.Point(126, 91)
        Me.txtmanganh.Multiline = True
        Me.txtmanganh.Name = "txtmanganh"
        Me.txtmanganh.Size = New System.Drawing.Size(109, 22)
        Me.txtmanganh.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mã Ngành"
        '
        'txtnamnhaphoc
        '
        Me.txtnamnhaphoc.Location = New System.Drawing.Point(445, 91)
        Me.txtnamnhaphoc.Multiline = True
        Me.txtnamnhaphoc.Name = "txtnamnhaphoc"
        Me.txtnamnhaphoc.Size = New System.Drawing.Size(109, 22)
        Me.txtnamnhaphoc.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Năm nhập Học"
        '
        'txthedt
        '
        Me.txthedt.Location = New System.Drawing.Point(445, 56)
        Me.txthedt.Multiline = True
        Me.txthedt.Name = "txthedt"
        Me.txthedt.Size = New System.Drawing.Size(109, 22)
        Me.txthedt.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hệ đào tạo"
        '
        'txtkhoahoc
        '
        Me.txtkhoahoc.Location = New System.Drawing.Point(445, 18)
        Me.txtkhoahoc.Multiline = True
        Me.txtkhoahoc.Name = "txtkhoahoc"
        Me.txtkhoahoc.Size = New System.Drawing.Size(109, 22)
        Me.txtkhoahoc.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "khóa học"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(737, 77)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(645, 77)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(737, 33)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(645, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(880, 306)
        Me.DataGridView1.TabIndex = 19
        '
        'Lớp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(939, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtnamnhaphoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txthedt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtkhoahoc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtmanganh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttenlop)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtmalop)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Lớp"
        Me.Text = "Lớp"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtmalop As TextBox
    Friend WithEvents txttenlop As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents txtmanganh As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnamnhaphoc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txthedt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtkhoahoc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
