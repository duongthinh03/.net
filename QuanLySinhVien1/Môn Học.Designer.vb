<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Môn_Học
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
        Me.txtmahp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsodvht = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttenhp = New System.Windows.Forms.TextBox()
        Me.txthocky = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmanganh = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(41, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Học Phần"
        '
        'txtmahp
        '
        Me.txtmahp.Location = New System.Drawing.Point(141, 24)
        Me.txtmahp.Name = "txtmahp"
        Me.txtmahp.Size = New System.Drawing.Size(113, 22)
        Me.txtmahp.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Học Phần"
        '
        'txtsodvht
        '
        Me.txtsodvht.Location = New System.Drawing.Point(141, 109)
        Me.txtsodvht.Name = "txtsodvht"
        Me.txtsodvht.Size = New System.Drawing.Size(113, 22)
        Me.txtsodvht.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Số dvht"
        '
        'txttenhp
        '
        Me.txttenhp.Location = New System.Drawing.Point(141, 67)
        Me.txttenhp.Name = "txttenhp"
        Me.txttenhp.Size = New System.Drawing.Size(113, 22)
        Me.txttenhp.TabIndex = 3
        '
        'txthocky
        '
        Me.txthocky.Location = New System.Drawing.Point(428, 67)
        Me.txthocky.Name = "txthocky"
        Me.txthocky.Size = New System.Drawing.Size(113, 22)
        Me.txthocky.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Học Kỳ"
        '
        'txtmanganh
        '
        Me.txtmanganh.Location = New System.Drawing.Point(428, 24)
        Me.txtmanganh.Name = "txtmanganh"
        Me.txtmanganh.Size = New System.Drawing.Size(113, 22)
        Me.txtmanganh.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Mã Ngành"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(673, 71)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(581, 71)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(673, 27)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(581, 27)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(44, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(704, 303)
        Me.DataGridView1.TabIndex = 19
        '
        'Môn_Học
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.ClientSize = New System.Drawing.Size(827, 464)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txthocky)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmanganh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsodvht)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttenhp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmahp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Môn_Học"
        Me.Text = "Môn_Học"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtmahp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsodvht As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttenhp As TextBox
    Friend WithEvents txthocky As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmanganh As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
