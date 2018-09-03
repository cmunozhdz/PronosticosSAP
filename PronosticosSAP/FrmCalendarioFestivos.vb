Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic


Public Class FrmCalendarioFestivos
    Public mBolConsultandoDatos As Boolean
    Private Const cCOLANIO = "ColAnio"
    Private Const cCOLMES = "ColMes"
    Private Const cCOLDIA = "ColDia"

    Private Sub CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem.Click

        Dim mTransaction As SqlTransaction = Nothing
        Try
            If Me.Validate() Then
                'Trae los registros que han sufrido cambios

                If Me.SapForecastDataSet.HasChanges Then
                    Me.CONSULTA_DIASFESTIVOSALLBindingSource.EndEdit()
                    'Valida que las celdas tengan valores validos.
                    Dim mBolHayError As Boolean = False

                    
                    For Each intRow As DataGridViewRow In Me.CONSULTA_DIASFESTIVOSALLDataGridView.Rows


                        For intId = Me.CONSULTA_DIASFESTIVOSALLDataGridView.Columns(cCOLDIA).Index To Me.CONSULTA_DIASFESTIVOSALLDataGridView.Columns(cCOLANIO).Index
                            If Me.FnValidaCelda(intRow.Index, intId) = False Then
                                intRow.Cells(intId).ErrorText = Me.TsStatusLabel.Text
                                mBolHayError = True
                            End If
                        Next
                    Next
                    If mBolHayError Then Exit Sub

                    'No hay errores de captura continua grabando.
                    Dim mTa As SapForecastDataSetTableAdapters.CONSULTA_DIASFESTIVOSALLTableAdapter = Me.TableAdapterManager.CONSULTA_DIASFESTIVOSALLTableAdapter
                    'Dim mCon As SqlConnection = Me.TableAdapterManager.CONSULTA_DIASFESTIVOSALLTableAdapter.Connection
                    If Me.TableAdapterManager.CONSULTA_DIASFESTIVOSALLTableAdapter.Connection.State <> ConnectionState.Open Then
                        Me.TableAdapterManager.CONSULTA_DIASFESTIVOSALLTableAdapter.Connection.Open()

                    End If
                    mTransaction = Me.TableAdapterManager.CONSULTA_DIASFESTIVOSALLTableAdapter.Connection.BeginTransaction
                    Me.TableAdapterManager.CONSULTA_DIASFESTIVOSALLTableAdapter.Transaction = mTransaction

                    'Lista los estados y orden en que debe hacerse la actualizacion
                    Dim Sts As List(Of System.Data.DataRowState) = New List(Of System.Data.DataRowState)
                    Sts.Add(System.Data.DataRowState.Modified)
                    Sts.Add(System.Data.DataRowState.Added)

                    Dim ChngDs As DataSet

                    For Each mSts As System.Data.DataRowState In Sts
                        ChngDs = Me.SapForecastDataSet.GetChanges(mSts)
                        If Not IsNothing(ChngDs) Then
                            mTa.Update(ChngDs)
                        End If

                    Next
                    mTransaction.Commit()


                    Me.FillData()
                    Me.CONSULTA_DIASFESTIVOSALLBindingSource.ResetBindings(False)
                    Me.TsStatusLabel.Text = "Registros Actualizados"
                Else
                    Me.TsStatusLabel.Text = "No se encontraron cambios"
                End If


            Else
                Me.TsStatusLabel.Text = "Validación Fallida;No se ha guardado los cambios"
            End If



            'Valida que los datos son validos.

            'Me.TableAdapterManager.UpdateAll(Me.SapForecastDataSet)
            'Me.TableAdapterManager.CONSULTA_DIASFESTIVOSALLTableAdapter.Transaction.Commit()
            'Dim mTransaction As SqlTransaction




        Catch ex As SqlException
            Me.TsStatusLabel.Text = ex.Message
            If Not IsNothing(mTransaction.Connection) Then
                mTransaction.Rollback()
            End If


        Catch ex As Exception
            'ModComun.MsgError(ex.Message)
            Me.TsStatusLabel.Text = ex.Message

        End Try


    End Sub

    Private Sub FrmCalendario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'SapForecastDataSet.CONSULTA_DIASFESTIVOSALL' Puede moverla o quitarla según sea necesario.
            Me.FillData()



        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try

    End Sub




    Private Sub CONSULTA_DIASFESTIVOSALLDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles CONSULTA_DIASFESTIVOSALLDataGridView.CellValidating
        If mBolConsultandoDatos = False Then
            e.Cancel = Not FnValidaCelda(e.RowIndex, e.ColumnIndex, e.FormattedValue)

        End If


    End Sub
    ''' <summary>
    ''' Valida el contenido de la celda que ya se ha editado 
    ''' </summary>
    ''' <param name="RowIndex">Renglon a validar.</param>
    ''' <param name="ColumnIndex">Columna a validar</param>
    ''' <returns>Verdadero si la celda está correcta.</returns>
    ''' <remarks></remarks>
    Private Function FnValidaCelda(ByVal RowIndex As Integer, ByVal ColumnIndex As Integer) As Boolean
        Dim intValue As Integer


        
        TsStatusLabel.Text = String.Empty

        If RowIndex > -1 And ColumnIndex > -1 Then
            'Dim mCeldaValidar As DataGridViewCell = CONSULTA_DIASFESTIVOSALLDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
            Dim mCelda As DataGridViewCell = Me.CONSULTA_DIASFESTIVOSALLDataGridView.Rows(RowIndex).Cells(ColumnIndex)




            Select Case CONSULTA_DIASFESTIVOSALLDataGridView.Columns(ColumnIndex).Name
                Case cCOLANIO


                    If Not (String.IsNullOrEmpty(mCelda.FormattedValue) Or IsNumeric(mCelda.FormattedValue)) Then
                        'CONSULTA_DIASFESTIVOSALLDataGridView.CurrentCell.ErrorText = "Error en el año"
                        TsStatusLabel.Text = "El año es invalido, dejar vacio para aplicar todos los años."
                        Return False
                    End If

                Case cCOLMES, cCOLDIA
                    If Integer.TryParse(mCelda.FormattedValue, intValue) Then
                        Select Case CONSULTA_DIASFESTIVOSALLDataGridView.Columns(ColumnIndex).Name
                            'Valida los meses correctos.
                            Case cCOLMES
                                If intValue < 0 Or intValue > 12 Then
                                    TsStatusLabel.Text = "Mes invalido elegir entre 1 y 12"
                                    Return False

                                End If
                            Case cCOLDIA
                                'Valida que los dias esten correctos.
                                Dim intMes As Integer



                                If IsDBNull(CONSULTA_DIASFESTIVOSALLDataGridView.Rows(RowIndex).Cells(cCOLMES).Value) = False AndAlso Integer.TryParse(CONSULTA_DIASFESTIVOSALLDataGridView.Rows(RowIndex).Cells(cCOLMES).Value, intMes) Then
                                    If intMes > 12 Or intMes < 0 Then
                                        TsStatusLabel.Text = "Mes invalido elegir entre 1 y 12"
                                        Return False

                                    End If


                                    Dim mArrDiasMes(0 To 12) As Integer
                                    mArrDiasMes(1) = 31
                                    mArrDiasMes(2) = 28
                                    mArrDiasMes(3) = 31
                                    mArrDiasMes(4) = 30
                                    mArrDiasMes(5) = 31
                                    mArrDiasMes(6) = 30
                                    mArrDiasMes(7) = 31
                                    mArrDiasMes(8) = 31
                                    mArrDiasMes(9) = 30
                                    mArrDiasMes(10) = 31
                                    mArrDiasMes(11) = 30
                                    mArrDiasMes(12) = 31
                                    If intValue < 0 Or intValue > mArrDiasMes(intMes) Then
                                        TsStatusLabel.Text = "Dia invalido elegir entre 1 y " & mArrDiasMes(intMes)
                                        Return False
                                    End If
                                End If

                        End Select
                    Else
                        TsStatusLabel.Text = "El dato deber ser numérico."
                        Return False

                    End If



            End Select
        End If
        Return True




    End Function
    ''' <summary>
    ''' Valida el contenido de una celda que está en proceso de edicion.
    ''' </summary>
    ''' <param name="RowIndex">Renglon que se está editando</param>
    ''' <param name="ColumnIndex">Columna que se está editando</param>
    ''' <param name="FormattedValue">Valor capturado</param>
    ''' <returns>Verdadero si la celda no tiene errores.</returns>
    ''' <remarks>Llamar  en la celda cellvalidating</remarks>
    Private Function FnValidaCelda(ByVal RowIndex As Integer, ByVal ColumnIndex As Integer, ByVal FormattedValue As String) As Boolean
        Dim intValue As Integer



        TsStatusLabel.Text = String.Empty

        If RowIndex > -1 And ColumnIndex > -1 Then
            'Dim mCeldaValidar As DataGridViewCell = CONSULTA_DIASFESTIVOSALLDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
            Dim mCelda As DataGridViewCell = Me.CONSULTA_DIASFESTIVOSALLDataGridView.Rows(RowIndex).Cells(ColumnIndex)




            Select Case CONSULTA_DIASFESTIVOSALLDataGridView.Columns(ColumnIndex).Name
                Case cCOLANIO


                    If Not (String.IsNullOrEmpty(FormattedValue) Or IsNumeric(FormattedValue)) Then
                        'CONSULTA_DIASFESTIVOSALLDataGridView.CurrentCell.ErrorText = "Error en el año"
                        TsStatusLabel.Text = "El año es invalido, dejar vacio para aplicar todos los años."
                        Return False
                    End If

                Case cCOLMES, cCOLDIA
                    If Integer.TryParse(FormattedValue, intValue) Then
                        Select Case CONSULTA_DIASFESTIVOSALLDataGridView.Columns(ColumnIndex).Name
                            'Valida los meses correctos.
                            Case cCOLMES
                                If intValue < 0 Or intValue > 12 Then
                                    TsStatusLabel.Text = "Mes invalido elegir entre 1 y 12"
                                    Return False

                                End If
                            Case cCOLDIA
                                'Valida que los dias esten correctos.
                                Dim intMes As Integer



                                If IsDBNull(CONSULTA_DIASFESTIVOSALLDataGridView.Rows(RowIndex).Cells(cCOLMES).Value) = False AndAlso Integer.TryParse(CONSULTA_DIASFESTIVOSALLDataGridView.Rows(RowIndex).Cells(cCOLMES).Value, intMes) Then
                                    Dim mArrDiasMes(0 To 12) As Integer
                                    mArrDiasMes(1) = 31
                                    mArrDiasMes(2) = 28
                                    mArrDiasMes(3) = 31
                                    mArrDiasMes(4) = 30
                                    mArrDiasMes(5) = 31
                                    mArrDiasMes(6) = 30
                                    mArrDiasMes(7) = 31
                                    mArrDiasMes(8) = 31
                                    mArrDiasMes(9) = 30
                                    mArrDiasMes(10) = 31
                                    mArrDiasMes(11) = 30
                                    mArrDiasMes(12) = 31
                                    If intValue < 0 Or intValue > mArrDiasMes(intMes) Then
                                        TsStatusLabel.Text = "Dia invalido elegir entre 1 y " & mArrDiasMes(intMes)
                                        Return False
                                    End If
                                End If

                        End Select
                    Else
                        TsStatusLabel.Text = "El dato deber ser numérico."
                        Return False

                    End If



            End Select
        End If
        Return True




    End Function

    Private Sub FillData()
        mBolConsultandoDatos = True
        Me.CONSULTA_DIASFESTIVOSALLTableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_DIASFESTIVOSALL)
    End Sub

    Private Sub CONSULTA_DIASFESTIVOSALLBindingSource_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingManagerDataErrorEventArgs) Handles CONSULTA_DIASFESTIVOSALLBindingSource.DataError
        Me.TsStatusLabel.Text = e.Exception.Message
    End Sub



    ''' <summary>
    ''' Controla cuando el usuario quiere elimar un item y pregunta si es posible.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CONSULTA_DIASFESTIVOSALLBindingNavigator_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles CONSULTA_DIASFESTIVOSALLBindingNavigator.ItemClicked
        If e.ClickedItem Is Me.BindingNavigatorDeleteItem Then
            Dim mRow As DataRowView = CType(CONSULTA_DIASFESTIVOSALLBindingNavigator.BindingSource.Current, DataRowView)

            If IsNothing(mRow) = False AndAlso mRow.Row.RowState = DataRowState.Added Then
                'El registro es nuevo por lo tanto pregunta si esta seguro de eliminar.
                If ModComun.MsgYesNo("El registro se eliminara esta seguro ?") Then
                    CONSULTA_DIASFESTIVOSALLBindingNavigator.BindingSource.RemoveCurrent()
                Else
                    Me.TsStatusLabel.Text = "Eliminación Cancelada"
                End If
            Else
                Me.TsStatusLabel.Text = "No esta permitido eliminar registro indicado."

            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try

       
        If Clipboard.ContainsText Then
            'Inicia el proceso para leer el portapapeles.
            Dim mArray() As String = Clipboard.GetText().Split(Environment.NewLine)
            For intRow = LBound(mArray) To UBound(mArray)
                Dim mRec = mArray(intRow).Split(vbTab)
                Dim mRow As DataRowView = CType(Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.BindingSource.AddNew(), DataRowView)
                For INTCOL As Integer = LBound(mRec) To UBound(mRec)
                    Select Case INTCOL
                        Case 0
                            If IsNumeric(mRec(INTCOL)) Then mRow.Row("DIA") = mRec(INTCOL)

                        Case 1
                            If IsNumeric(mRec(INTCOL)) Then mRow.Row("MES") = mRec(INTCOL)
                        Case 2
                            If IsNumeric(mRec(INTCOL)) Then mRow.Row("ANIO") = mRec(INTCOL)
                    End Select

                Next

            Next
            End If
        Catch ex As Exception
            Me.TsStatusLabel.Text = ex.Message

        End Try

    End Sub
End Class