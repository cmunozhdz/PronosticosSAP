Public Class FrmForgotUsuario
    Dim mStrMensaje As String


    Private Sub USP_CONSULTA_USUARIOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USP_CONSULTA_USUARIOBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.USP_CONSULTA_USUARIOBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SapForecastDataSet)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Function DataFill() As Boolean
        Try
            Me.USP_CONSULTA_USUARIOTableAdapter.Fill(Me.SapForecastDataSet.USP_CONSULTA_USUARIO, Nothing)
            mStrMensaje = "Proceso Terminado"
            Return True
        Catch ex As System.Exception
            mStrMensaje = ex.Message

            Return (False)
        End Try

    End Function


    Private Sub FrmForgotUsuario_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If BGWK.IsBusy Then
            Me.SetMsgSatus("El proceso actual está ocupado")
        Else
            BGWK.RunWorkerAsync()

        End If
    End Sub

    
    Private Sub BGWK_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWK.DoWork
        If Not BGWK.CancellationPending Then
            If e.Cancel = False Then
                Me.mStrMensaje = "Espere Consultando datos.... "
                BGWK.ReportProgress(10)
                e.Result = DataFill()
                If e.Result Then
                    BGWK.ReportProgress(90)
                    Me.mStrMensaje = "Espere Dando  Formato..."
                End If
                
            End If
        End If
        


    End Sub

    Private Sub BGWK_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BGWK.ProgressChanged
        'Me.ProgressUser.Value = e.ProgressPercentage
        Me.ProgressUser.Style = ProgressBarStyle.Marquee
        SetMsgSatus(mStrMensaje)
    End Sub

    Private Sub BGWK_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGWK.RunWorkerCompleted
        If e.Cancelled Then
            mStrMensaje = "Proceso Cancelado"
            Me.ProgressUser.Value = 0
            SetMsgSatus(mStrMensaje)
        ElseIf Not IsNothing(e.Error) Then
            mStrMensaje = e.Error.Message
            Me.ProgressUser.Value = 0
            SetMsgSatus(mStrMensaje)
        Else
            Dim Bol As Boolean = e.Result
            USP_CONSULTA_USUARIOBindingNavigatorSaveItem.Enabled = Bol
            If Bol = False Then

                Me.SetMsgSatus(Mid(String.Format("{0}", Me.mStrMensaje), 1, 95))
                Me.ProgressUser.Value = 0
            Else
                Me.USP_CONSULTA_USUARIOBindingSource.ResetBindings(True)
                Me.SetMsgSatus("Proceso terminado")
                Me.ProgressUser.Value = 100
            End If

            Me.ProgressUser.Style = ProgressBarStyle.Blocks
        End If


    End Sub
    Private Sub SetMsgSatus(pStrValue As String)
        LblStatus.Text = pStrValue
    End Sub

    
End Class

