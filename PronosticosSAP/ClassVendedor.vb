Imports System.Data.SqlClient

Public Class ClassVendedor
    Private mId As Long
    Private mStrClave As String

    Private mstrDescripcion As String
    Private mStrStatus As String
    Private mTerritorio As ClassTerritorios
    Private mStrError As String
    Private mstrNegocio As String
    Private mstrSociedad As String


    Public Sub New()
        mId = 0
        mTerritorio = New ClassTerritorios
    End Sub
    Public Sub New(ByVal pId As Long, ByVal pClave As String, ByVal pDescripcion As String, ByVal pTerritorio As String, ByVal pStatus As String)

        mId = pId
        mStrClave = pClave

        mstrDescripcion = pDescripcion

        mStrStatus = pStatus
        mTerritorio = New ClassTerritorios
        mTerritorio.Clave = pTerritorio


    End Sub
    Public Property AreaNegocios As String
        Get
            Return mstrNegocio
        End Get
        Set(ByVal value As String)
            mstrNegocio = value

        End Set
    End Property


    Public Property Territorio As ClassTerritorios
        Get
            Return mTerritorio
        End Get
        Set(ByVal value As ClassTerritorios)
            mTerritorio = value

        End Set

    End Property
    Public Property Descripcion As String
        Get
            Return mstrDescripcion

        End Get
        Set(ByVal value As String)
            mstrDescripcion = value
        End Set

    End Property


    Public Property Id As Long

        Get
            Return mId
        End Get
        Set(ByVal value As Long)
            mId = value
        End Set
    End Property

    Public Property Clave As String


        Get
            Return mStrClave

        End Get
        Set(ByVal value As String)
            mStrClave = value

        End Set
    End Property
    Public Property Estado() As String
        Get
            Return mStrStatus
        End Get
        Set(ByVal value As String)
            mStrStatus = value

        End Set
    End Property
    Public ReadOnly Property EstatusProceso As String
        Get
            Return mStrError

        End Get

    End Property

    Property Sociedad As String
        Get
            Return mstrSociedad
        End Get
        Set(ByVal value As String)
            mstrSociedad = value
        End Set
    End Property

#Region "AccesoDatos"
    ''' <summary>
    ''' Buscar el elmento en la base solo por la clave
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Para realizar una busqueda correcta actualizar la propiedad clave</remarks>
    Public Function ConsultarCatalogo() As Long
        Try
            Dim lngRows = ConsultarCatalogo(mStrClave, String.Empty, String.Empty, String.Empty)
            Return lngRows
        Catch ex As Exception
            mStrError = ex.Message
            Return -1

        End Try

    End Function
    ''' <summary>
    ''' Hace la consulta cuando se conocen clave, descripcion, territorio
    ''' </summary>
    ''' <param name="pstrClave"></param>
    ''' <param name="pstrDescipcion"></param>
    ''' <param name="pTerritorio"></param>
    ''' <param name="Status"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ConsultarCatalogo(ByVal pstrClave As String, ByVal pstrDescipcion As String, ByVal pTerritorio As String, ByVal Status As String) As Long
        Try
            Dim lngRows As Long
            Dim mTd As SapForecastDataSet.CONSULTA_AGENTESDataTable = FnGetDataTable(pstrClave, pstrDescipcion, pTerritorio, Status)

            lngRows = 0



            For Each mRow As DataRow In mTd.Rows
                lngRows = lngRows + 1

                mId = mRow.Item("ID").ToString()
                mStrClave = mRow.Item("CLAVEAGENTE").ToString()
                mstrDescripcion = mRow.Item("NOMBRE").ToString()
                'mTerritorio.Clave = mRow.Item("IDTERRITORIO").ToString
                mstrNegocio = mRow.Item("NEGOCIO").ToString
                mStrStatus = mRow.Item("STATUS").ToString



            Next mRow
            mTd = Nothing

            Return lngRows
        Catch ex As Exception
            mStrError = ex.Message
            Return -1
        End Try
        


    End Function

    Private Function FnGetDataTable(ByVal pClave As String, ByVal pNombre As String, ByVal pIdTerritorio As String, ByVal pstrStatus As String) As SapForecastDataSet.CONSULTA_AGENTESDataTable
        Dim mTd As SapForecastDataSet.CONSULTA_AGENTESDataTable = New SapForecastDataSet.CONSULTA_AGENTESDataTable
        Dim mTa As SapForecastDataSetTableAdapters.CONSULTA_AGENTESTableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_AGENTESTableAdapter
        mTa.Fill(mTd, pClave, pNombre, pstrStatus)
        Return mTd


    End Function


    Public Function Actualizar() As Boolean
        Try
            Dim mDt As SapForecastDataSet.CONSULTA_AGENTESDataTable = New SapForecastDataSet.CONSULTA_AGENTESDataTable
            Dim mTa As SapForecastDataSetTableAdapters.CONSULTA_AGENTESTableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_AGENTESTableAdapter

            Dim intRow As Integer = mTa.Update(mStrClave, mstrDescripcion, Me.mStrStatus)

            Return intRow = 1
        Catch ex As Exception
            mStrError = ex.Message
            Return False

        End Try


    End Function
    Public Function Insertar() As Boolean

        Dim lngProceso As Long = 0

        Try
            Dim mCon As SqlConnection = DjpSap.Dac.mConexion

            Dim mCmd As SqlCommand = New SqlCommand
            With mCmd
                .Connection = mCon
                .CommandType = CommandType.StoredProcedure
                .CommandText = "CATALOGOS.INSERTA_AGENTES"
                Dim mRet As SqlParameter = New SqlParameter
                mRet.Direction = System.Data.ParameterDirection.ReturnValue

                .Parameters.Add(mRet)

                .Parameters.AddWithValue("@CLAVEAGENTE", mStrClave)
                .Parameters.AddWithValue("@NOMBRE", mstrDescripcion)
                .Parameters.AddWithValue("@IDTERRITORIO", mTerritorio.Clave)
                .Parameters.AddWithValue("@STATUS", mStrStatus)

                .ExecuteNonQuery()
                lngProceso = mRet.Value
                If lngProceso > 0 Then
                    mId = lngProceso
                End If
            End With

        Catch ex As Exception
            mStrError = ex.Message
            lngProceso = 0

        End Try
        Return lngProceso <> 0


    End Function

#End Region

End Class
