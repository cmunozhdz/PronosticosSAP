Public Class FrmHistorialVtas

    Dim mObjProducto As ClassProducto
    Dim mAnioSelect As Nullable(Of Integer)
    Dim mMesSelect As Nullable(Of Integer)
    Dim mstrCentros As String 'Centros a consultar separados por comas 
    Dim mAgente As ClassVendedor
    Public Sub AutoRun()
        AbrirToolStripButton.PerformClick()

    End Sub
    Public Sub SetVariables(pIdAgente As String, pProducto As String, pCentro As String, pAnio As Nullable(Of Integer), pMes As Nullable(Of Integer))

        mAgente = New ClassVendedor
        mObjProducto = New ClassProducto
        mAnioSelect = pAnio
        mMesSelect = pMes

        mObjProducto.Clave = pProducto
        mstrCentros = pCentro
        mAgente.Clave = pIdAgente


    End Sub
    
    ''' <summary>
    ''' Consulta las ventas del agente seleccionado.
    ''' </summary>
    ''' <remarks></remarks>
    Public Function ConsultarVtas()
        Try
            Dim mds As DataSet = Nothing
            Dim idAgente As Nullable(Of Integer)
            Dim mDtPivot As DataTable


            Bkg.ReportProgress(10)

            Dim mCteWs As CteSigeProCentralWbSrv.SigeProCentralWbSrv = New CteSigeProCentralWbSrv.SigeProCentralWbSrv
            With mCteWs
                mCteWs.Credentials = New Net.NetworkCredential("Administrador", "Nilvst", "192.168.2.22")


            End With

            If Bkg.CancellationPending = False Then
                Bkg.ReportProgress(20)

                If mAgente.Clave Is Nothing Then
                    idAgente = Nothing
                Else
                    idAgente = Integer.Parse(mAgente.Clave)
                End If
            End If
            If Bkg.CancellationPending = False Then
                Bkg.ReportProgress(30)

                'mds = mCteWs.GetVtasXAgenteMes(mAnioSelect, mMesSelect, mstrCentros, mObjpProducto.Clave, idAgente)
                Dim pProducto As Nullable(Of Integer)

                If Not IsNumeric(pProducto) Then
                    pProducto = Nothing
                Else
                    Integer.TryParse(mObjProducto.Clave, pProducto)

                End If


                mds = mCteWs.GetVtasXAgenteMes(mAnioSelect, mMesSelect, "1000,2000,1100", pProducto, idAgente)

                Bkg.ReportProgress(40)

            End If
            If Bkg.CancellationPending = False Then
                Bkg.ReportProgress(50)
                mDtPivot = New DataTable

                mDtPivot.Columns.Add("Año", GetType(Integer))
                mDtPivot.Columns.Add("Agente", GetType(String))
                mDtPivot.Columns.Add("Centro", GetType(String))
                mDtPivot.Columns.Add("Material", GetType(String))
                mDtPivot.Columns.Add("Unidad", GetType(String))

                Dim mArrMes(0 To 11) As String

                mArrMes(0) = "Enero"

                mArrMes(1) = "Febrero"

                mArrMes(2) = "Marzo"
                mArrMes(3) = "Abril"
                mArrMes(4) = "Mayo"
                mArrMes(5) = "Junio"
                mArrMes(6) = "Julio"
                mArrMes(7) = "Agosto"
                mArrMes(8) = "Septiembre"
                mArrMes(9) = "Octubre"
                mArrMes(10) = "Noviembre"
                mArrMes(11) = "Diciembre"
                For intCol As Integer = mArrMes.GetLowerBound(0) To mArrMes.GetUpperBound(0)
                    mDtPivot.Columns.Add(mArrMes(intCol), GetType(Double))
                Next
                Dim mRow As DataRow = Nothing 'Instancia del renglo a agregar.
                Dim mbolFound As Boolean 'Valida si el empleado ya existe 

                For Each mRowDb As DataRow In mds.Tables(0).Rows
                    'Valida si el año, y agente ya existen
                    mbolFound = False
                    For Each mRow In mDtPivot.Rows
                        If CType(mRow("Año"), Integer) = CType(mRowDb("AÑO"), Integer) AndAlso _
                           CType(mRow("Centro"), Integer) = CType(mRowDb("WERKS"), Integer) AndAlso _
                           CType(mRow("Agente"), Integer) = CType(mRowDb("REPRESENTANTE"), Integer) AndAlso _
                           CType(mRow("Material"), Integer) = CType(mRowDb("MATNR"), Integer) Then

                            mbolFound = True
                            Exit For
                        End If
                    Next
                    If mbolFound = False Then
                        mRow = mDtPivot.NewRow()
                        mRow("Año") = mRowDb("AÑO")
                        mRow("Centro") = mRowDb("WERKS")
                        mRow("Agente") = mRowDb("REPRESENTANTE")
                        mRow("Material") = mRowDb("MATNR")
                        mRow("Unidad") = mRowDb("Unidad de Venta")

                        mDtPivot.Rows.Add(mRow)


                    End If
                    mRow(mArrMes(mRowDb("MES") - 1)) = mRowDb("VOLUMENMENSUAL")


                    'Actualiza las ventas mensuales.

                Next
                mDtPivot.TableName = "ResumenVtas"
                mds.Tables.Add(mDtPivot)




            End If


            Return mds

        Catch ex As Exception

            ModComun.MsgError(ex.Message)
            Return Nothing

        End Try


    End Function

   
    Private Sub Bkg_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Bkg.DoWork
        e.Result = ConsultarVtas()
        If Bkg.CancellationPending Then
            e.Cancel = True
        End If
        

    End Sub

    Private Sub Bkg_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles Bkg.ProgressChanged
        ToolStripProgressBar1.Value = e.ProgressPercentage
        Select Case e.ProgressPercentage
            Case 10
                Me.StatusProgres.Text = "Iniciando comunicacion con Web Service"
            Case 20
                Me.StatusProgres.Text = "Web Service Conectado"
            Case 30
                Me.StatusProgres.Text = "Esperando Datos"
            Case 40
                Me.StatusProgres.Text = "Dando Formato"
        End Select
    End Sub

    Private Sub Bkg_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Bkg.RunWorkerCompleted
        If e.Cancelled Then
            ToolStripProgressBar1.Value = 0
            Me.StatusProgres.Text = "Proceso de Consulta Cancelada"
        ElseIf Not (e.Error Is Nothing) Then
            ModComun.MsgError(e.Error.Message)
            ToolStripProgressBar1.Value = 0
        Else
            Dim mds As DataSet = CType(e.Result, DataSet)

            GrdVtas.AutoGenerateColumns = True
            GrdVtas.DataSource = mds
            GrdVtas.DataMember = "ResumenVtas"

            Me.StatusProgres.Text = "Proceso Terminado"
            ToolStripProgressBar1.Value = 100

        End If
        

    End Sub

    Private Sub AbrirToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles AbrirToolStripButton.Click
        If Not Bkg.IsBusy Then
            Bkg.RunWorkerAsync()
        Else
            Me.StatusProgres.Text = "Espere el proceso está ocupado."

        End If



    End Sub


    Private Sub FrmHistorialVtas_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Bkg.IsBusy Then
            If ModComun.MsgYesNo("Se cancelará el proceso actual ¿ Es correcto ? ") Then
                Bkg.CancelAsync()
                e.Cancel = True
            End If
        End If
    End Sub
End Class