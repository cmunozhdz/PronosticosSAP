Imports System.Data
Imports System.Data.SqlClient

Public Class FrmRepartos
    Private Const CTE_CAPTION As String = "Sistema Pronosticos Polaquimia (Repartos)"
    Public ObjItemReparto As ClassItemPronosticos



    ''' <summary>
    ''' Asigna los valores del objeto asigando por referencia a los controles.
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetValues()
        Try
            With ObjItemReparto
                Me.CentroTxt.Text = .Centro
                Me.ProductoTxt.Text = .Producto.Clave

                If .Producto.ConsultarCatalogo() Then
                    Me.DescProductoLbl.Text = .Producto.DescripcionCorta
                End If
                Me.PronosticoLbl.Text = .Id


                If .Producto.BuscarEquivalenciaCatalogo() Then
                    Me.EquivalenciaLbl.Text = "Presentacion: 1 " & .Producto.UnidadAlterna & " = " & .Producto.Equivalencia(.Producto.UnidadBase, 1) & " " & .Producto.UnidadBase
                End If


                Me.FechaLbl.Text = "Fecha:" & String.Format("{0:MMM-yyyy}", .Periodo).ToUpper()


                Me.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_DETALLEPRONOSTICOSALMACEN _
                                                                       , New System.Nullable(Of Integer)(CType(.Id, Integer)), _
                                                                          New System.Nullable(Of Date)(CType(.Periodo, Date)), _
                                                                          .Centro, _
                                                                          .Producto.Clave)

            End With
            'Me.Validate()
            'QtyProgramadaLbl.Text = "Total: " & String.Format("{0:###,##0.00}", Me.FnTotalRepartir())


        Catch ex As Exception
            Me.ShowMsgError(ex.Message)

        End Try

    End Sub











    'Private Sub CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.CellValidated
    '    Try
    '        With CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView
    '            Dim Mr As DataGridViewRow = .Rows(e.RowIndex)
    '            Dim mCol As Integer
    '            For mCol = 0 To CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Columns.Count - 1
    '                Select Case CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Columns(mCol).DataPropertyName
    '                    Case "IDPRONOSTICO"
    '                        .Rows(e.RowIndex).Cells(mCol).Value = ObjItemReparto.Id
    '                    Case "INTPERIODO"
    '                        '.Rows(e.RowIndex).Cells(mCol).Value = ObjItemReparto.Periodo
    '                    Case "CLAVECENTRO"
    '                        .Rows(e.RowIndex).Cells(mCol).Value = ObjItemReparto.Centro
    '                    Case "CLAVEPRODUCTO"
    '                        .Rows(e.RowIndex).Cells(mCol).Value = ObjItemReparto.Producto.Clave
    '                    Case "SMDTIMESTAMP"
    '                        .Rows(e.RowIndex).Cells(mCol).Value = Date.Now
    '                End Select
    '            Next
    '        End With
    '    Catch ex As Exception
    '        ShowMsgError(ex.Message)

    '    End Try



    'End Sub





    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        Try
            Dim mValidacionOk As Boolean

            Me.Validate()
            'Manda Mensaje Indicando si el monto actual es diferente que el proyectado.

            ObjItemReparto.CantidaReparto = FnTotalRepartir()
            If ObjItemReparto.Cantidad = 0 Then

                mValidacionOk = True
            ElseIf ObjItemReparto.Cantidad = ObjItemReparto.CantidaReparto Then
                mValidacionOk = True
            ElseIf ObjItemReparto.Cantidad <> ObjItemReparto.CantidaReparto Then
                'mValidacionOk = Me.ShowMsgYesNo("El monto a repartir y la  cantidad repartida no coincide" & "¿ Desea Guardar de de cualquier manera ?")
                mValidacionOk = Me.ShowMsgYesNo("El monto a repartir y la  cantidad repartida no coincide" & "¿ Desea Guardar de de cualquier manera ?")
            Else
                Me.ShowMsgError("La cantidad a repartir ha sido rebasada, no puede guardarse.")
                mValidacionOk = False
            End If
            If mValidacionOk Then

                Me.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter.Update(Me.SapForecastDataSet.CONSULTA_DETALLEPRONOSTICOSALMACEN)

                Me.SapForecastDataSet.AcceptChanges()


            End If
            If ObjItemReparto.Cantidad < ObjItemReparto.CantidaReparto Then
                'MsgBox("Guardando el total por centro")
                'Abre la conexion.

                Dim objCon As SqlConnection = DjpSap.Dac.mConexion
                Using mCmd As SqlCommand = New SqlCommand
                    With mCmd
                        .Connection = objCon
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "PRONOSTICOS.ACTUALIZALINEA_PRONOSTICO"
                        .Parameters.AddWithValue("@IDPRONOSTICO", ObjItemReparto.Id)
                        .Parameters.AddWithValue("@CENTRO", ObjItemReparto.Centro)
                        .Parameters.AddWithValue("@CVEPRODUCTO", ObjItemReparto.Producto.Clave)
                        .Parameters.AddWithValue("@FECHAPERIODO", ObjItemReparto.Periodo)
                        .Parameters.AddWithValue("@CLIENTE", System.DBNull.Value)
                        .Parameters.AddWithValue("@CANTIDADBASE", ObjItemReparto.CantidaReparto)
                        'Calcula la Equivalencia
                        Dim QtyAlterna As Double = ObjItemReparto.Producto.Equivalencia(ObjItemReparto.Producto.UnidadAlterna, ObjItemReparto.CantidaReparto)
                        .Parameters.AddWithValue("@CANTIDADALTERNA", QtyAlterna)
                        .ExecuteNonQuery()

                    End With
                End Using





            End If
        Catch ex As Exception
            Me.ShowMsgError(ex.Message)

        End Try
    End Sub

    ''' <summary>
    ''' Valida el proceso de descar de datos.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FrmRepartos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub ShowMsgError(ByVal pStrMensaje As String)
        System.Windows.Forms.MessageBox.Show(pStrMensaje, CTE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Function ShowMsgYesNo(ByVal pStrMensaje As String) As Boolean
        Return System.Windows.Forms.MessageBox.Show(pStrMensaje, CTE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes
    End Function
    Private Sub CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.CellValidated
        'DEtermina la conversion en unidades base

        Try
            Dim mCellOrigen As DataGridViewCell
            Dim mColBase As Integer
            Dim mColAlterna As Integer
            For Each mcol As DataGridViewColumn In CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Columns
                Select Case mcol.DataPropertyName
                    Case "NUMCANTIDADBASE"
                        mColBase = mcol.Index

                    Case "NUMCANTIDADALTERNA"
                        mColAlterna = mcol.Index
                End Select

            Next mcol

            With ObjItemReparto.Producto
                If .BuscarEquivalenciaCatalogo() Then
                    Dim mCol As DataGridViewColumn = CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Columns(e.ColumnIndex)
                    mCellOrigen = CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    Dim mCelDestino As DataGridViewCell = Nothing

                    Select Case mCol.DataPropertyName
                        Case "NUMCANTIDADBASE"

                            mCelDestino = CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Rows(e.RowIndex).Cells(mColAlterna)
                            If Not IsDBNull(mCellOrigen.Value) Then
                                mCelDestino.Value = .Equivalencia(.UnidadAlterna, mCellOrigen.Value)
                            Else
                                mCelDestino.Value = 0
                            End If

                        Case "NUMCANTIDADALTERNA"
                            mCelDestino = CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Rows(e.RowIndex).Cells(mColBase)
                            If Not IsDBNull(mCellOrigen.Value) Then
                                mCelDestino.Value = .Equivalencia(.UnidadBase, mCellOrigen.Value)
                            Else
                                mCelDestino.Value = 0
                            End If

                    End Select
                    If .HayErrorRedondeo Then
                        mCellOrigen.ErrorText = "Error al efectuar las equivalencias "
                        'Aolcua facto de conversion correcto
                        Dim mCellDestinoCorregido As DataGridViewCell

                        Select Case mCol.DataPropertyName
                            Case "NUMCANTIDADBASE"
                                mCellDestinoCorregido = CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Rows(e.RowIndex).Cells(mColBase)

                                'mCelDestino = CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Rows(e.RowIndex).Cells(mColAlterna)
                                mCellDestinoCorregido.Value = .Equivalencia(.UnidadBase, mCelDestino.Value)

                            Case "NUMCANTIDADALTERNA"

                                mCellDestinoCorregido = CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Rows(e.RowIndex).Cells(mColAlterna)
                                mCellDestinoCorregido.Value = .Equivalencia(.UnidadAlterna, mCellOrigen.Value)

                        End Select

                    End If
                End If


            End With

            Me.Totales()

        Catch ex As Exception
            Me.ShowMsgError(ex.Message)

        End Try






    End Sub




    Private Sub CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.CellValidating
        Try
            If e.ColumnIndex > -1 Then
                If Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Columns(e.ColumnIndex).ReadOnly = False Then
                    Dim mLngValue As Long = 0
                    If Not String.IsNullOrEmpty(e.FormattedValue) Then
                        If Not Long.TryParse(e.FormattedValue, mLngValue) Then

                            Me.ShowMsgError("La celda debe ser numerica")
                            e.Cancel = True

                        End If
                    End If

                End If
            End If

        Catch ex As Exception
            Me.ShowMsgError(ex.Message)
        End Try


    End Sub
    Private Function FnTotalRepartir() As Double
        Dim mBolFound As Boolean = False
        Dim mValue As Double = 0
        Dim mColIndex As Integer
        Dim mValueCelda As Double


        For Each mCol As DataGridViewColumn In Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Columns
            If mCol.DataPropertyName = "NUMCANTIDADBASE" Then
                mColIndex = mCol.Index
                mBolFound = True
                Exit For
            End If
        Next
        If mBolFound Then

            'For Each mRow As DataGridCell In mCol.i
            ' For Each mRow In DataGridViewRow in ME.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.ROWS()
            For Each mRow As DataGridViewRow In Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Rows
                If Not IsDBNull(mRow.Cells(mColIndex).Value) Then
                    Double.TryParse(mRow.Cells(mColIndex).Value, mValueCelda)
                    mValue += mValueCelda
                End If
            Next
        End If
        Return mValue

    End Function




    Private Sub CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.DataBindingComplete
        Try

            For Each MCOL As DataGridViewColumn In Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Columns
                If MCOL.ReadOnly Then
                    MCOL.DefaultCellStyle.BackColor = Color.Silver
                Else
                    MCOL.DefaultCellStyle.BackColor = Color.White
                End If

            Next
            Me.Totales()
        Catch ex As Exception
            Me.ShowMsgError(ex.Message)

        End Try


    End Sub


    Private Sub ToolRegresarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolRegresarBtn.Click
        Me.Validate()
        If Me.SapForecastDataSet.HasChanges Then

            If ShowMsgYesNo("Existen datos sin guardar, esta información se perderá" & vbCrLf & "¿Desea salir sin guardar?") Then
                Me.Hide()
            End If
        Else
            Me.Hide()
        End If
    End Sub

    Private Sub Totales()
        Dim mDblRepartido = Me.FnTotalRepartir()
        Dim mDblPendiente = ObjItemReparto.Cantidad - mDblRepartido
        Me.QtyLbl.Text = "Cant. a Repartir:" & String.Format("{0:###,##0.00}", ObjItemReparto.Cantidad)
        QtyProgramadaLbl.Text = "Repartido:" & String.Format("{0:###,##0.00}", mDblRepartido)

        QTYPendienteLbl.Text = "Pendiente:" & String.Format("{0:###,##0.00}", mDblPendiente)
        If mDblPendiente <= 0 Then
            QTYPendienteLbl.ForeColor = Color.Green
        Else
            QTYPendienteLbl.ForeColor = Color.Red
        End If
        'QtyProgramadaLbl.Text = "Total: " & String.Format("{0:###,##0.00}", Me.FnTotalRepartir())
    End Sub

    
   
End Class