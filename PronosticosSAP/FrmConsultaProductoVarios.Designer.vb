<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaProductoVarios
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ClaveTxt = New System.Windows.Forms.TextBox()
        Me.DescCortaTxt = New System.Windows.Forms.TextBox()
        Me.TipoTxt = New System.Windows.Forms.TextBox()
        Me.NegocioCbo = New System.Windows.Forms.ComboBox()
        Me.EstadoCbo = New System.Windows.Forms.ComboBox()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.CONSULTA_PRODUCTODataGridView = New System.Windows.Forms.DataGridView()
        Me.Selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CLAVE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NEGOCIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDADMEDIDABASE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.AceptarBtnTp = New System.Windows.Forms.ToolStripButton()
        Me.CancelBtnTp = New System.Windows.Forms.ToolStripButton()
        Me.TpCatalogos = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.CONSULTA_PRODUCTODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(632, 311)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(624, 285)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Parametros"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Indique los criterios de búsqueda"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ClaveTxt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DescCortaTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TipoTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NegocioCbo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.EstadoCbo, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.AceptarBtn, 0, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 58)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(566, 203)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Clave:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripción Corta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Negocio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Estado"
        '
        'ClaveTxt
        '
        Me.ClaveTxt.Location = New System.Drawing.Point(103, 3)
        Me.ClaveTxt.Name = "ClaveTxt"
        Me.ClaveTxt.Size = New System.Drawing.Size(100, 20)
        Me.ClaveTxt.TabIndex = 8
        '
        'DescCortaTxt
        '
        Me.DescCortaTxt.Location = New System.Drawing.Point(103, 29)
        Me.DescCortaTxt.Name = "DescCortaTxt"
        Me.DescCortaTxt.Size = New System.Drawing.Size(277, 20)
        Me.DescCortaTxt.TabIndex = 9
        '
        'TipoTxt
        '
        Me.TipoTxt.AutoCompleteCustomSource.AddRange(New String() {"HAWA", "FERT", "ROH"})
        Me.TipoTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TipoTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TipoTxt.Location = New System.Drawing.Point(103, 55)
        Me.TipoTxt.Name = "TipoTxt"
        Me.TipoTxt.Size = New System.Drawing.Size(100, 20)
        Me.TipoTxt.TabIndex = 10
        Me.TpCatalogos.SetToolTip(Me.TipoTxt, "Indicar el tipo de productos, dejar vacio para aplicar todos.")
        '
        'NegocioCbo
        '
        Me.NegocioCbo.FormattingEnabled = True
        Me.NegocioCbo.Items.AddRange(New Object() {"(Todos)", "A:Agricola", "I:Industrial", "E:Exportación"})
        Me.NegocioCbo.Location = New System.Drawing.Point(103, 81)
        Me.NegocioCbo.Name = "NegocioCbo"
        Me.NegocioCbo.Size = New System.Drawing.Size(121, 21)
        Me.NegocioCbo.TabIndex = 11
        '
        'EstadoCbo
        '
        Me.EstadoCbo.FormattingEnabled = True
        Me.EstadoCbo.Location = New System.Drawing.Point(103, 108)
        Me.EstadoCbo.Name = "EstadoCbo"
        Me.EstadoCbo.Size = New System.Drawing.Size(121, 21)
        Me.EstadoCbo.TabIndex = 12
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(3, 135)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(75, 23)
        Me.AceptarBtn.TabIndex = 13
        Me.AceptarBtn.Text = "&Consultar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(624, 285)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resultados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ToolStripContainer1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(618, 279)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ToolStripContainer1
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.ToolStripContainer1, 2)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.CONSULTA_PRODUCTODataGridView)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(612, 248)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(612, 273)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'CONSULTA_PRODUCTODataGridView
        '
        Me.CONSULTA_PRODUCTODataGridView.AllowUserToAddRows = False
        Me.CONSULTA_PRODUCTODataGridView.AllowUserToDeleteRows = False
        Me.CONSULTA_PRODUCTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_PRODUCTODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selected, Me.CLAVE, Me.DESCRIPCION, Me.TIPO, Me.NEGOCIO, Me.UNIDADMEDIDABASE})
        Me.CONSULTA_PRODUCTODataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_PRODUCTODataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CONSULTA_PRODUCTODataGridView.Name = "CONSULTA_PRODUCTODataGridView"
        Me.CONSULTA_PRODUCTODataGridView.Size = New System.Drawing.Size(612, 248)
        Me.CONSULTA_PRODUCTODataGridView.TabIndex = 4
        '
        'Selected
        '
        Me.Selected.DataPropertyName = "Selected"
        Me.Selected.Frozen = True
        Me.Selected.HeaderText = ""
        Me.Selected.Name = "Selected"
        '
        'CLAVE
        '
        Me.CLAVE.DataPropertyName = "CLAVE"
        Me.CLAVE.Frozen = True
        Me.CLAVE.HeaderText = "CLAVE"
        Me.CLAVE.Name = "CLAVE"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DESCRIPCION.Width = 130
        '
        'TIPO
        '
        Me.TIPO.DataPropertyName = "TIPO"
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        '
        'NEGOCIO
        '
        Me.NEGOCIO.DataPropertyName = "NEGOCIO"
        Me.NEGOCIO.HeaderText = "NEGOCIO"
        Me.NEGOCIO.Name = "NEGOCIO"
        Me.NEGOCIO.ReadOnly = True
        '
        'UNIDADMEDIDABASE
        '
        Me.UNIDADMEDIDABASE.DataPropertyName = "UNIDADMEDIDABASE"
        Me.UNIDADMEDIDABASE.HeaderText = "UNIDAD DE MEDIDA"
        Me.UNIDADMEDIDABASE.Name = "UNIDADMEDIDABASE"
        Me.UNIDADMEDIDABASE.ReadOnly = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarBtnTp, Me.CancelBtnTp})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(56, 25)
        Me.ToolStrip2.TabIndex = 4
        '
        'AceptarBtnTp
        '
        Me.AceptarBtnTp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AceptarBtnTp.Image = Global.PronosticosSAP.My.Resources.Resources.accept
        Me.AceptarBtnTp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AceptarBtnTp.Name = "AceptarBtnTp"
        Me.AceptarBtnTp.Size = New System.Drawing.Size(23, 22)
        Me.AceptarBtnTp.Text = "ToolStripButton1"
        Me.AceptarBtnTp.ToolTipText = "Aceptar Seleccion"
        '
        'CancelBtnTp
        '
        Me.CancelBtnTp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelBtnTp.Image = Global.PronosticosSAP.My.Resources.Resources.cancel
        Me.CancelBtnTp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelBtnTp.Name = "CancelBtnTp"
        Me.CancelBtnTp.Size = New System.Drawing.Size(23, 22)
        Me.CancelBtnTp.Text = "ToolStripButton2"
        Me.CancelBtnTp.ToolTipText = "Cancelar y regresar al anterior"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "&Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmConsultaProductoVarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 311)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmConsultaProductoVarios"
        Me.Text = "Bucar productos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.CONSULTA_PRODUCTODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ClaveTxt As System.Windows.Forms.TextBox
    Friend WithEvents DescCortaTxt As System.Windows.Forms.TextBox
    Friend WithEvents TipoTxt As System.Windows.Forms.TextBox
    Friend WithEvents NegocioCbo As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoCbo As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TpCatalogos As System.Windows.Forms.ToolTip
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents AceptarBtnTp As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelBtnTp As System.Windows.Forms.ToolStripButton
    Friend WithEvents CONSULTA_PRODUCTODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Selected As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CLAVE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NEGOCIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNIDADMEDIDABASE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
