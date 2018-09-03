Imports System.Collections.Generic
Imports System.Data.SqlClient

Public Class FormZonas
    Private Enum enTipoAccion
        enInicializar = 0
        enNuevo = 1
        enAbrir = 2
        enError = 3

    End Enum
    Dim mlstEstados As List(Of DjpSap.ClassEstatus)
    Dim mAccion As enTipoAccion


    Private Sub FormZonas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mAccion = enTipoAccion.enInicializar


            mlstEstados = New List(Of DjpSap.ClassEstatus)
            Dim mObj As DjpSap.ClassEstatus = New DjpSap.ClassEstatus

            mObj.Clave = "A"
            mObj.Descripcion = "ACTIVO"
            mlstEstados.Add(mObj)
            mObj = New DjpSap.ClassEstatus


            mObj.Clave = "I"
            mObj.Descripcion = "INACTIVO"
            mlstEstados.Add(mObj)

            For Each mObj In mlstEstados
                CboStatus.Items.Add(mObj.Descripcion)
            Next

            Me.CONSULTA_ESTADOGEOGRAFICOBYCLAVETableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_ESTADOGEOGRAFICOBYCLAVE, String.Empty, "A")
        Catch ex As Exception

            Mensajes(ex.Message)

        End Try


    End Sub

    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        'Busca la zona 
        Try
            If Me.ValidarFormulario("A") Then
                Me.Consultar(Me.CLAVETextBox.Text)
            End If

        Catch ex As System.Exception

            Mensajes(ex.Message)
            mAccion = enTipoAccion.enError
        End Try

    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click

        Dim mSlTran As SqlTransaction = Nothing
        Try


            If Me.ValidarFormulario("G") Then
                Me.Validate()
                Select Case mAccion
                    Case enTipoAccion.enNuevo
                        Dim mConexion As SqlConnection = DjpSap.Dac.mConexion
                        Dim mCmd As SqlCommand = New SqlCommand
                        Dim mParExe As SqlParameter = New SqlParameter()


                        mCmd.CommandType = System.Data.CommandType.StoredProcedure
                        mCmd.CommandText = "CATALOGOS.INSERTAZONA"
                        mParExe.Direction = System.Data.ParameterDirection.ReturnValue
                        mCmd.Parameters.Add(mParExe)
                        mCmd.Parameters.AddWithValue("@CLAVE", Me.CLAVETextBox.Text)
                        mCmd.Parameters.AddWithValue("@DESCRIPCION", Me.DESCRIPCIONTextBox.Text)
                        mCmd.Parameters.AddWithValue("@ESTATUS", Me.CboStatus.SelectedValue)
                        mCmd.ExecuteNonQuery()
                        If mParExe.Value < 0 Then
                            Me.MensajesExclamacion("El registro no pudo ser actualizado")
                        Else
                            Me.ZonaMsgTLS.Text = "Encabezado actualizado correctemente."
                        End If
                    Case enTipoAccion.enAbrir

                        Me.Validate() 'Forza que el cursor activo sea validado
                        Me.CONSULTA_ZONASBYCLAVEBindingSource.EndEdit() 'Acepta los cambios del data source de la cabecera
                        Me.CONSULTAESTADOBYZONABindingSource.EndEdit() 'Acepta los cambio del data source del grid

                        If Me.SapForecastDataSet.HasChanges() Then
                            



                            Dim mStr As System.Text.StringBuilder = New System.Text.StringBuilder
                            

                            Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter.Update(Me.SapForecastDataSet)

                            Dim mEstados As SapForecastDataSet.CONSULTAESTADOBYZONADataTable = Me.SapForecastDataSet.CONSULTAESTADOBYZONA

                            For Each mRow As DataRow In mEstados.Rows

                                Select Case mRow.RowState
                                    Case DataRowState.Modified

                                        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter.Update(mRow)
                                    Case DataRowState.Added
                                        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter.Insert( _
                                                                                mRow.Item("CLAVEZONA").ToString, _
                                                                                mRow.Item("CLAVEESTADO").ToString(), _
                                                                                mRow.Item("ESTATUS").ToString())

                                End Select

                            Next


                            
                            Me.ZonaMsgTLS.Text = mStr.ToString()
                            Me.Consultar(Me.CLAVETextBox.Text)
                            Me.Mensajes("Registro Actualizado")


                            Exit Sub
                        End If

                    Case enTipoAccion.enError
                        Mensajes("El estado del proceso es invalido, intente generar un registro nuevo o editar uno existente")

                End Select







            End If
        Catch ex1 As SqlException
            If IsNothing(mSlTran) = False Then
                If IsNothing(mSlTran.Connection) Then
                    mSlTran.Rollback()
                End If

                mSlTran.Dispose()


            End If
        Catch ex As Exception

            Me.ZonaMsgTLS.Text = ex.Message

        End Try

    End Sub
    Private Function ValidarFormulario(ByVal pstrAccion As String) As Boolean
        ZonaErrProvider.Clear()
        ValidarFormulario = True
        Dim mstrError As String

        Select Case pstrAccion

            Case "A"
                'Inicia validaciom de consulta

                If String.IsNullOrEmpty(Me.CLAVETextBox.Text) Then
                    mstrError = "Clave Dato obligatorio"
                    ZonaErrProvider.SetError(Me.CLAVETextBox, mstrError)
                    Me.ZonaMsgTLS.Text = mstrError
                    ValidarFormulario = False
                Else
                    ZonaErrProvider.Clear()

                End If

            Case "G"
                mstrError = "Clave Dato obligatorio"
                If String.IsNullOrEmpty(Me.CLAVETextBox.Text) Then
                    ZonaErrProvider.SetError(Me.CLAVETextBox, mstrError)
                    Me.ZonaMsgTLS.Text = mstrError
                    ValidarFormulario = False
                    Exit Function
                End If

                If String.IsNullOrEmpty(Me.DESCRIPCIONTextBox.Text) Then
                    mstrError = "Descripción Dato Obligatorio"
                    ZonaErrProvider.SetError(Me.DESCRIPCIONTextBox, mstrError)
                    Me.ZonaMsgTLS.Text = mstrError
                    ValidarFormulario = False
                    Exit Function
                End If

                If Me.CboStatus.SelectedIndex = -1 Then
                    mstrError = "Estado Invalido"
                    ZonaErrProvider.SetError(Me.CboStatus, mstrError)
                    ZonaMsgTLS.Text =
                    ValidarFormulario = False
                    Exit Function
                End If
            Case Else
                ValidarFormulario = False
        End Select

    End Function


    Private Sub NuevoToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        Try
            Me.CLAVETextBox.Text = String.Empty
            Me.CLAVETextBox.Enabled = True
            Me.DESCRIPCIONTextBox.Text = ""
            Me.SapForecastDataSet.CONSULTA_ZONASBYCLAVE.Clear()
            Me.CLAVETextBox.Focus()
            mAccion = enTipoAccion.enNuevo

        Catch ex As Exception
            MensajesExclamacion(ex.Message)

        End Try



    End Sub
    Private Sub Mensajes(ByVal pstrMensaje As String)
        System.Windows.Forms.MessageBox.Show(pstrMensaje, "Pronosticos Sap", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub MensajesExclamacion(ByVal pstrMensaje As String)
        System.Windows.Forms.MessageBox.Show(pstrMensaje, "Pronosticos Sap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    Private Sub Consultar(ByVal pstrClave As String)
        Dim mstrTmp = UCase(pstrClave)

        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_ZONASBYCLAVE, mstrTmp)

        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter.Fill(Me.SapForecastDataSet.CONSULTAESTADOBYZONA, mstrTmp, String.Empty, String.Empty, String.Empty)

        'Me.CONSULTAESTADOBYZONADataGridView.DataSource = Me.SapForecastDataSet.CONSULTAESTADOBYZONA



        If Me.SapForecastDataSet.CONSULTA_ZONASBYCLAVE.Rows.Count > 0 Then
            Me.CLAVETextBox.Enabled = False

            For Each mDataRow As DataRow In Me.SapForecastDataSet.CONSULTA_ZONASBYCLAVE.Rows
                Dim mIdx As Integer
                For mIdx = 0 To mlstEstados.Count - 1
                    If mlstEstados(mIdx).Clave = mDataRow.Item("ESTATUS") Then
                        Me.CboStatus.SelectedIndex = mIdx
                        mAccion = enTipoAccion.enAbrir

                        Exit Sub
                    End If

                Next
                Me.CboStatus.SelectedIndex = -1 'El objeto no existe


            Next

            mAccion = enTipoAccion.enInicializar

        Else
            Me.CLAVETextBox.Enabled = True
            Me.CLAVETextBox.Text = mstrTmp
            Me.ZonaMsgTLS.Text = "Registro Inexistente"

            MensajesExclamacion("Registro Inexistente")
            mAccion = enTipoAccion.enError
        End If

    End Sub

    Private Sub CONSULTAESTADOBYZONADataGridView_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles CONSULTAESTADOBYZONADataGridView.DefaultValuesNeeded


        With e.Row
            '.Cells("colId").Value = 0
            'If .Cells("colId").Value < 0 Then
            'lOS REGISTROS SON NUEVOS
            .Cells("colClaveZona").Value = Me.CLAVETextBox.Text
            Dim mRow As DataRowView = Me.colEstadoCliente.Items(Me.colEstadoCliente.DisplayIndex)
            Dim mStrTmpo As String = mRow.Row(colEstadoCliente.ValueMember).ToString()

            .Cells("colClaveEstado").Value = mStrTmpo
            Me.ZonaMsgTLS.Text = mRow.Row(colEstadoCliente.DisplayMember).ToString()
            .Cells("colEstatus").Value = "A"


            'End If





        End With

    End Sub




    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        Dim mForm As FormZonasConsulta

        mForm = New FormZonasConsulta
        If mForm.ShowDialog() = DialogResult.OK Then

            Me.Consultar(mForm.pClaveZona)
        End If
        mForm.Dispose()



    End Sub

    Private Sub CboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboStatus.SelectedIndexChanged
        If CboStatus.SelectedIndex > -1 Then
            Me.TxtEstatus.Text = mlstEstados.Item(CboStatus.SelectedIndex).Clave

        End If
    End Sub
End Class