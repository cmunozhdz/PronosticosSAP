<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgentesConsulta
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
        Me.TabParametros = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.EstadoTxt = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabResultados = New System.Windows.Forms.TabPage()
        Me.CONSULTA_AGENTESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTA_AGENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.CONSULTA_AGENTESTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_AGENTESTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1.SuspendLayout()
        Me.TabParametros.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabResultados.SuspendLayout()
        CType(Me.CONSULTA_AGENTESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_AGENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabParametros)
        Me.TabControl1.Controls.Add(Me.TabResultados)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(660, 297)
        Me.TabControl1.TabIndex = 0
        '
        'TabParametros
        '
        Me.TabParametros.Controls.Add(Me.Label1)
        Me.TabParametros.Controls.Add(Me.TableLayoutPanel1)
        Me.TabParametros.Location = New System.Drawing.Point(4, 22)
        Me.TabParametros.Name = "TabParametros"
        Me.TabParametros.Padding = New System.Windows.Forms.Padding(3)
        Me.TabParametros.Size = New System.Drawing.Size(652, 271)
        Me.TabParametros.TabIndex = 0
        Me.TabParametros.Text = "Parametros"
        Me.TabParametros.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Parámetros de Búsqueda (Agentes):"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.21569!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.78431!))
        Me.TableLayoutPanel1.Controls.Add(Me.EstadoTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCancelar, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtNombre, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtClave, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAceptar, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 32)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(612, 164)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'EstadoTxt
        '
        Me.EstadoTxt.Location = New System.Drawing.Point(90, 55)
        Me.EstadoTxt.Name = "EstadoTxt"
        Me.EstadoTxt.Size = New System.Drawing.Size(94, 20)
        Me.EstadoTxt.TabIndex = 7
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(90, 81)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 29)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(90, 29)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(508, 20)
        Me.TxtNombre.TabIndex = 3
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
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre(s):"
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(90, 3)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(100, 20)
        Me.TxtClave.TabIndex = 2
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(3, 81)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 29)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Estado:"
        '
        'TabResultados
        '
        Me.TabResultados.AutoScroll = True
        Me.TabResultados.Controls.Add(Me.CONSULTA_AGENTESDataGridView)
        Me.TabResultados.Location = New System.Drawing.Point(4, 22)
        Me.TabResultados.Name = "TabResultados"
        Me.TabResultados.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResultados.Size = New System.Drawing.Size(652, 271)
        Me.TabResultados.TabIndex = 1
        Me.TabResultados.Text = "Resultados"
        Me.TabResultados.UseVisualStyleBackColor = True
        '
        'CONSULTA_AGENTESDataGridView
        '
        Me.CONSULTA_AGENTESDataGridView.AllowUserToAddRows = False
        Me.CONSULTA_AGENTESDataGridView.AllowUserToDeleteRows = False
        Me.CONSULTA_AGENTESDataGridView.AutoGenerateColumns = False
        Me.CONSULTA_AGENTESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_AGENTESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CONSULTA_AGENTESDataGridView.DataSource = Me.CONSULTA_AGENTESBindingSource
        Me.CONSULTA_AGENTESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_AGENTESDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CONSULTA_AGENTESDataGridView.Name = "CONSULTA_AGENTESDataGridView"
        Me.CONSULTA_AGENTESDataGridView.ReadOnly = True
        Me.CONSULTA_AGENTESDataGridView.Size = New System.Drawing.Size(646, 265)
        Me.CONSULTA_AGENTESDataGridView.TabIndex = 0
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CLAVEAGENTE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CLAVE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'CONSULTA_AGENTESBindingSource
        '
        Me.CONSULTA_AGENTESBindingSource.DataMember = "CONSULTA_AGENTES"
        Me.CONSULTA_AGENTESBindingSource.DataSource = Me.SapForecastDataSet
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTA_AGENTESTableAdapter
        '
        Me.CONSULTA_AGENTESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTA_AGENTECLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTESTableAdapter = Me.CONSULTA_AGENTESTableAdapter
        Me.TableAdapterManager.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USP_CONSULTA_USUARIOTableAdapter = Nothing
        '
        'FrmAgentesConsulta
        '
        Me.AcceptButton = Me.BtnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(660, 297)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmAgentesConsulta"
        Me.Text = "Búsqueda de agentes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabParametros.ResumeLayout(False)
        Me.TabParametros.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabResultados.ResumeLayout(False)
        CType(Me.CONSULTA_AGENTESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_AGENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabParametros As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TabResultados As System.Windows.Forms.TabPage
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_AGENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_AGENTESTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_AGENTESTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTA_AGENTESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
