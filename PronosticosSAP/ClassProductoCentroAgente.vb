Imports System.Data
Imports System.Data.SqlClient
Namespace DjpSap

    Public Class ClassProductoCentroAgente
        Private mAgente As ClassVendedor
        Private mProductoCentro As ClassProductoCentro
        Private mDataMember As String


        Sub New(pAgente As ClassVendedor, pProducto As String, pCentro As String)
            mAgente = pAgente
            mProductoCentro = New ClassProductoCentro(pProducto, pCentro)
        End Sub
        Public ReadOnly Property DataMember
            Get
                Return mDataMember
            End Get
        End Property


        ''' <summary>
        ''' Indica si el dataset va a devolver una columna con checkbox
        ''' </summary>
        ''' <param name="pChekBox"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetDataSet(pChekBox As Boolean)

            Dim mCommand As SqlCommand 'Select command para DataAdapter
            mCommand = New SqlCommand
            With mCommand
                .CommandType = CommandType.StoredProcedure
                .CommandText = "CATALOGOS.CONSULTA_PRODUCTOXCENTROAGENTE"
                .Connection = Dac.mConexion()
                If String.IsNullOrEmpty(mProductoCentro.Producto.Clave) Then
                    .Parameters.AddWithValue("@PRODUCTO", System.DBNull.Value)
                Else
                    .Parameters.AddWithValue("@PRODUCTO", mProductoCentro.Producto.Clave)
                End If

                If String.IsNullOrEmpty(mProductoCentro.Centro.Clave) Then
                    .Parameters.AddWithValue("@CENTRO", System.DBNull.Value)
                Else
                    .Parameters.AddWithValue("@CENTRO", mProductoCentro.Centro.Clave)
                End If

                .Parameters.AddWithValue("@AGENTE", mAgente.Clave)
            End With

            Dim mDt As DataTable = New DataTable
            Dim mTa As SqlDataAdapter = New SqlDataAdapter(mCommand)
            Dim mDs As DataSet = New DataSet

            mTa.Fill(mDt)
            mDt.TableName = "CONSULTA_PRODUCTOXCENTROAGENTE"
            If pChekBox Then
                Dim mColChk As DataColumn = New DataColumn("Seleccionar", GetType(System.Boolean))
                mDt.Columns.Add(mColChk)
                'mDt.Columns.Add("")

            End If
            mDataMember = mDt.TableName
            mDs.Tables.Add(mDt)


            Return mDs

        End Function

    End Class
End Namespace

