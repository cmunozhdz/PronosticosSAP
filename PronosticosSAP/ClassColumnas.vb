Public Class ClassColumnasGridView
    Dim pstrHeader As String
    Dim pstrClave As String
    Dim pbolVisible As Boolean
    Dim pBolFrozen As Boolean
    Dim pColor As System.Drawing.Color
    Dim pReadOnly As Boolean
    Dim pstrFormato As String
    Dim pEsCaptura As Boolean
    Dim pStrHeaderFecha As Date




    Public Sub New(ByVal Header As String, ByVal Clave As String, ByVal visible As Boolean, ByVal Frozen As Boolean)
        pstrHeader = Header
        pstrClave = Clave
        pbolVisible = visible
        pBolFrozen = Frozen
        pColor = Color.Black
        pReadOnly = False
        pEsCaptura = False

    End Sub
    Public Property Formato As String
        Get
            Return pstrFormato

        End Get
        Set(ByVal value As String)
            pstrFormato = value

        End Set
    End Property

    Public Property SoloLectura As Boolean
        Get
            Return pReadOnly


        End Get
        Set(ByVal value As Boolean)
            pReadOnly = value

        End Set
    End Property

    Public Property Color As System.Drawing.Color
        Get
            Return pColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            pColor = value
        End Set
    End Property


    Public Property Frozen As Boolean
        Get
            Return pBolFrozen
        End Get
        Set(ByVal value As Boolean)
            pBolFrozen = value

        End Set
    End Property

    Public Property Visible As Boolean
        Get
            Return pbolVisible
        End Get
        Set(ByVal value As Boolean)
            pbolVisible = value
        End Set

    End Property
    Public Property Header As String

        Get
            Return pstrHeader
        End Get
        Set(ByVal value As String)
            pstrHeader = value
        End Set
    End Property
    Public Property Clave As String

        Get
            Return pstrClave
        End Get
        Set(ByVal value As String)
            pstrClave = value
        End Set
    End Property
    Public Property EsCaptura As Boolean
        Get
            Return Me.pEsCaptura
        End Get
        Set(ByVal value As Boolean)
            Me.pEsCaptura = value

        End Set

    End Property
    Public Property HeaderValorFecha As Date
        Get
            Return pStrHeaderFecha
        End Get
        Set(ByVal value As Date)
            pStrHeaderFecha = value
        End Set
    End Property

End Class
