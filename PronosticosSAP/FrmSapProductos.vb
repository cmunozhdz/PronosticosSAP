Imports System.Data.SqlClient
Imports System.Data
Imports PronosticosSAP.DjpSap

Public Class FrmSapProductos

    Dim mDs As DataSet '= objCteWs.FnGetDsSapPRODUCTOS(Me.ProductoTxt.Text, Me.DescripcionTxt.Text, Me.NegocioTxt.Text, Me.FechaTxt.Text)

    Dim mDvCentro As DataView
    Dim mDvUnidadMedida As DataView
    Dim mFecha As Integer
    Dim mClave As Nullable(Of Integer)

    Dim mDescripcion As String
    Dim mNegocio As String

    Const CTETABLAPRODUCTOSSAP As String = "GET_MARA"
    Const CTETABLAPRODUCTOALMACEN As String = "GET_MARD"
    Const CTETABLAPRODUCTOUDM As String = "GET_MATNR" 'Tabla de unidades de medida.
    Private strMsgError As String
    Enum enProcesoAsync
        enConsultas = 1
        enGuardar = 2
        enErrorGuardar = 3
        enErorrConsultar = 4

    End Enum
    Enum enTipoProcesoAsync
        enConsultar = 0
        enGuardar = 1

    End Enum
    ''' <summary>
    ''' Actuliza los catalogos de productos, prodcuto almacen y unidades de medida.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Guardar() As enProcesoAsync
        'Obtiene la lista de produdtos
        Dim mTra As SqlTransaction = Nothing
        Try

        
        Const CTEPRODUCTO As String = "MATNR"
        Const CTECVEANTERIOR As String = "BISMT"
        Dim mCon As SqlClient.SqlConnection = DjpSap.Dac.mConexion 'Abre la conexion de la base datos.
            mTra = mCon.BeginTransaction()

        Dim mCmd As SqlCommand = New SqlCommand
        Dim mParRet = New SqlParameter()
        Dim intRow As Integer = 1
        With mCmd
            .Connection = mCon
            .Transaction = mTra
            .CommandType = CommandType.StoredProcedure
            .CommandText = "CATALOGOS.INSERTA_PRODUCTO"
            mParRet.Direction = ParameterDirection.ReturnValue
            .Parameters.Add(mParRet)
            .Parameters.Add("@CLAVE", SqlDbType.VarChar, 100)
            .Parameters.Add("@CLAVEANTERIOR", SqlDbType.VarChar, 100)
            .Parameters.Add("@DESCRIPCION", SqlDbType.VarChar, 255)
            .Parameters.Add("@DESCRIPCION_DETALLE", SqlDbType.VarChar, 255)
            .Parameters.Add("@TIPO", SqlDbType.VarChar, 255)
            .Parameters.Add("@NEGOCIO", SqlDbType.Char, 1)

            .Parameters.Add("@UNIDADMEDIDA", SqlDbType.Char, 5)
            .Parameters.Add("@CREADO", SqlDbType.DateTime)
            .Parameters.Add("@MODIFICACION", SqlDbType.DateTime)
            .Parameters.Add("@STATUS", SqlDbType.Char, 1)

            For Each mRow As DataRow In mDs.Tables(CTETABLAPRODUCTOSSAP).Rows
                'Actualiza la vista de producto almacen

                intRow += 1
                strMsgError = "Actualizando producto:" & mRow(CTEPRODUCTO)
                ProductosBW.ReportProgress((intRow / mDs.Tables(CTETABLAPRODUCTOSSAP).Rows.Count) * 33)
                .Parameters("@CLAVE").Value = mRow(CTEPRODUCTO)


                .Parameters("@CLAVEANTERIOR").Value = mRow(CTECVEANTERIOR)
                .Parameters("@DESCRIPCION").Value = mRow("MAKTX")
                .Parameters("@DESCRIPCION_DETALLE").Value = mRow("MAKTG")
                .Parameters("@TIPO").Value = mRow("MTART")
                .Parameters("@NEGOCIO").Value = mRow("NEGOCIO")

                .Parameters("@UNIDADMEDIDA").Value = mRow("MEINS")
                    .Parameters("@CREADO").Value = ModComun.GetDate(mRow("ERSDA").ToString())


                    .Parameters("@MODIFICACION").Value = ModComun.GetDate(mRow("LAEDA").ToString())
                .Parameters("@STATUS").Value = mRow("STATUS")
                .ExecuteNonQuery()
                    If mParRet.Value <> 1 OrElse ProductosBW.CancellationPending Then
                        'eXISTE ERROR
                        mTra.Rollback()
                        mCon.Close()
                        strMsgError = "No se pudo actualizar el producto" & mRow(CTEPRODUCTO)
                        Return enProcesoAsync.enErrorGuardar
                    End If
                    

            Next
        End With
            'Actualiza la relacion producto almacen
            If ProductosBW.CancellationPending = False Then
                strMsgError = "Actualizando Producto Almacen"
                ProductosBW.ReportProgress(33)
                intRow = 1
                Dim mCmdPRODALM As SqlCommand = New SqlCommand
                With mCmdPRODALM
                    .Connection = mCon
                    .Transaction = mTra
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "CATALOGOS.INSERTA_PRODUCTOXALMACEN"
                    mParRet = New SqlParameter
                    mParRet.Direction = ParameterDirection.ReturnValue
                    .Parameters.Add(mParRet)
                    .Parameters.Add("@CLAVEPRODUCTO", SqlDbType.Char, 10)
                    .Parameters.Add("@CLAVECENTRO", SqlDbType.Char, 5)
                    .Parameters.Add("@CLAVEALMACEN", SqlDbType.Char, 5)
                    .Parameters.Add("@STATUS", SqlDbType.Char, 1)
                    .Parameters.Add("@APLICA_PRONOSTICO", SqlDbType.Char, 1)
                    For Each mRow As DataRow In mDs.Tables(CTETABLAPRODUCTOALMACEN).Rows
                        intRow += 1
                        ProductosBW.ReportProgress((intRow / mDs.Tables(CTETABLAPRODUCTOALMACEN).Rows.Count) * 100)



                        strMsgError = "Actualizando producto Almacen:" & mRow(CTEPRODUCTO) & "-" & mRow("WERKS")

                        .Parameters("@CLAVEPRODUCTO").Value = mRow(CTEPRODUCTO)
                        .Parameters("@CLAVECENTRO").Value = mRow("WERKS")
                        .Parameters("@CLAVEALMACEN").Value = mRow("LGORT")
                        .Parameters("@STATUS").Value = "A"
                        .Parameters("@APLICA_PRONOSTICO").Value = "S"
                        .ExecuteNonQuery()
                        If mParRet.Value <> 1 OrElse ProductosBW.CancellationPending Then
                            mTra.Rollback()
                            mCon.Close()
                            strMsgError = "No se pudo actualizar el producto ALMACEN" & mRow(CTEPRODUCTO) & "," & mRow("WERKS")
                            Return enProcesoAsync.enErrorGuardar
                        End If
                    Next

                End With
                'Actualiza la lista de productos y unidades de medida.
                'Se ha cancelado el proceso de actualizacion

                If ProductosBW.CancellationPending = False Then
                    Dim mCmdUDM As SqlCommand = New SqlCommand
                    With mCmdUDM
                        .Connection = mCon
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "CATALOGOS.INSERTA_PRODUCTOXUDM"

                        mParRet = New SqlParameter
                        mParRet.Direction = ParameterDirection.ReturnValue
                        .Parameters.Add(mParRet)
                        .Parameters.Add("@CLAVE", SqlDbType.Char, 10)
                        .Parameters.Add("@UDMBASE", SqlDbType.Char, 5)
                        .Parameters.Add("@UDMALTERNA", SqlDbType.Char, 5)
                        .Parameters.Add("@OPERADOR", SqlDbType.Char, 1)
                        .Parameters.Add("@FACTOR", SqlDbType.Decimal)
                        .Parameters.Add("@EXACTA", SqlDbType.Bit)
                        .Parameters.Add("@STATUS", SqlDbType.Char, 1)
                        .Transaction = mTra
                        intRow = 0
                        For Each mRowUdm As DataRow In mDs.Tables(CTETABLAPRODUCTOUDM).Rows
                            intRow += 1
                            ProductosBW.ReportProgress((intRow / mDs.Tables(CTETABLAPRODUCTOUDM).Rows.Count) * 100)
                            strMsgError = "Actualizando Unidades de medida Producto:" & mRowUdm(CTEPRODUCTO)
                            .Parameters("@CLAVE").Value = mRowUdm(CTEPRODUCTO)
                            .Parameters("@UDMBASE").Value = mRowUdm("MEINS")
                            .Parameters("@UDMALTERNA").Value = mRowUdm("MEINH")
                            .Parameters("@OPERADOR").Value = mRowUdm("OPERADOR")
                            .Parameters("@FACTOR").Value = mRowUdm("UMREZ")
                            .Parameters("@EXACTA").Value = mRowUdm("Exacto")
                            .Parameters("@STATUS").Value = "A"
                            .ExecuteNonQuery()
                            If mParRet.Value <> 1 OrElse ProductosBW.CancellationPending Then
                                mTra.Rollback()
                                mCon.Close()
                                strMsgError = "No se pudo actualizar el Unidades de Medida Alterna :" & mRowUdm(CTEPRODUCTO) & "," & mRowUdm("MEINH")
                                Return enProcesoAsync.enErrorGuardar
                            End If
                        Next
                    End With
                    
                End If
                

                'Actualiza las unidades de medida.


                mTra.Commit() 'Confirma las transacciones pendientes

            End If
        
            mCon.Close()
            Return enProcesoAsync.enGuardar
        Catch ex As Exception
            strMsgError = ex.Message
            If Not IsNothing(mTra) Then
                If Not IsNothing(mTra.Connection) Then
                    mTra.Rollback()
                    'mTra.Connection.Close()
                End If
            End If
            Return enProcesoAsync.enErrorGuardar
        End Try




    End Function

    ''' <summary>
    ''' Genera dataset de informacion proveniente del servidor de forecastsap.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function ConsultarSap() As enProcesoAsync

        Try

            strMsgError = "Iniciando web service"
            ProductosBW.ReportProgress(10)

            Dim objCteWs As CteSigeProCentralWbSrv.SigeProCentralWbSrv = New CteSigeProCentralWbSrv.SigeProCentralWbSrv
            strMsgError = "web service iniciado"
            ProductosBW.ReportProgress(20)

            mDs = objCteWs.FnGetDsSapPRODUCTOS(mClave, mDescripcion, mNegocio, mFecha)
            strMsgError = "Formateando Informacion"
            ProductosBW.ReportProgress(80)
            mDvCentro = New DataView(mDs.Tables(CTETABLAPRODUCTOALMACEN))
            mDvUnidadMedida = New DataView(mDs.Tables(CTETABLAPRODUCTOUDM))


            strMsgError = "Terminado Proceso de consultas"
            ProductosBW.ReportProgress(90)

            Return enProcesoAsync.enConsultas



        Catch ex As Exception
            strMsgError = ex.Message
            Return enProcesoAsync.enErorrConsultar

        End Try






    End Function
    Private Function FnValidarCtrl() As Boolean


        If String.IsNullOrEmpty(Me.FechaTxt.Text) Then
            mFecha = 0
        Else
            If IsNumeric(Me.FechaTxt.Text) Then
                mFecha = Me.FechaTxt.Text
            Else
                'ModComun.MsgError("La fecha debe ser un dato numerico")
                ProdSapErrProvider.SetError(Me.FechaTxt, "Indicar una fecha correcta")
                Return False
            End If
        End If

        If String.IsNullOrEmpty(Me.ProductoTxt.Text) OrElse String.IsNullOrEmpty(Trim(Me.ProductoTxt.Text)) Then
            mClave = Nothing
        Else
            If IsNumeric(Me.ProductoTxt.Text) Then

                mClave = Me.ProductoTxt.Text

            Else
                ProdSapErrProvider.SetError(Me.ProductoTxt, "La clave debe ser un dato numerico")
                Return False
            End If
        End If

        If String.IsNullOrEmpty(Me.DescripcionTxt.Text) OrElse String.IsNullOrEmpty(Trim(Me.DescripcionTxt.Text)) Then
            mDescripcion = Nothing
        Else
            mDescripcion = Me.DescripcionTxt.Text.Replace("*", "%").ToUpper()
        End If

        If String.IsNullOrEmpty(CboDivision.SelectedValue) OrElse String.IsNullOrEmpty(Trim(CboDivision.SelectedValue)) OrElse "IAE".Contains(CboDivision.SelectedValue.ToUpper) = False Then
            ProdSapErrProvider.SetError(CboDivision, "Indique un negocio A:Agricola o I:Industrial")
            Return False
        Else
            mNegocio = CboDivision.SelectedValue.ToString.ToUpper
        End If
        Return True


    End Function

    Private Sub ProductosDG_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDG.CellClick ', ProductosDG.SelectionChanged
        If e.RowIndex > -1 Then
            DataviewRefresh()
        End If
    End Sub
    Private Sub DataviewRefresh()
        For Each mCol As DataGridViewColumn In ProductosDG.Columns
            If mCol.DataPropertyName.ToString.Equals("MATNR") Then
                dVSetFilter(ProductosDG.CurrentRow.Cells(mCol.Index).Value)


                Exit For
            End If
        Next
    End Sub

    Private Function dVSetFilter(ByVal PRODUCTO As String) As Boolean
        Try
            Dim mstrFiltro As String = "MATNR='" & PRODUCTO & "'"
            mDvCentro.RowFilter = mstrFiltro
            mDvUnidadMedida.RowFilter = mstrFiltro
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function




    Private Sub AbrirToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        'ConsultarSap()
        If Not ProductosBW.IsBusy Then
            Me.AbrirToolStripButton.Enabled = False
            Me.GuardarToolStripButton.Enabled = False

            If Me.FnValidarCtrl() Then
                Me.ProductosBW.RunWorkerAsync(enTipoProcesoAsync.enConsultar)
            Else
                Me.AbrirToolStripButton.Enabled = True
            End If
        Else
            Me.SetMsg("Espere se está ejecutando un proceso")

        End If
        

    End Sub

    Private Sub ProductosBW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ProductosBW.DoWork
        Try
            
                Dim mIdProceso As enTipoProcesoAsync = CType(e.Argument, enTipoProcesoAsync)

                Select Case mIdProceso
                    Case enTipoProcesoAsync.enConsultar
                        e.Result = ConsultarSap()

                    Case enTipoProcesoAsync.enGuardar
                        e.Result = Guardar()

                End Select

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ProductosBW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles ProductosBW.ProgressChanged

        TpProgressBar.Value = e.ProgressPercentage Mod 100
        Me.SetMsg(strMsgError)

    End Sub

    Private Sub ProductosBW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ProductosBW.RunWorkerCompleted
        Try
            If e.Cancelled Then
                Me.SetMsg("Proceso Cancelado")
            ElseIf IsNothing(e.Error) = False Then
                Me.SetMsg(e.Error.Message)
            Else
                Dim mRes As enProcesoAsync = CType(e.Result, enProcesoAsync)
                Select Case mRes
                    Case enProcesoAsync.enConsultas

                        Me.ProductosDG.DataSource = mDs
                        Me.ProductosDG.DataMember = CTETABLAPRODUCTOSSAP
                        Me.ProductosDG.Refresh()

                        Me.ProductosAlmacenDg.DataSource = mDvCentro
                        Me.UnidadeMedidaDG.DataSource = mDvUnidadMedida

                        TpProgressBar.Value = 100
                        Me.AbrirToolStripButton.Enabled = True
                        Me.GuardarToolStripButton.Enabled = True

                    Case enProcesoAsync.enGuardar
                        Me.SetMsg("Se han actualizado los catalogos")
                        GuardarToolStripButton.Enabled = True
                        Me.AbrirToolStripButton.Enabled = True
                        TpProgressBar.Value = 100

                    Case enProcesoAsync.enErorrConsultar, enProcesoAsync.enErrorGuardar

                        Me.SetMsg(Me.strMsgError)
                        If enProcesoAsync.enErorrConsultar Then
                            Me.AbrirToolStripButton.Enabled = True
                            Me.GuardarToolStripButton.Enabled = False
                        Else
                            Me.AbrirToolStripButton.Enabled = True
                            Me.GuardarToolStripButton.Enabled = True

                        End If

                End Select


            End If
        Catch ex As Exception
            SetMsg(ex.Message)
        End Try



    End Sub

    Private Sub SetMsg(ByVal pstrMensaje As String)
        ToolStripMsg.Text = Mid(pstrMensaje, 1, 250)

    End Sub


    Private Sub ProductosDG_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductosDG.SelectionChanged

        'If ProductosDG.SelectedRows.Count = 1 Then
        If Not IsNothing(ProductosDG.CurrentRow) Then
            If ProductosDG.CurrentRow.IsNewRow = False Then
                DataviewRefresh()
            End If

        End If
        
        'End If


    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        'valida que haya datos a guardar.
        'If mDs.Tables() Then
        If ModComun.MsgYesNo("Este proceso actualizará su catalogo de productos con el resultado de la consulta a SAP" & _
                               Environment.NewLine & "¿ Desea continuar ?") Then

            GuardarToolStripButton.Enabled = False
            If Not ProductosBW.IsBusy Then
                ProductosBW.RunWorkerAsync(enTipoProcesoAsync.enGuardar)
            Else
                SetMsg("Espere se está ejecutando un proceso")

            End If
        End If
        



    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()

    End Sub

    Private Sub FrmSapProductos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ProductosBW.IsBusy Then

            If ModComun.MsgYesNo("El proceso actual será cancelado" & Environment.NewLine & "¿ Esta seguro ?") Then
                If ProductosBW.CancellationPending = False Then
                    ProductosBW.CancelAsync()
                End If
                e.Cancel = True


            End If
        Else
            e.Cancel = Not ModComun.MsgYesNo("¿Desea cerrar la ventana actual ?")
        End If



    End Sub

    Private Sub ProductosDG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDG.CellContentClick

    End Sub

    Private Sub FrmSapProductos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mLst As ClassLstDivision = New ClassLstDivision
        Me.CboDivision.DataSource = mLst.GetLista()
        Me.CboDivision.ValueMember = "Clave"
        Me.CboDivision.DisplayMember = "Descripcion"
    End Sub
End Class