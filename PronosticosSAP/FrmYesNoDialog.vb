Public Class FrmYesNoDialog
    Private CTE_ACEPTAR = "AceptarBtn"
    Private Sub Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click, AceptarBtn.Click
        Dim mBtn As System.Windows.Forms.Button = CType(sender, System.Windows.Forms.Button)
        If mBtn.Name.ToString.Equals(CTE_ACEPTAR) Then
            Me.DialogResult = DialogResult.Yes
        Else
            Me.DialogResult = DialogResult.No
        End If

    End Sub


    'Private Sub FrmYesNoDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.DialogResult = DialogResult.No
    'End Sub

    Public Sub Inicializar(ByVal pstrMensaje As String, ByVal pDefaulButtonYes As Boolean)
        Me.MensajeLbl.Text = pstrMensaje
        If pDefaulButtonYes Then

            AceptarBtn.Focus()
        Else
            CancelarBtn.Focus()
        End If
    End Sub

End Class