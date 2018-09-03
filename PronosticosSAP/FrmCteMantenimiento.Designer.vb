<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCteMantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCteMantenimiento))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsPB = New System.Windows.Forms.ToolStripProgressBar()
        Me.TsLabelMsg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PrincipalMnuContex = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CteProductoMnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BuscarProdictoTSMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarTSMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCteProductoMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdAgenteTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PegarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Sincronizar = New System.Windows.Forms.ToolStripButton()
        Me.BtnAddDistribuidor = New System.Windows.Forms.ToolStripButton()
        Me.FrmTable = New System.Windows.Forms.TableLayoutPanel()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.ClientesTab = New System.Windows.Forms.TabControl()
        Me.CteAgteTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ClienteDg = New System.Windows.Forms.DataGridView()
        Me.COLSOCIEDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLCTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLRAZON = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLAGENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGENTENOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLVIGENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProductosTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ClienteProductoDg = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRCTE_COLAGENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRCTE_COLSOCIEDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRCTE_COLAGENTE_COLCLAVECTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRCTE_COLPRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRCTE_COLCENTRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRCTE_COLDECPRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRCTE_COLDESCCENTRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIGENCIACTEPRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblSociedadSeleccionada = New System.Windows.Forms.Label()
        Me.BtnConsultarCteProducto = New System.Windows.Forms.Button()
        Me.CteSeleccionadoLbl = New System.Windows.Forms.Label()
        Me.CentroSeleccionadoLbl = New System.Windows.Forms.Label()
        Me.CaducidadLabel = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VigentesDropDown = New System.Windows.Forms.ComboBox()
        Me.GuardarOpciones = New System.Windows.Forms.Button()
        Me.LBlCteDesc = New System.Windows.Forms.Label()
        Me.ClientesTp = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClientesWKGW = New System.ComponentModel.BackgroundWorker()
        Me.MsgErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.PrincipalMnuContex.SuspendLayout()
        Me.CteProductoMnu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.FrmTable.SuspendLayout()
        Me.ClientesTab.SuspendLayout()
        Me.CteAgteTab.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ClienteDg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosTab.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.ClienteProductoDg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MsgErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsPB, Me.TsLabelMsg})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 362)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(870, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TsPB
        '
        Me.TsPB.Name = "TsPB"
        Me.TsPB.Size = New System.Drawing.Size(100, 16)
        '
        'TsLabelMsg
        '
        Me.TsLabelMsg.Name = "TsLabelMsg"
        Me.TsLabelMsg.Size = New System.Drawing.Size(0, 17)
        '
        'PrincipalMnuContex
        '
        Me.PrincipalMnuContex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.PrincipalMnuContex.Name = "PrincipalMnuContex"
        Me.PrincipalMnuContex.Size = New System.Drawing.Size(138, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripMenuItem1.Text = "Posicionar."
        '
        'CteProductoMnu
        '
        Me.CteProductoMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarProdictoTSMnu, Me.ToolStripSeparator4, Me.EliminarTSMnu, Me.AddCteProductoMnu})
        Me.CteProductoMnu.Name = "PrincipalMnuContex"
        Me.CteProductoMnu.Size = New System.Drawing.Size(171, 76)
        '
        'BuscarProdictoTSMnu
        '
        Me.BuscarProdictoTSMnu.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.BuscarProdictoTSMnu.Name = "BuscarProdictoTSMnu"
        Me.BuscarProdictoTSMnu.Size = New System.Drawing.Size(170, 22)
        Me.BuscarProdictoTSMnu.Text = "Asignar Producto "
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(167, 6)
        '
        'EliminarTSMnu
        '
        Me.EliminarTSMnu.Image = Global.PronosticosSAP.My.Resources.Resources.paper_arrow_red_16_ns
        Me.EliminarTSMnu.Name = "EliminarTSMnu"
        Me.EliminarTSMnu.Size = New System.Drawing.Size(170, 22)
        Me.EliminarTSMnu.Text = "&Eliminar Registro"
        '
        'AddCteProductoMnu
        '
        Me.AddCteProductoMnu.Image = Global.PronosticosSAP.My.Resources.Resources.page_add
        Me.AddCteProductoMnu.Name = "AddCteProductoMnu"
        Me.AddCteProductoMnu.Size = New System.Drawing.Size(170, 22)
        Me.AddCteProductoMnu.Text = "RegistroNuevo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.FrmTable.SetColumnSpan(Me.Label3, 3)
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(3, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Datos Generales del Agente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Agente:"
        '
        'IdAgenteTxt
        '
        Me.IdAgenteTxt.Location = New System.Drawing.Point(53, 58)
        Me.IdAgenteTxt.Name = "IdAgenteTxt"
        Me.IdAgenteTxt.Size = New System.Drawing.Size(100, 20)
        Me.IdAgenteTxt.TabIndex = 2
        Me.ClientesTp.SetToolTip(Me.IdAgenteTxt, "Indique la clave del ciente a consultar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y a contiuación de click en el boton Con" & _
        "sultar Clientes Asignados  de la barra principal," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o pulse enter.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.FrmTable.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Catálogo de Clientes"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ToolStripSeparator3, Me.AddToolStripButton, Me.DelToolStripButton, Me.toolStripSeparator, Me.CortarToolStripButton, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.SalirToolStripButton, Me.AyudaToolStripButton, Me.ToolStripSeparator2, Me.Sincronizar, Me.BtnAddDistribuidor})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(870, 25)
        Me.ToolStrip1.TabIndex = 3
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
        Me.AbrirToolStripButton.Text = "&Consultar Clientes Asignados"
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolStripButton.Image = Global.PronosticosSAP.My.Resources.Resources.page_add
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AddToolStripButton.Text = "ToolStripButton1"
        Me.AddToolStripButton.ToolTipText = "Agregar Registro"
        '
        'DelToolStripButton
        '
        Me.DelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DelToolStripButton.Image = Global.PronosticosSAP.My.Resources.Resources.paper_arrow_red_16_ns
        Me.DelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DelToolStripButton.Name = "DelToolStripButton"
        Me.DelToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DelToolStripButton.Text = "ToolStripButton1"
        Me.DelToolStripButton.ToolTipText = "Eliminar Registro"
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
        'SalirToolStripButton
        '
        Me.SalirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalirToolStripButton.Image = Global.PronosticosSAP.My.Resources.Resources.door_out
        Me.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalirToolStripButton.Name = "SalirToolStripButton"
        Me.SalirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SalirToolStripButton.ToolTipText = "Salir"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Sincronizar
        '
        Me.Sincronizar.Image = Global.PronosticosSAP.My.Resources.Resources.arrow_switch
        Me.Sincronizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Sincronizar.Name = "Sincronizar"
        Me.Sincronizar.Size = New System.Drawing.Size(121, 22)
        Me.Sincronizar.Text = "Sincronizar con SAP"
        Me.Sincronizar.ToolTipText = "Sincronizar la lista de Clientes con SAP"
        '
        'BtnAddDistribuidor
        '
        Me.BtnAddDistribuidor.Image = Global.PronosticosSAP.My.Resources.Resources.page_star_24
        Me.BtnAddDistribuidor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddDistribuidor.Name = "BtnAddDistribuidor"
        Me.BtnAddDistribuidor.Size = New System.Drawing.Size(123, 22)
        Me.BtnAddDistribuidor.Text = "Agregar &Distribuidor"
        '
        'FrmTable
        '
        Me.FrmTable.ColumnCount = 4
        Me.FrmTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.FrmTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.FrmTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.FrmTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.FrmTable.Controls.Add(Me.BuscarBtn, 2, 2)
        Me.FrmTable.Controls.Add(Me.ClientesTab, 0, 3)
        Me.FrmTable.Controls.Add(Me.Label1, 0, 0)
        Me.FrmTable.Controls.Add(Me.Label3, 0, 1)
        Me.FrmTable.Controls.Add(Me.Label2, 0, 2)
        Me.FrmTable.Controls.Add(Me.IdAgenteTxt, 1, 2)
        Me.FrmTable.Controls.Add(Me.LBlCteDesc, 3, 2)
        Me.FrmTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmTable.Location = New System.Drawing.Point(0, 25)
        Me.FrmTable.Name = "FrmTable"
        Me.FrmTable.RowCount = 4
        Me.FrmTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FrmTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FrmTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FrmTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FrmTable.Size = New System.Drawing.Size(870, 337)
        Me.FrmTable.TabIndex = 4
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.BuscarBtn.Location = New System.Drawing.Point(159, 58)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(31, 23)
        Me.BuscarBtn.TabIndex = 7
        Me.ClientesTp.SetToolTip(Me.BuscarBtn, "Buscar Agente")
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'ClientesTab
        '
        Me.FrmTable.SetColumnSpan(Me.ClientesTab, 6)
        Me.ClientesTab.Controls.Add(Me.CteAgteTab)
        Me.ClientesTab.Controls.Add(Me.ProductosTab)
        Me.ClientesTab.Controls.Add(Me.TabPage1)
        Me.ClientesTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClientesTab.Location = New System.Drawing.Point(3, 87)
        Me.ClientesTab.Name = "ClientesTab"
        Me.ClientesTab.SelectedIndex = 0
        Me.ClientesTab.Size = New System.Drawing.Size(864, 247)
        Me.ClientesTab.TabIndex = 6
        '
        'CteAgteTab
        '
        Me.CteAgteTab.Controls.Add(Me.TableLayoutPanel2)
        Me.CteAgteTab.Location = New System.Drawing.Point(4, 22)
        Me.CteAgteTab.Name = "CteAgteTab"
        Me.CteAgteTab.Padding = New System.Windows.Forms.Padding(3)
        Me.CteAgteTab.Size = New System.Drawing.Size(856, 221)
        Me.CteAgteTab.TabIndex = 0
        Me.CteAgteTab.Text = "Clientes"
        Me.CteAgteTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ClienteDg, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.94915!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.05085!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(850, 215)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'ClienteDg
        '
        Me.ClienteDg.AllowUserToAddRows = False
        Me.ClienteDg.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClienteDg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ClienteDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COLSOCIEDAD, Me.COLCTE, Me.COLRAZON, Me.COLAGENTE, Me.AGENTENOMBRE, Me.COLVIGENCIA})
        Me.TableLayoutPanel2.SetColumnSpan(Me.ClienteDg, 2)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClienteDg.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClienteDg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClienteDg.Location = New System.Drawing.Point(3, 39)
        Me.ClienteDg.Name = "ClienteDg"
        Me.ClienteDg.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClienteDg.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ClienteDg.Size = New System.Drawing.Size(844, 173)
        Me.ClienteDg.TabIndex = 5
        '
        'COLSOCIEDAD
        '
        Me.COLSOCIEDAD.DataPropertyName = "SOCIEDAD"
        Me.COLSOCIEDAD.HeaderText = "SOCIEDAD"
        Me.COLSOCIEDAD.Name = "COLSOCIEDAD"
        Me.COLSOCIEDAD.ReadOnly = True
        '
        'COLCTE
        '
        Me.COLCTE.DataPropertyName = "CLAVECLIENTE"
        Me.COLCTE.HeaderText = "CLAVE"
        Me.COLCTE.Name = "COLCTE"
        Me.COLCTE.ReadOnly = True
        '
        'COLRAZON
        '
        Me.COLRAZON.ContextMenuStrip = Me.PrincipalMnuContex
        Me.COLRAZON.DataPropertyName = "RAZONSOCIAL"
        Me.COLRAZON.HeaderText = "RAZON SOCIAL"
        Me.COLRAZON.Name = "COLRAZON"
        Me.COLRAZON.ReadOnly = True
        Me.COLRAZON.Width = 200
        '
        'COLAGENTE
        '
        Me.COLAGENTE.DataPropertyName = "CLAVEAGENTE"
        Me.COLAGENTE.HeaderText = "AGENTE"
        Me.COLAGENTE.Name = "COLAGENTE"
        Me.COLAGENTE.ReadOnly = True
        Me.COLAGENTE.Visible = False
        '
        'AGENTENOMBRE
        '
        Me.AGENTENOMBRE.DataPropertyName = "AGENTENOMBRE"
        Me.AGENTENOMBRE.HeaderText = "AGENTENOMBRE"
        Me.AGENTENOMBRE.Name = "AGENTENOMBRE"
        Me.AGENTENOMBRE.ReadOnly = True
        Me.AGENTENOMBRE.Visible = False
        '
        'COLVIGENCIA
        '
        Me.COLVIGENCIA.DataPropertyName = "VIGENCIA"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.COLVIGENCIA.DefaultCellStyle = DataGridViewCellStyle2
        Me.COLVIGENCIA.HeaderText = "VIGENCIA"
        Me.COLVIGENCIA.Name = "COLVIGENCIA"
        Me.COLVIGENCIA.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label4, 2)
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Clientes Asignados en SigePro"
        '
        'ProductosTab
        '
        Me.ProductosTab.Controls.Add(Me.TableLayoutPanel3)
        Me.ProductosTab.Location = New System.Drawing.Point(4, 22)
        Me.ProductosTab.Name = "ProductosTab"
        Me.ProductosTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductosTab.Size = New System.Drawing.Size(856, 221)
        Me.ProductosTab.TabIndex = 1
        Me.ProductosTab.Text = "Productos X Cliente"
        Me.ProductosTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ClienteProductoDg, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LblSociedadSeleccionada, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnConsultarCteProducto, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CteSeleccionadoLbl, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.CentroSeleccionadoLbl, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.CaducidadLabel, 2, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(850, 215)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'ClienteProductoDg
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClienteProductoDg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ClienteProductoDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteProductoDg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.PRCTE_COLAGENTE, Me.PRCTE_COLSOCIEDAD, Me.PRCTE_COLAGENTE_COLCLAVECTE, Me.PRCTE_COLPRODUCTO, Me.PRCTE_COLCENTRO, Me.PRCTE_COLDECPRODUCTO, Me.PRCTE_COLDESCCENTRO, Me.VIGENCIACTEPRODUCTO})
        Me.TableLayoutPanel3.SetColumnSpan(Me.ClienteProductoDg, 5)
        Me.ClienteProductoDg.ContextMenuStrip = Me.CteProductoMnu
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClienteProductoDg.DefaultCellStyle = DataGridViewCellStyle7
        Me.ClienteProductoDg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClienteProductoDg.Location = New System.Drawing.Point(3, 75)
        Me.ClienteProductoDg.Name = "ClienteProductoDg"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClienteProductoDg.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.ClienteProductoDg.Size = New System.Drawing.Size(844, 137)
        Me.ClienteProductoDg.TabIndex = 13
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.Frozen = True
        Me.ID.HeaderText = "POSICION"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'PRCTE_COLAGENTE
        '
        Me.PRCTE_COLAGENTE.DataPropertyName = "CLAVEAGENTE"
        Me.PRCTE_COLAGENTE.HeaderText = "AGENTE"
        Me.PRCTE_COLAGENTE.Name = "PRCTE_COLAGENTE"
        Me.PRCTE_COLAGENTE.Visible = False
        '
        'PRCTE_COLSOCIEDAD
        '
        Me.PRCTE_COLSOCIEDAD.DataPropertyName = "CLAVESOCIEDAD"
        Me.PRCTE_COLSOCIEDAD.HeaderText = "CLAVESOCIEDAD"
        Me.PRCTE_COLSOCIEDAD.Name = "PRCTE_COLSOCIEDAD"
        Me.PRCTE_COLSOCIEDAD.Visible = False
        '
        'PRCTE_COLAGENTE_COLCLAVECTE
        '
        Me.PRCTE_COLAGENTE_COLCLAVECTE.DataPropertyName = "CLAVECLIENTE"
        Me.PRCTE_COLAGENTE_COLCLAVECTE.HeaderText = "CLAVE CLIENTE"
        Me.PRCTE_COLAGENTE_COLCLAVECTE.Name = "PRCTE_COLAGENTE_COLCLAVECTE"
        Me.PRCTE_COLAGENTE_COLCLAVECTE.Visible = False
        '
        'PRCTE_COLPRODUCTO
        '
        Me.PRCTE_COLPRODUCTO.DataPropertyName = "CLAVEPRODUCTO"
        Me.PRCTE_COLPRODUCTO.HeaderText = "CLAVE PRODUCTO"
        Me.PRCTE_COLPRODUCTO.Name = "PRCTE_COLPRODUCTO"
        '
        'PRCTE_COLCENTRO
        '
        Me.PRCTE_COLCENTRO.DataPropertyName = "CLAVECENTRO"
        Me.PRCTE_COLCENTRO.HeaderText = "CLAVECENTRO"
        Me.PRCTE_COLCENTRO.Name = "PRCTE_COLCENTRO"
        '
        'PRCTE_COLDECPRODUCTO
        '
        Me.PRCTE_COLDECPRODUCTO.DataPropertyName = "DESC_PRODUCTO"
        Me.PRCTE_COLDECPRODUCTO.HeaderText = "DESC. PRODUCTO"
        Me.PRCTE_COLDECPRODUCTO.Name = "PRCTE_COLDECPRODUCTO"
        '
        'PRCTE_COLDESCCENTRO
        '
        Me.PRCTE_COLDESCCENTRO.DataPropertyName = "DESC_CENTRO"
        Me.PRCTE_COLDESCCENTRO.HeaderText = "DESC. CENTRO"
        Me.PRCTE_COLDESCCENTRO.Name = "PRCTE_COLDESCCENTRO"
        '
        'VIGENCIACTEPRODUCTO
        '
        Me.VIGENCIACTEPRODUCTO.DataPropertyName = "VIGENCIA"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.VIGENCIACTEPRODUCTO.DefaultCellStyle = DataGridViewCellStyle6
        Me.VIGENCIACTEPRODUCTO.HeaderText = "VIGENCIA"
        Me.VIGENCIACTEPRODUCTO.MaxInputLength = 10
        Me.VIGENCIACTEPRODUCTO.Name = "VIGENCIACTEPRODUCTO"
        Me.VIGENCIACTEPRODUCTO.ToolTipText = "La vigencia solo afectará la creación de nuevos escenarios."
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label5, 4)
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(774, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Asignar Productos  X Cliente"
        '
        'LblSociedadSeleccionada
        '
        Me.LblSociedadSeleccionada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSociedadSeleccionada.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.LblSociedadSeleccionada, 2)
        Me.LblSociedadSeleccionada.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSociedadSeleccionada.ForeColor = System.Drawing.Color.Navy
        Me.LblSociedadSeleccionada.Location = New System.Drawing.Point(3, 29)
        Me.LblSociedadSeleccionada.Name = "LblSociedadSeleccionada"
        Me.LblSociedadSeleccionada.Size = New System.Drawing.Size(384, 23)
        Me.LblSociedadSeleccionada.TabIndex = 9
        Me.LblSociedadSeleccionada.Text = "Elja un cliente antes de editar"
        '
        'BtnConsultarCteProducto
        '
        Me.BtnConsultarCteProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnConsultarCteProducto.Image = Global.PronosticosSAP.My.Resources.Resources.table_refresh
        Me.BtnConsultarCteProducto.Location = New System.Drawing.Point(816, 3)
        Me.BtnConsultarCteProducto.Name = "BtnConsultarCteProducto"
        Me.BtnConsultarCteProducto.Size = New System.Drawing.Size(31, 23)
        Me.BtnConsultarCteProducto.TabIndex = 8
        Me.ClientesTp.SetToolTip(Me.BtnConsultarCteProducto, "Consultar")
        Me.BtnConsultarCteProducto.UseVisualStyleBackColor = True
        '
        'CteSeleccionadoLbl
        '
        Me.CteSeleccionadoLbl.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.CteSeleccionadoLbl, 2)
        Me.CteSeleccionadoLbl.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CteSeleccionadoLbl.ForeColor = System.Drawing.Color.Navy
        Me.CteSeleccionadoLbl.Location = New System.Drawing.Point(393, 29)
        Me.CteSeleccionadoLbl.Name = "CteSeleccionadoLbl"
        Me.CteSeleccionadoLbl.Size = New System.Drawing.Size(286, 23)
        Me.CteSeleccionadoLbl.TabIndex = 5
        Me.CteSeleccionadoLbl.Text = "Elja un cliente antes de editar"
        '
        'CentroSeleccionadoLbl
        '
        Me.CentroSeleccionadoLbl.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.CentroSeleccionadoLbl, 2)
        Me.CentroSeleccionadoLbl.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CentroSeleccionadoLbl.ForeColor = System.Drawing.Color.Navy
        Me.CentroSeleccionadoLbl.Location = New System.Drawing.Point(3, 52)
        Me.CentroSeleccionadoLbl.Name = "CentroSeleccionadoLbl"
        Me.CentroSeleccionadoLbl.Size = New System.Drawing.Size(286, 20)
        Me.CentroSeleccionadoLbl.TabIndex = 6
        Me.CentroSeleccionadoLbl.Text = "Elja un cliente antes de editar"
        '
        'CaducidadLabel
        '
        Me.CaducidadLabel.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.CaducidadLabel, 2)
        Me.CaducidadLabel.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaducidadLabel.ForeColor = System.Drawing.Color.Navy
        Me.CaducidadLabel.Location = New System.Drawing.Point(393, 52)
        Me.CaducidadLabel.Name = "CaducidadLabel"
        Me.CaducidadLabel.Size = New System.Drawing.Size(286, 20)
        Me.CaducidadLabel.TabIndex = 12
        Me.CaducidadLabel.Text = "Elja un cliente antes de editar"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(856, 221)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Opciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.VigentesDropDown, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GuardarOpciones, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(850, 215)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Mostrar Solo Clientes Vigentes:"
        '
        'VigentesDropDown
        '
        Me.VigentesDropDown.FormattingEnabled = True
        Me.VigentesDropDown.Items.AddRange(New Object() {"S", "N"})
        Me.VigentesDropDown.Location = New System.Drawing.Point(428, 3)
        Me.VigentesDropDown.Name = "VigentesDropDown"
        Me.VigentesDropDown.Size = New System.Drawing.Size(44, 21)
        Me.VigentesDropDown.TabIndex = 1
        '
        'GuardarOpciones
        '
        Me.GuardarOpciones.Location = New System.Drawing.Point(3, 110)
        Me.GuardarOpciones.Name = "GuardarOpciones"
        Me.GuardarOpciones.Size = New System.Drawing.Size(140, 23)
        Me.GuardarOpciones.TabIndex = 2
        Me.GuardarOpciones.Text = "Guardar &Opciones"
        Me.GuardarOpciones.UseVisualStyleBackColor = True
        '
        'LBlCteDesc
        '
        Me.LBlCteDesc.AutoSize = True
        Me.LBlCteDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBlCteDesc.ForeColor = System.Drawing.Color.Navy
        Me.LBlCteDesc.Location = New System.Drawing.Point(287, 55)
        Me.LBlCteDesc.Name = "LBlCteDesc"
        Me.LBlCteDesc.Size = New System.Drawing.Size(0, 13)
        Me.LBlCteDesc.TabIndex = 8
        '
        'ClientesWKGW
        '
        Me.ClientesWKGW.WorkerReportsProgress = True
        Me.ClientesWKGW.WorkerSupportsCancellation = True
        '
        'MsgErrProvider
        '
        Me.MsgErrProvider.ContainerControl = Me
        '
        'FrmCteMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 384)
        Me.Controls.Add(Me.FrmTable)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FrmCteMantenimiento"
        Me.Text = "Clientes"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PrincipalMnuContex.ResumeLayout(False)
        Me.CteProductoMnu.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.FrmTable.ResumeLayout(False)
        Me.FrmTable.PerformLayout()
        Me.ClientesTab.ResumeLayout(False)
        Me.CteAgteTab.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.ClienteDg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosTab.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.ClienteProductoDg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.MsgErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents FrmTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdAgenteTxt As System.Windows.Forms.TextBox
    Friend WithEvents ClientesTp As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AbrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CortarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopiarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PegarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientesWKGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents TsLabelMsg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TsPB As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Sincronizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrincipalMnuContex As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MsgErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents CteProductoMnu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BuscarProdictoTSMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCteProductoMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DelToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EliminarTSMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents ClientesTab As System.Windows.Forms.TabControl
    Friend WithEvents CteAgteTab As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ClienteDg As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProductosTab As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CteSeleccionadoLbl As System.Windows.Forms.Label
    Friend WithEvents LBlCteDesc As System.Windows.Forms.Label
    Friend WithEvents SalirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnConsultarCteProducto As System.Windows.Forms.Button
    Friend WithEvents LblSociedadSeleccionada As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents VigentesDropDown As System.Windows.Forms.ComboBox
    Friend WithEvents GuardarOpciones As System.Windows.Forms.Button
    Friend WithEvents ClienteProductoDg As System.Windows.Forms.DataGridView
    Friend WithEvents CentroSeleccionadoLbl As System.Windows.Forms.Label
    Friend WithEvents CaducidadLabel As System.Windows.Forms.Label
    Friend WithEvents COLSOCIEDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLCTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLRAZON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLAGENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AGENTENOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLVIGENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRCTE_COLAGENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRCTE_COLSOCIEDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRCTE_COLAGENTE_COLCLAVECTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRCTE_COLPRODUCTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRCTE_COLCENTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRCTE_COLDECPRODUCTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRCTE_COLDESCCENTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VIGENCIACTEPRODUCTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAddDistribuidor As System.Windows.Forms.ToolStripButton
End Class
