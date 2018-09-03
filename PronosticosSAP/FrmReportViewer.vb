Public Class FrmReportViewer

    Private Sub FrmReportViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    

    End Sub
    Public Sub FillReport(ByVal IdPronostico As Integer)
        Try
            Dim mDt As DataTable = New SapForecastDataSet.CONSULTA_DETALLEPRONOSTICOS_RPTDataTable
            Dim mta As SapForecastDataSetTableAdapters.CONSULTA_DETALLEPRONOSTICOS_RPTTableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_DETALLEPRONOSTICOS_RPTTableAdapter
            mta.Fill(mDt, IdPronostico)
            Dim mRpt As New PronosticoDetalle
            mRpt.SetDataSource(mDt)
            Me.CrystalReportViewer1.ReportSource = mRpt
        Catch ex As Exception
            MsgBox(ex)

        End Try
        

    End Sub

End Class