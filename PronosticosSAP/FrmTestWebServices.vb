Imports System.IO

Public Class FrmTestWebServices

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'Dim mCte As WsCteRecibeArchivos.WsRecibeArchivos = New WsCteRecibeArchivos.WsRecibeArchivos
            Dim mCte As lhWsCteRecibeArchivos.WsRecibeArchivos = New lhWsCteRecibeArchivos.WsRecibeArchivos
            Dim mStr As System.Text.StringBuilder = New System.Text.StringBuilder()
            mStr.Append(mCte.Echo() & "<br>" & Environment.NewLine)
            'mStr.Append(mCte.Url)
            Me.TextBox1.Text = Replace(mStr.ToString, "<br>", Environment.NewLine)






        Catch ex As Exception
            MsgBox(ex.Message)

        End Try





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim mStrSource = Me.TextBox1.Text
            Me.TextBox1.Text = "Iniciando..." & Environment.NewLine

            Me.TextBox1.Text = Me.TextBox1.Text & "Abriendo archivo origen ..." & Environment.NewLine

            Dim objfilestream As FileStream = New FileStream(mStrSource, FileMode.Open, FileAccess.Read)

            Dim FileSise As Long = objfilestream.Length
            Me.TextBox1.Text = Me.TextBox1.Text & "Tamaño del archivo..." & FileSise & Environment.NewLine
            Dim mybytearray As Byte()
            ReDim mybytearray(FileSise)

            Me.TextBox1.Text = Me.TextBox1.Text & "Leyendo ..." & Environment.NewLine

            objfilestream.Read(mybytearray, 0, FileSise)

            Me.TextBox1.Text = Me.TextBox1.Text & "Conectando a web service" & Environment.NewLine

            'Dim mCte As WsCteRecibeArchivos.WsRecibeArchivos = New WsCteRecibeArchivos.WsRecibeArchivos
            Dim mCte As lhWsCteRecibeArchivos.WsRecibeArchivos = New lhWsCteRecibeArchivos.WsRecibeArchivos


            Me.TextBox1.Text = Me.TextBox1.Text & "Envinado a web service" & Environment.NewLine

            mCte.SaveFile(mybytearray, "tempFile" & String.Format("{0:yyymmdd_hhmmss}", Today) & ".TXT", "cmunoz@polakgrupo.com", "S", FileSise, "Proceso enviado manualmente", "A")
            objfilestream.Close()
            Me.TextBox1.Text = Me.TextBox1.Text & "Proceso terminado" & Environment.NewLine

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        
    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class