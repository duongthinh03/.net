Public Class Ngành
    Private Sub Ngành_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketnoi()
        Dim dt As DataTable
        dt = DLNganh()
        DataGridView1.DataSource = dt
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txttennganh.DataBindings.Clear()
        txttennganh.DataBindings.Add("text", dt, "TenNganh")
        txtmakhoa.DataBindings.Clear()
        txtmakhoa.DataBindings.Add("text", dt, "MaKhoa")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtmakhoa.Clear()
        txtmanganh.Clear()
        txttennganh.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim mn As String = txtmanganh.Text
        Dim tn As String = txttennganh.Text
        Dim mk As String = txtmakhoa.Text
        sql = "insert into NGANH(MaNganh,TenNganh,MaKhoa) values('" + mn + "',N'" + tn + "','" + mk + "')"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLNganh()
        DataGridView1.DataSource = dt
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txttennganh.DataBindings.Clear()
        txttennganh.DataBindings.Add("text", dt, "TenNganh")
        txtmakhoa.DataBindings.Clear()
        txtmakhoa.DataBindings.Add("text", dt, "MaKhoa")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim mn As String = txtmanganh.Text
        Dim tn As String = txttennganh.Text
        Dim mk As String = txtmakhoa.Text
        sql = "Update NGANH set MaNganh='" + mn + "',TenNganh=N'" + tn + "',MaKhoa='" + mk + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLNganh()
        DataGridView1.DataSource = dt
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txttennganh.DataBindings.Clear()
        txttennganh.DataBindings.Add("text", dt, "TenNganh")
        txtmakhoa.DataBindings.Clear()
        txtmakhoa.DataBindings.Add("text", dt, "MaKhoa")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim mn As String = txtmanganh.Text
        Dim tn As String = txttennganh.Text
        Dim mk As String = txtmakhoa.Text
        sql = "delete from NGANH where MaNganh='" + mn + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLNganh()
        DataGridView1.DataSource = dt
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txttennganh.DataBindings.Clear()
        txttennganh.DataBindings.Add("text", dt, "TenNganh")
        txtmakhoa.DataBindings.Clear()
        txtmakhoa.DataBindings.Add("text", dt, "MaKhoa")
    End Sub
End Class