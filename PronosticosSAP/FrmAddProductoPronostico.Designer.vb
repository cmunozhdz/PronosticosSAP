<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddProductoPronostico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddProductoPronostico))
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.ALMACENPRONOSTICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALMACENPRONOSTICOTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.ALMACENPRONOSTICOTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DescAgenteTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdPronosticoTxt = New System.Windows.Forms.TextBox()
        Me.PronosticoDescTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CveAgenteTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductoTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CentroTxt = New System.Windows.Forms.TextBox()
        Me.BtnConsultaProducto = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SociedadTxt = New System.Windows.Forms.TextBox()
        Me.CentroBtn = New System.Windows.Forms.Button()
        Me.SociedadBtn = New System.Windows.Forms.Button()
        Me.DescProductoTxt = New System.Windows.Forms.TextBox()
        Me.ClienteTxt = New System.Windows.Forms.TextBox()
        Me.ClienteBtn = New System.Windows.Forms.Button()
        Me.DescCentroTxt = New System.Windows.Forms.TextBox()
        Me.CentrosErrProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALMACENPRONOSTICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CentrosErrProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALMACENPRONOSTICOBindingSource
        '
        Me.ALMACENPRONOSTICOBindingSource.DataMember = "ALMACENPRONOSTICO"
        Me.ALMACENPRONOSTICOBindingSource.DataSource = Me.SapForecastDataSet
        '
        'ALMACENPRONOSTICOTableAdapter
        '
        Me.ALMACENPRONOSTICOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTECLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTESTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_DIASFESTIVOSALLTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USP_CONSULTA_USUARIOTableAdapter = Nothing
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cliente"
        '
        'DescAgenteTxt
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.DescAgenteTxt, 2)
        Me.DescAgenteTxt.Location = New System.Drawing.Point(193, 35)
        Me.DescAgenteTxt.Name = "DescAgenteTxt"
        Me.DescAgenteTxt.Size = New System.Drawing.Size(404, 20)
        Me.DescAgenteTxt.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Escenario:"
        '
        'IdPronosticoTxt
        '
        Me.IdPronosticoTxt.Location = New System.Drawing.Point(69, 61)
        Me.IdPronosticoTxt.Name = "IdPronosticoTxt"
        Me.IdPronosticoTxt.Size = New System.Drawing.Size(100, 20)
        Me.IdPronosticoTxt.TabIndex = 2
        '
        'PronosticoDescTxt
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.PronosticoDescTxt, 2)
        Me.PronosticoDescTxt.Location = New System.Drawing.Point(193, 61)
        Me.PronosticoDescTxt.Name = "PronosticoDescTxt"
        Me.PronosticoDescTxt.Size = New System.Drawing.Size(404, 20)
        Me.PronosticoDescTxt.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Agente:"
        '
        'CveAgenteTxt
        '
        Me.CveAgenteTxt.Location = New System.Drawing.Point(69, 35)
        Me.CveAgenteTxt.Name = "CveAgenteTxt"
        Me.CveAgenteTxt.Size = New System.Drawing.Size(100, 20)
        Me.CveAgenteTxt.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Producto:"
        '
        'ProductoTxt
        '
        Me.ProductoTxt.Location = New System.Drawing.Point(69, 87)
        Me.ProductoTxt.Name = "ProductoTxt"
        Me.ProductoTxt.Size = New System.Drawing.Size(100, 20)
        Me.ProductoTxt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Centro"
        '
        'CentroTxt
        '
        Me.CentroTxt.Location = New System.Drawing.Point(69, 116)
        Me.CentroTxt.Name = "CentroTxt"
        Me.CentroTxt.Size = New System.Drawing.Size(100, 20)
        Me.CentroTxt.TabIndex = 7
        '
        'BtnConsultaProducto
        '
        Me.BtnConsultaProducto.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.BtnConsultaProducto.Location = New System.Drawing.Point(193, 87)
        Me.BtnConsultaProducto.Name = "BtnConsultaProducto"
        Me.BtnConsultaProducto.Size = New System.Drawing.Size(45, 23)
        Me.BtnConsultaProducto.TabIndex = 5
        Me.BtnConsultaProducto.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Sociedad:"
        '
        'SociedadTxt
        '
        Me.SociedadTxt.Location = New System.Drawing.Point(69, 145)
        Me.SociedadTxt.Name = "SociedadTxt"
        Me.SociedadTxt.Size = New System.Drawing.Size(100, 20)
        Me.SociedadTxt.TabIndex = 15
        '
        'CentroBtn
        '
        Me.CentroBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.CentroBtn.Location = New System.Drawing.Point(193, 116)
        Me.CentroBtn.Name = "CentroBtn"
        Me.CentroBtn.Size = New System.Drawing.Size(45, 23)
        Me.CentroBtn.TabIndex = 8
        Me.CentroBtn.UseVisualStyleBackColor = True
        '
        'SociedadBtn
        '
        Me.SociedadBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.SociedadBtn.Location = New System.Drawing.Point(193, 145)
        Me.SociedadBtn.Name = "SociedadBtn"
        Me.SociedadBtn.Size = New System.Drawing.Size(45, 23)
        Me.SociedadBtn.TabIndex = 16
        Me.SociedadBtn.UseVisualStyleBackColor = True
        '
        'DescProductoTxt
        '
        Me.DescProductoTxt.Enabled = False
        Me.DescProductoTxt.Location = New System.Drawing.Point(250, 87)
        Me.DescProductoTxt.Name = "DescProductoTxt"
        Me.DescProductoTxt.Size = New System.Drawing.Size(347, 20)
        Me.DescProductoTxt.TabIndex = 20
        '
        'ClienteTxt
        '
        Me.ClienteTxt.Location = New System.Drawing.Point(69, 174)
        Me.ClienteTxt.Name = "ClienteTxt"
        Me.ClienteTxt.Size = New System.Drawing.Size(100, 20)
        Me.ClienteTxt.TabIndex = 18
        '
        'ClienteBtn
        '
        Me.ClienteBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.ClienteBtn.Location = New System.Drawing.Point(193, 174)
        Me.ClienteBtn.Name = "ClienteBtn"
        Me.ClienteBtn.Size = New System.Drawing.Size(45, 23)
        Me.ClienteBtn.TabIndex = 19
        Me.ClienteBtn.UseVisualStyleBackColor = True
        '
        'DescCentroTxt
        '
        Me.DescCentroTxt.Enabled = False
        Me.DescCentroTxt.Location = New System.Drawing.Point(250, 116)
        Me.DescCentroTxt.Name = "DescCentroTxt"
        Me.DescCentroTxt.Size = New System.Drawing.Size(347, 20)
        Me.DescCentroTxt.TabIndex = 21
        '
        'CentrosErrProv
        '
        Me.CentrosErrProv.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(791, 25)
        Me.ToolStrip1.TabIndex = 10
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.78261!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.21739!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 543.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DescCentroTxt, 3, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.CentroBtn, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnConsultaProducto, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.PronosticoDescTxt, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.DescProductoTxt, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SociedadTxt, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ClienteTxt, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.DescAgenteTxt, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CveAgenteTxt, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.IdPronosticoTxt, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ProductoTxt, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CentroTxt, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ClienteBtn, 2, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.SociedadBtn, 2, 5)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(791, 394)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label1, 4)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(785, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Agregar Producto a pronóstico"
        '
        'HelpProvider
        '
        Me.HelpProvider.Tag = "1000"
        '
        'FrmAddProductoPronostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 419)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmAddProductoPronostico"
        Me.Text = "Agregar Producto"
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALMACENPRONOSTICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CentrosErrProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents ALMACENPRONOSTICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALMACENPRONOSTICOTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.ALMACENPRONOSTICOTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdPronosticoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProductoTxt As System.Windows.Forms.TextBox
    Friend WithEvents BtnConsultaProducto As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CentroTxt As System.Windows.Forms.TextBox
    Friend WithEvents CentroBtn As System.Windows.Forms.Button
    Friend WithEvents CentrosErrProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AbrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PronosticoDescTxt As System.Windows.Forms.TextBox
    Friend WithEvents DescAgenteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CveAgenteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ClienteTxt As System.Windows.Forms.TextBox
    Friend WithEvents ClienteBtn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SociedadTxt As System.Windows.Forms.TextBox
    Friend WithEvents SociedadBtn As System.Windows.Forms.Button
    Friend WithEvents DescProductoTxt As System.Windows.Forms.TextBox
    Friend WithEvents DescCentroTxt As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider As System.Windows.Forms.HelpProvider
End Class
