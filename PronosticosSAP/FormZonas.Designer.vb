<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormZonas
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
        Dim CLAVELabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim ESTATUSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormZonas))
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.CONSULTA_ZONASBYCLAVEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTA_ZONASBYCLAVETableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ZONASBYCLAVETableAdapter()
        Me.CLAVETextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIPCIONTextBox = New System.Windows.Forms.TextBox()
        Me.CONSULTAESTADOBYZONATableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTAESTADOBYZONATableAdapter()
        Me.CONSULTAESTADOBYZONADataGridView = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClaveZona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClaveEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesZona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstadoCliente = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CONSULTA_ESTADOGEOGRAFICOBYCLAVEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTAESTADOBYZONABindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CboStatus = New System.Windows.Forms.ComboBox()
        Me.ZonaErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CONSULTA_ESTADOGEOGRAFICOBYCLAVETableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ESTADOGEOGRAFICOBYCLAVETableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ZonaMsgTLS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTipZonas = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.TxtEstatus = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        CLAVELabel = New System.Windows.Forms.Label()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        ESTATUSLabel = New System.Windows.Forms.Label()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_ZONASBYCLAVEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTAESTADOBYZONADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_ESTADOGEOGRAFICOBYCLAVEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTAESTADOBYZONABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ZonaErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CLAVELabel
        '
        CLAVELabel.AutoSize = True
        CLAVELabel.Location = New System.Drawing.Point(12, 46)
        CLAVELabel.Name = "CLAVELabel"
        CLAVELabel.Size = New System.Drawing.Size(44, 13)
        CLAVELabel.TabIndex = 4
        CLAVELabel.Text = "CLAVE:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(12, 72)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(83, 13)
        DESCRIPCIONLabel.TabIndex = 6
        DESCRIPCIONLabel.Text = "DESCRIPCION:"
        '
        'ESTATUSLabel
        '
        ESTATUSLabel.AutoSize = True
        ESTATUSLabel.Location = New System.Drawing.Point(12, 99)
        ESTATUSLabel.Name = "ESTATUSLabel"
        ESTATUSLabel.Size = New System.Drawing.Size(43, 13)
        ESTATUSLabel.TabIndex = 8
        ESTATUSLabel.Text = "Estado:"
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTA_ZONASBYCLAVEBindingSource
        '
        Me.CONSULTA_ZONASBYCLAVEBindingSource.DataMember = "CONSULTA_ZONASBYCLAVE"
        Me.CONSULTA_ZONASBYCLAVEBindingSource.DataSource = Me.SapForecastDataSet
        '
        'CONSULTA_ZONASBYCLAVETableAdapter
        '
        Me.CONSULTA_ZONASBYCLAVETableAdapter.ClearBeforeFill = True
        '
        'CLAVETextBox
        '
        Me.CLAVETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_ZONASBYCLAVEBindingSource, "CLAVE", True))
        Me.CLAVETextBox.Location = New System.Drawing.Point(101, 43)
        Me.CLAVETextBox.MaxLength = 6
        Me.CLAVETextBox.Name = "CLAVETextBox"
        Me.CLAVETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CLAVETextBox.TabIndex = 5
        Me.ToolTipZonas.SetToolTip(Me.CLAVETextBox, "Indique la clave unica de la zona")
        '
        'DESCRIPCIONTextBox
        '
        Me.DESCRIPCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_ZONASBYCLAVEBindingSource, "DESCRIPCION", True))
        Me.DESCRIPCIONTextBox.Location = New System.Drawing.Point(101, 72)
        Me.DESCRIPCIONTextBox.MaxLength = 100
        Me.DESCRIPCIONTextBox.Name = "DESCRIPCIONTextBox"
        Me.DESCRIPCIONTextBox.Size = New System.Drawing.Size(550, 20)
        Me.DESCRIPCIONTextBox.TabIndex = 7
        Me.ToolTipZonas.SetToolTip(Me.DESCRIPCIONTextBox, "Indique la descripcion")
        '
        'CONSULTAESTADOBYZONATableAdapter
        '
        Me.CONSULTAESTADOBYZONATableAdapter.ClearBeforeFill = True
        '
        'CONSULTAESTADOBYZONADataGridView
        '
        Me.CONSULTAESTADOBYZONADataGridView.AllowUserToDeleteRows = False
        Me.CONSULTAESTADOBYZONADataGridView.AutoGenerateColumns = False
        Me.CONSULTAESTADOBYZONADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTAESTADOBYZONADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colClaveZona, Me.colClaveEstado, Me.colDesZona, Me.colEstadoCliente, Me.ColEstatus})
        Me.CONSULTAESTADOBYZONADataGridView.DataSource = Me.CONSULTAESTADOBYZONABindingSource
        Me.CONSULTAESTADOBYZONADataGridView.Location = New System.Drawing.Point(12, 126)
        Me.CONSULTAESTADOBYZONADataGridView.Name = "CONSULTAESTADOBYZONADataGridView"
        Me.CONSULTAESTADOBYZONADataGridView.Size = New System.Drawing.Size(634, 220)
        Me.CONSULTAESTADOBYZONADataGridView.TabIndex = 11
        Me.ToolTipZonas.SetToolTip(Me.CONSULTAESTADOBYZONADataGridView, "Asigne los estados correspondientes")
        '
        'colId
        '
        Me.colId.DataPropertyName = "ID"
        Me.colId.HeaderText = "ID"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        Me.colId.Visible = False
        '
        'colClaveZona
        '
        Me.colClaveZona.DataPropertyName = "CLAVEZONA"
        Me.colClaveZona.HeaderText = "CLAVEZONA"
        Me.colClaveZona.Name = "colClaveZona"
        Me.colClaveZona.Visible = False
        '
        'colClaveEstado
        '
        Me.colClaveEstado.DataPropertyName = "CLAVEESTADO"
        Me.colClaveEstado.HeaderText = "CLAVEESTADO"
        Me.colClaveEstado.Name = "colClaveEstado"
        Me.colClaveEstado.ReadOnly = True
        Me.colClaveEstado.Visible = False
        '
        'colDesZona
        '
        Me.colDesZona.DataPropertyName = "DESCZONA"
        Me.colDesZona.HeaderText = "DESCZONA"
        Me.colDesZona.Name = "colDesZona"
        Me.colDesZona.Visible = False
        '
        'colEstadoCliente
        '
        Me.colEstadoCliente.DataPropertyName = "CLAVEESTADO"
        Me.colEstadoCliente.DataSource = Me.CONSULTA_ESTADOGEOGRAFICOBYCLAVEBindingSource
        Me.colEstadoCliente.DisplayMember = "DESCRIPCION"
        Me.colEstadoCliente.HeaderText = "Estado o Cliente"
        Me.colEstadoCliente.Name = "colEstadoCliente"
        Me.colEstadoCliente.ToolTipText = "Indica el estado o clientes de la zona"
        Me.colEstadoCliente.ValueMember = "CLAVE"
        Me.colEstadoCliente.Width = 300
        '
        'CONSULTA_ESTADOGEOGRAFICOBYCLAVEBindingSource
        '
        Me.CONSULTA_ESTADOGEOGRAFICOBYCLAVEBindingSource.DataMember = "CONSULTA_ESTADOGEOGRAFICOBYCLAVE"
        Me.CONSULTA_ESTADOGEOGRAFICOBYCLAVEBindingSource.DataSource = Me.SapForecastDataSet
        '
        'ColEstatus
        '
        Me.ColEstatus.DataPropertyName = "ESTATUS"
        Me.ColEstatus.HeaderText = "ESTATUS"
        Me.ColEstatus.Name = "ColEstatus"
        '
        'CONSULTAESTADOBYZONABindingSource
        '
        Me.CONSULTAESTADOBYZONABindingSource.DataMember = "CONSULTA_ZONAS_ESTADOS"
        Me.CONSULTAESTADOBYZONABindingSource.DataSource = Me.CONSULTA_ZONASBYCLAVEBindingSource
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.CortarToolStripButton, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(658, 25)
        Me.ToolStrip1.TabIndex = 12
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
        'CboStatus
        '
        Me.CboStatus.FormattingEnabled = True
        Me.CboStatus.Location = New System.Drawing.Point(101, 99)
        Me.CboStatus.Name = "CboStatus"
        Me.CboStatus.Size = New System.Drawing.Size(115, 21)
        Me.CboStatus.TabIndex = 13
        Me.ToolTipZonas.SetToolTip(Me.CboStatus, "Seleccione un elemento")
        '
        'ZonaErrProvider
        '
        Me.ZonaErrProvider.ContainerControl = Me
        '
        'CONSULTA_ESTADOGEOGRAFICOBYCLAVETableAdapter
        '
        Me.CONSULTA_ESTADOGEOGRAFICOBYCLAVETableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZonaMsgTLS})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 350)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(658, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ZonaMsgTLS
        '
        Me.ZonaMsgTLS.Name = "ZonaMsgTLS"
        Me.ZonaMsgTLS.Size = New System.Drawing.Size(0, 17)
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.BtnConsulta.Location = New System.Drawing.Point(207, 43)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(24, 23)
        Me.BtnConsulta.TabIndex = 15
        Me.ToolTipZonas.SetToolTip(Me.BtnConsulta, "Elija un elemento a buscar")
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'TxtEstatus
        '
        Me.TxtEstatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_ZONASBYCLAVEBindingSource, "ESTATUS", True))
        Me.TxtEstatus.Location = New System.Drawing.Point(311, 100)
        Me.TxtEstatus.Name = "TxtEstatus"
        Me.TxtEstatus.Size = New System.Drawing.Size(100, 20)
        Me.TxtEstatus.TabIndex = 16
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTA_AGENTECLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTESTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Me.CONSULTA_ZONASBYCLAVETableAdapter
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Me.CONSULTAESTADOBYZONATableAdapter
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USP_CONSULTA_USUARIOTableAdapter = Nothing
        '
        'FormZonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 372)
        Me.Controls.Add(Me.TxtEstatus)
        Me.Controls.Add(Me.BtnConsulta)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CboStatus)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.CONSULTAESTADOBYZONADataGridView)
        Me.Controls.Add(CLAVELabel)
        Me.Controls.Add(Me.CLAVETextBox)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.DESCRIPCIONTextBox)
        Me.Controls.Add(ESTATUSLabel)
        Me.MaximizeBox = False
        Me.Name = "FormZonas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Regiones"
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_ZONASBYCLAVEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTAESTADOBYZONADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_ESTADOGEOGRAFICOBYCLAVEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTAESTADOBYZONABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ZonaErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_ZONASBYCLAVEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_ZONASBYCLAVETableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ZONASBYCLAVETableAdapter
    Friend WithEvents CLAVETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CONSULTAESTADOBYZONABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTAESTADOBYZONATableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTAESTADOBYZONATableAdapter
    Friend WithEvents CONSULTAESTADOBYZONADataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents CboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents ZonaErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents CONSULTA_ESTADOGEOGRAFICOBYCLAVEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_ESTADOGEOGRAFICOBYCLAVETableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ESTADOGEOGRAFICOBYCLAVETableAdapter
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ZonaMsgTLS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents colId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colClaveZona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colClaveEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesZona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstadoCliente As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ColEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTipZonas As System.Windows.Forms.ToolTip
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents TxtEstatus As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
End Class
