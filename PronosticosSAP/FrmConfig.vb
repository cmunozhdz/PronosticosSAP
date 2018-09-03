Public Class FrmConfig
    Dim MOBJ As ClassCustomConfig
    
    ''' <summary>
    ''' Habilita o desabilita cambios cuando se activa seguridad de windows.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub ChkWindows_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If ChkWindows.Checked Then
            With Me.TxtUid
                Text = String.Empty
                .Enabled = False

            End With
            With Me.txtPwd
                Text = String.Empty
                .Enabled = False

            End With
        Else
            With Me.TxtUid
                Text = String.Empty
                .Enabled = True

            End With
            With Me.txtPwd
                Text = String.Empty
                .Enabled = True

            End With
        End If
    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        Me.Validate()

        If String.IsNullOrEmpty(Me.CtrlErrPrv.GetError(Me.txtAgricola)) And
            String.IsNullOrEmpty(Me.CtrlErrPrv.GetError(Me.txtIndustrial)) Then

            MOBJ.DiasAgricolas = Me.txtAgricola.Text
            MOBJ.DiasIndustrial = Me.txtIndustrial.Text
            MOBJ.DelayAutoSave = Me.NumAutoSave.Value

            Dim tmp As System.Text.StringBuilder = New System.Text.StringBuilder

            tmp.Append("Data Source=" & Me.txtServer.Text & _
                                ";Initial Catalog=" & Me.txtBd.Text)

            If Me.ChkWindows.Checked Then
                tmp.Append(";Integrated Security=true;")
            Else
                tmp.Append(";Uid=" & Me.TxtUid.Text)
                tmp.Append(";pwd=" & Me.txtPwd.Text)
            End If
            MOBJ.Connection = tmp.ToString
            MOBJ.AplicaAgricolaHabiles = Me.ChkAgricolasFestivos.Checked
            MOBJ.AplicaIndustrialHabiles = Me.ChkIndustrialesFestivos.Checked

            MOBJ.Save()
            'My.Settings.Save()
            My.Application.SaveMySettingsOnExit = True
            TsLabelStatus.Text = "Guardado !!!"
        Else
            TsLabelStatus.Text = "No se pudo guardar"
        End If




    End Sub

    Private Sub FrmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MOBJ = New ClassCustomConfig
        'Me.TextBox1.Text = MOBJ.Connection
        Dim mParametros() As String = Split(MOBJ.Connection, ";", -1, Microsoft.VisualBasic.CompareMethod.Text)
        Dim intPos As Integer
        Dim mstrValue As String
        For mItem As Integer = LBound(mParametros) To UBound(mParametros)


            intPos = InStr(mParametros(mItem), "=", Microsoft.VisualBasic.CompareMethod.Text)
            If intPos > 0 Then
                mstrValue = Mid(mParametros(mItem), intPos + 1)

                Select Case Mid(mParametros(mItem), 1, intPos - 1)
                    Case "Data Source" : Me.txtServer.Text = mstrValue
                    Case "Initial Catalog" : Me.txtBd.Text = mstrValue
                    Case "Integrated Security"
                        If mstrValue = "True" Then
                            Me.ChkWindows.Checked = True
                        Else
                            Me.ChkWindows.Checked = False
                        End If
                    Case "UID"

                    Case "pwd"



                End Select
            End If

        Next
        Me.txtAgricola.Text = MOBJ.DiasAgricolas
        Me.txtIndustrial.Text = MOBJ.DiasIndustrial
        Me.NumAutoSave.Value = MOBJ.DelayAutoSave
        Me.TxtDirApp.Text = Application.StartupPath
        ChkAgricolasFestivos.Checked = MOBJ.AplicaAgricolaHabiles
        ChkIndustrialesFestivos.Checked = MOBJ.AplicaIndustrialHabiles
        'Dim mUser As New DjpSap.ClassUser

        Dim mParen As MDIPronosticos = CType(Me.MdiParent, MDIPronosticos)
        If mParen.pUsuario.EsSuperUsuario = False Then
            MsgInfo("Solo el usuario administrador puede modificar los datos Actuales.")
            Me.GuardarToolStripButton.Enabled = False

        End If

    End Sub

    ''' <summary>
    ''' Valida que se hayan capturado entre 1 y 30 dias.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    
    Private Sub Dias_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAgricola.Validating, txtIndustrial.Validating
        Dim mObjTxt As TextBox = CType(sender, TextBox)
        If String.IsNullOrEmpty(mObjTxt.Text) OrElse String.IsNullOrWhiteSpace(mObjTxt.Text) Then
            Me.CtrlErrPrv.SetError(mObjTxt, "Dato obligatorio")
            e.Cancel = True
        Else
            Dim intDias As Integer
            If Integer.TryParse(mObjTxt.Text, intDias) = False Then
                Me.CtrlErrPrv.SetError(mObjTxt, "El dato debe ser numerico")
                e.Cancel = True
            Else
                If intDias < 1 Or intDias > 30 Then
                    Me.CtrlErrPrv.SetError(mObjTxt, "Valor fuera de intervalo, debe ser entre 1 y 30")
                    e.Cancel = True
                Else
                    Me.CtrlErrPrv.SetError(mObjTxt, String.Empty)
                End If

            End If
        End If



    End Sub

    
End Class