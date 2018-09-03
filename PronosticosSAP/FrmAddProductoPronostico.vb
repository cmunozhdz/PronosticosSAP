Imports System.Data.SqlClient

Public Class FrmAddProductoPronostico
    Private pObJItem As ClassPronosticos

    Private Sub FrmAddProductoPronostico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirToolStripButton.Enabled = False

    End Sub


    Private Sub BtnConsultaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultaProducto.Click
        Try
            Dim mFrmPrd As FrmConsultaProducto = New FrmConsultaProducto
            mFrmPrd.ShowDialog()
            If mFrmPrd.DialogResult = DialogResult.Yes Then
                Me.ProductoTxt.Text = mFrmPrd.pObjProducto.Clave
            End If
            mFrmPrd.Dispose()

        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try


    End Sub

    Private Sub CentroBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentroBtn.Click
        Dim mFrmCentro As FrmConsultaCentro = New FrmConsultaCentro
        mFrmCentro.ShowDialog()
        If mFrmCentro.DialogResult = DialogResult.Yes Then

        End If
        mFrmCentro.Dispose()


    End Sub

    
    ''' <summary>
    ''' Abre la pantalla de edición de un pronostico dado.
    ''' </summary>
    ''' <param name="ItemPronostico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Inicializar(ByVal ItemPronostico)
        Try
            pObJItem = ItemPronostico
            With pObJItem

                Me.IdPronosticoTxt.Text = .Id
                Me.IdPronosticoTxt.Enabled = False

                Me.PronosticoDescTxt.Text = .Descripcion
                Me.PronosticoDescTxt.Enabled = False

                Me.CveAgenteTxt.Text = .Agente.Clave
                Me.CveAgenteTxt.Enabled = False
                Me.DescAgenteTxt.Text = .Agente.Descripcion
                Me.DescAgenteTxt.Enabled = False
                Me.ProductoTxt.Text = String.Empty
                Me.CentroTxt.Text = String.Empty
                If .Agente.AreaNegocios = "I" Then
                    Me.ClienteTxt.Enabled = True
                    Me.SociedadTxt.Enabled = True
                    Me.ClienteBtn.Enabled = True
                    Me.SociedadBtn.Enabled = True
                Else
                    Me.ClienteTxt.Enabled = False
                    Me.SociedadTxt.Enabled = False
                    Me.ClienteBtn.Enabled = False
                    Me.SociedadBtn.Enabled = False
                End If

            End With
            Return True
        Catch ex As Exception
            ModComun.MsgError(ex.Message)
            Return False
        End Try


    End Function


    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        Try
            'Valida que el producto y centro no existan el el pronosticos 
            If Not (pObJItem.Agente.Clave) Then
                Dim mObJCentro As ClassCentro = Nothing
                Dim mProducto As ClassProducto = Nothing
                Dim mCliente As ClassCliente = Nothing
                Dim mValidacionOk As Boolean = False
                If String.IsNullOrEmpty(Me.CentroTxt.Text) Then
                    CentrosErrProv.SetError(Me.CentroTxt, "Indicar un centro valido")
                    'El centro no existe
                    mValidacionOk = False
                Else
                    'Validar que el centro Existe en la base de datos.
                    If IsNumeric(Me.CentroTxt.Text) Then
                        mObJCentro = New ClassCentro(Me.CentroTxt.Text)
                        mObJCentro.ConsultarCatalogo(pObJItem.Agente.Clave, Me.CentroTxt.Text)
                        If Not mObJCentro.Existe Then
                            CentrosErrProv.SetError(Me.CentroTxt, "El centro indicado no está asignado al agente.")
                        Else
                            DescCentroTxt.Text = mObJCentro.Descripcion

                            mValidacionOk = True
                        End If
                    Else
                        CentrosErrProv.SetError(Me.CentroTxt, "El centro debe ser un valor numerico")
                        mValidacionOk = False
                    End If
                    
                End If

                If mValidacionOk Then
                    mValidacionOk = False
                    If String.IsNullOrEmpty(Me.ProductoTxt.Text) = False Then
                        'Valida que el producto existe en el centro.
                        mProducto = New ClassProducto
                        mProducto.Clave = Me.ProductoTxt.Text
                        If mProducto.ConsultarCatalogo(Me.CentroTxt.Text) Then
                            If mProducto.Existe Then
                                'Agrega el producto al escenario.
                                mValidacionOk = True
                                'Actualiza la descripcion del producto
                                Me.DescProductoTxt.Text = mProducto.DescripcionCorta

                            Else
                                mValidacionOk = False
                                CentrosErrProv.SetError(Me.ProductoTxt, "El producto indicado no está ampliado al centro.")
                            End If
                        End If

                    End If
                End If

                If pObJItem.Agente.AreaNegocios = "I" Then
                    'Valida que se registre el cliente y el area de negocios.

                    If String.IsNullOrEmpty(Me.ClienteTxt.Text) Then
                        CentrosErrProv.SetError(Me.ClienteTxt, "El pronóstico Industrial Exige definir un cliente")
                        mValidacionOk = False
                    End If
                    If String.IsNullOrEmpty(Me.SociedadTxt.Text) Then
                        CentrosErrProv.SetError(Me.SociedadTxt, "El pronóstico Industrial Exige definir una sociedad")
                        mValidacionOk = False
                    End If

                    'Valida que la sociedad y cliente existe.
                    Dim mTdCte As SapForecastDataSet.CONSULTA_AGENTECLIENTEDataTable = New SapForecastDataSet.CONSULTA_AGENTECLIENTEDataTable
                    Dim mTaCte As SapForecastDataSetTableAdapters.CONSULTA_AGENTECLIENTETableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_AGENTECLIENTETableAdapter
                    If mTaCte.Fill(mTdCte, pObJItem.Agente.Clave, Me.SociedadTxt.Text, Me.ClienteTxt.Text) = 0 Then
                        CentrosErrProv.SetError(Me.ClienteTxt, "El cliente/sociedad no está asignado al agente")
                        mValidacionOk = False
                    End If
                End If

                If mValidacionOk Then

                    'Ejecuta el proceso de envio.

                    If ModComun.MsgYesNo("¿Esta seguro de agregar producto al pronostico ?" & Environment.NewLine & "Este proceso no puede ser anulado", _
                                          MessageBoxDefaultButton.Button2) Then
                        Dim mCon As SqlConnection = DjpSap.Dac.mConexion()
                        Dim mCmd As SqlCommand = New SqlCommand()
                        Dim mPar As SqlParameter = New SqlParameter
                        mPar.Direction = ParameterDirection.ReturnValue
                        Using mCon
                            With mCmd
                                .Connection = mCon

                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "PRONOSTICOS.AGREGA_PRODUCTO"
                                .Parameters.Add(mPar)
                                .Parameters.AddWithValue("@IDPRONOSTICO", pObJItem.Id)


                                .Parameters.AddWithValue("@CLAVECENTRO", mObJCentro.Clave)
                                .Parameters.AddWithValue("@CLAVEPRODUCTO", mProducto.Clave)


                                If String.IsNullOrEmpty(Me.SociedadTxt.Text) Then

                                    .Parameters.AddWithValue("@CLAVESOCIEDAD", DBNull.Value)

                                Else
                                    .Parameters.AddWithValue("@CLAVESOCIEDAD", Me.SociedadTxt.Text)
                                End If

                                If String.IsNullOrEmpty(Me.ClienteTxt.Text) Then
                                    .Parameters.AddWithValue("@CLAVECLIENTE", DBNull.Value)
                                Else
                                    .Parameters.AddWithValue("@CLAVECLIENTE", mCliente.Clave)
                                End If

                                .ExecuteNonQuery()

                                If mPar.Value = 0 Then
                                    ModComun.MsgError("Producto No pudo agregarse")
                                Else
                                    ModComun.MsgInfo("Producto Agregado Exitosamente")
                                End If
                            End With
                            mCon.Close()

                        End Using



                        'Dim mOjbDac As DjpSap.Dac = New DjpSap.Dac
                    End If
                End If
            Else
                ModComun.MsgError("El objeto: Empleado no se inicializa correctamente")
            End If
            

        Catch ex As Exception
            ModComun.MsgError(ex.Message)

        End Try
        

    End Sub

   
    
    Private Sub NuevoToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        If IsNothing(pObJItem) Then
            Me.IdPronosticoTxt.Text = String.Empty
        Else
            Me.IdPronosticoTxt.Text = pObJItem.Id
        End If
        Me.ProductoTxt.Text = String.Empty
        If IsNothing(pObJItem.Agente) Then
            Me.CveAgenteTxt.Text = String.Empty
        Else
            Me.CveAgenteTxt.Text = pObJItem.Agente.Clave
        End If
        Me.CentroTxt.Text = String.Empty
        Me.SociedadTxt.Text = String.Empty
        Me.ClienteTxt.Text = String.Empty

    End Sub
End Class