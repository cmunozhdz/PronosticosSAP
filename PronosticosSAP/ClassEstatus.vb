
Namespace DjpSap
    Class ClassEstatus
        Dim mStrClave As String
        Dim mstrDescripcion As String


        Public Property Clave As String
            Get
                Return mStrClave

            End Get
            Set(ByVal value As String)
                mStrClave = value
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

    End Class


End Namespace
