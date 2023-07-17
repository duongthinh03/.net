Public Class Môn_Học
    Private Sub Môn_Học_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketnoi()
        Dim dt As DataTable
        dt = DLMonHoc()
        DataGridView1.DataSource = dt
        txtmahp.DataBindings.Clear()
        txtmahp.DataBindings.Add("text", dt, "MaHP")
        txttenhp.DataBindings.Clear()
        txttenhp.DataBindings.Add("text", dt, "TenHP")
        txtsodvht.DataBindings.Clear()
        txtsodvht.DataBindings.Add("text", dt, "Sodvht")
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txthocky.DataBindings.Clear()
        txthocky.DataBindings.Add("text", dt, "HocKy")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtmahp.Clear()
        txttenhp.Clear()
        txtsodvht.Clear()
        txtmanganh.Clear()
        txthocky.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim mh As String = txtmahp.Text
        Dim tmh As String = txttenhp.Text
        Dim sdvht As String = txtsodvht.Text
        Dim mn As String = txtmanganh.Text
        Dim hk As String = txthocky.Text
        sql = "insert into HOCPHAN(MaHP,TenHP,Sodvht,MaNganh,HocKy) values ('" + mh + "',N'" + tmh + "','" + sdvht + "','" + mn + "','" + hk + "')"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLMonHoc()
        DataGridView1.DataSource = dt
        txtmahp.DataBindings.Clear()
        txtmahp.DataBindings.Add("text", dt, "MaHP")
        txttenhp.DataBindings.Clear()
        txttenhp.DataBindings.Add("text", dt, "TenHP")
        txtsodvht.DataBindings.Clear()
        txtsodvht.DataBindings.Add("text", dt, "Sodvht")
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txthocky.DataBindings.Clear()
        txthocky.DataBindings.Add("text", dt, "HocKy")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim mh As String = txtmahp.Text
        Dim tmh As String = txttenhp.Text
        Dim sdvht As String = txtsodvht.Text
        Dim mn As String = txtmanganh.Text
        Dim hk As String = txthocky.Text
        sql = "update HOCPHAN set MaHP='" + mh + "',TenHP=N'" + tmh + "',Sodvht='" + sdvht + "',MaNganh'" + mn + "',HocKy'" + hk + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLMonHoc()
        DataGridView1.DataSource = dt
        txtmahp.DataBindings.Clear()
        txtmahp.DataBindings.Add("text", dt, "MaHP")
        txttenhp.DataBindings.Clear()
        txttenhp.DataBindings.Add("text", dt, "TenHP")
        txtsodvht.DataBindings.Clear()
        txtsodvht.DataBindings.Add("text", dt, "Sodvht")
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txthocky.DataBindings.Clear()
        txthocky.DataBindings.Add("text", dt, "HocKy")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim mh As String = txtmahp.Text
        Dim tmh As String = txttenhp.Text
        Dim sdvht As String = txtsodvht.Text
        Dim mn As String = txtmanganh.Text
        Dim hk As String = txthocky.Text
        sql = "delete from HOCPHAN where MaHP='" + mh + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLMonHoc()
        DataGridView1.DataSource = dt
        txtmahp.DataBindings.Clear()
        txtmahp.DataBindings.Add("text", dt, "MaHP")
        txttenhp.DataBindings.Clear()
        txttenhp.DataBindings.Add("text", dt, "TenHP")
        txtsodvht.DataBindings.Clear()
        txtsodvht.DataBindings.Add("text", dt, "Sodvht")
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txthocky.DataBindings.Clear()
        txthocky.DataBindings.Add("text", dt, "HocKy")
    End Sub
End Class