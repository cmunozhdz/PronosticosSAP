Public Class FrmImputText
    Public strRespuesta As String
    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        strRespuesta = Trim(Me.TxtBuscar.Text)
        Me.DialogResult = DialogResult.OK
        Me.Hide()


    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()
    End Sub
End Class