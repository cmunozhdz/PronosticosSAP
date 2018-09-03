Imports System.Data.SqlClient

Public Class ConsultarTerritorio
    Public SelectItem As Long

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Try
            'Dim mTa As SapForecastDataSetTableAdapters.CONSULTA_TERRITORIOSBYCLAVETableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_TERRITORIOSBYCLAVETableAdapter
            'Dim mtd As SapForecastDataSet.CONSULTA_TERRITORIOSBYCLAVEDataTable = New SapForecastDataSet.CONSULTA_TERRITORIOSBYCLAVEDataTable
            'mTa.FillByClaveDescripcion(mtd, Trim(Me.ClaveTxt.Text), Trim(Me.DescripcionTxt.Text), Trim(Me.EstadoTxt.Text))

            'With ResultadosDGW
            '    .AutoGenerateColumns = False
            '    .Columns(0).DataPropertyName = "ID"
            '    .Columns(0).Visible = False

            '    .Columns(1).DataPropertyName = "CLAVE"
            '    .Columns(2).DataPropertyName = "DESCRIPCION"
            '    .Columns(3).DataPropertyName = "ESTATUS"
            '    .DataSource = mtd
            'End With
            'mtd = Nothing
            'mTa = Nothing
            'Me.TabControl1.SelectTab(1)



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        


    End Sub

    
    Private Sub ResultadosDGW_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ResultadosDGW.CellMouseClick
        Try
            SelectItem = ResultadosDGW.CurrentCell.OwningRow.Cells(1).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()
    End Sub

    
End Class