Public Class FrmUsuario


    Private Sub USP_CONSULTA_USUARIOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USP_CONSULTA_USUARIOBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.USP_CONSULTA_USUARIOBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SapForecastDataSet)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.USP_CONSULTA_USUARIOTableAdapter.Fill(Me.SapForecastDataSet.USP_CONSULTA_USUARIO, UserIdToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    
End Class