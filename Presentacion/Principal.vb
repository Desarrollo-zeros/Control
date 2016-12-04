Public Class Principal

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        ListadoDeUsarios.Show()

    End Sub

    Private Sub LinkProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinkProductosToolStripMenuItem.Click
        Process.Start("http://www.microsoft.com")
    End Sub
End Class