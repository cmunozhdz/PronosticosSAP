Public Class VendedoresForm
    Private mObjVendedor As ClassVendedor
    Private mColStatus As System.Collections.Generic.List(Of DjpSap.ClassEstatus)



    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With Me
            .ClaveTxt.Text = String.Empty

        End With
        mObjVendedor = New ClassVendedor

    End Sub

    Private Sub VendedoresForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated


    End Sub

    Private Sub VendedoresForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mObjStatus As DjpSap.ClassEstatus
        mObjStatus = New DjpSap.ClassEstatus
        mObjStatus.Clave = "A"
        mObjStatus.Descripcion = "Activo"
        mColStatus = New System.Collections.Generic.List(Of DjpSap.ClassEstatus)
        mColStatus.Add(mObjStatus)

        mObjStatus = New DjpSap.ClassEstatus
        mObjStatus.Clave = "I"
        mObjStatus.Descripcion = "Inactivo"
        mColStatus.Add(mObjStatus)

        For Each mObjStatus In mColStatus
            Me.EstadoCbo.Items.Add(mObjStatus.Clave & ":" & mObjStatus.Descripcion)
        Next
        mObjVendedor = New ClassVendedor




    End Sub

    
    Private Sub BuscarTerritorioBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarTerritorioBtn.Click
        Dim mForm As ConsultarTerritorio = New ConsultarTerritorio
        mForm.ShowDialog(Me)
        If mForm.DialogResult = DialogResult.OK Then
            TerritorioTxt.Text = mForm.SelectItem
        Else
            TerritorioTxt.Text = String.Empty
        End If
        mForm.Dispose()

    End Sub

    Private Sub NuevoToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        mObjVendedor = New ClassVendedor()


        With Me.ClaveTxt
            .Enabled = True
            .Text = String.Empty

        End With
        Me.DescripcionTxt.Text = String.Empty
        Me.TerritorioTxt.Text = String.Empty

        Me.EstadoCbo.SelectedIndex = 0



    End Sub

    Private Sub AbrirToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        Try
            If IsNumeric(Me.ClaveTxt.Text) Then

                VendedorErrProvider.Clear()

                mObjVendedor = New ClassVendedor
                mObjVendedor.Clave = Me.ClaveTxt.Text
                Dim intProceso = mObjVendedor.ConsultarCatalogo()



                Select Case intProceso
                    Case 0 'El registro no existe
                        MsgBox("El registro No Existe", MsgBoxStyle.Exclamation)
                        Me.ClaveTxt.Enabled = True
                        Me.TerritorioTxt.Text = String.Empty
                        Me.EstadoCbo.SelectedIndex = -1
                        Me.TerritorioLbl.Text = String.Empty





                    Case 1
                        With mObjVendedor
                            Me.ClaveTxt.Text = .Clave
                            Me.ClaveTxt.Enabled = False
                            Me.DescripcionTxt.Text = .Descripcion
                            Me.TerritorioTxt.Text = .Territorio.Clave
                            .Territorio.Consultar(.Territorio.Clave)
                            Me.TerritorioLbl.Text = .Territorio.Descripcion

                            Dim mIndex As Integer = -1
                            Dim mBolFound As Boolean = False

                            For Each mObjStatus In mColStatus
                                mIndex = mIndex + 1
                                If mObjStatus.Clave = .Estado Then
                                    mBolFound = True
                                    Exit For

                                End If

                            Next
                            If mBolFound Then
                                EstadoCbo.SelectedIndex = mIndex
                            Else
                                EstadoCbo.SelectedIndex = -1
                            End If
                        End With


                    Case 3
                        'Existe un error en el proceso
                        MsgBox(mObjVendedor.EstatusProceso, MsgBoxStyle.Exclamation)
                        Me.ClaveTxt.Enabled = True

                End Select
            Else
                VendedorErrProvider.SetError(Me.ClaveTxt, "El almacen debe ser un dato numerico")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
        


    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        Try
            'Valida los controles
            Dim mbolProceso As Boolean
            VendedorErrProvider.Clear()

            If IsNumeric(Me.ClaveTxt.Text) = False Then

                VendedorErrProvider.SetError(Me.ClaveTxt, "El debe ser un dato numerico")
                Exit Sub
            End If
            If Trim(Me.DescripcionTxt.Text) = String.Empty Then
                VendedorErrProvider.SetError(Me.DescripcionTxt, "Dato obligatorio")
                Exit Sub
            End If

            If EstadoCbo.SelectedIndex = -1 Then
                VendedorErrProvider.SetError(Me.EstadoCbo, "Indique un estado correcto")
                Exit Sub

            End If
            If Trim(TerritorioTxt.Text) = String.Empty Then
                VendedorErrProvider.SetError(Me.TerritorioTxt, "El territorio es obligatorio")
                Exit Sub
            Else
                'Valida que el territorio exista y este activo en caso de no estarlo marcara error.
                'mObjVendedor.Territorio.Clave = TerritorioTxt.Text
                'Verifica que el territorio exita
                mObjVendedor.Territorio.Consultar(TerritorioTxt.Text)
                If mObjVendedor.Territorio.Status <> "A" Then
                    If MsgBox("El territorio esta inactivo, esta seguro de guardar ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Agentes") = MsgBoxResult.No Then
                        Exit Sub
                    End If

                End If



            End If
            'Los datos han sido validados procede a guardar.
            With mObjVendedor
                .Clave = Me.ClaveTxt.Text
                .Descripcion = Me.DescripcionTxt.Text
                .Estado = mColStatus(Me.EstadoCbo.SelectedIndex).Clave
                .Territorio.Clave = Me.TerritorioTxt.Text
            End With
            If mObjVendedor.Id = 0 Then

                mbolProceso = mObjVendedor.Insertar()
            Else
                mbolProceso = mObjVendedor.Actualizar()

            End If
            If mbolProceso Then
                Me.ClaveTxt.Enabled = False
                mObjVendedor.Territorio.Consultar(Me.TerritorioTxt.Text)
                TerritorioLbl.Text = mObjVendedor.Territorio.Descripcion
                MsgBox("Actualizado", MsgBoxStyle.Exclamation)
            Else
                MsgBox("El producto no se pudo actualizar causa:" & mObjVendedor.EstatusProceso)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        

    End Sub
End Class
