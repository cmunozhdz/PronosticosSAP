Imports System.Data.SqlClient
Public Class FrmAddProductosPronosticoByCliente
    Private Const AREA_INDUSTRIAL As String = "I"
    Private mDst As DataSet
    Private IdPronostico As Integer
    Private mAgente As ClassVendedor
    Public Sub Inicializar(ByVal pAgente As ClassVendedor, ByVal pIdPronostico As Integer)
        mAgente = pAgente
        Me.AgenteTxt.Text = pAgente.Clave
        Me.AgenteTxt.Enabled = False

        TabControl1.SelectedTab = ParametrosTab
        IdPronostico = pIdPronostico
        Me.ClienteTxt.Enabled = pAgente.AreaNegocios.Equals(AREA_INDUSTRIAL) 'Solo los clientes industriales pueden indicar un cliente.
        Me.CteBtn.Enabled = False

    End Sub


    Private Sub AbrirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripButton.Click
        Try
            Dim mStrDataMember As String

            AddErrProvider.Clear()

            If String.IsNullOrEmpty(Me.AgenteTxt.Text) = False AndAlso
                Not IsNumeric(Me.AgenteTxt.Text) Then
                AddErrProvider.SetError(Me.AgenteTxt, "La clave del agente debe ser numerico")
                Exit Sub
            End If

            If String.IsNullOrEmpty(Me.ProductoTxt.Text) = False AndAlso
                Not IsNumeric(Me.ProductoTxt.Text) Then
                AddErrProvider.SetError(Me.ProductoTxt, "La clave del producto debe ser numerico")
                Exit Sub
            End If

            ', Me.SociedadTxt.Text)
            If String.IsNullOrEmpty(Me.CentroTxt.Text) = False AndAlso
                Not IsNumeric(Me.CentroTxt.Text) Then
                AddErrProvider.SetError(Me.CentroTxt, "La clave del centro debe ser numerico")
                Exit Sub
            End If


            If String.IsNullOrEmpty(Me.ClienteTxt.Text) = False AndAlso
                Not IsNumeric(Me.ClienteTxt.Text) Then
                AddErrProvider.SetError(Me.ClienteTxt, "La clave del cliente debe ser numerico")
                Exit Sub
            End If

            If String.IsNullOrEmpty(Me.SociedadTxt.Text) = False AndAlso
                Not IsNumeric(Me.SociedadTxt.Text) Then
                AddErrProvider.SetError(Me.SociedadTxt, "La clave de sociedad debe ser numerico")
                Exit Sub
            End If
            If Me.mAgente.AreaNegocios.Equals(AREA_INDUSTRIAL) Then
                'Asigna los producctos asignados por cliente solo para el area industrial
                Dim mQry As DjpSap.ClassClienteAgenteProducto = New DjpSap.ClassClienteAgenteProducto(Me.AgenteTxt.Text, Me.ProductoTxt.Text, Me.CentroTxt.Text, Me.ClienteTxt.Text, Me.SociedadTxt.Text)
                mDst = mQry.GetDataSet(True)
                mStrDataMember = mQry.DataMember
            Else
                'Asigna los producctos asignados por centro y cliente
                Dim mQryCentroAgente As DjpSap.ClassProductoCentroAgente = New DjpSap.ClassProductoCentroAgente(Me.mAgente, Me.ProductoTxt.Text, Me.CentroTxt.Text)
                mDst = mQryCentroAgente.GetDataSet(True)
                mStrDataMember = mQryCentroAgente.DataMember


            End If

            ResultadoBDS.DataSource = mDst
            ResultadoBDS.DataMember = mStrDataMember
            ResultadoBDS.ResetBindings(True)

            TabControl1.SelectedTab = ResultadosTab

        Catch ex As Exception
            Me.MsgStatus(ex.Message)

        End Try

    End Sub
    Private Sub ActualizaPronosticoAgricola()

        Dim mTran As SqlTransaction = Nothing
        Try


            Me.Validate()

            If mDst.HasChanges Then
                '*************************************************
                'Valida que ningun reguistro existente en el pronostico
                'Exista
                '*************************************************
                For mIndex = 0 To Me.QryDGrv.Rows.Count - 1
                    Me.QryDGrv.Rows(mIndex).ErrorText = String.Empty
                Next


                Dim mCon As SqlConnection = DjpSap.Dac.mConexion()
                Dim mCmdValidacion As SqlCommand = New SqlCommand
                Dim mReader As SqlDataReader
                Dim mValidacionOk = True

                With mCmdValidacion
                    .CommandType = CommandType.StoredProcedure
                    .Connection = mCon
                    .CommandText = "PRONOSTICOS.EXISTE_PRODUCTOCENTRO"
                    .Parameters.Add(New SqlParameter("@IDPRONOSTICO", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@CENTRO", SqlDbType.Char, 5))
                    .Parameters.Add(New SqlParameter("@PRODUCTO", SqlDbType.Char, 10))

                    Dim mCurrRow As DjpSap.ClassFindGrView
                    mCurrRow = New DjpSap.ClassFindGrView(Me.QryDGrv, "CLAVECENTRO,CLAVEPRODUCTO", ",")
                    Dim mIndex As Integer

                    For Each mRow As DataRow In mDst.GetChanges(System.Data.DataRowState.Modified).Tables(0).Rows
                        'Valida si los registros modificados no estan en la base de pronosticos.
                        Dim mSel As Boolean = CType(mRow("Seleccionar"), Boolean)
                        If mSel Then

                            .Parameters("@IDPRONOSTICO").Value = Me.IdPronostico
                            .Parameters("@CENTRO").Value = mRow("CLAVECENTRO")
                            .Parameters("@PRODUCTO").Value = mRow("CLAVEPRODUCTO")
                                '.Parameters("@CLAVESOCIEDAD").Value = mRow("CLAVESOCIEDAD")
                            '.Parameters("@CLAVECLIENTE").Value = mRow("CLAVECLIENTE")
                                '.Parameters("@AGENTE").Value = Me.AgenteTxt.Text
                                mReader = .ExecuteReader()
                                If mReader.HasRows Then
                                    mReader.Read()
                                    If String.Equals(mReader("Existe"), "X") Then
                                        mValidacionOk = False
                                        'Posiciona el registro en el renglo que fallo.
                                    mIndex = mCurrRow.GetIndex(Trim(mRow("CLAVECENTRO")) & "," & Trim(mRow("CLAVEPRODUCTO")))

                                        If mIndex > -1 Then
                                            Me.QryDGrv.Rows(mIndex).ErrorText = "El registro ya existe en el pronostico"
                                        End If


                                    End If
                                End If
                                mReader.Close()

                            End If





                    Next

                End With

                If mValidacionOk Then
                    '*************************************************
                    ''Envia los cambios a la base de datos.
                    '*************************************************
                    Dim mCmd As SqlCommand = New SqlCommand()
                    With mCmd

                        mTran = mCon.BeginTransaction

                        .Connection = mCon
                        .Transaction = mTran
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "PRONOSTICOS.ADD_PRODUCTOCENTRO"
                        .Parameters.Add(New SqlParameter("@IDPRONOSTICO", SqlDbType.Int))
                        .Parameters.Add(New SqlParameter("@PRODUCTO", SqlDbType.Char, 10))
                        .Parameters.Add(New SqlParameter("@CENTRO", SqlDbType.Char, 5))

                        '.Parameters.Add(New SqlParameter("@CLAVESOCIEDAD", SqlDbType.Char, 5))
                        '.Parameters.Add(New SqlParameter("@CLAVECLIENTE", SqlDbType.Char, 10))
                        '.Parameters.Add(New SqlParameter("@AGENTE", SqlDbType.Int))

                    End With


                    For Each mRow As DataRow In mDst.GetChanges(System.Data.DataRowState.Modified).Tables(0).Rows
                        Dim mSel As Boolean = CType(mRow("Seleccionar"), Boolean)

                        If mSel Then
                            Me.MsgStatus("Agregando Producto:" & mRow("CLAVEPRODUCTO"))
                            With mCmd
                                .Parameters("@IDPRONOSTICO").Value = Me.IdPronostico
                                .Parameters("@CENTRO").Value = mRow("CLAVECENTRO")
                                .Parameters("@PRODUCTO").Value = mRow("CLAVEPRODUCTO")
                                .ExecuteNonQuery()


                            End With

                        End If





                    Next
                    mTran.Commit()
                End If
                Me.MsgStatus("Proceso terminado")
            End If
        Catch Ex1 As SqlException
            Me.MsgStatus(Ex1.Message)
            If IsNothing(mTran) = False AndAlso IsNothing(mTran.Connection) = False Then
                mTran.Rollback()
            End If

        Catch ex As Exception
            Me.MsgStatus(ex.Message)
            If IsNothing(mTran) = False AndAlso IsNothing(mTran.Connection) = False Then
                mTran.Rollback()
            End If
        End Try

    End Sub

    Private Sub ActualizaPronosticoIndustrial()

        Dim mTran As SqlTransaction = Nothing
        Try


            Me.Validate()

            If mDst.HasChanges Then
                '*************************************************
                'Valida que ningun reguistro existente en el pronostico
                'Exista
                '*************************************************
                For mIndex = 0 To Me.QryDGrv.Rows.Count - 1
                    Me.QryDGrv.Rows(mIndex).ErrorText = String.Empty
                Next


                Dim mCon As SqlConnection = DjpSap.Dac.mConexion()
                Dim mCmdValidacion As SqlCommand = New SqlCommand
                Dim mReader As SqlDataReader
                Dim mValidacionOk = True

                With mCmdValidacion
                    .CommandType = CommandType.StoredProcedure
                    .Connection = mCon
                    .CommandText = "PRONOSTICOS.EXISTE_PRODUCTOCLIENTE"
                    .Parameters.Add(New SqlParameter("@IDPRONOSTICO", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@CLAVECENTRO", SqlDbType.Char, 5))
                    .Parameters.Add(New SqlParameter("@CLAVEPRODUCTO", SqlDbType.Char, 10))
                    .Parameters.Add(New SqlParameter("@CLAVECLIENTE", SqlDbType.Char, 10))
                    Dim mCurrRow As DjpSap.ClassFindGrView
                    mCurrRow = New DjpSap.ClassFindGrView(Me.QryDGrv, "CLAVECENTRO,CLAVEPRODUCTO,CLAVECLIENTE", ",")
                    Dim mIndex As Integer

                    For Each mRow As DataRow In mDst.GetChanges(System.Data.DataRowState.Modified).Tables(0).Rows
                        'Valida si los registros modificados no estan en la base de pronosticos.
                        Dim mSel As Boolean = CType(mRow("Seleccionar"), Boolean)
                        If mSel Then

                            If Date.Compare(Today, mRow("VIGENCIA")) > 0 Then
                                mIndex = mCurrRow.GetIndex(Trim(mRow("CLAVECENTRO")) & "," & Trim(mRow("CLAVEPRODUCTO")) & "," & Trim(mRow("CLAVECLIENTE")))
                                If mIndex > -1 Then
                                    Me.QryDGrv.Rows(mIndex).ErrorText = "El registro No puede agregarse ya que la vigencia ha vencido"
                                    mValidacionOk = False
                                End If
                            Else
                                .Parameters("@IDPRONOSTICO").Value = Me.IdPronostico
                                .Parameters("@CLAVECENTRO").Value = mRow("CLAVECENTRO")
                                .Parameters("@CLAVEPRODUCTO").Value = mRow("CLAVEPRODUCTO")
                                '.Parameters("@CLAVESOCIEDAD").Value = mRow("CLAVESOCIEDAD")
                                .Parameters("@CLAVECLIENTE").Value = mRow("CLAVECLIENTE")
                                '.Parameters("@AGENTE").Value = Me.AgenteTxt.Text
                                mReader = .ExecuteReader()
                                If mReader.HasRows Then
                                    mReader.Read()
                                    If String.Equals(mReader("Existe"), "X") Then
                                        mValidacionOk = False
                                        'Posiciona el registro en el renglo que fallo.
                                        mIndex = mCurrRow.GetIndex(Trim(mRow("CLAVECENTRO")) & "," & Trim(mRow("CLAVEPRODUCTO")) & "," & Trim(mRow("CLAVECLIENTE")))

                                        If mIndex > -1 Then
                                            Me.QryDGrv.Rows(mIndex).ErrorText = "El registro ya existe en el pronostico"
                                        End If


                                    End If
                                End If
                                mReader.Close()

                            End If


                        End If


                    Next

                End With

                If mValidacionOk Then
                    '*************************************************
                    ''Envia los cambios a la base de datos.
                    '*************************************************
                    Dim mCmd As SqlCommand = New SqlCommand()
                    With mCmd

                        mTran = mCon.BeginTransaction

                        .Connection = mCon
                        .Transaction = mTran
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "PRONOSTICOS.ADD_PRODUCTOCLIENTE"
                        .Parameters.Add(New SqlParameter("@IDPRONOSTICO", SqlDbType.Int))
                        .Parameters.Add(New SqlParameter("@CLAVECENTRO", SqlDbType.Char, 5))
                        .Parameters.Add(New SqlParameter("@CLAVEPRODUCTO", SqlDbType.Char, 10))
                        .Parameters.Add(New SqlParameter("@CLAVESOCIEDAD", SqlDbType.Char, 5))
                        .Parameters.Add(New SqlParameter("@CLAVECLIENTE", SqlDbType.Char, 10))
                        .Parameters.Add(New SqlParameter("@AGENTE", SqlDbType.Int))

                    End With


                    For Each mRow As DataRow In mDst.GetChanges(System.Data.DataRowState.Modified).Tables(0).Rows
                        Dim mSel As Boolean = CType(mRow("Seleccionar"), Boolean)

                        If mSel Then
                            Me.MsgStatus("Agregando Producto:" & mRow("CLAVEPRODUCTO"))
                            With mCmd
                                .Parameters("@IDPRONOSTICO").Value = Me.IdPronostico
                                .Parameters("@CLAVECENTRO").Value = mRow("CLAVECENTRO")
                                .Parameters("@CLAVEPRODUCTO").Value = mRow("CLAVEPRODUCTO")
                                .Parameters("@CLAVESOCIEDAD").Value = mRow("CLAVESOCIEDAD")
                                .Parameters("@CLAVECLIENTE").Value = mRow("CLAVECLIENTE")
                                .Parameters("@AGENTE").Value = Me.AgenteTxt.Text
                                .ExecuteNonQuery()


                            End With

                        End If





                    Next
                    mTran.Commit()
                End If
                Me.MsgStatus("Proceso terminado")
            End If
        Catch Ex1 As SqlException
            Me.MsgStatus(Ex1.Message)
            If IsNothing(mTran) = False AndAlso IsNothing(mTran.Connection) = False Then
                mTran.Rollback()
            End If

        Catch ex As Exception
            Me.MsgStatus(ex.Message)
            If IsNothing(mTran) = False AndAlso IsNothing(mTran.Connection) = False Then
                mTran.Rollback()
            End If
        End Try
    End Sub
    Private Sub MsgStatus(ByVal pStrMensaje As String)
        StsLbl.Text = pStrMensaje
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub


    Private Sub ProductoBtn_Click(sender As System.Object, e As System.EventArgs) Handles ProductoBtn.Click
        Dim mFrm As New FrmConsultaProductoByCentro

        If mFrm.ShowDialog = Windows.Forms.DialogResult.Yes Then
            With mFrm.ObjItem
                Me.ProductoTxt.Text = .Producto.Clave
                Me.CentroTxt.Text = .Centro.Clave
            End With
        End If
        mFrm.Dispose()


    End Sub

    Private Sub CentroBtn_Click(sender As Object, e As System.EventArgs) Handles CentroBtn.Click
        Dim mFrm As New FrmConsultaCentro
        mFrm.Incializar(Me.CentroTxt.Text)
        Dim mRes As Windows.Forms.DialogResult = mFrm.ShowDialog
        If mRes = ModComun.FORMDIALOG Then
            If IsNothing(mFrm.SelectedItem) = False Then
                Me.CentroTxt.Text = mFrm.SelectedItem.Clave
                Me.CentroDescricpionTxt.Text = mFrm.SelectedItem.Descripcion
                Me.SociedadTxt.Text = mFrm.SelectedItem.Sociedad
            End If

        End If
        mFrm.Dispose()

    End Sub


    Private Sub CteBtn_Click(sender As Object, e As System.EventArgs) Handles CteBtn.Click
        Dim MFrmCtes As New FrmClientes
        MFrmCtes.TxtSociedad.Text = Me.SociedadTxt.Text
        If MFrmCtes.ShowDialog = ModComun.FORMDIALOG Then
            If Not IsNothing(MFrmCtes.POBJCTE) Then
                Me.SociedadTxt.Text = MFrmCtes.POBJCTE.Sociedad
                ClienteTxt.Text = MFrmCtes.POBJCTE.Clave
            End If
        End If
        MFrmCtes.Dispose()
    End Sub


    Private Sub AyudaToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles AyudaToolStripButton.Click

        Help()
    End Sub

    Private Sub FrmAddProductosPronosticoByCliente_HelpRequested(sender As Object, hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested
        Help()
    End Sub
    Private Sub Help()
        ModComun.ShowHelpAppByTopicId(Me, Me.HelpProvider1.Tag)

    End Sub

    Private Sub FrmAddProductosPronosticoByCliente_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp


    End Sub

    Private Sub AgenteTxt_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CentroTxt.KeyUp, ClienteTxt.KeyUp, SociedadTxt.KeyUp, ProductoTxt.KeyUp
        If e.KeyValue = ModComun.CTE_KEYENTER Then
            AbrirToolStripButton.PerformClick()

        End If
    End Sub

    Private Sub AgenteTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles AgenteTxt.TextChanged

    End Sub

    Private Sub GuardarToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles GuardarToolStripButton.Click
        If Me.mAgente.AreaNegocios.Equals("I") Then
            ActualizaPronosticoIndustrial()
        Else
            ActualizaPronosticoAgricola()
        End If
    End Sub

End Class
