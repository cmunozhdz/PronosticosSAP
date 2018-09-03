Imports PronosticosSAP.DjpSap
Public Class FrmConsultaPronosticoGlobal
    Dim bolSetMsg As Boolean
    Dim strMsgDescripcion As String
    Dim Ds As DataSet
    Dim dsDetalleProducto As DataSet  'Almacena los datos detallados del pronostico

    Structure ParametrosConsulta
        Dim Anio As Integer
        Dim Negocio As String

    End Structure

    Structure ParametrosConsultaDetalle
        Dim Hdr As ParametrosConsulta
        Dim Centro As String
        Dim Periodo As Integer
        Dim Producto As String


    End Structure
    Dim mPar As ParametrosConsulta
    Dim mPardt As ParametrosConsultaDetalle

    Private Sub PronosticosDgr_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Right Then
            If e.ColumnIndex > -1 AndAlso PronosticosDgr.Columns(e.ColumnIndex).DataPropertyName.Contains("BASE_") Then
                PronosticosContextMnu.Visible = True

                TsConsulta.Visible = True


            Else
                'PronosticosContextMnu.Visible = False
                TsConsulta.Visible = False

            End If

        End If
    End Sub
    Private Sub FrmConsultaPronosticoGlobal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If QryBgWk.IsBusy Then
            If ModComun.MsgYesNo("El proceso actual se cancelara ¿ está seguro? ") Then
                QryBgWk.CancelAsync()
                e.Cancel = True

            End If
        Else
            If Not ModComun.MsgYesNo("¿ está seguro de cerrar la ventana actual? ") Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FrmConsultaPronosticoGlobal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.AnioTxt.Text = Year(Today)
            Dim mList As ClassLstDivision = New ClassLstDivision()
            Me.CboDivision.DataSource = mList.GetLista()
            Me.CboDivision.DisplayMember = "Descripcion"
            Me.CboDivision.ValueMember = "Clave"
            DGAgentes.AutoGenerateColumns = True
            PronosticosDgr.AutoGenerateColumns = True
        Catch ex As Exception
            Me.SetMsg(ex.Message)

        End Try





    End Sub
    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        Try
            If QryBgWk.IsBusy Then
                Me.SetMsg("Espere se está ejecutando un proceso anterior.")
                Exit Sub
            End If
            QryErrProvider.Clear()
            If IsNothing(CboDivision.SelectedValue) Then
                QryErrProvider.SetError(CboDivision, "Elija un elemento valido")
                Exit Sub

            End If
            If IsNumeric(Me.AnioTxt.Text) = False Then
                QryErrProvider.SetError(Me.AnioTxt, "Elija un año valido para consultar")
                Exit Sub
            End If
            mPar = New ParametrosConsulta

            mPar.Anio = Me.AnioTxt.Text
            mPar.Negocio = CboDivision.SelectedValue

            AbrirToolStripButton.Enabled = False
            QryBgWk.RunWorkerAsync("P")




        Catch ex As Exception
            Me.SetMsg(ex.Message)
        End Try


    End Sub

    Private Sub QryBgWk_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles QryBgWk.DoWork
        If e.Argument.ToString = "P" Then
            'Consulta el pronostico global
            e.Result = ConsultarDatos()
        Else
            e.Result = ConsultarDetalles()

        End If


    End Sub


    Private Sub QryBgWk_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles QryBgWk.ProgressChanged
        Me.EstatusBar.Value = e.ProgressPercentage
        If bolSetMsg Then
            Me.SetMsg(strMsgDescripcion)
        End If
    End Sub

    Private Sub QryBgWk_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles QryBgWk.RunWorkerCompleted
        If e.Cancelled Then
            Me.SetMsg("Proceso cancelado")
        ElseIf Not IsNothing(e.Error) Then
            Me.SetMsg(e.Error.Message)
        Else
            Select Case CType(e.Result, Integer)

                Case 1
                    FormatearGrid()
                Case 2
                    FormatearGridDetalle()
                Case 0
                    Me.SetMsg("Procedimiento de salida invalido")

            End Select


        End If

    End Sub

