<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtDescricpion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSociedad = New System.Windows.Forms.TextBox()
        Me.TabResultados = New System.Windows.Forms.TabPage()
        Me.CONSULTA_CLIENTESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTA_CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.CONSULTA_CLIENTESTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_CLIENTESTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabResultados.SuspendLayout()
        CType(Me.CONSULTA_CLIENTESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabResultados)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(655, 280)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(647, 254)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Parametros"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.91264!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.08736!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAceptar, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCliente, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCancelar, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtDescricpion, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtSociedad, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(641, 248)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(3, 81)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(105, 3)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(100, 20)
        Me.TxtCliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clave"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(105, 81)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TxtDescricpion
        '
        Me.TxtDescricpion.Location = New System.Drawing.Point(105, 55)
        Me.TxtDescricpion.Name = "TxtDescricpion"
        Me.TxtDescricpion.Size = New System.Drawing.Size(500, 20)
        Me.TxtDescricpion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sociedad"
        '
        'TxtSociedad
        '
        Me.TxtSociedad.Location = New System.Drawing.Point(105, 29)
        Me.TxtSociedad.Name = "TxtSociedad"
        Me.TxtSociedad.Size = New System.Drawing.Size(100, 20)
        Me.TxtSociedad.TabIndex = 6
        '
        'TabResultados
        '
        Me.TabResultados.AutoScroll = True
        Me.TabResultados.Controls.Add(Me.CONSULTA_CLIENTESDataGridView)
        Me.TabResultados.Location = New System.Drawing.Point(4, 22)
        Me.TabResultados.Name = "TabResultados"
        Me.TabResultados.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResultados.Size = New System.Drawing.Size(647, 254)
        Me.TabResultados.TabIndex = 1
        Me.TabResultados.Text = "Resultados"
        Me.TabResultados.UseVisualStyleBackColor = True
        '
        'CONSULTA_CLIENTESDataGridView
        '
        Me.CONSULTA_CLIENTESDataGridView.AllowUserToAddRows = False
        Me.CONSULTA_CLIENTESDataGridView.AllowUserToDeleteRows = False
        Me.CONSULTA_CLIENTESDataGridView.AutoGenerateColumns = False
        Me.CONSULTA_CLIENTESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_CLIENTESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CONSULTA_CLIENTESDataGridView.DataSource = Me.CONSULTA_CLIENTESBindingSource
        Me.CONSULTA_CLIENTESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_CLIENTESDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CONSULTA_CLIENTESDataGridView.Name = "CONSULTA_CLIENTESDataGridView"
        Me.CONSULTA_CLIENTESDataGridView.ReadOnly = True
        Me.CONSULTA_CLIENTESDataGridView.Size = New System.Drawing.Size(641, 248)
        Me.CONSULTA_CLIENTESDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SOCIEDAD"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SOCIEDAD"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CLAVECLIENTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CLAVECLIENTE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RAZONSOCIAL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RAZONSOCIAL"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'CONSULTA_CLIENTESBindingSource
        '
        Me.CONSULTA_CLIENTESBindingSource.DataMember = "CONSULTA_CLIENTES"
        Me.CONSULTA_CLIENTESBindingSource.DataSource = Me.SapForecastDataSet
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTA_CLIENTESTableAdapter
        '
        Me.CONSULTA_CLIENTESTableAdapter.ClearBeforeFill = True
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
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 280)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmClientes"
        Me.Text = "FrmClientes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabResultados.ResumeLayout(False)
        CType(Me.CONSULTA_CLIENTESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabResultados As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents TxtDescricpion As System.Windows.Forms.TextBox
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_CLIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_CLIENTESTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_CLIENTESTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtSociedad As System.Windows.Forms.TextBox
    Friend WithEvents CONSULTA_CLIENTESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
