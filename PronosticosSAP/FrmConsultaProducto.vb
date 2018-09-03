Public Class FrmConsultaProducto
    Public psrClaveProducto As String
    Public pObjProducto As ClassProducto


    Private Sub CONSULTA_PRODUCTOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CONSULTA_PRODUCTOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SapForecastDataSet)

    End Sub

    Private Sub Consultar()

        Try
            Me.CONSULTA_PRODUCTOTableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_PRODUCTO, Me.ClaveTxt.Text, Me.DescCortaTxt.Text, Me.TipoTxt.Text, Me.NegocioCbo.SelectedValue, Me.EstadoCbo.SelectedValue)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Consultar()
        Me.TabControl1.SelectTab(1)
    End Sub

    Private Sub CONSULTA_PRODUCTODataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CONSULTA_PRODUCTODataGridView.CellClick
        If e.RowIndex > -1 Then

            If Not String.IsNullOrEmpty(CONSULTA_PRODUCTODataGridView.Rows(e.RowIndex).Cells(1).Value.ToString) Then
                psrClaveProducto = CONSULTA_PRODUCTODataGridView.Rows(e.RowIndex).Cells(1).Value
                pObjProducto = New ClassProducto
                With pObjProducto
                    .Clave = psrClaveProducto
                    .DescripcionCorta = CONSULTA_PRODUCTODataGridView.Rows(e.RowIndex).Cells(2).Value

                End With


                Me.DialogResult = Windows.Forms.DialogResult.Yes
                Me.Hide()
            End If
        End If
    End Sub

   
   
    
    Private Sub CONSULTA_PRODUCTODataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CONSULTA_PRODUCTODataGridView.CellContentClick

    End Sub
End Class