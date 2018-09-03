<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPronosticosAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPronosticosAlmacen))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PronosticosToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PegarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PanelFrm = New System.Windows.Forms.Panel()
        Me.TabPronosticos = New System.Windows.Forms.TabControl()
        Me.TabMaestro = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AgentesBtn = New System.Windows.Forms.Button()
        Me.NoPronosticoTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CveAgenteTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FinDTP = New System.Windows.Forms.DateTimePicker()
        Me.InicioDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TipoPeriodoCbo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PronosticoBtn = New System.Windows.Forms.Button()
        Me.ZonaAgentesBtn = New System.Windows.Forms.Button()
        Me.ZonasTxt = New System.Windows.Forms.TextBox()
        Me.lblAgenteTxt = New System.Windows.Forms.Label()
        Me.NombreAgenteLabel = New System.Windows.Forms.Label()
        Me.TabDetalle = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.CboAlmacen = New System.Windows.Forms.ComboBox()
        Me.RegionLbl = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboCentroFiltro = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NomAgentelbl = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Cbocliente = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ZonaLabel = New System.Windows.Forms.Label()
        Me.lblCongelado = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabOpciones = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkUnidadAlterna = New System.Windows.Forms.CheckBox()
        Me.ChkOpcVerColumnas = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ALMACENPRONOSTICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.PronosticoErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ALMACENPRONOSTICOTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.ALMACENPRONOSTICOTableAdapter()
        Me.PronosticosToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BGWK = New System.ComponentModel.BackgroundWorker()
        Me.AutoSaveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RepartosItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PronosticosToolStrip.SuspendLayout()
        Me.PanelFrm.SuspendLayout()
        Me.TabPronosticos.SuspendLayout()
        Me.TabMaestro.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabOpciones.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ALMACENPRONOSTICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PronosticoErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PronosticosToolStrip)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelFrm)
        Me.SplitContainer1.Size = New System.Drawing.Size(1085, 567)
        Me.SplitContainer1.SplitterDistance = 27
        Me.SplitContainer1.TabIndex = 3
        '
        'PronosticosToolStrip
        '
        Me.PronosticosToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.CortarToolStripButton, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton})
        Me.PronosticosToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.PronosticosToolStrip.Name = "PronosticosToolStrip"
        Me.PronosticosToolStrip.Size = New System.Drawing.Size(1085, 25)
        Me.PronosticosToolStrip.TabIndex = 3
        Me.PronosticosToolStrip.Text = "ToolStrip1"
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevoToolStripButton.Text = "&Nuevo"
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), System.Drawing.Image)
        Me.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        Me.AbrirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AbrirToolStripButton.Text = "&Abrir"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton.Text = "&Guardar"
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CortarToolStripButton
        '
        Me.CortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CortarToolStripButton.Image = CType(resources.GetObject("CortarToolStripButton.Image"), System.Drawing.Image)
        Me.CortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CortarToolStripButton.Name = "CortarToolStripButton"
        Me.CortarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CortarToolStripButton.Text = "Cort&ar"
        '
        'CopiarToolStripButton
        '
        Me.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), System.Drawing.Image)
        Me.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripButton.Name = "CopiarToolStripButton"
        Me.CopiarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopiarToolStripButton.Text = "&Copiar"
        '
        'PegarToolStripButton
        '
        Me.PegarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PegarToolStripButton.Image = CType(resources.GetObject("PegarToolStripButton.Image"), System.Drawing.Image)
        Me.PegarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PegarToolStripButton.Name = "PegarToolStripButton"
        Me.PegarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PegarToolStripButton.Text = "&Pegar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AyudaToolStripButton
        '
        Me.AyudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), System.Drawing.Image)
        Me.AyudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaToolStripButton.Name = "AyudaToolStripButton"
        Me.AyudaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AyudaToolStripButton.Text = "Ay&uda"
        '
        'PanelFrm
        '
        Me.PanelFrm.Controls.Add(Me.TabPronosticos)
        Me.PanelFrm.Controls.Add(Me.StatusStrip1)
        Me.PanelFrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFrm.Location = New System.Drawing.Point(0, 0)
        Me.PanelFrm.Name = "PanelFrm"
        Me.PanelFrm.Size = New System.Drawing.Size(1085, 536)
        Me.PanelFrm.TabIndex = 15
        '
        'TabPronosticos
        '
        Me.TabPronosticos.Controls.Add(Me.TabMaestro)
        Me.TabPronosticos.Controls.Add(Me.TabDetalle)
        Me.TabPronosticos.Controls.Add(Me.TabOpciones)
        Me.TabPronosticos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPronosticos.Location = New System.Drawing.Point(0, 0)
        Me.TabPronosticos.Name = "TabPronosticos"
        Me.TabPronosticos.SelectedIndex = 0
        Me.TabPronosticos.Size = New System.Drawing.Size(1085, 514)
        Me.TabPronosticos.TabIndex = 1
        '
        'TabMaestro
        '
        Me.TabMaestro.Controls.Add(Me.TableLayoutPanel1)
        Me.TabMaestro.Controls.Add(Me.NombreAgenteLabel)
        Me.TabMaestro.Location = New System.Drawing.Point(4, 22)
        Me.TabMaestro.Name = "TabMaestro"
        Me.TabMaestro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMaestro.Size = New System.Drawing.Size(1077, 488)
        Me.TabMaestro.TabIndex = 0
        Me.TabMaestro.Text = "Maestro"
        Me.TabMaestro.ToolTipText = "Defne los parametros iniciales."
        Me.TabMaestro.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.2116!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.50806!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.86681!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.62836!))
        Me.TableLayoutPanel1.Controls.Add(Me.AgentesBtn, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NoPronosticoTxt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CveAgenteTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FinDTP, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.InicioDTP, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TipoPeriodoCbo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PronosticoBtn, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ZonaAgentesBtn, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ZonasTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAgenteTxt, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.037826!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.328606!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.929079!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.510639!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.19386!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1071, 420)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'AgentesBtn
        '
        Me.AgentesBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.AgentesBtn.Location = New System.Drawing.Point(331, 35)
        Me.AgentesBtn.Name = "AgentesBtn"
        Me.AgentesBtn.Size = New System.Drawing.Size(29, 23)
        Me.AgentesBtn.TabIndex = 5
        Me.PronosticosToolTip.SetToolTip(Me.AgentesBtn, "Buscar agentes")
        Me.AgentesBtn.UseVisualStyleBackColor = True
        '
        'NoPronosticoTxt
        '
        Me.NoPronosticoTxt.Location = New System.Drawing.Point(144, 3)
        Me.NoPronosticoTxt.Name = "NoPronosticoTxt"
        Me.NoPronosticoTxt.Size = New System.Drawing.Size(100, 20)
        Me.NoPronosticoTxt.TabIndex = 1
        Me.PronosticosToolTip.SetToolTip(Me.NoPronosticoTxt, "Pronostico a consuiltar o crear")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "TipoPeriodo"
        '
        'CveAgenteTxt
        '
        Me.CveAgenteTxt.Location = New System.Drawing.Point(144, 35)
        Me.CveAgenteTxt.MaxLength = 6
        Me.CveAgenteTxt.Name = "CveAgenteTxt"
        Me.CveAgenteTxt.Size = New System.Drawing.Size(100, 20)
        Me.CveAgenteTxt.TabIndex = 4
        Me.PronosticosToolTip.SetToolTip(Me.CveAgenteTxt, "Indique su clave de agente")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Vigencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Zona/Territotio"
        '
        'FinDTP
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.FinDTP, 2)
        Me.FinDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FinDTP.Location = New System.Drawing.Point(331, 103)
        Me.FinDTP.Name = "FinDTP"
        Me.FinDTP.Size = New System.Drawing.Size(121, 20)
        Me.FinDTP.TabIndex = 12
        Me.PronosticosToolTip.SetToolTip(Me.FinDTP, "La fecha debe ser mayor a la inicial")
        '
        'InicioDTP
        '
        Me.InicioDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.InicioDTP.Location = New System.Drawing.Point(144, 103)
        Me.InicioDTP.Name = "InicioDTP"
        Me.InicioDTP.Size = New System.Drawing.Size(121, 20)
        Me.InicioDTP.TabIndex = 11
        Me.PronosticosToolTip.SetToolTip(Me.InicioDTP, "La fecha debe ser menor a la final")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cve. Agente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TipoPeriodoCbo
        '
        Me.TipoPeriodoCbo.FormattingEnabled = True
        Me.TipoPeriodoCbo.Items.AddRange(New Object() {"W:Semana", "M:Mes"})
        Me.TipoPeriodoCbo.Location = New System.Drawing.Point(144, 137)
        Me.TipoPeriodoCbo.Name = "TipoPeriodoCbo"
        Me.TipoPeriodoCbo.Size = New System.Drawing.Size(121, 21)
        Me.TipoPeriodoCbo.TabIndex = 14
        Me.PronosticosToolTip.SetToolTip(Me.TipoPeriodoCbo, "Indicar si el periodo es semanal o mensual")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "No. Pronostico"
        '
        'PronosticoBtn
        '
        Me.PronosticoBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.PronosticoBtn.Location = New System.Drawing.Point(331, 3)
        Me.PronosticoBtn.Name = "PronosticoBtn"
        Me.PronosticoBtn.Size = New System.Drawing.Size(29, 23)
        Me.PronosticoBtn.TabIndex = 2
        Me.PronosticosToolTip.SetToolTip(Me.PronosticoBtn, "Buscar pronosticos")
        Me.PronosticoBtn.UseVisualStyleBackColor = True
        '
        'ZonaAgentesBtn
        '
        Me.ZonaAgentesBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.ZonaAgentesBtn.Location = New System.Drawing.Point(331, 64)
        Me.ZonaAgentesBtn.Name = "ZonaAgentesBtn"
        Me.ZonaAgentesBtn.Size = New System.Drawing.Size(29, 23)
        Me.ZonaAgentesBtn.TabIndex = 9
        Me.PronosticosToolTip.SetToolTip(Me.ZonaAgentesBtn, "Buscar Zona o territorio")
        Me.ZonaAgentesBtn.UseVisualStyleBackColor = True
        '
        'ZonasTxt
        '
        Me.ZonasTxt.Enabled = False
        Me.ZonasTxt.Location = New System.Drawing.Point(144, 64)
        Me.ZonasTxt.Name = "ZonasTxt"
        Me.ZonasTxt.Size = New System.Drawing.Size(100, 20)
        Me.ZonasTxt.TabIndex = 8
        '
        'lblAgenteTxt
        '
        Me.lblAgenteTxt.AutoSize = True
        Me.lblAgenteTxt.Location = New System.Drawing.Point(372, 32)
        Me.lblAgenteTxt.Name = "lblAgenteTxt"
        Me.lblAgenteTxt.Size = New System.Drawing.Size(0, 13)
        Me.lblAgenteTxt.TabIndex = 6
        '
        'NombreAgenteLabel
        '
        Me.NombreAgenteLabel.AutoSize = True
        Me.NombreAgenteLabel.Location = New System.Drawing.Point(202, 59)
        Me.NombreAgenteLabel.Name = "NombreAgenteLabel"
        Me.NombreAgenteLabel.Size = New System.Drawing.Size(0, 13)
        Me.NombreAgenteLabel.TabIndex = 2
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.TableLayoutPanel2)
        Me.TabDetalle.Location = New System.Drawing.Point(4, 22)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetalle.Size = New System.Drawing.Size(1077, 488)
        Me.TabDetalle.TabIndex = 1
        Me.TabDetalle.Text = "Detalle"
        Me.TabDetalle.ToolTipText = "Capure su pronostico aqu'i"
        Me.TabDetalle.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.6747!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.3253!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 345.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.CboAlmacen, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.RegionLbl, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridView1, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CboCentroFiltro, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NomAgentelbl, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCliente, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Cbocliente, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ZonaLabel, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCongelado, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 2, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.75646!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.23608!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.904232!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.681514!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.93318!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1071, 482)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'CboAlmacen
        '
        Me.CboAlmacen.FormattingEnabled = True
        Me.CboAlmacen.Location = New System.Drawing.Point(487, 125)
        Me.CboAlmacen.Name = "CboAlmacen"
        Me.CboAlmacen.Size = New System.Drawing.Size(223, 21)
        Me.CboAlmacen.TabIndex = 13
        '
        'RegionLbl
        '
        Me.RegionLbl.AutoSize = True
        Me.RegionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionLbl.ForeColor = System.Drawing.Color.Black
        Me.RegionLbl.Location = New System.Drawing.Point(3, 46)
        Me.RegionLbl.Name = "RegionLbl"
        Me.RegionLbl.Size = New System.Drawing.Size(104, 29)
        Me.RegionLbl.TabIndex = 12
        Me.RegionLbl.Text = "Región:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel2.SetColumnSpan(Me.DataGridView1, 5)
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1065, 297)
        Me.DataGridView1.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Centro:"
        '
        'CboCentroFiltro
        '
        Me.CboCentroFiltro.FormattingEnabled = True
        Me.CboCentroFiltro.Location = New System.Drawing.Point(122, 125)
        Me.CboCentroFiltro.Name = "CboCentroFiltro"
        Me.CboCentroFiltro.Size = New System.Drawing.Size(223, 21)
        Me.CboCentroFiltro.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label6, 3)
        Me.Label6.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 32)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Pronósticos de Ventas:"
        '
        'NomAgentelbl
        '
        Me.NomAgentelbl.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.NomAgentelbl, 2)
        Me.NomAgentelbl.Font = New System.Drawing.Font("Arial", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomAgentelbl.ForeColor = System.Drawing.Color.Blue
        Me.NomAgentelbl.Location = New System.Drawing.Point(487, 0)
        Me.NomAgentelbl.Name = "NomAgentelbl"
        Me.NomAgentelbl.Size = New System.Drawing.Size(264, 42)
        Me.NomAgentelbl.TabIndex = 1
        Me.NomAgentelbl.Text = "(SIN DEFINIR)"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(3, 151)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(45, 13)
        Me.lblCliente.TabIndex = 9
        Me.lblCliente.Text = "Cliente::"
        '
        'Cbocliente
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.Cbocliente, 3)
        Me.Cbocliente.DisplayMember = "displlay"
        Me.Cbocliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cbocliente.FormattingEnabled = True
        Me.Cbocliente.Location = New System.Drawing.Point(122, 154)
        Me.Cbocliente.Name = "Cbocliente"
        Me.Cbocliente.Size = New System.Drawing.Size(704, 21)
        Me.Cbocliente.TabIndex = 10
        Me.Cbocliente.ValueMember = "value"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(832, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Filtrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ZonaLabel
        '
        Me.ZonaLabel.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.ZonaLabel, 2)
        Me.ZonaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZonaLabel.ForeColor = System.Drawing.Color.Blue
        Me.ZonaLabel.Location = New System.Drawing.Point(122, 46)
        Me.ZonaLabel.Name = "ZonaLabel"
        Me.ZonaLabel.Size = New System.Drawing.Size(256, 29)
        Me.ZonaLabel.TabIndex = 2
        Me.ZonaLabel.Text = "(Zona Sin Identificar)"
        '
        'lblCongelado
        '
        Me.lblCongelado.AutoSize = True
        Me.lblCongelado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCongelado.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCongelado.Location = New System.Drawing.Point(487, 46)
        Me.lblCongelado.Name = "lblCongelado"
        Me.lblCongelado.Size = New System.Drawing.Size(170, 20)
        Me.lblCongelado.TabIndex = 3
        Me.lblCongelado.Text = "Editable (sin definir)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(418, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Almacen"
        '
        'TabOpciones
        '
        Me.TabOpciones.Controls.Add(Me.TableLayoutPanel3)
        Me.TabOpciones.Location = New System.Drawing.Point(4, 22)
        Me.TabOpciones.Name = "TabOpciones"
        Me.TabOpciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TabOpciones.Size = New System.Drawing.Size(1077, 488)
        Me.TabOpciones.TabIndex = 2
        Me.TabOpciones.Text = "Opciones"
        Me.TabOpciones.ToolTipText = "Personalizar la captura"
        Me.TabOpciones.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.ChkUnidadAlterna, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ChkOpcVerColumnas, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1071, 482)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'ChkUnidadAlterna
        '
        Me.ChkUnidadAlterna.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.ChkUnidadAlterna, 2)
        Me.ChkUnidadAlterna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUnidadAlterna.Location = New System.Drawing.Point(3, 26)
        Me.ChkUnidadAlterna.Name = "ChkUnidadAlterna"
        Me.ChkUnidadAlterna.Size = New System.Drawing.Size(231, 20)
        Me.ChkUnidadAlterna.TabIndex = 1
        Me.ChkUnidadAlterna.Text = "Capturar en Unidad  de Venta"
        Me.ChkUnidadAlterna.UseVisualStyleBackColor = True
        '
        'ChkOpcVerColumnas
        '
        Me.ChkOpcVerColumnas.AutoSize = True
        Me.ChkOpcVerColumnas.Location = New System.Drawing.Point(3, 3)
        Me.ChkOpcVerColumnas.Name = "ChkOpcVerColumnas"
        Me.ChkOpcVerColumnas.Size = New System.Drawing.Size(148, 17)
        Me.ChkOpcVerColumnas.TabIndex = 0
        Me.ChkOpcVerColumnas.Text = "Ocultar Periodos cerrados"
        Me.ChkOpcVerColumnas.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar, Me.ToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 514)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1085, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar
        '
        Me.ToolStripProgressBar.Name = "ToolStripProgressBar"
        Me.ToolStripProgressBar.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(4, 17)
        '
        'ALMACENPRONOSTICOBindingSource
        '
        Me.ALMACENPRONOSTICOBindingSource.DataMember = "ALMACENPRONOSTICO"
        Me.ALMACENPRONOSTICOBindingSource.DataSource = Me.SapForecastDataSet
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PronosticoErrProvider
        '
        Me.PronosticoErrProvider.ContainerControl = Me
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1085, 542)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1085, 567)
        Me.ToolStripContainer1.TabIndex = 13
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ALMACENPRONOSTICOTableAdapter
        '
        Me.ALMACENPRONOSTICOTableAdapter.ClearBeforeFill = True
        '
        'BGWK
        '
        Me.BGWK.WorkerReportsProgress = True
        '
        'AutoSaveTimer
        '
        '
        'RepartosItem
        '
        Me.RepartosItem.Name = "RepartosItem"
        Me.RepartosItem.Size = New System.Drawing.Size(61, 4)
        Me.RepartosItem.Text = "Repartos"
        '
        'FrmPronosticosAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 567)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "FrmPronosticosAlmacen"
        Me.Text = "Registro Forecast"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PronosticosToolStrip.ResumeLayout(False)
        Me.PronosticosToolStrip.PerformLayout()
        Me.PanelFrm.ResumeLayout(False)
        Me.PanelFrm.PerformLayout()
        Me.TabPronosticos.ResumeLayout(False)
        Me.TabMaestro.ResumeLayout(False)
        Me.TabMaestro.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabDetalle.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabOpciones.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ALMACENPRONOSTICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PronosticoErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PronosticosToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AbrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CortarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopiarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PegarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PronosticoErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ALMACENPRONOSTICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents ALMACENPRONOSTICOTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.ALMACENPRONOSTICOTableAdapter
    Friend WithEvents PanelFrm As System.Windows.Forms.Panel
    Friend WithEvents TabPronosticos As System.Windows.Forms.TabControl
    Friend WithEvents TabMaestro As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AgentesBtn As System.Windows.Forms.Button
    Friend WithEvents NoPronosticoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CveAgenteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FinDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents InicioDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TipoPeriodoCbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PronosticoBtn As System.Windows.Forms.Button
    Friend WithEvents ZonaAgentesBtn As System.Windows.Forms.Button
    Friend WithEvents ZonasTxt As System.Windows.Forms.TextBox
    Friend WithEvents lblAgenteTxt As System.Windows.Forms.Label
    Friend WithEvents NombreAgenteLabel As System.Windows.Forms.Label
    Friend WithEvents TabDetalle As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboCentroFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents ZonaLabel As System.Windows.Forms.Label
    Friend WithEvents lblCongelado As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NomAgentelbl As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents Cbocliente As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TabOpciones As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ChkOpcVerColumnas As System.Windows.Forms.CheckBox
    Friend WithEvents PronosticosToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ChkUnidadAlterna As System.Windows.Forms.CheckBox
    Friend WithEvents BGWK As System.ComponentModel.BackgroundWorker
    Friend WithEvents RegionLbl As System.Windows.Forms.Label
    Friend WithEvents AutoSaveTimer As System.Windows.Forms.Timer
    Friend WithEvents CboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RepartosItem As System.Windows.Forms.ContextMenuStrip

End Class
