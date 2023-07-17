Imports System.Data.SqlClient
Imports System.IO
Imports System.Collections.Generic
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Linq
Imports System.Drawing
Imports System.Configuration

Public Class Trang_Chủ
    Private Sub KhoaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhoaToolStripMenuItem.Click
        Khoa.Show()
    End Sub

    Private Sub NgànhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NgànhToolStripMenuItem.Click
        Ngành.Show()
    End Sub

    Private Sub LớpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LớpToolStripMenuItem.Click
        Lớp.Show()
    End Sub

    Private Sub SinhViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SinhViênToolStripMenuItem.Click
        Sinh_Viên.Show()
    End Sub

    Private Sub MônHọcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MônHọcToolStripMenuItem.Click
        Môn_Học.Show()
    End Sub

    Private Sub KếtQuảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KếtQuảToolStripMenuItem.Click
        Kết_Quả.Show()
    End Sub
    Private Sub Trang_Chủ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketnoi()
        Dim dt As DataTable
        dt = DLTimKiem()
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sql As String = "select a.MaSV,HoTen,MaLop,GioiTinh,NgaySinh,DiaChi,DiemHP from SINHVIEN a join DIEMHP b on a.MaSV=b.MaSV where a.MaSV like  '%" & txtSearch.Text & "%'"
        'load du lieu
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand(sql, conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        txtSearch.DataBindings.Clear()
        txtSearch.DataBindings.Add("text", dt, "MaSV")
    End Sub
End Class