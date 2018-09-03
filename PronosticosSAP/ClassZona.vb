Public Class ClassZona
    Private pstrClave As String
    Private pstrDescripcion As String
    Sub New(ByVal pClave As String)
        pstrClave = pClave

    End Sub
    Public Property Clave As String
        Get
            Return pstrClave
        End Get
        Set(ByVal value As String)
            pstrClave = value

        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return pstrDescripcion
        End Get
        Set(ByVal value As String)
            pstrDescripcion = value

        End Set
    End Property

    Public Function Consultar() As Integer
        Dim mDt As SapForecastDataSet.CONSULTA_ZONASBYCLAVEDataTable = New SapForecastDataSet.CONSULTA_ZONASBYCLAVEDataTable
        Dim mTa As SapForecastDataSetTableAdapters.CONSULTA_ZONASBYCLAVETableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_ZONASBYCLAVETableAdapter
        mTa.Fill(mDt, Me.pstrClave)
        If mDt.Rows.Count > 0 Then
            For Each mRow As DataRow In mDt.Rows
                pstrClave = mRow.Item("CLAVE")
                pstrDescripcion = mRow.Item("DESCRIPCION")
            Next
            Return mDt.Rows.Count
        Else
            Return 0

        End If
        

    End Function

End Class
