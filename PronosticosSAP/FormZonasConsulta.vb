Public Class FormZonasConsulta
    Public pClaveZona As String

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        Try


            Me.UseWaitCursor = True


            Me.CONSULTA_ZONASBYCLAVETableAdapter.FillByVarios(Me.SapForecastDataSet.CONSULTA_ZONASBYCLAVE, Me.ClaveTxt.Text, Me.DescripcionTxt.Text, Me.EstadoTxt.Text)
            Me.ZonasTabConsulta.SelectedTab = Me.TabResultados
            Me.UseWaitCursor = False



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub CONSULTA_ZONASBYCLAVEDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CONSULTA_ZONASBYCLAVEDataGridView.CellClick
        Try

            If e.RowIndex > -1 Then
                pClaveZona = CONSULTA_ZONASBYCLAVEDataGridView.Rows(e.RowIndex).Cells("ColClaveGridview").Value

                Me.DialogResult = DialogResult.OK
                Me.Hide()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)



        End Try


    End Sub


    Private Sub CanelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanelarBtn.Click
        Me.DialogResult = DialogResult.No

    End Sub
End Class