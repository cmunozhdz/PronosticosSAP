<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepartos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepartos))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.QTYPendienteLbl = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PegarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolRegresarBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLAVEALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CentroTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PronosticoLbl = New System.Windows.Forms.Label()
        Me.FechaLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductoTxt = New System.Windows.Forms.TextBox()
        Me.QtyProgramadaLbl = New System.Windows.Forms.Label()
        Me.EquivalenciaLbl = New System.Windows.Forms.Label()
        Me.DescProductoLbl = New System.Windows.Forms.Label()
        Me.QtyLbl = New System.Windows.Forms.Label()
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_DETALLEPRONOSTICOSALMACENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.QTYPendienteLbl, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CentroTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PronosticoLbl, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaLbl, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ProductoTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.QtyProgramadaLbl, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.EquivalenciaLbl, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DescProductoLbl, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.QtyLbl, 2, 8)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(517, 414)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'QTYPendienteLbl
        '
        Me.QTYPendienteLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QTYPendienteLbl.AutoSize = True
        Me.QTYPendienteLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTYPendienteLbl.ForeColor = System.Drawing.Color.Red
        Me.QTYPendienteLbl.Location = New System.Drawing.Point(370, 342)
        Me.QTYPendienteLbl.Name = "QTYPendienteLbl"
        Me.QTYPendienteLbl.Size = New System.Drawing.Size(146, 16)
        Me.QTYPendienteLbl.TabIndex = 14
        Me.QTYPendienteLbl.Text = "QTYPROGRAMADA"
        '
        'ToolStrip1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ToolStrip1, 3)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.toolStripSeparator, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.ToolRegresarBtn, Me.ToolStripSeparator2, Me.AyudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(519, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), System.Drawing.Image)
        Me.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        Me.AbrirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AbrirToolStripButton.Text = "&Importar"
        Me.AbrirToolStripButton.ToolTipText = "Importa el pronositico de un archivo de texto separado por tabuladores"
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
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
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
        'ToolRegresarBtn
        '
        Me.ToolRegresarBtn.Image = CType(resources.GetObject("ToolRegresarBtn.Image"), System.Drawing.Image)
        Me.ToolRegresarBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolRegresarBtn.Name = "ToolRegresarBtn"
        Me.ToolRegresarBtn.Size = New System.Drawing.Size(71, 22)
        Me.ToolRegresarBtn.Text = "&Regresar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView
        '
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.AllowUserToAddRows = False
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.AllowUserToDeleteRows = False
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.AllowUserToOrderColumns = True
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.AutoGenerateColumns = False
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.CLAVEALMACEN, Me.DESCALMACEN, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.TableLayoutPanel1.SetColumnSpan(Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView, 3)
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.DataSource = Me.CONSULTA_DETALLEPRONOSTICOSALMACENBindingSource
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Location = New System.Drawing.Point(3, 122)
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Name = "CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView"
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.Size = New System.Drawing.Size(513, 185)
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDPRONOSTICO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDPRONOSTICO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'CLAVEALMACEN
        '
        Me.CLAVEALMACEN.DataPropertyName = "CLAVEALMACEN"
        Me.CLAVEALMACEN.HeaderText = "CLAVE ALMACEN"
        Me.CLAVEALMACEN.Name = "CLAVEALMACEN"
        Me.CLAVEALMACEN.ReadOnly = True
        '
        'DESCALMACEN
        '
        Me.DESCALMACEN.DataPropertyName = "DESCALMACEN"
        Me.DESCALMACEN.HeaderText = "DESCRIPCION"
        Me.DESCALMACEN.Name = "DESCALMACEN"
        Me.DESCALMACEN.ReadOnly = True
        Me.DESCALMACEN.ToolTipText = "DESCRIPCION DEL ALMACEN"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "INTPERIODO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "INTPERIODO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CLAVECENTRO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CLAVECENTRO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CLAVEPRODUCTO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CLAVEPRODUCTO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NUMCANTIDADBASE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CANTIDAD "
        Me.DataGridViewTextBoxColumn7.MaxInputLength = 99
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ToolTipText = "CANTIDAD EN UNIDADES BASE"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NUMCANTIDADALTERNA"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CANT. PRESENTACION"
        Me.DataGridViewTextBoxColumn8.MaxInputLength = 99
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.ToolTipText = "CANTIDAD X PRESENTACION"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SMDTIMESTAMP"
        Me.DataGridViewTextBoxColumn9.HeaderText = "SMDTIMESTAMP"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'CONSULTA_DETALLEPRONOSTICOSALMACENBindingSource
        '
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENBindingSource.DataMember = "CONSULTA_DETALLEPRONOSTICOSALMACEN"
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENBindingSource.DataSource = Me.SapForecastDataSet
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Centro:"
        '
        'CentroTxt
        '
        Me.CentroTxt.Location = New System.Drawing.Point(95, 54)
        Me.CentroTxt.Name = "CentroTxt"
        Me.CentroTxt.ReadOnly = True
        Me.CentroTxt.Size = New System.Drawing.Size(71, 20)
        Me.CentroTxt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pronostico:"
        '
        'PronosticoLbl
        '
        Me.PronosticoLbl.AutoSize = True
        Me.PronosticoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PronosticoLbl.ForeColor = System.Drawing.Color.Navy
        Me.PronosticoLbl.Location = New System.Drawing.Point(95, 35)
        Me.PronosticoLbl.Name = "PronosticoLbl"
        Me.PronosticoLbl.Size = New System.Drawing.Size(0, 16)
        Me.PronosticoLbl.TabIndex = 6
        '
        'FechaLbl
        '
        Me.FechaLbl.AutoSize = True
        Me.FechaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLbl.Location = New System.Drawing.Point(172, 35)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.Size = New System.Drawing.Size(52, 16)
        Me.FechaLbl.TabIndex = 7
        Me.FechaLbl.Text = "FEcha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Producto:"
        '
        'ProductoTxt
        '
        Me.ProductoTxt.Location = New System.Drawing.Point(95, 80)
        Me.ProductoTxt.Name = "ProductoTxt"
        Me.ProductoTxt.ReadOnly = True
        Me.ProductoTxt.Size = New System.Drawing.Size(71, 20)
        Me.ProductoTxt.TabIndex = 3
        '
        'QtyProgramadaLbl
        '
        Me.QtyProgramadaLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QtyProgramadaLbl.AutoSize = True
        Me.QtyProgramadaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyProgramadaLbl.ForeColor = System.Drawing.Color.Blue
        Me.QtyProgramadaLbl.Location = New System.Drawing.Point(370, 326)
        Me.QtyProgramadaLbl.Name = "QtyProgramadaLbl"
        Me.QtyProgramadaLbl.Size = New System.Drawing.Size(146, 16)
        Me.QtyProgramadaLbl.TabIndex = 13
        Me.QtyProgramadaLbl.Text = "QTYPROGRAMADA"
        '
        'EquivalenciaLbl
        '
        Me.EquivalenciaLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.EquivalenciaLbl, 2)
        Me.EquivalenciaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquivalenciaLbl.Location = New System.Drawing.Point(3, 103)
        Me.EquivalenciaLbl.Name = "EquivalenciaLbl"
        Me.EquivalenciaLbl.Size = New System.Drawing.Size(103, 16)
        Me.EquivalenciaLbl.TabIndex = 11
        Me.EquivalenciaLbl.Text = "Presentación:"
        '
        'DescProductoLbl
        '
        Me.DescProductoLbl.AutoSize = True
        Me.DescProductoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescProductoLbl.Location = New System.Drawing.Point(172, 77)
        Me.DescProductoLbl.Name = "DescProductoLbl"
        Me.DescProductoLbl.Size = New System.Drawing.Size(142, 16)
        Me.DescProductoLbl.TabIndex = 9
        Me.DescProductoLbl.Text = "DESC. PRODUCTO"
        '
        'QtyLbl
        '
        Me.QtyLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QtyLbl.AutoSize = True
        Me.QtyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyLbl.Location = New System.Drawing.Point(477, 310)
        Me.QtyLbl.Name = "QtyLbl"
        Me.QtyLbl.Size = New System.Drawing.Size(39, 16)
        Me.QtyLbl.TabIndex = 10
        Me.QtyLbl.Text = "QTY"
        '
        'CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter
        '
        Me.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTA_AGENTECLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTESTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter = Me.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USP_CONSULTA_USUARIOTableAdapter = Nothing
        '
        'FrmRepartos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(527, 450)
        Me.MinimumSize = New System.Drawing.Size(527, 450)
        Me.Name = "FrmRepartos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Repartos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_DETALLEPRONOSTICOSALMACENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CentroTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProductoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PronosticoLbl As System.Windows.Forms.Label
    Friend WithEvents FechaLbl As System.Windows.Forms.Label
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_DETALLEPRONOSTICOSALMACENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTA_DETALLEPRONOSTICOSALMACENDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents AbrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopiarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PegarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DescProductoLbl As System.Windows.Forms.Label
    Friend WithEvents EquivalenciaLbl As System.Windows.Forms.Label
    Friend WithEvents QtyProgramadaLbl As System.Windows.Forms.Label
    Friend WithEvents QtyLbl As System.Windows.Forms.Label
    Friend WithEvents ToolRegresarBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QTYPendienteLbl As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLAVEALMACEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCALMACEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
