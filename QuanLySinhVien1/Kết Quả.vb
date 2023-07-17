Public Class Kết_Quả
    Private Sub Kết_Quả_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketnoi()
        Dim dt As DataTable
        dt = DLKetQua()
        DataGridView1.DataSource = dt
        txtmsv.DataBindings.Clear()
        txtmsv.DataBindings.Add("text", dt, "MaSV")
        txtmhp.DataBindings.Clear()
        txtmhp.DataBindings.Add("text", dt, "MaHP")
        txtdiemhp.DataBindings.Clear()
        txtdiemhp.DataBindings.Add("text", dt, "DiemHP")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtmsv.Clear()
        txtmhp.Clear()
        txtdiemhp.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim msv As String = txtmsv.Text
        Dim mhp As String = txtmhp.Text
        Dim dhp As String = txtdiemhp.Text
        sql = "insert into DIEMHP(MaSV,MaHP,DiemHP) values ('" + msv + "','" + mhp + "','" + dhp + "')"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLKetQua()
        DataGridView1.DataSource = dt
        txtmsv.DataBindings.Clear()
        txtmsv.DataBindings.Add("text", dt, "MaSV")
        txtmhp.DataBindings.Clear()
        txtmhp.DataBindings.Add("text", dt, "MaHP")
        txtdiemhp.DataBindings.Clear()
        txtdiemhp.DataBindings.Add("text", dt, "DiemHP")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim msv As String = txtmsv.Text
        Dim mhp As String = txtmhp.Text
        Dim dhp As String = txtdiemhp.Text
        sql = "update HOCPHAN set MaSV='" + msv + "',MaHP='" + mhp + "',DiemHP'" + dhp + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLKetQua()
        DataGridView1.DataSource = dt
        txtmsv.DataBindings.Clear()
        txtmsv.DataBindings.Add("text", dt, "MaSV")
        txtmhp.DataBindings.Clear()
        txtmhp.DataBindings.Add("text", dt, "MaHP")
        txtdiemhp.DataBindings.Clear()
        txtdiemhp.DataBindings.Add("text", dt, "DiemHP")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim msv As String = txtmsv.Text
        Dim mhp As String = txtmhp.Text
        Dim dhp As String = txtdiemhp.Text
        sql = "delete from DIEMHP where MaSV='" + msv + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLKetQua()
        DataGridView1.DataSource = dt
        txtmsv.DataBindings.Clear()
        txtmsv.DataBindings.Add("text", dt, "MaSV")
        txtmhp.DataBindings.Clear()
        txtmhp.DataBindings.Add("text", dt, "MaHP")
        txtdiemhp.DataBindings.Clear()
        txtdiemhp.DataBindings.Add("text", dt, "DiemHP")
    End Sub
End Class