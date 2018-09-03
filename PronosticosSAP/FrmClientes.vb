Public Class FrmClientes

    Public POBJCTE As ClassCliente
   

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            Dim mSociedad As Nullable(Of Integer)
            Dim mCte As Nullable(Of Integer)

            If Not IsNumeric(Me.TxtSociedad.Text) Then

                mSociedad = Nothing
            Else
                mSociedad = Me.TxtSociedad.Text
            End If

            If Not IsNumeric(Me.TxtCliente.Text) Then
                mCte = Nothing
            Else
                mCte = Me.TxtCliente.Text
            End If

            Me.CONSULTA_CLIENTESTableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_CLIENTES, _
                                                  mSociedad, _
                                                  mCte, _
                                                  Me.TxtDescricpion.Text)
            Me.TabControl1.SelectedIndex = 1




        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CONSULTA_CLIENTESDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CONSULTA_CLIENTESDataGridView.CellClick

        
        If e.RowIndex > -1 Then
            Me.DialogResult = ModComun.FORMDIALOG
            POBJCTE = New ClassCliente
            POBJCTE.Clave = CONSULTA_CLIENTESDataGridView.Rows(e.RowIndex).Cells(1).Value
            POBJCTE.Sociedad = CONSULTA_CLIENTESDataGridView.Rows(e.RowIndex).Cells(0).Value
            Me.Hide()

        Else
            System.Windows.Forms.MessageBox.Show("Elija un elemento valido", "Validando", MessageBoxButtons.OK)


        End If


    End Sub

    
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Hide()
    End Sub

    
End Class