Imports System.Data.SqlClient
Imports System.Configuration
Namespace DjpSap
    Public Class Dac
        Shared Function mConexion() As SqlConnection
            Dim mTmpConexion As SqlConnection = New SqlConnection

            mTmpConexion.ConnectionString = My.Settings.ForeCastSapConnectionString.ToString()


            mTmpConexion.Open()
            Return mTmpConexion




        End Function



    End Class
End Namespace

