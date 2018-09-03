Imports System.Collections.Generic
Imports System.Text

Namespace DjpSap




    Public Class ClassFindGrView
        Dim mLstIems As Dictionary(Of String, Integer)


        Sub New(ByVal mGrd As DataGridView, ByVal mCampos As String, ByVal Separador As String)
            Dim mArrCampos() As String = mCampos.Split(Separador)
            Dim mBldTes As StringBuilder = New StringBuilder
            Dim mIndex As Integer = 0
            mLstIems = New Dictionary(Of String, Integer)
            For Each mItem As DataGridViewRow In mGrd.Rows

                mBldTes.Clear()
                For mColId As Integer = LBound(mArrCampos) To UBound(mArrCampos)
                    If Not String.IsNullOrEmpty(mArrCampos(mColId)) Then
                        If IsDBNull(mItem.Cells(mArrCampos(mColId)).Value) = False AndAlso String.IsNullOrEmpty(mItem.Cells(mArrCampos(mColId)).Value) = False Then


                            mBldTes.Append(Trim(mItem.Cells(mArrCampos(mColId)).Value.ToString))
                        End If


                    End If
                    If mColId <> UBound(mArrCampos) Then
                        mBldTes.Append(Separador)
                    End If
                Next
                If Not mLstIems.ContainsKey(mBldTes.ToString) Then
                    mLstIems.Add(mBldTes.ToString, mIndex)
                End If
                mIndex += 1
            Next


        End Sub

        Function GetIndex(ByVal pstrValorBuscar As String) As Integer
            If mLstIems.ContainsKey(pstrValorBuscar) Then
                Return mLstIems(pstrValorBuscar)
            Else
                Return -1
            End If

        End Function

    End Class

End Namespace