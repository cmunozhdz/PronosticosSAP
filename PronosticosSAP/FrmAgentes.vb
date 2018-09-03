Imports System.Data
Imports System.Data.SqlClient

Public Class FrmAgentes
    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        Me.UseWaitCursor = True
        If Not String.IsNullOrEmpty(Trim(Me.CLAVEAGENTETextBox.Text)) Then
            Me.Consultar(Me.CLAVEAGENTETextBox.Text)

        End If
        Me.UseWaitCursor = False

    End Sub

    Private Sub Consultar(ByVal pstrAgente As String)


        Me.CONSULTA_AGENTESTableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_AGENTES, pstrAgente, String.Empty, String.Empty)
        Me.CONSULTA_ALMACENTableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_ALMACEN, String.Empty, pstrAgente)
        Me.CONSULTA_ZONAXAGENTETableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_ZONAXAGENTE, pstrAgente)
        Me.CONSULTA_ALMACENDataGridView.DataSource = Me.CONSULTA_ALMACENBindingSource
        Me.CONSULTA_ZONAXAGENTEDataGridView.DataSource = Me.CONSULTA_ZONAXAGENTEBindingSource

        'Me.CONSULTA_ZONAXAGENTETableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_ZONAXAGENTE, pstrAgente)
        'Me.ALMACENPRONOSTICOTableAdapter.FillByAgente(Me.SapForecastDataSet.ALMACENPRONOSTICO, pstrAgente, DBNull.Value)
        If Me.SapForecastDataSet.CONSULTA_AGENTES.Rows.Count = 0 Then
            Me.ShowMessageError("Registro Inexistente")

        End If



    End Sub


    'Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
    '    Dim mFrmConsulta As FrmAgentesConsulta = New FrmAgentesConsulta
    '    Using mFrmConsulta
    '        With mFrmConsulta
    '            .ShowDialog()
    '            If .DialogResult = System.Windows.Forms.DialogResult.Yes Then
    '                Me.CLAVEAGENTETextBox.Text = .mAgente.Clave
    '            End If
    '        End With

    '    End Using
    '    mFrmConsulta.Dispose()
    'End Sub

    
  

    

 

    
    
    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        Dim mCon As SqlConnection
        Dim mbolTranOpen As Boolean
        Dim mTran As SqlTransaction = Nothing
        Dim mIRow As Integer
        Dim mCmd As SqlCommand

        Try
            mCon = DjpSap.Dac.mConexion
            mTran = mCon.BeginTransaction
            mbolTranOpen = True
            mCmd = New SqlCommand()
            With mCmd

                .CommandType = CommandType.StoredProcedure
                .CommandText = "CATALOGOS.ACTUALIZA_AGENTES"
                .Connection = mCon
                .Transaction = mTran
                .Parameters.AddWithValue("@CLAVEAGENTE", Me.CLAVEAGENTETextBox.Text)
                .Parameters.AddWithValue("@NOMBRE", Me.NOMBRETextBox.Text)
                .Parameters.AddWithValue("@STATUS", Me.STATUSTextBox.Text)
                mIRow = .ExecuteNonQuery()
                If mIRow = 1 Then
                    Dim mChanges As DataTable = Me.SapForecastDataSet.CONSULTA_ALMACEN.GetChanges()

                    If Not IsNothing(mChanges) Then
                        Dim mCmdAlmacen As SqlCommand = New SqlCommand()
                        With mCmdAlmacen


                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "CATALOGOS.INSERTA_AGENTEXALMACEN"
                            .Connection = mCon
                            .Transaction = mTran
                            .Parameters.Add("@CLAVECENTRO", System.Data.SqlDbType.Char, 5)
                            .Parameters.Add("@CLAVEALMACEN", System.Data.SqlDbType.Char, 5)
                            .Parameters.Add("@CLAVEAGENTE", System.Data.SqlDbType.Char, 10)
                            .Parameters.Add("@ESTATUS", System.Data.SqlDbType.Char, 1)

                            For Each mRow As DataRow In mChanges.Rows
                                'Ejecuta el query de actualizacion

                                
                                If mRow.RowState <> System.Data.DataRowState.Deleted Then
                                    .Parameters("@CLAVECENTRO").Value = mRow.Item("CLAVECENTRO")
                                    .Parameters("@CLAVEALMACEN").Value = mRow.Item("CLAVEALMACEN") 'mRow("CLAVEALMACEN").ToString
                                    .Parameters("@CLAVEAGENTE").Value = Me.CLAVEAGENTETextBox.Text
                                    .Parameters("@ESTATUS").Value = "A"


                                Else
                                    .Parameters("@CLAVECENTRO").Value = mRow.Item("CLAVECENTRO", System.Data.DataRowVersion.Original)
                                    .Parameters("@CLAVEALMACEN").Value = mRow.Item("CLAVEALMACEN", System.Data.DataRowVersion.Original) 'mRow("CLAVEALMACEN").ToString
                                    .Parameters("@CLAVEAGENTE").Value = Me.CLAVEAGENTETextBox.Text
                                    .Parameters("@ESTATUS").Value = "I"
                                End If
                                .ExecuteNonQuery()

                            Next
                        End With

                    End If

                End If


            End With
            mTran.Commit()
            Me.ShowMessage("Registro Guaradado Exitosamente")

        Catch ex As Exception

            If mbolTranOpen Then
                If Not IsNothing(mTran) Then
                    mTran.Rollback()

                End If
                Me.ShowMessageError(ex.Message)
            End If

        End Try

        'Prepara las transacciones para enviar los datos 
        'Acutaliza la cabecerá del vendedor.




    End Sub

    Sub ShowMessage(ByVal pstrMensaje As String)
        System.Windows.Forms.MessageBox.Show(pstrMensaje, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
    End Sub
    Sub ShowMessageError(ByVal pstrMensaje As String)
        System.Windows.Forms.MessageBox.Show(pstrMensaje, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
    End Sub
    

    Private Sub AlmacenAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    ''' <summary>
    ''' Consulta la lista de agentes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mfrm As FrmAgentesConsulta = New FrmAgentesConsulta
        mfrm.ShowDialog()
        If mfrm.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            Me.CLAVEAGENTETextBox.Text = mfrm.mAgente.Clave
            Me.Consultar(Me.CLAVEAGENTETextBox.Text)
        End If

    End Sub

    

    Private Sub AlmacenMnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlmacenMnuAdd.Click
        Dim mFrm As FrmConsultaAlmacenes = New FrmConsultaAlmacenes
        With mFrm
            .ShowDialog()
            If .DialogResult = System.Windows.Forms.DialogResult.Yes Then
                With .ObjAlmacen
                    Me.SapForecastDataSet.CONSULTA_ALMACEN.AddCONSULTA_ALMACENRow(.Centro, .Clave, String.Empty, .Descripcion)
                End With
                Me.CONSULTA_ALMACENBindingSource.ResetBindings(False)
            End If

        End With
    End Sub

    
    Private Sub FrmAgentes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CONSULTA_ZONASBYCLAVETableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_ZONASBYCLAVE, String.Empty)


    End Sub

    
    Private Sub AlmacenMenuDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlmacenMenuDel.Click
        Dim mCell As DataGridViewCell = Me.CONSULTA_ALMACENDataGridView.CurrentCell
        If Not IsNothing(mCell) Then
            If mCell.RowIndex > -1 Then
                'Me.CONSULTA_ALMACENDataGridView.Rows(mCell.RowIndex).de()
                Dim mRow As DataGridViewRow = Me.CONSULTA_ALMACENDataGridView.Rows(mCell.RowIndex)
                Me.CONSULTA_ALMACENDataGridView.Rows.Remove(mRow)
                'Dim mRow As DataGridViewRow = Me.CONSULTA_ALMACENDataGridView.Rows(mCell.RowIndex)


            End If
        End If
    End Sub

    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        Try
            Me.CLAVEAGENTETextBox.Text = String.Empty
            Me.NOMBRETextBox.Text = String.Empty
            Me.STATUSTextBox.Text = String.Empty
            Me.NEGOCIOTextBox.Text = String.Empty
            CONSULTA_ALMACENDataGridView.DataSource = Nothing
            CONSULTA_ZONAXAGENTEDataGridView.DataSource = Nothing

        Catch ex As Exception
            Me.ShowMessageError(ex.Message)

        End Try
        




    End Sub
End Class
