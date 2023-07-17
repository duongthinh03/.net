<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Trang_Chủ
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuảnLýSinhViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KhoaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NgànhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LớpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SinhViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MônHọcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KếtQuảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Bisque
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýSinhViênToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(786, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuảnLýSinhViênToolStripMenuItem
        '
        Me.QuảnLýSinhViênToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KhoaToolStripMenuItem, Me.NgànhToolStripMenuItem, Me.LớpToolStripMenuItem, Me.ToolStripMenuItem1, Me.SinhViênToolStripMenuItem, Me.ToolStripMenuItem2, Me.MônHọcToolStripMenuItem, Me.KếtQuảToolStripMenuItem})
        Me.QuảnLýSinhViênToolStripMenuItem.Name = "QuảnLýSinhViênToolStripMenuItem"
        Me.QuảnLýSinhViênToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.QuảnLýSinhViênToolStripMenuItem.Text = "&Quản Lý Sinh Viên"
        '
        'KhoaToolStripMenuItem
        '
        Me.KhoaToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.KhoaToolStripMenuItem.Name = "KhoaToolStripMenuItem"
        Me.KhoaToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.KhoaToolStripMenuItem.Text = "Khoa"
        '
        'NgànhToolStripMenuItem
        '
        Me.NgànhToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NgànhToolStripMenuItem.Name = "NgànhToolStripMenuItem"
        Me.NgànhToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.NgànhToolStripMenuItem.Text = "Ngành"
        '
        'LớpToolStripMenuItem
        '
        Me.LớpToolStripMenuItem.BackColor = System.Drawing.Color.Yellow
        Me.LớpToolStripMenuItem.Name = "LớpToolStripMenuItem"
        Me.LớpToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.LớpToolStripMenuItem.Text = "Lớp"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(150, 6)
        '
        'SinhViênToolStripMenuItem
        '
        Me.SinhViênToolStripMenuItem.BackColor = System.Drawing.Color.Cyan
        Me.SinhViênToolStripMenuItem.Name = "SinhViênToolStripMenuItem"
        Me.SinhViênToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.SinhViênToolStripMenuItem.Text = "Sinh Viên"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(150, 6)
        '
        'MônHọcToolStripMenuItem
        '
        Me.MônHọcToolStripMenuItem.BackColor = System.Drawing.Color.Magenta
        Me.MônHọcToolStripMenuItem.Name = "MônHọcToolStripMenuItem"
        Me.MônHọcToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.MônHọcToolStripMenuItem.Text = "Môn Học"
        '
        'KếtQuảToolStripMenuItem
        '
        Me.KếtQuảToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.KếtQuảToolStripMenuItem.Name = "KếtQuảToolStripMenuItem"
        Me.KếtQuảToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.KếtQuảToolStripMenuItem.Text = "Kết Quả"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(762, 330)
        Me.DataGridView1.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(108, 70)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(221, 30)
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(354, 69)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 34)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Trang_Chủ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(786, 469)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Trang_Chủ"
        Me.Text = "Trang_Chủ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuảnLýSinhViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KhoaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NgànhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LớpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SinhViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents MônHọcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KếtQuảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
End Class
