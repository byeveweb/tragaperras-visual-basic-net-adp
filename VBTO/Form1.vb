Public Class Form1

    Dim CrtlAdo As New ControlADO

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Partidas_Combinaciones' 
        Me.Partidas_CombinacionesTableAdapter.Fill(Me.Database1DataSet.Partidas_Combinaciones)
    End Sub



    Private Sub PartidaIni_Click(sender As Object, e As EventArgs) Handles PartidaIni.Click

        CrtlAdo.IniciarPartida()
        CreditoIni.Text = CrtlAdo.Credito
        HoraIni.Text = CrtlAdo.Hora
        NumJuegos.Text = CrtlAdo.NumJuegos
        PrecioJugada.Text = CrtlAdo.PrecioJugada
        CreditoActual.Text = CrtlAdo.CreditoFin
        NombreJugador.Text = CrtlAdo.NombreJugador

    End Sub

    Private Sub NewJugada_Click(sender As Object, e As EventArgs) Handles NewJugada.Click



        If CreditoIni.Text = "" Or CreditoIni.Text = "0" Then
            MsgBox("Por favor, inicie la partida")
        Else
            CrtlAdo.NuevoJuego()
            CreditoActual.Text = CrtlAdo.CreditoFin
            NumJuegos.Text = CrtlAdo.NumJuegos
            CrtlAdo.RefresData(DataGridView1)

        End If

    End Sub

    Private Sub FinPar_Click(sender As Object, e As EventArgs) Handles FinPar.Click
        If CreditoIni.Text = "" Or CreditoIni.Text = "0" Then
            MsgBox("Es necesario que inicie una partida")
        Else
            CrtlAdo.FinPartida()
            Reset()
        End If
        Reset()


    End Sub

    Public Sub Reset()
        CreditoIni.Text = 0
        NumJuegos.Text = 0
        CreditoActual.Text = 0
        NombreJugador.Text = ""
        HoraIni.Text = ""
    End Sub


End Class
