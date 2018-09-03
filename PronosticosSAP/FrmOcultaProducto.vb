Imports System.Data.SqlClient

Public Class FrmOcultaProducto
#Region "Custom"
    Dim PIdPronostico As Long
    Dim mCon As System.Data.SqlClient.SqlConnection
    Dim mDs As DataSet
    Dim mSqlDataAdapter As SqlDataAdapter
    ''' <summary>
    ''' Establece la conexion a Sql por procesar.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SetConexion() As Boolean
        Try
            mCon = DjpSap.Dac.mConexion()
            Return True
        Catch ex As Exception
            StatusLbl.Text = "Error al establecer conexion de base de datos:" & ex.Message
            Return False

        End Try


    End Function
    ''' <summary>
    ''' Consulta  la informacion del disco y estabece el Stored Procedure que guardará los cambios.
    ''' </summary>
    ''' <param name="pId">No. Pronostico</param>
    ''' <remarks></remarks>
    Public Sub Consultar(pId As Long)
        Try
            If pId > 0 Then
                If SetConexion() Then
                    mDs = New DataSet

                    mSqlDataAdapter = New SqlDataAdapter()

                    Dim mCmd As New System.Data.SqlClient.SqlCommand


                    With mCmd
                        .Connection = mCon
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "PRONOSTICOS.GET_PRODUCTOSOCULTOS"

                        .Parameters.AddWithValue("@IDPRONOSTICO", pId) 'NoPronosticoTxt.Text
                    End With



                    mSqlDataAdapter.SelectCommand = mCmd

                    Dim mCmdUpdate As New SqlCommand
                    Dim pPronostico = New SqlParameter("@IDPRONOSTICO", SqlDbType.Int)
                    pPronostico.Value = pId

                    Dim pProducto = New SqlParameter("@CLAVEPRODUCTO", SqlDbType.Char, 10, "CLAVE")
                    Dim pStatus = New SqlParameter("@PROD_OCULTO", SqlDbType.Bit)
                    pStatus.SourceColumn = "OCULTO"
                    pStatus.SourceVersion = DataRowVersion.Current

                    With mCmdUpdate
                        .CommandText = "PRONOSTICOS.SET_PRODUCTOOCULTO"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = mCon

                        .Parameters.Add(pPronostico)
                        .Parameters.Add(pProducto)
                        .Parameters.Add(pStatus)

                    End With
                    mSqlDataAdapter.UpdateCommand = mCmdUpdate

                    mSqlDataAdapter.Fill(mDs)

                    GridProductos.DataSource = mDs
                    GridProductos.DataMember = mDs.Tables(0).TableName

                    GridProductos.Refresh()
                    ' mDs.AcceptChanges()


                    PIdPronostico = pId
                End If
                

            Else
                StatusLbl.Text = "Seleccione un Pronostico Valido"


            End If

        Catch ex As Exception
            StatusLbl.Text = ex.Message

        Finally
            If Not mCon Is Nothing AndAlso mCon.State = ConnectionState.Open Then
                mCon.Close()

            End If
            mCon = Nothing


        End Try

    End Sub

#End Region
    ''' <summary>
    ''' Consulta la informacion den disco
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub AbrirToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles AbrirToolStripButton.Click
        Consultar(PIdPronostico)

    End Sub

    Private Sub FrmOcultaProducto_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Not mCon Is Nothing AndAlso mCon.State = ConnectionState.Open Then
                mCon.Close()

            End If
            mCon = Nothing

        Catch ex As Exception
            ''Se provoca una excepcion no controlada.
        End Try
    End Sub
    ''' <summary>
    ''' Establece el tamaño por defautlt.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FrmOcultaProducto_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Height = 300
        Me.Width = 600
    End Sub

    ''' <summary>
    ''' Guarda en la base de datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GuardarToolStripButton_Click(sender As Object, e As System.EventArgs) Handles GuardarToolStripButton.Click
        Try

            If GridProductos.IsCurrentCellDirty Then
                MsgError("Confirme la edicion de la celda actual")
                Exit Sub

            End If

            Me.StatusLbl.Text = String.Format("Iniciando proceso de guardado")
            'Dim mDt As DataTable = mDs.Tables("PRODUCTOS")
            mSqlDataAdapter.Update(mDs)
            mDs.AcceptChanges()
            Me.StatusLbl.Text = String.Format("Finalizado")
            Me.Close()


        Catch ex As Exception
            Me.StatusLbl.Text = ex.Message

        End Try


    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()

    End Sub
End Class