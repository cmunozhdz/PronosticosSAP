<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaMaestroPronostico
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
        Me.TbParametros = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NoPronosticoTxt = New System.Windows.Forms.TextBox()
        Me.NoVendedorTxt = New System.Windows.Forms.TextBox()
        Me.VendedorBuscarBtn = New System.Windows.Forms.Button()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbResultados = New System.Windows.Forms.TabPage()
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.COL_IDPRONOSTICO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLAVEAGENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMDINICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMDFIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOPERIODO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.HdrPronosticoToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_MAESTROPRONOSTICOSBYIDTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1.SuspendLayout()
        Me.TbParametros.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TbResultados.SuspendLayout()
        CType(Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_MAESTROPRONOSTICOSBYIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TbParametros)
        Me.TabControl1.Controls.Add(Me.TbResultados)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(619, 301)
        Me.TabControl1.TabIndex = 0
        '
        'TbParametros
        '
        Me.TbParametros.Controls.Add(Me.TableLayoutPanel1)
        Me.TbParametros.Location = New System.Drawing.Point(4, 22)
        Me.TbParametros.Name = "TbParametros"
        Me.TbParametros.Padding = New System.Windows.Forms.Padding(3)
        Me.TbParametros.Size = New System.Drawing.Size(611, 275)
        Me.TbParametros.TabIndex = 0
        Me.TbParametros.Text = "Parametros"
        Me.TbParametros.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.81967!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.18033!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 432.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NoPronosticoTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NoVendedorTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.VendedorBuscarBtn, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AceptarBtn, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CancelarBtn, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(605, 269)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Pronostico:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendedor:"
        '
        'NoPronosticoTxt
        '
        Me.NoPronosticoTxt.Location = New System.Drawing.Point(90, 26)
        Me.NoPronosticoTxt.Name = "NoPronosticoTxt"
        Me.NoPronosticoTxt.Size = New System.Drawing.Size(78, 20)
        Me.NoPronosticoTxt.TabIndex = 2
        Me.HdrPronosticoToolTip.SetToolTip(Me.NoPronosticoTxt, "Indique el numero de pronóstico")
        '
        'NoVendedorTxt
        '
        Me.NoVendedorTxt.Location = New System.Drawing.Point(90, 52)
        Me.NoVendedorTxt.Name = "NoVendedorTxt"
        Me.NoVendedorTxt.Size = New System.Drawing.Size(78, 20)
        Me.NoVendedorTxt.TabIndex = 3
        Me.HdrPronosticoToolTip.SetToolTip(Me.NoVendedorTxt, "Indique No. Vendedor")
        '
        'VendedorBuscarBtn
        '
        Me.VendedorBuscarBtn.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.VendedorBuscarBtn.Location = New System.Drawing.Point(175, 52)
        Me.VendedorBuscarBtn.Name = "VendedorBuscarBtn"
        Me.VendedorBuscarBtn.Size = New System.Drawing.Size(30, 23)
        Me.VendedorBuscarBtn.TabIndex = 4
        Me.HdrPronosticoToolTip.SetToolTip(Me.VendedorBuscarBtn, "Búscar vendedor en catálogo")
        Me.VendedorBuscarBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(3, 81)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(75, 23)
        Me.AceptarBtn.TabIndex = 5
        Me.AceptarBtn.Text = "&Aceptar"
        Me.HdrPronosticoToolTip.SetToolTip(Me.AceptarBtn, "Buscar en el catálogo")
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Location = New System.Drawing.Point(175, 81)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelarBtn.TabIndex = 6
        Me.CancelarBtn.Text = "Cancelar"
        Me.HdrPronosticoToolTip.SetToolTip(Me.CancelarBtn, "Salir")
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 3)
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Búsqueda de Pronósticos"
        '
        'TbResultados
        '
        Me.TbResultados.AutoScroll = True
        Me.TbResultados.Controls.Add(Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView)
        Me.TbResultados.Location = New System.Drawing.Point(4, 22)
        Me.TbResultados.Name = "TbResultados"
        Me.TbResultados.Padding = New System.Windows.Forms.Padding(3)
        Me.TbResultados.Size = New System.Drawing.Size(611, 275)
        Me.TbResultados.TabIndex = 1
        Me.TbResultados.Text = "Resultado"
        Me.TbResultados.UseVisualStyleBackColor = True
        '
        'CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView
        '
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.AllowUserToAddRows = False
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.AllowUserToDeleteRows = False
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.AutoGenerateColumns = False
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COL_IDPRONOSTICO, Me.CLAVEAGENTE, Me.DataGridViewTextBoxColumn7, Me.SMDINICIO, Me.SMDFIN, Me.TIPOPERIODO, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8})
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.DataSource = Me.CONSULTA_MAESTROPRONOSTICOSBYIDBindingSource
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.Name = "CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView"
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.ReadOnly = True
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.Size = New System.Drawing.Size(605, 269)
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView.TabIndex = 0
        Me.HdrPronosticoToolTip.SetToolTip(Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView, "De click en un elemento para seleccionar")
        '
        'COL_IDPRONOSTICO
        '
        Me.COL_IDPRONOSTICO.DataPropertyName = "IDPRONOSTICO"
        Me.COL_IDPRONOSTICO.HeaderText = "IDPRONOSTICO"
        Me.COL_IDPRONOSTICO.Name = "COL_IDPRONOSTICO"
        Me.COL_IDPRONOSTICO.ReadOnly = True
        '
        'CLAVEAGENTE
        '
        Me.CLAVEAGENTE.DataPropertyName = "CLAVEAGENTE"
        Me.CLAVEAGENTE.HeaderText = "CLAVEAGENTE"
        Me.CLAVEAGENTE.Name = "CLAVEAGENTE"
        Me.CLAVEAGENTE.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'SMDINICIO
        '
        Me.SMDINICIO.DataPropertyName = "SMDINICIO"
        Me.SMDINICIO.HeaderText = "SMDINICIO"
        Me.SMDINICIO.Name = "SMDINICIO"
        Me.SMDINICIO.ReadOnly = True
        '
        'SMDFIN
        '
        Me.SMDFIN.DataPropertyName = "SMDFIN"
        Me.SMDFIN.HeaderText = "SMDFIN"
        Me.SMDFIN.Name = "SMDFIN"
        Me.SMDFIN.ReadOnly = True
        '
        'TIPOPERIODO
        '
        Me.TIPOPERIODO.DataPropertyName = "TIPOPERIODO"
        Me.TIPOPERIODO.HeaderText = "TIPOPERIODO"
        Me.TIPOPERIODO.Name = "TIPOPERIODO"
        Me.TIPOPERIODO.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NUMPERIODOS"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NUMPERIODOS"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NEGOCIO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NEGOCIO"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'CONSULTA_MAESTROPRONOSTICOSBYIDBindingSource
        '
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDBindingSource.DataMember = "CONSULTA_MAESTROPRONOSTICOSBYID"
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDBindingSource.DataSource = Me.SapForecastDataSet
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTA_MAESTROPRONOSTICOSBYIDTableAdapter
        '
        Me.CONSULTA_MAESTROPRONOSTICOSBYIDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTECLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTESTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USP_CONSULTA_USUARIOTableAdapter = Nothing
        '
        'FrmConsultaMaestroPronostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 301)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmConsultaMaestroPronostico"
        Me.Text = "Búsqueda Pronósticos"
        Me.TabControl1.ResumeLayout(False)
        Me.TbParametros.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TbResultados.ResumeLayout(False)
        CType(Me.CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_MAESTROPRONOSTICOSBYIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TbParametros As System.Windows.Forms.TabPage
    Friend WithEvents TbResultados As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NoPronosticoTxt As System.Windows.Forms.TextBox
    Friend WithEvents NoVendedorTxt As System.Windows.Forms.TextBox
    Friend WithEvents VendedorBuscarBtn As System.Windows.Forms.Button
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_MAESTROPRONOSTICOSBYIDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_MAESTROPRONOSTICOSBYIDTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_MAESTROPRONOSTICOSBYIDTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTA_MAESTROPRONOSTICOSBYIDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents HdrPronosticoToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents COL_IDPRONOSTICO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLAVEAGENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SMDINICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SMDFIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPOPERIODO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
