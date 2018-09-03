Imports System.IO


Public Class ClassCteWebservices
    Dim pStrError As String
    Public ReadOnly Property myError() As String
        Get
            Return pStrError
        End Get

    End Property


    Public Function EnviarServer(ByVal pStrFileName As String, ByVal pstrRemitente As DjpSap.ClassUser, ByVal pParmetrosEntrada As String, ByVal NegocioPronostico As String) As Boolean
        Dim intBytesRead As Integer 'Determina el numero de bytes que se han leido 
        Dim intChunkSize As Integer 'Indica el tamaño de bytes a pasar en el stream
        Dim mybytearray As Byte() 'Contiene los bytes que van a ser enviados.
        Dim intChunks As Integer = 1  'Contador de los trozos de archivo que se han enviado
        Dim objfilestream As FileStream = Nothing

        Try

            objfilestream = New FileStream(pStrFileName, FileMode.Open, FileAccess.Read)
            'Abre el archivo que se va enviar por el web service.
            Dim mArrFileName() As String = Split(pStrFileName, "\")             'Separa el nombre de la ruta.
            Dim mArrTargetFile As String = pstrRemitente.UserName & "_" & mArrFileName(UBound(mArrFileName))   'Obteniendo el archivo destino

            Dim FileSise As Long = objfilestream.Length 'Tamaño en bytes del archivo a enviar


            intChunkSize = 1024 * My.Settings.TamanoBufferWeb  'Define el tamaño estandard de envio en nuestro caso 100 KB
            If FileSise < intChunkSize Then
                intChunkSize = FileSise
            End If

            ReDim mybytearray(intChunkSize - 1)                                 'Dimensiona el arreglo que 
            intBytesRead = objfilestream.Read(mybytearray, 0, intChunkSize)     'va a recibir los bytes del archivo




            'Dim mCte As WsCteRecibeArchivos.WsRecibeArchivos = New WsCteRecibeArchivos.WsRecibeArchivos()
            Dim mCte As lhWsCteRecibeArchivos.WsRecibeArchivos = New lhWsCteRecibeArchivos.WsRecibeArchivos

            Dim mbolBytesEnviados As Boolean = True
            Dim mLngBytesXEnviar As Long = 0
            Dim mStrEnviarMail As String = "N"
            '************
            '
            '************
            While intBytesRead > 0 And mbolBytesEnviados
                mLngBytesXEnviar += intChunkSize 'Indica el numero de bytes que se van a enviar
                If mLngBytesXEnviar = FileSise Then
                    mStrEnviarMail = "S"
                    'cuando llega al final del archivo solicitará en el envio de correo de confirmacion
                End If
                'Manda llamar el web service y en su caso devuelve un estado que indica si e envio o no
                mbolBytesEnviados = mCte.SaveFile(mybytearray, mArrTargetFile, pstrRemitente.Email, mStrEnviarMail, intChunks, pParmetrosEntrada, NegocioPronostico)

                If mbolBytesEnviados Then
                    intChunks += 1

                    If FileSise < (intChunkSize * intChunks) Then


                        intChunkSize = FileSise Mod (intChunkSize * (intChunks - 1))
                        ReDim mybytearray(intChunkSize - 1)
                    End If


                    intBytesRead = objfilestream.Read(mybytearray, 0, intChunkSize)

                Else
                    pStrError = mCte.GetError(String.Empty)


                End If

            End While
            objfilestream.Close()

            Return mbolBytesEnviados

        Catch ex As Exception
            'Response.Write(ex.Message)
            pStrError = ex.Message
            If Not IsNothing(objfilestream) Then
                objfilestream.Close()
            End If
            objfilestream = Nothing

            Return False


        End Try





    End Function



End Class

