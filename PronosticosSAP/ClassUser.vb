Namespace DjpSap


    Public Class ClassUser
        Structure tpUserAdministrativo
            Dim mUserid As String
            Dim mPwd As String
            Dim mEmail As String

        End Structure

        Enum enEstado
            enUsuarioNoExiste = 0
            enOk = 1
            enErrorContrasena = 2
            enUsuarioBloqueado = 3
            enError = 4

        End Enum
        Dim mColEstados As System.Collections.Generic.Dictionary(Of enEstado, String)
        Dim mStrUserBuscar As String


        Dim mArrUsrAdmin(0 To 1) As tpUserAdministrativo
        Dim mStrError As String

        Dim mUserId As String
        Dim mPwd As String
        Dim strEmail As String

        Const CTE_USERADMIN As String = "Admin"       'Actividades administrativas  
        Const CTE_SUPERADMIN As String = "SuperAdmin" 'SOLO SE HABILITA COMO MODO A PRUEBA DE FALLOS
        Const CTE_MODOCONFIGINI As String = "I" 'Cuando el programa nunca se ha utilizado es necesario para la config de bases de datos
        ''' <summary>
        ''' Implementa la condiciones para indicar si el usuario actual está 
        ''' en la lista de super usuarios predeterminada.
        ''' </summary>
        ''' <param name="ObjUsuario"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function FnBuscarUsuario(ByVal ObjUsuario As tpUserAdministrativo) As Boolean

            Return String.Compare(Me.UserName, ObjUsuario.mUserid) = 0

        End Function
        Public Sub New()
            With mArrUsrAdmin(0)
                .mUserid = "Admin"
                .mPwd = "Ni1vst"
                .mEmail = "cmunoz@polakgrupo.com"

            End With
            With mArrUsrAdmin(1)
                .mUserid = "SuperAdmin"
                .mPwd = "Vaqnm1c9est"
                .mEmail = "cmunoz@polakgrupo.com"
            End With
            mColEstados = New System.Collections.Generic.Dictionary(Of enEstado, String)
            mColEstados.Add(enEstado.enError, "Error no controlado")
            mColEstados.Add(enEstado.enErrorContrasena, "Contraseña Incorrecta")
            mColEstados.Add(enEstado.enOk, "Validado Exitosamente")
            mColEstados.Add(enEstado.enUsuarioBloqueado, "Usuario Bloqueado")
            mColEstados.Add(enEstado.enUsuarioNoExiste, "Usuario No existe")



        End Sub
        Public Property Password() As String
            Get
                Return mPwd

            End Get
            Set(ByVal value As String)
                mPwd = value

            End Set
        End Property
        Public Property UserName() As String
            Get
                Return mUserId

            End Get
            Set(ByVal value As String)
                mUserId = value

            End Set
        End Property
        Public Property Email As String
            Get
                Return strEmail
            End Get
            Set(ByVal value As String)
                strEmail = value
            End Set
        End Property

        Public Function Autentificar() As Integer
            Dim mObjEstado As enEstado
            'Busca si el usuario es admon.

            Dim tmpUserAdmon As DjpSap.ClassUser.tpUserAdministrativo = Array.Find(mArrUsrAdmin, AddressOf FnBuscarUsuario)

            If Not IsNothing(tmpUserAdmon.mUserid) Then
                Me.Email = tmpUserAdmon.mEmail
                If String.Compare(Me.mPwd, tmpUserAdmon.mPwd) = 0 Then
                    mObjEstado = enEstado.enOk

                Else
                    mObjEstado = enEstado.enErrorContrasena
                End If

            Else

                'Verifica en la base de datos de sql los datos del usuario y password
                Try
                    Dim mcon As System.Data.SqlClient.SqlConnection = DjpSap.Dac.mConexion
                    Dim mCmd As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand("CATALOGOS.CONSULTA_USUARIOS", mcon)
                    mCmd.CommandType = System.Data.CommandType.StoredProcedure
                    mCmd.Parameters.AddWithValue("@UserId", Me.mUserId)

                    Dim mReader As System.Data.SqlClient.SqlDataReader = mCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)

                    If mReader.HasRows Then
                        While mReader.Read
                            Me.Email = mReader.Item("email")

                            If mReader.Item("estatus") <> "A" Then
                                'El usuario no esta activado
                                mObjEstado = enEstado.enUsuarioBloqueado
                            Else
                                If String.Compare(Me.mPwd, mReader.Item("Pwd").ToString) = 0 Then
                                    mObjEstado = enEstado.enOk
                                Else
                                    mObjEstado = enEstado.enErrorContrasena

                                End If

                            End If


                        End While
                        mReader.Close()
                        mcon.Close()
                        mReader = Nothing
                        mcon = Nothing


                    Else
                        mObjEstado = enEstado.enUsuarioNoExiste
                    End If

                Catch ex As Exception
                    mObjEstado = enEstado.enError
                    mColEstados.Item(mObjEstado) = ex.Message

                End Try
            End If

            Return CType(mObjEstado, Integer)



        End Function

        Function FnMsgError(ByVal IdError As Integer) As String
            Dim mError As enEstado = IdError
            Return mColEstados(mError)

        End Function

        Function EsSuperUsuario() As Boolean
            Dim tmpUserAdmon As DjpSap.ClassUser.tpUserAdministrativo = Array.Find(mArrUsrAdmin, AddressOf FnBuscarUsuario)
            Return Not IsNothing(tmpUserAdmon.mUserid)
        End Function

    End Class

End Namespace
