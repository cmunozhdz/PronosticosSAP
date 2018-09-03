Imports System.Data.SqlClient
Imports System.Data
Imports System.Collections.Generic
Imports System.ComponentModel

Imports System.Linq
Imports System.Linq.Expressions


Public Class Pronosticos
#Region "Declaraciones"
    Dim IdTaskThread As String
    Dim BolCalculandoTotales As Boolean

    Private Enum enEstadoProceso
        enError = -1
        enInicializar = 1
        enAbrir = 2
        enModificado = 3
        enGuardando = 4
        enSerializando = 5

    End Enum
    Private Enum enTablasDataset
        enMaestro = 0
        enPeriodos = 1
        enCentros = 3
        enPronosticos = 4
    End Enum
    Private Structure tpTablasDataset
        Dim NombreTablaDataSet As String
        Dim SqlText As String
        Dim NombreCatalogo As String


    End Structure
    Private Structure tpCelda
        Dim Col As Integer
        Dim Row As Long
    End Structure
    Private Structure enTipoProceso
        Dim intProceso As Integer
        Dim mbolProceso As Boolean
        Dim intRow As Long
        Dim intCol As Integer

    End Structure

    Const CTE_COLBASE As String = "BASE_"
    Const CTE_COLALTERNA As String = "ALTERNA_"
    Const CTE_CAPTION As String = "Sistema Pronósticos de Polaquimia"
    Const CTE_TOTALPRODUCTO As String = "TotalProducto"
    Const CTE_COL_TITULO_TOTALPERIODO As String = "CLAVEPRODUCTO"
    Const CTE_TOTAL_PERIODO_CAPTION = "Total X Periodo"

    Dim mstrErrorProceso As String
    Dim intProcesando As Integer

    Dim mColumnas As Dictionary(Of String, ClassColumnasGridView)
    Dim mObjCeldaActual As tpCelda

    Dim mPidProceso As enEstadoProceso
    Dim mCeldaActual As Double
    Dim mcolTablas As Dictionary(Of enTablasDataset, tpTablasDataset)
    Dim pLngEstatus As Long
    Dim mAgente As ClassVendedor
    Dim intProgreso As Long
    Public pPronostico As ClassPronosticos


    Private mDataSet As DataSet



#End Region
#Region "Delegados"

#End Region

