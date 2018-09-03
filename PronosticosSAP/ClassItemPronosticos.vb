Public Class ClassItemPronosticos
    Private mObjProducto As ClassProducto
    Private mLngPronostico As Long
    'Private mLngPeriodo As Long
    Private mDtPeriodo As Date
    Private mstrCentro As String
    'Private mStrAlmacen As String
    Private pAgente As ClassVendedor
    Private pDblCantidad As Double
    Private pDblCantidadReparto As Double
    Private pCliente As ClassCliente



    Public Sub New(ByVal idPronostico As Long, ByVal Periodo As Date, _
                   ByVal strCentro As String, ByVal pstrProducto As String, ByVal pstrAgente As String, ByVal pstrCliente As String, ByVal pCantidad As Double)
        mLngPronostico = idPronostico
        mDtPeriodo = Periodo
        mstrCentro = strCentro
        'mStrAlmacen = strAlmacen
        mObjProducto = New ClassProducto
        mObjProducto.Clave = pstrProducto
        pAgente = New ClassVendedor
        pAgente.Clave = pstrAgente
        pDblCantidad = pCantidad
        If Not String.IsNullOrEmpty(pstrCliente) Then
            pCliente = New ClassCliente
            pCliente.Clave = pstrCliente
        Else
            pCliente = Nothing
        End If

    End Sub
    Public Property Cantidad As Double
        Get
            Return pDblCantidad
        End Get
        Set(ByVal value As Double)
            pDblCantidad = value

        End Set
    End Property

    Public ReadOnly Property Agente As ClassVendedor
        Get
            Return pAgente
        End Get

    End Property

    Public Property Id() As Long
        Get
            Return mLngPronostico
        End Get
        Set(ByVal value As Long)
            mLngPronostico = value
        End Set
    End Property
    Public Property Periodo As Date
        Get
            Return mDtPeriodo
        End Get
        Set(ByVal value As Date)
            mDtPeriodo = value
        End Set
    End Property
    Public Property Centro As String
        Get
            Return mstrCentro
        End Get
        Set(ByVal value As String)
            mstrCentro = value
        End Set
    End Property


    Public ReadOnly Property Producto As ClassProducto
        Get
            Return mObjProducto

        End Get
    End Property
    Public Property CantidaReparto
        Get
            Return pDblCantidadReparto
        End Get
        Set(ByVal value)
            pDblCantidadReparto = value
        End Set
    End Property
    Public Property Cliente As ClassCliente
        Get
            Return pCliente

        End Get
        Set(ByVal value As ClassCliente)
            pCliente = value


        End Set
    End Property

    Public Sub SetClienteByString(ByVal ClaveCliente As String)
        If IsNothing(pCliente) Then
            pCliente = New ClassCliente
        End If
        pCliente.Clave = ClaveCliente

    End Sub






End Class
