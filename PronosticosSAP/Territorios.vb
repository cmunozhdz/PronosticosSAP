Public Class TerritoriosForm
    Private pUniqeIdTerrirorio As Long
    Private pStrStatusAnterior As String

    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        pUniqeIdTerrirorio = 0
        pStrStatusAnterior = "A"
        With Me.ClaveTxt
            .Text = String.Empty
            .Enabled = True
            .Focus()
            .SelectionStart = 0
            .SelectionLength = .MaxLength


        End With


        Me.DescripcionTxt.Text = String.Empty
        Me.ActivoCbo.SelectedIndex = 0
        Me.GuardarToolStripButton.Enabled = True





    End Sub

    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        AbrirItem()
    End Sub

    Private Sub Mensajes(ByVal pstrMensaje As String, ByVal bolShowDialog As Boolean)
        Dim mParent As MDIPronosticos = Me.MdiParent
        'Dim mStrMensaje As String = "El campo debe ser numerico"
        mParent.StatusLbl.Text = pstrMensaje


        'MsgBox(mStrMensaje)
        If bolShowDialog Then
            MsgBox(pstrMensaje, MsgBoxStyle.Information, "Territorios")
        End If

    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        'Valida los controles
        If IsNumeric(Me.ClaveTxt.Text) = False Then
            Me.Mensajes("La clave es un dato obligatorio o debe ser un valor numérico", False)
            Me.ClaveTxt.Focus()
            'Me.ClaveTxt.SelectedText = Len(Me.ClaveTxt.Text)

            Exit Sub


        End If
        If String.IsNullOrEmpty(Trim(Me.DescripcionTxt.Text)) Then
            Me.Mensajes("La Descripcion es un dato obligatorio", False)

            Exit Sub

        End If
        Dim mArrList As ArrayList = New ArrayList
        mArrList.Add("A")
        mArrList.Add("I")
        If mArrList.Contains(Mid(Me.ActivoCbo.SelectedItem, 1, 1)) = False Then
            Me.Mensajes("Estado tiene una valor invalido", False)
        End If
        




        Dim mTerritorio As ClassTerritorios = New ClassTerritorios(Me.ClaveTxt.Text, Me.DescripcionTxt.Text, Mid(Me.ActivoCbo.SelectedItem, 1, 1))
        Dim mBolStatus As Boolean

        mTerritorio.Id = pUniqeIdTerrirorio
        If mTerritorio.Id <> 0 Then
            mBolStatus = mTerritorio.Actualizar(pStrStatusAnterior)



        Else
            mBolStatus = mTerritorio.Insertar()

        End If
        pUniqeIdTerrirorio = mTerritorio.Id
        pStrStatusAnterior = mTerritorio.Status



        If mBolStatus Then
            Me.ClaveTxt.Enabled = False
            Me.Mensajes("Actualizado", True)

        Else
            Me.Mensajes(mTerritorio.EstatusProceso, True)

        End If



    End Sub

    
    Private Sub ConsultaBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaBtn.Click
        Dim mForm As ConsultarTerritorio = New ConsultarTerritorio
        If mForm.ShowDialog() = DialogResult.OK Then
            Me.ClaveTxt.Text = mForm.SelectItem
            AbrirItem()


        End If
        mForm.Dispose()




    End Sub
    Private Sub AbrirItem()
        Dim mTerritorio As New ClassTerritorios
        Dim idClave As Long

        'Dim mTerritorio As New ClassTerritorios(Me.ClaveTxt.Text, String.Empty, String.Empty)


        Dim mIDx As Long
        Try
            If Long.TryParse(Me.ClaveTxt.Text, idClave) Then

                Me.ClaveErrorProvider.SetError(Me.ClaveTxt, String.Empty)

                mTerritorio.Consultar(Me.ClaveTxt.Text)
                pUniqeIdTerrirorio = mTerritorio.Id

                If String.IsNullOrWhiteSpace(mTerritorio.EstatusProceso) Then
                    With mTerritorio
                        Me.ClaveTxt.Text = mTerritorio.Clave
                        Me.ClaveTxt.Enabled = False
                        Me.DescripcionTxt.Text = mTerritorio.Descripcion
                        mIDx = -1
                        pStrStatusAnterior = mTerritorio.Status

                        For mItem = 0 To ActivoCbo.Items.Count - 1
                            If ActivoCbo.Items(mItem).ToString().Substring(0, 1) = mTerritorio.Status Then
                                mIDx = mItem
                                Exit For

                            End If

                        Next
                        Me.ActivoCbo.SelectedIndex = mIDx


                    End With
                    Me.GuardarToolStripButton.Enabled = True

                Else
                    Me.GuardarToolStripButton.Enabled = False
                    'Me.ClaveErrorProvider.SetError(Me.ClaveTxt, "El dato debe ser numérico")

                    Me.Mensajes(mTerritorio.EstatusProceso, False)





                End If

            Else
                Me.ClaveErrorProvider.SetError(Me.ClaveTxt, "El dato debe ser numérico")
                Mensajes("El campo debe ser numérico", False)






            End If

        Catch ex As Exception

            Me.GuardarToolStripButton.Enabled = False
            Mensajes(ex.Message, False)




        End Try
    End Sub
End Class