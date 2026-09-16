Public Class FormPajak

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim Rp As Decimal
        Dim pajak As Decimal

        If Not Decimal.TryParse(txtRp.Text, Rp) Then
            MessageBox.Show("Masukkan pendapatan dengan format yang benar!")
            Return
        End If

        If Rp > 100000000 Then
            pajak = Rp * 30 / 100

        ElseIf Rp > 30000000 Then
            pajak = Rp * 20 / 100

        ElseIf Rp >= 5000000 Then
            pajak = Rp * 10 / 100

        Else
            pajak = 0
        End If

        MessageBox.Show(
            "Pendapatan : Rp. " & Rp.ToString("#,##0") &
            vbCrLf &
            "Pajak yang harus dibayar : Rp. " & pajak.ToString("#,##0"),
            "Hasil Perhitungan"
        )

    End Sub


    Private Sub txtRp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRp.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click

        Me.Close()

    End Sub

End Class