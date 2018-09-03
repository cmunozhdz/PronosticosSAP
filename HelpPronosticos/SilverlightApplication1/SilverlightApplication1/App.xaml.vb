Partial Public Class App
	Inherits Application

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub Application_Startup(ByVal o As Object, ByVal e As StartupEventArgs) Handles Me.Startup
		Me.RootVisual = New MainPage()
	End Sub

	Private Sub Application_Exit(ByVal o As Object, ByVal e As EventArgs) Handles Me.Exit
	End Sub

	Private Sub Application_UnhandledException(ByVal sender As Object, ByVal e As ApplicationUnhandledExceptionEventArgs) Handles Me.UnhandledException
		' Si la aplicación se está ejecutando fuera del depurador, informa de la excepción mediante
		' el mecanismo de excepciones del explorador. En Internet Explorer, se muestra como un icono de alerta amarillo 
		' en la barra de estado y Firefox muestra un error de script.
		If Not System.Diagnostics.Debugger.IsAttached Then

			' NOTA: esto permitirá que la aplicación continúe ejecutándose cuando se produzca una excepción
			' y no se controle. 
			' Para aplicaciones de producción, este control de errores debería reemplazarse por algo que 
			' informe del error al sitio web y detenga la aplicación.
			e.Handled = True
			Deployment.Current.Dispatcher.BeginInvoke(New Action(Of ApplicationUnhandledExceptionEventArgs)(AddressOf ReportErrorToDOM), e)
		End If
	End Sub

	Private Sub ReportErrorToDOM(ByVal e As ApplicationUnhandledExceptionEventArgs)
		Try
			Dim errorMsg As String = e.ExceptionObject.Message + e.ExceptionObject.StackTrace
			errorMsg = errorMsg.Replace(""""c, "'"c).Replace(ChrW(13) & ChrW(10), "\n")

			System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(""Unhandled Error in Silverlight Application " + errorMsg + """);")
		Catch

		End Try
	End Sub
End Class