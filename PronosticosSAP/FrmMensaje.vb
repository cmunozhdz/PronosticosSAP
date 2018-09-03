
Imports System.Threading

Public Class FrmMensaje
    ' Dim mThread As System.Threading.Thread
    Dim mStrUsuario As String
    'Dim mDs As DataSet
    Private mHandler As Boolean = False


    'Private Sub StartWebServices()
    '    Dim CteWs As CteSigeProCentralWbSrv.SigeProCentralWbSrv = New CteSigeProCentralWbSrv.SigeProCentralWbSrv
    '    'Dim mDs As DataSet = CteWs.FnGetDsMensajes(mStrUsuario)

    'End Sub
    Private Sub getCompleteHandler(Sender As Object, ByVal e As CteSigeProCentralWbSrv.FnGetDsMensajesCompletedEventArgs)
        Dim mActivarVentana As Boolean = False
        Try




            If e.Cancelled Then
                MsgInfo("Servicio de mensajes cancelado")

            ElseIf IsNothing(e.Error) = False Then
                Dim mEx As Exception = e.Error.GetBaseException()
                Select Case mEx.GetType().FullName
                    Case "System.Net.WebException"
                        'TsLabel.Text = mEx.Message
                        'MDIPronosticos.StatusLbl.Text = String.Format("Servidor de Mensajes:{0}  {1}", Date.Now, mEx.Message)
                        MDIPronosticos.MsgTextStatusBar(String.Format("Servidor de Mensajes:{0}  {1}", Date.Now, mEx.Message), True)

                    Case Else
                        TsLabel.Text = mEx.Source
                        mActivarVentana = True 'Hay un error y quiero verlo
                End Select





            ElseIf IsNothing(e.Result) = False Then

                Me.MensajesDs = CType(e.Result, DataSet)
                Me.MensajesBindingSource.DataSource = Me.MensajesDs
                Me.MensajesBindingSource.DataMember = Me.MensajesDs.Tables(0).TableName
                If Me.MensajesDs.Tables(0).Rows.Count > 0 Then
                    'El dataset si tiene registros

                    MDIPronosticos.MsgTextStatusBar(String.Format("{0},Se han encontrado mensajes nuevos ", Date.Now), False)
                    If Me.DataBindings.Count = 0 Then
                        FromTxt.DataBindings.Add(New Binding("Text", Me.MensajesBindingSource, "FROMUSER"))
                        ToTxt.DataBindings.Add(New Binding("Text", Me.MensajesBindingSource, "TOUSER"))
                        SubjectTxt.DataBindings.Add(New Binding("Text", Me.MensajesBindingSource, "ASUNTO"))
                        ContenidoTxt.DataBindings.Add(New Binding("Text", Me.MensajesBindingSource, "CONTENIDO"))

                        'Me.SubjectTxt.Text = .Item("ASUNTO").ToString
                        '            Me.TxtFrom.Text = .Item("FROMUSER").ToString.Trim()
                        '            Me.TxtTo.Text = .Item("TOUSER").ToString
                        '            Me.MsgTxt.Text = .Item("CONTENIDO").ToString

                    End If
                    mActivarVentana = True 'Hay mensajes y quiero verlos.

                End If


            End If

        Catch ex As Exception
            TsLabel.Text = ex.Source

            mActivarVentana = True 'Hay mensajes y quiero verlos.
        Finally
            If mActivarVentana Then
                Try
                    Me.Show()
                Catch ex1 As Exception
                    Me.Dispose()

                End Try


            Else
                'Dim mForm As MDIPronosticos = Me.MdiParent
                'MDIPronosticos.Timer.Enabled = True 'Activa el timer para una llamada posterior del mensajero
                MDIPronosticos.CloseMensajero(False)
            End If

        End Try
        
    End Sub
    Public Sub BindData()
        Try
            Dim mForm As MDIPronosticos = Me.MdiParent
            mForm.Timer.Enabled = False
            mForm.Timer.Interval = My.Settings.TimerMensajes * 1000 'Establece el tiempo de retraso para el siguiente mensaje 
            mStrUsuario = mForm.pUsuario.UserName
            CallAsincWebservice() 'Hace la llamada del webservice asincrono para evitar retrasos en el cliente
        Catch ex As Exception
            MDIPronosticos.MsgTextStatusBar("BindData_" & ex.Message, True)
        End Try
        
    End Sub
    
    Private Sub CallAsincWebservice()

        Try
            
            'mThread = New Thread(AddressOf StartWebServices)
            'mThread.Start()
            If Not mHandler Then 'El proceso no ha Iniciao
                AddHandler My.WebServices.SigeProCentralWbSrv.FnGetDsMensajesCompleted, AddressOf getCompleteHandler
                mHandler = True
            End If
            'Ahora Hace la llamada del webservice asincrono
            My.WebServices.SigeProCentralWbSrv.FnGetDsMensajesAsync(mStrUsuario)



        Catch ex As Web.Services.Protocols.SoapException

            ModComun.MsgError(String.Format("Servicio de Mensajes:{0}", ex.Message))
            Me.Close()

        Catch Ex As Net.WebException
            'No hay acceso a internet y no responde el servicio
            Me.Close()

        Catch ex As Exception
            ModComun.MsgError(String.Format("Servicio de Mensajes:{0}", ex.Message))

        End Try
    End Sub

    


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    

    Private Sub BindingNavigatorMoveNextItem_Click(sender As System.Object, e As System.EventArgs)
        Me.MensajesBindingSource.MoveNext()
    End Sub

    Private Sub FrmMensaje_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            'Dim mStrMsg As String = 

            MsgInfo(String.Format("Esta acción hará que se consulten nuevamente los mensajes el dia {0:dd-MMM-yyyy hh:mm:ss} ", Date.Now.AddSeconds(My.Settings.TimerMensajes)))
            MDIPronosticos.CloseMensajero(True)
        Catch ex As Exception
            MDIPronosticos.MsgTextStatusBar("Cerrando Mensajero:" & ex.Message, True)
        End Try


    End Sub

    

    Private Sub ToolStripButton1_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Close()
        Catch ex As Exception
            MDIPronosticos.MsgTextStatusBar("ToolStripButton1.Click_Cerrando Mensajero:" & ex.Message, True)
        End Try


    End Sub
End Class