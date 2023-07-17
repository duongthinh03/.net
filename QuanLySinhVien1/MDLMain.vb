Imports System.Data.SqlClient ' gọi thư viện kết nối SQl
Module MDLMain
    Public conn As New SqlConnection
    Public sql As String
    Public cmd As New SqlCommand
    Public Sub ketnoi()
        Dim cn As String = "Data Source=THINH\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True"
        Try
            conn = New SqlConnection(cn)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("kết nối không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Lấy nguồn dữ liệu
    Public Function DLKhoa() As DataTable
        Dim da As New SqlDataAdapter("select * from KHOA", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function DLNganh() As DataTable
        Dim da As New SqlDataAdapter("select * from NGANH", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function DLLop() As DataTable
        Dim da As New SqlDataAdapter("select * from LOP", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function DLSinhVien() As DataTable
        Dim da As New SqlDataAdapter("select * from SINHVIEN", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function DLMonHoc() As DataTable
        Dim da As New SqlDataAdapter("select * from HOCPHAN", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function DLKetQua() As DataTable
        Dim da As New SqlDataAdapter("select * from DIEMHP", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function DLTimKiem() As DataTable
        Dim da As New SqlDataAdapter("select a.MaSV,HoTen,MaLop,GioiTinh,NgaySinh,DiaChi,DiemHP from SINHVIEN a join DIEMHP b on a.MaSV=b.MaSV", conn) 'where a.MaSV='{0}'
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
End Module
