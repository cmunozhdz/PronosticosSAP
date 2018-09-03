Public Class FrmConsultaProductoVarios
    Public psrClaveProducto As String
    Public pObjProducto As ClassProducto
    Dim mDs As DataSet
    Const CTE_COLSEL = "Selected"
    Private mElementosActivos As String
    

    Private Sub Consultar()

        Try
            
            'Me.SapForecastDataSet.Tables("CONSULTA_PRODUCTO").Columns.Add("Selected", GetType(Boolean))
            
            Dim mta As SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOTableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOTableAdapter
            Dim mDt As SapForecastDataSet.CONSULTA_PRODUCTODataTable = New SapForecastDataSet.CONSULTA_PRODUCTODataTable
            Dim mstrNegocio As String = Me.NegocioCbo.SelectedItem

            If String.IsNullOrEmpty(mstrNegocio) OrElse mstrNegocio.Equals("(Todos)") Then
                mstrNegocio = String.Empty
            Else
                mstrNegocio = Mid(mstrNegocio, 1, 1)

            End If

            mta.Fill(mDt, Me.ClaveTxt.Text, Me.DescCortaTxt.Text, Me.TipoTxt.Text, mstrNegocio, Me.EstadoCbo.SelectedValue)


            If Not mDt.Columns.Contains(CTE_COLSEL) Then
                Dim mcol As DataColumn = mDt.Columns.Add(CTE_COLSEL, GetType(Boolean))
                mcol.ReadOnly = False
                mcol.DefaultValue = True


            End If
           
            mDs = New DataSet

            mDs.Tables.Clear()
            mDs.Tables.Add(mDt)
            Me.CONSULTA_PRODUCTODataGridView.AutoGenerateColumns = False
            Me.CONSULTA_PRODUCTODataGridView.DataSource = mDs
            Me.CONSULTA_PRODUCTODataGridView.DataMember = mDt.TableName
            Me.CONSULTA_PRODUCTODataGridView.Refresh()
        Catch ex As System.Exception
            ModComun.MsgError(ex.Message)

        End Try

    End Sub


    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Hide()

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Consultar()
        Me.TabControl1.SelectTab(1)
    End Sub

    'Private Sub CONSULTA_PRODUCTODataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If e.RowIndex > -1 Then

    '        If Not String.IsNullOrEmpty(CONSULTA_PRODUCTODataGridView.Rows(e.RowIndex).Cells(1).Value.ToString) Then
    '            psrClaveProducto = CONSULTA_PRODUCTODataGridView.Rows(e.RowIndex).Cells(1).Value
    '            pObjProducto = New ClassProducto
    '            With pObjProducto
    '                .Clave = psrClaveProducto
    '                .DescripcionCorta = CONSULTA_PRODUCTODataGridView.Rows(e.RowIndex).Cells(2).Value

    '            End With


    '            Me.DialogResult = Windows.Forms.DialogResult.Yes
    '            Me.Hide()
    '        End If
    '    End If
    'End Sub



   


    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()
        mElementosActivos = String.Empty
    End Sub
    Public Function GetItems() As String
        Return mElementosActivos
    End Function

    


    Private Sub Txt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ClaveTxt.KeyUp, DescCortaTxt.KeyUp, TipoTxt.KeyUp
        If e.KeyCode = Keys.Enter Then
            ' BtnAceptar.PerformClick()
            AceptarBtn.PerformClick()

        End If

    End Sub

    

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        Consultar()
        Me.TabControl1.SelectTab(1)
    End Sub

    Private Sub AceptarBtnTp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtnTp.Click
        Try
            Me.Validate()

            Dim mBolValue As Boolean

            Dim mdsCh As DataSet = mDs.GetChanges(System.Data.DataRowState.Modified)
            Dim mTa As DataTable = mdsCh.Tables(0)
            Dim mBld As System.Text.StringBuilder = New System.Text.StringBuilder


            mElementosActivos = String.Empty
            For Each mRow As DataRow In mTa.Rows
                mBolValue = CType(mRow.Item(CTE_COLSEL), Boolean)
                If mBolValue Then
                    mBld.Append(Trim(mRow.Item("CLAVE")) & ",")
                End If

            Next
            mElementosActivos = mBld.ToString
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Hide()

        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try

    End Sub

    Private Sub CancelBtnTp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtnTp.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Hide()
    End Sub
End Class