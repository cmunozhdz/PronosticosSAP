Public Class FrmAgentesConsulta
    Public mAgente As ClassVendedor



    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try

            Me.CONSULTA_AGENTESTableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_AGENTES, Me.TxtClave.Text, Me.TxtNombre.Text, Me.EstadoTxt.Text)
            Me.TabControl1.SelectTab(TabResultados)



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CONSULTA_AGENTESDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CONSULTA_AGENTESDataGridView.CellClick
        Dim mIndex = e.RowIndex
        If mIndex >= 0 Then
            If Not IsDBNull(CONSULTA_AGENTESDataGridView.Rows(mIndex).Cells(1).Value) Then
                mAgente = New ClassVendedor
                With mAgente
                    .Clave = CONSULTA_AGENTESDataGridView.Rows(mIndex).Cells(1).Value
                    .Descripcion = CONSULTA_AGENTESDataGridView.Rows(mIndex).Cells(2).Value


                End With
                Me.DialogResult = System.Windows.Forms.DialogResult.Yes
                Me.Hide()


                Exit Sub

            End If


        End If
        MsgBox("Elija un elemento valido", MsgBoxStyle.OkOnly)




    End Sub


    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

    End Sub

    
    

    
End Class