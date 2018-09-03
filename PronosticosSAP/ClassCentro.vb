Public Class ClassCentro
    Dim mBolExiste As Boolean
    Dim mStrClave As String
    Dim mStrDescripcion As String
    Dim mstrSociedad As String
    Sub New(ByVal pClave As String)
        mStrClave = pClave
    End Sub
    Property Sociedad As String
        Get
            Return mstrSociedad
        End Get
        Set(value As String)
            mstrSociedad = value
        End Set
    End Property

    Property Clave As String
        Get
            Return mStrClave
        End Get
        Set(ByVal value As String)
            mStrClave = value
        End Set
    End Property
    Property Descripcion As String
        Get
            Return mStrDescripcion
        End Get
        Set(ByVal value As String)
            mStrDescripcion = value
        End Set
    End Property

    ''' <summary>
    ''' Busca los centros asignados al agente.
    ''' </summary>
    ''' <param name="pStrAgente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ConsultarCatalogo(ByVal pStrAgente As String, ByVal pstrCentro As String) As Boolean
        Dim mbolProceso As Boolean = False
        Try
            Dim mTa As SapForecastDataSet.CONSULTA_CENTRODataTable = New SapForecastDataSet.CONSULTA_CENTRODataTable
            Dim mTd As SapForecastDataSetTableAdapters.CONSULTA_CENTROTableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_CENTROTableAdapter
            mTd.FillByAgente(mTa, pStrAgente)
            mBolExiste = mTa.Rows.Count > 0 'Determina si el producto existe
            If mBolExiste Then
                Using mTa
                    For Each mRow As SapForecastDataSet.CONSULTA_CENTRORow In mTa.Rows
                        If pstrCentro = Trim(mRow.CLAVECENTRO.ToString) Then
                            mStrClave = Trim(mRow.CLAVECENTRO)
                            mStrDescripcion = mRow.DESCRIPCION
                        Else
                            mBolExiste = False
                        End If
                    Next
                End Using
            Else

                mStrDescripcion = Nothing
            End If
            mbolProceso = True
        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try
        Return mbolProceso

    End Function

    Public ReadOnly Property Existe() As Boolean
        Get
            Return mBolExiste
        End Get
        
    End Property


End Class
