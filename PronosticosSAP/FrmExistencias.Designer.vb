<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExistencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExistencias))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.TsText = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MATNR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WERKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LGORT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHARG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEINS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLABS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPEME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAKTX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CentroTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaterialTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AlmacenTxt = New System.Windows.Forms.TextBox()
        Me.LoteTxt = New System.Windows.Forms.TextBox()
        Me.MaterialBtn = New System.Windows.Forms.Button()
        Me.ExistenciasBGW = New System.ComponentModel.BackgroundWorker()
        Me.ExistenciasToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsProgress, Me.TsText})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 251)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(972, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TsProgress
        '
        Me.TsProgress.Name = "TsProgress"
        Me.TsProgress.Size = New System.Drawing.Size(100, 16)
        '
        'TsText
        '
        Me.TsText.Name = "TsText"
        Me.TsText.Size = New System.Drawing.Size(111, 17)
        Me.TsText.Text = "ToolStripStatusLabel1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.CortarToolStripButton, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(972, 25)
        Me.ToolStrip1.TabIndex = 0
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
        Me.AbrirToolStripButton.Text = "&Abrir"
        Me.AbrirToolStripButton.ToolTipText = "Consultar"
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
        Me.ImprimirToolStripButton.Enabled = False
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton1.Text = "Cancelar"
        Me.ToolStripButton1.ToolTipText = "Cancelar la consulta actual"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.PronosticosSAP.My.Resources.Resources.door_out
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Salir"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CentroTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MaterialTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.AlmacenTxt, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LoteTxt, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.MaterialBtn, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(972, 226)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MATNR, Me.WERKS, Me.LGORT, Me.CHARG, Me.MEINS, Me.CLABS, Me.SPEME, Me.INSME, Me.TRAME, Me.MAKTX})
        Me.TableLayoutPanel1.SetColumnSpan(Me.DataGridView1, 3)
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 157)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(966, 66)
        Me.DataGridView1.TabIndex = 15
        '
        'MATNR
        '
        Me.MATNR.DataPropertyName = "MATNR"
        Me.MATNR.Frozen = True
        Me.MATNR.HeaderText = "NO. MATERIAL"
        Me.MATNR.Name = "MATNR"
        Me.MATNR.ReadOnly = True
        '
        'WERKS
        '
        Me.WERKS.DataPropertyName = "WERKS"
        Me.WERKS.Frozen = True
        Me.WERKS.HeaderText = "CENTRO"
        Me.WERKS.Name = "WERKS"
        Me.WERKS.ReadOnly = True
        '
        'LGORT
        '
        Me.LGORT.DataPropertyName = "LGORT"
        Me.LGORT.Frozen = True
        Me.LGORT.HeaderText = "ALMACEN"
        Me.LGORT.Name = "LGORT"
        Me.LGORT.ReadOnly = True
        '
        'CHARG
        '
        Me.CHARG.DataPropertyName = "CHARG"
        Me.CHARG.Frozen = True
        Me.CHARG.HeaderText = "LOTE"
        Me.CHARG.Name = "CHARG"
        Me.CHARG.ReadOnly = True
        '
        'MEINS
        '
        Me.MEINS.DataPropertyName = "MEINS"
        Me.MEINS.Frozen = True
        Me.MEINS.HeaderText = "UN. MEDIDA BASE"
        Me.MEINS.Name = "MEINS"
        Me.MEINS.ReadOnly = True
        '
        'CLABS
        '
        Me.CLABS.DataPropertyName = "CLABS"
        Me.CLABS.Frozen = True
        Me.CLABS.HeaderText = "LIBRE UTILIZACION"
        Me.CLABS.Name = "CLABS"
        Me.CLABS.ReadOnly = True
        Me.CLABS.Width = 140
        '
        'SPEME
        '
        Me.SPEME.DataPropertyName = "SPEME"
        Me.SPEME.Frozen = True
        Me.SPEME.HeaderText = "BLOQUEADO"
        Me.SPEME.Name = "SPEME"
        Me.SPEME.ReadOnly = True
        '
        'INSME
        '
        Me.INSME.DataPropertyName = "INSME"
        Me.INSME.Frozen = True
        Me.INSME.HeaderText = "EN CONTROL DE CALIDAD"
        Me.INSME.Name = "INSME"
        Me.INSME.ReadOnly = True
        '
        'TRAME
        '
        Me.TRAME.DataPropertyName = "TRAME"
        Me.TRAME.Frozen = True
        Me.TRAME.HeaderText = "TRANSITO"
        Me.TRAME.Name = "TRAME"
        Me.TRAME.ReadOnly = True
        '
        'MAKTX
        '
        Me.MAKTX.DataPropertyName = "MAKTX"
        Me.MAKTX.HeaderText = "Descripción"
        Me.MAKTX.Name = "MAKTX"
        Me.MAKTX.ReadOnly = True
        Me.MAKTX.Width = 300
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label6, 3)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(776, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Para ejecutar este proceso es necesario una conexión activa de internet"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label5, 3)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(417, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Inventarios , Centro/Almacen/Producto"
        '
        'Button3
        '
        Me.Button3.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.Button3.Location = New System.Drawing.Point(173, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 20)
        Me.Button3.TabIndex = 13
        Me.ExistenciasToolTip.SetToolTip(Me.Button3, "Indique los Numero de lotes a consultar, separados por ," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.Button2.Location = New System.Drawing.Point(173, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 20)
        Me.Button2.TabIndex = 10
        Me.ExistenciasToolTip.SetToolTip(Me.Button2, "Indique los almacenes a consultar, separados por ," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.Button1.Location = New System.Drawing.Point(173, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 20)
        Me.Button1.TabIndex = 7
        Me.ExistenciasToolTip.SetToolTip(Me.Button1, "Indique los centrosa consultar, separados por ," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Almacen:"
        '
        'CentroTxt
        '
        Me.CentroTxt.Location = New System.Drawing.Point(73, 79)
        Me.CentroTxt.Name = "CentroTxt"
        Me.CentroTxt.Size = New System.Drawing.Size(94, 20)
        Me.CentroTxt.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Centro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No. Material"
        '
        'MaterialTxt
        '
        Me.MaterialTxt.Location = New System.Drawing.Point(73, 53)
        Me.MaterialTxt.Name = "MaterialTxt"
        Me.MaterialTxt.Size = New System.Drawing.Size(94, 20)
        Me.MaterialTxt.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Lote:"
        '
        'AlmacenTxt
        '
        Me.AlmacenTxt.Location = New System.Drawing.Point(73, 105)
        Me.AlmacenTxt.Name = "AlmacenTxt"
        Me.AlmacenTxt.Size = New System.Drawing.Size(94, 20)
        Me.AlmacenTxt.TabIndex = 9
        '
        'LoteTxt
        '
        Me.LoteTxt.Location = New System.Drawing.Point(73, 131)
        Me.LoteTxt.Name = "LoteTxt"
        Me.LoteTxt.Size = New System.Drawing.Size(94, 20)
        Me.LoteTxt.TabIndex = 12
        '
        'MaterialBtn
        '
        Me.MaterialBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.MaterialBtn.Location = New System.Drawing.Point(173, 53)
        Me.MaterialBtn.Name = "MaterialBtn"
        Me.MaterialBtn.Size = New System.Drawing.Size(28, 20)
        Me.MaterialBtn.TabIndex = 4
        Me.ExistenciasToolTip.SetToolTip(Me.MaterialBtn, "Indique los materiales a consultar, separados por ,")
        Me.MaterialBtn.UseVisualStyleBackColor = True
        '
        'ExistenciasBGW
        '
        Me.ExistenciasBGW.WorkerReportsProgress = True
        Me.ExistenciasBGW.WorkerSupportsCancellation = True
        '
        'FrmExistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 273)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FrmExistencias"
        Me.Text = "Inventarios"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
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
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CentroTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MaterialTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AlmacenTxt As System.Windows.Forms.TextBox
    Friend WithEvents LoteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MaterialBtn As System.Windows.Forms.Button
    Friend WithEvents ExistenciasBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents TsProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TsText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExistenciasToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MATNR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WERKS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LGORT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHARG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEINS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLABS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SPEME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INSME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAKTX As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
