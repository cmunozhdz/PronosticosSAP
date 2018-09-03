Imports System.Data
Imports System.Data.SqlClient
Namespace DjpSap

    Public Class ClassClienteAgenteProducto

        Dim mAgente As ClassVendedor
        Dim mProducto As ClassProductoCentro
        Dim mCliente As ClassCliente
        Dim mDataMember As String

        Sub New(ByVal pValAgente As String, ByVal Producto As String, ByVal Centro As String, ByVal Cliente As String, ByVal Sociedad As String)
            mAgente = New ClassVendedor
            mAgente.Clave = pValAgente

            mProducto = New ClassProductoCentro(Producto, Centro)
            mProducto.Producto.Clave = Producto
            mProducto.Centro.Clave = Centro


            mCliente = New ClassCliente
            Me.mCliente.Clave = Cliente
            Me.mCliente.Sociedad = Sociedad

        End Sub
        ReadOnly Property DataMember As String
            Get
                Return mDataMember
            End Get
        End Property
        ReadOnly Property GetDataSet(ByVal CheckBox As Boolean) As DataSet
            Get
                Dim mCmd As SqlCommand = New SqlCommand()
                Dim mds As System.Data.DataSet

                With mCmd

                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "CATALOGOS.GET_AGENTE_CLIENTE_PRODUCTO_VARIOS"
                    .Connection = DjpSap.Dac.mConexion

                    If IsNothing(mAgente) OrElse String.IsNullOrEmpty(mAgente.Clave) Then
                        .Parameters.AddWithValue("@AGENTE", System.DBNull.Value)
                    Else
                        .Parameters.AddWithValue("@AGENTE", mAgente.Clave)
                    End If

                    If IsNothing(mCliente) OrElse String.IsNullOrEmpty(mCliente.Sociedad) Then
                        .Parameters.AddWithValue("@SOCIEDAD", System.DBNull.Value)
                    Else
                        .Parameters.AddWithValue("@SOCIEDAD", mCliente.Sociedad)
                    End If

                    If IsNothing(mCliente) OrElse String.IsNullOrEmpty(mCliente.Clave) Then
                        .Parameters.AddWithValue("@CLIENTE", System.DBNull.Value)
                    Else
                        .Parameters.AddWithValue("@CLIENTE", mCliente.Clave)
                    End If

                    If IsNothing(mProducto) OrElse String.IsNullOrEmpty(mProducto.Producto.Clave) Then
                        .Parameters.AddWithValue("@PRODUCTO", System.DBNull.Value)
                    Else
                        .Parameters.AddWithValue("@PRODUCTO", mProducto.Producto.Clave)
                    End If


                    If IsNothing(mProducto) OrElse String.IsNullOrEmpty(mProducto.Centro.Clave) Then
                        .Parameters.AddWithValue("@CENTRO", System.DBNull.Value)
                    Else
                        .Parameters.AddWithValue("@CENTRO", mProducto.Centro.Clave)
                    End If


                End With
                mds = New DataSet
                Dim mDt As DataTable = mds.Tables.Add("GET_AGENTE_CLIENTE_PRODUCTO_VARIOS")
                mDataMember = mDt.TableName

                Dim Ta As SqlDataAdapter = New SqlDataAdapter(mCmd)

                Ta.Fill(mDt)
                If CheckBox Then
                    Dim mColChk As DataColumn = New DataColumn("Seleccionar", GetType(System.Boolean))
                    mDt.Columns.Add(mColChk)
                End If
                Return mds
            End Get
        End Property
    End Class
End Namespace
