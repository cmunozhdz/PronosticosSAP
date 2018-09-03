<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pronosticos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pronosticos))
        Me.PronosticoErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.ZonasTxt = New System.Windows.Forms.TextBox()
        Me.lblAgenteTxt = New System.Windows.Forms.Label()
        Me.DescPronosticoTxt = New System.Windows.Forms.TextBox()
        Me.TerritorioLbl = New System.Windows.Forms.Label()
        Me.NombreAgenteLabel = New System.Windows.Forms.Label()
        Me.TabDetalle = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RegionLbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboCentroFiltro = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Cbocliente = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ZonaLabel = New System.Windows.Forms.Label()
        Me.NomAgentelbl = New System.Windows.Forms.Label()
        Me.lblCongelado = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TotalesGrd = New System.Windows.Forms.DataGridView()
        Me.TabOpciones = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkOpcVerColumnas = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AutoGuardadoOpcion = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ChkActivos = New System.Windows.Forms.CheckBox()
        Me.PronosticosToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BGWK = New System.ComponentModel.BackgroundWorker()
        Me.AutoSaveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PronosticosCm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GuardarMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepartosMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoricosMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VentasMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresupuestoMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RepartosItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALMACENPRONOSTICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        Me.PronosticosToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddProductoBtn = New System.Windows.Forms.ToolStripButton()
        Me.BtnOcultar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PegarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.EstatusBarTxt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PronosticoErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPronosticos.SuspendLayout()
        Me.TabMaestro.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalesGrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabOpciones.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.AutoGuardadoOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PronosticosCm.SuspendLayout()
        CType(Me.ALMACENPRONOSTICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PronosticosToolStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PronosticoErrProvider
        '
        Me.PronosticoErrProvider.ContainerControl = Me
        '
        'TabPronosticos
        '
        Me.TabPronosticos.Controls.Add(Me.TabMaestro)
        Me.TabPronosticos.Controls.Add(Me.TabDetalle)
        Me.TabPronosticos.Controls.Add(Me.TabOpciones)
        Me.TabPronosticos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPronosticos.Location = New System.Drawing.Point(3, 3)
        Me.TabPronosticos.Name = "TabPronosticos"
        Me.TabPronosticos.SelectedIndex = 0
        Me.TabPronosticos.Size = New System.Drawing.Size(1022, 514)
        Me.TabPronosticos.TabIndex = 16
        '
        'TabMaestro
        '
        Me.TabMaestro.Controls.Add(Me.TableLayoutPanel1)
        Me.TabMaestro.Controls.Add(Me.NombreAgenteLabel)
        Me.TabMaestro.Location = New System.Drawing.Point(4, 22)
        Me.TabMaestro.Name = "TabMaestro"
        Me.TabMaestro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMaestro.Size = New System.Drawing.Size(1014, 488)
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
        Me.TableLayoutPanel1.Controls.Add(Me.ZonasTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAgenteTxt, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DescPronosticoTxt, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TerritorioLbl, 2, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.037826!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.328606!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.929079!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.510639!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.19386!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1014, 420)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'AgentesBtn
        '
        Me.AgentesBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.AgentesBtn.Location = New System.Drawing.Point(313, 35)
        Me.AgentesBtn.Name = "AgentesBtn"
        Me.AgentesBtn.Size = New System.Drawing.Size(29, 23)
        Me.AgentesBtn.TabIndex = 5
        Me.PronosticosToolTip.SetToolTip(Me.AgentesBtn, "Buscar agentes")
        Me.AgentesBtn.UseVisualStyleBackColor = True
        '
        'NoPronosticoTxt
        '
        Me.NoPronosticoTxt.Location = New System.Drawing.Point(136, 3)
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
        Me.CveAgenteTxt.Location = New System.Drawing.Point(136, 35)
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
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Territorio"
        '
        'FinDTP
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.FinDTP, 2)
        Me.FinDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FinDTP.Location = New System.Drawing.Point(313, 103)
        Me.FinDTP.Name = "FinDTP"
        Me.FinDTP.Size = New System.Drawing.Size(121, 20)
        Me.FinDTP.TabIndex = 12
        Me.PronosticosToolTip.SetToolTip(Me.FinDTP, "La fecha debe ser mayor a la inicial")
        '
        'InicioDTP
        '
        Me.InicioDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.InicioDTP.Location = New System.Drawing.Point(136, 103)
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
        Me.TipoPeriodoCbo.Location = New System.Drawing.Point(136, 137)
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
        Me.PronosticoBtn.Location = New System.Drawing.Point(313, 3)
        Me.PronosticoBtn.Name = "PronosticoBtn"
        Me.PronosticoBtn.Size = New System.Drawing.Size(29, 23)
        Me.PronosticoBtn.TabIndex = 2
        Me.PronosticosToolTip.SetToolTip(Me.PronosticoBtn, "Buscar pronosticos")
        Me.PronosticoBtn.UseVisualStyleBackColor = True
        '
        'ZonasTxt
        '
        Me.ZonasTxt.Enabled = False
        Me.ZonasTxt.Location = New System.Drawing.Point(136, 64)
        Me.ZonasTxt.Name = "ZonasTxt"
        Me.ZonasTxt.Size = New System.Drawing.Size(100, 20)
        Me.ZonasTxt.TabIndex = 8
        '
        'lblAgenteTxt
        '
        Me.lblAgenteTxt.AutoSize = True
        Me.lblAgenteTxt.Location = New System.Drawing.Point(352, 32)
        Me.lblAgenteTxt.Name = "lblAgenteTxt"
        Me.lblAgenteTxt.Size = New System.Drawing.Size(0, 13)
        Me.lblAgenteTxt.TabIndex = 6
        '
        'DescPronosticoTxt
        '
        Me.DescPronosticoTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.DescPronosticoTxt.Location = New System.Drawing.Point(352, 3)
        Me.DescPronosticoTxt.MaxLength = 255
        Me.DescPronosticoTxt.Name = "DescPronosticoTxt"
        Me.DescPronosticoTxt.Size = New System.Drawing.Size(659, 20)
        Me.DescPronosticoTxt.TabIndex = 15
        '
        'TerritorioLbl
        '
        Me.TerritorioLbl.AutoSize = True
        Me.TerritorioLbl.Location = New System.Drawing.Point(313, 61)
        Me.TerritorioLbl.Name = "TerritorioLbl"
        Me.TerritorioLbl.Size = New System.Drawing.Size(0, 13)
        Me.TerritorioLbl.TabIndex = 16
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
        Me.TabDetalle.Size = New System.Drawing.Size(1014, 488)
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
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 297.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RegionLbl, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CboCentroFiltro, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCliente, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Cbocliente, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ZonaLabel, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.NomAgentelbl, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCongelado, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SplitContainer2, 0, 7)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1008, 482)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'RegionLbl
        '
        Me.RegionLbl.AutoSize = True
        Me.RegionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionLbl.ForeColor = System.Drawing.Color.Black
        Me.RegionLbl.Location = New System.Drawing.Point(3, 64)
        Me.RegionLbl.Name = "RegionLbl"
        Me.RegionLbl.Size = New System.Drawing.Size(68, 58)
        Me.RegionLbl.TabIndex = 12
        Me.RegionLbl.Text = "Región:"
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
        Me.CboCentroFiltro.Location = New System.Drawing.Point(88, 125)
        Me.CboCentroFiltro.Name = "CboCentroFiltro"
        Me.CboCentroFiltro.Size = New System.Drawing.Size(195, 21)
        Me.CboCentroFiltro.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label6, 2)
        Me.Label6.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 64)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Pronósticos de Ventas:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(3, 149)
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
        Me.Cbocliente.Location = New System.Drawing.Point(88, 152)
        Me.Cbocliente.Name = "Cbocliente"
        Me.Cbocliente.Size = New System.Drawing.Size(619, 21)
        Me.Cbocliente.TabIndex = 10
        Me.Cbocliente.ValueMember = "value"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Filtrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ZonaLabel
        '
        Me.ZonaLabel.AutoSize = True
        Me.ZonaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZonaLabel.ForeColor = System.Drawing.Color.Blue
        Me.ZonaLabel.Location = New System.Drawing.Point(88, 64)
        Me.ZonaLabel.Name = "ZonaLabel"
        Me.ZonaLabel.Size = New System.Drawing.Size(137, 58)
        Me.ZonaLabel.TabIndex = 2
        Me.ZonaLabel.Text = "(Zona Sin Identificar)"
        '
        'NomAgentelbl
        '
        Me.NomAgentelbl.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.NomAgentelbl, 2)
        Me.NomAgentelbl.Font = New System.Drawing.Font("Arial", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomAgentelbl.ForeColor = System.Drawing.Color.Blue
        Me.NomAgentelbl.Location = New System.Drawing.Point(299, 0)
        Me.NomAgentelbl.Name = "NomAgentelbl"
        Me.NomAgentelbl.Size = New System.Drawing.Size(264, 42)
        Me.NomAgentelbl.TabIndex = 1
        Me.NomAgentelbl.Text = "(SIN DEFINIR)"
        '
        'lblCongelado
        '
        Me.lblCongelado.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lblCongelado, 3)
        Me.lblCongelado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCongelado.ForeColor = System.Drawing.Color.Green
        Me.lblCongelado.Location = New System.Drawing.Point(299, 64)
        Me.lblCongelado.Name = "lblCongelado"
        Me.TableLayoutPanel2.SetRowSpan(Me.lblCongelado, 2)
        Me.lblCongelado.Size = New System.Drawing.Size(170, 20)
        Me.lblCongelado.TabIndex = 3
        Me.lblCongelado.Text = "Editable (sin definir)"
        '
        'SplitContainer2
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.SplitContainer2, 5)
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 179)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DataGridView1)
        Me.SplitContainer2.Panel1MinSize = 0
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TotalesGrd)
        Me.SplitContainer2.Size = New System.Drawing.Size(1002, 350)
        Me.SplitContainer2.SplitterDistance = 263
        Me.SplitContainer2.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1002, 263)
        Me.DataGridView1.TabIndex = 13
        '
        'TotalesGrd
        '
        Me.TotalesGrd.AllowUserToAddRows = False
        Me.TotalesGrd.AllowUserToDeleteRows = False
        Me.TotalesGrd.AllowUserToOrderColumns = True
        Me.TotalesGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.TotalesGrd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.TotalesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TotalesGrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalesGrd.Location = New System.Drawing.Point(0, 0)
        Me.TotalesGrd.Name = "TotalesGrd"
        Me.TotalesGrd.Size = New System.Drawing.Size(1002, 83)
        Me.TotalesGrd.TabIndex = 14
        '
        'TabOpciones
        '
        Me.TabOpciones.Controls.Add(Me.TableLayoutPanel3)
        Me.TabOpciones.Location = New System.Drawing.Point(4, 22)
        Me.TabOpciones.Name = "TabOpciones"
        Me.TabOpciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TabOpciones.Size = New System.Drawing.Size(1014, 488)
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
        Me.TableLayoutPanel3.Controls.Add(Me.ChkOpcVerColumnas, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.AutoGuardadoOpcion, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Button2, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.ChkActivos, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1008, 482)
        Me.TableLayoutPanel3.TabIndex = 0
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Auto Guardado en  Segundos"
        '
        'AutoGuardadoOpcion
        '
        Me.AutoGuardadoOpcion.Location = New System.Drawing.Point(157, 26)
        Me.AutoGuardadoOpcion.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.AutoGuardadoOpcion.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.AutoGuardadoOpcion.Name = "AutoGuardadoOpcion"
        Me.AutoGuardadoOpcion.Size = New System.Drawing.Size(120, 20)
        Me.AutoGuardadoOpcion.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Guardar Opciones"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ChkActivos
        '
        Me.ChkActivos.AutoSize = True
        Me.ChkActivos.Checked = Global.PronosticosSAP.My.MySettings.Default.ProductosVisibles
        Me.ChkActivos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkActivos.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.PronosticosSAP.My.MySettings.Default, "ProductosVisibles", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChkActivos.Location = New System.Drawing.Point(157, 3)
        Me.ChkActivos.Name = "ChkActivos"
        Me.ChkActivos.Size = New System.Drawing.Size(85, 17)
        Me.ChkActivos.TabIndex = 4
        Me.ChkActivos.Text = "Solo Visibles"
        Me.ChkActivos.UseVisualStyleBackColor = True
        '
        'BGWK
        '
        Me.BGWK.WorkerReportsProgress = True
        Me.BGWK.WorkerSupportsCancellation = True
        '
        'AutoSaveTimer
        '
        '
        'PronosticosCm
        '
        Me.PronosticosCm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarMnuItem, Me.RepartosMenuItem, Me.HistoricosMnu, Me.ToolStripSeparator2, Me.VentasMenuItem, Me.ToolStripSeparator3})
        Me.PronosticosCm.Name = "PronosticosCm"
        Me.PronosticosCm.Size = New System.Drawing.Size(176, 104)
        '
        'GuardarMnuItem
        '
        Me.GuardarMnuItem.Image = Global.PronosticosSAP.My.Resources.Resources.disk_multiple
        Me.GuardarMnuItem.Name = "GuardarMnuItem"
        Me.GuardarMnuItem.Size = New System.Drawing.Size(175, 22)
        Me.GuardarMnuItem.Text = "Guardar "
        '
        'RepartosMenuItem
        '
        Me.RepartosMenuItem.Image = Global.PronosticosSAP.My.Resources.Resources.page_add
        Me.RepartosMenuItem.Name = "RepartosMenuItem"
        Me.RepartosMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.RepartosMenuItem.Text = "&Repartos"
        '
        'HistoricosMnu
        '
        Me.HistoricosMnu.Name = "HistoricosMnu"
        Me.HistoricosMnu.Size = New System.Drawing.Size(175, 22)
        Me.HistoricosMnu.Text = "Ver Modificaciones"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(172, 6)
        '
        'VentasMenuItem
        '
        Me.VentasMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasMnu, Me.PresupuestoMnu})
        Me.VentasMenuItem.Image = Global.PronosticosSAP.My.Resources.Resources.folder_database
        Me.VentasMenuItem.Name = "VentasMenuItem"
        Me.VentasMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.VentasMenuItem.Text = "&Historicos"
        '
        'VentasMnu
        '
        Me.VentasMnu.Name = "VentasMnu"
        Me.VentasMnu.Size = New System.Drawing.Size(156, 22)
        Me.VentasMnu.Text = "Ventas"
        '
        'PresupuestoMnu
        '
        Me.PresupuestoMnu.Name = "PresupuestoMnu"
        Me.PresupuestoMnu.Size = New System.Drawing.Size(156, 22)
        Me.PresupuestoMnu.Text = "Plan Anual Vtas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(172, 6)
        '
        'RepartosItem
        '
        Me.RepartosItem.Name = "RepartosItem"
        Me.RepartosItem.Size = New System.Drawing.Size(152, 22)
        Me.RepartosItem.Text = "Repartos"
        '
        'ALMACENPRONOSTICOBindingSource
        '
        '
        'HelpProvider
        '
        Me.HelpProvider.Tag = "1000"
        '
        'PronosticosToolStrip
        '
        Me.PronosticosToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.ToolStripSeparator5, Me.AddProductoBtn, Me.BtnOcultar, Me.toolStripSeparator, Me.CortarToolStripButton, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.ToolStripSeparator4, Me.AyudaToolStripButton, Me.BtnSalir})
        Me.PronosticosToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.PronosticosToolStrip.Name = "PronosticosToolStrip"
        Me.PronosticosToolStrip.Size = New System.Drawing.Size(1028, 25)
        Me.PronosticosToolStrip.TabIndex = 14
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'AddProductoBtn
        '
        Me.AddProductoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddProductoBtn.Image = Global.PronosticosSAP.My.Resources.Resources.page_add
        Me.AddProductoBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddProductoBtn.Name = "AddProductoBtn"
        Me.AddProductoBtn.Size = New System.Drawing.Size(23, 22)
        Me.AddProductoBtn.Text = "Agregarproducto"
        Me.AddProductoBtn.ToolTipText = "Agregar producto a escenario generado"
        '
        'BtnOcultar
        '
        Me.BtnOcultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnOcultar.Image = Global.PronosticosSAP.My.Resources.Resources.paper_arrow_red_16_ns
        Me.BtnOcultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOcultar.Name = "BtnOcultar"
        Me.BtnOcultar.Size = New System.Drawing.Size(23, 22)
        Me.BtnOcultar.Text = "Ocultar"
        Me.BtnOcultar.ToolTipText = "Ocultar Productos"
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
        Me.CortarToolStripButton.Visible = False
        '
        'CopiarToolStripButton
        '
        Me.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), System.Drawing.Image)
        Me.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripButton.Name = "CopiarToolStripButton"
        Me.CopiarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopiarToolStripButton.Text = "&Copiar"
        Me.CopiarToolStripButton.Visible = False
        '
        'PegarToolStripButton
        '
        Me.PegarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PegarToolStripButton.Image = CType(resources.GetObject("PegarToolStripButton.Image"), System.Drawing.Image)
        Me.PegarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PegarToolStripButton.Name = "PegarToolStripButton"
        Me.PegarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PegarToolStripButton.Text = "&Pegar"
        Me.PegarToolStripButton.Visible = False
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        'BtnSalir
        '
        Me.BtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSalir.Image = Global.PronosticosSAP.My.Resources.Resources.door_out
        Me.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(23, 22)
        Me.BtnSalir.Text = "Salir"
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripProgressBar, Me.EstatusBarTxt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 545)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(77, 17)
        Me.ToolStripStatusLabel.Text = "EstatusBarTxt"
        '
        'ToolStripProgressBar
        '
        Me.ToolStripProgressBar.Name = "ToolStripProgressBar"
        Me.ToolStripProgressBar.Size = New System.Drawing.Size(100, 16)
        '
        'EstatusBarTxt
        '
        Me.EstatusBarTxt.Name = "EstatusBarTxt"
        Me.EstatusBarTxt.Size = New System.Drawing.Size(0, 17)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(1028, 520)
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.TabPronosticos, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1028, 520)
        Me.TableLayoutPanel4.TabIndex = 17
        '
        'Pronosticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 567)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.PronosticosToolStrip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Pronosticos"
        Me.Text = "Registro de pronosticos"
        CType(Me.PronosticoErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPronosticos.ResumeLayout(False)
        Me.TabMaestro.ResumeLayout(False)
        Me.TabMaestro.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabDetalle.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalesGrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabOpciones.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.AutoGuardadoOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PronosticosCm.ResumeLayout(False)
        CType(Me.ALMACENPRONOSTICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PronosticosToolStrip.ResumeLayout(False)
        Me.PronosticosToolStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PronosticoErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ALMACENPRONOSTICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents ALMACENPRONOSTICOTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.ALMACENPRONOSTICOTableAdapter
    Friend WithEvents PronosticosToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents BGWK As System.ComponentModel.BackgroundWorker
    Friend WithEvents AutoSaveTimer As System.Windows.Forms.Timer
    Friend WithEvents PronosticosCm As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RepartosItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepartosMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VentasMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresupuestoMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarMnuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HistoricosMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents PronosticosToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AbrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AddProductoBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CortarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopiarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PegarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSalir As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents ZonasTxt As System.Windows.Forms.TextBox
    Friend WithEvents lblAgenteTxt As System.Windows.Forms.Label
    Friend WithEvents DescPronosticoTxt As System.Windows.Forms.TextBox
    Friend WithEvents TerritorioLbl As System.Windows.Forms.Label
    Friend WithEvents NombreAgenteLabel As System.Windows.Forms.Label
    Friend WithEvents TabDetalle As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RegionLbl As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboCentroFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents Cbocliente As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ZonaLabel As System.Windows.Forms.Label
    Friend WithEvents NomAgentelbl As System.Windows.Forms.Label
    Friend WithEvents lblCongelado As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TotalesGrd As System.Windows.Forms.DataGridView
    Friend WithEvents TabOpciones As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ChkOpcVerColumnas As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AutoGuardadoOpcion As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents EstatusBarTxt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnOcultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChkActivos As System.Windows.Forms.CheckBox
    'Friend WithEvents PronosticosCm As System.Windows.Forms.ToolStripMenuItem


End Class
