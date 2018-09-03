<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaProducto
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.ClaveTxt = New System.Windows.Forms.TextBox()
        Me.DescCortaTxt = New System.Windows.Forms.TextBox()
        Me.TipoTxt = New System.Windows.Forms.TextBox()
        Me.NegocioCbo = New System.Windows.Forms.ComboBox()
        Me.EstadoCbo = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CONSULTA_PRODUCTODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTA_PRODUCTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.CONSULTA_PRODUCTOTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.CONSULTA_PRODUCTODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAceptar, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCancelar, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ClaveTxt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DescCortaTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TipoTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NegocioCbo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.EstadoCbo, 1, 5)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Descripción Larga:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Negocio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Estado"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(3, 148)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 27)
        Me.BtnAceptar.TabIndex = 6
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(286, 148)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 27)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'ClaveTxt
        '
        Me.ClaveTxt.Location = New System.Drawing.Point(286, 3)
        Me.ClaveTxt.Name = "ClaveTxt"
        Me.ClaveTxt.Size = New System.Drawing.Size(100, 20)
        Me.ClaveTxt.TabIndex = 8
        '
        'DescCortaTxt
        '
        Me.DescCortaTxt.Location = New System.Drawing.Point(286, 29)
        Me.DescCortaTxt.Name = "DescCortaTxt"
        Me.DescCortaTxt.Size = New System.Drawing.Size(277, 20)
        Me.DescCortaTxt.TabIndex = 9
        '
        'TipoTxt
        '
        Me.TipoTxt.Location = New System.Drawing.Point(286, 68)
        Me.TipoTxt.Name = "TipoTxt"
        Me.TipoTxt.Size = New System.Drawing.Size(100, 20)
        Me.TipoTxt.TabIndex = 10
        '
        'NegocioCbo
        '
        Me.NegocioCbo.FormattingEnabled = True
        Me.NegocioCbo.Location = New System.Drawing.Point(286, 94)
        Me.NegocioCbo.Name = "NegocioCbo"
        Me.NegocioCbo.Size = New System.Drawing.Size(121, 21)
        Me.NegocioCbo.TabIndex = 11
        '
        'EstadoCbo
        '
        Me.EstadoCbo.FormattingEnabled = True
        Me.EstadoCbo.Location = New System.Drawing.Point(286, 121)
        Me.EstadoCbo.Name = "EstadoCbo"
        Me.EstadoCbo.Size = New System.Drawing.Size(121, 21)
        Me.EstadoCbo.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.CONSULTA_PRODUCTODataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(624, 285)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resultados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CONSULTA_PRODUCTODataGridView
        '
        Me.CONSULTA_PRODUCTODataGridView.AllowUserToAddRows = False
        Me.CONSULTA_PRODUCTODataGridView.AutoGenerateColumns = False
        Me.CONSULTA_PRODUCTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_PRODUCTODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CONSULTA_PRODUCTODataGridView.DataSource = Me.CONSULTA_PRODUCTOBindingSource
        Me.CONSULTA_PRODUCTODataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_PRODUCTODataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CONSULTA_PRODUCTODataGridView.Name = "CONSULTA_PRODUCTODataGridView"
        Me.CONSULTA_PRODUCTODataGridView.ReadOnly = True
        Me.CONSULTA_PRODUCTODataGridView.Size = New System.Drawing.Size(618, 279)
        Me.CONSULTA_PRODUCTODataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CLAVE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CLAVE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DESCRIPCION_DETALLADA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DESCRIPCION_DETALLADA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TIPO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TIPO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NEGOCIO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NEGOCIO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn7.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'CONSULTA_PRODUCTOBindingSource
        '
        Me.CONSULTA_PRODUCTOBindingSource.DataMember = "CONSULTA_PRODUCTO"
        Me.CONSULTA_PRODUCTOBindingSource.DataSource = Me.SapForecastDataSet
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Me.CONSULTA_PRODUCTOTableAdapter
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USP_CONSULTA_USUARIOTableAdapter = Nothing
        '
        'FrmConsultaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 311)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmConsultaProducto"
        Me.Text = "FrmConsultaProducto"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.CONSULTA_PRODUCTODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_PRODUCTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_PRODUCTOTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_PRODUCTOTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTA_PRODUCTODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents ClaveTxt As System.Windows.Forms.TextBox
    Friend WithEvents DescCortaTxt As System.Windows.Forms.TextBox
    Friend WithEvents TipoTxt As System.Windows.Forms.TextBox
    Friend WithEvents NegocioCbo As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoCbo As System.Windows.Forms.ComboBox
End Class
