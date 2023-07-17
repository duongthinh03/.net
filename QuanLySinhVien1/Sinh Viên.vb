Public Class Sinh_Viên
    Private Sub Sinh_Viên_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketnoi()
        Dim dt As DataTable
        dt = DLSinhVien()
        DataGridView1.DataSource = dt
        txtmasv.DataBindings.Clear()
        txtmasv.DataBindings.Add("text", dt, "MaSV")
        txthoten.DataBindings.Clear()
        txthoten.DataBindings.Add("text", dt, "HoTen")
        txtmalop.DataBindings.Clear()
        txtmalop.DataBindings.Add("text", dt, "MaLop")
        txtgioitinh.DataBindings.Clear()
        txtgioitinh.DataBindings.Add("text", dt, "GioiTinh")
        txtngaysinh.DataBindings.Clear()
        txtngaysinh.DataBindings.Add("text", dt, "NgaySinh")
        txtdiachi.DataBindings.Clear()
        txtdiachi.DataBindings.Add("text", dt, "DiaChi")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtmalop.Clear()
        txthoten.Clear()
        txtmalop.Clear()
        txtgioitinh.Clear()
        txtngaysinh.Clear()
        txtdiachi.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim msv As String = txtmasv.Text
        Dim ht As String = txthoten.Text
        Dim ml As String = txtmalop.Text
        Dim gt As String = txtgioitinh.Text
        Dim ns As String = txtngaysinh.Text
        Dim dc As String = txtdiachi.Text
        sql = "insert into SINHVIEN(MaSV,HoTen,MaLop,GioiTinh,NgaySinh,DiaChi) values('" + msv + "',N'" + ht + "','" + ml + "','" + gt + "','" + ns + "',N'" + dc + "')"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLSinhVien()
        DataGridView1.DataSource = dt
        txtmasv.DataBindings.Clear()
        txtmasv.DataBindings.Add("text", dt, "MaSV")
        txthoten.DataBindings.Clear()
        txthoten.DataBindings.Add("text", dt, "HoTen")
        txtmalop.DataBindings.Clear()
        txtmalop.DataBindings.Add("text", dt, "MaLop")
        txtgioitinh.DataBindings.Clear()
        txtgioitinh.DataBindings.Add("text", dt, "GioiTinh")
        txtngaysinh.DataBindings.Clear()
        txtngaysinh.DataBindings.Add("text", dt, "NgaySinh")
        txtdiachi.DataBindings.Clear()
        txtdiachi.DataBindings.Add("text", dt, "DiaChi")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim msv As String = txtmasv.Text
        Dim ht As String = txthoten.Text
        Dim ml As String = txtmalop.Text
        Dim gt As String = txtgioitinh.Text
        Dim ns As String = txtngaysinh.Text
        Dim dc As String = txtdiachi.Text
        sql = "Update SINHVIEN Set MaSV='" + msv + "',HoTen=N'" + ht + "',MaLop'" + ml + "',GioiTinh=N'" + gt + "',NgaySinh'" + ns + "',diachi=N'" + dc + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLSinhVien()
        DataGridView1.DataSource = dt
        txtmasv.DataBindings.Clear()
        txtmasv.DataBindings.Add("text", dt, "MaSV")
        txthoten.DataBindings.Clear()
        txthoten.DataBindings.Add("text", dt, "HoTen")
        txtmalop.DataBindings.Clear()
        txtmalop.DataBindings.Add("text", dt, "MaLop")
        txtgioitinh.DataBindings.Clear()
        txtgioitinh.DataBindings.Add("text", dt, "GioiTinh")
        txtngaysinh.DataBindings.Clear()
        txtngaysinh.DataBindings.Add("text", dt, "NgaySinh")
        txtdiachi.DataBindings.Clear()
        txtdiachi.DataBindings.Add("text", dt, "DiaChi")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim msv As String = txtmasv.Text
        Dim ht As String = txthoten.Text
        Dim ml As String = txtmalop.Text
        Dim gt As String = txtgioitinh.Text
        Dim ns As String = txtngaysinh.Text
        Dim dc As String = txtdiachi.Text
        sql = "delete from SINHVIEN where MaSV='" + msv + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLSinhVien()
        DataGridView1.DataSource = dt
        txtmasv.DataBindings.Clear()
        txtmasv.DataBindings.Add("text  ", dt, "MaSV")
        txthoten.DataBindings.Clear()
        txthoten.DataBindings.Add("text", dt, "HoTen")
        txtmalop.DataBindings.Clear()
        txtmalop.DataBindings.Add("text", dt, "MaLop")
        txtgioitinh.DataBindings.Clear()
        txtgioitinh.DataBindings.Add("text", dt, "GioiTinh")
        txtngaysinh.DataBindings.Clear()
        txtngaysinh.DataBindings.Add("text", dt, "NgaySinh")
        txtdiachi.DataBindings.Clear()
        txtdiachi.DataBindings.Add("text", dt, "DiaChi")
    End Sub
End Class