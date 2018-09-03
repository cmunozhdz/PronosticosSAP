Public Class FrmConsultaProductoByCentro

    Public psrClaveProducto As String

    Public pObjProducto As ClassProducto

    Public strCentro As String
    Public strSociedad As String
    Public strAlmacen As String
    Public ObjItem As ClassProductoCentro


    Private Sub CONSULTA_PRODUCTOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Validate()
        'Me.CONSULTA_PRODUCTOBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.SapForecastDataSet)

    End Sub

    Private Sub Consultar()

        Try
            Dim mStrClave As String = Nothing
            If Not String.IsNullOrEmpty(Me.ClaveTxt.Text) AndAlso IsNumeric(Me.ClaveTxt.Text) Then
                mStrClave = Trim(Me.ClaveTxt.Text)
            End If
            Me.CONSULTA_PRODUCTOXALMACENTableAdapter.FillByDescAndSociedad(Me.SapForecastDataSet.CONSULTA_PRODUCTOXALMACEN, mStrClave, Me.strCentro, Me.strAlmacen, Me.strSociedad, Me.DescCortaTxt.Text)


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
                
                ObjItem = New ClassProductoCentro(CONSULTA_PRODUCTODataGridView.Rows(e.RowIndex).Cells("CLAVEPRODUCTO").Value, CONSULTA_PRODUCTODataGridView.Rows(e.RowIndex).Cells("CLAVECENTRO").Value)


                Me.DialogResult = Windows.Forms.DialogResult.Yes
                Me.Hide()
            End If
        End If
    End Sub




    
    
    
End Class