#Region "CustomMethod"
    ''' <summary>
    ''' Da formato al grid cuanto termina de consultar los datos del web service
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormatearGrid()
        Try
            'Lee los periodos para después cada celda ocultar los meses.
            'Determina los periodos que ya se crearon.
            If Me.QryBgWk.CancellationPending = False Then
                PronosticosDgr.DataSource = Ds
                PronosticosDgr.DataMember = "CONSULTA_PRONOSTICOSXDIVISION"


                Dim mDtPeriodos As DataTable = Ds.Tables("CONSULTA_PERIODOSXDIVISION")

                For Each mcol As DataGridViewColumn In Me.PronosticosDgr.Columns
                    If InStr((mcol.DataPropertyName.ToString()), "ALTERNA_", CompareMethod.Text) > 0 Then
                        mcol.Visible = False
                    ElseIf InStr(mcol.DataPropertyName, "BASE_", CompareMethod.Text) > 0 Then
                        mcol.Visible = True
                        For Each mRowPeriodo As DataRow In mDtPeriodos.Rows
                            If String.Equals(mcol.DataPropertyName, "BASE_" & Trim(mRowPeriodo("INTPERIODO").ToString)) Then
                                mcol.HeaderText = String.Format("{0:MMMM -yyyy}", mRowPeriodo("SMDINICIO"))
                                mcol.DefaultCellStyle.Format = "###,###.0000"
                                mcol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                                Exit For
                            End If
                        Next
                    End If
                Next mcol
                Me.SetMsg("Proceso de consulta terminado")

            Else
                Me.SetMsg("Se cancelo el proceso ")
            End If
            Me.EstatusBar.Value = 100
            Me.AbrirToolStripButton.Enabled = True

        Catch ex As Exception
            Me.SetMsg(ex.Message)

        End Try

    End Sub
    ''' <summary>
    ''' Presenta mensajes en la barra de estado
    ''' </summary>
    ''' <param name="pMensaje"></param>
    ''' <remarks></remarks>
    Private Sub SetMsg(ByVal pMensaje As String)
        Me.EstatusTxt.Text = pMensaje

    End Sub
    ''' <summary>
    ''' Da formato al grid de consulta detallada
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FormatearGridDetalle()

        DGAgentes.DataSource = dsDetalleProducto
        DGAgentes.DataMember = "CONSULTA_MOVIMIENTOSXDIVISION"

    End Sub


    Private Function ConsultarDetalles() As Integer
        Try
            bolSetMsg = True
            strMsgDescripcion = "Iniciando comunicación con web service ... "
            QryBgWk.ReportProgress(10)

            Dim mCteWs As CteSigeProCentralWbSrv.SigeProCentralWbSrv = New CteSigeProCentralWbSrv.SigeProCentralWbSrv
            strMsgDescripcion = "web service Iniciado "
            If QryBgWk.CancellationPending = False Then
                QryBgWk.ReportProgress(20)
                strMsgDescripcion = "Consultando Datos, Espere ...."
                QryBgWk.ReportProgress(30)
            End If
            dsDetalleProducto = mCteWs.GetDsMovsPronosticosXDivision(mPardt.Hdr.Anio, mPardt.Periodo, mPardt.Centro, mPardt.Producto, mPardt.Hdr.Negocio)

            Return 2
        Catch ex As Exception
            Return 0
        End Try

    End Function
    ''' <summary>
    ''' Ejecuta el web service para consultar datos enviados al sistema central.
    ''' </summary>
    ''' <remarks></remarks>
    Private Function ConsultarDatos() As Integer
        Try
            bolSetMsg = True
            strMsgDescripcion = "Iniciando comunicación con web service ... "
            QryBgWk.ReportProgress(10)

            Dim mCteWs As CteSigeProCentralWbSrv.SigeProCentralWbSrv = New CteSigeProCentralWbSrv.SigeProCentralWbSrv
            strMsgDescripcion = "web service Iniciado "
            If QryBgWk.CancellationPending = False Then
                QryBgWk.ReportProgress(20)
                strMsgDescripcion = "Consultando Datos, Espere ...."
                QryBgWk.ReportProgress(30)

                If QryBgWk.CancellationPending = False Then
                    Ds = mCteWs.FnGetDsPronosticosXDivision(mPar.Anio, mPar.Negocio, String.Empty, "S")
                    strMsgDescripcion = "Espere ...."
                    QryBgWk.ReportProgress(50)
                End If


            End If
            Return 1 'Termino ok

            'Asigna los valores al grid.

            'Define los formatos de las columnas
        Catch ex As Exception

            Me.SetMsg(ex.Message)
            Return 0 'Termino con error
        End Try



    End Function
    Private Function FnIndexCol(ByVal pValCampo As String) As Integer
        Dim intIndex As Integer = -1
        For Each mCol As DataGridViewColumn In Me.PronosticosDgr.Columns
            If mCol.DataPropertyName.Equals(pValCampo) Then
                intIndex = mCol.Index
                Exit For
            End If
        Next
        Return intIndex

    End Function
#End Region






    Private Sub TsConsultaContextMnu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TsConsulta.Click


        If Me.PronosticosDgr.CurrentCell.ColumnIndex > -1 AndAlso
          Me.PronosticosDgr.Columns(Me.PronosticosDgr.CurrentCell.ColumnIndex).DataPropertyName.Contains("BASE_") Then
            mPardt = New ParametrosConsultaDetalle
            With mPardt
                .Hdr = mPar
                .Periodo = Me.PronosticosDgr.Columns(Me.PronosticosDgr.CurrentCell.ColumnIndex).DataPropertyName.Replace("BASE_", String.Empty)


                Dim mIndex As Integer = Me.FnIndexCol("CLAVECENTRO")
                If mIndex > -1 Then
                    .Centro = Me.PronosticosDgr.Rows(Me.PronosticosDgr.CurrentCell.RowIndex).Cells(mIndex).Value
                Else
                    Me.SetMsg("No ha sido posible identificar el centro ")

                    Exit Sub
                End If

                mIndex = Me.FnIndexCol("CLAVEPRODUCTO")
                If mIndex > -1 Then
                    .Producto = Me.PronosticosDgr.Rows(Me.PronosticosDgr.CurrentCell.RowIndex).Cells(mIndex).Value
                Else
                    Me.SetMsg("No ha sido posible identificar el producto ")
                    Exit Sub
                End If



            End With
            QryBgWk.RunWorkerAsync("D")
        Else
            Me.SetMsg("Elija una registro correcto")




        End If

    End Sub

   
End Class