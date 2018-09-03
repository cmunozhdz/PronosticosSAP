Imports System.IO
Imports System.Runtime.Serialization

<Serializable()> Public Class ClassPronosticos
    Dim mPstrId As String
    Dim pStrPeriodo As String
    Dim pDtFechaInicial As Date
    Dim pDtFechaFinal As Date
    Dim pStrDescPronostico As String
    <NonSerialized()> Dim mBolFound As Boolean 'Indica que el pronostico se busco en el catalogo y se encontro
    <NonSerialized()> Dim mAgente As ClassVendedor

    Public Property Id As Long
        Get
            Return mPstrId
        End Get
        Set(ByVal value As Long)
            mPstrId = value
        End Set
    End Property
    Public Property Agente As ClassVendedor
        Get
            Return mAgente
        End Get
        Set(ByVal value As ClassVendedor)
            mAgente = value

        End Set
    End Property
    Public Property Periodo As String
        Get
            Return pStrPeriodo
        End Get
        Set(ByVal value As String)
            pStrPeriodo = value
        End Set
    End Property
    Public Property PeriodoInicial As Date
        Get
            Return pDtFechaInicial

        End Get
        Set(ByVal value As Date)
            pDtFechaInicial = value
        End Set
    End Property

    Public Property PeriodoFinal As Date
        Get
            Return pDtFechaFinal
        End Get
        Set(ByVal value As Date)
            pDtFechaFinal = value
        End Set
    End Property
    Public Property NewProperty As String
        Get
            Return "MyNewProperty"
        End Get
        Set(ByVal value As String)
            Dim pNew = "Property"
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return pStrDescPronostico
        End Get
        Set(ByVal value As String)
            pStrDescPronostico = value
        End Set
    End Property
    Public ReadOnly Property ExisteCatalogo() As Boolean

        Get
            Return mBolFound
        End Get

    End Property

    Public Function ConsultarCatalogo(ByVal IdPronostico As Integer) As Boolean

        Dim mBolOk As Boolean = False
        Dim mta As SapForecastDataSetTableAdapters.CONSULTA_MAESTROPRONOSTICOSBYIDTableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_MAESTROPRONOSTICOSBYIDTableAdapter()
        Dim mDt As SapForecastDataSet.CONSULTA_MAESTROPRONOSTICOSBYIDDataTable = New SapForecastDataSet.CONSULTA_MAESTROPRONOSTICOSBYIDDataTable
        mta.FillById(mDt, IdPronostico)
        Me.mBolFound = False
        For Each mRow As DataRow In mDt.Rows
            Me.mBolFound = True

            Me.mPstrId = mRow("IDPRONOSTICO")
            Me.mAgente = New ClassVendedor
            Me.mAgente.Clave = Trim(mRow("CLAVEAGENTE"))
            Me.Agente.ConsultarCatalogo(Me.mAgente.Clave, Nothing, Nothing, Nothing)
            Me.pDtFechaInicial = mRow("SMDINICIO")
            Me.pDtFechaFinal = mRow("SMDFIN")
            Me.pStrPeriodo = Trim(mRow("TIPOPERIODO"))
            Me.pStrDescPronostico = Trim(mRow("DESCRIPCION"))
            mBolOk = True
        Next
        mta.Dispose()

        Return mBolOk

    End Function


End Class
