Public Class EnviarCorreo

    Private Sub TextBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles TxTCorreo.MouseDown
        TxTCorreo.Text = ""
    End Sub

    Private Sub TxTCorreo_TextChanged(sender As Object, e As EventArgs) Handles TxTCorreo.TextChanged

    End Sub
End Class