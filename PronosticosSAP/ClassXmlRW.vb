Imports System.IO
Namespace DjpSap
    Public Class ClassXmlRW
        Dim mFilew As StreamWriter
        Dim mFileR As StreamReader
        Dim mbolEstado As Boolean
        Dim mstrMensajeError As String
        Dim mStrTipoFile As Integer
        ''' <summary>
        ''' Constructor 
        ''' </summary>
        ''' <param name="pintAccion">Indica si se inicializara un objeto de lectura o escritura 0:Lectura: 1 escritura</param>
        ''' <param name="pStrfileName">Nombre del Xml que se va a generar</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pintAccion As Integer, ByVal pStrfileName As String)
            ''Determina la ruta del archivo que se va a serializar.
            Try
                'mFile = Nothing
                mbolEstado = False

                Dim mStrfile As String = System.Environment.GetEnvironmentVariable("temp")
                If String.IsNullOrEmpty(mStrfile) Then
                    'La variable de de entorno no existe por lo tanto debe tomar la ruta de ejecucion de la aplicacion
                    mStrfile = Application.StartupPath

                End If
                If Not mStrfile.EndsWith("\") Then
                    mStrfile = mStrfile & "\"
                End If
                'verifica que el directorio existe
                Dim mDir As DirectoryInfo = New DirectoryInfo(mStrfile)
                If mDir.Exists Then
                    'El directorio Existe
                    mStrfile = mStrfile & pStrfileName & ".xml"
                    If pintAccion = 0 Then
                        'Valida que el archivo existe
                        Dim mFileInfo As FileInfo = New FileInfo(mStrfile)

                        If mFileInfo.Exists Then
                            mFileR = New StreamReader(mStrfile)

                        End If
                    Else
                        mFilew = New StreamWriter(mStrfile)

                    End If
                    
                    mStrTipoFile = pintAccion
                    mbolEstado = True

                Else
                    Me.mstrMensajeError = "El Directorio inexistente:" & mStrfile
                End If

            Catch ex As Exception
                mbolEstado = False
                Me.mstrMensajeError = ex.Message

            End Try
        End Sub

        Protected Overrides Sub Finalize()
            'MyBase.Finalize()
            If Not IsNothing(mFilew) Then
                mFilew.Close()
            End If
            If Not IsNothing(mFileR) Then
                mFileR.Close()
            End If

        End Sub
        Public Function xmlWriter() As StreamWriter
            Return mFilew

        End Function
        Public Function xmlReader() As StreamReader
            Return mFileR
        End Function
    End Class
End Namespace