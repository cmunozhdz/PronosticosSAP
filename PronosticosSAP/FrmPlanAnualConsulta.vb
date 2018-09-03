Imports System.Data
Imports System.Data.SqlClient

Public Class FrmPlanAnualConsulta
    Dim mItem As ClassItemPronosticos
    Public Sub SetItemConsulta(ByVal pItem As ClassItemPronosticos)
        mItem = pItem
    End Sub
    Public Sub Consultar()
        Try

            If Not IsNothing(mItem) Then
                Dim intRows As Long
                Const CTETABLAORIGEN As String = "Presupuestos"
                Me.AgenteTxt.Text = mItem.Agente.Clave
                Me.ProductoTxt.Text = mItem.Producto.Clave

                Dim PresupuestosDs As DataSet = New DataSet

                'Dim PresupuestosTD As DataTable = PresupuestosDs.Tables.Add("Presupuestos")

                Using mCmd As SqlCommand = New SqlCommand


                    With mCmd
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "PRESUPUESTO.CONSULTABY_AGENTEPRODUCTO"
                        .Parameters.AddWithValue("@AGENTE", mItem.Agente.Clave)
                        .Parameters.AddWithValue("@PRODUCTO", mItem.Producto.Clave)
                        .Parameters.AddWithValue("@FECHA", mItem.Periodo)
                        .Connection = DjpSap.Dac.mConexion

                    End With

                    Dim presupuestosTa As SqlDataAdapter
                    presupuestosTa = New SqlDataAdapter(mCmd)
                    intRows = presupuestosTa.Fill(PresupuestosDs, CTETABLAORIGEN)

                    'presupuestosTa.Fill(PresupuestosTD)
                    If intRows > 0 Then
                        PresupuestoDG.DataSource = PresupuestosDs
                        PresupuestoDG.DataMember = CTETABLAORIGEN
                        Me.MsgStatusLbl.Text = String.Empty
                        FormateaDataGrid()
                    Else
                        PresupuestoDG.Visible = False
                        Me.MsgStatusLbl.Text = "No hay registros"
                    End If
                End Using
            Else
                Me.MsgStatusLbl.Text = "El objecto no se inicializo correctamente"
            End If
        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub RefreshBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.Click
        Consultar()
    End Sub
    Private Sub FormateaDataGrid()
        'Toma el primer item 
        'del pronostico.
        'IDPRONOSTICO
        Dim mLstColumnas As Dictionary(Of String, ClassColumnasGridView) = New Dictionary(Of String, ClassColumnasGridView)
        Dim mColItemFormat As ClassColumnasGridView
        Dim mIdPronostico As Long
        ColumnasAddItem(mLstColumnas, "CLAVE", "IDPRONOSTICO", False, True)
        ColumnasAddItem(mLstColumnas, "AGENTE", "CLAVEAGENTE", False, True)
        ColumnasAddItem(mLstColumnas, "CLAVEZONA", "CLAVEZONA", False, True)
        ColumnasAddItem(mLstColumnas, "CENTRO", "CLAVECENTRO", False, True)
        ColumnasAddItem(mLstColumnas, "NO MATERIAL", "CLAVEPRODUCTO", False, True)
        ColumnasAddItem(mLstColumnas, "PRODUCTO", "DESCPRODUCTO", False, True)
        ColumnasAddItem(mLstColumnas, "UNIDADMEDIDABASE", "UNIDADMEDIDABASE", False, True)
        ColumnasAddItem(mLstColumnas, "UNIDADMEDIDAALTERNA", "UNIDADMEDIDAALTERNA", False, True)
        ColumnasAddItem(mLstColumnas, "CANTIDADEXACTA", "CANTIDADEXACTA", False, True)
        ColumnasAddItem(mLstColumnas, "FACTOR", "FACTOR", False, True)
        ColumnasAddItem(mLstColumnas, "OPERADOR", "OPERADOR", False, True)
        ColumnasAddItem(mLstColumnas, "CLAVECLIENTE", "CLAVECLIENTE", False, True)
        ColumnasAddItem(mLstColumnas, "RAZONSOCIAL", "RAZONSOCIAL", False, True)
        ColumnasAddItem(mLstColumnas, "MAXPER", "MAXPER", False, True)

        If Me.PresupuestoDG.RowCount > 0 Then
            For Each mCol As DataGridViewColumn In Me.PresupuestoDG.Columns
                If mCol.DataPropertyName = "IDPRONOSTICO" Then

                    With Me.PresupuestoDG.Rows(0).Cells(mCol.Index)
                        If IsDBNull(.Value) Then
                            mIdPronostico = 0
                        Else
                            Long.TryParse(.Value, mIdPronostico)
                        End If
                    End With
                    Exit For
                End If
            Next





            Dim mColDef As PronosticosSAP.ClassColumnasGridView

            Dim mCon As SqlCommand = New SqlCommand
            Using mCon
                mCon.Connection = DjpSap.Dac.mConexion()
                mCon.CommandType = CommandType.StoredProcedure
                mCon.CommandText = "PRESUPUESTO.CONSULTA_PERIODOS"



                mCon.Parameters.AddWithValue("@IDPRESUPUESTO", mIdPronostico) 'Toma la clave del 

                Dim mRdr As SqlDataReader = mCon.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If mRdr.HasRows Then
                    While mRdr.Read()

                        Dim mHdrFecha As String = UCase(String.Format("{0:MMM-yyyy}", mRdr("DTFECHAINICIO")))
                        Dim mHdrClave As String = "BASE_" & Trim(mRdr("IDPERIODO"))

                        mColDef = ColumnasAddItem(mLstColumnas, mHdrFecha, mHdrClave, True, False)
                        mColDef.Formato = "###,###0.00"

                        mHdrClave = UCase("ALTERNA_" & Trim(mRdr("IDPERIODO")))
                        mColDef = ColumnasAddItem(mLstColumnas, mHdrFecha, mHdrClave, False, False)
                        mColDef.Formato = "###,###0.00"

                    End While



                End If

                mCon = Nothing

            End Using
        End If



        For Each mCol As DataGridViewColumn In Me.PresupuestoDG.Columns

            If mLstColumnas.ContainsKey(mCol.DataPropertyName) Then
                mColItemFormat = mLstColumnas(mCol.DataPropertyName)
                mCol.HeaderText = mColItemFormat.Header
                mCol.Visible = mColItemFormat.Visible
                mCol.Frozen = mColItemFormat.Frozen
                mCol.DefaultCellStyle.Format = mColItemFormat.Formato


            End If
        Next





    End Sub
    Public Function ColumnasAddItem(ByRef mLstColumnas As Dictionary(Of String, ClassColumnasGridView), ByVal Header As String, ByVal Clave As String, ByVal Visible As Boolean, ByVal Frozen As Boolean) As ClassColumnasGridView

        Dim mColumna As ClassColumnasGridView
        mColumna = New ClassColumnasGridView(Header, Clave, Visible, Frozen)
        mLstColumnas.Add(Clave, mColumna)
        Return mColumna


    End Function



End Class