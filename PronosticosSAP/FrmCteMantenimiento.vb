Imports System.Data
Imports System.Data.SqlClient

Public Class FrmCteMantenimiento
#Region "Declaraciones"
    Private Structure structCliente
        Dim ClaveCliente As String
        Dim ClienteRazonSocial As String

        Dim Sociedad As String
        Dim Vigencia As Date
        Dim Agente As String

    End Structure

    Const CTE_HELP As String = "30100"
    Enum enProcesoWK
        enError = -1
        enSincronizarOk = 1
        enConsultarOk = 2

    End Enum
    Dim mDs As DataSet = New DataSet
    Dim mCurrenRow As Integer = -1
    Dim mTranOperacion As SqlTransaction
    Private mCurrentCliente As structCliente

    Dim Ta As SqlDataAdapter = New SqlDataAdapter
    Dim CteProductoBS As BindingSource = New BindingSource
    Dim mParVerCtesVigentes As String


    Private Const CTE_TABLA = "clientes"
    Private Const CTE_TABLAPRODUCTO = "AGENTE_CLIENTE_PRODUCTO"

    '*************************************************
    '*Columnas del grid de agente_cliente
    '*************************************************
    Private Const HDR_SOCIEDAD As String = "COLSOCIEDAD"
    Private Const HDR_CTE As String = "COLCTE"
    Private Const HDR_VIGENCIA As String = "COLVIGENCIA"
    Private Const HDR_AGENTE As String = "COLAGENTE"


    '*************************************************
    '*Columnas del grid de producto cliente
    '*************************************************
    Private Const CTE_COLBTNCENTRO = "BTNCENTRO"
    Private Const CTE_COLPRODUCTO = "PRCTE_COLPRODUCTO"
    Private Const CTE_COLCENTRO = "PRCTE_COLCENTRO"

    Private Const CTE_COLBTNPRODUCTO = "ColBuscarProducto"
    Private Const CTE_COLAGENTE = "PRCTE_COLAGENTE"
    Private Const CTE_COLSOCIEDAD = "PRCTE_COLSOCIEDAD"

    Private Const CTE_COLCTE = "PRCTE_COLAGENTE_COLCLAVECTE"
    Private Const CTE_COLPOSICION = "ID"
    Private MSGERRORSINGUARDAR As String

