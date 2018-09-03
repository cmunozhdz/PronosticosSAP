
Namespace DjpSap

    Public Class ClassConfig

        Public Shared Function strGetPeriodobloqueado(ByVal pValorItem As String) As Integer
            Dim mValor As Integer = 1
            Select Case pValorItem
                Case "A" : mValor = My.Settings.DiaCongelaAgricola
                Case "I" : mValor = My.Settings.DiaCongelaIndustrial
            End Select
            Return mValor

        End Function

        Public Shared Function EsDiasHabiles(ByVal pValorItem As String) As Boolean
            Dim mValor As Integer = 1
            Select Case pValorItem
                Case "A" : mValor = My.Settings.DiasHabilesAgricola.Equals("S")
                Case "I" : mValor = My.Settings.DiasHabilesI.Equals("S")

            End Select
            Return mValor

        End Function
    End Class
End Namespace

