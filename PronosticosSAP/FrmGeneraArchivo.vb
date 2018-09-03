Imports System.ComponentModel
Imports System.Text

Public Class FrmGeneraArchivo
    Structure mCampos
        Dim Clave As String
        Dim Formato As String
        Dim NullValue As String

        Sub New(ByRef pClave As String, ByVal pFormato As String, ByVal pNullValue As String)
            Clave = pClave
            Formato = pFormato
            NullValue = pNullValue

        End Sub
    End Structure

    Dim mObjPronostico As ClassPronosticos
    Private pstrErrorWs As String
    Dim intPronostico As Long
    Dim mCurrentUser As DjpSap.ClassUser
    Dim mFechaInicio As Nullable(Of Date)
    Dim mFechaFin As Nullable(Of Date)
    Dim mBolEstadoEnvioWs As Boolean
    Dim mBolSalir As Boolean
    Const CTE_MSGOK As String = "Archivo enviado exitosamente."
    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        txtPronostico.Tag = String.Empty
        If Me.Validate Then

            If Validar() Then

                GuardarToolStripButton.Enabled = False

                mFechaInicio = FechaIniDtPicker.Value
                mFechaFin = Me.FechaFinDtPicker.Value

                mCurrentUser = CType(Me.MdiParent, MDIPronosticos).pUsuario

                Me.BGWKEnvios.RunWorkerAsync(intPronostico)
            Else
                txtPronostico.Focus()

            End If
        End If
    End Sub
    Private Function EnviarRemoto(ByVal pstrFilename As String, ByVal pArEntrada As String, ByVal pNegocioPronostico As String) As Boolean
        Dim mBolProceso As Boolean

        Try
            Me.BGWKEnvios.ReportProgress(70)

            Dim mObjEnviar As ClassCteWebservices = New ClassCteWebservices

            Me.BGWKEnvios.ReportProgress(80)

            mBolProceso = mObjEnviar.EnviarServer(pstrFilename, mCurrentUser, pArEntrada, pNegocioPronostico)

            If Not mBolProceso Then

                pstrErrorWs = mObjEnviar.myError


            End If

        Catch ex As Exception
            pstrErrorWs = ex.Message


        End Try
        Me.BGWKEnvios.ReportProgress(90)
        Return mBolProceso

    End Function

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Try
            'txtPronostico.Tag = "Consultar"
            'Me.Validate()

            Dim mFrm As FrmConsultaMaestroPronostico = New FrmConsultaMaestroPronostico
            With mFrm
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Me.txtPronostico.Text = .Pronostico.Id
                    Me.GuardarToolStripButton.Enabled = Me.Validar()
                    

                End If
                .Dispose()

            End With
            txtPronostico.Tag = String.Empty
        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try



    End Sub


    Private Sub BGWKEnvios_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGWKEnvios.DoWork
        'Proceso de envios 
        Try
            Dim mBw As BackgroundWorker = CType(sender, BackgroundWorker)

            EnviarAsync(e.Argument)
            If mBw.CancellationPending Then
                e.Cancel = True

            End If
        Catch ex As Exception
            ModComun.MsgError(ex.Message)


        End Try


    End Sub
    ''' <summary>
    ''' Hace el envio asincrono
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EnviarAsync(ByVal intPronostico As Long)
        'Hace la consulta de datos 
        Try
            Dim intRowsProcesar As Long
            Dim dt As SapForecastDataSetTableAdapters.CONSULTA_ENVIO_LIBERADOTableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_ENVIO_LIBERADOTableAdapter()
            Dim DTA As SapForecastDataSet.CONSULTA_ENVIO_LIBERADODataTable = New SapForecastDataSet.CONSULTA_ENVIO_LIBERADODataTable()


            intRowsProcesar = dt.Fill(DTA, mObjPronostico.Id, mObjPronostico.PeriodoInicial, mObjPronostico.PeriodoFinal)


            If intRowsProcesar > 0 Then




                Dim intItem As Long = 0
                Dim LstCampos As System.Collections.Generic.Dictionary(Of String, mCampos) = New System.Collections.Generic.Dictionary(Of String, mCampos)
                LstCampos.Add("IDPRONOSTICO", New mCampos("IDPRONOSTICO", String.Empty, String.Empty))

                LstCampos.Add("CLAVEAGENTE", New mCampos("CLAVEAGENTE", String.Empty, String.Empty))
                LstCampos.Add("CLAVEZONA", New mCampos("CLAVEZONA", String.Empty, String.Empty))
                LstCampos.Add("AGENTENEGOCIO", New mCampos("AGENTENEGOCIO", String.Empty, String.Empty))

                LstCampos.Add("INICIOPRONOSTICO", New mCampos("INICIOPRONOSTICO", "{0:yyyyMMdd}", String.Empty))
                LstCampos.Add("FINPRONOSTICO", New mCampos("FINPRONOSTICO", "{0:yyyyMMdd}", String.Empty))
                LstCampos.Add("TIPOPERIODO", New mCampos("TIPOPERIODO", String.Empty, String.Empty))
                LstCampos.Add("NUMPERIODOS", New mCampos("NUMPERIODOS", String.Empty, String.Empty))
                LstCampos.Add("DESCRIPIONPRONOSTICO", New mCampos("DESCRIPIONPRONOSTICO", String.Empty, String.Empty))


                LstCampos.Add("CLAVECLIENTE", New mCampos("CLAVECLIENTE", String.Empty, String.Empty))
                LstCampos.Add("SOCIEDAD", New mCampos("SOCIEDAD", String.Empty, String.Empty))
                LstCampos.Add("INTPERIODO", New mCampos("INTPERIODO", String.Empty, String.Empty))
                LstCampos.Add("SMDINICIO", New mCampos("SMDINICIO", "{0:yyyyMMdd}", String.Empty))
                LstCampos.Add("CLAVECENTRO", New mCampos("CLAVECENTRO", String.Empty, String.Empty))
                'LstCampos.Add("CLAVEALMACEN", New mCampos("CLAVEALMACEN", String.Empty, String.Empty))
                LstCampos.Add("CLAVEPRODUCTO", New mCampos("CLAVEPRODUCTO", String.Empty, String.Empty))
                LstCampos.Add("UNIDADMEDIDABASE", New mCampos("UNIDADMEDIDABASE", String.Empty, String.Empty))
                LstCampos.Add("NUMCANTIDADBASE", New mCampos("NUMCANTIDADBASE", String.Empty, "0"))
                LstCampos.Add("SMDTIMESTAMP", New mCampos("SMDTIMESTAMP", String.Empty, "0"))


                Me.BGWKEnvios.ReportProgress(15)


                Dim mstrSeparador As String = My.Settings.SeparadorArchivos
                If mstrSeparador = "\t" Then
                    mstrSeparador = Chr(9)
                End If


                Dim mStrFileName As String = Environ("Temp").ToString
                If Not mStrFileName.EndsWith("\") Then
                    mStrFileName = mStrFileName & "\"

                End If

                mStrFileName = mStrFileName & "Pronosticos_" & Me.txtPronostico.Text & "_" & String.Format("{0:yyyyMMdd_hhmmss_ffffff}", Date.Now) & ".txt"


                Dim mFile As DjpSap.ClassArchivos = New DjpSap.ClassArchivos(mStrFileName)
                Dim mBld As New System.Text.StringBuilder
                Dim mValueFld As Object

                For Each objItem As mCampos In LstCampos.Values
                    mBld.Append(objItem.Clave & mstrSeparador) 'Grava los titulos de las columnas
                Next objItem
                mFile.Append(mBld.ToString())


                intItem = 0
                Dim mstrNegocio As String = Nothing

                If DTA.Rows.Count > 0 Then
                    mstrNegocio = DTA.Rows(0).Item("AGENTENEGOCIO").ToString()

                End If


                For Each mrow As DataRow In DTA.Rows
                    intItem = intItem + 1
                    BGWKEnvios.ReportProgress((intItem + 15) Mod 50)



                    intItem = intItem + 1
                    mBld = New System.Text.StringBuilder

                    For Each objItem As mCampos In LstCampos.Values
                        mValueFld = mrow.Item(objItem.Clave)
                        If IsDBNull(mValueFld) Then
                            'Aplica definiciones cuando el campo es un valor nullo
                            If Not String.IsNullOrEmpty(objItem.NullValue) Then
                                mValueFld = objItem.NullValue
                            Else
                                mValueFld = String.Empty

                            End If
                        Else
                            If Not String.IsNullOrEmpty(objItem.Formato) Then
                                'Aplica formatos especiales.
                                mValueFld = String.Format(objItem.Formato, mValueFld)
                            End If
                        End If
                        mBld.Append(mValueFld & mstrSeparador)

                    Next objItem


                    mFile.Append(mBld.ToString())



                Next
                BGWKEnvios.ReportProgress(55)
                mFile.Save()


                BGWKEnvios.ReportProgress(60)
                Dim mParEntrada As StringBuilder = New StringBuilder
                With Me.mObjPronostico
                    mParEntrada.Append("<br>Id Pronostico:" & .Id)
                    mParEntrada.Append("<br>Descripcion:" & .Descripcion)
                    mParEntrada.Append("<br>Agente:" & .Agente.Clave & .Agente.Descripcion)
                    mParEntrada.Append("<br>Periodo de:" & .PeriodoInicial.ToString("dd-MMM-yyyy"))
                    mParEntrada.Append("  a:" & .PeriodoFinal.ToString("dd-MMM-yyyy"))
                End With
                mBolEstadoEnvioWs = EnviarRemoto(mStrFileName, mParEntrada.ToString, mstrNegocio)
                If mBolEstadoEnvioWs Then
                    pstrErrorWs = CTE_MSGOK
                Else
                    pstrErrorWs = "El proceso de envio ha fallado." & Environment.NewLine & pstrErrorWs
                End If


            Else
                pstrErrorWs = "No hay datos por enviar."


            End If
        Catch ex As Exception
            pstrErrorWs = ex.Message
            ModComun.MsgError(ex.Message)

        End Try



    End Sub


    Private Sub BGWKEnvios_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BGWKEnvios.ProgressChanged
        TsProgressBar.ProgressBar.Visible = True

        TsProgressBar.ProgressBar.Value = e.ProgressPercentage
        Select Case e.ProgressPercentage
            Case 1

                TsProgressBar.Visible = True
            Case 10
                EnviarTsLabel.Text = "Iniciando Extracccion de datos ..."
            Case 15
                EnviarTsLabel.Text = "Creando archivo ..."
            Case 55
                EnviarTsLabel.Text = "Guardando temporalmente ..."
            Case 70
                EnviarTsLabel.Text = "Conectando con web service .."
            Case 80
                EnviarTsLabel.Text = "Espere enviando ..."
            Case 90
                EnviarTsLabel.Text = pstrErrorWs

            Case Else
                If e.ProgressPercentage > 15 And e.ProgressPercentage < 50 Then
                    EnviarTsLabel.Text = "Agregando informacion al archivo"
                End If

        End Select

    End Sub

    Private Sub BGWKEnvios_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGWKEnvios.RunWorkerCompleted
        Try
            If e.Cancelled Then
                ModComun.MsgError("Proceso cancelado")
            ElseIf Not IsNothing(e.Error) Then
                ModComun.MsgError(e.Error.Message)
            Else
                TsProgressBar.ProgressBar.Value = 100
                If pstrErrorWs = CTE_MSGOK Then
                    ModComun.MsgInfo(pstrErrorWs)

                Else
                    ModComun.MsgError(Me.pstrErrorWs)
                End If



            End If
            Me.GuardarToolStripButton.Enabled = True
        Catch ex As Exception
            ModComun.MsgError(ex.Message)
        End Try

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        'Si se está ejecutando el thread detenerlo para pode cerrar la ventana.
        txtPronostico.Tag = "Salir"

        If PuedeSalir() Then
            Me.Close()
        End If
    End Sub

    Function PuedeSalir() As Boolean
        Dim mBolCancelar As Boolean = False
        Try


            If BGWKEnvios.IsBusy Then
                If ModComun.MsgYesNo("El proceso de envio será cancelado, por lo que no podrá validarse la integridad" & _
                                      Environment.NewLine & _
                                      "¿Está seguro de realizar la cancelación ?") Then
                    If BGWKEnvios.IsBusy Then
                        BGWKEnvios.CancelAsync()
                    End If

                End If

            Else
                mBolCancelar = True

            End If



        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try
        Return mBolCancelar
    End Function

    Private Sub FrmGeneraArchivo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not PuedeSalir() Then
            'Se está ejecutand el thread por lo tant debe esperar antes de continuar 
            e.Cancel = True
        End If
    End Sub




    Private Sub txtPronostico_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPronostico.Validating
        EnvioErrProv.Clear()

        If Me.ActiveControl.Name.Equals(btnEnviar.Name) = False AndAlso String.IsNullOrEmpty(txtPronostico.Tag) Then
            e.Cancel = Not Validar()

        End If



    End Sub
    ''Valida los datos de entrada 
    Private Function Validar() As Boolean
        Try
            Dim mBolOk As Boolean = False

            If String.IsNullOrEmpty(Trim(Me.txtPronostico.Text)) OrElse IsNumeric(Me.txtPronostico.Text) = False Then
                EnvioErrProv.SetError(txtPronostico, "El numero de pronostico debe ser un dato numerico.")
                'e.Cancel = True
            Else
                mObjPronostico = New ClassPronosticos
                If mObjPronostico.ConsultarCatalogo(Me.txtPronostico.Text) = False OrElse mObjPronostico.ExisteCatalogo = False Then
                    EnvioErrProv.SetError(txtPronostico, "El pronostico no existe, o no pudo ser consultado")
                Else

                    mBolOk = AsignarPronostico()

                End If
            End If
            Return mBolOk
        Catch ex As Exception
            ModComun.MsgError(ex.Message)
            Return False
        End Try
        

    End Function
    Private Function AsignarPronostico() As Boolean
        txtPronostico.Text = mObjPronostico.Id
        Me.FechaIniDtPicker.Value = mObjPronostico.PeriodoInicial
        'Me.FechaIniDtPicker.Enabled = False
        Me.FechaFinDtPicker.Value = mObjPronostico.PeriodoFinal
        '              Me.FechaIniDtPicker.Enabled = False
        'Me.mFechaFin.Value = mObjPronostico.PeriodoFinal
        DescripcionTxt.Text = mObjPronostico.Descripcion
        AgenteLbl.Text = mObjPronostico.Agente.Clave & ":" & mObjPronostico.Agente.Descripcion

        Return True

    End Function

    Private Sub FrmGeneraArchivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            mObjPronostico = New ClassPronosticos
            Dim mObjStream As DjpSap.ClassXmlRW = New DjpSap.ClassXmlRW(0, mObjPronostico.GetType.Name)
            If IsNothing(mObjStream.xmlReader) = False Then


                Dim mSerializer As New System.Xml.Serialization.XmlSerializer(GetType(ClassPronosticos))


                mObjPronostico = CType(mSerializer.Deserialize(mObjStream.xmlReader), ClassPronosticos)
            Else
                mObjPronostico.Id = 0
            End If
            If mObjPronostico.Id <> 0 Then
                If mObjPronostico.ConsultarCatalogo(mObjPronostico.Id) Then
                    AsignarPronostico()
                End If

            End If
        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try
        

    End Sub

    
    
    
End Class