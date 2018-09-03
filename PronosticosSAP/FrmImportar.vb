Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class FrmImportar
#Region "Declaraciones"
    'Definicion de las columnas de escenario Hdr
    Const CTE_CAPTION As String = "SIGEPRO  (Importando archivos)"
    ''' <summary>
    ''' Define las columnas que se estan considerando como detalle del pronostico
    ''' o del plan
    ''' </summary>
    ''' <remarks></remarks>
    Enum enDefPronosticoLinea2

        enCentro = 0
        enCliente = 1
        enProducto = 2
        enSociedad = 3

        enFechaIni = 5

    End Enum
    ''' <summary>
    ''' Define las columnas utilizadas combo encabezado del pronostico o plan
    ''' </summary>
    ''' <remarks></remarks>

    Enum enDefPronosticoHdr
        enCeldaA = 0
        enFolioEscenario = 1
        enCeldaC = 2
        enEsNuevo = 3
        EnCeldaE = 4
        EnPeriodoIni = 5
        EnPeriodoFin = 6
        EnCeldaH = 7
        enCveAgente = 8

        EnTipoPeriodo = 10
        EnDescripcion = 12




    End Enum
    Enum enColImportarFile
        enSociedad = 0
        enCliente = 1
        enAgente = 2
        enProducto = 3
        enCentro = 4
        enVigencia = 5
    End Enum

    Enum enColImportarFileAddProducto
        enSociedad = 0
        enCliente = 1
        enAgente = 2
        enProducto = 3
        enCentro = 4
        enPronostico = 5

    End Enum

    Dim mStrFileOrigen As String
    'Dim mArrayError As ArrayList
    Dim mItem As ClassMsgError
#End Region
#Region "Eventos"


    ''' <summary>
    ''' Se ejecuta cuando termina la ejecución del proceso de importacion.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub ImportarBW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ImportarBW.RunWorkerCompleted

        If Not IsNothing(e.Error) Then
            'System.Windows.Forms.MessageBox.Show(e.Error.Message, CTE_ERROR, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            ShowMessageError(e.Error.Message)
        ElseIf e.Cancelled Then
            'System.Windows.Forms.MessageBox.Show("Proceso Cancelado", CTE_ERROR, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            ShowMessageError("Proceso Cancelado")
        Else
            mItem = New ClassMsgError("ImportarBW_RunWorkerCompleted", "Proceso terminado")


            Me.LstErrores.Items.Add(UCase(mItem.Mensaje))

            Me.LstErrores.SelectedIndex = Me.LstErrores.Items.Count - 1
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ToolStripPB.ProgressBar.Value = 100

            AbrirToolStripButton.Enabled = True

        End If

    End Sub
    ''' <summary>
    ''' Sirve para copiar la bitacora de errores en un archivo de texto.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub CopiarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripButton.Click
        Try
            Select Case Me.ActiveControl.Name
                Case "LstErrores"

                    Dim mBld As System.Text.StringBuilder = New System.Text.StringBuilder()
                    For Each strItem As String In LstErrores.Items
                        mBld.AppendLine(strItem)
                    Next

                    Clipboard.SetText(mBld.ToString)


            End Select

        Catch ex As Exception
            ShowMessageError(ex.Message)

        End Try

    End Sub





    ''' <summary>
    ''' Define la tarea a ejecutar de manera asincrona
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ImportarBW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ImportarBW.DoWork


        ImportarArchivo(e.Argument)

    End Sub

    ''' <summary>
    ''' Pregunta por el nombre del archivo a importar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        If IsNothing(TablaCbo.SelectedValue) Then
            'Debe elegirse un elemento valido
            Exit Sub
        End If
        AbrirToolStripButton.Enabled = False
        If Not IsNothing(TablaCbo.SelectedItem) Then
            'LstErrores.Items.Clear()
            Me.LstErrores.Items.Clear()

            With ImportOFD
                .AddExtension = True
                .CheckFileExists = True
                .DefaultExt = ".txt"
                .Filter = "Archivos de Texto(*.txt)|*.txt|Excel CSV (*.csv)|*.csv"
                .FileName = String.Empty
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    mStrFileOrigen = .FileName
                    If Not String.IsNullOrEmpty(mStrFileOrigen) Then

                        Me.ImportarBW.RunWorkerAsync(TablaCbo.SelectedValue)
                    End If

                End If


            End With


        End If


    End Sub

    ''' <summary>
    ''' Reporta avances del proceso.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub ImportarBW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles ImportarBW.ProgressChanged
        'Me.TablaCbo.DataSource = mArrayError
        'ListBoxDataFill()
        Try
            If Not IsNothing(mItem) Then

                Me.LstErrores.Items.Add(UCase(mItem.Origen & Chr(9) & mItem.Mensaje))
            End If
            ToolStripPB.ProgressBar.Value = e.ProgressPercentage
            Me.LstErrores.SelectedIndex = Me.LstErrores.Items.Count - 1
            mItem = Nothing 'Borra el log para evitar llamadas recursivas.
        Catch ex As Exception
            ShowMessageError(ex.Message)
        End Try




    End Sub


#End Region
#Region "Metodos"



    ''' <summary>
    ''' Importa los clientes asignados por agente.
    ''' </summary>
    ''' <param name="pStrTabla"></param>
    ''' <remarks></remarks>
    Private Sub ImportarArchivo(ByVal pStrTabla As String)


        Select Case pStrTabla
            Case "001"
                ImportaCtesXAgente()
            Case "002"
                ImportaPronosticos()
            Case "003"
                ImportaPlan()
            Case "004"
                ImportaCtesXAgentePronostico()

        End Select
    End Sub

    Private Sub ImportaCtesXAgente()
        Try
            'hace la llamada asyncrona.
            Dim intRow As Long
            'mArrayError = New ArrayList





            If Not String.IsNullOrEmpty(mStrFileOrigen) Then
                'Abre el archivo de lectura


                Dim mFileEstream As System.IO.StreamReader
                mFileEstream = New System.IO.StreamReader(mStrFileOrigen)
                Dim mSeparador As String = My.Settings.SeparadorArchivos
                If mSeparador = "\t" Then mSeparador = Chr(9)

                If mFileEstream.EndOfStream = False Then
                    Dim mTran As SqlTransaction
                    Dim mCon As SqlConnection = DjpSap.Dac.mConexion()
                    Dim mstrQuery As String

                    mTran = mCon.BeginTransaction

                    If Iniciarchk.Checked Then
                        mstrQuery = "CATALOGOS.INICIALIZA_AGENTECLIENTE"
                        'Else
                        '   mstrQuery = "CATALOGOS.SETCLIENTESVIGENCIA"



                        Try

                            Dim mCmdInicializar As SqlClient.SqlCommand = New SqlClient.SqlCommand(mstrQuery, mCon, mTran)
                            mCmdInicializar.ExecuteNonQuery()

                            mItem = New ClassMsgError("Inicializando Tabla", "Incializando tabla")



                        Catch ex As Exception
                            mItem = New ClassMsgError(ex.Source, ex.Message)

                        End Try
                        Me.ImportarBW.ReportProgress(1)
                    End If



                    Dim mCmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("CATALOGOS.INSERTA_AGENTECLIENTE", mCon, mTran)
                    Using mCmd



                        mCmd.CommandType = CommandType.StoredProcedure

                        Dim mParAgente = New SqlClient.SqlParameter()
                        mParAgente.ParameterName = "@CVEAGENTE"
                        mCmd.Parameters.Add(mParAgente)



                        Dim mParCliente = New SqlClient.SqlParameter()
                        mParCliente.ParameterName = "@CVECTE"
                        mCmd.Parameters.Add(mParCliente)

                        Dim mParSociedad = New SqlClient.SqlParameter()
                        mParSociedad.ParameterName = "@SOCIEDAD"
                        mCmd.Parameters.Add(mParSociedad)


                        Dim mParProducto = New SqlClient.SqlParameter()
                        mParProducto.ParameterName = "@CVEPRODUCTO"
                        mCmd.Parameters.Add(mParProducto)

                        Dim mParCentro = New SqlClient.SqlParameter()
                        mParCentro.ParameterName = "@CVECENTRO"
                        mCmd.Parameters.Add(mParCentro)
                        'mCmd.Connection = DjpSap.Dac.mConexion()
                        Dim mParVigencia = New SqlClient.SqlParameter()
                        mParVigencia.ParameterName = "@VIGENCIA"
                        mCmd.Parameters.Add(mParVigencia)


                        mItem = New ClassMsgError("IO", "Procesando...")
                        Me.ImportarBW.ReportProgress(1)

                        'mArrayError.Add(New ClassMsgError("ImportarCtesXAgente", "Iniciando Proceso ...."))
                        intRow = 0
                        While mFileEstream.EndOfStream = False
                            intRow += 1


                            Dim mArrCampos As String() = mFileEstream.ReadLine().Split(mSeparador)
                            If IsNumeric(mArrCampos(enColImportarFile.enCentro).Replace(Chr(34), String.Empty)) Then

                                mParAgente.Value = Trim(mArrCampos(enColImportarFile.enAgente).Replace(Chr(34), String.Empty))
                                mParCliente.Value = Trim(mArrCampos(enColImportarFile.enCliente).Replace(Chr(34), String.Empty))
                                mParSociedad.Value = Trim(mArrCampos(enColImportarFile.enSociedad).Replace(Chr(34), String.Empty))

                                'Busca la relacion sociedad centro
                                mParProducto.Value = Trim(mArrCampos(enColImportarFile.enProducto).Replace(Chr(34), String.Empty))
                                mParCentro.Value = Trim(mArrCampos(enColImportarFile.enCentro).Replace(Chr(34), String.Empty))
                                mParVigencia.Value = Trim(mArrCampos(enColImportarFile.enVigencia).Replace(Chr(34), String.Empty))

                                
                                Try
                                    mCmd.ExecuteNonQuery()
                                    If Not Me.RegistrosChk.Checked Then
                                        mItem = New ClassMsgError("EntradaOk", "Row:" & intRow & Chr(9) & "Agente:" & mParAgente.Value & Chr(9) & " Cliente:" & mParCliente.Value & Chr(9) & " Producto:" & mParProducto.Value & Chr(9) & " Centro:" & Chr(9) & mParCentro.Value & Chr(9) & " Agregado Correctamente")
                                    Else
                                        mItem = Nothing
                                    End If


                                Catch ex As Exception

                                    mItem = New ClassMsgError("EntradaErronea", "Row:" & Chr(9) & intRow & Chr(9) & ex.Message)


                                End Try
                                Me.ImportarBW.ReportProgress((intRow Mod 10) * 10)
                            End If



                        End While
                        If Me.SimularChk.Checked Then
                            mTran.Rollback()
                        Else
                            mTran.Commit()
                        End If


                        mCmd = Nothing
                        mCon.Close()

                    End Using
                    mItem = New ClassMsgError("ImportarCtesXAgente", "Proceso Terminado ")
                    mFileEstream.Close()
                    mFileEstream = Nothing


                End If
            End If

        Catch ex As Exception

            mItem = New ClassMsgError(ex.Source, ex.Message)
            Me.ImportarBW.ReportProgress(100)

        End Try

        '        System.Windows.Forms.MessageBox.Show("Proceso de importación terminado")
        '    Catch ex As Exception
        '        System.Windows.Forms.MessageBox.Show(ex.Message)

        '    End Try

    End Sub

    'ImportaCtesXAgente
    Private Sub ImportaCtesXAgentePronostico()
        Try
            'hace la llamada asyncrona.
            Dim intRow As Long
            'mArrayError = New ArrayList





            If Not String.IsNullOrEmpty(mStrFileOrigen) Then
                'Abre el archivo de lectura


                Dim mFileEstream As System.IO.StreamReader
                mFileEstream = New System.IO.StreamReader(mStrFileOrigen)
                Dim mSeparador As String = My.Settings.SeparadorArchivos
                If mSeparador = "\t" Then mSeparador = Chr(9)

                If mFileEstream.EndOfStream = False Then
                    Dim mTran As SqlTransaction
                    Dim mCon As SqlConnection = DjpSap.Dac.mConexion()

                    mTran = mCon.BeginTransaction

                    If Iniciarchk.Checked Then
                        Try

                            'Dim mCmdInicializar As SqlClient.SqlCommand = New SqlClient.SqlCommand("PRONOSTICOS.ADD_PRODUCTOCLIENTE", mCon, mTran)
                            'mCmdInicializar.ExecuteNonQuery()
                            mItem = New ClassMsgError("Inicializando Tabla", "Incializando tabla")



                        Catch ex As Exception
                            mItem = New ClassMsgError(ex.Source, ex.Message)

                        End Try
                        Me.ImportarBW.ReportProgress(1)


                    End If

                    Dim mCmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("PRONOSTICOS.ADD_PRODUCTOCLIENTE", mCon, mTran)
                    Using mCmd



                        mCmd.CommandType = CommandType.StoredProcedure
                        Dim mIdPronostico = New SqlClient.SqlParameter()
                        mIdPronostico.ParameterName = "@IDPRONOSTICO"
                        mCmd.Parameters.Add(mIdPronostico)


                        Dim mParCentro = New SqlClient.SqlParameter()
                        mParCentro.ParameterName = "@CLAVECENTRO"
                        mCmd.Parameters.Add(mParCentro)

                        Dim mParProducto = New SqlClient.SqlParameter()
                        mParProducto.ParameterName = "@CLAVEPRODUCTO"
                        mCmd.Parameters.Add(mParProducto)

                        Dim mParSociedad = New SqlClient.SqlParameter()
                        mParSociedad.ParameterName = "@CLAVESOCIEDAD"
                        mCmd.Parameters.Add(mParSociedad)


                        Dim mParCliente = New SqlClient.SqlParameter()
                        mParCliente.ParameterName = "@CLAVECLIENTE"
                        mCmd.Parameters.Add(mParCliente)


                        Dim mParAgente = New SqlClient.SqlParameter()
                        mParAgente.ParameterName = "@AGENTE"

                        mCmd.Parameters.Add(mParAgente)



                        

                        


                        
                        
                        'mCmd.Connection = DjpSap.Dac.mConexion()



                        mItem = New ClassMsgError("IO", "Procesando...")
                        Me.ImportarBW.ReportProgress(1)

                        'mArrayError.Add(New ClassMsgError("ImportarCtesXAgente", "Iniciando Proceso ...."))
                        intRow = 0
                        While mFileEstream.EndOfStream = False And Not (mTran.Connection Is Nothing)

                            intRow += 1

                            'La transaccion está abierta por lo tanto continua con el proceso
                            Dim mArrCampos As String() = mFileEstream.ReadLine().Split(mSeparador)
                            If IsNumeric(mArrCampos(enColImportarFileAddProducto.enCentro).Replace(Chr(34), String.Empty)) Then

                                mParAgente.Value = Trim(mArrCampos(enColImportarFileAddProducto.enAgente).Replace(Chr(34), String.Empty))
                                mParCliente.Value = Trim(mArrCampos(enColImportarFileAddProducto.enCliente).Replace(Chr(34), String.Empty))
                                mParSociedad.Value = Trim(mArrCampos(enColImportarFileAddProducto.enSociedad).Replace(Chr(34), String.Empty))

                                'Busca la relacion sociedad centro
                                mParProducto.Value = Trim(mArrCampos(enColImportarFileAddProducto.enProducto).Replace(Chr(34), String.Empty))
                                mParCentro.Value = Trim(mArrCampos(enColImportarFileAddProducto.enCentro).Replace(Chr(34), String.Empty))
                                If Long.TryParse(Trim(mArrCampos(enColImportarFileAddProducto.enPronostico).Replace(Chr(34), String.Empty)), mIdPronostico.Value) Then


                                    'mIdPronostico.Value = Trim(mArrCampos(enColImportarFileAddProducto.enPronostico).Replace(Chr(34), String.Empty))
                                    'Envia la ejecucion del query los datos son validados.

                                    Try
                                        mCmd.ExecuteNonQuery()
                                        If Not Me.RegistrosChk.Checked Then
                                            mItem = New ClassMsgError("EntradaOk", "Row:" & intRow & Chr(9) & "Agente:" & mParAgente.Value & Chr(9) & " Cliente:" & mParCliente.Value & Chr(9) & " Producto:" & mParProducto.Value & Chr(9) & " Centro:" & Chr(9) & mParCentro.Value & Chr(9) & " Agregado Correctamente")
                                        Else
                                            mItem = Nothing
                                        End If

                                    Catch SqlEx As SqlException
                                        Select Case SqlEx.Number
                                            Case 16
                                                mItem = New ClassMsgError("EntradaErronea", "Row:" & Chr(9) & intRow & Chr(9) & SqlEx.Message)
                                            Case Else
                                                mItem = New ClassMsgError("EntradaErronea", "Row:" & Chr(9) & intRow & Chr(9) & SqlEx.Message)
                                        End Select


                                    Catch ex As Exception

                                        mItem = New ClassMsgError("EntradaErronea", "Row:" & Chr(9) & intRow & Chr(9) & ex.Message)


                                    End Try
                                Else
                                    mItem = New ClassMsgError("EntradaErronea", "Row:" & Chr(9) & intRow & Chr(9) & "El numero de pronostico es invalido")
                                End If
                                Me.ImportarBW.ReportProgress((intRow Mod 10) * 10)
                            End If





                        End While
                        If mTran.Connection Is Nothing Then


                            'Se ha perdido la transaccion por lo tanto el proceso debe detenerse para garantizar una sola operacion
                            mItem = New ClassMsgError("EntradaErronea", "Row:" & Chr(9) & intRow & Chr(9) & "La transaccion no puede ser garantizada el proceso queda detenido")
                        Else
                            If Me.SimularChk.Checked Then
                                mTran.Rollback()
                            Else
                                mItem = New ClassMsgError("EntradaErronea", "Row:" & Chr(9) & intRow & Chr(9) & "Confirmando operaciones ...")
                                mTran.Commit()
                            End If
                        End If


                


                mCmd = Nothing
                mCon.Close()

                    End Using
                mItem = New ClassMsgError("ImportarCtesXAgente", "Proceso Terminado ")
                mFileEstream.Close()
                mFileEstream = Nothing


            End If
            End If

        Catch ex As Exception

            mItem = New ClassMsgError(ex.Source, ex.Message)
            Me.ImportarBW.ReportProgress(100)

        End Try

        '        System.Windows.Forms.MessageBox.Show("Proceso de importación terminado")
        '    Catch ex As Exception
        '        System.Windows.Forms.MessageBox.Show(ex.Message)

        '    End Try

    End Sub
    ''' <summary>
    ''' Importa  el pronostico desde un archivo de texto.
    ''' </summary>
    ''' <remarks>El pronostico no debe existir antes de continuar.</remarks>
    Private Sub ImportaPronosticos()
        Dim mFileEstream As System.IO.StreamReader = Nothing
        Dim mBolTransaccionAbierta As Boolean = False
        Dim mTran As SqlTransaction = Nothing
        Dim mBolPorcAvance As Integer = 0

        Try
            'hace la llamada asyncrona.
            If Not String.IsNullOrEmpty(mStrFileOrigen) Then
                'Abre el archivo de lectura

                mItem = New ClassMsgError(Me.Name, "Iniciando proceso ...")

                mBolPorcAvance += 10
                Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)


                mFileEstream = New System.IO.StreamReader(mStrFileOrigen)
                Dim mSeparador As String = My.Settings.SeparadorArchivos
                If mSeparador = "\t" Then mSeparador = Chr(9)

                If mFileEstream.EndOfStream = False Then
                    'Valida la integridad del archivo:
                    'Verifica 


                    Dim mCon As SqlConnection = DjpSap.Dac.mConexion()
                    mBolPorcAvance += 10
                    Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                    mTran = mCon.BeginTransaction
                    mBolTransaccionAbierta = True
                    If Iniciarchk.Checked Then
                        Try
                            'Debe Determinar si crear un escenario nuevo.

                            'Dim mCmdInicializar As SqlClient.SqlCommand = New SqlClient.SqlCommand("CATALOGOS.INICIALIZA_AGENTECLIENTE", mCon, mTran)
                            'mCmdInicializar.ExecuteNonQuery()
                            mItem = New ClassMsgError("Inicializando Tabla", "Incializando tabla")
                            mBolPorcAvance += 10
                            Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)


                        Catch ex As Exception
                            mItem = New ClassMsgError(ex.Source, ex.Message)

                        End Try
                        mBolPorcAvance += 10
                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                    End If
                    'Determina si debe crear un escenario nuevo y le asigna folio.
                    Dim mArrHdrs() As String

                    Dim mArrCampos As String() = Nothing
                    Dim mBolValidaArchivo As Boolean = False
                    Dim mlngFolioEscenario As Long
                    Dim mEsNuevo As Boolean
                    Dim mPeriodoIni As Date
                    Dim mPeriodoFin As Date
                    Dim mArrFechas() As Date = Nothing
                    Dim mStrCveAgente As String = Nothing
                    Dim mstrTipoPeriodo As String = Nothing
                    Dim mstrDescPronostico As String = Nothing
                    Dim intLineas As Integer
                    Dim mBolEOf As Boolean

                    mArrHdrs = mFileEstream.ReadLine().Split(mSeparador)
                    intLineas = 1

                    While mFileEstream.EndOfStream = False
                        mBolEOf = False
                        Select Case intLineas
                            Case 1

                                mBolValidaArchivo = True
                                If UBound(mArrHdrs) < enDefPronosticoHdr.EnDescripcion Then
                                    mBolValidaArchivo = False
                                    mItem = New ClassMsgError("Formato de Archivo:", "Linea 1 Invalida:Debe tener el formato:Escenario:[X] Nuevo:	S/N	Periodo	[FechaInicial]	[FechaFinal]	CVEAGENTE	[CLAVE AGENTE]	TIPOPERIODO:	W/M Descripcion:	[DESCRIPCION]")
                                    mBolPorcAvance += 10
                                    Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                End If

                                If mBolValidaArchivo Then
                                    'Continua validando el contenido del archivo.
                                    If Not Long.TryParse(mArrHdrs(enDefPronosticoHdr.enFolioEscenario), mlngFolioEscenario) Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda B1 Invalida:El numero de escenario es invalido")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                                    End If

                                    If InStr("SN", UCase(mArrHdrs(enDefPronosticoHdr.enEsNuevo)), CompareMethod.Text) = 0 Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda D1 Invalida:Debe indicar sí generará un escenario nuevo S/N")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    Else
                                        mEsNuevo = String.Compare(UCase(mArrHdrs(enDefPronosticoHdr.enEsNuevo)), "S") = 0
                                    End If

                                    If Not Date.TryParse(mArrHdrs(enDefPronosticoHdr.EnPeriodoIni), mPeriodoIni) Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda F1 Invalida:La fecha inicial no tiene formato valido")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    End If
                                    If Not Date.TryParse(mArrHdrs(enDefPronosticoHdr.EnPeriodoFin), mPeriodoFin) Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda G1 Invalida:La fecha final no tiene formato valido")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    End If

                                    If mPeriodoIni > mPeriodoIni Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda G1 Invalida:La fecha inicial debe ser menor a la final")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    End If

                                    If String.IsNullOrEmpty(mArrHdrs(enDefPronosticoHdr.enCveAgente)) Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda I1 Invalida:Debe Indicar una clave de agente")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    Else
                                        mStrCveAgente = mArrHdrs(enDefPronosticoHdr.enCveAgente)
                                    End If

                                    If InStr("WM", UCase(mArrHdrs(enDefPronosticoHdr.EnTipoPeriodo)), CompareMethod.Text) = 0 Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda K1 Invalida:Debe Indicar si el periodo es semanala o mensual (W/M)")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    Else
                                        mstrTipoPeriodo = mArrHdrs(enDefPronosticoHdr.EnTipoPeriodo)

                                    End If
                                    mstrDescPronostico = mArrHdrs(enDefPronosticoHdr.EnDescripcion)
                                End If

                            Case 2
                                ''*******************************
                                'Valida la segunda linea del archivo
                                '*********************************
                                If mBolValidaArchivo Then


                                    If mArrCampos(enDefPronosticoLinea2.enCentro) <> "CENTRO" Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Linea 2 COL:A DEBE TENER LA LEYENDA CENTRO")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                                    End If
                                    If mArrCampos(enDefPronosticoLinea2.enCliente) <> "CLIENTE" Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Linea 2 COL:B DEBE TENER LA LEYENDA CLIENTE")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    End If
                                    If mArrCampos(enDefPronosticoLinea2.enProducto) <> "PRODUCTO" Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Linea 2 COL:C DEBE TENER LA LEYENDA PRODUCTO")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    End If
                                    If mArrCampos(enDefPronosticoLinea2.enSociedad).Equals("SOCIEDAD") = False Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Linea 2 COL:D DEBE TENER LA LEYENDA SOCIEDAD")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    End If

                                    ReDim mArrFechas(0 To UBound(mArrCampos) - enDefPronosticoLinea2.enFechaIni)


                                    For mInCol = enDefPronosticoLinea2.enFechaIni To UBound(mArrCampos)
                                        If Not String.IsNullOrEmpty(mArrCampos(mInCol)) Then

                                            If Not Date.TryParse(mArrCampos(mInCol), mArrFechas(mInCol - enDefPronosticoLinea2.enFechaIni)) Then
                                                mBolValidaArchivo = False
                                                mItem = New ClassMsgError("Formato de Archivo:", "Linea 2 COL:" & mInCol & ".-" & mArrCampos(mInCol) & " no es una fecha valida")
                                                mBolPorcAvance += 10
                                                Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                            End If
                                        Else
                                            ReDim Preserve mArrFechas(0 To mInCol - enDefPronosticoLinea2.enFechaIni - 1)
                                            Exit For

                                        End If

                                    Next
                                End If




                                'Valida el resto del archivo
                                If mBolValidaArchivo Then
                                    'Genera el escenario

                                    If mEsNuevo Then
                                        'Indica en el archivo de texto que debe generarse un escenario nuevo.
                                        Using mCmdPronosticosHdr As New SqlClient.SqlCommand("PRONOSTICOS.CREA_PRONOSTICOS", mCon, mTran)

                                            With mCmdPronosticosHdr
                                                .CommandType = CommandType.StoredProcedure
                                                .Parameters.AddWithValue("@IDPRONOSTICO", mlngFolioEscenario)
                                                .Parameters.AddWithValue("@CLAVEAGENTE", mStrCveAgente)
                                                .Parameters.AddWithValue("@SMDINICIO", mPeriodoIni)
                                                .Parameters.AddWithValue("@SMDFIN", mPeriodoFin)
                                                .Parameters.AddWithValue("@TIPOPERIODO", mstrTipoPeriodo)
                                                .Parameters.AddWithValue("@DESCPRONOSTICO", mstrDescPronostico)

                                                Try

                                                    .ExecuteNonQuery()
                                                    If Not Me.RegistrosChk.Checked Then
                                                        mItem = New ClassMsgError(Me.Name, "Se ha creado el escenario: " & mlngFolioEscenario & " Exitosamente ...")
                                                        mBolPorcAvance += 10
                                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                    End If

                                                Catch ex As Exception

                                                    mItem = New ClassMsgError(ex.Source, ex.Message)
                                                    mBolValidaArchivo = False 'La ejecucion anterior fallo
                                                    mBolPorcAvance += 10
                                                    Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                End Try


                                            End With
                                        End Using

                                    End If

                                End If


                            Case Else
                                '*******************************************
                                'Actualiza las nuevas lineas
                                '*******************************************
                                If mBolValidaArchivo Then
                                    Dim mProd As ClassProducto = New ClassProducto
                                    Dim mDblUnidadAlterna As Double
                                    Dim mUnidadBase As Double

                                    Using mCmdLineas As SqlClient.SqlCommand = New SqlClient.SqlCommand("PRONOSTICOS.ACTUALIZALINEA_PRONOSTICO", mCon, mTran)
                                        With mCmdLineas
                                            .CommandType = CommandType.StoredProcedure

                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@IDPRONOSTICO", SqlDbType.Int))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@CENTRO", SqlDbType.Char, 4))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@CVEPRODUCTO", SqlDbType.Int))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@FECHAPERIODO", SqlDbType.Date))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE", SqlDbType.Int))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@CANTIDADBASE", SqlDbType.Decimal))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@CANTIDADALTERNA", SqlDbType.Decimal))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@SOCIEDAD", SqlDbType.Char, 4))


                                            While mBolEOf = False
                                                mBolEOf = mFileEstream.EndOfStream
                                                For intPeriodos = LBound(mArrFechas) To UBound(mArrFechas)
                                                    .Parameters("@IDPRONOSTICO").Value = mlngFolioEscenario
                                                    .Parameters("@CENTRO").Value = mArrCampos(enDefPronosticoLinea2.enCentro)
                                                    .Parameters("@CVEPRODUCTO").Value = mArrCampos(enDefPronosticoLinea2.enProducto)
                                                    .Parameters("@FECHAPERIODO").Value = mArrFechas(intPeriodos) 'mArrCampos(enDefPronosticoLinea2.enProducto)
                                                    If String.IsNullOrEmpty(mArrCampos(enDefPronosticoLinea2.enCliente)) Then
                                                        .Parameters("@SOCIEDAD").Value = DBNull.Value
                                                    Else
                                                        .Parameters("@SOCIEDAD").Value = mArrCampos(enDefPronosticoLinea2.enSociedad)
                                                    End If

                                                    If String.IsNullOrEmpty(mArrCampos(enDefPronosticoLinea2.enSociedad)) Then
                                                        .Parameters("@CLIENTE").Value = DBNull.Value
                                                    Else
                                                        .Parameters("@CLIENTE").Value = mArrCampos(enDefPronosticoLinea2.enCliente)
                                                    End If

                                                    mProd.Clave = mArrCampos(enDefPronosticoLinea2.enProducto)

                                                    If mProd.BuscarEquivalenciaCatalogo() Then
                                                        'Se han encontrado equivalencias 
                                                        Dim mstrTmpUB = mArrCampos(intPeriodos + enDefPronosticoLinea2.enFechaIni)
                                                        'Toma las celdas que viene en formato numerico.
                                                        '
                                                        mstrTmpUB = Replace(Replace(mstrTmpUB, ",", String.Empty), Chr(34), String.Empty)



                                                        If Double.TryParse(mstrTmpUB, mUnidadBase) = False AndAlso String.IsNullOrEmpty(mstrTmpUB) = False Then
                                                            'El campo no es numerico
                                                            mItem = New ClassMsgError("Unidades de medida:", "Linea " & intLineas & " Se esperaba una valor numerico como cantidad pronosticada; valor actual:" & mArrCampos(intPeriodos + enDefPronosticoLinea2.enFechaIni))
                                                            'mUnidadBase = mProd.Equivalencia(mProd.UnidadBase, mDblUnidadAlterna)
                                                            mUnidadBase = 0
                                                            mDblUnidadAlterna = 0

                                                            mBolPorcAvance += 10
                                                            Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                        Else

                                                            mDblUnidadAlterna = mProd.Equivalencia(mProd.UnidadAlterna, mUnidadBase)
                                                            If mProd.HayErrorRedondeo Then
                                                                Dim mErrorRedondeo As System.Text.StringBuilder = New System.Text.StringBuilder("Linea " & intLineas & " Producto:" & mProd.Clave & " Redondeando " & mUnidadBase & " " & mProd.UnidadBase & " a " & mProd.UnidadAlterna)

                                                                mErrorRedondeo.Append("Equivalencia: 1" & mProd.UnidadAlterna & "=" & mProd.Equivalencia(mProd.UnidadBase, 1) & mProd.UnidadBase)



                                                                mItem = New ClassMsgError("Unidades de medida:", mErrorRedondeo.ToString())
                                                                mUnidadBase = mProd.Equivalencia(mProd.UnidadBase, mDblUnidadAlterna)
                                                                mBolPorcAvance += 10
                                                                Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                                                            End If

                                                            .Parameters("@CANTIDADBASE").Value = mUnidadBase
                                                            .Parameters("@CANTIDADALTERNA").Value = mDblUnidadAlterna
                                                            Try
                                                                Dim intRowsAfectados As Integer
                                                                intRowsAfectados = .ExecuteNonQuery()
                                                                Select Case intRowsAfectados
                                                                    Case 1

                                                                        mItem = New ClassMsgError("ProcesadoOk", "Se registro la linea:" & intLineas & " Producto:" & mProd.Clave & " Periodo:" & String.Format("{0:dd-MMM-yyyy}", mArrFechas(intPeriodos)))

                                                                    Case 0
                                                                        mItem = New ClassMsgError("Proceso Fallido", "No se encontro registro en la linea:" & intLineas & " Producto:" & mProd.Clave & " Periodo:" & String.Format("{0:dd-MMM-yyyy}", mArrFechas(intPeriodos)))
                                                                    Case Else
                                                                        mItem = New ClassMsgError("Proceso Fallido", "Se encontro mas de un registro a actualizar en la linea:" & intLineas & " Producto:" & mProd.Clave & " Periodo:" & String.Format("{0:dd-MMM-yyyy}", mArrFechas(intPeriodos)))
                                                                End Select
                                                                'Muestra solo los registros erroneos
                                                                If Me.RegistrosChk.Checked Then
                                                                    If intRowsAfectados <> 1 Then
                                                                        mBolPorcAvance += 10
                                                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                                    Else
                                                                        mItem = Nothing

                                                                        mBolPorcAvance += 10
                                                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                                    End If
                                                                Else
                                                                    mBolPorcAvance += 10
                                                                    Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                                End If

                                                            Catch ex As Exception
                                                                'mBolValidaArchivo = False
                                                                mItem = New ClassMsgError(ex.Source, ex.Message)
                                                                mBolPorcAvance += 10
                                                                Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                                                            End Try

                                                        End If


                                                        'mUnidadBase = mArrCampos(intPeriodos + enDefPronosticoLinea2.enFechaIni)

                                                    Else
                                                        mItem = New ClassMsgError("Alerta Unidades de medida", "Linea " & intLineas & " Producto:" & mProd.Clave & " El producto no tiene unidades de medida valida")
                                                        'mUnidadBase()

                                                        mDblUnidadAlterna = mProd.Equivalencia(mProd.UnidadBase, mUnidadBase)

                                                        mBolPorcAvance += 10
                                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                    End If

                                                Next
                                                If mBolEOf = False Then
                                                    'Mientras no llege al fin del archivo continua 
                                                    mArrCampos = mFileEstream.ReadLine().Split(mSeparador)
                                                End If

                                                intLineas += 1


                                            End While

                                            'llega al fin del archivo.


                                        End With
                                    End Using
                                End If

                        End Select

                        If mBolEOf = False Then


                            mArrCampos = mFileEstream.ReadLine().Split(mSeparador)
                            intLineas += 1

                        End If
                    End While

                    If Not Me.SimularChk.Checked Then
                        mTran.Commit()
                        mItem = New ClassMsgError("Base de datos", "Confirmando Operaciones")
                        mBolPorcAvance += 10
                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                    Else
                        mTran.Rollback()
                    End If


                End If
                mItem = New ClassMsgError("ImportarPronosticos", "Proceso Terminado ")
                mBolPorcAvance += 10
                Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                mFileEstream.Close()
                mFileEstream = Nothing

            End If


        Catch ex As Exception

            mItem = New ClassMsgError(ex.Source, ex.Message)

            mBolPorcAvance += 10
            Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

            If Not IsNothing(mFileEstream) Then mFileEstream.Close()
            If mBolTransaccionAbierta = True Then
                mTran.Rollback()
            End If
        Finally


        End Try

        '        System.Windows.Forms.MessageBox.Show("Proceso de importación terminado")
        '    Catch ex As Exception
        '        System.Windows.Forms.MessageBox.Show(ex.Message)

        '    End Try

    End Sub
    ''' <summary>
    ''' Importa  el plan anual de ventas 
    ''' </summary>
    ''' <remarks>El plan no debe existir antes de continuar.</remarks>
    Private Sub ImportaPlan()
        Dim mFileEstream As System.IO.StreamReader = Nothing
        Dim mBolTransaccionAbierta As Boolean = False
        Dim mTran As SqlTransaction = Nothing
        Dim mBolPorcAvance As Integer = 0
        Dim mCon As SqlConnection
        Try
            'hace la llamada asyncrona.



            'mArrayError = New ArrayList





            If Not String.IsNullOrEmpty(mStrFileOrigen) Then
                'Abre el archivo de lectura

                mItem = New ClassMsgError(Me.Name, "Iniciando proceso ...")

                mBolPorcAvance += 10
                Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)


                mFileEstream = New System.IO.StreamReader(mStrFileOrigen)
                Dim mSeparador As String = My.Settings.SeparadorArchivos
                If mSeparador = "\t" Then mSeparador = Chr(9)

                If mFileEstream.EndOfStream = False Then
                    'Valida la integridad del archivo:
                    'Verifica 


                    mCon = DjpSap.Dac.mConexion()
                    mBolPorcAvance += 10
                    Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                    mTran = mCon.BeginTransaction
                    mBolTransaccionAbierta = True
                    If Iniciarchk.Checked Then
                        Try
                            'Debe Determinar si crear un escenario nuevo.

                            'Dim mCmdInicializar As SqlClient.SqlCommand = New SqlClient.SqlCommand("CATALOGOS.INICIALIZA_AGENTECLIENTE", mCon, mTran)
                            'mCmdInicializar.ExecuteNonQuery()
                            mItem = New ClassMsgError("Inicializando Tabla", "Incializando tabla")
                            mBolPorcAvance += 10
                            Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)


                        Catch ex As Exception
                            mItem = New ClassMsgError(ex.Source, ex.Message)

                        End Try
                        mBolPorcAvance += 10
                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                    End If
                    'Determina si debe crear un escenario nuevo y le asigna folio.
                    Dim mArrHdrs() As String

                    Dim mArrCampos As String() = Nothing
                    Dim mBolValidaArchivo As Boolean = False
                    Dim mlngFolioEscenario As Long
                    Dim mEsNuevo As Boolean
                    Dim mPeriodoIni As Date
                    Dim mPeriodoFin As Date
                    Dim mArrFechas() As Date = Nothing
                    Dim mStrCveAgente As String = Nothing
                    Dim mstrTipoPeriodo As String = Nothing

                    Dim mstrDescPronostico As String = Nothing

                    Dim intLineas As Integer
                    Dim mBolEOf As Boolean

                    mArrHdrs = mFileEstream.ReadLine().Split(mSeparador)
                    intLineas = 1

                    While mFileEstream.EndOfStream = False
                        mBolEOf = False
                        Select Case intLineas
                            Case 1

                                mBolValidaArchivo = True
                                If UBound(mArrHdrs) < enDefPronosticoHdr.EnDescripcion Then
                                    mBolValidaArchivo = False
                                    mItem = New ClassMsgError("Formato de Archivo:", "Linea 1 Invalida:Debe tener el formato:Escenario:[X] Nuevo:	S/N	Periodo	[FechaInicial]	[FechaFinal]	CVEAGENTE	[CLAVE AGENTE]	TIPOPERIODO:	W/M Descripcion:	[DESCRIPCION]")
                                    mBolPorcAvance += 10
                                    Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                End If

                                If mBolValidaArchivo Then
                                    'Continua validando el contenido del archivo.
                                    If Not Long.TryParse(mArrHdrs(enDefPronosticoHdr.enFolioEscenario), mlngFolioEscenario) Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda B1 Invalida:El numero de escenario es invalido")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                                    End If

                                    If InStr("SN", UCase(mArrHdrs(enDefPronosticoHdr.enEsNuevo)), CompareMethod.Text) = 0 Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda D1 Invalida:Debe indicar sí generará un escenario nuevo S/N")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    Else
                                        mEsNuevo = String.Compare(UCase(mArrHdrs(enDefPronosticoHdr.enEsNuevo)), "S") = 0
                                    End If

                                    If Not Date.TryParse(mArrHdrs(enDefPronosticoHdr.EnPeriodoIni), mPeriodoIni) Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda F1 Invalida:La fecha inicial no tiene formato valido")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    End If
                                    If Not Date.TryParse(mArrHdrs(enDefPronosticoHdr.EnPeriodoFin), mPeriodoFin) Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda G1 Invalida:La fecha final no tiene formato valido")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    End If

                                    If mPeriodoIni > mPeriodoIni Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda G1 Invalida:La fecha inicial debe ser menor a la final")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    End If

                                    If String.IsNullOrEmpty(mArrHdrs(enDefPronosticoHdr.enCveAgente)) Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda I1 Invalida:Debe Indicar una clave de agente")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    Else
                                        mStrCveAgente = mArrHdrs(enDefPronosticoHdr.enCveAgente)
                                    End If

                                    If InStr("WM", UCase(mArrHdrs(enDefPronosticoHdr.EnTipoPeriodo)), CompareMethod.Text) = 0 Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Celda K1 Invalida:Debe Indicar si el periodo es semanala o mensual (W/M)")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    Else
                                        mstrTipoPeriodo = mArrHdrs(enDefPronosticoHdr.EnTipoPeriodo)

                                    End If
                                    mstrDescPronostico = mArrHdrs(enDefPronosticoHdr.EnDescripcion)
                                End If

                            Case 2
                                ''*******************************
                                'Valida la segunda linea del archivo
                                '*********************************
                                If mBolValidaArchivo Then


                                    If mArrCampos(enDefPronosticoLinea2.enCentro) <> "CENTRO" Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Linea 2 COL:A DEBE TENER LA LEYENDA CENTRO")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                                    End If
                                    If mArrCampos(enDefPronosticoLinea2.enCliente) <> "CLIENTE" Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Linea 2 COL:B DEBE TENER LA LEYENDA CLIENTE")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    End If
                                    If mArrCampos(enDefPronosticoLinea2.enProducto) <> "PRODUCTO" Then
                                        mBolValidaArchivo = False
                                        mItem = New ClassMsgError("Formato de Archivo:", "Linea 2 COL:C DEBE TENER LA LEYENDA PRODUCTO")
                                        mBolPorcAvance += 10
                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                    End If

                                    ReDim mArrFechas(0 To UBound(mArrCampos) - enDefPronosticoLinea2.enFechaIni)


                                    For mInCol = enDefPronosticoLinea2.enFechaIni To UBound(mArrCampos)
                                        If Not String.IsNullOrEmpty(mArrCampos(mInCol)) Then

                                            If Not Date.TryParse(mArrCampos(mInCol), mArrFechas(mInCol - enDefPronosticoLinea2.enFechaIni)) Then
                                                mBolValidaArchivo = False
                                                mItem = New ClassMsgError("Formato de Archivo:", "Linea 2 COL:" & mInCol & ".-" & mArrCampos(mInCol) & " no es una fecha valida")
                                                mBolPorcAvance += 10
                                                Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                            End If
                                        Else
                                            ReDim Preserve mArrFechas(0 To mInCol - enDefPronosticoLinea2.enFechaIni - 1)
                                            Exit For

                                        End If

                                    Next
                                End If




                                'Valida el resto del archivo
                                If mBolValidaArchivo Then
                                    'Genera el escenario

                                    If mEsNuevo Then
                                        'Indica en el archivo de texto que debe generarse un escenario nuevo.
                                        Using mCmdPronosticosHdr As New SqlClient.SqlCommand("PRESUPUESTO.CREA_PRESUPUESTO", mCon, mTran)

                                            With mCmdPronosticosHdr
                                                .CommandType = CommandType.StoredProcedure
                                                .Parameters.AddWithValue("@IDPRESUPUESTO", mlngFolioEscenario)
                                                .Parameters.AddWithValue("@CLAVEAGENTE", mStrCveAgente)
                                                .Parameters.AddWithValue("@SMDINICIO", mPeriodoIni)
                                                .Parameters.AddWithValue("@SMDFIN", mPeriodoFin)
                                                .Parameters.AddWithValue("@TIPOPERIODO", mstrTipoPeriodo)
                                                .Parameters.AddWithValue("@DESCPRONOSTICO", mstrDescPronostico)

                                                Try

                                                    .ExecuteNonQuery()
                                                    If Not Me.RegistrosChk.Checked Then
                                                        mItem = New ClassMsgError(Me.Name, "Se ha creado el escenario: " & mlngFolioEscenario & " Exitosamente ...")
                                                        mBolPorcAvance += 10
                                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                    End If

                                                Catch ex As Exception

                                                    mItem = New ClassMsgError(ex.Source, ex.Message)
                                                    mBolValidaArchivo = False 'La ejecucion anterior fallo
                                                    mBolPorcAvance += 10
                                                    Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                End Try


                                            End With
                                        End Using

                                    End If

                                End If


                            Case Else
                                '*******************************************
                                'Actualiza las nuevas lineas
                                '*******************************************
                                If mBolValidaArchivo Then
                                    Dim mProd As ClassProducto = New ClassProducto
                                    Dim mDblUnidadAlterna As Double
                                    Dim mUnidadBase As Double

                                    Using mCmdLineas As SqlClient.SqlCommand = New SqlClient.SqlCommand("PRESUPUESTO.ACTUALIZALINEA", mCon, mTran)
                                        With mCmdLineas
                                            .CommandType = CommandType.StoredProcedure

                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@IDPRESUPUESTO", SqlDbType.Int))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@CENTRO", SqlDbType.Char, 4))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@CVEPRODUCTO", SqlDbType.Int))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@FECHAPERIODO", SqlDbType.Date))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE", SqlDbType.Int))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@CANTIDADBASE", SqlDbType.Decimal))
                                            .Parameters.Add(New System.Data.SqlClient.SqlParameter("@CANTIDADALTERNA", SqlDbType.Decimal))
                                            While mFileEstream.EndOfStream = False
                                                For intPeriodos = LBound(mArrFechas) To UBound(mArrFechas)
                                                    .Parameters("@IDPRESUPUESTO").Value = mlngFolioEscenario
                                                    .Parameters("@CENTRO").Value = mArrCampos(enDefPronosticoLinea2.enCentro)
                                                    .Parameters("@CVEPRODUCTO").Value = mArrCampos(enDefPronosticoLinea2.enProducto)
                                                    .Parameters("@FECHAPERIODO").Value = mArrFechas(intPeriodos) 'mArrCampos(enDefPronosticoLinea2.enProducto)
                                                    If String.IsNullOrEmpty(mArrCampos(enDefPronosticoLinea2.enCliente)) Then
                                                        .Parameters("@CLIENTE").Value = DBNull.Value
                                                    Else
                                                        .Parameters("@CLIENTE").Value = mArrCampos(enDefPronosticoLinea2.enCliente)
                                                    End If


                                                    mProd.Clave = mArrCampos(enDefPronosticoLinea2.enProducto)
                                                    If mProd.BuscarEquivalenciaCatalogo() Then
                                                        'Se han encontrado equivalencias 
                                                        Dim mstrTmpUB = mArrCampos(intPeriodos + enDefPronosticoLinea2.enFechaIni)
                                                        'Toma las celdas que viene en formato numerico.
                                                        '
                                                        mstrTmpUB = Replace(Replace(mstrTmpUB, ",", String.Empty), Chr(34), String.Empty)



                                                        If Double.TryParse(mstrTmpUB, mUnidadBase) = False AndAlso String.IsNullOrEmpty(mstrTmpUB) = False Then
                                                            'El campo no es numerico
                                                            mItem = New ClassMsgError("Unidades de medida:", "Linea " & intLineas & " Se esperaba una valor numero como cantidad pronosticada; valor actual:" & mArrCampos(intPeriodos + enDefPronosticoLinea2.enFechaIni))
                                                            'mUnidadBase = mProd.Equivalencia(mProd.UnidadBase, mDblUnidadAlterna)
                                                            mUnidadBase = 0
                                                            mDblUnidadAlterna = 0

                                                            mBolPorcAvance += 10
                                                            Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                        Else

                                                            mDblUnidadAlterna = mProd.Equivalencia(mProd.UnidadAlterna, mUnidadBase)
                                                            If mProd.HayErrorRedondeo Then
                                                                Dim mErrorRedondeo As System.Text.StringBuilder = New System.Text.StringBuilder("Linea " & intLineas & " Producto:" & mProd.Clave & " Redondeando " & mUnidadBase & " " & mProd.UnidadBase & " a " & mProd.UnidadAlterna)

                                                                mErrorRedondeo.Append("Equivalencia: 1" & mProd.UnidadAlterna & "=" & mProd.Equivalencia(mProd.UnidadBase, 1) & mProd.UnidadBase)



                                                                mItem = New ClassMsgError("Unidades de medida:", mErrorRedondeo.ToString())
                                                                mUnidadBase = mProd.Equivalencia(mProd.UnidadBase, mDblUnidadAlterna)
                                                                mBolPorcAvance += 10
                                                                Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                                                            End If

                                                            .Parameters("@CANTIDADBASE").Value = mUnidadBase
                                                            .Parameters("@CANTIDADALTERNA").Value = mDblUnidadAlterna
                                                            Try
                                                                Dim intRowsAfectados As Integer
                                                                intRowsAfectados = .ExecuteNonQuery()
                                                                Select Case intRowsAfectados
                                                                    Case 1

                                                                        mItem = New ClassMsgError("ProcesadoOk", "Se registro la linea:" & intLineas & " Producto:" & mProd.Clave & " Periodo:" & String.Format("{0:dd-MMM-yyyy}", mArrFechas(intPeriodos)))

                                                                    Case 0
                                                                        mItem = New ClassMsgError("Proceso Fallido", "No se encontro registro en la linea:" & intLineas & " Producto:" & mProd.Clave & " Periodo:" & String.Format("{0:dd-MMM-yyyy}", mArrFechas(intPeriodos)))
                                                                    Case Else
                                                                        mItem = New ClassMsgError("Proceso Fallido", "Se encontro mas de un registro a actualizar en la linea:" & intLineas & " Producto:" & mProd.Clave & " Periodo:" & String.Format("{0:dd-MMM-yyyy}", mArrFechas(intPeriodos)))
                                                                End Select
                                                                'Muestra solo los registros erroneos
                                                                If Me.RegistrosChk.Checked Then
                                                                    If intRowsAfectados <> 1 Then
                                                                        mBolPorcAvance += 10
                                                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                                    Else
                                                                        mItem = Nothing

                                                                        mBolPorcAvance += 10
                                                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                                    End If
                                                                Else
                                                                    mBolPorcAvance += 10
                                                                    Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                                End If

                                                            Catch ex As Exception
                                                                'mBolValidaArchivo = False
                                                                mItem = New ClassMsgError(ex.Source, ex.Message)
                                                                mBolPorcAvance += 10
                                                                Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

                                                            End Try

                                                        End If


                                                        'mUnidadBase = mArrCampos(intPeriodos + enDefPronosticoLinea2.enFechaIni)

                                                    Else
                                                        mItem = New ClassMsgError("Alerta Unidades de medida", "Linea " & intLineas & " Producto:" & mProd.Clave & " El producto no tiene unidades de medida valida")
                                                        'mUnidadBase()

                                                        mDblUnidadAlterna = mProd.Equivalencia(mProd.UnidadBase, mUnidadBase)

                                                        mBolPorcAvance += 10
                                                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                                                    End If

                                                Next
                                                mArrCampos = mFileEstream.ReadLine().Split(mSeparador)
                                                intLineas += 1


                                            End While
                                            mBolEOf = True 'llega al fin del archivo.


                                        End With
                                    End Using
                                End If

                        End Select
                        If mBolEOf = False Then


                            mArrCampos = mFileEstream.ReadLine().Split(mSeparador)
                            intLineas += 1

                        End If
                    End While

                    If Not Me.SimularChk.Checked Then
                        mTran.Commit()
                        mItem = New ClassMsgError("Base de datos", "Confirmando Operaciones")
                        mBolPorcAvance += 10
                        Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                    Else
                        mTran.Rollback()
                    End If


                End If
                mItem = New ClassMsgError("ImportarPronosticos", "Proceso Terminado ")
                mBolPorcAvance += 10
                Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)
                mFileEstream.Close()
                mFileEstream = Nothing

            End If


        Catch ex As Exception

            mItem = New ClassMsgError(ex.Source, ex.Message)

            mBolPorcAvance += 10
            Me.ImportarBW.ReportProgress(mBolPorcAvance Mod 100)

            If Not IsNothing(mFileEstream) Then mFileEstream.Close()
            If mBolTransaccionAbierta = True Then

                mTran.Rollback()
            End If
        Finally


        End Try

        '        System.Windows.Forms.MessageBox.Show("Proceso de importación terminado")
        '    Catch ex As Exception
        '        System.Windows.Forms.MessageBox.Show(ex.Message)

        '    End Try

    End Sub

    Private Sub ListBoxDataFill()
        'Me.LstErrores.DataSource = mArrayError
        'Me.LstErrores.DisplayMember = "Mensaje"
        'Me.Refresh()

        'Me.LstErrores.ValueMember = "Mensaje"'
    End Sub
    Private Sub ShowMessageError(ByVal pstrMensaje As String)
        Windows.Forms.MessageBox.Show(pstrMensaje, CTE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub
    Private Sub ShowMessageWarning(ByVal pstrMensaje As String)
        Windows.Forms.MessageBox.Show(pstrMensaje, CTE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub
#End Region

   



    ''' <summary>
    ''' Inicializa la colecion para llenar la lista de tablas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FrmImportar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
   

        Dim mDs As DataSet = New DataSet
        Dim mDa As DataTable = mDs.Tables.Add()
        Dim mColClave As New System.Data.DataColumn("CLAVE", System.Type.GetType("System.String"))
        Dim mColDescripion As New System.Data.DataColumn("DESCRIPCION", System.Type.GetType("System.String"))
        Dim mColHelpId As New System.Data.DataColumn("HelpId", System.Type.GetType("System.String"))

        mDa.Columns.Add(mColClave)
        mDa.Columns.Add(mColDescripion)
        mDa.Columns.Add(mColHelpId)
        Dim mPrimaryKey(0 To 0) As DataColumn
        mPrimaryKey(0) = mColClave
        mDa.PrimaryKey = mPrimaryKey






        Dim mRow As DataRow = mDa.NewRow()
        mRow("CLAVE") = "001"
        mRow("DESCRIPCION") = "Clientes asignados al agentes (SOLO INDUSTRIAL)"
        mRow("HelpId") = "10100"

        mDa.Rows.Add(mRow)
        mRow = mDa.NewRow
        mRow("CLAVE") = "002"
        mRow("DESCRIPCION") = "Pronosticos de Ventas"
        mRow("HelpId") = "10300"

        mDa.Rows.Add(mRow)

        mRow = mDa.NewRow
        mRow("CLAVE") = "003"
        mRow("DESCRIPCION") = "Plan anual de ventas"
        mRow("HelpId") = "10200"

        mDa.Rows.Add(mRow)

        mRow = mDa.NewRow
        mRow("CLAVE") = "004"
        mRow("DESCRIPCION") = "Agregar Productos y Clientes Nuevos a Pronostico Existente (SOLO INDUSTRIAL)"
        mRow("HelpId") = "10300"

        mDa.Rows.Add(mRow)

        TablaCbo.DataSource = mDa
        TablaCbo.DisplayMember = "DESCRIPCION"
        TablaCbo.ValueMember = "CLAVE"

        'Me.ImportarHlp.SetHelpString(TablaCbo, "Las tablas a importar en sigepro son las siguiente")



    End Sub


    Private Sub AyudaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripButton.Click

        'Dim mCurrFileHelp As String = Application.StartupPath

        'If Not mCurrFileHelp.EndsWith("\") Then
        '    mCurrFileHelp = Application.StartupPath & "\"
        'End If

        ''mCurrFileHelp = mCurrFileHelp & "PronosticosSAP.chm"
        'mCurrFileHelp = mCurrFileHelp & "PronosticosSap_Kal.chm"

        'If IO.File.Exists(mCurrFileHelp) Then
        '    Me.ImportarHlp.HelpNamespace = mCurrFileHelp

        'Else
        '    Me.ImportarHlp.HelpNamespace = Nothing
        'End If
        'Dim mNav As HelpNavigator = HelpNavigator.TopicId
        'Help.ShowHelp(Me, mCurrFileHelp, mNav, "1000")


        ShowHelpAppByTopicId(Me, "10000")








        'Help.ShowHelp(Me, mCurrFileHelp, HelpNavigator.TableOfContents)


        '   = Help.ShowHelp(TablaCbo, "Layout_pronosticos.html")


        'Dim converter As TypeConverter
        'converter = TypeDescriptor.GetConverter(GetType(HelpNavigator))

        'Dim value As Object
        'For Each value In converter.GetStandardValues()
        '    navigatorCombo.Items.Add(value)
        'Next value



        'mNav.KeywordIndex()
        'mNav.KeywordIndex 
        'Help.ShowHelp(Me, mCurrFileHelp, mNav, "Layout Clientes X Agentes")


    End Sub




    Private Sub CreateIndexHelp()
        'Dim converter As TypeConverter
        'converter = TypeDescriptor.GetConverter(GetType(HelpNavigator))

        'Dim value As Object
        'For Each value In converter.GetStandardValues()
        '    navigatorCombo.Items.Add(value)
        'Next value
    End Sub

    
    Private Sub TablaCbo_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles TablaCbo.HelpRequested
        If TablaCbo.SelectedIndex > -1 Then
            Dim mTa As DataTable = CType(TablaCbo.DataSource, DataTable)
            Dim mRowCurrent = mTa.Rows.Find(TablaCbo.SelectedValue)
            If IsNothing(mRowCurrent) = False Then
                ShowHelpAppByTopicId(Me, Trim(mRowCurrent("HelpId").ToString()))
            End If

        End If


    End Sub
End Class
