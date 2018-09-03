Imports System.IO
Namespace DjpSap
    Public Class ClassArchivos
        Dim sw As StreamWriter
        Dim mFile As FileStream
        Public Sub New(ByVal mParDestino As String)
            'Crea el string writer
            mFile = New FileStream(mParDestino, FileMode.Create, FileAccess.Write, FileShare.None)
            sw = New StreamWriter(mFile)

        End Sub
        Public Sub Append(ByVal pValue As String)
            sw.WriteLine(pValue)
        End Sub
        Public Sub Save()
            sw.Flush()
            sw.Close()
        End Sub


    End Class

End Namespace
