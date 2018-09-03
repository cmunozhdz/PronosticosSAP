Public Class FrmConsultaMaestroPronostico
    Private pObjPronostico As ClassPronosticos
    Public IdPronostico As Long

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        Try
            Dim mInteger As Nullable(Of Long)
            If String.IsNullOrEmpty(Me.NoPronosticoTxt.Text) Then
                mInteger = Nothing
            ElseIf IsNumeric(Me.NoPronosticoTxt.Text) Then
                mInteger = Me.NoPronosticoTxt.Text
            Else

                MsgBox("El dato debe ser numerico")
                Exit Sub


            End If

            Me.CONSULTA_MAESTROPRONOSTICOSBYIDTableAdapter.FillByVarios(Me.SapForecastDataSet.CONSULTA_MAESTROPRONOSTICOSBYID, mInteger, Me.NoVendedorTxt.Text)

            Me.TabControl1.SelectedTab = TbResultados

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try




    End Sub

    Private Sub CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.CellClick
        Try
            If e.RowIndex > -1 Then

                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                pObjPronostico = New ClassPronosticos
                With pObjPronostico
                    .Id = CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.Rows(e.RowIndex).Cells("COL_IDPRONOSTICO").Value
                    .PeriodoInicial = CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.Rows(e.RowIndex).Cells("SMDINICIO").Value
                    .PeriodoFinal = CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.Rows(e.RowIndex).Cells("SMDFIN").Value
                    .Agente = New ClassVendedor

                    .Agente.Clave = CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.Rows(e.RowIndex).Cells("CLAVEAGENTE").Value
                    .Periodo = CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.Rows(e.RowIndex).Cells("TIPOPERIODO").Value



                    Me.IdPronostico = .Id

                    'CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.Rows(e.RowIndex).Cells("DataGridViewTextBoxColumn1").Value
                End With

                Me.Hide()

            Else
                pObjPronostico = Nothing

            End If
        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try
        
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Hide()

    End Sub

    Private Sub VendedorBuscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedorBuscarBtn.Click
        Dim mFrm As FrmAgentesConsulta = New FrmAgentesConsulta
        mFrm.ShowDialog()
        If mFrm.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            Me.NoVendedorTxt.Text = mFrm.mAgente.Clave

        End If
        mFrm.Dispose()

    End Sub

    
    
    Public ReadOnly Property Pronostico As ClassPronosticos

        Get
            Return pObjPronostico

        End Get
        
    End Property


    
    
End Class