#Region "Metodos"
    Private Sub ShowHelp()
        ModComun.ShowHelpAppByTopicId(Me, Me.HelpProvider.Tag)

    End Sub


    ''' <summary>
    ''' Valida si el usuario ha modificado algun dato del dataset por lo tanto no
    ''' debe salir sin guardar.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function PuedeSalir() As Boolean
        Dim mBolSalir As Boolean = False
        If Me.BGWK.IsBusy Then
            If MsgYesNo("Esta acción provocará que el proceso actual sea cancelado" & "Está seguro?") Then
                If Me.BGWK.IsBusy Then
                    Me.BGWK.CancelAsync()
                End If

            End If
        Else
            'mBolSalir = True
            If Not IsNothing(mDataSet) Then
                If mDataSet.HasChanges(System.Data.DataRowState.Modified) Then
                    mBolSalir = ModComun.MsgYesNo("Se pederán los cambios realizados " & Environment.NewLine & "Desea continuar ?")
                Else
                    mBolSalir = True
                End If
            Else
                mBolSalir = True
            End If


        End If



        Return mBolSalir


    End Function
    Private Sub AgregaTotalesGrid(mView As DataView)

        Dim mTable As DataTable = mView.ToTable("TmpTotales")
        Dim mTableNew As DataTable = mTable.Clone()

        Dim mRow = mTableNew.NewRow
        mTableNew.Rows.Add(mRow)
        'mTable.Rows.Clear() 'Borra los registros nuevos.

        mRow(CTE_COL_TITULO_TOTALPERIODO) = CTE_TOTAL_PERIODO_CAPTION
        For Each mColData As DataColumn In mTable.Columns
            If mColData.ColumnName.Contains(CTE_COLBASE) Then

                For Each mRowValueOriginal As DataRow In mTable.Rows

                    If IsDBNull(mRowValueOriginal(mColData.ColumnName)) = False Then
                        If IsDBNull(mRow(mColData.ColumnName)) Then
                            mRow(mColData.ColumnName) = 0
                        End If


                        mRow(mColData.ColumnName) = mRow(mColData.ColumnName) + mRowValueOriginal(mColData.ColumnName)

                    End If



                    'Calcula el total de la celda.
                Next


            End If

        Next




        With Me.TotalesGrd
            .DataSource = mTableNew
            .ReadOnly = True
            '.Refresh()
            For Each mCol As KeyValuePair(Of String, PronosticosSAP.ClassColumnasGridView) In Me.mColumnas
                For Each mColGrd As DataGridViewColumn In Me.TotalesGrd.Columns
                    If mColGrd.DataPropertyName.Equals(mCol.Value.Clave) Then
                        mColGrd.Visible = mCol.Value.Visible
                        mColGrd.HeaderText = mCol.Value.Header



                    End If
                Next

            Next

        End With

    End Sub
    ''' <summary>
    ''' Agrega los totales por producto y mes al visualizar el pronostico.
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    <Obsolete("Ya no se utiliza por tener problemas con la ultima celdas, mejor utilizar el procedimiento del segundo grid.")> _
    Private Sub AgregaTotales2()
        If BolCalculandoTotales Then Exit Sub 'Evita llamadas recursivas
        BolCalculandoTotales = True
        Try
            'AGREGA LOS TOTALES POR PRODUCTO


            For inRow As Integer = 0 To Me.DataGridView1.Rows.Count - 1

                'Actualiza el valor de la celda actual
                CalculaTotalProducto(inRow)
            Next


            'End If
            'AGREGA LOS TOTALES POR MES.

            Dim mLastRow As DataGridViewRow = Me.DataGridView1.Rows(DataGridView1.Rows.Count - 1)

            For intCols As Integer = 0 To DataGridView1.Columns.Count - 1



                If DataGridView1.Columns(intCols).DataPropertyName = CTE_COL_TITULO_TOTALPERIODO Then


                    If String.IsNullOrEmpty(mLastRow.Cells(CTE_COL_TITULO_TOTALPERIODO).Value) Then

                        mLastRow.Cells(CTE_COL_TITULO_TOTALPERIODO).Value = CTE_TOTAL_PERIODO_CAPTION


                    End If



                End If
                With mLastRow.Cells(intCols)
                    .ReadOnly = True

                    .Style.BackColor = Color.Navy
                    .Style.ForeColor = Color.White
                    .Style.Format = "###,##0.00"
                    Dim mTmpFont As Font = Me.DataGridView1.Font
                    .Style.Font = New Font(mTmpFont.Name, mTmpFont.Size, FontStyle.Bold)
                End With

                If InStr(DataGridView1.Columns(intCols).DataPropertyName, CTE_COLBASE, vbTextCompare) > 0 Then
                    If mLastRow.Cells(CTE_COL_TITULO_TOTALPERIODO).Value = CTE_TOTAL_PERIODO_CAPTION Then
                        CalculaTotalMes(intCols)
                    End If
                End If


            Next intCols
            'Actualiza el gran total
            'CalculaGranTotal()
            BolCalculandoTotales = False


        Catch ex As Exception
            Me.ShowErrorMessage("Evento:DataGridView1_DataBindingComplete" & Environment.NewLine & ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' Calcula el total anual de todos los productos
    ''' </summary>
    ''' <remarks></remarks>
    <Obsolete("Ya no se utiliza la celda del gran total no existe en el grid de totales.")> _
    Sub CalculaGranTotal()
        Dim mDblGranTotal As Double = 0
        For intCols As Integer = 0 To DataGridView1.Columns.Count - 1

            If InStr(DataGridView1.Columns(intCols).DataPropertyName, CTE_COLBASE, CompareMethod.Text) > 0 Then
                If Not IsDBNull(DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(intCols).Value) Then
                    mDblGranTotal += DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(intCols).Value

                End If
            End If

        Next

        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(CTE_TOTALPRODUCTO).Value = mDblGranTotal
    End Sub


    ''' <summary>
    ''' Establece el Objeto de la celda que se esta actualizando
    ''' El cual se usa como intermediario para cambiar datos con los formularios
    ''' de Historico de Movimientos, Repartos Entre Otros.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SetItemActual() As ClassItemPronosticos
        Dim mItem As ClassItemPronosticos = Nothing
        If (mObjCeldaActual.Row > -1 And mObjCeldaActual.Row < Me.DataGridView1.Rows.Count) And _
            (mObjCeldaActual.Col > -1 And mObjCeldaActual.Col < Me.DataGridView1.ColumnCount) Then

            Dim mRow = Me.DataGridView1.Rows(mObjCeldaActual.Row)
            Dim mCol As ClassColumnasGridView = Me.mColumnas.Values(mObjCeldaActual.Col)
            Dim mStrCliente As String
            Dim x As String = DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).DataPropertyName





            Dim Qty As Double = 0
            If Not IsDBNull(mRow.Cells(mObjCeldaActual.Col).Value) Then
                Double.TryParse(mRow.Cells(mObjCeldaActual.Col).Value, Qty)
            End If




            If Not IsDBNull(mRow.Cells("CLAVECLIENTE").Value) Then
                mStrCliente = mRow.Cells("CLAVECLIENTE").Value
            Else
                mStrCliente = Nothing
            End If


            mItem = New ClassItemPronosticos(mRow.Cells("IDPRONOSTICO").Value, _
                                                              mCol.HeaderValorFecha, _
                                                              mRow.Cells("CLAVECENTRO").Value, _
                                                              mRow.Cells("CLAVEPRODUCTO").Value, _
                                                              mRow.Cells("CLAVEAGENTE").Value, _
                                                              mStrCliente,
                                                              Qty)
            'mItem.Periodo = mColumnas.Values(DataGridView1.Columns(mObjCeldaActual.Col).DataPropertyName).HeaderValorFecha
            Dim mColDt As ClassColumnasGridView = Nothing


            If mColumnas.TryGetValue(DataGridView1.Columns(mObjCeldaActual.Col).DataPropertyName, mColDt) Then
                mItem.Periodo = mColDt.HeaderValorFecha
            End If





            EstatusBarTxt.Text = String.Empty
        Else
            EstatusBarTxt.Text = "Elija una celda valida"
        End If
        Return mItem

    End Function

    ''' <summary>
    ''' Muestra ventana de error
    ''' </summary>
    ''' <param name="pstrMensaje"></param>
    ''' <remarks></remarks>

    Private Sub ShowErrorMessage(ByVal pstrMensaje As String)
        Dim mbolEstadoTimer = Me.AutoSaveTimer.Enabled
        Me.DetieneTimer()
        System.Windows.Forms.MessageBox.Show(pstrMensaje, CTE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error)
        If mbolEstadoTimer Then
            Me.AutoSaveTimer.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' Muestra ventana de advertencia
    ''' </summary>
    ''' <param name="pstrMensaje"></param>
    ''' <remarks></remarks>
    Private Sub ShowErrorWarning(ByVal pstrMensaje As String)
        Dim mbolEstadoTimer = Me.AutoSaveTimer.Enabled
        Me.DetieneTimer()
        System.Windows.Forms.MessageBox.Show(pstrMensaje, CTE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If mbolEstadoTimer Then
            Me.AutoSaveTimer.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' Muestra mensaje para elegir entre el boton yes/no
    ''' </summary>
    ''' <param name="pstrMensaje">Texto o pregunta a realizar</param>
    ''' <returns>Devuelee true cuando se pulsa el boton yes</returns>
    ''' <remarks></remarks>
    Private Function ShowMsgYesNo(ByVal pstrMensaje As String) As Boolean
        'Return
        Dim mbolEstadoTimer = Me.AutoSaveTimer.Enabled
        Me.DetieneTimer()
        Return System.Windows.Forms.MessageBox.Show(pstrMensaje, CTE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = System.Windows.Forms.DialogResult.Yes
        If mbolEstadoTimer Then
            Me.AutoSaveTimer.Enabled = True
        End If

    End Function
    ''' <summary>
    ''' Obtiene una columna del datagrid proporcionando el nombre del campo vinculado en la base de datos.
    ''' </summary>
    ''' <param name="pDataPropertyName">Nombre del campo de la base de datos.</param>
    ''' <returns></returns>
    ''' <remarks>Validar que la columna devuelta no sea nothing</remarks>
    Private Function GetColumnByDataPropertyName(ByVal pDataPropertyName As String) As DataGridViewColumn
        Try
            Dim mBolFound As Boolean = False
            Dim mCol As DataGridViewColumn = Nothing
            For Each mCol In DataGridView1.Columns
                If String.Compare(mCol.DataPropertyName, pDataPropertyName) = 0 Then
                    mBolFound = True
                    Exit For
                End If

            Next
            If Not mBolFound Then

                mCol = Nothing

            End If
            Return mCol
        Catch ex As Exception
            ToolStripStatusLabel.Text = ex.Message
            Return Nothing
        End Try
        

    End Function
    ''' <summary>
    ''' Calcula los totales x mes.
    ''' </summary>
    ''' <param name="mColIndex"></param>
    ''' <remarks></remarks>
    Private Sub CalculaTotalMes(ByVal mColIndex As Integer)
        Dim mValor As Double = 0
        'Toma el primer renglon y el penultimo
        Try
            'Identifica el Nombre del campo que se ha actualizado


            For mrows As Integer = 0 To Me.DataGridView1.Rows.Count - 1

                'If InStr(mCol.DataPropertyName, CTE_COLBASE, CompareMethod.Text) > 0 Then
                Dim mcellValue As Object = Me.DataGridView1.Rows(mrows).Cells(mColIndex).Value

                If Not IsDBNull(mcellValue) Then
                    mValor += mcellValue
                End If


            Next mrows

            'Atualiza el valor del grid de totales.
            'Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells(mColIndex).Value = mValor
            If Me.TotalesGrd.Rows.Count > 0 Then
                'Compara los nombres de los campos y aplica el nuevo valor.
                For intColTotales As Integer = 0 To Me.TotalesGrd.Columns.Count - 1
                    If Me.TotalesGrd.Columns(intColTotales).DataPropertyName.Equals(Me.DataGridView1.Columns(mColIndex).DataPropertyName) Then
                        Me.TotalesGrd.Rows(0).Cells(intColTotales).Value = mValor
                        If Me.TotalesGrd.Rows(0).Cells(intColTotales).Visible Then
                            Me.TotalesGrd.CurrentCell = Me.TotalesGrd.Rows(0).Cells(intColTotales)
                        End If
                        Exit For
                    End If
                Next

            End If

        Catch ex As Exception
            'MsgError("Fuente:CalculaTotalMes" & Environment.NewLine & ex.Message)
            ToolStripStatusLabel.Text = "Fuente:CalculaTotalMes" & Environment.NewLine & ex.Message
        End Try



    End Sub
    ''' <summary>
    ''' Calula el total del pronostico x producto
    ''' </summary>
    ''' <param name="mRowIndex">Renglon actual</param>
    ''' <remarks></remarks>
    Private Sub CalculaTotalProducto(ByVal mRowIndex As Integer)
        Try
            Dim mValor As Double = 0
            If Me.DataGridView1.Columns.Contains(CTE_TOTALPRODUCTO) Then
                For Each mCol As DataGridViewColumn In Me.DataGridView1.Columns
                    If InStr(mCol.DataPropertyName, CTE_COLBASE, CompareMethod.Text) > 0 Then
                        Dim mcellValue As Object = Me.DataGridView1.Rows(mRowIndex).Cells(mCol.DataPropertyName).Value

                        If Not IsDBNull(mcellValue) Then
                            mValor += mcellValue
                        End If
                    End If

                Next

                With Me.DataGridView1.Rows(mRowIndex).Cells(CTE_TOTALPRODUCTO)
                    .Value = mValor
                    .ReadOnly = True
                End With

                'Me.DataGridView1.Rows(mRowIndex).Cells(CTE_TOTALPRODUCTO).ReadOnly = True

            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message)
        End Try
        

    End Sub
    ''' <summary>
    ''' Detine el proceso del timer evitar llamadas recursivas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DetieneTimer()
        Me.AutoSaveTimer.Enabled = False
    End Sub
    ''' <summary>
    ''' Prepara el timer para guardar los datos automaticamente
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InicializaTimer()
        Try
            'Inicializa las llamadas a la configuracion del programa
            Dim ObjConfig As ClassCustomConfig = New ClassCustomConfig
            'La variable almacen el tiempo en segundos por lo que el timer debe convertirse a milisegundos
            Dim mLngTiempo As Long = ObjConfig.DelayAutoSave * 1000
            If mLngTiempo > 3600 * 1000 Then
                'Asigna el tiempo maximo de autoguardado a una hora.
                mLngTiempo = 3600 * 1000
            End If

            If mLngTiempo > 0 Then

                Me.AutoSaveTimer.Interval = mLngTiempo
                Me.AutoSaveTimer.Enabled = True

            Else

                Me.AutoSaveTimer.Enabled = False

            End If
        Catch ex As Exception
            ToolStripStatusLabel.Text = ex.Message
        End Try
        
    End Sub
    ''' <summary>
    ''' GUARDA LOS DATOS DEL GRID 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GuardaMovsEscenario()
        Try

            Me.AutoSaveTimer.Enabled = False 'Deshhabilita el timer y evita llamadas recursivas.
            Me.Validate() 'Hace que las celdas automaticamente disparen los eventos pendientes.

            Me.GuardarToolStripButton.Enabled = False 'Deshabilita el control para evitar llamadas repetitivas.
            Me.BGWK.RunWorkerAsync(enEstadoProceso.enModificado) 'Envia el proceso en un thread adicional.
        Catch ex As Exception
            Me.ShowErrorMessage(ex.Message)
        End Try


    End Sub
    ''' <summary>
    ''' Inicializa el dataset de pronosticos.
    ''' </summary>
    ''' <param name="pIdPronostico">No. Pronostico</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function InicializarDataSet(ByVal pIdPronostico As Long) As Boolean
        Dim mBolProceso As Boolean
        Try
            Me.mstrErrorProceso = String.Empty

            Dim objTabla As tpTablasDataset
            Dim mCon As SqlConnection = DjpSap.Dac.mConexion()
            Using mCon

                'Dim mCon As System.Data.SqlClient.SqlConnection = DjpSap.Dac.mConexion()
                mDataSet = New DataSet

                ''Verificar.
                Dim intTabla As Integer = 1

                For Each objTabla In mcolTablas.Values

                    Me.BGWK.ReportProgress(intTabla / mcolTablas.Count * 100)
                    Me.FillData(objTabla, pIdPronostico, mCon)
                    intTabla += 1

                Next
                mCon.Close()



            End Using
            mBolProceso = True
        Catch ex As Exception
            mstrErrorProceso = ex.Message
            mBolProceso = False
        End Try
        Return mBolProceso


    End Function
    ''' <summary>
    ''' Serializa como xml el objeto actual
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Serializar() As Boolean

        Try
            mPidProceso = enEstadoProceso.enSerializando
            Dim mObjStream As DjpSap.ClassXmlRW = New DjpSap.ClassXmlRW(1, pPronostico.GetType.Name)
            Dim mSerializer As New System.Xml.Serialization.XmlSerializer(GetType(ClassPronosticos))
            mSerializer.Serialize(mObjStream.xmlWriter, pPronostico)
            mObjStream.xmlWriter.Close()
            Return True


        Catch ex As Exception

            Return False

        End Try

    End Function

    ''' <summary>
    ''' desSerializa el objeto a un xml con el nombre 
    ''' </summary>
    ''' <param name="pPronostico">Objeto a serializar</param>
    ''' <returns>Verdadero si no hay error</returns>
    ''' <remarks></remarks>
    Private Function DesSerializar(ByRef pPronostico As ClassPronosticos) As Boolean
        Dim mBolProceso As Boolean
        Try
            Dim mObjStream As DjpSap.ClassXmlRW = New DjpSap.ClassXmlRW(0, pPronostico.GetType.Name)
            If IsNothing(mObjStream.xmlReader) = False Then


                Dim mSerializer As New System.Xml.Serialization.XmlSerializer(GetType(ClassPronosticos))


                pPronostico = CType(mSerializer.Deserialize(mObjStream.xmlReader), ClassPronosticos)
            Else
                pPronostico.Id = 0
            End If
            mBolProceso = True

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Me.ShowErrorMessage(ex.Message)

            mBolProceso = False
        End Try
        Return True
    End Function
    ''' <summary>
    ''' Consulta la base datos del pronostico.
    ''' </summary>
    ''' <remarks></remarks>
    Sub EjecutaConsulta()
        Try
            Me.ConsultarAsync()
        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try
    End Sub

    ''' <summary>
    ''' AgregaCampoCalculado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AgregaCampoCalculado()
        Try

        
        '************************************************
        'Agrega Campo Calculado
        '************************************************
        If Not Me.DataGridView1.Columns.Contains(CTE_TOTALPRODUCTO) Then
            Dim mCampoCalculado As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn

            With mCampoCalculado
                .HeaderText = "Total"
                .Name = CTE_TOTALPRODUCTO
                .ReadOnly = True
                .DefaultCellStyle.BackColor = Color.Navy
                .DefaultCellStyle.ForeColor = Color.White
                .DefaultCellStyle.Format = "###,##0.00"
                Dim mTmpFont As Font = Me.DataGridView1.Font

                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight

                .DefaultCellStyle.Font = New Font(mTmpFont.Name, mTmpFont.Size, FontStyle.Bold)
            End With
            Me.DataGridView1.Columns.Add(mCampoCalculado)
            End If
        Catch ex As Exception
            ToolStripStatusLabel.Text = ex.Message
        End Try

    End Sub
    ''' <summary>
    ''' Presenta el resultado del pronostico, este metodo se manda llamar despues que se hayan llenaddo los datasets
    ''' </summary>
    ''' <remarks>Ejecutar el Metodos InicializarDataSet</remarks>
    Private Sub MuestraPronostico()
        Try

            With Me.TabPronosticos
                .SelectTab(Me.TabDetalle)

                .Enabled = True
            End With

            Dim mCol As ClassColumnasGridView
            Dim tpronosticos As DataTable
            Dim mStrColUnidad As String
            Me.DataGridView1.Columns.Clear() 'Borra la colexion de columnas
            'Obtiene el maestro del pronostico
            tpronosticos = mDataSet.Tables(mcolTablas(enTablasDataset.enMaestro).NombreTablaDataSet)


            If tpronosticos.Rows.Count > 0 Then
                'Trae los datos del agente.
                Dim mAgente As ClassVendedor = New ClassVendedor
                If IsDBNull(tpronosticos.Rows(0).Item("CLAVEAGENTE")) = False Then
                    mAgente.Clave = tpronosticos.Rows(0).Item("CLAVEAGENTE")
                    mAgente.ConsultarCatalogo()
                    Me.NomAgentelbl.Text = mAgente.Descripcion
                    Me.NombreAgenteLabel.Text = mAgente.Descripcion
                Else
                    mAgente.Clave = String.Empty
                    Me.NomAgentelbl.Text = String.Empty
                    Me.NombreAgenteLabel.Text = String.Empty
                End If
                'Obtiene los datos de la zona.
                pPronostico.Agente = mAgente



                'Obtiene los centros
                Dim MSTRTMP = mcolTablas(enTablasDataset.enCentros).SqlText


                With Me.CboCentroFiltro
                    .DataSource = mDataSet.Tables(mcolTablas(enTablasDataset.enCentros).NombreTablaDataSet)
                    .DisplayMember = "DESCRIPCION"
                    .ValueMember = "CLAVECENTRO"
                End With

                'Trae los datos generales.
                For Each mRow As DataRow In tpronosticos.Rows
                    With Me.NoPronosticoTxt
                        .Text = mRow.Item("IDPRONOSTICO").ToString()
                        .Enabled = False

                    End With

                    With Me.CveAgenteTxt
                        .Text = mRow.Item("CLAVEAGENTE").ToString()
                        .Enabled = False
                    End With

                    ' Me.ZonasTxt.Text = = mRow.Item("CLAVEAGENTE").ToString()
                    With Me.InicioDTP
                        .Value = mRow.Item("SMDINICIO")
                        .Enabled = False
                    End With
                    With Me.FinDTP
                        .Value = mRow.Item("SMDFIN")
                        .Enabled = False
                    End With
                    With Me.TipoPeriodoCbo
                        For intTipo As Integer = 0 To .Items.Count - 1
                            If Mid(.Items(intTipo).ToString, 1, 1) = mRow.Item("TIPOPERIODO") Then
                                .SelectedIndex = intTipo
                                .Enabled = False
                                Exit For

                            End If

                        Next
                    End With
                    If IsDBNull(mRow.Item("DESCRIPCION")) Then
                        DescPronosticoTxt.Text = String.Empty
                    Else
                        DescPronosticoTxt.Text = mRow.Item("DESCRIPCION")

                    End If


                    InicializaColGrid(mRow.Item("NEGOCIO"))
                Next
                If IsNothing(pPronostico) Then
                    pPronostico = New ClassPronosticos

                End If

                If pPronostico.Id <> Me.NoPronosticoTxt.Text Then
                    With pPronostico
                        .Id = Me.NoPronosticoTxt.Text
                        .Agente = New ClassVendedor
                        .Agente.Clave = Me.CveAgenteTxt.Text
                        .PeriodoInicial = Me.InicioDTP.Value
                        .PeriodoFinal = Me.FinDTP.Value

                    End With
                    'Ejecuta la serializacion asyncrona
                    'para mejorar el rendimiento
                    Me.BGWK.RunWorkerAsync("Serializar") 'Ejecuta la serializacion en segundo  plano.

                    'Me.Serializar()

                End If

                pPronostico.Descripcion = Me.DescPronosticoTxt.Text



                'Actualiza la coleccion de columnas del mes actual.
                Dim mDt As Date
                Dim mdtOrigen As Date
                Dim Dias As Integer = DjpSap.ClassConfig.strGetPeriodobloqueado(mAgente.AreaNegocios)
                If Not DjpSap.ClassConfig.EsDiasHabiles(mAgente.AreaNegocios) Then
                    mDt = DateSerial(Date.Today.Year, Date.Today.Month, Dias)
                    mdtOrigen = DateSerial(Date.Today.Year, Date.Today.Month, Dias)
                Else
                    Dim mDiasHabiles As DjpSap.ClassDiasFestivos = New DjpSap.ClassDiasFestivos(Date.Today.Month, Date.Today.Year)

                    mDt = mDiasHabiles.DateAddHabiles(DateSerial(Date.Today.Year, Date.Today.Month, 1), Dias)
                    mdtOrigen = mDt

                End If



                'Determina la fecha apartir del cual se bloquean los periodos

                Dim mstrFechaBloqueo As String
                If mAgente.AreaNegocios = "A" Then
                    mstrFechaBloqueo = "Mes:" & String.Format("{0:MMMM -yyyy}", DateAdd(DateInterval.Month, 1, mDt))

                Else
                    Dim mDtPrimerDiaMes As Date
                    mDtPrimerDiaMes = DateSerial(Year(mDt), Month(mDt), 1)

                    mstrFechaBloqueo = "Dia:" & String.Format("{0:dd-MMMM -yyyy}", DateAdd(DateInterval.Month, 1, mDtPrimerDiaMes))

                End If

                Me.lblCongelado.Text = "La fecha limite para CAPTURAR pronóstico del  " & mstrFechaBloqueo & Environment.NewLine & " Es :" & String.Format("{0:dd-MMM-yyyy}", mdtOrigen)



                'Lee los periodos para ponerlos como titulos del grid



                Dim mFecha As String
                For Each mRow As DataRow In mDataSet.Tables(mcolTablas(enTablasDataset.enPeriodos).NombreTablaDataSet).Rows
                    'Dim mFecha As String = CDate(mRow.Item("SMDINICIO")).ToString("yyyy-MMM-dd")
                    If mAgente.AreaNegocios = "A" Then
                        mFecha = String.Format("{0:MMM-yyyy}", mRow.Item("SMDINICIO")).ToUpper()  'CDate(mRow.Item("SMDINICIO")).ToString("yyyy-MMM-dd")
                    Else
                        mFecha = String.Format("{0:dd-MMM-yyyy}", mRow.Item("SMDINICIO")).ToUpper() 'CDate(mRow.Item("SMDINICIO")).ToString("yyyy-MMM-dd")
                    End If

                    mStrColUnidad = CTE_COLBASE & mRow.Item("INTPERIODO").ToString()

                    If Me.mColumnas.ContainsKey(mStrColUnidad) Then
                        mCol = Me.mColumnas.Item(mStrColUnidad)
                        mCol.Header = mFecha
                        'mCol.Visible = Not Me.ChkUnidadAlterna.Checked
                        mCol.Visible = True
                        mCol.Frozen = False
                        mCol.EsCaptura = True

                        mCol.HeaderValorFecha = mRow.Item("SMDINICIO")


                    Else
                        mCol = New ClassColumnasGridView(mFecha, mStrColUnidad, True, True)
                        'mCol.Visible = Not Me.ChkUnidadAlterna.Checked
                        mCol.Visible = True
                        mCol.Frozen = False
                        mCol.EsCaptura = True
                        mCol.HeaderValorFecha = mRow.Item("SMDINICIO")

                        Me.mColumnas.Add(mCol.Clave, mCol)

                    End If
                    If (Date.Today > mDt) Then
                        mCol.SoloLectura = DateSerial(Year(mDt), Month(mDt) + 1, 1) >= CDate(mRow.Item("SMDINICIO")) ' CDate(mRow.Item("SMDINICIO"))
                    Else
                        mCol.SoloLectura = mDt > CDate(mRow.Item("SMDINICIO"))
                    End If


                    If mCol.SoloLectura Then
                        mCol.Color = Color.Blue

                    Else
                        mCol.Color = Color.Black

                    End If


                    mStrColUnidad = CTE_COLALTERNA & mRow.Item("INTPERIODO").ToString()

                    If Me.mColumnas.ContainsKey(mStrColUnidad) Then
                        mCol = Me.mColumnas.Item(mStrColUnidad)
                        mCol.Header = mFecha
                        'mCol.Visible = True

                        'mCol.Visible = Me.ChkUnidadAlterna.Checked
                        mCol.Visible = False

                        mCol.Frozen = False
                        mCol.EsCaptura = False

                    Else
                        'Dim mDt As Date = mRow.Item("SMDINICIO")


                        mCol = New ClassColumnasGridView(mFecha, mStrColUnidad, True, True)
                        mCol.Header = mFecha
                        'mCol.Visible = Me.ChkUnidadAlterna.Checked
                        mCol.Visible = False
                        'mCol.Visible = True
                        mCol.Frozen = False
                        mCol.EsCaptura = False


                        Me.mColumnas.Add(mStrColUnidad, mCol)

                    End If
                    mCol.SoloLectura = mDt > CDate(mRow.Item("SMDINICIO"))
                    If mCol.SoloLectura Then
                        mCol.Color = Color.Blue

                    Else
                        mCol.Color = Color.Black

                    End If

                    'Dim mDt As Date = DateSerial(2012, 12, 1)





                Next mRow




                'Trase los datos del grid


                'Toma el dataset del detalle del pronostico y lo mete como dataview para poder hacer filtros en tiempo d
                'de ejecucion y evitar retrasos de red.
                'intProgreso = intProgreso + 10
                'Me.BGWK.ReportProgress(intProgreso)


                Dim mvw As DataView = New DataView(mDataSet.Tables(mcolTablas(enTablasDataset.enPronosticos).NombreTablaDataSet))
                'Dim MROWVIEW As DataRowView = mvw.AddNew()
                'MROWVIEW(CTE_COL_TITULO_TOTALPERIODO) = CTE_TOTAL_PERIODO_CAPTION '"TOTAL PERIODO:"

                If Not IsNothing(Me.CboCentroFiltro.SelectedValue) Then
                    mvw.RowFilter = "CLAVECENTRO=" & Me.CboCentroFiltro.SelectedValue
                    'MROWVIEW("CLAVECENTRO") = Me.CboCentroFiltro.SelectedValue '"TOTAL PERIODO:"
                Else
                    mvw.RowFilter = String.Empty
                    'MROWVIEW("CLAVECENTRO") = String.Empty
                End If

                If mAgente.AreaNegocios = "A" Then
                    Me.Cbocliente.Visible = False
                    lblCliente.Visible = False

                Else
                    Me.Cbocliente.Visible = True
                    Me.lblCliente.Visible = True

                End If

                Me.Cbocliente.SelectedIndex = -1




                'Me.DataGridView1.Columns.Clear()
                Me.DataGridView1.AutoGenerateColumns = True



                'Asigna los datos del pronostico actual.
                Me.DataGridView1.DataSource = mvw


                Me.AgregaCampoCalculado()


                If mvw.Count > 0 And mAgente.AreaNegocios = "A" Then

                    If IsDBNull(mvw.Item(0).Item("CLAVEZONA")) = False Then
                        Dim mZona As ClassZona = New ClassZona(mvw.Item(0).Item("CLAVEZONA").ToString())

                        If mZona.Consultar > 0 Then
                            Me.ZonaLabel.Text = mZona.Descripcion
                            Me.ZonasTxt.Text = mZona.Clave

                        Else
                            Me.ZonaLabel.Text = String.Empty
                            Me.ZonasTxt.Text = String.Empty
                        End If

                    Else
                        Me.ZonaLabel.Text = String.Empty
                    End If

                Else
                    Me.ZonaLabel.Text = String.Empty
                    Me.ZonasTxt.Text = String.Empty

                End If
                'Rellena la lista de almacenes.

                'DEtermina los titulos de la columnas Deseada
                Dim mBolPrevious As Boolean = False

                For Each mColGrd As DataGridViewColumn In Me.DataGridView1.Columns

                    If Me.mColumnas.ContainsKey(mColGrd.DataPropertyName) Then
                        mStrColUnidad = mColGrd.DataPropertyName
                        mCol = Me.mColumnas(mColGrd.DataPropertyName)
                        With mCol

                            mColGrd.HeaderText = .Header
                            mColGrd.Visible = .Visible

                            If InStr(mColGrd.DataPropertyName, "ALTERNA_") > 0 Or InStr(mColGrd.DataPropertyName, "BASE_") > 0 Then
                                mColGrd.Frozen = False
                                mColGrd.DefaultCellStyle.Format = "###,##0.00"
                                mColGrd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight



                                'mColGrd.Name = 

                            Else
                                mColGrd.Frozen = True

                            End If




                            mColGrd.DefaultCellStyle.ForeColor = .Color
                            mColGrd.ReadOnly = .SoloLectura
                            If .SoloLectura Then
                                mColGrd.DefaultCellStyle.BackColor = Color.Silver
                                If .EsCaptura Then
                                    'LAS COLUMNAS DEL PRONOSTICO SE OCULTAN EN PERIODOS CERRADOS
                                    mColGrd.Visible = Not Me.ChkOpcVerColumnas.Checked
                                End If
                            Else
                                mColGrd.DefaultCellStyle.BackColor = Color.LightYellow
                            End If

                            mBolPrevious = .Frozen


                        End With


                    End If



                Next

                '******************************************************
                'Agrega totales.
                '******************************************************
                'Actualiza la columna de totales por cada producto existente.
                For mIndexRow As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                    CalculaTotalProducto(mIndexRow)
                Next



                AgregaTotalesGrid(mvw)

                'Me.InvokePaint(Me.DataGridView1, Nothing)

                Me.WindowState = FormWindowState.Maximized


            Else
                Me.TabPronosticos.SelectTab(Me.TabMaestro)


            End If

        Catch ex As Exception

            Me.ShowErrorMessage(ex.Message)

        End Try


    End Sub
    ''' <summary>
    ''' Genera un pronostico nuevo 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GuardarNuevoAsync() As Boolean

        Dim mBolProceso As Boolean = False
        Try

            'Try
            Me.BGWK.ReportProgress(10)

            Dim mCon As SqlConnection = DjpSap.Dac.mConexion

            Using mCmd As SqlCommand = New SqlCommand
                mCmd.Connection = mCon
                mCmd.CommandType = CommandType.StoredProcedure
                mCmd.CommandText = "[PRONOSTICOS].[CREA_PRONOSTICOS]"
                With pPronostico
                    If .Id = 0 Then
                        'Busca el ultimo elemento a generar.

                        Using mCmdConsecutivo As SqlCommand = New SqlCommand
                            With mCmdConsecutivo
                                .Connection = mCon
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "PRONOSTICOS.CONSULTACONSECUTIVO_MAESTROPRONOSTICOS"
                                Dim mPar As SqlParameter = New SqlParameter()
                                mPar.Direction = ParameterDirection.ReturnValue
                                .Parameters.Add(mPar)

                                .ExecuteNonQuery()
                                pPronostico.Id = mPar.Value

                            End With
                        End Using



                    End If

                    mCmd.Parameters.AddWithValue("@IDPRONOSTICO", .Id)

                    mCmd.Parameters.AddWithValue("@CLAVEAGENTE", .Agente.Clave)
                    mCmd.Parameters.AddWithValue("@SMDINICIO", .PeriodoInicial)
                    mCmd.Parameters.AddWithValue("@SMDFIN", .PeriodoFinal)


                    mCmd.Parameters.AddWithValue("@TIPOPERIODO", .Periodo)
                    mCmd.Parameters.AddWithValue("@DESCPRONOSTICO", .Descripcion)

                    mCmd.ExecuteNonQuery()

                End With


            End Using

            'Me.Serializar()

            mCon.Close()
            mCon.Dispose()
            'Me.ConsultarAsync()
            'mPidProceso = enEstadoProceso.enModificado

            mBolProceso = Me.InicializarDataSet(pPronostico.Id)
            'IdTaskThread = "ds"



        Catch ex As Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
            Me.ShowErrorMessage(ex.Message)
            mBolProceso = False
        End Try

        Return mBolProceso

    End Function
    ''' <summary>
    ''' Guarda un pronostico existente.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GuardarExistenteAsync() As enTipoProceso
        Dim retTp As enTipoProceso = New enTipoProceso
        Dim sqltr As SqlTransaction = Nothing

        Try

            If mDataSet.HasChanges Then
                If IsNothing(mObjCeldaActual) Then mObjCeldaActual = New tpCelda

                mObjCeldaActual.Row = Me.DataGridView1.CurrentCell.RowIndex
                mObjCeldaActual.Col = Me.DataGridView1.CurrentCell.ColumnIndex

                mPidProceso = enEstadoProceso.enGuardando


                Me.BGWK.ReportProgress(10)

                With mDataSet.Tables(mcolTablas.Item(enTablasDataset.enPronosticos).NombreTablaDataSet)
                    '
                    Dim mTablaCambios = .GetChanges()
                    If mTablaCambios.Rows.Count > 0 Then

                        Dim mCmd As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand
                        Me.BGWK.ReportProgress(20)
                        Dim mCon As System.Data.SqlClient.SqlConnection = DjpSap.Dac.mConexion
                        Me.BGWK.ReportProgress(30)
                        Dim mDblCantidadBase As Double
                        Dim mDblCantidadAlterna As Double
                        Dim prod As ClassProducto = New ClassProducto()

                        sqltr = mCon.BeginTransaction

                        With mCmd
                            .Connection = mCon
                            .Transaction = sqltr

                            .CommandType = System.Data.CommandType.StoredProcedure
                            .CommandText = "PRONOSTICOS.ACTUALIZALINEA_PRONOSTICO"
                            Dim mParIdPronostico As SqlParameter = New SqlParameter
                            Dim mParCENTRO As SqlParameter = New SqlParameter
                            'Dim mParALMACEN As SqlParameter = New SqlParameter
                            Dim mParCVEPRODUCTO As SqlParameter = New SqlParameter
                            Dim mParFECHAPERIODO As SqlParameter = New SqlParameter
                            Dim mParCLIENTE As SqlParameter = New SqlParameter
                            Dim mParCANTIDADBASE As SqlParameter = New SqlParameter
                            Dim mParCANTIDADALTERNA As SqlParameter = New SqlParameter
                            Dim mParSociedad As SqlParameter = New SqlParameter

                            mParIdPronostico.ParameterName = "@IDPRONOSTICO"
                            .Parameters.Add(mParIdPronostico)


                            mParCENTRO.ParameterName = "@CENTRO"
                            .Parameters.Add(mParCENTRO)


                            'mParALMACEN.ParameterName = "@ALMACEN"
                            '.Parameters.Add(mParALMACEN)


                            mParCVEPRODUCTO.ParameterName = "@CVEPRODUCTO"
                            .Parameters.Add(mParCVEPRODUCTO)


                            mParFECHAPERIODO.ParameterName = "@FECHAPERIODO"
                            .Parameters.Add(mParFECHAPERIODO)

                            '

                            mParCLIENTE.ParameterName = "@CLIENTE"
                            .Parameters.Add(mParCLIENTE)


                            mParCANTIDADBASE.ParameterName = "@CANTIDADBASE"
                            .Parameters.Add(mParCANTIDADBASE)



                            mParCANTIDADALTERNA.ParameterName = "@CANTIDADALTERNA"
                            .Parameters.Add(mParCANTIDADALTERNA)
                            mParSociedad.ParameterName = "@SOCIEDAD"
                            .Parameters.Add(mParSociedad)

                            Me.BGWK.ReportProgress(40)
                            Dim mIrow As Integer = 0
                            For Each mRow As DataRow In mTablaCambios.Rows
                                mIrow += 1

                                Me.BGWK.ReportProgress(40 + (mIrow / mTablaCambios.Rows.Count) * 60)


                                'Me.BGWK.ReportProgress(10)
                                If mRow.RowState = System.Data.DataRowState.Modified Then
                                    'Manda los cambios al servidor de sql.


                                    'mcolTablas.Item(PronosticosSAP.Pronosticos.enTablasDataset.enPeriodos)

                                    For Each mcolGrd As ClassColumnasGridView In mColumnas.Values
                                        If mcolGrd.EsCaptura Then
                                            If IsDBNull(mRow.Item(mcolGrd.Clave)) OrElse mRow.Item(mcolGrd.Clave) = 0 Then
                                                mDblCantidadBase = 0
                                                mDblCantidadAlterna = 0
                                            Else
                                                mDblCantidadBase = mRow.Item(mcolGrd.Clave)
                                                With prod
                                                    .Clave = mRow.Item("CLAVEPRODUCTO")

                                                    .EstableceFactorConversion(mRow.Item("UNIDADMEDIDABASE"), _
                                                                                mRow.Item("UNIDADMEDIDAALTERNA"), _
                                                                               mRow.Item("FACTOR"), mRow.Item("OPERADOR"), _
                                                                                mRow.Item("CANTIDADEXACTA"))
                                                    mDblCantidadAlterna = .Equivalencia(Trim(mRow.Item("UNIDADMEDIDAALTERNA")), mRow.Item(mcolGrd.Clave))
                                                End With





                                            End If





                                            mParIdPronostico.Value = mRow.Item("IDPRONOSTICO")
                                            mParCENTRO.Value = mRow.Item("CLAVECENTRO")


                                            'mParALMACEN.Value = mRow.Item("CLAVEALMACEN")
                                            mParCVEPRODUCTO.Value = mRow.Item("CLAVEPRODUCTO")


                                            mParFECHAPERIODO.Value = mcolGrd.HeaderValorFecha

                                            mParCLIENTE.Value = mRow.Item("CLAVECLIENTE")
                                            If String.IsNullOrEmpty(mRow.Item("CLAVECLIENTE").ToString) Then
                                                mParSociedad.Value = DBNull.Value
                                            Else
                                                mParSociedad.Value = mRow.Item("CLAVESOCIEDAD")

                                            End If


                                            mParCANTIDADBASE.Value = mDblCantidadBase

                                            mParCANTIDADALTERNA.Value = mDblCantidadAlterna


                                            If Me.BGWK.CancellationPending = False Then
                                                .ExecuteNonQuery()
                                            Else
                                                Exit For
                                            End If


                                        End If
                                    Next

                                End If
                                If Me.BGWK.CancellationPending Then
                                    Exit For
                                End If
                            Next

                        End With
                        If Not Me.BGWK.CancellationPending Then
                            sqltr.Commit()
                        End If



                    End If
                    If Not Me.BGWK.CancellationPending Then
                        .AcceptChanges()
                    End If
                End With
                If IsNothing(Me.pPronostico) Then
                    pPronostico = New ClassPronosticos


                End If
                With pPronostico
                    .Id = NoPronosticoTxt.Text
                    .Agente = New ClassVendedor
                    .Agente.Id = CveAgenteTxt.Text

                End With
                Me.Serializar()

            End If
            mPidProceso = enEstadoProceso.enModificado
            retTp.intProceso = pPronostico.Id

            retTp.mbolProceso = True
            If Not IsNothing(DataGridView1.CurrentCell) Then
                retTp.intCol = DataGridView1.CurrentCell.ColumnIndex
                retTp.intRow = DataGridView1.CurrentCell.RowIndex
            Else
                retTp.intCol = 0
                retTp.intRow = 0
            End If
        Catch ex As Exception
            ModComun.MsgError(ex.Message)
            sqltr.Rollback()
            If BGWK.CancellationPending = False Then
                BGWK.CancelAsync()
            End If
            'BGWK.CancelAsync()
            retTp.mbolProceso = False


        End Try
        Return retTp
    End Function



    Private Sub ConsultarAsync()




        mPidProceso = enEstadoProceso.enAbrir


        Try
            pLngEstatus = 1
            intProgreso = 10
            mDataSet = New DataSet
            'Inicializa los objetos  de la vista
            Me.AbrirToolStripButton.Enabled = False
            Me.BGWK.RunWorkerAsync("ds")
        Catch ex As SqlException
            intProcesando = 0
            ToolStripStatusLabel.Text = "Error en el proceso"
            MsgBox(ex.Message)
            mPidProceso = enEstadoProceso.enError

        Catch ex As Exception
            intProcesando = 0

            ToolStripStatusLabel.Text = "Error en el proceso..."

            MsgBox(ex.Message)
            mPidProceso = enEstadoProceso.enError


        End Try






    End Sub


    ''' <summary>
    ''' LLena el contenido de los dataset (copias de datos)
    ''' </summary>
    ''' <param name="pTable">Nombre de la tabla a llenar</param>
    ''' <param name="pId">Identificador del escenario</param>
    ''' <param name="pConexion">Conexion a sql server</param>
    ''' <remarks>La conexion debe estar abierta</remarks>

    Private Sub FillData(ByVal pTable As tpTablasDataset, ByVal pId As String, ByVal pConexion As SqlConnection)
        'Dim mCon As SqlConnection = DjpSap.Dac.mConexion()

        Using mCmd As New System.Data.SqlClient.SqlCommand
            With mCmd
                .Connection = pConexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = pTable.SqlText
                .Parameters.AddWithValue("@parPronostico", pId) 'NoPronosticoTxt.Text
                If pTable.NombreCatalogo = "DETALLE DE PRONOSTICOS" Then
                    If ChkActivos.Checked Then
                        'Muestra los productos activos unicamente.
                        .Parameters.AddWithValue("@visibles", 1) 'NoPronosticoTxt.Text
                    Else
                        .Parameters.AddWithValue("@visibles", 0) 'NoPronosticoTxt.Text
                    End If
                End If
                

            End With


            Dim mDt As SqlDataAdapter = New SqlDataAdapter()
            mDt.SelectCommand = mCmd
            mDt.Fill(mDataSet, pTable.NombreTablaDataSet)

        End Using


    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Actualiza los totales cuando el usuario ordena las columnas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub DataGridView1_Sorted(ByVal sender As Object, ByVal e As System.EventArgs)
        AgregaTotales2()
        'CalculaTotalMes(
    End Sub
    ''' <summary>
    ''' Se ejecuta cuando se da click en el boton salir.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
        'If PuedeSalir() Then

        'End If

    End Sub


    ''' <summary>
    ''' Presenta la pantalla del presupuesto de ventas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PresupuestoMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresupuestoMnu.Click
        Me.DetieneTimer()
        Try
            Dim mItem As ClassItemPronosticos = Me.SetItemActual()
            If Not IsNothing(mItem) Then
                Dim mFrmPresupuesto As FrmPlanAnualConsulta = New FrmPlanAnualConsulta
                With mFrmPresupuesto
                    .SetItemConsulta(Me.SetItemActual())
                    .Consultar()
                    .ShowDialog()
                    .Dispose() 'Libera los recursos
                End With
            End If


        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try
        Me.InicializaTimer()
    End Sub

    ''' <summary>
    ''' Agrega producto a un pronostico.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AddProductoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProductoBtn.Click
        Try

        
        Me.DetieneTimer()

        If mDataSet.HasChanges() Then
            'Existen cambios por lo tanto pregunta antes de guardar.
            'Me.ShowMsgYesNo ("Antes de definir los repartos deben guardar sus cambios", ")
            ModComun.MsgWarning("Antes de agregar un producto guarde los cambios realizados")
            Exit Sub

        End If
        If IsNothing(pPronostico) Then
            ModComun.MsgWarning("Elija un pronostico válido")
            Exit Sub
            'pPronostico = New ClassPronosticos

        End If
        'Dependiendo del negocio muestra el formulario 
        'para agregar productos.
        Dim mAgenteSel As ClassVendedor = New ClassVendedor()

        mAgenteSel.ConsultarCatalogo(Me.CveAgenteTxt.Text, String.Empty, String.Empty, "A")


        Dim mAddProducto As FrmAddProductosPronosticoByCliente = New FrmAddProductosPronosticoByCliente
        mAddProducto.Inicializar(mAgenteSel, Me.NoPronosticoTxt.Text)
        mAddProducto.ShowDialog()


        'If mAgenteSel.AreaNegocios = "I" Then
        '    Dim mAddProducto As FrmAddProductosPronosticoByCliente = New FrmAddProductosPronosticoByCliente
        '    mAddProducto.Inicializar(mAgenteSel, Me.NoPronosticoTxt.Text)
        '    mAddProducto.ShowDialog()

        'Else
        '    Dim mFrm As New FrmAddProductoPronostico
        '    With mFrm
        '        If .Inicializar(pPronostico) Then
        '            .ShowDialog()

        '        End If
        '        .Dispose()

        '    End With
        'End If


        'ModComun.MsgWarning("Debe consultar nuevamente el pronostico para que los cambios se vean reflejados.")
        AbrirToolStripButton.PerformClick()
            MsgInfo("Verifique sus cambios se ha consultado la version del pronóstico en disco")
        Catch ex As Exception
            ToolStripStatusLabel.Text = ex.Message
        End Try



    End Sub
    Private Sub AutoSaveTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AutoSaveTimer.Tick
        Try
            Me.DetieneTimer()
            GuardaMovsEscenario()
        Catch ex As Exception
            ToolStripStatusLabel.Text = ex.Message
        End Try


        'Me.InicializaTimer()
        'AutoSaveTimer.Enabled = False
    End Sub

    Private Sub RepartosItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepartosMenuItem.Click


        Try
            If Me.DataGridView1.SelectedCells.Count = 1 Then
                Me.DetieneTimer()
                If mDataSet.HasChanges(System.Data.DataRowState.Modified) Then
                    'Existen cambios por lo tanto pregunta antes de guardar.
                    'Me.ShowMsgYesNo ("Antes de definir los repartos deben guardar sus cambios", ")
                    Me.ShowErrorWarning("Para evitar perdida de información" & Environment.NewLine &
                                        "Guarde el pronostico antes de definir los repartos.")

                Else


                    'Determina los datos del producto que se esta editando


                    'Eliga un solo renglon
                    Dim mFrm As FrmRepartos = New FrmRepartos

                    Dim mRow As DataGridViewRow = Me.DataGridView1.Rows(mObjCeldaActual.Row)

                    Dim mStrColUnidad As String = Me.DataGridView1.Columns(mObjCeldaActual.Col).DataPropertyName
                    Dim mQty As Double = 0

                    If Not IsDBNull(mRow.Cells(mObjCeldaActual.Col).Value) Then
                        Double.TryParse(mRow.Cells(mObjCeldaActual.Col).Value, mQty)
                    End If
                    mFrm.ObjItemReparto = Me.SetItemActual()


                    'mFrm.ObjItemReparto = New ClassItemPronosticos(mRow.Cells("IDPRONOSTICO").Value, _
                    '                                               Me.mColumnas.Item(mStrColUnidad).HeaderValorFecha, _
                    '                                               mRow.Cells("CLAVECENTRO").Value, _
                    '                                               mRow.Cells("CLAVEPRODUCTO").Value, _
                    '                                               mRow.Cells("CLAVEAGENTE").Value, _
                    '                                                mRow.Cells("CLAVECLIENTE").Value, _
                    '                                               mQty)


                    If Not IsNothing(mFrm.ObjItemReparto) Then
                        mFrm.SetValues()
                        mFrm.ShowDialog(Me)
                    End If
                    mFrm.Dispose()

                    'Actualiza el contenido del grid actual.
                    Me.ConsultarAsync()
                    Me.InicializaTimer()

                End If


            Else

                Me.ShowErrorWarning("Elija una celda")

            End If
        Catch ex As Exception
            Me.ShowErrorMessage(ex.Message)

        End Try
        Me.InicializaTimer()
    End Sub





    Private Sub DataGridView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDown
        Try
            'Cuando pulsa el boton derecho asigna al menu contextual.
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                'vALIDA QUE LA CELDA SEA DE CAPTURA DE VALORES.
                'Me.DataGridView1.Columns(mObjCeldaActual.Col).DataPropertyName
                'If IsNothing(mObjCeldaActual) Then Exit Sub
                mObjCeldaActual = New tpCelda
                mObjCeldaActual.Col = DataGridView1.CurrentCell.ColumnIndex
                mObjCeldaActual.Row = DataGridView1.CurrentCell.RowIndex
                'If mObjCeldaActual.Col < 0 Then Exit Sub
                Dim mCol As PronosticosSAP.ClassColumnasGridView = Me.mColumnas(DataGridView1.Columns(mObjCeldaActual.Col).DataPropertyName)
                If IsNothing(mCol) Then Exit Sub

                If mCol.EsCaptura Then


                    GuardarMnuItem.Visible = mDataSet.HasChanges() 'SI HAY cambios en el data set aparece la opcion de guardar.
                    Me.DataGridView1.CurrentCell.ContextMenuStrip = PronosticosCm

                    'PronosticosCm.Show(DataGridView1, New Point(e.X, e.Y))

                End If


            End If
        Catch ex As Exception
            Me.ShowErrorMessage(ex.Message)

        End Try


    End Sub



    ''' <summary>
    ''' Ventana de dialogo para busqueda de agentes.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AgentesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentesBtn.Click
        Try


            Dim FrmAgente As New FrmAgentesConsulta
            FrmAgente.ShowDialog()
            If FrmAgente.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                Me.CveAgenteTxt.Text = FrmAgente.mAgente.Clave
                Me.lblAgenteTxt.Text = FrmAgente.mAgente.Descripcion
                If FrmAgente.mAgente.ConsultarCatalogo() > 0 Then
                    FrmAgente.mAgente.Territorio.Consultar(FrmAgente.mAgente.Clave, String.Empty)
                    ZonasTxt.Text = FrmAgente.mAgente.Territorio.Clave
                    Me.TerritorioLbl.Text = FrmAgente.mAgente.Territorio.Descripcion
                Else
                    ZonasTxt.Text = String.Empty
                    Me.TerritorioLbl.Text = String.Empty
                End If

            End If
            FrmAgente.Dispose()
        Catch ex As Exception
            Me.ShowErrorMessage(ex.Message)
        End Try



    End Sub
    ''' <summary>
    ''' Ejecuta ventana de dialogo para buscar una zona de agentes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ZonaAgentesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mFrm As New FormZonasConsulta
        mFrm.ShowDialog()
        If mFrm.DialogResult = System.Windows.Forms.DialogResult.OK Then
            ZonasTxt.Text = mFrm.pClaveZona
        End If


    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click


        Dim mstrPeriodo As String
        Dim sqltr As SqlTransaction = Nothing
        ToolStripProgressBar.Visible = True
        Try
            If Me.Validate() Then



                Select Case mPidProceso
                    Case enEstadoProceso.enInicializar
                        '***************************************************
                        'Define el proceso para generar un ambiente nuevo.
                        '***************************************************

                        If MsgBox("Se va a generar un escenario nuevo" & vbCrLf & "¿ Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            If Me.TipoPeriodoCbo.SelectedIndex = -1 Then
                                Me.PronosticoErrProvider.SetError(Me.TipoPeriodoCbo, "Indique un periodo valido")
                                Exit Sub

                            Else
                                mstrPeriodo = Mid(Me.TipoPeriodoCbo.SelectedItem.ToString, 1, 1)
                            End If




                            'If Not IsNumeric(Me.NoPronosticoTxt.Text) Then
                            ' Me.PronosticoErrProvider.SetError(Me.NoPronosticoTxt, "Se esperaba un valor numérico")
                            ' Exit Sub

                            'End If

                            If String.IsNullOrEmpty(Me.CveAgenteTxt.Text) Then
                                Me.PronosticoErrProvider.SetError(Me.CveAgenteTxt, "Indique un agente valido.")
                                Exit Sub
                            End If

                            If Me.InicioDTP.Value > Me.FinDTP.Value Then
                                Me.PronosticoErrProvider.SetError(Me.FinDTP, "Debe ser mayor a la fecha inicial.")
                                Exit Sub
                            End If
                            If IsNothing(pPronostico) Then
                                pPronostico = New ClassPronosticos
                            End If

                            With pPronostico
                                .Periodo = mstrPeriodo
                                .Id = 0
                                Long.TryParse(Me.NoPronosticoTxt.Text, .Id)


                                .Agente = New ClassVendedor
                                .Agente.Clave = Me.CveAgenteTxt.Text
                                If .Agente.ConsultarCatalogo() > 0 Then
                                    'Buscando el dato del agente.
                                    If .Agente.AreaNegocios = "I" Then
                                        .PeriodoInicial = Me.InicioDTP.Value
                                        .PeriodoFinal = Me.FinDTP.Value
                                    Else
                                        .PeriodoInicial = DateSerial(Me.InicioDTP.Value.Year, Me.InicioDTP.Value.Month, 1)
                                        .PeriodoFinal = DateSerial(Me.FinDTP.Value.Year, Me.FinDTP.Value.Month, 1)
                                    End If
                                    Me.BGWK.RunWorkerAsync(enEstadoProceso.enInicializar)
                                Else
                                    System.Windows.Forms.MessageBox.Show("El cliente no existe")
                                End If
                                .Descripcion = Me.DescPronosticoTxt.Text


                            End With

                            'Me.ConsultarAsync()
                            'GuardarNuevoAsync()


                        End If

                    Case enEstadoProceso.enModificado
                        '***************************************************
                        'Define el proceso para guardar las ediciones del grid.
                        '***************************************************
                        GuardaMovsEscenario()


                End Select
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            'MsgBox(ex.Message)
            Try

                sqltr.Rollback()

            Catch ex2 As Exception

                Debug.Print("Error al deshacer transaccion")

            End Try
        End Try
        ToolStripProgressBar.Visible = True

    End Sub
    ''' <summary>
    ''' Se ejecuta cuando el usuario desea crear un escenario o pronostico nuevo.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        Try
            Me.DetieneTimer()
            Select Case mPidProceso
                Case enEstadoProceso.enModificado, enEstadoProceso.enError


                    If MsgBox("Esta seguro se perderan los datos no guardados", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Exit Sub
                    End If

                Case enEstadoProceso.enAbrir, enEstadoProceso.enInicializar
                    '

            End Select
            Me.NoPronosticoTxt.Text = String.Empty
            Me.NoPronosticoTxt.Enabled = True

            Me.CveAgenteTxt.Text = String.Empty
            Me.CveAgenteTxt.Enabled = True
            ' Me.ZonasTxt.Text = = mRow.Item("CLAVEAGENTE").ToString()
            Me.InicioDTP.Value = Date.Today
            Me.InicioDTP.Enabled = True

            FinDTP.Enabled = True

            Me.FinDTP.Value = Date.Today


            Me.TipoPeriodoCbo.Enabled = True


            If IsNothing(Me.pPronostico) Then
                pPronostico = New ClassPronosticos


            End If
            With pPronostico
                Integer.TryParse(NoPronosticoTxt.Text, .Id)
                .Agente = New ClassVendedor
                '.Agente.Id = CveAgenteTxt.Text

            End With
            Me.Serializar()
            Me.DataGridView1.Columns.Clear()
            Me.DataGridView1.DataSource = Nothing
            Me.TabPronosticos.SelectedTab = Me.TabMaestro
            mPidProceso = enEstadoProceso.enInicializar
        Catch ex As Exception
            ToolStripStatusLabel.Text = ex.Message
        End Try


    End Sub

    Private Sub Pronosticos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Me.PuedeSalir() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Pronosticos_HelpRequested(sender As Object, hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested
        ShowHelp()



    End Sub
    ''' <summary>
    ''' Define el diseño del grid 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Pronosticos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            '******************************************************************************************
            'Define los procesos de carga de datos de los dataset.
            '******************************************************************************************
            Me.AutoSaveTimer.Enabled = False
            mPidProceso = enEstadoProceso.enInicializar
            Dim objTabla As tpTablasDataset

            mcolTablas = New Dictionary(Of enTablasDataset, tpTablasDataset)
            'Inicializa las definicion de dataset.


            objTabla = New tpTablasDataset
            With objTabla
                .NombreTablaDataSet = "CONSULTA_MAESTROPRONOSTICOSBYID"
                .SqlText = "PRONOSTICOS.CONSULTA_MAESTROPRONOSTICOSBYID"
                .NombreCatalogo = "PRONOSTICOS CABECERA"

            End With
            mcolTablas.Add(enTablasDataset.enMaestro, objTabla)


            objTabla = New tpTablasDataset
            With objTabla
                .NombreTablaDataSet = "CONSULTA_PRONOSTICOS"
                .SqlText = "PRONOSTICOS.CONSULTA_PRONOSTICOS"
                .NombreCatalogo = "DETALLE DE PRONOSTICOS"
            End With
            mcolTablas.Add(enTablasDataset.enPronosticos, objTabla)


            objTabla = New tpTablasDataset
            With objTabla
                .NombreTablaDataSet = "CONSULTA_PRONOSTICOS_PERIODOS"
                .SqlText = "[PRONOSTICOS].[CONSULTA_PRONOSTICOS_PERIODOS]"
                .NombreCatalogo = "PERIODOS"
            End With
            mcolTablas.Add(enTablasDataset.enPeriodos, objTabla)

            objTabla = New tpTablasDataset
            With objTabla
                .NombreTablaDataSet = "CONSULTA_CENTROBYIDPRONOSTICO"
                .SqlText = "PRONOSTICOS.CONSULTA_CENTROBYIDPRONOSTICO"
                .NombreCatalogo = "CENTROS"

            End With
            mcolTablas.Add(enTablasDataset.enCentros, objTabla)




            Me.ToolStripProgressBar.Visible = False



            'Me.TabPronosticos.Enabled = False
            Me.TabPronosticos.SelectTab(Me.TabMaestro)

            pPronostico = New ClassPronosticos
            Me.DesSerializar(pPronostico)
            If pPronostico.Id <> 0 Then
                Me.NoPronosticoTxt.Text = pPronostico.Id

                Me.ConsultarAsync()

            End If



        Catch ex As Exception
            Me.ShowErrorMessage(ex.Message)

            mPidProceso = enEstadoProceso.enError

        End Try



    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pNegocio">A:Agricola, I:Industrial, E:Exportacion</param>
    ''' <remarks></remarks>
    Private Sub InicializaColGrid(ByVal pNegocio As String)

        mColumnas = New System.Collections.Generic.Dictionary(Of String, ClassColumnasGridView)

        '******************************************************************************************
        'Define el formato de las columnas del grid de datos
        '******************************************************************************************


        Dim mItem As ClassColumnasGridView = New ClassColumnasGridView("IDPRONOSTICO", "IDPRONOSTICO", False, False)
        mColumnas.Add(mItem.Clave, mItem)

        mItem = New ClassColumnasGridView("CLAVEAGENTE", "CLAVEAGENTE", False, True)
        mItem.SoloLectura = True
        mItem.Visible = False

        mColumnas.Add(mItem.Clave, mItem)

        mItem = New ClassColumnasGridView("CLAVEZONA", "CLAVEZONA", True, True)
        mItem.SoloLectura = True
        mItem.Visible = False
        'mItem.Visible = pNegocio = "A" 'Solo para el area agricola se abre la zona

        mColumnas.Add(mItem.Clave, mItem)

        mItem = New ClassColumnasGridView("CLAVECENTRO", "CLAVECENTRO", True, True)
        mItem.SoloLectura = True
        mItem.Visible = False


        mColumnas.Add(mItem.Clave, mItem)

        mItem = New ClassColumnasGridView("CLAVE" & vbCrLf & "ALMACEN", "CLAVEALMACEN", True, True)
        mItem.SoloLectura = True
        mItem.Visible = False
        'mItem.Visible = pNegocio = "A"
        mColumnas.Add(mItem.Clave, mItem)

        mItem = New ClassColumnasGridView("CLAVE" & vbCrLf & "PRODUCTO", "CLAVEPRODUCTO", True, True)
        mItem.SoloLectura = True
        mColumnas.Add(mItem.Clave, mItem)

        mItem = New ClassColumnasGridView("DESC." & vbCrLf & "PRODUCTO", "DESCPRODUCTO", True, True)
        mItem.SoloLectura = True
        mColumnas.Add(mItem.Clave, mItem)



        mItem = New ClassColumnasGridView("UND." & vbCrLf & "BASE", "UNIDADMEDIDABASE", True, True)
        mItem.SoloLectura = True
        mItem.Color = Color.Blue

        mColumnas.Add(mItem.Clave, mItem)

        mItem = New ClassColumnasGridView("UND." & vbCrLf & "VENTAS", "UNIDADMEDIDAALTERNA", True, True)
        mItem.SoloLectura = True
        mItem.Color = Color.Green

        mColumnas.Add(mItem.Clave, mItem)
        'Dependiendo del negocio sera visible o no

        mItem = New ClassColumnasGridView("CLAVE" & vbCrLf & "CLIENTE", "CLAVECLIENTE", True, True)
        mItem.SoloLectura = True
        mItem.Visible = pNegocio = "I"


        mColumnas.Add(mItem.Clave, mItem)
        'Dependiendo del negocio sera visible o no



        mItem = New ClassColumnasGridView("RAZON" & vbCrLf & "SOCIAL", "RAZONSOCIAL", True, True)
        mItem.SoloLectura = True
        mItem.Visible = pNegocio = "I"


        mColumnas.Add(mItem.Clave, mItem)


        mItem = New ClassColumnasGridView("CLAVESOCIEDAD", "CLAVESOCIEDAD", True, True)
        mItem.SoloLectura = True
        mItem.Visible = pNegocio = "I"

        mColumnas.Add(mItem.Clave, mItem)


        mItem = New ClassColumnasGridView("CANTIDADEXACTA", "CANTIDADEXACTA", False, True)
        mItem.SoloLectura = True
        mItem.Visible = False

        mColumnas.Add(mItem.Clave, mItem)

        mItem = New ClassColumnasGridView("AGENTENEGOCIO", "AGENTENEGOCIO", False, True)
        mItem.SoloLectura = True
        mItem.Visible = False

        mColumnas.Add(mItem.Clave, mItem)



        mItem = New ClassColumnasGridView("MAXPER", "MAXPER", False, True)
        mItem.SoloLectura = True
        mItem.Visible = False

        mColumnas.Add(mItem.Clave, mItem)

        mItem = New ClassColumnasGridView("FACTOR", "FACTOR", False, True)
        mItem.SoloLectura = True
        mColumnas.Add(mItem.Clave, mItem)

        mItem = New ClassColumnasGridView("OPERADOR", "OPERADOR", False, True)
        mItem.SoloLectura = True

        mColumnas.Add(mItem.Clave, mItem)

        


    End Sub
    ''' <summary>
    ''' Actualiza la consulta.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 
    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        EjecutaConsulta()
    End Sub

    ''' <summary>
    ''' Actualiza el contenido del grid aplicando los filtros de busqueda.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim mFiltro As System.Text.StringBuilder = New System.Text.StringBuilder

            If IsNothing(Me.CboCentroFiltro.SelectedValue) Then
                Me.PronosticoErrProvider.SetError(Me.CboCentroFiltro, "Elija un elemento valido")
            Else
                Dim mvw As DataView = mDataSet.Tables("CONSULTA_PRONOSTICOS").AsDataView()
                mFiltro.Append("CLAVECENTRO=" & Me.CboCentroFiltro.SelectedValue)

                If IsNothing(Me.Cbocliente.SelectedValue) = False Then
                    mFiltro.Append(" AND CLAVECLIENTE='" & Me.Cbocliente.SelectedValue & "'")
                End If

                'If IsNothing(Me.CboAlmacen.SelectedValue) = False Then
                '    If Not String.IsNullOrEmpty(Me.CboAlmacen.SelectedValue) Then

                '        mFiltro.Append(" AND CLAVEALMACEN='" & Me.CboAlmacen.SelectedValue & "'")
                '    End If

                'End If


                mvw.RowFilter = mFiltro.ToString()
                '  Dim mRowView As DataRowView = mvw.AddNew()
                ' mRowView.Item(CTE_COL_TITULO_TOTALPERIODO) = CTE_TOTAL_PERIODO_CAPTION



                'mLastRow.Cells(CTE_COL_TITULO_TOTALPERIODO).Value = CTE_TOTAL_PERIODO_CAPTION
                Me.DataGridView1.DataSource = mvw

                For mIndexRow As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                    CalculaTotalProducto(mIndexRow)
                Next

                'AgregaTotales2()
                AgregaTotalesGrid(mvw)
            End If


        Catch ex As Exception
            Me.ShowErrorMessage(ex.Message)



        End Try

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            If e.Clicks = 1 Then
                mObjCeldaActual = New tpCelda
                With mObjCeldaActual
                    .Row = e.RowIndex
                    .Col = e.ColumnIndex
                End With



            End If
        Catch ex As Exception
            Me.ShowErrorMessage("Evento:DataGridView1_CellMouseClick" & Environment.NewLine & ex.Message)
        End Try


    End Sub
    ''' <summary>
    ''' Actualiza el valor de la celda redondeada segun el factor de conversion
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub DataGridView1_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValidated


        Try
            Dim mGrd As DataGridView = CType(sender, System.Windows.Forms.DataGridView)

            With mGrd.Columns(e.ColumnIndex)
                If .ReadOnly = False And mGrd.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = False Then
                    'Solo modifica el dato cuando la celda actual este en modo de escritura
                    If InStr(.DataPropertyName, CTE_COLBASE) > 0 Or _
                         InStr(.DataPropertyName, CTE_COLALTERNA) > 0 Then
                        Dim mCelda As DataGridViewCell = mGrd.Rows(e.RowIndex).Cells(e.ColumnIndex)

                        If mCeldaActual <> 0 Then
                            mCelda.Value = mCeldaActual

                        Else
                            mCelda.Value = DBNull.Value
                        End If
                        mPidProceso = enEstadoProceso.enModificado


                    End If

                    ToolStripStatusLabel.Text = "Modificado."

                    CalculaTotalProducto(e.RowIndex)
                    CalculaTotalMes(e.ColumnIndex)
                    'CalculaGranTotal()
                End If
            End With



            'End If
        Catch ex As Exception
            Me.ShowErrorMessage("Evento:DataGridView1_CellValidated" & Environment.NewLine & ex.Message)
        End Try


    End Sub

    Private Sub DataGridView1_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating


        Try
            Dim mbolConvertirDesdeUnidadBase As String
            If mPidProceso = enEstadoProceso.enGuardando Then
                'System.Windows.Forms.MessageBox.Show("Espere Estamos guardando datos", "SPP", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                e.Cancel = True

                Exit Sub

            End If



            If InStr(DataGridView1.Columns(e.ColumnIndex).DataPropertyName, CTE_COLBASE) > 0 Or InStr(DataGridView1.Columns(e.ColumnIndex).DataPropertyName, CTE_COLALTERNA) > 0 Then
                'Dim mCeldaActual As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex) 'Determina cual es la celda que se esta editando
                Dim mGrd As DataGridView = CType(sender, System.Windows.Forms.DataGridView)
                If Not mGrd.Columns(e.ColumnIndex).ReadOnly And mGrd.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = False Then

                    mbolConvertirDesdeUnidadBase = InStr(DataGridView1.Columns(e.ColumnIndex).DataPropertyName, CTE_COLBASE) > 0
                    If Not IsDBNull(e.FormattedValue) Then

                        Double.TryParse(e.FormattedValue, mCeldaActual)
                    Else
                        mCeldaActual = 0
                    End If




                    Dim mColEquivalencia As String
                    Dim lbFound As Boolean = False


                    If InStr(mGrd.Columns(e.ColumnIndex).DataPropertyName, CTE_COLBASE) > 0 Then
                        mColEquivalencia = CTE_COLALTERNA
                        mColEquivalencia = mColEquivalencia & Mid(mGrd.Columns(e.ColumnIndex).DataPropertyName, Len(CTE_COLBASE) + 1)

                    Else
                        mColEquivalencia = CTE_COLBASE
                        mColEquivalencia = mColEquivalencia & Mid(mGrd.Columns(e.ColumnIndex).DataPropertyName, Len(CTE_COLALTERNA) + 1)

                    End If




                    If Not String.IsNullOrEmpty(e.FormattedValue) AndAlso Not IsNumeric(e.FormattedValue) Then
                        e.Cancel = True
                        Me.ShowErrorWarning("El valor debe ser numérico")




                    Else
                        'e.Cancel = False
                        'Actualiza el factor para la nueva celda.
                        Dim mValCurrentCell As Double
                        If IsDBNull(e.FormattedValue) Then
                            mValCurrentCell = 0
                        Else
                            Double.TryParse(e.FormattedValue, mValCurrentCell)
                        End If
                        If mValCurrentCell >= 0 Then
                            Dim mValFactorCell As Double
                            Double.TryParse(mGrd.Rows(e.RowIndex).Cells("FACTOR").Value, mValFactorCell)

                            Dim mObjProducto As ClassProducto = New ClassProducto
                            With mGrd.Rows(e.RowIndex)
                                mObjProducto.EstableceFactorConversion(.Cells("UNIDADMEDIDABASE").Value, _
                                                                   .Cells("UNIDADMEDIDAALTERNA").Value, _
                                                                   mValFactorCell, _
                                                                  .Cells("OPERADOR").Value, _
                                                                  .Cells("CANTIDADEXACTA").Value)


                                Dim mCelda As DataGridViewCell = mGrd.Rows(e.RowIndex).Cells(e.ColumnIndex)
                                'DataGridView1.Rows(e.RowIndex).Cells("UNIDADMEDIDAALTERNA").Value,
                                Dim mEquivalencia As Double

                                If mbolConvertirDesdeUnidadBase Then
                                    mEquivalencia = mObjProducto.Equivalencia(mObjProducto.UnidadAlterna, mCeldaActual)
                                Else
                                    mEquivalencia = mObjProducto.Equivalencia(mObjProducto.UnidadBase, mCeldaActual)
                                End If


                                If mObjProducto.HayErrorRedondeo Then
                                    If mbolConvertirDesdeUnidadBase Then
                                        mCelda.ErrorText = "Error convirtiendo a unidad " & .Cells("UNIDADMEDIDAALTERNA").Value & Environment.NewLine & _
                                                            " Se ha realizando redondeo aplicable al inmediatio superior:" & Environment.NewLine & _
                                                            " 1 " & mObjProducto.UnidadAlterna & "=" & mObjProducto.Equivalencia(mObjProducto.UnidadBase, "1") & " " & mObjProducto.UnidadBase

                                    Else
                                        mCelda.ErrorText = "Error convirtiendo a unidad " & .Cells("UNIDADMEDIDABASE").Value & Environment.NewLine & _
                                                            " Se ha realizando redondeo aplicable al inmediatio superior:" & Environment.NewLine & _
                                                            " 1 " & mObjProducto.UnidadAlterna & "=" & mObjProducto.Equivalencia(mObjProducto.UnidadBase, "1") & " " & mObjProducto.UnidadBase

                                    End If
                                Else
                                    mCelda.ErrorText = String.Empty

                                End If


                                .Cells(mColEquivalencia).Value = mEquivalencia
                                If mbolConvertirDesdeUnidadBase Then
                                    mCeldaActual = String.Format("{0:0.00}", mObjProducto.Equivalencia(mObjProducto.UnidadBase, mEquivalencia))


                                Else
                                    mCeldaActual = String.Format("{0:0.00}", mObjProducto.Equivalencia(mObjProducto.UnidadAlterna, mEquivalencia))
                                End If
                            End With
                        Else
                            e.Cancel = True
                            Me.ToolStripStatusLabel.Text = "El valor debe ser mayor que cero"
                        End If







                        'DataGridView1.Rows(e.RowIndex).Cells(DataGridView1.Columns(e.ColumnIndex).DataPropertyName).Value = mValor2 * mValFactorCell

                    End If

                End If




            End If



        Catch ex As Exception
            Me.ShowErrorMessage("Evento:DataGridView1_CellValidating" & Environment.NewLine & ex.Message)
        End Try


    End Sub

    Private Sub PronosticoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PronosticoBtn.Click
        Dim mForm As New FrmConsultaMaestroPronostico
        Dim mBolConsultar As Boolean
        mForm.ShowDialog()
        mBolConsultar = mForm.DialogResult = System.Windows.Forms.DialogResult.OK


        If mBolConsultar Then
            Me.NoPronosticoTxt.Text = mForm.IdPronostico
        End If
        mForm.Dispose()
        If mBolConsultar Then
            AbrirToolStripButton.PerformClick()
        End If


    End Sub


    Private Sub CboCentroFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCentroFiltro.SelectedIndexChanged
        Try
            Dim mstrCentro As String
            If TypeOf (Me.CboCentroFiltro.SelectedValue) Is String Then
                mstrCentro = CboCentroFiltro.SelectedValue


            Else

                mstrCentro = Me.CboCentroFiltro.SelectedValue.Item("CLAVECENTRO")

            End If

            'Actualiza los clientes del area industrial
            Dim DTCtes As New SapForecastDataSet.CONSULTA_CLIENTESBYPRONOSTICODataTable
            Dim mTaCtes As SapForecastDataSetTableAdapters.CONSULTA_CLIENTESBYPRONOSTICOTableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_CLIENTESBYPRONOSTICOTableAdapter

            Dim intRecords As Integer = mTaCtes.Fill(DTCtes, Me.NoPronosticoTxt.Text, mstrCentro)

            With Me.Cbocliente
                .DataSource = DTCtes
                .ValueMember = "CLAVECLIENTE"
                .DisplayMember = "RAZONSOCIAL"
            End With
        Catch ex As Exception
            Me.ShowErrorMessage("Evento:CboCentroFiltro_SelectedIndexChanged" & Environment.NewLine & ex.Message)

        End Try




    End Sub

    Private Sub ChkOpcVerColumnas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkOpcVerColumnas.CheckedChanged
        If IsNothing(mColumnas) = False Then
            For Each mCol As ClassColumnasGridView In mColumnas.Values
                If mCol.EsCaptura AndAlso mCol.SoloLectura Then

                    Me.DataGridView1.Columns(mCol.Clave).Visible = Not ChkOpcVerColumnas.Checked

                End If

            Next
        End If


    End Sub
    Private Sub BGWK_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGWK.DoWork
        Try
            'Prepara el Control para poder controlar la cancelacion de procesos
            Dim BG As BackgroundWorker = CType(sender, BackgroundWorker)
            

            'BGWK.RunWorkerAsync()
            IdTaskThread = e.Argument.ToString
            Select Case IdTaskThread
                Case "ds"
                    Dim mLng As Long
                    If Long.TryParse(Me.NoPronosticoTxt.Text, mLng) Then
                        Me.InicializarDataSet(mLng)
                    End If
                Case "Serializar"
                    Me.Serializar()
                Case "Deserializar"
                    Me.Serializar()
                Case enEstadoProceso.enInicializar.ToString
                    GuardarNuevoAsync()

                Case enEstadoProceso.enModificado.ToString
                    e.Result = GuardarExistenteAsync()


            End Select
            'Habilita la posibilidad de poder cancelar el thread

            If BG.CancellationPending Then
                e.Cancel = True

            End If



        Catch ex As Exception
            ModComun.MsgError(ex.Message)
            e.Cancel = True
        End Try


    End Sub

    Private Sub BGWK_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BGWK.ProgressChanged

        If e.ProgressPercentage = 0 Then
            Me.AbrirToolStripButton.Enabled = False

        End If
        Select Case mPidProceso
            Case enEstadoProceso.enAbrir
                Me.ToolStripProgressBar.Value = e.ProgressPercentage
                Me.ToolStripProgressBar.Visible = True
                Me.ToolStripStatusLabel.Text = "Espere Consultando datos.."
            Case enEstadoProceso.enModificado, enEstadoProceso.enInicializar

                Me.ToolStripProgressBar.Value = e.ProgressPercentage
                Me.ToolStripProgressBar.Visible = True
                Me.ToolStripStatusLabel.Text = "Espere Guardando datos.."


        End Select

    End Sub

    Private Sub BGWK_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGWK.RunWorkerCompleted
        Try
            If Not (e.Error Is Nothing) Then

                Me.ShowErrorWarning(e.Error.Message)

            ElseIf e.Cancelled Then
                Me.ToolStripStatusLabel.Text = "Proceso cancelado!!!"

            Else
                'Me.ShowErrorMessage("Thread:" & IdTaskThread)
                Me.ToolStripProgressBar.Visible = True
                Me.ToolStripStatusLabel.Text = "Terminado"
                Select Case IdTaskThread
                    Case "ds", enEstadoProceso.enInicializar.ToString
                        Select Case mPidProceso
                            Case enEstadoProceso.enAbrir, enEstadoProceso.enInicializar
                                If String.IsNullOrEmpty(Me.mstrErrorProceso) Then
                                    Me.NoPronosticoTxt.Text = pPronostico.Id


                                    MuestraPronostico()

                                    Me.AbrirToolStripButton.Enabled = True
                                    If Not IsNothing(mObjCeldaActual) Then
                                        'Me.DataGridView1.Rows(mObjCeldaActual.Row).Selected = True
                                        If mObjCeldaActual.Row > 0 And (mObjCeldaActual.Row < Me.DataGridView1.Rows.Count And mObjCeldaActual.Col < Me.DataGridView1.Columns.Count) Then
                                            If Me.DataGridView1.Rows(mObjCeldaActual.Row).Cells(mObjCeldaActual.Col).Visible Then

                                                Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(mObjCeldaActual.Row).Cells(mObjCeldaActual.Col)
                                            End If
                                        End If

                                    End If
                                    mPidProceso = enEstadoProceso.enAbrir

                                Else
                                    ' Me.ToolStripStatusLabel.Text = Me.mstrErrorProceso

                                    Me.ShowErrorWarning(Me.mstrErrorProceso)

                                End If
                                InicializaTimer()
                            Case enEstadoProceso.enModificado
                                MuestraPronostico()
                                If Not IsNothing(mObjCeldaActual) Then
                                    'Me.DataGridView1.Rows(mObjCeldaActual.Row).Selected = True
                                    'Se posiciona sobre la ultima celda editada.
                                    If mObjCeldaActual.Row > 0 And mObjCeldaActual.Col > 0 Then
                                        If mObjCeldaActual.Row < Me.DataGridView1.Rows.Count And mObjCeldaActual.Col < Me.DataGridView1.Columns.Count Then
                                            If Me.DataGridView1.Rows(mObjCeldaActual.Row).Cells(mObjCeldaActual.Col).Visible Then

                                                Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(mObjCeldaActual.Row).Cells(mObjCeldaActual.Col)
                                            End If
                                        End If
                                    End If


                                End If
                                Me.GuardarToolStripButton.Enabled = True
                                mPidProceso = enEstadoProceso.enAbrir
                                Me.InicializaTimer()

                        End Select
                    Case enEstadoProceso.enModificado.ToString
                        GuardarToolStripButton.Enabled = True
                        If TypeOf (e.Result) Is enTipoProceso Then
                            Dim mRst As enTipoProceso
                            mRst = CType(e.Result, enTipoProceso)
                            Me.ConsultarAsync()
                            If Me.DataGridView1.Rows(mRst.intRow).Cells(mRst.intCol).Visible Then
                                Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(mRst.intRow).Cells(mRst.intCol)
                            End If

                        End If

                End Select


                Me.ToolStripProgressBar.Value = 100

            End If
        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try




        'Me.AbrirToolStripButton.Enabled = True


    End Sub
    Private Sub GuardarMnuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GuardarMnuItem.Click
        GuardaMovsEscenario()
    End Sub

    'Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim mFrm As FrmReportViewer = New FrmReportViewer
    '    mFrm.FillReport(pPronostico.Id)
    '    mFrm.ShowDialog(Me)

    'End Sub



    Private Sub HistoricosMnu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HistoricosMnu.Click
        Try
            'Deteminar los valores de la celda actual.
            Me.DetieneTimer()

            Dim mHistFrm As FrmPronosticoCambios
            mHistFrm = New FrmPronosticoCambios

            mHistFrm.objItemConsulta = Me.SetItemActual()


            With mCeldaActual
                mHistFrm.Consultar()
                mHistFrm.ShowDialog(Me)
            End With
            mHistFrm.Dispose()
            Me.InicializaTimer()

        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try


    End Sub
    Private Sub AyudaToolStripButton_Click(sender As System.Object, e As System.EventArgs)

        ShowHelp()
    End Sub

#End Region




    
    

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            My.Settings.ProductosVisibles = ChkActivos.Checked
            My.Settings.AutoSave = Me.AutoGuardadoOpcion.Value

            InicializaTimer()
        Catch ex As Exception

        End Try
        
    End Sub

    

    Private Sub TabPronosticos_Selected(sender As Object, e As System.Windows.Forms.TabControlEventArgs) Handles TabPronosticos.Selected
        If e.TabPage.Name.Equals("TabOpciones") Then
            Me.AutoGuardadoOpcion.Value = My.Settings.AutoSave
        End If

    End Sub

    



    Private Sub AutoGuardadoOpcion_ValueChanged(sender As System.Object, e As System.EventArgs) Handles AutoGuardadoOpcion.ValueChanged

        My.Settings.AutoSave = Me.AutoGuardadoOpcion.Value
        InicializaTimer()
    End Sub

    
    

    
    

    Private Sub VentasMnu_Click(sender As System.Object, e As System.EventArgs) Handles VentasMnu.Click
        Try

            Dim mFrmVtas As New FrmHistorialVtas
            Dim mIndexColProducto As Integer
            Dim mCol As DataGridViewColumn = Me.GetColumnByDataPropertyName("CLAVEPRODUCTO")

            If mCol Is Nothing Then
                mIndexColProducto = -1
            Else
                mIndexColProducto = Me.GetColumnByDataPropertyName("CLAVEPRODUCTO").Index
            End If

            mCol = Me.GetColumnByDataPropertyName("CLAVECENTRO")
            Dim mIndexColCentro As Integer

            If mCol Is Nothing Then
                mIndexColCentro = -1
            Else
                mIndexColCentro = mCol.Index
            End If







            With DataGridView1.CurrentRow

                mFrmVtas.SetVariables(CveAgenteTxt.Text, Nothing, Nothing, Year(Date.Now), Month(Date.Now))
                mFrmVtas.AutoRun()
                mFrmVtas.ShowDialog(Me)

            End With

        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try








    End Sub

    Private Sub BtnOcultar_Click(sender As System.Object, e As System.EventArgs) Handles BtnOcultar.Click
        'Desactiva el guardado automático.
       
        Dim mIdPronostico As Long
        Try
            Me.DetieneTimer()
            GuardaMovsEscenario()

            If Long.TryParse(Me.NoPronosticoTxt.Text, mIdPronostico) AndAlso mIdPronostico > 0 Then
                Dim mFrm As New FrmOcultaProducto

                With mFrm
                    '.MdiParent = MDIPronosticos
                    .Consultar(mIdPronostico)
                    .ShowDialog(Me)
                    'Actualiza la consulta
                    .Dispose()



                End With
                AbrirToolStripButton.PerformClick() 'Actualiza la consulta actual
                'Button1.PerformClick()


            Else

                MsgBox("Seleccione un pronostico valido.")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub

   
    
    Private Sub AyudaToolStripButton_Click_1(sender As System.Object, e As System.EventArgs) Handles AyudaToolStripButton.Click
        Me.ShowHelp()

    End Sub

    Private Sub ImprimirToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripButton.Click

    End Sub

    Private Sub ALMACENPRONOSTICOBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ALMACENPRONOSTICOBindingSource.CurrentChanged

    End Sub
End Class
