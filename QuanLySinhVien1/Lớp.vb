Public Class Lớp
    Private Sub Lớp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketnoi()
        Dim dt As DataTable
        dt = DLLop()
        DataGridView1.DataSource = dt
        txtmalop.DataBindings.Clear()
        txtmalop.DataBindings.Add("text", dt, "MaLop")
        txttenlop.DataBindings.Clear()
        txttenlop.DataBindings.Add("text", dt, "TenLop")
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txtkhoahoc.DataBindings.Clear()
        txtkhoahoc.DataBindings.Add("text", dt, "KhoaHoc")
        txthedt.DataBindings.Clear()
        txthedt.DataBindings.Add("text", dt, "HeDT")
        txtnamnhaphoc.DataBindings.Clear()
        txtnamnhaphoc.DataBindings.Add("text", dt, "NamNhapHoc")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtmalop.Clear()
        txttenlop.Clear()
        txtmanganh.Clear()
        txtkhoahoc.Clear()
        txthedt.Clear()
        txtnamnhaphoc.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ml As String = txtmalop.Text
        Dim tl As String = txttenlop.Text
        Dim mn As String = txtmanganh.Text
        Dim kh As String = txtkhoahoc.Text
        Dim hdt As String = txthedt.Text
        Dim nh As String = txtnamnhaphoc.Text
        sql = "insert into LOP(MaLop,TenLop,MaNganh,KhoaHoc,HeDT,NamNhapHoc) values('" + ml + "',N'" + tl + "','" + mn + "','" + kh + "','" + hdt + "','" + nh + "')"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLNganh()
        DataGridView1.DataSource = dt
        txtmalop.DataBindings.Clear()
        txtmalop.DataBindings.Add("text", dt, "MaLop")
        txttenlop.DataBindings.Clear()
        txttenlop.DataBindings.Add("text", dt, "TenLop")
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txtkhoahoc.DataBindings.Clear()
        txtkhoahoc.DataBindings.Add("text", dt, "KhoaHoc")
        txthedt.DataBindings.Clear()
        txthedt.DataBindings.Add("text", dt, "HeDT")
        txtnamnhaphoc.DataBindings.Clear()
        txtnamnhaphoc.DataBindings.Add("text", dt, "NamNhapHoc")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim ml As String = txtmalop.Text
        Dim tl As String = txttenlop.Text
        Dim mn As String = txtmanganh.Text
        Dim kh As String = txtkhoahoc.Text
        Dim hdt As String = txthedt.Text
        Dim nh As String = txtnamnhaphoc.Text
        sql = "Update LOP set MaLop='" + ml + "',TenLop=N'" + tl + "',MaNganh'" + mn + "',KhoaHoc'" + kh + "',HeDT=N'" + hdt + "',NamNhapHoc'" + nh + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLNganh()
        DataGridView1.DataSource = dt
        txtmalop.DataBindings.Clear()
        txtmalop.DataBindings.Add("text", dt, "MaLop")
        txttenlop.DataBindings.Clear()
        txttenlop.DataBindings.Add("text", dt, "TenLop")
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txtkhoahoc.DataBindings.Clear()
        txtkhoahoc.DataBindings.Add("text", dt, "KhoaHoc")
        txthedt.DataBindings.Clear()
        txthedt.DataBindings.Add("text", dt, "HeDT")
        txtnamnhaphoc.DataBindings.Clear()
        txtnamnhaphoc.DataBindings.Add("text", dt, "NamNhapHoc")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ml As String = txtmalop.Text
        Dim tl As String = txttenlop.Text
        Dim mn As String = txtmanganh.Text
        Dim kh As String = txtkhoahoc.Text
        Dim hdt As String = txthedt.Text
        Dim nh As String = txtnamnhaphoc.Text
        sql = "delete from LOP where MaLop='" + ml + "'"
        cmd = New SqlClient.SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        ketnoi()
        Dim dt As DataTable
        dt = DLNganh()
        DataGridView1.DataSource = dt
        txtmalop.DataBindings.Clear()
        txtmalop.DataBindings.Add("text", dt, "MaLop")
        txttenlop.DataBindings.Clear()
        txttenlop.DataBindings.Add("text", dt, "TenLop")
        txtmanganh.DataBindings.Clear()
        txtmanganh.DataBindings.Add("text", dt, "MaNganh")
        txtkhoahoc.DataBindings.Clear()
        txtkhoahoc.DataBindings.Add("text", dt, "KhoaHoc")
        txthedt.DataBindings.Clear()
        txthedt.DataBindings.Add("text", dt, "HeDT")
        txtnamnhaphoc.DataBindings.Clear()
        txtnamnhaphoc.DataBindings.Add("text", dt, "NamNhapHoc")
    End Sub
End Class