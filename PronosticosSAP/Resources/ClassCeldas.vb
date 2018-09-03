Imports System.Text

Public Class ClassCeldas
    ''' <summary>
    ''' Devuelve la celda que contiene un valor predeterminado
    ''' </summary>
    ''' <param name="pIdBuscar">Valor a Buscar</param>
    ''' <param name="pControl">Control en el cual se va hacer la busqueda</param>
    ''' <param name="pColumnName">Nombre de la columna a buscar</param>
    ''' <param name="pColumnTarget">Nombre de la columna a devolver normalmente es igual a pColumName</param>
    ''' <param name="pBusExacta">Indica si la busqueda es exacta </param>
    ''' <returns>Devuelve la celda que contiene el dato deseado</returns>
    ''' <remarks></remarks>
    Public Function Posicionar(ByVal pIdBuscar As String, ByRef pControl As DataGridView, _
                               ByVal pColumnName As String, ByVal pColumnTarget As String, _
                               ByVal pBusExacta As Boolean) As DataGridViewCell

        For Each mRow As DataGridViewRow In pControl.Rows
            If mRow.IsNewRow Then Return Nothing
            If pBusExacta Then
                If mRow.Cells(pColumnName).Value.ToString.Equals(pIdBuscar) Then
                    Return mRow.Cells(pColumnTarget)
                End If

            Else
                If mRow.Cells(pColumnName).Value.ToString.Contains(pIdBuscar) Then
                    Return mRow.Cells(pColumnTarget)
                End If
            End If


        Next
        Return Nothing

    End Function

    Public Function PosicionarVarios(ByVal pIdBuscar As String, ByRef pControl As DataGridView, _
                               ByVal pListaColumnasBuscar As String, ByVal pColumnTarget As String, _
                               ByVal pBusExacta As Boolean, ByVal pstrSepCol As String) As DataGridViewCell

        Dim mListaColumnas() As String = pListaColumnasBuscar.Split(pstrSepCol)
        Dim mTmpCampo As StringBuilder = Nothing





        For Each mRow As DataGridViewRow In pControl.Rows
            mTmpCampo = New StringBuilder
            If mRow.IsNewRow Then Return Nothing
            For intCampo = LBound(mListaColumnas) To UBound(mListaColumnas)
                If Not String.IsNullOrEmpty(mListaColumnas(intCampo)) Then
                    mTmpCampo.Append(mRow.Cells(mListaColumnas(intCampo)).Value)
                    If intCampo <> UBound(mListaColumnas) Then
                        mTmpCampo.Append(pstrSepCol)
                    End If
                End If
            Next

            If pBusExacta Then
                If mTmpCampo.ToString.Equals(pIdBuscar) Then
                    Return mRow.Cells(pColumnTarget)
                End If


            Else
                If mTmpCampo.ToString.Contains(pIdBuscar) Then
                    Return mRow.Cells(pColumnTarget)
                End If
            End If


        Next
        Return Nothing

    End Function

End Class
