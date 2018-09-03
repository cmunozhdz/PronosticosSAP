Imports System.Data.SqlClient
Imports System.Data
Imports System.Collections.Generic

Public Class FrmPronosticosAlmacen
#Region "Declaraciones"


    Private Enum enEstadoProceso
        enError = -1
        enInicializar = 1
        enAbrir = 2
        enModificado = 3
        enGuardando = 4

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


    Const CTE_COLBASE As String = "BASE_"
    Const CTE_COLALTERNA As String = "ALTERNA_"
    Dim mstrErrorProceso As String
    Dim intProcesando As Integer

    Dim mColumnas As Dictionary(Of String, ClassColumnasGridView)

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
    Private Sub DetieneTimer()
        Me.AutoSaveTimer.Enabled = False
    End Sub
    Private Sub InicializaTimer()
        Dim ObjConfig As ClassCustomConfig = New ClassCustomConfig

        Dim mLngTiempo As Long = ObjConfig.DelayAutoSave * 1000
        If mLngTiempo > 3600 * 1000 Then
            mLngTiempo = 3600 * 1000
        End If
        If mLngTiempo > 0 Then
            Me.AutoSaveTimer.Interval = mLngTiempo

            Me.AutoSaveTimer.Enabled = True

        Else
            Me.AutoSaveTimer.Enabled = False

        End If
    End Sub
    Private Sub GuardaMovsEscenario()
        Me.AutoSaveTimer.Enabled = False
        Me.Validate()
        Me.GuardarToolStripButton.Enabled = False
        Me.BGWK.RunWorkerAsync(enEstadoProceso.enModificado)

    End Sub

    Private Sub InicializarDataSet(ByVal pIdPronostico As Long)
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

        Catch ex As Exception
            mstrErrorProceso = ex.Message

        End Try



    End Sub
    ''' <summary>
    ''' Serializa como xml el objeto actual
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Serializar() As Boolean

        Try
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
    ''' <param name="pPronostico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DesSerializar(ByRef pPronostico As ClassPronosticos) As Boolean
        Dim mBolEstatusProceso As Boolean = False
        Try
            Dim mObjStream As DjpSap.ClassXmlRW = New DjpSap.ClassXmlRW(0, pPronostico.GetType.Name)
            If IsNothing(mObjStream.xmlReader) = False Then


                Dim mSerializer As New System.Xml.Serialization.XmlSerializer(GetType(ClassPronosticos))


                pPronostico = CType(mSerializer.Deserialize(mObjStream.xmlReader), ClassPronosticos)
            Else
                pPronostico.Id = 0
            End If
            mBolEstatusProceso = True


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Return mBolEstatusProceso
    End Function

    Private Sub Consultar()


        Dim mStrColUnidad As String = Nothing

        mPidProceso = enEstadoProceso.enAbrir


        Try
            pLngEstatus = 1
            Dim intProgreso As Long = 0




            'ToolStriptxt.Text = "Iniciando ..."

            'Me.ToolStripProgressBar.Visible = False
            mDataSet = New DataSet
            Dim mCon As SqlConnection = DjpSap.Dac.mConexion()
            Dim mCol As ClassColumnasGridView
            Dim tpronosticos As DataTable
            Dim objTabla As tpTablasDataset


            Using mCon

                'Dim mCon As System.Data.SqlClient.SqlConnection = DjpSap.Dac.mConexion()

                ''Verificar.
                For Each objTabla In mcolTablas.Values
                    'Me.BGWK.RunWorkerAsync()

                    'ToolStriptxt.Text = "Consultando..." & objTabla.NombreCatalogo
                    intProgreso = intProgreso + 10
                    'Me.BGWK.ReportProgress(intProgreso)

                    Me.FillData(objTabla, Me.NoPronosticoTxt.Text, mCon)

                Next
                mCon.Close()



            End Using

            'Inicializa los objetos  de la vista



            'Obtiene el maestro del pronostico
            tpronosticos = mDataSet.Tables(mcolTablas(enTablasDataset.enMaestro).NombreTablaDataSet)


            If tpronosticos.Rows.Count > 0 Then
                'Trae los datos del agente.


                intProgreso = intProgreso + 10
                'Me.BGWK.ReportProgress(intProgreso)



                Dim mAgente As ClassVendedor = New ClassVendedor
                If IsDBNull(tpronosticos.Rows(0).Item("CLAVEAGENTE")) = False Then
                    intProgreso = intProgreso + 10
                    'Me.BGWK.ReportProgress(intProgreso)


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




                'Obtiene los centros
                Dim MSTRTMP = mcolTablas(enTablasDataset.enCentros).SqlText

                With Me.CboCentroFiltro
                    .DataSource = mDataSet.Tables(mcolTablas(enTablasDataset.enCentros).NombreTablaDataSet)
                    .DisplayMember = "DESCRIPCION"
                    .ValueMember = "CLAVECENTRO"
                End With

                'Trae los datos generales.
                For Each mRow As DataRow In mDataSet.Tables("CONSULTA_MAESTROPRONOSTICOSBYID").Rows
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

                    InicializaColGrid(mRow.Item("NEGOCIO"))
                Next
                'Actualiza la coleccion de columnas del mes actual.
                Dim mDt As Date = DateSerial(Date.Today.Year, Date.Today.Month + 1, DjpSap.ClassConfig.strGetPeriodobloqueado(mAgente.AreaNegocios))
                'Determina la fecha apartir del cual se bloquean los periodos
                Me.lblCongelado.Text = "Editable a partir de:" & String.Format("{0:dd-MMM-yyyy}", mDt)


                ToolStripStatusLabel.Text = "Formateando registros..."
                'Obtiene los meses 
                Dim mFecha As String
                For Each mRow As DataRow In mDataSet.Tables(mcolTablas(enTablasDataset.enPeriodos).NombreTablaDataSet).Rows
                    'Determina el titulo de las columnas


                    If mAgente.AreaNegocios = "A" Then
                        mFecha = String.Format("{0:MMM-yyyy}", mRow.Item("SMDINICIO")) 'CDate(mRow.Item("SMDINICIO")).ToString("yyyy-MMM-dd")
                    Else
                        mFecha = String.Format("{0:dd-MMM-yyyy}", mRow.Item("SMDINICIO")) 'CDate(mRow.Item("SMDINICIO")).ToString("yyyy-MMM-dd")
                    End If



                    mStrColUnidad = CTE_COLBASE & mRow.Item("INTPERIODO").ToString()

                    If Me.mColumnas.ContainsKey(mStrColUnidad) Then
                        mCol = Me.mColumnas.Item(mStrColUnidad)
                        mCol.Header = mFecha
                        mCol.Visible = Not Me.ChkUnidadAlterna.Checked
                        mCol.Frozen = False
                        mCol.EsCaptura = True
                        mCol.HeaderValorFecha = mRow.Item("SMDINICIO")


                    Else
                        mCol = New ClassColumnasGridView(mFecha, mStrColUnidad, True, True)
                        mCol.Visible = Not Me.ChkUnidadAlterna.Checked
                        mCol.Frozen = False
                        mCol.EsCaptura = True
                        mCol.HeaderValorFecha = mRow.Item("SMDINICIO")

                        Me.mColumnas.Add(mCol.Clave, mCol)

                    End If
                    mCol.SoloLectura = mDt > CDate(mRow.Item("SMDINICIO"))
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

                        mCol.Visible = Me.ChkUnidadAlterna.Checked

                        mCol.Frozen = False
                        mCol.EsCaptura = False

                    Else
                        'Dim mDt As Date = mRow.Item("SMDINICIO")


                        mCol = New ClassColumnasGridView(mFecha, mStrColUnidad, True, True)
                        mCol.Header = mFecha
                        mCol.Visible = Me.ChkUnidadAlterna.Checked
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

                Next mRow
                'Trase los datos del grid


                'Toma el dataset del detalle del pronostico y lo mete como dataview para poder hacer filtros en tiempo 
                'de ejecucion y evitar retrasos de red.


                Dim mvw As DataView = New DataView(mDataSet.Tables(mcolTablas(enTablasDataset.enPronosticos).NombreTablaDataSet))
                If Not IsNothing(Me.CboCentroFiltro.SelectedValue) Then
                    mvw.RowFilter = "CLAVECENTRO=" & Me.CboCentroFiltro.SelectedValue

                Else
                    mvw.RowFilter = String.Empty

                End If
                If mAgente.AreaNegocios = "A" Then
                    Me.Cbocliente.Visible = False
                    lblCliente.Visible = False

                Else
                    Me.Cbocliente.Visible = True
                    Me.lblCliente.Visible = True

                End If

                Me.Cbocliente.SelectedIndex = -1
                Me.DataGridView1.DataSource = mvw

                If mvw.Count > 0 And mAgente.AreaNegocios = "A" Then
                    'Solo para el area agricola trae las zonas.
                    If IsDBNull(mvw.Item(0).Item("CLAVEZONA")) = False Then
                        Dim mZona As ClassZona = New ClassZona(mvw.Item(0).Item("CLAVEZONA").ToString())
                        Me.RegionLbl.Text = "Región:"
                        If mZona.Consultar > 0 Then

                            Me.ZonaLabel.Text = mZona.Descripcion
                            Me.ZonasTxt.Text = mZona.Clave

                        Else
                            'Me.ZonaLabel.Text = "Zona:"
                            Me.ZonasTxt.Text = String.Empty
                        End If

                    Else
                        Me.RegionLbl.Text = String.Empty
                        Me.ZonaLabel.Text = String.Empty
                    End If

                Else
                    Me.ZonaLabel.Text = String.Empty
                    Me.ZonasTxt.Text = String.Empty

                End If
                'Rellena la lista de almacenes.
                'se Actualiza al elefir un elemento de los centros.

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

                            End If
                            mBolPrevious = .Frozen


                        End With


                    End If



                Next
            End If


            'ToolStriptxt.Text = "Proceso Terminado !!!"
            Me.TabPronosticos.SelectTab(Me.TabDetalle)


            intProcesando = 0




        Catch ex As SqlException
            intProcesando = 0
            ToolStripStatusLabel.Text = "Error en el proceso"
            MsgBox(ex.Message)
            mPidProceso = enEstadoProceso.enError

        Catch ex As Exception
            intProcesando = 0

            ToolStripStatusLabel.Text = "Error en el proceso..."

            MsgBox(ex.Message & mStrColUnidad)
            mPidProceso = enEstadoProceso.enError


        End Try






    End Sub
    ''' <summary>
    ''' Presenta el resultado del pronostico, este metodo se manda llamar despues que se hayan llenaddo los datasets
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MuestraPronostico()
        Try
            Dim mCol As ClassColumnasGridView
            Dim tpronosticos As DataTable
            Dim mStrColUnidad As String
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

                    End With
                    'Ejecuta la serializacion asyncrona
                    'para mejorar el rendimiento
                    Me.BGWK.RunWorkerAsync("Serializar")

                    'Me.Serializar()

                End If




                'Actualiza la coleccion de columnas del mes actual.
                Dim mDt As Date = DateSerial(Date.Today.Year, Date.Today.Month + 1, DjpSap.ClassConfig.strGetPeriodobloqueado(mAgente.AreaNegocios))
                'Determina la fecha apartir del cual se bloquean los periodos
                Me.lblCongelado.Text = "Editable a partir de:" & String.Format("{0:dd-MMM-yyyy}", mDt)


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
                        mCol.Visible = Not Me.ChkUnidadAlterna.Checked
                        mCol.Frozen = False
                        mCol.EsCaptura = True
                        mCol.HeaderValorFecha = mRow.Item("SMDINICIO")


                    Else
                        mCol = New ClassColumnasGridView(mFecha, mStrColUnidad, True, True)
                        mCol.Visible = Not Me.ChkUnidadAlterna.Checked
                        mCol.Frozen = False
                        mCol.EsCaptura = True
                        mCol.HeaderValorFecha = mRow.Item("SMDINICIO")

                        Me.mColumnas.Add(mCol.Clave, mCol)

                    End If
                    mCol.SoloLectura = mDt > CDate(mRow.Item("SMDINICIO"))
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

                        mCol.Visible = Me.ChkUnidadAlterna.Checked

                        mCol.Frozen = False
                        mCol.EsCaptura = False

                    Else
                        'Dim mDt As Date = mRow.Item("SMDINICIO")


                        mCol = New ClassColumnasGridView(mFecha, mStrColUnidad, True, True)
                        mCol.Header = mFecha
                        mCol.Visible = Me.ChkUnidadAlterna.Checked
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
                If Not IsNothing(Me.CboCentroFiltro.SelectedValue) Then
                    mvw.RowFilter = "CLAVECENTRO=" & Me.CboCentroFiltro.SelectedValue

                Else
                    mvw.RowFilter = String.Empty

                End If
                If mAgente.AreaNegocios = "A" Then
                    Me.Cbocliente.Visible = False
                    lblCliente.Visible = False

                Else
                    Me.Cbocliente.Visible = True
                    Me.lblCliente.Visible = True

                End If

                Me.Cbocliente.SelectedIndex = -1





                Me.DataGridView1.DataSource = mvw

                If mvw.Count > 0 And mAgente.AreaNegocios = "A" Then

                    If IsDBNull(mvw.Item(0).Item("CLAVEZONA")) = False Then
                        Dim mZona As ClassZona = New ClassZona(mvw.Item(0).Item("CLAVEZONA").ToString())

                        If mZona.Consultar > 0 Then
                            Me.ZonaLabel.Text = "Zona:" & mZona.Descripcion
                            Me.ZonasTxt.Text = mZona.Clave

                        Else
                            Me.ZonaLabel.Text = "Zona:"
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

                            End If
                            mBolPrevious = .Frozen


                        End With


                    End If



                Next
                With Me.TabPronosticos
                    .SelectTab(Me.TabDetalle)

                    .Enabled = True
                End With
                InicializaTimer()


            Else
                Me.TabPronosticos.SelectTab(Me.TabMaestro)


            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message, "SCCP", System.Windows.Forms.MessageBoxButtons.OK)


        End Try


    End Sub

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
                    mCmd.Parameters.AddWithValue("@IDPRONOSTICO", .Id)

                    mCmd.Parameters.AddWithValue("@CLAVEAGENTE", .Agente.Clave)
                    mCmd.Parameters.AddWithValue("@SMDINICIO", .PeriodoInicial)
                    mCmd.Parameters.AddWithValue("@SMDFIN", .PeriodoFinal)


                    mCmd.Parameters.AddWithValue("@TIPOPERIODO", .Periodo)
                    mCmd.ExecuteNonQuery()

                End With


            End Using

            Me.Serializar()

            mCon.Close()
            mCon.Dispose()
            'Me.ConsultarAsync()
            mPidProceso = enEstadoProceso.enAbrir
            Dim mLngIdPronostico As Long
            If Long.TryParse(Me.NoPronosticoTxt.Text, mLngIdPronostico) Then


                Me.InicializarDataSet(mLngIdPronostico)
                mBolProceso = True
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            mBolProceso = False
        End Try

        Return mBolProceso

    End Function
    Private Sub GuardarExistenteAsync()

        Dim sqltr As SqlTransaction
        If mDataSet.HasChanges Then
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


                                        mParCANTIDADBASE.Value = mDblCantidadBase

                                        mParCANTIDADALTERNA.Value = mDblCantidadAlterna


                                        .ExecuteNonQuery()
                                    End If
                                Next

                            End If

                        Next

                    End With

                    sqltr.Commit()


                End If

                .AcceptChanges()

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

    End Sub



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
            End With


            Dim mDt As SqlDataAdapter = New SqlDataAdapter()
            mDt.SelectCommand = mCmd
            mDt.Fill(mDataSet, pTable.NombreTablaDataSet)

        End Using


    End Sub

#End Region

#Region "Eventos"





    ''' <summary>
    ''' Ventana de dialogo para busqueda de agentes.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AgentesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentesBtn.Click
        Dim FrmAgente As New FrmAgentesConsulta
        FrmAgente.ShowDialog()
        If FrmAgente.DialogResult = System.Windows.Forms.DialogResult.Yes Then
            Me.CveAgenteTxt.Text = FrmAgente.mAgente.Clave
            Me.lblAgenteTxt.Text = FrmAgente.mAgente.Descripcion

        End If
        FrmAgente.Dispose()




    End Sub
    ''' <summary>
    ''' Ejecuta ventana de dialogo para buscar una zona de agentes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ZonaAgentesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZonaAgentesBtn.Click
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




                        If Not IsNumeric(Me.NoPronosticoTxt.Text) Then
                            Me.PronosticoErrProvider.SetError(Me.NoPronosticoTxt, "Se esperaba un valor numérico")
                            Exit Sub

                        End If
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
                            .Id = Me.NoPronosticoTxt.Text

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

        mPidProceso = enEstadoProceso.enInicializar
        If IsNothing(Me.pPronostico) Then
            pPronostico = New ClassPronosticos


        End If
        With pPronostico
            Integer.TryParse(NoPronosticoTxt.Text, .Id)
            .Agente = New ClassVendedor
            '.Agente.Id = CveAgenteTxt.Text

        End With
        Me.Serializar()


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

            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
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
    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        Me.ConsultarAsync()

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

                Me.DataGridView1.DataSource = mvw


            End If


        Catch ex As Exception

            MsgBox(ex.Message)

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
        Dim mGrd As DataGridView = CType(sender, System.Windows.Forms.DataGridView)
        With mGrd.Columns(e.ColumnIndex)
            If .ReadOnly = False Then
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
            End If
        End With



    End Sub

    Private Sub DataGridView1_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        Dim mbolConvertirDesdeUnidadBase As String
        If mPidProceso = enEstadoProceso.enGuardando Then
            'System.Windows.Forms.MessageBox.Show("Espere Estamos guardando datos", "SPP", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
            e.Cancel = True

            Exit Sub

        End If



        If InStr(DataGridView1.Columns(e.ColumnIndex).DataPropertyName, CTE_COLBASE) > 0 Or InStr(DataGridView1.Columns(e.ColumnIndex).DataPropertyName, CTE_COLALTERNA) > 0 Then
            'Dim mCeldaActual As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex) 'Determina cual es la celda que se esta editando
            Dim mGrd As DataGridView = CType(sender, System.Windows.Forms.DataGridView)
            If Not mGrd.Columns(e.ColumnIndex).ReadOnly Then

                mbolConvertirDesdeUnidadBase = InStr(DataGridView1.Columns(e.ColumnIndex).DataPropertyName, CTE_COLBASE) > 0
                Double.TryParse(e.FormattedValue, mCeldaActual)



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
                    MsgBox("El valor debe ser numérico", MsgBoxStyle.Information)


                Else
                    'e.Cancel = False
                    'Actualiza el factor para la nueva celda.
                    Dim mValCurrentCell As Double
                    Double.TryParse(e.FormattedValue, mValCurrentCell)

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




                    'DataGridView1.Rows(e.RowIndex).Cells(DataGridView1.Columns(e.ColumnIndex).DataPropertyName).Value = mValor2 * mValFactorCell

                End If
            End If




        End If




    End Sub

    Private Sub PronosticoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PronosticoBtn.Click
        Dim mForm As New FrmConsultaMaestroPronostico
        mForm.ShowDialog()
        If mForm.DialogResult = System.Windows.Forms.DialogResult.OK Then
            Me.NoPronosticoTxt.Text = mForm.IdPronostico

        End If
        mForm.Dispose()


    End Sub







    Private Sub CboCentroFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCentroFiltro.SelectedIndexChanged
        'Actualiza los centros
        'Dim mTa As SapForecastDataSet.ALMACENPRONOSTICODataTable = New SapForecastDataSet.ALMACENPRONOSTICODataTable()
        'Dim mTd As SapForecastDataSetTableAdapters.ALMACENPRONOSTICOTableAdapter = New SapForecastDataSetTableAdapters.ALMACENPRONOSTICOTableAdapter()
        Dim mstrCentro As String
        If TypeOf (Me.CboCentroFiltro.SelectedValue) Is String Then
            mstrCentro = CboCentroFiltro.SelectedValue

            'mTd.Fill(mTa, Me.NoPronosticoTxt.Text, Me.CboCentroFiltro.SelectedValue)

        Else
            'mTd.Fill(mTa, Me.NoPronosticoTxt.Text, Me.CboCentroFiltro.SelectedValue.Item("CLAVECENTRO"))
            mstrCentro = Me.CboCentroFiltro.SelectedValue.Item("CLAVECENTRO")

        End If
        'mTd.Fill(mTa, Me.NoPronosticoTxt.Text, mstrCentro)

        'Me.ALMACENPRONOSTICOBindingSource.DataSource = mTa
        'Actualiza los clientes del area industrial
        Dim DTCtes As New SapForecastDataSet.CONSULTA_CLIENTESBYPRONOSTICODataTable
        Dim mTaCtes As SapForecastDataSetTableAdapters.CONSULTA_CLIENTESBYPRONOSTICOTableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_CLIENTESBYPRONOSTICOTableAdapter

        Dim intRecords As Integer = mTaCtes.Fill(DTCtes, Me.NoPronosticoTxt.Text, mstrCentro)

        With Me.Cbocliente
            .DataSource = DTCtes
            .ValueMember = "CLAVECLIENTE"
            .DisplayMember = "RAZONSOCIAL"
        End With



    End Sub

    Private Sub ChkOpcVerColumnas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkOpcVerColumnas.CheckedChanged
        If IsNothing(mColumnas) = False Then
            For Each mCol As ClassColumnasGridView In mColumnas.Values
                If mCol.EsCaptura Then
                    If mCol.SoloLectura Then
                        Me.DataGridView1.Columns(mCol.Clave).Visible = Not ChkOpcVerColumnas.Checked
                    End If
                End If

            Next
        End If


    End Sub
    Private Sub BGWK_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGWK.DoWork
        Select Case e.Argument.ToString
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
                GuardarExistenteAsync()

        End Select






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

        If Not (e.Error Is Nothing) Then
            MessageBox.Show(e.Error.Message)
        ElseIf e.Cancelled Then
            Me.ToolStripStatusLabel.Text = "Proceso cancelado!!!"

        Else

            Me.ToolStripProgressBar.Visible = True
            Me.ToolStripStatusLabel.Text = "Terminado"

            Select Case mPidProceso
                Case enEstadoProceso.enAbrir
                    If String.IsNullOrEmpty(Me.mstrErrorProceso) Then
                        MuestraPronostico()
                        Me.AbrirToolStripButton.Enabled = True
                    Else
                        ' Me.ToolStripStatusLabel.Text = Me.mstrErrorProceso
                        System.Windows.Forms.MessageBox.Show(Me.mstrErrorProceso, "Pronosticos", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)

                    End If

                Case enEstadoProceso.enModificado
                    MuestraPronostico()
                    Me.GuardarToolStripButton.Enabled = True
                    mPidProceso = enEstadoProceso.enAbrir
                    Me.InicializaTimer()

            End Select

            Me.ToolStripProgressBar.Value = 100

        End If



        'Me.AbrirToolStripButton.Enabled = True


    End Sub
    ''' <summary>
    ''' Controla el tiempo en el cual se efecutará el guardado automático.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AutoSaveTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AutoSaveTimer.Tick

        Me.DetieneTimer()
        GuardaMovsEscenario()
        'Me.InicializaTimer()
        'AutoSaveTimer.Enabled = False
    End Sub
    

#End Region


  
  
    
End Class
