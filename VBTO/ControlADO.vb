Imports System.Data.SqlClient


Public Class ControlADO
    ':::Variable String de Conexión
    Dim Conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus_\source\repos\ladefi\Database1.mdf;Integrated Security=True")
    ':::Variables Lógica del Juego
    Public Credito As Integer = 5000
    Public CreditoFin As Integer
    Public Hora As String = Now.ToString("HH:mm:ss")
    Public NumJuegos As Integer = 0
    Public PrecioJugada As Integer = 1015
    Public NombreJugador As String

    ':::Función que refresca la tabla de combinaciones_partidas
    Public Sub RefresData(ByVal Tabla As DataGridView)

        Try
            Conn.Open()
            Dim ocmd As New SqlCommand()
            ocmd.CommandText = "select * from Partidas_Combinaciones"
            ocmd.Connection = Conn
            ocmd.ExecuteNonQuery()

            ':::Creamos el objeto DataTable que recibe la informacion del DataAdapter
            Dim DT As New DataTable
            ':::Creamos el objeto DataAdapter y le pasamos los dos parametros (Instruccion, conexión)
            Dim DA As New SqlDataAdapter("select * from Partidas_Combinaciones", Conn)
            ':::Pasamos la informacion del DataAdapter al DataTable mediante la propiedad Fill
            DA.Fill(DT)
            ':::Ahora mostramos los datos en el DataGridView
            Tabla.DataSource = DT
            MsgBox("Jugada finalizada correctamente")
            Conn.Close()
        Catch ex As Exception
            MsgBox("No se logro realizar la consulta por: " & ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
        End Try
    End Sub







    ':::Función que inicia lapartida
    Public Sub IniciarPartida()

        ':::Aquí cargamos la fecha y el crédito inicial en = PARTIDAS table
        Dim Message
        Message = "Por favor, introduzca su nombre"    ' Set prompt.
        ':::Display message, title, and default value.
        NombreJugador = InputBox(Message)
        CreditoFin = Credito


        Dim ocmd As New SqlCommand()
        ocmd.CommandType = System.Data.CommandType.Text
            ocmd.CommandText = "insert into Partidas(Hora, CreditoIni, CreditoFin )" + "values (@Hora, @CreditoIni, @CreditoFin)"
        ocmd.Connection = Conn

        Try

            Conn.Open()
            ocmd.Parameters.AddWithValue("@Hora", Hora)
            ocmd.Parameters.AddWithValue("@CreditoIni", Credito)
            ocmd.Parameters.AddWithValue("@CreditoFin", CreditoFin)

            ocmd.ExecuteNonQuery()
            Conn.Close()
            MsgBox("Bienvenido " + NombreJugador)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try



    End Sub

    Public Sub NuevoJuego()
        ':::Aquí cargamos el importe de cada jugada en PARTIDAS_COMBINACIONES, Impartida, el ID y la hora en la que se inicia

        CreditoFin = CreditoFin - PrecioJugada

        If CreditoFin >= 0 Then

            Dim ocmd As New SqlCommand()

            ocmd.CommandText = "insert into Partidas_Combinaciones(IdCombinacion, Hora)" + "values (@IdCombinacion, @Hora)"
            ocmd.Connection = Conn

            Try

                Conn.Open()
                ocmd.Parameters.AddWithValue("@IdCombinacion", NumJuegos)
                ocmd.Parameters.AddWithValue("@Hora", Hora)
                ocmd.ExecuteNonQuery()
                Conn.Close()
                NumJuegos += 1
                MsgBox("Tu crédito actual es : " & CreditoFin & ". El id de la combinacion es : " & NumJuegos)

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try


        Else
            MsgBox("Lo siento, no tiene suficientes créditos")
            CreditoFin = CreditoFin + PrecioJugada
            FinPartida()
        End If


    End Sub

    Public Sub FinPartida()

        ':::Aquí finalizamos la partida 
        ':::Almacenamos en la tabla IdCombinación Final, Nombre y Créditos

        Try
            Dim ocmd As New SqlCommand()
            ocmd.CommandType = System.Data.CommandType.Text
            ocmd.CommandText = "insert into Combinaciones(Nombre, Creditos)" + "values (@Nombre, @Creditos)"
            ocmd.Connection = Conn

            Conn.Open()
            ocmd.Parameters.AddWithValue("@Nombre", NombreJugador)
            ocmd.Parameters.AddWithValue("@Creditos", CreditoFin)
            ocmd.ExecuteNonQuery()
            Conn.Close()
            MsgBox("Ha finalizado la partida " & NombreJugador & " , con un crédito de  " & CreditoFin & " a las " & Hora)


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try



    End Sub

End Class
