Public Class ClassAssembly
    Function GetVersion() As String
        Dim mBld As New Text.StringBuilder

        Dim mAsembl = System.Reflection.Assembly.GetEntryAssembly()
        Dim mAsemlyName As System.Reflection.AssemblyName = mAsembl.GetName()
        Dim mVers As System.Version = mAsemlyName.Version
        mBld.AppendLine(String.Format("Versión:{0}", mVers))
        If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            mBld.AppendLine(String.Format("Versión Distribución:{0}", System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()))
        End If
        Return mBld.ToString()



    End Function
End Class
