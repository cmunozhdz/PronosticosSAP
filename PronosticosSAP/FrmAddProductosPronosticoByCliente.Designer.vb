<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddProductosPronosticoByCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddProductosPronosticoByCliente))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StsLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ParametrosTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CentroBtn = New System.Windows.Forms.Button()
        Me.ProductoBtn = New System.Windows.Forms.Button()
        Me.CteBtn = New System.Windows.Forms.Button()
        Me.SociedaBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProductoTxt = New System.Windows.Forms.TextBox()
        Me.CentroTxt = New System.Windows.Forms.TextBox()
        Me.AgenteTxt = New System.Windows.Forms.TextBox()
        Me.SociedadTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClienteTxt = New System.Windows.Forms.TextBox()
        Me.AgenteBtn = New System.Windows.Forms.Button()
        Me.CentroDescricpionTxt = New System.Windows.Forms.Label()
        Me.ResultadosTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.QryDGrv = New System.Windows.Forms.DataGridView()
        Me.CLAVEAGENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLAVESOCIEDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLAVECLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZONSOCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLAVECENTRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_CENTRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLAVEPRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_PRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIGENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ResultadoBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ParametrosTab.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ResultadosTab.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.QryDGrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultadoBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StsLbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 269)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(721, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StsLbl
        '
        Me.StsLbl.Name = "StsLbl"
        Me.StsLbl.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.CortarToolStripButton, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(721, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.ImprimirToolStripButton.Visible = False
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
        'AyudaToolStripButton
        '
        Me.AyudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), System.Drawing.Image)
        Me.AyudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaToolStripButton.Name = "AyudaToolStripButton"
        Me.AyudaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AyudaToolStripButton.Text = "Ay&uda"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.PronosticosSAP.My.Resources.Resources.door_out
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ParametrosTab)
        Me.TabControl1.Controls.Add(Me.ResultadosTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(721, 244)
        Me.TabControl1.TabIndex = 2
        '
        'ParametrosTab
        '
        Me.ParametrosTab.Controls.Add(Me.TableLayoutPanel1)
        Me.ParametrosTab.Location = New System.Drawing.Point(4, 22)
        Me.ParametrosTab.Name = "ParametrosTab"
        Me.ParametrosTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ParametrosTab.Size = New System.Drawing.Size(713, 218)
        Me.ParametrosTab.TabIndex = 0
        Me.ParametrosTab.Text = "Parametros"
        Me.ParametrosTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CentroBtn, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ProductoBtn, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CteBtn, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.SociedaBtn, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ProductoTxt, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CentroTxt, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.AgenteTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SociedadTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ClienteTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AgenteBtn, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CentroDescricpionTxt, 3, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(707, 212)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'CentroBtn
        '
        Me.CentroBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.CentroBtn.Location = New System.Drawing.Point(170, 155)
        Me.CentroBtn.Name = "CentroBtn"
        Me.CentroBtn.Size = New System.Drawing.Size(26, 26)
        Me.CentroBtn.TabIndex = 15
        Me.CentroBtn.UseVisualStyleBackColor = True
        '
        'ProductoBtn
        '
        Me.ProductoBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.ProductoBtn.Location = New System.Drawing.Point(170, 123)
        Me.ProductoBtn.Name = "ProductoBtn"
        Me.ProductoBtn.Size = New System.Drawing.Size(26, 26)
        Me.ProductoBtn.TabIndex = 14
        Me.ProductoBtn.UseVisualStyleBackColor = True
        '
        'CteBtn
        '
        Me.CteBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.CteBtn.Location = New System.Drawing.Point(170, 91)
        Me.CteBtn.Name = "CteBtn"
        Me.CteBtn.Size = New System.Drawing.Size(26, 26)
        Me.CteBtn.TabIndex = 13
        Me.CteBtn.UseVisualStyleBackColor = True
        '
        'SociedaBtn
        '
        Me.SociedaBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.SociedaBtn.Location = New System.Drawing.Point(170, 59)
        Me.SociedaBtn.Name = "SociedaBtn"
        Me.SociedaBtn.Size = New System.Drawing.Size(26, 26)
        Me.SociedaBtn.TabIndex = 12
        Me.SociedaBtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label6, 3)
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(384, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Indique los parametros de búsqueda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Centro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sociedad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Producto:"
        '
        'ProductoTxt
        '
        Me.ProductoTxt.Location = New System.Drawing.Point(64, 123)
        Me.ProductoTxt.Name = "ProductoTxt"
        Me.ProductoTxt.Size = New System.Drawing.Size(100, 20)
        Me.ProductoTxt.TabIndex = 7
        Me.AddToolTip.SetToolTip(Me.ProductoTxt, "Clave del producto")
        '
        'CentroTxt
        '
        Me.CentroTxt.Location = New System.Drawing.Point(64, 155)
        Me.CentroTxt.Name = "CentroTxt"
        Me.CentroTxt.Size = New System.Drawing.Size(100, 20)
        Me.CentroTxt.TabIndex = 9
        Me.AddToolTip.SetToolTip(Me.CentroTxt, "Clave del Centro")
        '
        'AgenteTxt
        '
        Me.AgenteTxt.Location = New System.Drawing.Point(64, 27)
        Me.AgenteTxt.Name = "AgenteTxt"
        Me.AgenteTxt.Size = New System.Drawing.Size(100, 20)
        Me.AgenteTxt.TabIndex = 1
        Me.AddToolTip.SetToolTip(Me.AgenteTxt, "Agente del pronostico asignado")
        '
        'SociedadTxt
        '
        Me.SociedadTxt.Location = New System.Drawing.Point(64, 59)
        Me.SociedadTxt.Name = "SociedadTxt"
        Me.SociedadTxt.Size = New System.Drawing.Size(100, 20)
        Me.SociedadTxt.TabIndex = 3
        Me.AddToolTip.SetToolTip(Me.SociedadTxt, "Clave de la sociedad.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cliente:"
        '
        'ClienteTxt
        '
        Me.ClienteTxt.Location = New System.Drawing.Point(64, 91)
        Me.ClienteTxt.Name = "ClienteTxt"
        Me.ClienteTxt.Size = New System.Drawing.Size(100, 20)
        Me.ClienteTxt.TabIndex = 5
        Me.AddToolTip.SetToolTip(Me.ClienteTxt, "Clave del cliente")
        '
        'AgenteBtn
        '
        Me.AgenteBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.AgenteBtn.Location = New System.Drawing.Point(170, 27)
        Me.AgenteBtn.Name = "AgenteBtn"
        Me.AgenteBtn.Size = New System.Drawing.Size(26, 26)
        Me.AgenteBtn.TabIndex = 11
        Me.AgenteBtn.UseVisualStyleBackColor = True
        '
        'CentroDescricpionTxt
        '
        Me.CentroDescricpionTxt.AutoSize = True
        Me.CentroDescricpionTxt.Location = New System.Drawing.Point(393, 152)
        Me.CentroDescricpionTxt.Name = "CentroDescricpionTxt"
        Me.CentroDescricpionTxt.Size = New System.Drawing.Size(0, 13)
        Me.CentroDescricpionTxt.TabIndex = 16
        '
        'ResultadosTab
        '
        Me.ResultadosTab.Controls.Add(Me.TableLayoutPanel2)
        Me.ResultadosTab.Location = New System.Drawing.Point(4, 22)
        Me.ResultadosTab.Name = "ResultadosTab"
        Me.ResultadosTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ResultadosTab.Size = New System.Drawing.Size(713, 218)
        Me.ResultadosTab.TabIndex = 1
        Me.ResultadosTab.Text = "Resultados"
        Me.ResultadosTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.QryDGrv, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(707, 212)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'QryDGrv
        '
        Me.QryDGrv.AllowUserToAddRows = False
        Me.QryDGrv.AllowUserToDeleteRows = False
        Me.QryDGrv.AutoGenerateColumns = False
        Me.QryDGrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QryDGrv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLAVEAGENTE, Me.CLAVESOCIEDAD, Me.CLAVECLIENTE, Me.RAZONSOCIAL, Me.CLAVECENTRO, Me.DESC_CENTRO, Me.CLAVEPRODUCTO, Me.DESC_PRODUCTO, Me.VIGENCIA, Me.Seleccionar})
        Me.TableLayoutPanel2.SetColumnSpan(Me.QryDGrv, 2)
        Me.QryDGrv.DataSource = Me.ResultadoBDS
        Me.QryDGrv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QryDGrv.Location = New System.Drawing.Point(3, 3)
        Me.QryDGrv.Name = "QryDGrv"
        Me.QryDGrv.Size = New System.Drawing.Size(701, 195)
        Me.QryDGrv.TabIndex = 0
        '
        'CLAVEAGENTE
        '
        Me.CLAVEAGENTE.DataPropertyName = "CLAVEAGENTE"
        Me.CLAVEAGENTE.HeaderText = "Agente"
        Me.CLAVEAGENTE.Name = "CLAVEAGENTE"
        Me.CLAVEAGENTE.ReadOnly = True
        '
        'CLAVESOCIEDAD
        '
        Me.CLAVESOCIEDAD.DataPropertyName = "CLAVESOCIEDAD"
        Me.CLAVESOCIEDAD.HeaderText = "SOCIEDAD"
        Me.CLAVESOCIEDAD.Name = "CLAVESOCIEDAD"
        Me.CLAVESOCIEDAD.ReadOnly = True
        '
        'CLAVECLIENTE
        '
        Me.CLAVECLIENTE.DataPropertyName = "CLAVECLIENTE"
        Me.CLAVECLIENTE.HeaderText = "CLIENTE"
        Me.CLAVECLIENTE.Name = "CLAVECLIENTE"
        Me.CLAVECLIENTE.ReadOnly = True
        '
        'RAZONSOCIAL
        '
        Me.RAZONSOCIAL.DataPropertyName = "RAZONSOCIAL"
        Me.RAZONSOCIAL.HeaderText = "RAZONSOCIAL"
        Me.RAZONSOCIAL.Name = "RAZONSOCIAL"
        Me.RAZONSOCIAL.ReadOnly = True
        '
        'CLAVECENTRO
        '
        Me.CLAVECENTRO.DataPropertyName = "CLAVECENTRO"
        Me.CLAVECENTRO.HeaderText = "CENTRO"
        Me.CLAVECENTRO.Name = "CLAVECENTRO"
        Me.CLAVECENTRO.ReadOnly = True
        '
        'DESC_CENTRO
        '
        Me.DESC_CENTRO.DataPropertyName = "DESC_CENTRO"
        Me.DESC_CENTRO.HeaderText = "DESC. CENTRO"
        Me.DESC_CENTRO.Name = "DESC_CENTRO"
        Me.DESC_CENTRO.ReadOnly = True
        '
        'CLAVEPRODUCTO
        '
        Me.CLAVEPRODUCTO.DataPropertyName = "CLAVEPRODUCTO"
        Me.CLAVEPRODUCTO.HeaderText = "CLAVEPRODUCTO"
        Me.CLAVEPRODUCTO.Name = "CLAVEPRODUCTO"
        Me.CLAVEPRODUCTO.ReadOnly = True
        '
        'DESC_PRODUCTO
        '
        Me.DESC_PRODUCTO.DataPropertyName = "DESC_PRODUCTO"
        Me.DESC_PRODUCTO.HeaderText = "DESC. PRODUCTO"
        Me.DESC_PRODUCTO.Name = "DESC_PRODUCTO"
        Me.DESC_PRODUCTO.ReadOnly = True
        '
        'VIGENCIA
        '
        Me.VIGENCIA.DataPropertyName = "VIGENCIA"
        Me.VIGENCIA.HeaderText = "VIGENCIA"
        Me.VIGENCIA.Name = "VIGENCIA"
        Me.VIGENCIA.ReadOnly = True
        '
        'Seleccionar
        '
        Me.Seleccionar.DataPropertyName = "Seleccionar"
        Me.Seleccionar.HeaderText = "Seleccione"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AddErrProvider
        '
        Me.AddErrProvider.ContainerControl = Me
        '
        'HelpProvider1
        '
        Me.HelpProvider1.Tag = "1000"
        '
        'FrmAddProductosPronosticoByCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 291)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FrmAddProductosPronosticoByCliente"
        Me.Text = "Agregar Productos al pronostico"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ParametrosTab.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResultadosTab.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.QryDGrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultadoBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ParametrosTab As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ResultadosTab As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents QryDGrv As System.Windows.Forms.DataGridView
    Friend WithEvents ResultadoBDS As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AgenteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SociedadTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClienteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProductoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CentroTxt As System.Windows.Forms.TextBox
    Friend WithEvents StsLbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AddToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents AddErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CentroBtn As System.Windows.Forms.Button
    Friend WithEvents ProductoBtn As System.Windows.Forms.Button
    Friend WithEvents CteBtn As System.Windows.Forms.Button
    Friend WithEvents SociedaBtn As System.Windows.Forms.Button
    Friend WithEvents AgenteBtn As System.Windows.Forms.Button
    Friend WithEvents CentroDescricpionTxt As System.Windows.Forms.Label
    Friend WithEvents CLAVEAGENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLAVESOCIEDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLAVECLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAZONSOCIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLAVECENTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_CENTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLAVEPRODUCTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_PRODUCTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VIGENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
