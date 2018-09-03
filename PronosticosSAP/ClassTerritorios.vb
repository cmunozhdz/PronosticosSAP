Imports System.Data.SqlClient



Public Class ClassTerritorios
#Region "Declaracion de Variables"
    Private strClave As String
    Private strDescripcion As String
    Private strStatus As String
    Private pstrEstatusProceso As String
    Private pLongId As Long
#End Region
    

#Region "Constructores"
    ''' <summary>
    ''' Inicializa el objeto con valores vacios
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        pLongId = 0
        strClave = String.Empty
        strDescripcion = String.Empty
        strStatus = "A"
        pstrEstatusProceso = String.Empty



    End Sub
    ''' <summary>
    ''' Inicializa el objeto con datos definidos desde el cliente
    ''' </summary>
    ''' <param name="pStrClave">Clave a asignar</param>
    ''' <param name="pstrDescripcion">Descripcion </param>
    ''' <param name="pstrStatus">Estatus</param>
    ''' <remarks></remarks>
    Sub New(ByVal pStrClave As String, ByVal pstrDescripcion As String, ByVal pstrStatus As String)
        pLongId = 0

        strClave = pStrClave
        strDescripcion = pstrDescripcion
        strStatus = pstrStatus

    End Sub

#End Region



#Region "Metodos de Acceso a Datos"
    ''' <summary>
    ''' Agrega un registro nuevo a la base de datos
    ''' </summary>
    ''' <returns>El Identificador Unico</returns>
    ''' <remarks>Validar el Estatus de proceso en caso de que haya alguna falla</remarks>
    Public Function Insertar() As Boolean
        Dim mCon As SqlClient.SqlConnection = Nothing

        Dim mBolStatus As Boolean
        Try

            'Dim mTa As SapForecastDataSetTableAdapters.CONSULTA_TERRITORIOSBYCLAVETableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_TERRITORIOSBYCLAVETableAdapter
            'Dim mTd As SapForecastDataSet.CONSULTA_TERRITORIOSBYCLAVEDataTable = New SapForecastDataSet.CONSULTA_TERRITORIOSBYCLAVEDataTable
            mCon = DjpSap.Dac.mConexion


            Dim mCmd As SqlCommand = New SqlCommand("CATALOGOS.INSERTA_TERRITORIOS", mCon)
            mCmd.CommandType = System.Data.CommandType.StoredProcedure
            Dim mRet As New System.Data.SqlClient.SqlParameter()
            mRet.Direction = ParameterDirection.ReturnValue
            mCmd.Parameters.Add(mRet)
            mCmd.Parameters.AddWithValue("@ID", Me.Id)
            mCmd.Parameters.AddWithValue("@CLAVE", Me.Clave)
            mCmd.Parameters.AddWithValue("@DESCRIPCION", Me.Descripcion.ToUpper)
            mCmd.Parameters.AddWithValue("@ESTATUS", Me.Status)
            mCmd.ExecuteNonQuery()

            pLongId = mRet.Value
            pstrEstatusProceso = String.Empty


            mBolStatus = True

        Catch ex As Exception
            pstrEstatusProceso = ex.Message

            mBolStatus = False
        Finally
            If IsNothing(mCon) = False Then

                mCon.Close()

            End If
            mCon = Nothing

        End Try
        Return mBolStatus

    End Function
    ''' <summary>
    ''' Guarda en la base de datos un registro prexistente 
    ''' </summary>
    ''' <param name="pStatusAnterior">Estatus del registro que tenia la ultima vez que se leyo para garantizar que otro usuario no lo ha modificado</param>
    ''' <returns>Verdadero cuando lo actualiza, Falso en caso contrario</returns>
    ''' <remarks>revisar la propieddd Estatus proceso para ver la causa que no lo guardo</remarks>
    Public Function Actualizar(ByVal pStatusAnterior As String)
        Try

            'Dim mTa As SapForecastDataSetTableAdapters.CONSULTA_TERRITORIOSBYCLAVETableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_TERRITORIOSBYCLAVETableAdapter
            'Dim mTd As SapForecastDataSet.CONSULTA_TERRITORIOSBYCLAVEDataTable = New SapForecastDataSet.CONSULTA_TERRITORIOSBYCLAVEDataTable
            'mTa.Fill(mTd, Me.Id)

            'mTa.Update(Me.Id, Me.Clave, Me.Descripcion.ToUpper, Me.Status, pStatusAnterior)
            Return True
        Catch ex As Exception
            pstrEstatusProceso = ex.Message

            Return False
        End Try









    End Function
    ''' <summary>
    ''' Lee la base de datos  
    ''' </summary>
    ''' <param name="pStrClave">Clave del territorio a leer</param>
    ''' <remarks>Actualiza las propiedades del objeto</remarks>
    Public Sub Consultar(ByVal pStrClave As String)
        pstrEstatusProceso = String.Empty
        Try

            'Dim mTa As SapForecastDataSetTableAdapters.CONSULTA_TERRITORIOSBYCLAVETableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_TERRITORIOSBYCLAVETableAdapter
            'Dim mTd As SapForecastDataSet.CONSULTA_TERRITORIOSBYCLAVEDataTable = New SapForecastDataSet.CONSULTA_TERRITORIOSBYCLAVEDataTable
            'mTa.Fill(mTd, pStrClave)
            'If mTd.Rows.Count > 0 Then
            '    With mTd.Rows
            '        strClave = .Item(0)("CLAVE")
            '        strDescripcion = .Item(0)("Descripcion")
            '        strStatus = .Item(0)("Estatus")
            '        Id = .Item(0)("Id")



            '    End With
            'Else
            '    pstrEstatusProceso = "Territorio No existe"
            'End If
        Catch ex As Exception
            pstrEstatusProceso = ex.Message

        End Try





    End Sub
    Public Sub Consultar(ByVal pstrAgente As String, ByVal pstrClave As String)
        Dim Td As SapForecastDataSet.CONSULTA_ZONAXAGENTEDataTable = New SapForecastDataSet.CONSULTA_ZONAXAGENTEDataTable

        Dim Ta As SapForecastDataSetTableAdapters.CONSULTA_ZONAXAGENTETableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_ZONAXAGENTETableAdapter
        Dim intRows = Ta.Fill(Td, pstrAgente)
        If intRows > 0 Then
            For Each mRow As SapForecastDataSet.CONSULTA_ZONAXAGENTERow In Td.Rows
                Me.Clave = mRow.CLAVEZONA
                Me.Descripcion = mRow.ZONADESC


            Next
        End If




    End Sub



#End Region
#Region "Propiedades"



    Public Property Clave As String
        Get
            Return strClave

        End Get
        Set(ByVal value As String)
            strClave = Trim(value)
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return strDescripcion
        End Get
        Set(ByVal value As String)
            strDescripcion = value

        End Set

    End Property
    Public Property Status As String
        Get
            Return strStatus
        End Get
        Set(ByVal value As String)
            strStatus = value
        End Set
    End Property
    Public Property Id As Long
        Get
            Return pLongId
        End Get
        Set(ByVal value As Long)
            pLongId = value
        End Set
    End Property
    Public ReadOnly Property EstatusProceso As String


        Get
            Return pstrEstatusProceso
        End Get

    End Property

#End Region

End Class
