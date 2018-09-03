Imports System.Collections.Generic
Namespace DjpSap


    Public Class ClassDivision
        Dim mClave As String
        Dim mDescripcion As String
        Sub New(ByVal Clave As String, ByVal Descripcion As String)

            mClave = Clave
            mDescripcion = Descripcion
        End Sub

        Property Clave As String
            Get
                Return mClave
            End Get
            Set(ByVal value As String)
                mClave = value

            End Set
        End Property
        Property Descripcion As String
            Get
                Return mDescripcion
            End Get
            Set(ByVal value As String)
                mDescripcion = value
            End Set
        End Property
    End Class


    Public Class ClassLstDivision

        Dim mList As System.Collections.Generic.List(Of ClassDivision)
        Sub New()
            mList = New System.Collections.Generic.List(Of ClassDivision)
            mList.Add(New ClassDivision("I", "Industrial"))
            mList.Add(New ClassDivision("A", "Agricola"))
        End Sub
        ReadOnly Property GetLista() As List(Of ClassDivision)
            Get
                Return mList
            End Get
        End Property



    End Class

End Namespace

