Public Class ClassCliente
    Dim pStrClave As String
    Dim pstrSociedad As String
    Public Property Sociedad As String
        Get
            Return pstrSociedad
        End Get
        Set(ByVal value As String)
            pstrSociedad = value

        End Set
    End Property



    Public Property Clave As String
        Get
            Return pStrClave
        End Get
        Set(ByVal value As String)
            pStrClave = value

        End Set
    End Property

End Class
