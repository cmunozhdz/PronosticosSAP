Public Class LoginForm
    Dim Frm As MDIPronosticos
    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim mUser As DjpSap.ClassUser = New DjpSap.ClassUser
        Dim mIntVerifica As Integer
        If String.IsNullOrEmpty(Me.UsernameTextBox.Text) = False And String.IsNullOrEmpty(Me.PasswordTextBox.Text) = False Then
            mUser.UserName = Me.UsernameTextBox.Text
            mUser.Password = Me.PasswordTextBox.Text
            mIntVerifica = mUser.Autentificar
            If mIntVerifica = 1 Then
                Dim mObjVerificaVersion As DjpSap.ClassActualizaciones = New DjpSap.ClassActualizaciones
                If mObjVerificaVersion.VerificaVersion Then

                    Me.DialogResult = DialogResult.Yes
                    Me.Hide()
                    'My.User.CurrentPrincipal = mUser
                    With MDIPronosticos
                        .pUsuario = mUser
                        .UsuarioTxtStatus.Text = .pUsuario.UserName


                        .Show(Me)
                    End With






                Else
                    ModComun.MsgError("Se ha encontrado una actualización que debe aplicarse en su base de datos " &
                                      Environment.NewLine & "Actual:" & mObjVerificaVersion.VersionDb &
                                      Environment.NewLine & "Esperado:" & mObjVerificaVersion.VersionAplicacion)
                End If


            Else
                ModComun.MsgWarning(mUser.FnMsgError(mIntVerifica))
                'MsgBox(mUser.FnMsgError(mIntVerifica), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Validando Usuario")


            End If
        Else

            ModComun.MsgError("El usuario y password son datos obligatorios")
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub





    Private Sub ChkForgotPassword_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkForgotPassword.CheckedChanged
        If ChkForgotPassword.Checked = True Then
            FrmForgotUsuario.ShowDialog()
            ChkForgotPassword.Checked = False
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Dim ojVersion As New ClassAssembly
            StsLabel.Text = ojVersion.GetVersion

        Catch ex As Exception
            StsLabel.Text = "Error al identificar versión actual" & ex.Message

        End Try


    End Sub


End Class
