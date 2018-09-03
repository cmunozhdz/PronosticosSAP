Public Class FrmConsultaCentro
    Private mObjCentro As ClassCentro
    ''' <summary>
    ''' Devuelve el objeto Centro Seleccionado.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SelectedItem() As ClassCentro
        Get
            Return mObjCentro
        End Get
    End Property

    Private Sub CentrosDG_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CentrosDG.CellClick
        If e.RowIndex > -1 And e.ColumnIndex > -1 Then
            mObjCentro = New ClassCentro(CentrosDG.Rows(e.RowIndex).Cells("CLAVECENTROCELL").Value.ToString())
            With mObjCentro
                .Descripcion = CentrosDG.Rows(e.RowIndex).Cells("DESCRIPCIONCell").Value.ToString()
                .Sociedad = CentrosDG.Rows(e.RowIndex).Cells("CLAVESOCIEDADCell").Value.ToString()
            End With
            'mObjCentro.Descripcion = CentrosDG.Rows(e.RowIndex).Cells("DESCRIPCIONCell").Value.ToString()
            Me.Hide()
            Me.DialogResult = ModComun.FORMDIALOG
        End If


    End Sub



   
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try

            Me.GETCENTROBYVARIOSTableAdapter.Fill(Me.SapForecastDataSet.GETCENTROBYVARIOS, Me.SociedadTxt.Text, Me.CentroTxt.Text, Me.DescripcionTxt.Text)
            Me.GETCENTROBYVARIOSBindingSource.ResetBindings(False)

            Me.TabControl1.SelectedTab = Me.TabPage2

        Catch ex As Exception
            ModComun.MsgError(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()

    End Sub

    Public Sub Incializar(pCentro As String)
        mObjCentro = New ClassCentro(pCentro)
        'mObjCentro.Clave = pCentro
        Me.CentroTxt.Text = pCentro
    End Sub

    
End Class