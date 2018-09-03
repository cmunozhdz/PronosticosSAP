Public Class FrmAddCteManual
    Private strAgente As String
    'Establece el valor del agente Seleccionado
    ''' <summary>
    ''' Agrega un Registro nuevo al dataset definiendo los datos por default sobre todo en lo campos
    ''' que no aceptan nulos.
    ''' </summary>
    ''' <param name="pValue">Clave del empleado asignado.</param>
    ''' <param name="mrowView">Nothing</param>
    ''' <remarks></remarks>
    Public Sub SetAgente(ByVal pValue As String, ByVal mrowView As DataRowView)

        strAgente = pValue
        'Dim mrowView As DataRowView = Me.CONSULTA_CLIENTESBindingSource.AddNew()
        If IsNothing(mrowView) Then mrowView = Me.CONSULTA_CLIENTESBindingSource.AddNew()
        mrowView("FECHAACTUALIZACION") = Today
        mrowView("VIGENCIA") = #12/31/2099#
        mrowView("CLAVEAGENTE") = pValue
        mrowView("CHR_ORIGEN") = "M"



    End Sub


    Private Sub CONSULTA_CLIENTESBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CONSULTA_CLIENTESBindingNavigatorSaveItem.Click
        Try

            If Me.Validate() Then
                If Me.SapForecastDataSet.HasChanges = False Then
                    Me.CONSULTA_CLIENTESBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.SapForecastDataSet)
                    ModComun.MsgInfo("Se han guardado los cambios solicitados")
                Else
                    ModComun.MsgInfo("No se han encontrado cambios por guardar")
                End If
                
            End If
        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try

    End Sub
    ''' <summary>
    ''' Busca los clientes en sap que son distribuidores por lo tanto en sap tienen una clave de vendedor
    ''' Pero lo pronostica otra persona.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Dim mSociedad As Nullable(Of Integer)

            Dim mCliente As Nullable(Of Integer)

            If IsNumeric(CVESOCIEDADToolStripTextBox.Text) Then
                mSociedad = CType(CVESOCIEDADToolStripTextBox.Text, Integer)
            Else
                mSociedad = Nothing
            End If
            If IsNumeric(CVECLIENTEToolStripTextBox.Text) Then
                mCliente = CType(CVECLIENTEToolStripTextBox.Text, Integer)
            Else

                mCliente = Nothing
            End If

            Me.CONSULTA_CLIENTESTableAdapter.FillByDistribuidor(Me.SapForecastDataSet.CONSULTA_CLIENTES, mSociedad, mCliente, RAZONSOCIALToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

   

    ''' <summary>
    ''' metodo de adicion personalizado, incializando datos por defecto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        SetAgente(strAgente, Nothing)
        Me.CONSULTA_CLIENTESBindingSource.ResetBindings(False)

    End Sub

    Private Sub FrmAddCteManual_HelpRequested(sender As Object, hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested
        ModComun.ShowHelpAppByTopicId(Me, Me.HelpProvider.Tag)

    End Sub

    Private Sub FrmAddCteManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    


    Private Sub NumericTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SOCIEDADTextBox.Validating, CLAVECLIENTETextBox.Validating
        Dim mTxt As TextBox = CType(sender, TextBox)
        If Not IsNumeric(mTxt.Text) Then
            Me.ErrorProvider.SetError(mTxt, "El Campo debe ser un valor numérico")
            e.Cancel = True
        End If

    End Sub
End Class