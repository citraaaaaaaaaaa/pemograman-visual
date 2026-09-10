Imports System.Drawing.Drawing2D
Imports System.Windows

Public Class Form1
    Private staffNama As String = "Miaw"
    Private staffNim As String = "241712079"

    Private managerNama As String = "Miaw"
    Private managerNim As String = "241712079"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRole.SelectedIndex = 0
        pic1.SizeMode = PictureBoxSizeMode.Zoom

        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pic1.Width, pic1.Height)
        pic1.Region = New Region(path)
    End Sub

    Private Sub cbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRole.SelectedIndexChanged
        If cbRole.SelectedItem Is Nothing Then
            Return
        End If

        If cbRole.SelectedItem.ToString() = "Staff" Then
            pic1.Image = Image.FromFile("Assets\b.jpg")
        Else
            pic1.Image = Image.FromFile("Assets\p.jpg")
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cbRole.SelectedItem Is Nothing Then
            MessageBox.Show("Silakan pilih role terlebih dahulu!")
            Return
        End If

        Dim role As String = cbRole.SelectedItem.ToString()
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNim.Text.Trim()

        If role = "Staff" Then

            If nama.Equals(staffNama, StringComparison.OrdinalIgnoreCase) AndAlso nim = staffNim Then
                Dim FormPajak As New FormPajak()
                FormPajak.Show()
                Me.Hide()
                txtNama.Clear()
                txtNim.Clear()
            Else
                MessageBox.Show("Masukkan data Staff dengan benar!")
            End If

        Else

            If nama.Equals(managerNama, StringComparison.OrdinalIgnoreCase) AndAlso nim = managerNIM Then
                Dim form2 As New FormPajak()
                FormPajak.Show()
                Me.Hide()
                MessageBox.Show("Login berhasil sebagai Manager!")
            Else
                MessageBox.Show("Masukkan data Manager dengan benar!")
            End If

        End If

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
End Class
