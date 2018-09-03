Imports System.Text
Module ModComun
    Private nForm As MDIPronosticos
    Private Const CTE_ISOFECHA = "YYYYMMDD"
    'Dim mUser As DjpSap.ClassUser
    Public Const FORMDIALOG As System.Windows.Forms.DialogResult = Windows.Forms.DialogResult.Yes 'DEvuelve a las pantallas de dialogo el valor de ok
    Public Const CTE_KEYENTER As Integer = 13

    Public Sub Principal()

        If LoginForm.ShowDialog() = System.Windows.Forms.DialogResult.Yes Then
            ModComun.nForm = New MDIPronosticos
            'mUser = New DjpSap.ClassUser

            With ModComun.nForm
                .pUsuario = New DjpSap.ClassUser()
                .pUsuario.UserName = LoginForm.UsernameTextBox.Text
                LoginForm.Dispose()

                .UsuarioTxtStatus.Text = .pUsuario.UserName
                .Show()


            End With

        End If

    End Sub


    Private Const mCTE_CAPTION As String = "Sistema de Gestion de Pronosticos"
    ''' <summary>
    ''' Mensaje presentar cuando ocurre un error grave
    ''' </summary>
    ''' <param name="pstrMensaje"></param>
    ''' <remarks></remarks>
    Public Sub MsgError(ByVal pstrMensaje As String)

        System.Windows.Forms.MessageBox.Show(pstrMensaje, mCTE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    ''' <summary>
    ''' Mensaje a presentar cuando ocurre una alerta
    ''' </summary>
    ''' <param name="pstrMensaje"></param>
    ''' <remarks></remarks>
    Public Sub MsgWarning(ByVal pstrMensaje As String)
        System.Windows.Forms.MessageBox.Show(pstrMensaje, mCTE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    ''' <summary>
    ''' DEvuelve un verdadero si el usuario presiono la tecla yes
    ''' </summary>
    ''' <param name="pstrMensaje">Mensaje a presentar </param>
    ''' <remarks></remarks>
    Public Function MsgYesNo(ByVal pstrMensaje As String) As Boolean
        Return System.Windows.Forms.MessageBox.Show(pstrMensaje, mCTE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    ''' <summary>
    ''' DEvuelve un verdadero si el usuario presiono la tecla yes
    ''' </summary>
    ''' <param name="pstrMensaje">Mensaje a presentar </param>
    ''' <param name="DefaultButton">Indica si se pone un boton como predeterminado</param>
    ''' <returns>Verdadero si se pulsa el boton yes</returns>

    Public Function MsgYesNo(ByVal pstrMensaje As String, ByVal DefaultButton As System.Windows.Forms.MessageBoxDefaultButton) As Boolean
        Return System.Windows.Forms.MessageBox.Show(pstrMensaje, mCTE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultButton) = DialogResult.Yes
    End Function

    ''' <summary>
    ''' Mensaje a presentar cuando ocurre una alerta
    ''' </summary>
    ''' <param name="pstrMensaje"></param>
    ''' <remarks></remarks>
    Public Sub MsgInfo(ByVal pstrMensaje As String)
        System.Windows.Forms.MessageBox.Show(pstrMensaje, mCTE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Function GetDate(ByRef pValor As String, ByRef Formato As String)
        Select Case Formato.ToUpper.Trim()

            Case CTE_ISOFECHA
                Return DateSerial(Mid(pValor, 1, 4), Mid(pValor, 5, 2), Mid(pValor, 7, 2))


        End Select
        Return Nothing

    End Function

    Public Function GetDate(ByRef pValor As String)
        Return GetDate(pValor, CTE_ISOFECHA)
    End Function

    Public Function GetDate(ByRef pValor As Integer)
        Return GetDate(pValor.ToString, CTE_ISOFECHA)
    End Function

    Sub ShowHelpAppByTopicId(ByVal mOwner As Form, ByVal TopicId As String)
        ''*********************************************************
        'Ejecuta el browser  
        ''**********************************************************
        Try

            Process.Start(My.Settings.UrlHelp)
        Catch ex As Exception
            MsgError(ex.Message)

        End Try

        Exit Sub

        Dim mCurrFileHelp As New System.Text.StringBuilder(Application.StartupPath)

        If Not mCurrFileHelp.ToString.EndsWith("\") Then
            mCurrFileHelp.Append("\")
        End If

        'mCurrFileHelp = mCurrFileHelp & "PronosticosSAP.chm"

        mCurrFileHelp = mCurrFileHelp.Append(My.Settings.HelpOnline)

        If System.IO.File.Exists(mCurrFileHelp.ToString) Then

            Dim mNav As HelpNavigator
            Select TopicId
                Case "0"
                    mNav = HelpNavigator.Index
                    TopicId = Nothing
                Case "-1"
                    mNav = HelpNavigator.Find
                    TopicId = String.Empty
                Case Else
                    mNav = HelpNavigator.TopicId
            End Select
            Help.ShowHelp(mOwner, mCurrFileHelp.ToString(), mNav, TopicId)



        Else
            MsgError(String.Format("El archivo de ayuda {0} No Existe", mCurrFileHelp))

        End If
    End Sub
    ''' <summary>
    ''' Presenta un formulario personalizado de si/no
    ''' </summary>
    ''' <param name="pstrMensaje">Mensaje a mostrar</param>
    ''' <param name="DefaultYes">Verdadero si el boton predetermina es Yes</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CustomYesNo(ByVal pstrMensaje As String, ByVal DefaultYes As Boolean, ByVal mPropietario As Form)
        Dim mBolRet As Boolean = False
        Dim mFrm As FrmYesNoDialog = New FrmYesNoDialog()
        mFrm.Inicializar(pstrMensaje, DefaultYes)
        mBolRet = mFrm.ShowDialog(mPropietario) = DialogResult.Yes
        mFrm.Dispose()
        Return mBolRet

    End Function
    ''' <summary>
    ''' Convierte una cadena cuyo valor es "S" en una true o false
    ''' </summary>
    ''' <param name="pValor">Valor a validar</param>
    ''' <returns>Devuelve true si la cadena vale s/S</returns>
    ''' <remarks></remarks>
    Public Function FnStr2Bol(ByVal pValor As String) As Boolean
        Dim CTESI = "S"
        Return CTESI.Equals(pValor.ToUpper.Trim)
    End Function
    ''' <summary>
    ''' Compara dos cadenas e indica si son iguales. quita espacios e ignora mayusculas y minusculas.
    ''' </summary>
    ''' <param name="pValor"></param>
    ''' <param name="pValorVerdadero"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnStr2Bol(ByVal pValor As String, ByVal pValorVerdadero As String) As Boolean
        Return pValorVerdadero.ToUpper.Trim.Equals(pValor.ToUpper.Trim)
    End Function

End Module
