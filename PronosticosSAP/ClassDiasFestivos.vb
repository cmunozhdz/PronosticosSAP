Imports System.Collections.Generic.Dictionary(Of Date, String)
Imports System.Data.SqlClient
Imports System.Data
Namespace DjpSap
    Public Class ClassDiasFestivos

        Dim mColDiasFestivos As List(Of Date) = New List(Of Date)

        Private mFechaTmp As Date

        Private mbolError As Boolean
        ''' <summary>
        ''' Inicializa la lista de dias festivos del mes.
        ''' </summary>
        ''' <param name="Mes">Mes a consultar</param>
        ''' <param name="Anio">Año de Consulta</param>
        ''' <remarks>La propiedad hay Error Value true cuando no logra incializar</remarks>

        Sub New(ByVal Mes As Integer, ByVal Anio As Integer)

            Try
                'Dim mCon As SqlConnection = DjpSap.Dac.mConexion
                Dim mCmd As SqlCommand = New SqlCommand()
                'mColDiasFestivos = New List(Of Date)

                With mCmd
                    .CommandType = CommandType.StoredProcedure
                    .Connection = DjpSap.Dac.mConexion
                    .CommandText = "CATALOGOS.CONSULTA_DIASFESTIVOSBYMES"
                    .Parameters.AddWithValue("@MES", Mes)
                    .Parameters.AddWithValue("@ANIO", Anio)
                    Dim mReader As SqlDataReader = .ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                    If mReader.HasRows Then
                        While mReader.Read
                            Dim mFecha As Date = DateSerial(mReader("ANIO"), mReader("MES"), mReader("DIA"))
                            mColDiasFestivos.Add(mFecha)
                        End While
                        mReader.Close()
                    End If
                End With
                mCmd.Dispose()
                mbolError = False
            Catch ex As Exception
                mbolError = True
            End Try

        End Sub
        ReadOnly Property HayError As Boolean
            Get
                Return Me.mbolError
            End Get
        End Property

        Private Function EsFestivo(ByVal Fecha As Date)
            If HayError = False Then
                Return mColDiasFestivos.Contains(Fecha)
            Else
                Return False 'El catalogo de dias festivo no tiene datos
            End If


        End Function

        
        ''' <summary>
        ''' Agrega dias habiles 
        ''' </summary>
        ''' <param name="FechaIni">Fecha Inicial </param>
        ''' <param name="Dias">Dias a sumar</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function DateAddHabiles(ByVal FechaIni As Date, ByVal Dias As Integer) As Date
            Dim DiasTmp As Integer = 0
            Dim mFechaTmp As Date = FechaIni
            'Valida si el primer dia del mes es habil esto quiere decir que ha trancurrido el primer dia.

            If (mFechaTmp.DayOfWeek >= DayOfWeek.Monday And mFechaTmp.DayOfWeek <= DayOfWeek.Friday) AndAlso Me.EsFestivo(mFechaTmp) = False Then
                'El dia es habil por lo tanto le suma otro
                DiasTmp += 1

            End If

            While DiasTmp < Dias
                mFechaTmp = mFechaTmp.AddDays(1)
                If (mFechaTmp.DayOfWeek >= DayOfWeek.Monday And mFechaTmp.DayOfWeek <= DayOfWeek.Friday) AndAlso Me.EsFestivo(mFechaTmp) = False Then
                    'El dia es habil por lo tanto le suma otro
                    DiasTmp += 1

                End If

            End While
            Return mFechaTmp

        End Function


    End Class
End Namespace

