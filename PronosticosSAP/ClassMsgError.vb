
Public Class ClassMsgError
    Dim mstr As String
    Dim mstrOrigen As String
    Public Property Mensaje As String
        Get
            Return mstr
        End Get
        Set(ByVal value As String)
            mstr = value
        End Set
    End Property

    Public Property Origen As String
        Get
            Return mstrOrigen
        End Get
        Set(ByVal value As String)
            mstrOrigen = value
        End Set
    End Property
    Public ReadOnly Property MensajeLargo() As String
        Get
            Return mstrOrigen & ":" & mstr

        End Get
    End Property

    Public Sub New(ByVal pOrigen As String, ByVal pTexto As String)
        mstr = pTexto
        mstrOrigen = pOrigen
    End Sub





End Class