#End Region
#Region "MetodosPersonalizados"
    Private Function FnGetAgente() As Boolean
        Dim mAgente As ClassVendedor = New ClassVendedor()
        mAgente.Clave = Me.IdAgenteTxt.Text
        If String.IsNullOrEmpty(mAgente.Clave) = False Then
            If mAgente.ConsultarCatalogo() > 0 Then
                Me.LBlCteDesc.Text = mAgente.Descripcion
                Return True
            Else
                Me.LBlCteDesc.Text = "Agente No Existe."
                Return False
            End If
        Else
            Me.IdAgenteTxt.Focus()

            Me.MsgErrProvider.SetError(Me.IdAgenteTxt, "La clave del agente es un dato obligatorio")
            Return False
        End If

        



    End Function
    Private Function FnValidarPerderCambios(ByVal pCurrenValorId) As Boolean
        If mDs.HasChanges = False OrElse ModComun.MsgYesNo(MSGERRORSINGUARDAR) Then
            Me.InicializarCtrl(pCurrenValorId)
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub InicializarCtrl(ByVal pCurrenValorId As String)
        Try
            Dim MCTE_ERROR As String = "Elja un cliente antes de editar"
            IdAgenteTxt.Text = pCurrenValorId
            'CteProductoBS.DataMember = CTE_TABLAPRODUCTO
            ClienteProductoDg.DataSource = Nothing
            ClienteDg.DataSource = Nothing

            LblSociedadSeleccionada.Text = MCTE_ERROR
            CteSeleccionadoLbl.Text = MCTE_ERROR
            CentroSeleccionadoLbl.Text = MCTE_ERROR
            CaducidadLabel.Text = MCTE_ERROR
            ClientesTab.SelectTab(0)
        Catch ex As Exception
            ModComun.MsgError(ex.Message)
        End Try



    End Sub
    Private Sub ActualizarCtesProductos(ByVal rowIndex As Integer)
        'Actualiza el valor que indica la celda que está modificandose

        If Me.FnValidaCambios() Then
            mCurrenRow = rowIndex
            ConsultaCteProducto()
        End If
    End Sub
    ''' <summary>
    ''' Indica si la fila deproducto cliente puede o no ser eliminada.
    ''' </summary>
    ''' <param name="pCelda"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function FnValidarEliminarCteProducto(ByVal pCelda As DataGridViewCell) As Boolean


        If Not IsNothing(pCelda.Value) AndAlso Not (pCelda.Value.ToString.Equals(DBNull.Value.ToString)) Then
            ModComun.MsgError("Eliminacion no permitida")
            Return False
        Else
            Return True
        End If

    End Function
    ''' <summary>
    ''' Devuelve un valor verdadero cuando el dataset tiene cambios.
    ''' </summary>
    ''' <returns>Verdadero</returns>
    ''' <remarks></remarks>
    Private Function FnValidaCambios() As Boolean

        If mDs.HasChanges Then


            If Not ModComun.MsgYesNo("Se perderán los datos no guardados" & Environment.NewLine & "¿ Está seguro ?") Then
                If Me.mCurrenRow > -1 Then
                    ClienteDg.CurrentCell = ClienteDg.Rows(Me.mCurrenRow).Cells(HDR_CTE)
                    ClientesTab.SelectedTab = ProductosTab
                End If
                Return False
            End If
        End If
        Return True
    End Function

    ''' <summary>
    ''' Establece los valores por default del renglon que se esta editando,
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetDefaultValues(ByVal pRowIndex As Integer)
        If mCurrenRow > -1 Then
            Dim mRow = Me.ClienteDg.Rows(mCurrenRow)
            'Determina el cliente que se está modificando

            With ClienteProductoDg.Rows(pRowIndex)
                'Asigna los valores del cliente y producto
                .Cells(CTE_COLAGENTE).Value = mRow.Cells(HDR_AGENTE).Value
                .Cells(CTE_COLSOCIEDAD).Value = mRow.Cells(HDR_SOCIEDAD).Value
                .Cells(CTE_COLCTE).Value = mRow.Cells(HDR_CTE).Value

            End With
        End If
    End Sub

    ''' <summary>
    ''' Muestra la pantalla para elegir un producto y el valor devuelto lo asigna al renglon actual
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuscarProducto()

        Try

            If IsNothing(ClienteDg.CurrentRow) OrElse (ClienteDg.CurrentRow.Index = -1) Then
                Me.TsLabelMsg.Text = "Seleccione un registro"
                Exit Sub
            End If
            Dim mRowActual As DataGridViewRow = ClienteProductoDg.CurrentRow


            If mRowActual.Index > -1 Then
                SetDefaultValues(mRowActual.Index)
                Dim mFrm = New FrmConsultaProductoByCentro

                'Determina la sociedad para solo traer productos Industriales.
                With mRowActual
                    mFrm.strSociedad = .Cells(CTE_COLSOCIEDAD).Value.ToString
                    mFrm.ShowDialog()

                    If mFrm.DialogResult = DialogResult.Yes Then
                        'La clave del producto es asignada automaticamente

                        .Cells(CTE_COLPRODUCTO).Value = mFrm.ObjItem.Producto.Clave
                        .Cells(CTE_COLCENTRO).Value = mFrm.ObjItem.Centro.Clave


                    End If
                End With
                mFrm.Dispose()
                Me.TsLabelMsg.Text = "Producto asignado"
            End If
        Catch ex As Exception
            ModComun.MsgError(ex.Message)
        End Try



    End Sub
    ''' <summary>
    ''' Obtiene la lista de productos asignados por cliente
    ''' </summary>
    ''' <remarks>Define los metodos de consulta y actualizacion a la base de datos </remarks>

    Private Sub ConsultaCteProducto()
        'Actualiza el contenido del grid actual
        Try
            If mCurrenRow > -1 Then

                Dim mRow = Me.ClienteDg.Rows(mCurrenRow)
                Dim mCon As SqlConnection = DjpSap.Dac.mConexion()
                mCurrentCliente = New structCliente
                With mCurrentCliente
                    .ClaveCliente = mRow.Cells("COLCTE").Value
                    .ClienteRazonSocial = mRow.Cells("COLRAZON").Value
                    .Agente = mRow.Cells("COLAGENTE").Value
                    .Sociedad = mRow.Cells(HDR_SOCIEDAD).Value
                    .Vigencia = mRow.Cells(HDR_VIGENCIA).Value
                    LblSociedadSeleccionada.Text = String.Format("Sociedad:{0}", .Sociedad)
                    CteSeleccionadoLbl.Text = String.Format("Agente:{0}.-{1}", .Agente, mRow.Cells("AGENTENOMBRE").Value)
                    CentroSeleccionadoLbl.Text = String.Format("Cliente:{0}.-{1}", .ClaveCliente, .ClienteRazonSocial)
                    CaducidadLabel.Text = String.Format("VIGENCIA:{0:dd-MMM-yyyy}", .Vigencia)
                    If Date.Compare(Today, .Vigencia) > 0 Then
                        'El cliente ya no está vigente.
                        CaducidadLabel.ForeColor = Color.Red
                    Else
                        CaducidadLabel.ForeColor = Color.Navy
                    End If

                End With






                Dim td As DataTable
                If IsNothing(mDs.Tables(CTE_TABLAPRODUCTO)) Then
                    td = mDs.Tables.Add(CTE_TABLAPRODUCTO)
                Else
                    td = mDs.Tables(CTE_TABLAPRODUCTO)
                    td.Rows.Clear()
                End If
                Dim mCmd As SqlCommand = New SqlCommand()
                With mCmd

                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "CATALOGOS.GET_AGENTE_CLIENTE_PRODUCTO"
                    .Connection = mCon
                    .Parameters.AddWithValue("@AGENTE", mCurrentCliente.Agente)
                    .Parameters.AddWithValue("@SOCIEDAD", mCurrentCliente.Sociedad)
                    .Parameters.AddWithValue("@CLIENTE", mCurrentCliente.ClaveCliente)

                End With
                Ta.SelectCommand = mCmd
                Dim mInsCmd = New SqlCommand()
                With mInsCmd

                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "CATALOGOS.INSERTA_AGENTECLIENTE"
                    .Connection = mCon
                    .Parameters.Add("@CVEAGENTE", System.Data.SqlDbType.Char, 10, "CLAVEAGENTE")
                    .Parameters.Add("@CVECTE", System.Data.SqlDbType.Char, 10, "CLAVECLIENTE")
                    .Parameters.Add("@SOCIEDAD", System.Data.SqlDbType.Char, 4, "CLAVESOCIEDAD")
                    .Parameters.Add("@CVEPRODUCTO", System.Data.SqlDbType.Char, 10, "CLAVEPRODUCTO")
                    .Parameters.Add("@CVECENTRO", System.Data.SqlDbType.Char, 10, "CLAVECENTRO")
                    .Parameters.Add("@VIGENCIA", System.Data.SqlDbType.DateTime, 10, "VIGENCIA")

                End With
                Ta.InsertCommand = mInsCmd
                Dim mUpdCmd = New SqlCommand()
                With mUpdCmd

                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "CATALOGOS.ACTUALIZA_AGENTECLIENTE"
                    .Connection = mCon

                    .Parameters.Add("@idRow", System.Data.SqlDbType.Int, 8, "ID")
                    .Parameters.Add("@CVEAGENTE", System.Data.SqlDbType.Char, 10, "CLAVEAGENTE")
                    .Parameters.Add("@CVECTE", System.Data.SqlDbType.Char, 10, "CLAVECLIENTE")
                    .Parameters.Add("@SOCIEDAD", System.Data.SqlDbType.Char, 4, "CLAVESOCIEDAD")
                    .Parameters.Add("@CVEPRODUCTO", System.Data.SqlDbType.Char, 10, "CLAVEPRODUCTO")
                    .Parameters.Add("@CVECENTRO", System.Data.SqlDbType.Char, 10, "CLAVECENTRO")
                    .Parameters.Add("@VIGENCIA", System.Data.SqlDbType.DateTime, 10, "VIGENCIA")

                End With


                Ta.UpdateCommand = mUpdCmd


                Ta.Fill(td)
                mCon.Close()

                'mDs.Tables.Add(td)
                CteProductoBS.DataSource = mDs
                CteProductoBS.DataMember = CTE_TABLAPRODUCTO
                ClienteProductoDg.DataSource = CteProductoBS
                'CteProductoDg.DataMember = CTE_TABLAPRODUCTO
                TsLabelMsg.Text = "Proceso terminado"


            Else
                CteSeleccionadoLbl.Text = "No se ha seleccionado cliente."
                CentroSeleccionadoLbl.Text = "No se ha seleccionado sociedad."
                TsLabelMsg.Text = "Seleccione un registro valido"
                Me.ClientesTab.SelectedTab = CteAgteTab
                ClienteDg.Focus()

            End If
        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try

    End Sub
    ''' <summary>
    ''' Obtiene la lista de productos asignados al agente seleccionado.
    ''' </summary>
    ''' <param name="pIdAgente">Clave del agente.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Consultar(ByVal pIdAgente As String, ByVal pSoloVigentes As String) As enProcesoWK
        ClientesWKGW.ReportProgress(10)

        Dim mCon As SqlConnection = DjpSap.Dac.mConexion
        ClientesWKGW.ReportProgress(20)
        Dim mCmd As SqlCommand = New SqlCommand
        ClientesWKGW.ReportProgress(30)
        Dim mTd As DataTable
        With mCmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "CATALOGOS.GET_CLIENTESBYAGENTE"
            .Parameters.AddWithValue("@CLAVEAGENTE", pIdAgente)
            .Parameters.AddWithValue("@VIGENTES", pSoloVigentes)
            .Connection = mCon
        End With
        ClientesWKGW.ReportProgress(40)
        Dim mTa As SqlDataAdapter = New SqlDataAdapter()
        ClientesWKGW.ReportProgress(50)
        mTa.SelectCommand = mCmd
        If Not IsNothing(mDs.Tables(CTE_TABLA)) Then
            mTd = mDs.Tables(CTE_TABLA)
            mTd.Rows.Clear()

        Else
            mTd = New DataTable(CTE_TABLA)
            mDs.Tables.Add(mTd)
        End If
        mTa.Fill(mTd)

        mCon.Close()
        ClientesWKGW.ReportProgress(90)
        mDs.AcceptChanges()

        Return enProcesoWK.enConsultarOk
    End Function


    ''' <summary>
    ''' Obtiene la lista de clientes existentes en el web services.
    ''' Actualizando la copia local 
    ''' </summary>
    ''' <param name="pIdAgente">Agente a consultar </param>
    ''' <returns>enProcesoWK.enSincronizarOk </returns>
    ''' <remarks>Devuelve enProcesoWK.enError si el proceso llega a fallar</remarks>
    Function FnSinCronizar(ByVal pIdAgente As String) As enProcesoWK
        'Obtiene la lista de productos 
        'existentes en el web service
        Dim mBolEstatus As enProcesoWK = enProcesoWK.enError

        Dim mTran As SqlTransaction = Nothing
        Dim mCon As SqlConnection = Nothing
        Try

            Dim mFechaProceso As Date = #1/1/2013#
            'Obtiene la fecha de ultima actualizacion.
            'ClientesWKGW.WorkerReportsProgress = 10
            ClientesWKGW.ReportProgress(10)
            Dim mCteWs As CteSigeProCentralWbSrv.SigeProCentralWbSrv = New CteSigeProCentralWbSrv.SigeProCentralWbSrv
            ClientesWKGW.ReportProgress(20)

            Dim mDs As DataSet = mCteWs.GetClientes(pIdAgente, mFechaProceso)
            ClientesWKGW.ReportProgress(30)

            'Crea Instancia a stored procedure 
            mCon = DjpSap.Dac.mConexion
            ClientesWKGW.ReportProgress(40)
            Dim mCmd As SqlCommand = New SqlCommand

            With mCmd
                .Connection = mCon
                .CommandType = CommandType.StoredProcedure
                .CommandText = "CATALOGOS.ADD_CLIENTES"
                Dim mPar As New SqlParameter
                mPar.Direction = ParameterDirection.ReturnValue
                .Parameters.Add(mPar)
                .Parameters.Add("@SOCIEDAD", System.Data.SqlDbType.Char, 4)
                .Parameters.Add("@CLAVECLIENTE", System.Data.SqlDbType.Char, 10)
                .Parameters.Add("@RAZONSOCIAL", System.Data.SqlDbType.Char, 255)
                .Parameters.Add("@CVEAGENTE", System.Data.SqlDbType.Char, 10)
                .Parameters.Add("@CHR_ORIGEN", System.Data.SqlDbType.Char, 1)


                'CATALOGOS.ADD_CLIENTES(@SOCIEDAD CHAR(4), @CLAVECLIENTE CHAR(10),@RAZONSOCIAL VARCHAR(255) )

            End With
            mTran = mCon.BeginTransaction

            mCmd.Transaction = mTran
            Dim intRow As Integer = 0

            'Establece la vigencia de los clientes al dia  de hoy cuando un cliente ya no está 
            'Para determinar los que han sido inactivados en SAP
            'CATALOGOS.SETCLIENTESVIGENCIA()
            Dim mCmdVigencia As SqlCommand = New SqlCommand
            With mCmdVigencia
                .Connection = mCon
                .CommandType = CommandType.StoredProcedure
                .CommandText = "CATALOGOS.SETCLIENTESVIGENCIA"
                .Transaction = mTran
                .ExecuteNonQuery()

            End With


            'Envia los datos del dataset al archivo de sigepro.
            For Each mRow As DataRow In mDs.Tables(0).Rows
                intRow += 1

                ClientesWKGW.ReportProgress(((40 + intRow) / (40 + mDs.Tables(0).Rows.Count)) Mod 100)

                mCmd.Parameters("@SOCIEDAD").Value = mRow("SOCIEDAD")
                mCmd.Parameters("@CLAVECLIENTE").Value = mRow("CLAVECLIENTE")
                mCmd.Parameters("@RAZONSOCIAL").Value = mRow("RAZONSOCIAL")
                mCmd.Parameters("@CVEAGENTE").Value = Trim(Me.IdAgenteTxt.Text)
                mCmd.Parameters("@CHR_ORIGEN").Value = "A"
                mCmd.ExecuteNonQuery()

            Next
            mTran.Commit()
            mCon.Close()
            mCon.Dispose()




            mBolEstatus = enProcesoWK.enSincronizarOk
        Catch ex As Exception
            If Not IsNothing(mTran) Then
                'Hay un error y deshace la transaccion
                If Not IsNothing(mTran.Connection) Then
                    mTran.Rollback()
                    mCon.Close()
                    mCon.Dispose()
                End If
            End If

            ModComun.MsgError(ex.Message)


        End Try
        Return mBolEstatus
    End Function

