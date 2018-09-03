Public Class ClassProductoCentro
    Public Producto As ClassProducto
    Public Centro As ClassCentro
    Sub New(ByVal StrProducto As String, ByVal strCentro As String)
        Producto = New ClassProducto
        Producto.Clave = StrProducto
        Centro = New ClassCentro(strCentro)

    End Sub
End Class
