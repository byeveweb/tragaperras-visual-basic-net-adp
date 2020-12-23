Public Class Form2

    Dim CrtlAdo As New ControlADO
    Private Sub Enviar_Click(sender As Object, e As EventArgs) Handles Enviar.Click
        CrtlAdo.NombreJugador = TextBox1.Text
        MsgBox(CrtlAdo.NombreJugador)
    End Sub

End Class