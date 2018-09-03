<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPronosticos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPronosticos))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ProcesosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PronosticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPronosticosCentralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsultasSAPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerritoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesAgenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiasFestivosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PruebasComunicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.UsuarioTxtStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AllowMerge = False
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcesosToolStripMenuItem1, Me.FileMenu, Me.ProcesosToolStripMenuItem, Me.ViewMenu, Me.ToolsMenu, Me.WindowsMenu, Me.HelpMenu, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ProcesosToolStripMenuItem1
        '
        Me.ProcesosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PronosticosToolStripMenuItem, Me.EnviosToolStripMenuItem, Me.VerPronosticosCentralToolStripMenuItem, Me.ToolStripSeparator1, Me.ConsultasSAPToolStripMenuItem})
        Me.ProcesosToolStripMenuItem1.Name = "ProcesosToolStripMenuItem1"
        Me.ProcesosToolStripMenuItem1.Size = New System.Drawing.Size(62, 20)
        Me.ProcesosToolStripMenuItem1.Text = "Procesos"
        '
        'PronosticosToolStripMenuItem
        '
        Me.PronosticosToolStripMenuItem.Name = "PronosticosToolStripMenuItem"
        Me.PronosticosToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PronosticosToolStripMenuItem.Text = "Pronosticos"
        '
        'EnviosToolStripMenuItem
        '
        Me.EnviosToolStripMenuItem.Name = "EnviosToolStripMenuItem"
        Me.EnviosToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.EnviosToolStripMenuItem.Text = "Envios"
        '
        'VerPronosticosCentralToolStripMenuItem
        '
        Me.VerPronosticosCentralToolStripMenuItem.Name = "VerPronosticosCentralToolStripMenuItem"
        Me.VerPronosticosCentralToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.VerPronosticosCentralToolStripMenuItem.Text = "Ver Pronosticos central"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'ConsultasSAPToolStripMenuItem
        '
        Me.ConsultasSAPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExistenciasToolStripMenuItem})
        Me.ConsultasSAPToolStripMenuItem.Name = "ConsultasSAPToolStripMenuItem"
        Me.ConsultasSAPToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ConsultasSAPToolStripMenuItem.Text = "Consultas SAP"
        '
        'ExistenciasToolStripMenuItem
        '
        Me.ExistenciasToolStripMenuItem.Name = "ExistenciasToolStripMenuItem"
        Me.ExistenciasToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExistenciasToolStripMenuItem.Text = "Existencias"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator4, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PrintSetupToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(55, 20)
        Me.FileMenu.Text = "&Archivo"
        Me.FileMenu.Visible = False
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.NewToolStripMenuItem.Text = "&Nuevo"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.OpenToolStripMenuItem.Text = "&Abrir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(201, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.SaveToolStripMenuItem.Text = "&Guardar"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.SaveAsToolStripMenuItem.Text = "Guardar &como"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(201, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.PrintToolStripMenuItem.Text = "&Imprimir"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "&Vista previa de impresión"
        '
        'PrintSetupToolStripMenuItem
        '
        Me.PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        Me.PrintSetupToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.PrintSetupToolStripMenuItem.Text = "Configurar impresión"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(201, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TerritoriosToolStripMenuItem, Me.VendedoresToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ClientesAgenteToolStripMenuItem, Me.DiasFestivosToolStripMenuItem1})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ProcesosToolStripMenuItem.Text = "Catalogos"
        '
        'TerritoriosToolStripMenuItem
        '
        Me.TerritoriosToolStripMenuItem.Name = "TerritoriosToolStripMenuItem"
        Me.TerritoriosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.TerritoriosToolStripMenuItem.Text = "&Región"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.VendedoresToolStripMenuItem.Text = "V&endedores"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ProductosToolStripMenuItem.Text = "&Productos"
        '
        'ClientesAgenteToolStripMenuItem
        '
        Me.ClientesAgenteToolStripMenuItem.Name = "ClientesAgenteToolStripMenuItem"
        Me.ClientesAgenteToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ClientesAgenteToolStripMenuItem.Text = "C&lientes Agente"
        '
        'DiasFestivosToolStripMenuItem1
        '
        Me.DiasFestivosToolStripMenuItem1.Name = "DiasFestivosToolStripMenuItem1"
        Me.DiasFestivosToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.DiasFestivosToolStripMenuItem1.Text = "&Dias Festivos"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(35, 20)
        Me.ViewMenu.Text = "&Ver"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ToolBarToolStripMenuItem.Text = "&Barra de herramientas"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Barra de estado"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.PruebasComunicacionToolStripMenuItem, Me.ImportarArchivosToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(83, 20)
        Me.ToolsMenu.Text = "&Herramientas"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.OptionsToolStripMenuItem.Text = "&Opciones"
        '
        'PruebasComunicacionToolStripMenuItem
        '
        Me.PruebasComunicacionToolStripMenuItem.Name = "PruebasComunicacionToolStripMenuItem"
        Me.PruebasComunicacionToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.PruebasComunicacionToolStripMenuItem.Text = "PruebasComunicacion"
        '
        'ImportarArchivosToolStripMenuItem
        '
        Me.ImportarArchivosToolStripMenuItem.Name = "ImportarArchivosToolStripMenuItem"
        Me.ImportarArchivosToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ImportarArchivosToolStripMenuItem.Text = "ImportarArchivos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(64, 20)
        Me.WindowsMenu.Text = "&Ventanas"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(50, 20)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contenido"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SearchToolStripMenuItem.Text = "&Buscar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(175, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioTxtStatus, Me.StatusLbl})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'UsuarioTxtStatus
        '
        Me.UsuarioTxtStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.UsuarioTxtStatus.Name = "UsuarioTxtStatus"
        Me.UsuarioTxtStatus.Size = New System.Drawing.Size(4, 17)
        '
        'StatusLbl
        '
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(40, 17)
        Me.StatusLbl.Text = "Estado"
        '
        'Timer
        '
        Me.Timer.Interval = 3000
        '
        'MDIPronosticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIPronosticos"
        Me.Text = "Sistema de Pronosticos Polaquimia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusLbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerritoriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PronosticosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioTxtStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PruebasComunicacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesAgenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiasFestivosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerPronosticosCentralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasSAPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExistenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
