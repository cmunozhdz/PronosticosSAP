Imports System.Windows.Forms
Imports System.Text
Public Class MDIPronosticos
    Public pUsuario As DjpSap.ClassUser
    Private CTE_PERMISOS = "Usted No tiene permisos para ejecutar está operacion"

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub TerritoriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerritoriosToolStripMenuItem.Click
        If Me.pUsuario.EsSuperUsuario Then
            Dim mForm As FormZonas = New FormZonas

            mForm.MdiParent = Me
            mForm.Show()
        Else
            ModComun.MsgInfo(Me.CTE_PERMISOS)
        End If

        


        'FormTerritorios.MdiParent = Me
        'FormTerritorios.Show()


    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VendedoresToolStripMenuItem.Click
        If Me.pUsuario.EsSuperUsuario Then
            Dim FormVendedores = FrmAgentes
            FormVendedores = New FrmAgentes
            FormVendedores.MdiParent = Me
            FormVendedores.Show()
        Else
            ModComun.MsgInfo(Me.CTE_PERMISOS)
        End If
        

    End Sub

    Private Sub ForecastToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.MsgTextStatusBar("Espere.... Iniciando Procesos de Pronósticos. ", False)

        Dim FormPronosticos As New Pronosticos
        FormPronosticos.MdiParent = Me
        FormPronosticos.Show()
        Me.MsgTextStatusBar(Nothing, False)


    End Sub



    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        'If Me.pUsuario.EsSuperUsuario Then
        Me.MsgTextStatusBar("Espere.... Iniciando Procesos de Productos. ", False)
        Dim mProductos As FrmProductos
        mProductos = New FrmProductos
        mProductos.MdiParent = Me
        mProductos.Show()
        Me.MsgTextStatusBar(Nothing, False)
        'Else
        'ModComun.MsgInfo(Me.CTE_PERMISOS)
        'End If


    End Sub

    Private Sub PronosticosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PronosticosToolStripMenuItem.Click
        'Dim mFrm As Pronosticos = New Pronosticos

        Me.MsgTextStatusBar("Espere Iniciando Pronosticos", False)
        Pronosticos.MdiParent = Me
        Pronosticos.Show()
        Me.MsgTextStatusBar(Nothing, False)
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        'Dim mfrm As FrmConfig = New FrmConfig
        FrmConfig.MdiParent = Me
        FrmConfig.Show()

    End Sub

    Private Sub EnviosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviosToolStripMenuItem.Click
        'Dim MFrm As FrmGeneraArchivo = New FrmGeneraArchivo
        Me.MsgTextStatusBar("Espere Iniciando Envios", False)
        With FrmGeneraArchivo
            .MdiParent = Me
            .Show()


        End With
        Me.MsgTextStatusBar("Espere Iniciando Envios", False)
    End Sub

    

    Private Sub PruebasComunicacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PruebasComunicacionToolStripMenuItem.Click
        Dim mFrm As FrmTestWebServices = FrmTestWebServices
        mFrm.ShowDialog()
        mFrm.Dispose()


    End Sub

    Private Sub ClientesAgenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesAgenteToolStripMenuItem.Click
        Dim MFRM As New FrmCteMantenimiento

        'Dim MFRM As New FrmClienteProducto
        MFRM.MdiParent = Me
        MFRM.Show()

    End Sub

    Private Sub ImportarArchivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarArchivosToolStripMenuItem.Click
        Dim mForm As FrmImportar = FrmImportar
        mForm.MdiParent = Me
        mForm.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        'Dim mFrm As FrmUsuario
        If Me.pUsuario.EsSuperUsuario Then
            FrmUsuario.MdiParent = Me
            FrmUsuario.Show()
        Else
            MsgInfo(CTE_PERMISOS)

        End If
        


    End Sub

    Private Sub MDIPronosticos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MDIPronosticos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.CloseMensajero(True)
            If Me.MdiChildren.Count > 0 Then
                ModComun.MsgError("Primero cierre las ventanas abiertas")
                e.Cancel = True
                Exit Sub
            End If
            If Not ModComun.MsgYesNo("¿ Saldra del sistema esta seguro?", MessageBoxDefaultButton.Button2) Then
                e.Cancel = True
            End If
        Catch ex As Exception
            Me.MsgTextStatusBar(ex.Message, True)
        End Try
        




    End Sub

    
    
    Private Sub ProductosSapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmSapProductos.Show()

    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click, IndexToolStripMenuItem.Click, SearchToolStripMenuItem.Click
        ' Dim mCtrl As Control = sender
        Dim mIdTopic As String
        Select Case sender.Name
            Case "ContentsToolStripMenuItem" : mIdTopic = "1000"
            Case "IndexToolStripMenuItem" : mIdTopic = "0"
            Case "SearchToolStripMenuItem" : mIdTopic = "-1"
            Case Else
                mIdTopic = "1000"

        End Select


        ModComun.ShowHelpAppByTopicId(Me, mIdTopic)

    End Sub


    Private Sub DiasFestivosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiasFestivosToolStripMenuItem1.Click
        If Me.pUsuario.EsSuperUsuario Then

            Dim mFrm As FrmCalendarioFestivos = New FrmCalendarioFestivos

            With mFrm
                .MdiParent = Me

                .Show()
                .mBolConsultandoDatos = False

            End With
        Else
            ModComun.MsgInfo(CTE_PERMISOS)

        End If

    End Sub

    Private Sub VerPronosticosCentralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerPronosticosCentralToolStripMenuItem.Click
        FrmConsultaPronosticoGlobal.MdiParent = Me
        FrmConsultaPronosticoGlobal.Show()
    End Sub

    Private Sub ExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciasToolStripMenuItem.Click
        Me.MsgTextStatusBar("Espere Consulta de pronósticos sistema central", False)
        With FrmExistencias

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized

            .Show()
        End With
        Me.MsgTextStatusBar(Nothing, False)

    End Sub


    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        'Dim mForm As FrmMensaje
        Try
            MsgTextStatusBar(String.Format("Iniciando Servicio de Mensajes {0} ", Date.Now), False)
            Timer.Enabled = False
            With FrmMensaje
                .MdiParent = Me
                .BindData()
            End With
        Catch ex As Exception
            MsgTextStatusBar(String.Format("Error Servicio de Mensajes {0} ", ex.Message), False)
        End Try


        'Timer.Enabled = True

    End Sub

    Private Sub MDIPronosticos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Timer.Interval = My.Settings.TimerMensajes * 1000
            Me.Timer.Enabled = True

        Catch ex As Exception
            Me.MsgTextStatusBar(ex.Message, True)
        End Try


    End Sub
    ''' <summary>
    ''' Cierra la ventana del mensajero de manera interactiva.
    ''' </summary>
    ''' <param name="pBolSelectByUser">El usuario Selecciona Cerrar ventana interactivamente.</param>
    ''' <remarks></remarks>
    Public Sub CloseMensajero(pBolSelectByUser As Boolean)
        'FrmMensaje.Close()
        Try
            Dim mTxtMensaje As StringBuilder = New StringBuilder(String.Format("Fin Servicio de Mensajes {0} Próximo Inicio de consulta {1} ", Date.Now, Date.Now.AddMilliseconds(Me.Timer.Interval)))

            If pBolSelectByUser Then
                FrmMensaje.Dispose()
                mTxtMensaje.Append("Servicio detenido Interactivamente")
            Else
                FrmMensaje.Hide()
            End If
            Me.MsgTextStatusBar(mTxtMensaje.ToString(), pBolSelectByUser)

            Me.Timer.Enabled = True
        Catch ex As Exception
            Me.MsgTextStatusBar(ex.Message, True)
        End Try


    End Sub
    Public Sub MsgTextStatusBar(pMensaje As String, mbolIconError As Boolean)
        Try
            If mbolIconError Then
                Me.StatusLbl.Image = My.Resources.exclamation
            Else
                Me.StatusLbl.Image = Nothing
            End If
            Me.StatusLbl.Text = pMensaje
        Catch ex As Exception
            Me.StatusLbl.Text = ex.Message
        End Try


    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim mBld As StringBuilder = New StringBuilder()

        With My.Application.Info

            mBld.AppendLine(.Copyright)
            mBld.AppendLine("Compañia:" & .CompanyName)
            mBld.AppendLine(.Title)
            ' mBld.AppendLine(String.Format("Versión: {0}.{1}.{2}", .Version.Major, .Version.MinorRevision, .Version.Revision))

            
            ' mBld.AppendLine("Revision:" & mAsemlyName.Version.MajorRevision)
            Dim mAsembl = System.Reflection.Assembly.GetEntryAssembly()
            Dim mAsemlyName As System.Reflection.AssemblyName = mAsembl.GetName()
            Dim mVers As System.Version = mAsemlyName.Version
            mBld.AppendLine(String.Format("Versión:{0}", mVers))
            If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
                mBld.AppendLine(String.Format("Versión Distribución:{0}", System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()))

            End If








        End With

        ModComun.MsgInfo(mBld.ToString())
    End Sub
End Class
