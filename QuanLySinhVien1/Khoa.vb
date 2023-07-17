Public Class Khoa
    Private Sub Khoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketnoi()
        Dim dt As DataTable
        dt = DLKhoa()
        DataGridView1.DataSource = dt
        txtmakhoa.DataBindings.Clear()
        txtmakhoa.DataBindings.Add("text", dt, "MaKhoa")
        txttenkhoa.DataBindings.Clear()
        txttenkhoa.DataBindings.Add("text", dt, "TenKhoa")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtmakhoa.Clear()
        txttenkhoa.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim mk As String = txtmakhoa.Text
        Dim tk As String = txttenkhoa.Text
        sql = "insert into KHOA(MaKhoa,TenKhoa) values('" + mk + "',N'" + tk + "')"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLKhoa()
        DataGridView1.DataSource = dt
        txtmakhoa.DataBindings.Clear()
        txtmakhoa.DataBindings.Add("text", dt, "MaKhoa")
        txttenkhoa.DataBindings.Clear()
        txttenkhoa.DataBindings.Add("text", dt, "TenKhoa")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim mk As String = txtmakhoa.Text
        Dim tk As String = txttenkhoa.Text
        sql = "Update KHOA set MaKhoa='" + mk + "',TenKhoa=N'" + tk + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLKhoa()
        DataGridView1.DataSource = dt
        txtmakhoa.DataBindings.Clear()
        txtmakhoa.DataBindings.Add("text", dt, "MaKhoa")
        txttenkhoa.DataBindings.Clear()

        txttenkhoa.DataBindings.Add("text", dt, "TenKhoa")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim mk As String = txtmakhoa.Text
        Dim tk As String = txttenkhoa.Text
        sql = "delete from KHOA where Makhoa='" + mk + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLKhoa()
        DataGridView1.DataSource = dt
        txtmakhoa.DataBindings.Clear()
        txtmakhoa.DataBindings.Add("text", dt, "MaKhoa")
        txttenkhoa.DataBindings.Clear()
        txttenkhoa.DataBindings.Add("text", dt, "TenKhoa")
    End Sub
End Class