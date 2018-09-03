Public Class ClassProducto
    Private Structure Conversion
        Dim pValor As Double
        Dim pErrorRedondeo As Boolean

    End Structure
    Dim mTmpValor As Conversion
    Private pBolExiste As Boolean
    Private mClave As String
    Private mUnidadBase As String
    Private mUnidadAlterna As String
    Private mStrOperador As String
    Private mDblFactor As Double
    Private mDblUsarRedondeo As Boolean
    Private mBolErrorRedondeo As Boolean
    Private mStrDescripcion As String
    Private mstrMsgError As String


    Public Property Clave As String

        Get
            Return Trim(mClave)
        End Get
        Set(ByVal value As String)
            mClave = Trim(value)

        End Set

    End Property
    Public Property DescripcionCorta As String
        Get
            Return mStrDescripcion

        End Get
        Set(ByVal value As String)
            mStrDescripcion = value

        End Set
    End Property
    Public Property UnidadBase As String
        Get
            Return mUnidadBase

        End Get
        Set(ByVal value As String)
            mUnidadBase = value
        End Set
    End Property

    Public Property UnidadAlterna As String
        Get
            Return mUnidadAlterna

        End Get
        Set(ByVal value As String)
            mUnidadAlterna = value
        End Set
    End Property
    Public ReadOnly Property HayErrorRedondeo As Boolean
        Get
            Return mTmpValor.pErrorRedondeo

        End Get
    End Property

    Public ReadOnly Property Equivalencia(ByVal pstrUnidadDestino As String, ByVal pCantidad As String) As Double
        Get
            Dim BolRedondeo As Boolean = Me.mDblUsarRedondeo

            If String.Compare(mUnidadAlterna, pstrUnidadDestino) = 0 Then
                'Va a convertir de unidad base a la alterna
                Return Me.ConvertirUnidades(pCantidad, Me.mStrOperador, Me.mDblFactor, BolRedondeo)
        
            Else
                Dim mStrOperadorAlterno As String
                Select Case Me.mStrOperador
                    Case "M" : mStrOperadorAlterno = "D"
                    Case "D" : mStrOperadorAlterno = "M"
                        Dim CteRed = 1000
                        BolRedondeo = CInt(Me.mDblFactor) = Me.mDblFactor
                    Case "A" : mStrOperadorAlterno = "S"
                    Case "S" : mStrOperadorAlterno = "A"
                    Case Else
                        mStrOperadorAlterno = String.Empty
                End Select
            

                Return Me.ConvertirUnidades(pCantidad, mStrOperadorAlterno, Me.mDblFactor, BolRedondeo)

            End If

        End Get

    End Property
    Private Function ConvertirUnidades(ByVal pCantidad As Double, ByVal pOperador As String, ByVal pFactor As Double, ByVal pRedondeo As Boolean) As Double
        Select Case pOperador
            Case "M"
                If Not pRedondeo Then

                    mTmpValor.pValor = pFactor * pCantidad
                    mTmpValor.pErrorRedondeo = False

                Else
                    mTmpValor.pValor = System.Math.Ceiling(pFactor * pCantidad)
                    mTmpValor.pErrorRedondeo = mTmpValor.pValor <> pFactor * pCantidad 'Pone una Bandera para indicar que hay un error de redondeo
                End If

            Case "D"

                If Not pRedondeo Then


                    If pFactor <> 0 Then
                        mTmpValor.pValor = pCantidad / pFactor
                    Else
                        mTmpValor.pValor = 0

                    End If
                    mTmpValor.pErrorRedondeo = False



                Else
                    If pFactor <> 0 Then
                        mTmpValor.pValor = System.Math.Ceiling(pCantidad / pFactor)
                        mTmpValor.pErrorRedondeo = mTmpValor.pValor <> (pCantidad / pFactor) 'Pone una Bandera para indicar que hay un error de redondeo
                    Else
                        mTmpValor.pValor = 0
                        mTmpValor.pErrorRedondeo = True
                    End If
                    

                End If

            Case "A"
                mTmpValor.pValor = pCantidad + pFactor

            Case "S"
                mTmpValor.pValor = pCantidad - pFactor
            Case Else
                mTmpValor.pErrorRedondeo = True
                mTmpValor.pValor = 0
        End Select
        Return mTmpValor.pValor

        
    End Function
    Function EstableceFactorConversion(ByVal pUnidadBase As String, _
                                    ByVal pUnidadAlterna As String, _
                                    ByVal pDblFactor As Double, _
                                    ByVal pStrOperador As String, _
                                    ByVal pValorExacto As Boolean) As Boolean
        EstableceFactorConversion = False
        Me.mUnidadBase = Trim(pUnidadBase)
        Me.mUnidadAlterna = Trim(pUnidadAlterna)
        Me.mDblFactor = pDblFactor
        Me.mStrOperador = pStrOperador
        mDblUsarRedondeo = pValorExacto

        EstableceFactorConversion = True



    End Function
    ''' <summary>
    ''' Busca el producto en el catalogo maestro
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ConsultarCatalogo() As Boolean
        Dim mBolProceso As Boolean
        Try
            Dim Dt As SapForecastDataSet.CONSULTA_PRODUCTODataTable = New SapForecastDataSet.CONSULTA_PRODUCTODataTable()
            Dim Ta As SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOTableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOTableAdapter
            Using Dt
                Using Ta
                    Dim intRecords As Integer = Ta.Fill(Dt, mClave, String.Empty, String.Empty, String.Empty, String.Empty)
                    If intRecords > 0 Then
                        For Each mRow As SapForecastDataSet.CONSULTA_PRODUCTORow In Dt.Rows
                            Me.mClave = mRow.CLAVE
                            Me.DescripcionCorta = mRow.DESCRIPCION
                            Me.UnidadBase = mRow.UNIDADMEDIDABASE
                            Me.UnidadAlterna = Me.UnidadBase





                        Next

                    End If
                    pBolExiste = intRecords > 0

                End Using
            End Using
            mBolProceso = True
        Catch ex As Exception
            mstrMsgError = ex.Message
            mBolProceso = False
        End Try

        Return mBolProceso





    End Function

    ''' <summary>
    ''' Busca el producto en el catalogo maestro producto y centro
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ConsultarCatalogo(ByVal pstrCentro As String) As Boolean
        Dim mBolProceso As Boolean
        Try
            Dim Dt As SapForecastDataSet.CONSULTA_PRODUCTODataTable = New SapForecastDataSet.CONSULTA_PRODUCTODataTable()
            Dim Ta As SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOTableAdapter = New SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOTableAdapter

            Using Dt
                Using Ta

                    Dim intRecords As Integer = Ta.FillByCentro(Dt, Me.Clave, Trim(pstrCentro))

                    If intRecords > 0 Then
                        For Each mRow As SapForecastDataSet.CONSULTA_PRODUCTORow In Dt.Rows
                            Me.mClave = mRow.CLAVE
                            Me.DescripcionCorta = mRow.DESCRIPCION
                            Me.UnidadBase = mRow.UNIDADMEDIDABASE
                            Me.UnidadAlterna = Me.UnidadBase

                        Next

                    End If
                    pBolExiste = intRecords > 0
                End Using
            End Using
            mBolProceso = True
        Catch ex As Exception
            mstrMsgError = ex.Message
            mBolProceso = False
        End Try

        Return mBolProceso





    End Function

    ''' <summary>
    ''' Busca el factor de conversion del producto segun el catalogo
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function BuscarEquivalenciaCatalogo() As Boolean
        Dim mBolProceso As Boolean
        Try
            Dim Dt As SapForecastDataSet.CONSULTAUMDataTable = New SapForecastDataSet.CONSULTAUMDataTable
            Dim Ta As SapForecastDataSetTableAdapters.CONSULTAUMTableAdapter = New SapForecastDataSetTableAdapters.CONSULTAUMTableAdapter
            Dim intRow As Integer = Ta.Fill(Dt, mClave)
            If intRow > 0 Then
                For Each mRow As SapForecastDataSet.CONSULTAUMRow In Dt.Rows
                    Me.EstableceFactorConversion(mRow.UNIDAMEDIDABASE, mRow.UNIDAMEDIDAALTERNA, mRow.FACTOR, mRow.OPERADOR, mRow.CANTIDADEXACTA)
                    mBolProceso = True
                Next
            Else
                'No hay Unidad alterna es la misma que la unidad base
                'If Not String.IsNullOrEmpty(Me.UnidadBase) Then
                If Me.ConsultarCatalogo() Then
                    Me.EstableceFactorConversion(Me.UnidadBase, Me.UnidadAlterna, 1, "M", False)
                    mBolProceso = True
                End If

                'End If


            End If
        Catch ex As Exception
            mstrMsgError = ex.Message
            mBolProceso = False
        End Try
        Return mBolProceso



    End Function

    Public ReadOnly Property Existe() As Boolean
        Get
            Return pBolExiste
        End Get
    End Property


End Class
