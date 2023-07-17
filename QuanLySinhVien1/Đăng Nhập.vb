Public Class Form1
    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        If txttaikhoan.Text = "admin" And txtMaukhau.Text = "admin" Then
            Trang_Chủ.Show()
        ElseIf txttaikhoan.Text = "admin" Then
            MsgBox("Hãy nhập mật khẩu")
        ElseIf txtMaukhau.Text = "admin" Then
            MsgBox("Hãy nhập tài khoản")
        Else MsgBox("Đăng nhập không thành công ")
        End If
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        MsgBox("Bạn có muốn thoát không ? ", vbOKCancel)
        If MsgBoxResult.Ok Then
            End
        End If
    End Sub
End Class
