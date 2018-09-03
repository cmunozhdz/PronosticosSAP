Public Class ClassAlmacen
    Dim pstrClave As String
    Dim pstrDescripcion As String
    Dim pStrCentro As String
    Property Clave As String
        Get
            Return pstrClave
        End Get
        Set(ByVal value As String)
            pstrClave = value
        End Set
    End Property

    Property Descripcion As String
        Get
            Return pstrDescripcion
        End Get
        Set(ByVal value As String)
            pstrDescripcion = value
        End Set
    End Property
    Property Centro As String
        Get
            Return pStrCentro
        End Get
        Set(ByVal value As String)
            pStrCentro = value
        End Set
    End Property


End Class
