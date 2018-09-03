Public Class FrmExistencias
    Dim Mds As DataSet
    Dim mBolUnload As Boolean
    Enum enProcesosWB
        Consulta = 0
        Imprimir = 1
    End Enum
    Private mIdProcesoActual As enProcesosWB
    ' Dim mRptExistencias As CrystalDecisions.CrystalReports.Engine.ReportDocument

    

    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        'FillData()
        AbrirToolStripButton.Enabled = False
        ToolStripButton1.Enabled = True
        ToolStripButton1.Visible = True
        Me.TsProgress.Style = ProgressBarStyle.Blocks
        ExistenciasBGW.RunWorkerAsync(enProcesosWB.Consulta)

    End Sub
    ''' <summary>
    ''' Muestra pantalla para seleccionar un producto del listado de materiales.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MaterialBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialBtn.Click

        If FrmConsultaProductoVarios.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.MaterialTxt.Text = FrmConsultaProductoVarios.GetItems()

        End If
        FrmConsultaProductoVarios.Close() 'Libera los recursos
        FrmConsultaProductoVarios.Dispose()

    End Sub
    ''' <summary>
    ''' Procesos  que se ejecutan en un segundo treath
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExistenciasBGW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ExistenciasBGW.DoWork
        Dim mBolRes As Boolean = False
        mBolRes = False


        ' Try
        Dim mType As enProcesosWB = CType(e.Argument, enProcesosWB)

        mIdProcesoActual = mType
        If mType = enProcesosWB.Consulta Then
            '************************************
            'Consultar el dataset
            '************************************

            Me.ExistenciasBGW.ReportProgress(5)
            Dim mObjCteWs As CteSigeProCentralWbSrv.SigeProCentralWbSrv = Nothing


            If ExistenciasBGW.CancellationPending = False Then
                Me.ExistenciasBGW.ReportProgress(10)
                mObjCteWs = New CteSigeProCentralWbSrv.SigeProCentralWbSrv
            Else
                mBolRes = True
                e.Cancel = mBolRes

            End If
            If ExistenciasBGW.CancellationPending = False Then
                Me.ExistenciasBGW.ReportProgress(20)
                Mds = mObjCteWs.FnGetDsSapExistencias(Me.MaterialTxt.Text, Me.CentroTxt.Text, Me.AlmacenTxt.Text, Me.LoteTxt.Text)
            Else
                mBolRes = True
                e.Cancel = mBolRes

            End If
            If ExistenciasBGW.CancellationPending = False Then
                Me.ExistenciasBGW.ReportProgress(70)
                'Mds = mObjCteWs.FnGetDsSapExistencias(Me.MaterialTxt.Text, Me.CentroTxt.Text, Me.AlmacenTxt.Text, Me.LoteTxt.Text)
                e.Result = True
            Else
                mBolRes = True
                e.Cancel = mBolRes

            End If
            
        Else
            ExistenciasBGW.ReportProgress(5)

            '************************************
            'Impresion de reportes
            '************************************
            'Dim mrt As CrystalDecisions.CrystalReports.Engine.ReportDocument
            'If ExistenciasBGW.CancellationPending = False Then
            '    mRptExistencias = New Existencias
            'Else
            '    mBolRes = True
            '    e.Cancel = mBolRes
            'End If
            'If ExistenciasBGW.CancellationPending = False Then
            '    ExistenciasBGW.ReportProgress(15)
            '    mRptExistencias.SetDataSource(Mds)
            'Else
            '    mBolRes = True
            '    e.Cancel = mBolRes
            'End If
            'If ExistenciasBGW.CancellationPending = False Then
            '    ExistenciasBGW.ReportProgress(85)
            '    e.Result = True
            'Else
            '    mBolRes = True
            '    e.Cancel = mBolRes
            'End If



        End If


        

            'ExistenciasBGW.CancellationPending = False

    End Sub

    Private Sub ExistenciasBGW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles ExistenciasBGW.ProgressChanged

        TsProgress.Value = e.ProgressPercentage
        If mIdProcesoActual = enProcesosWB.Consulta Then
            Select Case e.ProgressPercentage
                Case 5
                    TsText.Text = "Iniciando proceso de consultas"
                Case 10
                    TsText.Text = "Estableciendo  Comunicación remota con WebService "
                Case 20
                    TsText.Text = "Consultando datos ... "
                Case 70
                    TsText.Text = "Datos consultados ... dando formatos"
                    Me.DataGridView1.AutoGenerateColumns = False

                    Me.DataGridView1.DataSource = Mds
                    Me.DataGridView1.DataMember = Mds.Tables(0).TableName
                    Me.DataGridView1.Refresh()

            End Select
        Else
            Select Case e.ProgressPercentage
                Case 5
                    TsText.Text = "Proceso de impresion Iniciado."
                Case 15
                    TsText.Text = "Generando reporte"
                Case 85
                    TsText.Text = "Reporte Generado"


            End Select
        End If


    End Sub

    Private Sub ExistenciasBGW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ExistenciasBGW.RunWorkerCompleted
        Dim mBolContinuar As Boolean
        mBolContinuar = False
        If e.Cancelled Then
            TsText.Text = "Proceso Cancelado"
            If mBolUnload = True Then
                Me.Close()
            End If

            'Exit Sub
            
        ElseIf IsNothing(e.Error) = False Then

            If Me.mIdProcesoActual = enProcesosWB.Consulta Then
                TsText.Text = "Vista de Consulta.-Error:" & e.Error.Message
            Else
                TsText.Text = "Vista de impresión.-Error:" & e.Error.Message
            End If
            TsProgress.Style = ProgressBarStyle.Blocks
            'Exit Sub

        Else
            TsProgress.Style = ProgressBarStyle.Blocks
            'Valida el resultado 
            Dim mBolRes As Boolean = CType(e.Result, Boolean)
            If mBolRes Then
                If mIdProcesoActual = enProcesosWB.Consulta Then

                    AbrirToolStripButton.Enabled = True
                    ToolStripButton1.Enabled = False
                    ToolStripButton1.Visible = False
                    TsProgress.Value = 100
                    TsText.Text = "Proceso terminado"

                    Me.WindowState = FormWindowState.Maximized
                Else
                    TsProgress.Value = 100
                    TsText.Text = "Proceso terminado mostrando vista de impresion..."

                    Me.ShowReport()


                    
                End If

                ImprimirToolStripButton.Enabled = mBolRes  'El proceso termino ok Habilita el procedimientos de impresion.
            End If

            

        End If

        

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Me.ExistenciasBGW.CancellationPending = False Then
            If Me.ExistenciasBGW.IsBusy Then
                'If ModComun.MsgYesNo("El proceso actual será cancelado" & vbCrLf & "¿ Esta seguro ?") Then

                Me.ExistenciasBGW.CancelAsync()

                'End If
            End If
        End If


    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()

    End Sub

    Private Sub FrmExistencias_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.ExistenciasBGW.IsBusy Then
            If ModComun.MsgYesNo("El proceso de consulta será cancelado está seguro") Then
                Me.ExistenciasBGW.CancelAsync()
                mBolUnload = True
                e.Cancel = True 'Espera a que el proceso de cancelacion sea realizado
            Else
                e.Cancel = True
            End If
        End If
    End Sub


    
    
    Private Sub MaterialTxt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaterialTxt.KeyUp, CentroTxt.KeyUp, AlmacenTxt.KeyUp, LoteTxt.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.AbrirToolStripButton.PerformClick()
        End If
    End Sub


    
    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click
        'cREA UN REPORTE DE CRYSTAL
        Try
            If Me.ExistenciasBGW.IsBusy = False Then
                ImprimirToolStripButton.Enabled = False
                With Me.ToolStripButton1
                    .Enabled = True
                    .Visible = True
                End With
                
                Me.TsProgress.Style = ProgressBarStyle.Marquee
                'Me.ExistenciasBGW.ReportProgress(5)

                Me.ExistenciasBGW.RunWorkerAsync(enProcesosWB.Imprimir)

            End If

        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try

    End Sub

    'Private Function SetPrintData() As CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    'Me.ExistenciasBGW.RunWorkerAsync()
    '    Me.ExistenciasBGW.ReportProgress(5)
    '    Dim mrt As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Existencias
    '    Me.ExistenciasBGW.ReportProgress(15)
    '    mrt.SetDataSource(Mds)
    '    Me.ExistenciasBGW.ReportProgress(85)
    '    Return mrt


    'End Function
    Private Sub ShowReport()

        'Dim mFrmView As FrmReportViewer = New FrmReportViewer
        'With mFrmView
        '    .MdiParent = Me.MdiParent
        '    .Text = "Existencias"
        '    .WindowState = FormWindowState.Maximized
        '    .CrystalReportViewer1.ReportSource = mRptExistencias
        '    .CrystalReportViewer1.Show()

        '    .Show()
        'End With
        'Me.TsProgress.Style = ProgressBarStyle.Blocks

    End Sub

End Class

