Public Class FrmPronosticoCambios
    ''' <summary>
    ''' Presenta Historico de cambios por posicion.
    ''' </summary>
    ''' <remarks></remarks>
    Public objItemConsulta As ClassItemPronosticos
    ''' <summary>
    ''' Preenta el historico de cambios
    ''' </summary>
    ''' <remarks>Considerar que el Objeto objItemConsulta debe Inicializarse previamente.</remarks>
    Public Sub Consultar()
        Try
            If Not IsNothing(objItemConsulta) Then
                With objItemConsulta
                    Dim mstrCte As String = Nothing

                    If Not IsNothing(.Cliente) Then
                        mstrCte = .Cliente.Clave
                    End If
                    Me.CONSULTA_HISTORICOCAMBIOSTableAdapter.Fill(Me.SapForecastDataSet.CONSULTA_HISTORICOCAMBIOS, .Id, .Centro, .Producto.Clave, mstrCte, .Periodo)

                End With

            Else
                ModComun.MsgError("Item a consultar no ha sido establecido.")

            End If


        Catch ex As System.Exception
            ModComun.MsgError(ex.Message)

        End Try

    End Sub

    Private Sub RegresarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegresarBtn.Click
        Me.Hide()
    End Sub


    Private Sub ActualizarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarBtn.Click
        Consultar()
    End Sub
End Class