#End Region
#Region "MetodosStandard"
    Private Sub AyudaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripButton.Click
        ModComun.ShowHelpAppByTopicId(Me, cte_help)
    End Sub

    Private Sub FrmCteMantenimiento_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested
        ModComun.ShowHelpAppByTopicId(Me, cte_help)

    End Sub
    Private Sub FrmCteMantenimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ClienteProductoDg.AutoGenerateColumns = False
        MSGERRORSINGUARDAR = "Se perderan los datos no guardados" & Environment.NewLine & " ¿ Esta Seguro ?"

        For mItem As Integer = 0 To Me.VigentesDropDown.Items.Count - 1

            If Me.VigentesDropDown.Items(mItem).Equals(My.Settings.MostrarClientesVigentes) Then
                Me.VigentesDropDown.SelectedIndex = mItem
                Exit For
            End If
        Next



    End Sub
    Private Sub BtnConsultarCteProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultarCteProducto.Click
        If IsNothing(ClienteDg.CurrentRow) = False Then
            ActualizarCtesProductos(ClienteDg.CurrentRow.Index)
        Else
            Me.TsLabelMsg.Text = "Elija un cliente antes de actualizar"
        End If
    End Sub

    ''' <summary>
    ''' Ejecuta la sincroonizacion de clientes de manera asincrona.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtnSincronizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sincronizar.Click


        If String.IsNullOrEmpty(Me.IdAgenteTxt.Text) = False Then
            'Valida que el agente Exista en el catalogo.
            If ClientesWKGW.IsBusy = False Then
                'MsgErrProvider.SetError(Nothing, Nothing)
                MsgErrProvider.Clear()

                If ModComun.CustomYesNo("Este proceso puede ser lento y requiere conexion a internet para consultar los datos contenidos en SAP." & Environment.NewLine & _
                                     "Cuando el proceso termine su lista de clientes estará actualizada" & Environment.NewLine & "¿ Desea continuar ?", False, Me) Then
                    Dim mObjVendedor As ClassVendedor = New ClassVendedor
                    If mObjVendedor.ConsultarCatalogo(Me.IdAgenteTxt.Text, Nothing, Nothing, Nothing) > 0 Then
                        ClientesWKGW.RunWorkerAsync("S")
                    Else
                        TsLabelMsg.Text = "El Agente:" & Me.IdAgenteTxt.Text & "No existe o no pudo ser consultado."
                    End If



                End If
            Else
                TsLabelMsg.Text = "El proceso está ocupado, por favor espere"
            End If


        Else
            MsgErrProvider.SetError(Me.IdAgenteTxt, "No se ha indicado una clave de agente.")

        End If


    End Sub

    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        If Me.Validate() Then

            If Not String.IsNullOrEmpty(Me.IdAgenteTxt.Text) AndAlso IsNumeric(Me.IdAgenteTxt.Text) Then
                'ClienteDg.DataBindings.
                ClienteDg.Focus()
                ClienteDg.AutoGenerateColumns = False
                ClienteDg.DataSource = Nothing
                ClienteDg.DataMember = Nothing

                If ClientesWKGW.IsBusy = False Then
                    mParVerCtesVigentes = Me.VigentesDropDown.SelectedItem
                    ClientesWKGW.RunWorkerAsync("Q")
                Else
                    TsLabelMsg.Text = "Espere proceso ejecutandose en este momento."
                End If


            Else
                TsLabelMsg.Text = "La clave del cliente debe ser numerica."
                Me.MsgErrProvider.SetError(Me.IdAgenteTxt, TsLabelMsg.Text)



            End If
        End If

    End Sub

    ''' <summary>
    ''' Define las tareas asincronas a realizar.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClientesWKGW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ClientesWKGW.DoWork

        Select Case e.Argument
            Case "S" 'Consultar Clientes Remotos
                e.Result = FnSinCronizar(Me.IdAgenteTxt.Text)
            Case "Q"
                e.Result = Consultar(Me.IdAgenteTxt.Text, mParVerCtesVigentes)
        End Select
    End Sub


    Private Sub ClientesWKGW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles ClientesWKGW.ProgressChanged
        TsPB.Value = e.ProgressPercentage
    End Sub
    ''' <summary>
    ''' Tareas adicionales al termina el backgroound
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClientesWKGW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ClientesWKGW.RunWorkerCompleted

        If e.Cancelled Then
            TsLabelMsg.Text = "Proceso Cancelado"
        ElseIf Not IsNothing(e.Error) Then
            TsLabelMsg.Text = e.Error.Message
        Else
            Dim mResultado = CType(e.Result, enProcesoWK)
            Select Case mResultado
                Case enProcesoWK.enConsultarOk

                    ClienteDg.DataSource = mDs
                    ClienteDg.DataMember = CTE_TABLA
                    If mDs.Tables(CTE_TABLA).Rows.Count = 0 Then
                        TsLabelMsg.Text = "No existen clientes para el agente seleccionado, intente sincronizar con SAP para buscar nuevos clientes."
                    Else
                        TsLabelMsg.Text = "Datos actualizados!!!!"
                    End If
                    ClientesTab.SelectedTab = CteAgteTab



                Case enProcesoWK.enSincronizarOk

                    TsLabelMsg.Text = "Se ha sincronizado la información con SAP; consulte nuevamente dando click en el boton abrir"

                Case enProcesoWK.enError
                    TsLabelMsg.Text = "Error al sincronizar"
            End Select
        End If
    End Sub
    ''' <summary>
    ''' Consulta el catalogo de agentes y llena el campo respectivo.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BuscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBtn.Click

        If FnValidarPerderCambios(Nothing) Then
            Dim mFrmAgentes As FrmAgentesConsulta = New FrmAgentesConsulta
            If mFrmAgentes.ShowDialog() = System.Windows.Forms.DialogResult.Yes Then
                InicializarCtrl(mFrmAgentes.mAgente.Clave)
                Me.LBlCteDesc.Text = mFrmAgentes.mAgente.Descripcion

            End If
            mFrmAgentes.Dispose()

        End If

    End Sub

    ''' <summary>
    ''' Actualiza la consulta de clientes x producto al dar click en la celda
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClienteDg_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClienteDg.CellClick
        ActualizarCtesProductos(e.RowIndex)
    End Sub


    ''' <summary>
    ''' Guarda los cambios realizados.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        'Guarda los registros
        'CteProductoDg.DataMember = CTE_TABLAPRODUCTO
        If Me.Validate() Then



            Dim mValidacion As Boolean = False
            Dim mValidacionFase2 As Boolean = False
            Try
                TsLabelMsg.Text = String.Empty
                Dim mLstValores As DjpSap.ClassFindGrView
                Const CTE_SEPARADOR As String = "|"
                Dim intRowError As Integer
                If Not IsNothing(mDs.Tables(CTE_TABLAPRODUCTO)) Then
                    If mDs.HasChanges() Then
                        If Me.Validate() Then
                            'Inicializa la lista de valores.
                            mLstValores = New DjpSap.ClassFindGrView(ClienteProductoDg, CTE_COLPRODUCTO & CTE_SEPARADOR & CTE_COLCENTRO, CTE_SEPARADOR)
                            TsLabelMsg.Text = String.Empty
                            'Verifica que en todos los casos el producto y centro existe.
                            Dim mObjProducto = New ClassProducto
                            'Obtiene una copia de los regitro que sufrieron cambios.
                            Dim dtCh As DataTable = mDs.Tables(CTE_TABLAPRODUCTO).GetChanges()

                            mValidacionFase2 = True
                            For Each mRow As DataRow In dtCh.Rows
                                If mCurrenRow > -1 Then
                                    Dim mRowHdr = Me.ClienteDg.Rows(mCurrenRow)
                                    'Determina el cliente que se está modificando
                                    'Actualiza los campos llave del producto cliente
                                    With mRow

                                        .Item("CLAVEAGENTE") = mRowHdr.Cells(HDR_AGENTE).Value
                                        .Item("CLAVESOCIEDAD") = mRowHdr.Cells(HDR_SOCIEDAD).Value
                                        .Item("CLAVECLIENTE") = mRowHdr.Cells(HDR_CTE).Value
                                        '.Item("VIGENCIA") = mRowHdr.Cells(HDR_VIGENCIA).Value
                                        If String.IsNullOrEmpty(.Item("VIGENCIA").ToString) Then
                                            .Item("VIGENCIA") = mCurrentCliente.Vigencia
                                        End If
                                    End With
                                End If

                                If Not IsDBNull(mRow("CLAVEPRODUCTO")) Then
                                    mObjProducto.Clave = mRow("CLAVEPRODUCTO")
                                    mValidacion = True
                                Else
                                    mObjProducto.Clave = Nothing
                                    mValidacion = False
                                End If


                                mValidacion = mValidacion And (Not IsDBNull(mRow("CLAVECENTRO")))
                                If mValidacion Then
                                    mObjProducto.ConsultarCatalogo(mRow("CLAVECENTRO").ToString())
                                    mValidacion = mObjProducto.Existe


                                End If


                                If Not mValidacion Then
                                    'Const CTE_SEPARADOR As String = "|"
                                    intRowError = mLstValores.GetIndex(Trim(mRow("CLAVEPRODUCTO").ToString) & CTE_SEPARADOR & Trim(mRow("CLAVECENTRO").ToString()))
                                    If intRowError > -1 Then
                                        'ClienteProductoDg.Rows(intRowError).ErrorText = "El producto: " & mObjProducto.Clave.ToString & "No Existe o no está asignado al centro: " & mRow("CLAVECENTRO").ToString()
                                        ClienteProductoDg.Rows(intRowError).ErrorText = String.Format("El producto: {0} No Existe o no está asignado al centro: {1} ", mObjProducto.Clave, mObjProducto, mRow("CLAVECENTRO"))
                                    Else
                                        'TsLabelMsg.Text = "El producto: " & mObjProducto.Clave.ToString & "No Existe o no está asignado al centro: " & mRow("CLAVECENTRO").ToString()
                                        TsLabelMsg.Text = String.Format("El producto: {0} No Existe o no está asignado al centro: {1} ", mObjProducto.Clave, mObjProducto, mRow("CLAVECENTRO"))
                                    End If
                                    mValidacionFase2 = False

                                End If

                            Next

                            If mValidacionFase2 Then
                                'Prepara una tranasccion y lo envia a sql

                                If Ta.InsertCommand.Connection.State <> ConnectionState.Open Then
                                    Ta.InsertCommand.Connection.Open()
                                End If



                                Dim mTran As SqlTransaction = Ta.InsertCommand.Connection.BeginTransaction
                                Ta.InsertCommand.Transaction = mTran
                                Ta.UpdateCommand.Transaction = mTran
                                'Ta.Update(mDs, CTE_TABLAPRODUCTO)
                                Ta.Update(dtCh)

                                If Not dtCh.HasErrors Then
                                    mTran.Commit()
                                    mDs.AcceptChanges()

                                    ConsultaCteProducto()

                                Else
                                    'Busca la celda que esta mal parametrizada}

                                    CteProductoBS.ResetBindings(False)



                                    For Each mRow As DataRow In dtCh.Rows

                                        If mRow.HasErrors Then
                                            intRowError = mLstValores.GetIndex(Trim(mRow("CLAVEPRODUCTO").ToString) & CTE_SEPARADOR & Trim(mRow("CLAVECENTRO").ToString()))
                                            ClienteProductoDg.Rows(intRowError).ErrorText = mRow.RowError
                                        End If

                                    Next

                                    mTran.Rollback()

                                End If

                            End If
                        End If
                    End If
                End If

            Catch ex As Exception
                ModComun.MsgError(ex.Message)

            End Try
        End If
    End Sub

    ''' <summary>
    ''' Asigna los datos predeterminados de agente,sociedad y cliente.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CteProductoDg_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If ClienteProductoDg.Tag = "X" Then Exit Sub
        If e.RowIndex > -1 Then
            If Not ClienteProductoDg.Rows(e.RowIndex).IsNewRow Then
                SetDefaultValues(e.RowIndex)
            End If

        End If

    End Sub


    ''' <summary>
    ''' 'Buisca una celda dentro del grid de clientes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim mFrm = New FrmImputText
        mFrm.ShowDialog()
        If DialogResult.OK = mFrm.DialogResult Then
            If Not String.IsNullOrEmpty(mFrm.strRespuesta) Then
                Dim mCelda As ClassCeldas = New ClassCeldas
                ClienteDg.CurrentCell = mCelda.Posicionar(mFrm.strRespuesta,
                                                          ClienteDg,
                                                          ClienteDg.Columns(ClienteDg.CurrentCell.ColumnIndex).Name,
                                                          ClienteDg.Columns(ClienteDg.CurrentCell.ColumnIndex).Name,
                                                          False)
            End If
        End If
        mFrm.Dispose()

    End Sub


    Private Sub EliminarTSMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarTSMnu.Click, DelToolStripButton.Click

        With ClienteProductoDg
            If .SelectedRows.Count > 0 AndAlso (.SelectedRows(0).IsNewRow = False) Then
                If Me.FnValidarEliminarCteProducto(.SelectedRows(0).Cells(CTE_COLPOSICION)) Then
                    If ModComun.MsgYesNo("Esta seguro de eliminar") Then
                        .Rows.Remove(.SelectedRows(0))
                    End If
                End If
            Else
                ModComun.MsgInfo("Seleccione un renglon")
            End If
        End With
    End Sub

    ''' <summary>
    ''' Valida cuando se pulsa el boton delete del renglon
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CteProductoDg_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs)
        Dim mBolValidar As Boolean = FnValidarEliminarCteProducto(e.Row.Cells(CTE_COLPOSICION))
        If Not mBolValidar Then
            e.Cancel = True
        Else
            Me.TsLabelMsg.Text = "Registro Borrado."
        End If
    End Sub

    ''' <summary>
    ''' Agrega un registro al dataset cuando el usuario da click en el boton de registro nuevo.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>


    Private Sub AddCteProductoMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCteProductoMnu.Click, AddToolStripButton.Click

        If Not String.IsNullOrEmpty(CteProductoBS.DataMember) Then
            With mDs.Tables(CteProductoBS.DataMember)
                ClienteProductoDg.Tag = "X" 'Evita llamadas recursivas del evento RowEnter
                'Dim mRow = .NewRow()
                Dim mRowHdr = Me.ClienteDg.Rows(mCurrenRow)
                'Determina el cliente que se está modificando

                Dim intCols = .Columns.Count
                Dim mCols(0 To intCols - 1) As Object

                '.Rows.Add(mCols)
                Dim mRow = .Rows.Add(mCols)
                mRow("CLAVEAGENTE") = mRowHdr.Cells(HDR_AGENTE).Value
                mRow("CLAVESOCIEDAD") = mRowHdr.Cells(HDR_SOCIEDAD).Value
                mRow("CLAVECLIENTE") = mRowHdr.Cells(HDR_CTE).Value

                CteProductoBS.ResetBindings(False)
                ClienteProductoDg.Tag = ""
            End With

        End If
    End Sub



    Private Sub BuscarProdictoTSMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProdictoTSMnu.Click
        BuscarProducto()
    End Sub


    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        If Me.Validate() Then
            If FnValidarPerderCambios(Nothing) Then
                IdAgenteTxt.Focus()

            End If
        End If

    End Sub

    Private Sub SalirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripButton.Click
        Me.Tag = "Salir"

        Me.Close()
    End Sub

    Private Sub FrmCteMantenimiento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If FnValidarPerderCambios(Nothing) Then
            mDs.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub IdAgenteTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IdAgenteTxt.KeyPress

        If e.KeyChar = Chr(13) Then
            AbrirToolStripButton.PerformClick()
        End If
    End Sub

    Private Sub IdAgenteTxt_Validated(sender As Object, e As System.EventArgs) Handles IdAgenteTxt.Validated
        MsgErrProvider.SetError(sender, Nothing)

    End Sub
    Private Sub IdAgenteTxt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles IdAgenteTxt.Validating
        If String.IsNullOrEmpty(Me.Tag) OrElse Me.Tag.Equals("Salir") = False Then
            If Me.ActiveControl.Name.Equals(Me.BuscarBtn.Name) = False Then




                If String.IsNullOrEmpty(IdAgenteTxt.Text) OrElse IsNumeric(IdAgenteTxt.Text) = False Then
                    MsgErrProvider.SetError(IdAgenteTxt, "El campo debe ser un valor numérico")
                    e.Cancel = True


                Else
                    If Not FnValidarPerderCambios(IdAgenteTxt.Text) Then
                        e.Cancel = True
                    End If
                End If
            End If
        End If

    End Sub
