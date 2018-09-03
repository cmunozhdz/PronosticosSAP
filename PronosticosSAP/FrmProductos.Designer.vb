<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim CLAVELabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim DESCRIPCION_DETALLADALabel As System.Windows.Forms.Label
        Dim TIPOLabel As System.Windows.Forms.Label
        Dim NEGOCIOLabel As System.Windows.Forms.Label
        Dim STATUSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductos))
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.CONSULTA_PRODUCTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTA_PRODUCTOTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CLAVETextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIPCIONTextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIPCION_DETALLADATextBox = New System.Windows.Forms.TextBox()
        Me.TIPOTextBox = New System.Windows.Forms.TextBox()
        Me.STATUSTextBox = New System.Windows.Forms.TextBox()
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
        Me.BtnImportarSap = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ProductoErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CONSULTA_PRODUCTOXALMACENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTA_PRODUCTOXALMACENTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOXALMACENTableAdapter()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CONSULTAUMDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTAUMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CONSULTA_PRODUCTOXALMACENDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CboDivision = New System.Windows.Forms.ComboBox()
        Me.CONSULTAUMTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTAUMTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        CLAVELabel = New System.Windows.Forms.Label()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        DESCRIPCION_DETALLADALabel = New System.Windows.Forms.Label()
        TIPOLabel = New System.Windows.Forms.Label()
        NEGOCIOLabel = New System.Windows.Forms.Label()
        STATUSLabel = New System.Windows.Forms.Label()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ProductoErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_PRODUCTOXALMACENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CONSULTAUMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTAUMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.CONSULTA_PRODUCTOXALMACENDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(3, 23)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        IDLabel.Visible = False
        '
        'CLAVELabel
        '
        CLAVELabel.AutoSize = True
        CLAVELabel.Location = New System.Drawing.Point(3, 49)
        CLAVELabel.Name = "CLAVELabel"
        CLAVELabel.Size = New System.Drawing.Size(44, 13)
        CLAVELabel.TabIndex = 4
        CLAVELabel.Text = "CLAVE:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(3, 78)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(83, 13)
        DESCRIPCIONLabel.TabIndex = 6
        DESCRIPCIONLabel.Text = "DESCRIPCION:"
        '
        'DESCRIPCION_DETALLADALabel
        '
        DESCRIPCION_DETALLADALabel.AutoSize = True
        DESCRIPCION_DETALLADALabel.Location = New System.Drawing.Point(3, 104)
        DESCRIPCION_DETALLADALabel.Name = "DESCRIPCION_DETALLADALabel"
        DESCRIPCION_DETALLADALabel.Size = New System.Drawing.Size(149, 13)
        DESCRIPCION_DETALLADALabel.TabIndex = 8
        DESCRIPCION_DETALLADALabel.Text = "DESCRIPCION DETALLADA:"
        '
        'TIPOLabel
        '
        TIPOLabel.AutoSize = True
        TIPOLabel.Location = New System.Drawing.Point(3, 156)
        TIPOLabel.Name = "TIPOLabel"
        TIPOLabel.Size = New System.Drawing.Size(35, 13)
        TIPOLabel.TabIndex = 10
        TIPOLabel.Text = "TIPO:"
        '
        'NEGOCIOLabel
        '
        NEGOCIOLabel.AutoSize = True
        NEGOCIOLabel.Location = New System.Drawing.Point(3, 182)
        NEGOCIOLabel.Name = "NEGOCIOLabel"
        NEGOCIOLabel.Size = New System.Drawing.Size(47, 13)
        NEGOCIOLabel.TabIndex = 12
        NEGOCIOLabel.Text = "División:"
        '
        'STATUSLabel
        '
        STATUSLabel.AutoSize = True
        STATUSLabel.Location = New System.Drawing.Point(3, 209)
        STATUSLabel.Name = "STATUSLabel"
        STATUSLabel.Size = New System.Drawing.Size(53, 13)
        STATUSLabel.TabIndex = 14
        STATUSLabel.Text = "STATUS:"
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTA_PRODUCTOBindingSource
        '
        Me.CONSULTA_PRODUCTOBindingSource.DataMember = "CONSULTA_PRODUCTO"
        Me.CONSULTA_PRODUCTOBindingSource.DataSource = Me.SapForecastDataSet
        '
        'CONSULTA_PRODUCTOTableAdapter
        '
        Me.CONSULTA_PRODUCTOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTA_AGENTECLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTESTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_DIASFESTIVOSALLTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Me.CONSULTA_PRODUCTOTableAdapter
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USP_CONSULTA_USUARIOTableAdapter = Nothing
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_PRODUCTOBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(158, 26)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 3
        Me.IDTextBox.Visible = False
        '
        'CLAVETextBox
        '
        Me.CLAVETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_PRODUCTOBindingSource, "CLAVE", True))
        Me.CLAVETextBox.Location = New System.Drawing.Point(158, 52)
        Me.CLAVETextBox.Name = "CLAVETextBox"
        Me.CLAVETextBox.Size = New System.Drawing.Size(45, 20)
        Me.CLAVETextBox.TabIndex = 5
        '
        'DESCRIPCIONTextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DESCRIPCIONTextBox, 2)
        Me.DESCRIPCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_PRODUCTOBindingSource, "DESCRIPCION", True))
        Me.DESCRIPCIONTextBox.Location = New System.Drawing.Point(158, 81)
        Me.DESCRIPCIONTextBox.Name = "DESCRIPCIONTextBox"
        Me.DESCRIPCIONTextBox.Size = New System.Drawing.Size(486, 20)
        Me.DESCRIPCIONTextBox.TabIndex = 7
        '
        'DESCRIPCION_DETALLADATextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DESCRIPCION_DETALLADATextBox, 2)
        Me.DESCRIPCION_DETALLADATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_PRODUCTOBindingSource, "DESCRIPCION_DETALLADA", True))
        Me.DESCRIPCION_DETALLADATextBox.Location = New System.Drawing.Point(158, 107)
        Me.DESCRIPCION_DETALLADATextBox.Multiline = True
        Me.DESCRIPCION_DETALLADATextBox.Name = "DESCRIPCION_DETALLADATextBox"
        Me.DESCRIPCION_DETALLADATextBox.Size = New System.Drawing.Size(486, 46)
        Me.DESCRIPCION_DETALLADATextBox.TabIndex = 9
        '
        'TIPOTextBox
        '
        Me.TIPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_PRODUCTOBindingSource, "TIPO", True))
        Me.TIPOTextBox.Location = New System.Drawing.Point(158, 159)
        Me.TIPOTextBox.Name = "TIPOTextBox"
        Me.TIPOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TIPOTextBox.TabIndex = 11
        '
        'STATUSTextBox
        '
        Me.STATUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_PRODUCTOBindingSource, "STATUS", True))
        Me.STATUSTextBox.Location = New System.Drawing.Point(158, 212)
        Me.STATUSTextBox.Name = "STATUSTextBox"
        Me.STATUSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.STATUSTextBox.TabIndex = 15
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.CortarToolStripButton, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton, Me.BtnImportarSap, Me.ToolStripSeparator2, Me.BtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1033, 25)
        Me.ToolStrip1.TabIndex = 16
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
        Me.NuevoToolStripButton.Visible = False
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), System.Drawing.Image)
        Me.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        Me.AbrirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AbrirToolStripButton.Text = "&Consultar"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton.Text = "&Guardar"
        Me.GuardarToolStripButton.Visible = False
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
        'BtnImportarSap
        '
        Me.BtnImportarSap.Image = Global.PronosticosSAP.My.Resources.Resources.arrow_switch
        Me.BtnImportarSap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnImportarSap.Name = "BtnImportarSap"
        Me.BtnImportarSap.Size = New System.Drawing.Size(121, 22)
        Me.BtnImportarSap.Text = "Sincronizar con SAP"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnSalir
        '
        Me.BtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSalir.Image = Global.PronosticosSAP.My.Resources.Resources.door_out
        Me.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(23, 22)
        Me.BtnSalir.Text = "ToolStripButton1"
        '
        'ProductoErrProvider
        '
        Me.ProductoErrProvider.ContainerControl = Me
        '
        'CONSULTA_PRODUCTOXALMACENBindingSource
        '
        Me.CONSULTA_PRODUCTOXALMACENBindingSource.DataMember = "RELPRODUCTO_ALMACEN"
        Me.CONSULTA_PRODUCTOXALMACENBindingSource.DataSource = Me.CONSULTA_PRODUCTOBindingSource
        '
        'CONSULTA_PRODUCTOXALMACENTableAdapter
        '
        Me.CONSULTA_PRODUCTOXALMACENTableAdapter.ClearBeforeFill = True
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.BuscarBtn.Location = New System.Drawing.Point(285, 52)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(26, 23)
        Me.BuscarBtn.TabIndex = 18
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BuscarBtn, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.STATUSTextBox, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.DESCRIPCION_DETALLADATextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(STATUSLabel, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(NEGOCIOLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(TIPOLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(DESCRIPCION_DETALLADALabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(DESCRIPCIONLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CLAVETextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DESCRIPCIONTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(CLAVELabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TIPOTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.IDTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(IDLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.CboDivision, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1033, 415)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 23)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Consulta Catálogo de Productos"
        '
        'TabControl1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TabControl1, 3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 238)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1027, 174)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CONSULTAUMDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1019, 148)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Unidades de Medida"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CONSULTAUMDataGridView
        '
        Me.CONSULTAUMDataGridView.AllowUserToAddRows = False
        Me.CONSULTAUMDataGridView.AllowUserToDeleteRows = False
        Me.CONSULTAUMDataGridView.AutoGenerateColumns = False
        Me.CONSULTAUMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTAUMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn13})
        Me.CONSULTAUMDataGridView.DataSource = Me.CONSULTAUMBindingSource
        Me.CONSULTAUMDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTAUMDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CONSULTAUMDataGridView.Name = "CONSULTAUMDataGridView"
        Me.CONSULTAUMDataGridView.ReadOnly = True
        Me.CONSULTAUMDataGridView.Size = New System.Drawing.Size(1013, 142)
        Me.CONSULTAUMDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UNIDAMEDIDABASE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "UND. BASE"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "UNIDAMEDIDAALTERNA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "UND. ALTERNA"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "OPERADOR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "OPERADOR"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FACTOR"
        Me.DataGridViewTextBoxColumn12.HeaderText = "FACTOR"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CANTIDADEXACTA"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "CANTIDADEXACTA"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn13.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'CONSULTAUMBindingSource
        '
        Me.CONSULTAUMBindingSource.DataMember = "CONSULTAUM"
        Me.CONSULTAUMBindingSource.DataSource = Me.SapForecastDataSet
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CONSULTA_PRODUCTOXALMACENDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1019, 148)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Almacenes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CONSULTA_PRODUCTOXALMACENDataGridView
        '
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.AllowUserToAddRows = False
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.AllowUserToDeleteRows = False
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.AutoGenerateColumns = False
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5})
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.DataSource = Me.CONSULTA_PRODUCTOXALMACENBindingSource
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.Name = "CONSULTA_PRODUCTOXALMACENDataGridView"
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.ReadOnly = True
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.Size = New System.Drawing.Size(1013, 143)
        Me.CONSULTA_PRODUCTOXALMACENDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CLAVEPRODUCTO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CLAVEPRODUCTO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CLAVECENTRO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CLAVECENTRO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CLAVEALMACEN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CLAVEALMACEN"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DESCALMACEN"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DESCALMACEN"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'CboDivision
        '
        Me.CboDivision.FormattingEnabled = True
        Me.CboDivision.Location = New System.Drawing.Point(158, 185)
        Me.CboDivision.Name = "CboDivision"
        Me.CboDivision.Size = New System.Drawing.Size(121, 21)
        Me.CboDivision.TabIndex = 21
        '
        'CONSULTAUMTableAdapter
        '
        Me.CONSULTAUMTableAdapter.ClearBeforeFill = True
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 440)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmProductos"
        Me.Text = "Productos"
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ProductoErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_PRODUCTOXALMACENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.CONSULTAUMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTAUMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.CONSULTA_PRODUCTOXALMACENDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_PRODUCTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_PRODUCTOTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CLAVETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPCION_DETALLADATextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIPOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STATUSTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents ProductoErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents CONSULTA_PRODUCTOXALMACENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_PRODUCTOXALMACENTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOXALMACENTableAdapter
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CONSULTAUMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTAUMTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTAUMTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CONSULTAUMDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CONSULTA_PRODUCTOXALMACENDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnImportarSap As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CboDivision As System.Windows.Forms.ComboBox
End Class
