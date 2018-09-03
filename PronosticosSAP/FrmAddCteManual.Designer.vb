<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddCteManual
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
        Dim SOCIEDADLabel As System.Windows.Forms.Label
        Dim CLAVECLIENTELabel As System.Windows.Forms.Label
        Dim RAZONSOCIALLabel As System.Windows.Forms.Label
        Dim FECHAACTUALIZACIONLabel As System.Windows.Forms.Label
        Dim CLAVEAGENTELabel As System.Windows.Forms.Label
        Dim VIGENCIALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddCteManual))
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.CONSULTA_CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTA_CLIENTESTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_CLIENTESTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.CONSULTA_CLIENTESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CONSULTA_CLIENTESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CVESOCIEDADToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CVESOCIEDADToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CVECLIENTEToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CVECLIENTEToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RAZONSOCIALToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.RAZONSOCIALToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SOCIEDADTextBox = New System.Windows.Forms.TextBox()
        Me.CLAVECLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.RAZONSOCIALTextBox = New System.Windows.Forms.TextBox()
        Me.FECHAACTUALIZACIONDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CLAVEAGENTETextBox = New System.Windows.Forms.TextBox()
        Me.CHR_ORIGENTextBox = New System.Windows.Forms.TextBox()
        Me.VIGENCIADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        Me.ClienteTp = New System.Windows.Forms.ToolTip(Me.components)
        IDLabel = New System.Windows.Forms.Label()
        SOCIEDADLabel = New System.Windows.Forms.Label()
        CLAVECLIENTELabel = New System.Windows.Forms.Label()
        RAZONSOCIALLabel = New System.Windows.Forms.Label()
        FECHAACTUALIZACIONLabel = New System.Windows.Forms.Label()
        CLAVEAGENTELabel = New System.Windows.Forms.Label()
        VIGENCIALabel = New System.Windows.Forms.Label()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_CLIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONSULTA_CLIENTESBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(3, 25)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'SOCIEDADLabel
        '
        SOCIEDADLabel.AutoSize = True
        SOCIEDADLabel.Location = New System.Drawing.Point(3, 51)
        SOCIEDADLabel.Name = "SOCIEDADLabel"
        SOCIEDADLabel.Size = New System.Drawing.Size(65, 13)
        SOCIEDADLabel.TabIndex = 4
        SOCIEDADLabel.Text = "SOCIEDAD:"
        '
        'CLAVECLIENTELabel
        '
        CLAVECLIENTELabel.AutoSize = True
        CLAVECLIENTELabel.Location = New System.Drawing.Point(3, 77)
        CLAVECLIENTELabel.Name = "CLAVECLIENTELabel"
        CLAVECLIENTELabel.Size = New System.Drawing.Size(92, 13)
        CLAVECLIENTELabel.TabIndex = 6
        CLAVECLIENTELabel.Text = "CLAVE CLIENTE:"
        '
        'RAZONSOCIALLabel
        '
        RAZONSOCIALLabel.AutoSize = True
        RAZONSOCIALLabel.Location = New System.Drawing.Point(3, 103)
        RAZONSOCIALLabel.Name = "RAZONSOCIALLabel"
        RAZONSOCIALLabel.Size = New System.Drawing.Size(86, 13)
        RAZONSOCIALLabel.TabIndex = 8
        RAZONSOCIALLabel.Text = "RAZONSOCIAL:"
        '
        'FECHAACTUALIZACIONLabel
        '
        FECHAACTUALIZACIONLabel.AutoSize = True
        FECHAACTUALIZACIONLabel.Location = New System.Drawing.Point(3, 129)
        FECHAACTUALIZACIONLabel.Name = "FECHAACTUALIZACIONLabel"
        FECHAACTUALIZACIONLabel.Size = New System.Drawing.Size(133, 13)
        FECHAACTUALIZACIONLabel.TabIndex = 10
        FECHAACTUALIZACIONLabel.Text = "FECHA ACTUALIZACION:"
        '
        'CLAVEAGENTELabel
        '
        CLAVEAGENTELabel.AutoSize = True
        CLAVEAGENTELabel.Location = New System.Drawing.Point(3, 155)
        CLAVEAGENTELabel.Name = "CLAVEAGENTELabel"
        CLAVEAGENTELabel.Size = New System.Drawing.Size(91, 13)
        CLAVEAGENTELabel.TabIndex = 12
        CLAVEAGENTELabel.Text = "CLAVE AGENTE:"
        '
        'VIGENCIALabel
        '
        VIGENCIALabel.AutoSize = True
        VIGENCIALabel.Location = New System.Drawing.Point(3, 181)
        VIGENCIALabel.Name = "VIGENCIALabel"
        VIGENCIALabel.Size = New System.Drawing.Size(60, 13)
        VIGENCIALabel.TabIndex = 16
        VIGENCIALabel.Text = "VIGENCIA:"
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTA_CLIENTESBindingSource
        '
        Me.CONSULTA_CLIENTESBindingSource.DataMember = "CONSULTA_CLIENTES"
        Me.CONSULTA_CLIENTESBindingSource.DataSource = Me.SapForecastDataSet
        '
        'CONSULTA_CLIENTESTableAdapter
        '
        Me.CONSULTA_CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTA_AGENTECLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTESTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_CLIENTESTableAdapter = Me.CONSULTA_CLIENTESTableAdapter
        Me.TableAdapterManager.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_DIASFESTIVOSALLTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USP_CONSULTA_USUARIOTableAdapter = Nothing
        '
        'CONSULTA_CLIENTESBindingNavigator
        '
        Me.CONSULTA_CLIENTESBindingNavigator.AddNewItem = Nothing
        Me.CONSULTA_CLIENTESBindingNavigator.BindingSource = Me.CONSULTA_CLIENTESBindingSource
        Me.CONSULTA_CLIENTESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CONSULTA_CLIENTESBindingNavigator.DeleteItem = Nothing
        Me.CONSULTA_CLIENTESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.CONSULTA_CLIENTESBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.CONSULTA_CLIENTESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CONSULTA_CLIENTESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CONSULTA_CLIENTESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CONSULTA_CLIENTESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CONSULTA_CLIENTESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CONSULTA_CLIENTESBindingNavigator.Name = "CONSULTA_CLIENTESBindingNavigator"
        Me.CONSULTA_CLIENTESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CONSULTA_CLIENTESBindingNavigator.Size = New System.Drawing.Size(791, 25)
        Me.CONSULTA_CLIENTESBindingNavigator.TabIndex = 0
        Me.CONSULTA_CLIENTESBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CONSULTA_CLIENTESBindingNavigatorSaveItem
        '
        Me.CONSULTA_CLIENTESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CONSULTA_CLIENTESBindingNavigatorSaveItem.Image = CType(resources.GetObject("CONSULTA_CLIENTESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CONSULTA_CLIENTESBindingNavigatorSaveItem.Name = "CONSULTA_CLIENTESBindingNavigatorSaveItem"
        Me.CONSULTA_CLIENTESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CONSULTA_CLIENTESBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.PronosticosSAP.My.Resources.Resources.page_star_24
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Agregar"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CVESOCIEDADToolStripLabel, Me.CVESOCIEDADToolStripTextBox, Me.CVECLIENTEToolStripLabel, Me.CVECLIENTEToolStripTextBox, Me.RAZONSOCIALToolStripLabel, Me.RAZONSOCIALToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(791, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'CVESOCIEDADToolStripLabel
        '
        Me.CVESOCIEDADToolStripLabel.Name = "CVESOCIEDADToolStripLabel"
        Me.CVESOCIEDADToolStripLabel.Size = New System.Drawing.Size(85, 22)
        Me.CVESOCIEDADToolStripLabel.Text = "CVE SOCIEDAD:"
        Me.CVESOCIEDADToolStripLabel.ToolTipText = "No. Sociedad Ventas"
        '
        'CVESOCIEDADToolStripTextBox
        '
        Me.CVESOCIEDADToolStripTextBox.Name = "CVESOCIEDADToolStripTextBox"
        Me.CVESOCIEDADToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'CVECLIENTEToolStripLabel
        '
        Me.CVECLIENTEToolStripLabel.Name = "CVECLIENTEToolStripLabel"
        Me.CVECLIENTEToolStripLabel.Size = New System.Drawing.Size(74, 22)
        Me.CVECLIENTEToolStripLabel.Text = "CVE CLIENTE:"
        '
        'CVECLIENTEToolStripTextBox
        '
        Me.CVECLIENTEToolStripTextBox.Name = "CVECLIENTEToolStripTextBox"
        Me.CVECLIENTEToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'RAZONSOCIALToolStripLabel
        '
        Me.RAZONSOCIALToolStripLabel.Name = "RAZONSOCIALToolStripLabel"
        Me.RAZONSOCIALToolStripLabel.Size = New System.Drawing.Size(86, 22)
        Me.RAZONSOCIALToolStripLabel.Text = "RAZO NSOCIAL:"
        '
        'RAZONSOCIALToolStripTextBox
        '
        Me.RAZONSOCIALToolStripTextBox.Name = "RAZONSOCIALToolStripTextBox"
        Me.RAZONSOCIALToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(43, 22)
        Me.FillToolStripButton.Text = "Buscar"
        Me.FillToolStripButton.ToolTipText = "BuscarClientes según los criterios Indicados"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_CLIENTESBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(176, 28)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 3
        Me.ClienteTp.SetToolTip(Me.IDTextBox, "Consecutivo Interno no es editable")
        '
        'SOCIEDADTextBox
        '
        Me.SOCIEDADTextBox.AutoCompleteCustomSource.AddRange(New String() {"1000", "2000"})
        Me.SOCIEDADTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SOCIEDADTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SOCIEDADTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_CLIENTESBindingSource, "SOCIEDAD", True))
        Me.SOCIEDADTextBox.Location = New System.Drawing.Point(176, 54)
        Me.SOCIEDADTextBox.MaxLength = 4
        Me.SOCIEDADTextBox.Name = "SOCIEDADTextBox"
        Me.SOCIEDADTextBox.Size = New System.Drawing.Size(128, 20)
        Me.SOCIEDADTextBox.TabIndex = 5
        Me.ClienteTp.SetToolTip(Me.SOCIEDADTextBox, "Indicar la clave numérica de la sociedad, 1000 o 2000")
        '
        'CLAVECLIENTETextBox
        '
        Me.CLAVECLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_CLIENTESBindingSource, "CLAVECLIENTE", True))
        Me.CLAVECLIENTETextBox.Location = New System.Drawing.Point(176, 80)
        Me.CLAVECLIENTETextBox.MaxLength = 6
        Me.CLAVECLIENTETextBox.Name = "CLAVECLIENTETextBox"
        Me.CLAVECLIENTETextBox.Size = New System.Drawing.Size(128, 20)
        Me.CLAVECLIENTETextBox.TabIndex = 7
        Me.ClienteTp.SetToolTip(Me.CLAVECLIENTETextBox, "Indicar la clave del cliente asignado en SAP")
        '
        'RAZONSOCIALTextBox
        '
        Me.RAZONSOCIALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_CLIENTESBindingSource, "RAZONSOCIAL", True))
        Me.RAZONSOCIALTextBox.Location = New System.Drawing.Point(176, 106)
        Me.RAZONSOCIALTextBox.MaxLength = 255
        Me.RAZONSOCIALTextBox.Name = "RAZONSOCIALTextBox"
        Me.RAZONSOCIALTextBox.Size = New System.Drawing.Size(534, 20)
        Me.RAZONSOCIALTextBox.TabIndex = 9
        Me.ClienteTp.SetToolTip(Me.RAZONSOCIALTextBox, "RAZON SOCIAL (ESTE DATO NO SE VALIDA EN SAP)")
        '
        'FECHAACTUALIZACIONDateTimePicker
        '
        Me.FECHAACTUALIZACIONDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CONSULTA_CLIENTESBindingSource, "FECHAACTUALIZACION", True))
        Me.FECHAACTUALIZACIONDateTimePicker.Enabled = False
        Me.FECHAACTUALIZACIONDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHAACTUALIZACIONDateTimePicker.Location = New System.Drawing.Point(176, 132)
        Me.FECHAACTUALIZACIONDateTimePicker.Name = "FECHAACTUALIZACIONDateTimePicker"
        Me.FECHAACTUALIZACIONDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHAACTUALIZACIONDateTimePicker.TabIndex = 11
        Me.ClienteTp.SetToolTip(Me.FECHAACTUALIZACIONDateTimePicker, "Fecha en que se hace la actualización")
        '
        'CLAVEAGENTETextBox
        '
        Me.CLAVEAGENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_CLIENTESBindingSource, "CLAVEAGENTE", True))
        Me.CLAVEAGENTETextBox.Location = New System.Drawing.Point(176, 158)
        Me.CLAVEAGENTETextBox.Name = "CLAVEAGENTETextBox"
        Me.CLAVEAGENTETextBox.ReadOnly = True
        Me.CLAVEAGENTETextBox.Size = New System.Drawing.Size(200, 20)
        Me.CLAVEAGENTETextBox.TabIndex = 13
        Me.ClienteTp.SetToolTip(Me.CLAVEAGENTETextBox, "Agente asignado")
        '
        'CHR_ORIGENTextBox
        '
        Me.CHR_ORIGENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTA_CLIENTESBindingSource, "CHR_ORIGEN", True))
        Me.CHR_ORIGENTextBox.Enabled = False
        Me.CHR_ORIGENTextBox.Location = New System.Drawing.Point(176, 210)
        Me.CHR_ORIGENTextBox.Name = "CHR_ORIGENTextBox"
        Me.CHR_ORIGENTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CHR_ORIGENTextBox.TabIndex = 15
        Me.CHR_ORIGENTextBox.Visible = False
        '
        'VIGENCIADateTimePicker
        '
        Me.VIGENCIADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CONSULTA_CLIENTESBindingSource, "VIGENCIA", True))
        Me.VIGENCIADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VIGENCIADateTimePicker.Location = New System.Drawing.Point(176, 184)
        Me.VIGENCIADateTimePicker.Name = "VIGENCIADateTimePicker"
        Me.VIGENCIADateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.VIGENCIADateTimePicker.TabIndex = 17
        Me.ClienteTp.SetToolTip(Me.VIGENCIADateTimePicker, "Fecha en la cual el cliente deja de reecibir pronosticos")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.99747!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.00253!))
        Me.TableLayoutPanel1.Controls.Add(IDLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CLAVEAGENTETextBox, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CHR_ORIGENTextBox, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(CLAVEAGENTELabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.VIGENCIADateTimePicker, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(VIGENCIALabel, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.FECHAACTUALIZACIONDateTimePicker, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(FECHAACTUALIZACIONLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.RAZONSOCIALTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(RAZONSOCIALLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CLAVECLIENTETextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(CLAVECLIENTELabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.SOCIEDADTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(SOCIEDADLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.IDTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 50)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(791, 267)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(557, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Catálogo de clientes identificados como distribuidor"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'HelpProvider
        '
        Me.HelpProvider.Tag = "30300"
        '
        'FrmAddCteManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 317)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.CONSULTA_CLIENTESBindingNavigator)
        Me.Name = "FrmAddCteManual"
        Me.Text = "FrmAddCteManual"
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_CLIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONSULTA_CLIENTESBindingNavigator.ResumeLayout(False)
        Me.CONSULTA_CLIENTESBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_CLIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_CLIENTESTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_CLIENTESTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTA_CLIENTESBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CONSULTA_CLIENTESBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CVESOCIEDADToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CVESOCIEDADToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CVECLIENTEToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CVECLIENTEToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RAZONSOCIALToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RAZONSOCIALToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SOCIEDADTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CLAVECLIENTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents RAZONSOCIALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHAACTUALIZACIONDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CLAVEAGENTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CHR_ORIGENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VIGENCIADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents HelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents ClienteTp As System.Windows.Forms.ToolTip
End Class