#End Region















    Private Sub GuardarOpciones_Click(sender As System.Object, e As System.EventArgs) Handles GuardarOpciones.Click
        Try
            If Me.VigentesDropDown.SelectedIndex > -1 Then
                My.Settings.MostrarClientesVigentes = Me.VigentesDropDown.SelectedItem
                My.Settings.Save()
                TsLabelMsg.Text = "Configuración Actualizada"
            Else
                ModComun.MsgError("Seleccione un elemento valido")
                Me.VigentesDropDown.Focus()

            End If

        Catch ex As Exception
            ModComun.MsgError(ex.Message)


        End Try
    End Sub

    Private Sub ClienteProductoDg_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClienteProductoDg.CellEndEdit
        If Me.ClienteProductoDg.Columns(e.ColumnIndex).Name.Equals("VIGENCIACTEPRODUCTO") Then
            If IsDBNull(Me.ClienteProductoDg.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) OrElse String.IsNullOrEmpty(Me.ClienteProductoDg.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                Me.ClienteProductoDg.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = mCurrentCliente.Vigencia
            End If

        End If

    End Sub

    

  

    ''' <summary>
    ''' Valida el contenido de la celda vigencias.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>




    Private Sub ClienteProductoDg_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles ClienteProductoDg.CellValidating
        With Me.TsLabelMsg
            .Image = Nothing
            .Text = Nothing
        End With


        If Me.ClienteProductoDg.Columns(e.ColumnIndex).Name.Equals("VIGENCIACTEPRODUCTO") Then
            'Valida si el valor tecleado es una fecha.
            Dim mGrdCell As DataGridViewCell = Me.ClienteProductoDg.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If String.IsNullOrEmpty(e.FormattedValue.ToString.Trim) = False Then
                Dim mDt As Date



                If Date.TryParse(e.FormattedValue, mDt) Then
                    If mDt < #1/1/2013# Then
                        'mGrdCell.ErrorText = "La fecha debe ser Mayor al 01/01/2013"
                        e.Cancel = True
                        SetErrorCellda("La fecha debe ser Mayor al 01/01/2013")


                        

                    Else
                        If Date.Compare(mDt, mCurrentCliente.Vigencia) < 0 Then
                            'mGrdCell.ErrorText = "La fecha debe ser Mayor al 01/01/2013"

                            mGrdCell.ErrorText = "El producto no formará parte de nuevos pronósticos a partir de la fecha seleccionada"
                            e.Cancel = False
                        End If

                    End If
                Else
                    'Me.TsLabelMsg.Text = "El valor ingresado debe ser una fecha valida."

                    SetErrorCellda("El valor ingresado debe ser una fecha valida.")
                    e.Cancel = True

                End If


            Else
                'Cuando se deja la celda vacia se considerá la vigencia del cliente


                mGrdCell.Value = mCurrentCliente.Vigencia
                ClienteProductoDg.RefreshEdit()
                mGrdCell.ErrorText = "Se ha considerado la vigencia del cliente actual."

                'e.Cancel = True




            End If
            

        End If




    End Sub

    Private Sub SetErrorCellda(pStrMensaje As String)
        Me.TsLabelMsg.Text = pStrMensaje
        Me.TsLabelMsg.Image = My.Resources.exclamation
    End Sub
   

    
   

    Private Sub BtnAddDistribuidor_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddDistribuidor.Click
        If Me.Validate() Then


            Me.MsgErrProvider.SetError(Me.IdAgenteTxt, Nothing)
            If FnGetAgente() Then
                With FrmAddCteManual
                    .SetAgente(Me.IdAgenteTxt.Text, Nothing)
                    .ShowDialog()
                    .Dispose()

                    Me.AbrirToolStripButton.PerformClick()

                End With
            Else
                Me.MsgErrProvider.SetError(Me.IdAgenteTxt, "Existen errores al consultar los datos del agente")
            End If

            

        Else
            Me.MsgErrProvider.SetError(Me.IdAgenteTxt, "La clave del agente es un dato obligatorio")

        End If
        



    End Sub

    
    
    Private Sub IdAgenteTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles IdAgenteTxt.TextChanged

    End Sub
End Class

