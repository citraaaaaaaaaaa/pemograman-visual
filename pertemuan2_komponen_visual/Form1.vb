Public Class Form1
    Private Sub lblNama_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub lblNIM_Click(sender As Object, e As EventArgs) Handles lblNIM.Click

    End Sub

    Private Sub lblKOM_Click(sender As Object, e As EventArgs) Handles lblKOM.Click

    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Halo Dunia!" & vbCrLf &
                "Nama   : " & txtNama.Text & vbCrLf &
                "NIM    : " & txtNIM.Text & vbCrLf &
                "KOM    : " & txtKOM.Text
)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblNIM.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtNama.Clear()
        txtKOM.Clear()
        txtNIM.Clear()
    End Sub
End Class
