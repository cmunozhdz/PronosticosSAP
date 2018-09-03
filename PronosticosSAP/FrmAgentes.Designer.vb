<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgentes
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
        Dim CLAVEAGENTELabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim STATUSLabel As System.Windows.Forms.Label
        Dim NEGOCIOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgentes))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CLAVEAGENTETextBox = New System.Windows.Forms.TextBox()
        Me.CONSULTA_AGENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.STATUSTextBox = New System.Windows.Forms.TextBox()
        Me.NEGOCIOTextBox = New System.Windows.Forms.TextBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CONSULTA_ZONAXAGENTEDataGridView = New System.Windows.Forms.DataGridView()
        Me.COLCLAVEZONA = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CONSULTA_ZONASBYCLAVEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTA_ZONAXAGENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CONSULTA_ALMACENDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlmacenContexMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlmacenMnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenMenuDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTA_ALMACENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTA_AGENTESTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_AGENTESTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.CONSULTA_ALMACENTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ALMACENTableAdapter()
        Me.CONSULTA_ZONAXAGENTETableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ZONAXAGENTETableAdapter()
        Me.CONSULTA_ZONASBYCLAVETableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ZONASBYCLAVETableAdapter()
        Me.CLAVEZONADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONADESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CLAVEAGENTELabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        STATUSLabel = New System.Windows.Forms.Label()
        NEGOCIOLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CONSULTA_AGENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CONSULTA_ZONAXAGENTEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_ZONASBYCLAVEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_ZONAXAGENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.CONSULTA_ALMACENDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlmacenContexMenu.SuspendLayout()
        CType(Me.CONSULTA_ALMACENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLAVEAGENTELabel
        '
        CLAVEAGENTELabel.AutoSize = True
        CLAVEAGENTELabel.Location = New System.Drawing.Point(3, 25)
        CLAVEAGENTELabel.Name = "CLAVEAGENTELabel"
        CLAVEAGENTELabel.Size = New System.Drawing.Size(88, 13)
        CLAVEAGENTELabel.TabIndex = 3
        CLAVEAGENTELabel.Text = "CLAVEAGENTE:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(3, 54)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel.TabIndex = 5
        NOMBRELabel.Text = "NOMBRE:"
        '
        'STATUSLabel
        '
        STATUSLabel.AutoSize = True
        STATUSLabel.Location = New System.Drawing.Point(3, 80)
        STATUSLabel.Name = "STATUSLabel"
        STATUSLabel.Size = New System.Drawing.Size(53, 13)
        STATUSLabel.TabIndex = 7
        STATUSLabel.Text = "STATUS:"
        '
        'NEGOCIOLabel
        '
        NEGOCIOLabel.AutoSize = True
        NEGOCIOLabel.Location = New System.Drawing.Point(3, 106)
        NEGOCIOLabel.Name = "NEGOCIOLabel"
        NEGOCIOLabel.Size = New System.Drawing.Size(59, 13)
        NEGOCIOLabel.TabIndex = 9
        NEGOCIOLabel.Text = "NEGOCIO:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(CLAVEAGENTELabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CLAVEAGENTETextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(NOMBRELabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NOMBRETextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(STATUSLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.STATUSTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(NEGOCIOLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.NEGOCIOTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(635, 437)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'CLAVEAGENTETextBox
        '
        Me.CLAVEAGENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_AGENTESBindingSource, "CLAVEAGENTE", True))
        Me.CLAVEAGENTETextBox.Location = New System.Drawing.Point(97, 28)
        Me.CLAVEAGENTETextBox.Name = "CLAVEAGENTETextBox"
        Me.CLAVEAGENTETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CLAVEAGENTETextBox.TabIndex = 4
        '
        'CONSULTA_AGENTESBindingSource
        '
        Me.CONSULTA_AGENTESBindingSource.DataMember = "CONSULTA_AGENTES"
        Me.CONSULTA_AGENTESBindingSource.DataSource = Me.SapForecastDataSet
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NOMBRETextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.NOMBRETextBox, 2)
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_AGENTESBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(97, 57)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(463, 20)
        Me.NOMBRETextBox.TabIndex = 6
        '
        'STATUSTextBox
        '
        Me.STATUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_AGENTESBindingSource, "STATUS", True))
        Me.STATUSTextBox.Location = New System.Drawing.Point(97, 83)
        Me.STATUSTextBox.Name = "STATUSTextBox"
        Me.STATUSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.STATUSTextBox.TabIndex = 8
        '
        'NEGOCIOTextBox
        '
        Me.NEGOCIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_AGENTESBindingSource, "NEGOCIO", True))
        Me.NEGOCIOTextBox.Location = New System.Drawing.Point(97, 109)
        Me.NEGOCIOTextBox.Name = "NEGOCIOTextBox"
        Me.NEGOCIOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NEGOCIOTextBox.TabIndex = 10
        '
        'ToolStrip1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ToolStrip1, 3)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.CortarToolStripButton, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(635, 25)
        Me.ToolStrip1.TabIndex = 11
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
        'Button1
        '
        Me.Button1.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.Button1.Location = New System.Drawing.Point(203, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TabControl1, 3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 135)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(629, 300)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.CONSULTA_ZONAXAGENTEDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(621, 274)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Zona/Región"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CONSULTA_ZONAXAGENTEDataGridView
        '
        Me.CONSULTA_ZONAXAGENTEDataGridView.AllowUserToAddRows = False
        Me.CONSULTA_ZONAXAGENTEDataGridView.AllowUserToDeleteRows = False
        Me.CONSULTA_ZONAXAGENTEDataGridView.AllowUserToOrderColumns = True
        Me.CONSULTA_ZONAXAGENTEDataGridView.AutoGenerateColumns = False
        Me.CONSULTA_ZONAXAGENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_ZONAXAGENTEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COLCLAVEZONA, Me.CLAVEZONADataGridViewTextBoxColumn, Me.ZONADESCDataGridViewTextBoxColumn})
        Me.CONSULTA_ZONAXAGENTEDataGridView.DataSource = Me.CONSULTA_ZONAXAGENTEBindingSource
        Me.CONSULTA_ZONAXAGENTEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_ZONAXAGENTEDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CONSULTA_ZONAXAGENTEDataGridView.Name = "CONSULTA_ZONAXAGENTEDataGridView"
        Me.CONSULTA_ZONAXAGENTEDataGridView.Size = New System.Drawing.Size(615, 268)
        Me.CONSULTA_ZONAXAGENTEDataGridView.TabIndex = 0
        '
        'COLCLAVEZONA
        '
        Me.COLCLAVEZONA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.COLCLAVEZONA.DataPropertyName = "CLAVEZONA"
        Me.COLCLAVEZONA.DataSource = Me.CONSULTA_ZONASBYCLAVEBindingSource
        Me.COLCLAVEZONA.DisplayMember = "DESCRIPCION"
        Me.COLCLAVEZONA.HeaderText = "ZONAS"
        Me.COLCLAVEZONA.Name = "COLCLAVEZONA"
        Me.COLCLAVEZONA.ValueMember = "CLAVE"
        '
        'CONSULTA_ZONASBYCLAVEBindingSource
        '
        Me.CONSULTA_ZONASBYCLAVEBindingSource.DataMember = "CONSULTA_ZONASBYCLAVE"
        Me.CONSULTA_ZONASBYCLAVEBindingSource.DataSource = Me.SapForecastDataSet
        '
        'CONSULTA_ZONAXAGENTEBindingSource
        '
        Me.CONSULTA_ZONAXAGENTEBindingSource.DataMember = "CONSULTA_ZONAXAGENTE"
        Me.CONSULTA_ZONAXAGENTEBindingSource.DataSource = Me.SapForecastDataSet
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CONSULTA_ALMACENDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(621, 274)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Almacenes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CONSULTA_ALMACENDataGridView
        '
        Me.CONSULTA_ALMACENDataGridView.AllowUserToAddRows = False
        Me.CONSULTA_ALMACENDataGridView.AllowUserToDeleteRows = False
        Me.CONSULTA_ALMACENDataGridView.AllowUserToOrderColumns = True
        Me.CONSULTA_ALMACENDataGridView.AutoGenerateColumns = False
        Me.CONSULTA_ALMACENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_ALMACENDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CONSULTA_ALMACENDataGridView.ContextMenuStrip = Me.AlmacenContexMenu
        Me.CONSULTA_ALMACENDataGridView.DataSource = Me.CONSULTA_ALMACENBindingSource
        Me.CONSULTA_ALMACENDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_ALMACENDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CONSULTA_ALMACENDataGridView.Name = "CONSULTA_ALMACENDataGridView"
        Me.CONSULTA_ALMACENDataGridView.ReadOnly = True
        Me.CONSULTA_ALMACENDataGridView.Size = New System.Drawing.Size(615, 268)
        Me.CONSULTA_ALMACENDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CLAVECENTRO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CLAVECENTRO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CLAVEALMACEN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CLAVEALMACEN"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CLAVEAGENTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CLAVEAGENTE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'AlmacenContexMenu
        '
        Me.AlmacenContexMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlmacenMnuAdd, Me.AlmacenMenuDel})
        Me.AlmacenContexMenu.Name = "AlmacenContexMenu"
        Me.AlmacenContexMenu.Size = New System.Drawing.Size(153, 70)
        '
        'AlmacenMnuAdd
        '
        Me.AlmacenMnuAdd.Image = Global.PronosticosSAP.My.Resources.Resources.page_add
        Me.AlmacenMnuAdd.Name = "AlmacenMnuAdd"
        Me.AlmacenMnuAdd.Size = New System.Drawing.Size(152, 22)
        Me.AlmacenMnuAdd.Text = "Insertar"
        '
        'AlmacenMenuDel
        '
        Me.AlmacenMenuDel.Image = Global.PronosticosSAP.My.Resources.Resources.paper_arrow_red_16_ns
        Me.AlmacenMenuDel.Name = "AlmacenMenuDel"
        Me.AlmacenMenuDel.Size = New System.Drawing.Size(152, 22)
        Me.AlmacenMenuDel.Text = "Eliminar"
        '
        'CONSULTA_ALMACENBindingSource
        '
        Me.CONSULTA_ALMACENBindingSource.DataMember = "CONSULTA_ALMACEN"
        Me.CONSULTA_ALMACENBindingSource.DataSource = Me.SapForecastDataSet
        '
        'CONSULTA_AGENTESTableAdapter
        '
        Me.CONSULTA_AGENTESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTA_AGENTECLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTESTableAdapter = Me.CONSULTA_AGENTESTableAdapter
        Me.TableAdapterManager.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USP_CONSULTA_USUARIOTableAdapter = Nothing
        '
        'CONSULTA_ALMACENTableAdapter
        '
        Me.CONSULTA_ALMACENTableAdapter.ClearBeforeFill = True
        '
        'CONSULTA_ZONAXAGENTETableAdapter
        '
        Me.CONSULTA_ZONAXAGENTETableAdapter.ClearBeforeFill = True
        '
        'CONSULTA_ZONASBYCLAVETableAdapter
        '
        Me.CONSULTA_ZONASBYCLAVETableAdapter.ClearBeforeFill = True
        '
        'CLAVEZONADataGridViewTextBoxColumn
        '
        Me.CLAVEZONADataGridViewTextBoxColumn.DataPropertyName = "CLAVEZONA"
        Me.CLAVEZONADataGridViewTextBoxColumn.HeaderText = "CLAVEZONA"
        Me.CLAVEZONADataGridViewTextBoxColumn.Name = "CLAVEZONADataGridViewTextBoxColumn"
        '
        'ZONADESCDataGridViewTextBoxColumn
        '
        Me.ZONADESCDataGridViewTextBoxColumn.DataPropertyName = "ZONADESC"
        Me.ZONADESCDataGridViewTextBoxColumn.HeaderText = "ZONADESC"
        Me.ZONADESCDataGridViewTextBoxColumn.Name = "ZONADESCDataGridViewTextBoxColumn"
        '
        'FrmAgentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 437)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmAgentes"
        Me.Text = "Agentes"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.CONSULTA_AGENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.CONSULTA_ZONAXAGENTEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_ZONASBYCLAVEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_ZONAXAGENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.CONSULTA_ALMACENDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlmacenContexMenu.ResumeLayout(False)
        CType(Me.CONSULTA_ALMACENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_AGENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_AGENTESTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_AGENTESTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CLAVEAGENTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents STATUSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NEGOCIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CONSULTA_ALMACENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_ALMACENTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ALMACENTableAdapter
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CONSULTA_ALMACENDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSULTA_ZONAXAGENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_ZONAXAGENTETableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ZONAXAGENTETableAdapter
    Friend WithEvents CONSULTA_ZONAXAGENTEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AlmacenContexMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AlmacenMnuAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTA_ZONASBYCLAVEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_ZONASBYCLAVETableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ZONASBYCLAVETableAdapter
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlmacenMenuDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COLCLAVEZONA As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CLAVEZONADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZONADESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
