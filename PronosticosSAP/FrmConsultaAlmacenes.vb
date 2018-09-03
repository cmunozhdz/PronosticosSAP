Public Class FrmConsultaAlmacenes
    Public ObjAlmacen As ClassAlmacen
    Const CTE_CAPTION = "Consulta Almacenes"

    
    

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        Try

            'Me.CONSULTA_ALMACENTableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_ALMACEN, Me.CentroTxt.Text, String.Empty)
            Me.CONSULTA_ALMACENTableAdapter.FillByDescripcion(Me.SapForecastDataSet.CONSULTA_ALMACEN, Me.CentroTxt.Text, Me.ClaveAlmacenTxt.Text, Me.DescripcionTxt.Text)

            Me.TabControl1.SelectedTab = Me.TabPage2


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CONSULTA_ALMACENDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CONSULTA_ALMACENDataGridView.CellClick
        Try
            If e.RowIndex > -1 Then
                ObjAlmacen = New ClassAlmacen
                Dim mRow As DataGridViewRow = CONSULTA_ALMACENDataGridView.Rows(e.RowIndex)

                ObjAlmacen.Centro = mRow.Cells("CLAVECENTRO").Value
                ObjAlmacen.Clave = mRow.Cells("CLAVEALMACEN").Value
                ObjAlmacen.Descripcion = mRow.Cells("DESCRIPCION").Value
                Me.DialogResult = System.Windows.Forms.DialogResult.Yes
                Me.Hide()

            End If
        Catch ex As Exception
            ShowErrMessage(ex.Message)
        End Try
        

    End Sub

    Private Sub ShowErrMessage(ByVal pstrMensaje As String)
        System.Windows.Forms.MessageBox.Show(pstrMensaje, CTE_CAPTION, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)

    End Sub
    
    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
    End Sub

    Private Sub FrmConsultaAlmacenes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub
End Class