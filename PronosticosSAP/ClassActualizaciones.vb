Imports System.Data.SqlClient
Namespace DjpSap

    Public Class ClassActualizaciones
        Private pStrVersionAp As String
        Private pStrVersionDb As String
        ''' <summary>
        ''' Verifica que la version de la base de datos y la del  sistema sean iguales.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function VerificaVersion() As Boolean
            Dim mBolVerificaVersion As Boolean = False
            'Dim mStrVersion As String = "000"
            pStrVersionAp = "000"
            Try
                pStrVersionAp = My.Settings.VersionDb
                Dim mObjCon As DjpSap.Dac = New DjpSap.Dac
                Dim mCon As SqlConnection = DjpSap.Dac.mConexion
                Dim mCmd As SqlCommand = New SqlCommand
                Dim mRdr As SqlDataReader

                Using mCon
                    With mCmd
                        .Connection = mCon
                        .CommandType = System.Data.CommandType.StoredProcedure
                        .CommandText = "CONFIGURACION.CONSULTA_CONFIGURACION"
                        .Parameters.AddWithValue("@CLAVE", "00001")
                        mRdr = .ExecuteReader(System.Data.CommandBehavior.CloseConnection)

                    End With

                    If mRdr.HasRows Then 'El registro se ha encontrado

                        While mRdr.Read
                            pStrVersionDb = mRdr("VALOR").ToString
                            mBolVerificaVersion = String.Compare(pStrVersionAp, pStrVersionDb) = 0
                        End While

                    End If
                    mRdr.Close()
                End Using

            Catch ex As SqlException
                Select Case ex.Number
                    Case 2812, 201
                        'Errores El procedimiento no existe, no hay permisos, parametros incorrectos.
                        ModComun.MsgError(ex.Message)
                    Case Else
                        ModComun.MsgError(ex.Number & ":" & ex.Message)
                End Select


            Catch ex As Exception
                ModComun.MsgError(ex.Message)
                mBolVerificaVersion = False
            End Try
            Return mBolVerificaVersion
        End Function
        ''' <summary>
        ''' Muestra la version requerida por la aplicacion.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property VersionAplicacion As String
            Get
                Return pStrVersionAp
            End Get
        End Property
        ''' <summary>
        ''' Muestra la version de la base de datos actual
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property VersionDb As String
            Get
                If Not String.IsNullOrEmpty(pStrVersionDb) Then

                    Return pStrVersionDb
                Else
                    Return "[SIN IDENTIFICAR]"
                End If

            End Get
        End Property
    End Class


End Namespace


