Imports PronosticosSAP.DjpSap
Public Class FrmProductos
    Const CTE_CAPTION As String = "CONSULTA CATALOGO DE PRODUCTOS"

    'Private Sub CONSULTA_PRODUCTOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Me.Validate()
    '    Me.CONSULTA_PRODUCTOBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.SapForecastDataSet)

    'End Sub

    Private Sub Consultar(ByVal pClave As String)
        Try

            Me.CONSULTA_PRODUCTOTableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_PRODUCTO, pClave, String.Empty, String.Empty, String.Empty, String.Empty)
            Me.CONSULTA_PRODUCTOXALMACENTableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_PRODUCTOXALMACEN, pClave, String.Empty, String.Empty)
            Me.CONSULTAUMTableAdapter.Fill(Me.SapForecastDataSet.CONSULTAUM, pClave)



        Catch ex As System.Exception
            Me.ShowMessageError(ex.Message)
        End Try

    End Sub

    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        Try
            If String.IsNullOrEmpty(Trim(Me.CLAVETextBox.Text)) OrElse IsNumeric(Me.CLAVETextBox.Text) = False Then
                ProductoErrProvider.SetError(Me.CLAVETextBox, "El dato debe ser numerico")

            Else

                Me.Consultar(Me.CLAVETextBox.Text)

            End If

        Catch ex As Exception
            Me.ShowMessageError(ex.Message)
        End Try

    End Sub



    Private Sub BuscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBtn.Click
        Try
            Dim mFrm As FrmConsultaProducto
            mFrm = New FrmConsultaProducto
            mFrm.ShowDialog()
            Me.UseWaitCursor = True

            If mFrm.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                Me.CLAVETextBox.Text = mFrm.psrClaveProducto

            End If
            mFrm.Dispose()
            mFrm = Nothing
            Me.Consultar(Me.CLAVETextBox.Text)
            Me.UseWaitCursor = False
        Catch ex As Exception
            ShowMessageError(ex.Message)
        End Try


    End Sub

    Private Sub ShowMessageError(ByVal pstrValor As String)
        MessageBox.Show(pstrValor, CTE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub ShowMessageWarning(ByVal pstrValor As String)
        MessageBox.Show(pstrValor, CTE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub BtnImportarSap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportarSap.Click
        FrmSapProductos.ShowDialog()
        FrmSapProductos.Dispose()

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()


    End Sub

    Private Sub FrmProductos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not ModComun.MsgYesNo("¿ Desea cerrar la ventana actual?") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FrmProductos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim mLstDivision = New ClassLstDivision()
            With Me.CboDivision
                .DataSource = mLstDivision.GetLista()
                .ValueMember = "Clave"
                .DisplayMember = "Descripcion"

            End With

        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try
        

    End Sub

    Private Sub CONSULTA_PRODUCTOBindingSource_BindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles CONSULTA_PRODUCTOBindingSource.BindingComplete
        Dim mDs As DataSet = CType(e.Binding.DataSource.datasource, DataSet)


        Dim mTa As DataTable = mDs.Tables(e.Binding.DataSource.datamember)
        CboDivision.SelectedIndex = -1
        For Each mRow As DataRow In mTa.Rows
            Dim mNegocio As String = mRow("NEGOCIO").ToString
            For intItem As Integer = 0 To CboDivision.Items.Count - 1



                Dim mClassDiVision As ClassDivision = CType(CboDivision.Items(intItem), ClassDivision)
                If mClassDiVision.Clave.Equals(mNegocio) Then
                    CboDivision.SelectedIndex = intItem
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub CONSULTA_PRODUCTOBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONSULTA_PRODUCTOBindingSource.CurrentChanged

    End Sub
End Class