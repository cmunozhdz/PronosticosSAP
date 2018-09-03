<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormZonasConsulta
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
        Me.ZonasTabConsulta = New System.Windows.Forms.TabControl()
        Me.TabParametros = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.EstadoTxt = New System.Windows.Forms.TextBox()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.ClaveTxt = New System.Windows.Forms.TextBox()
        Me.CanelarBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabResultados = New System.Windows.Forms.TabPage()
        Me.CONSULTA_ZONASBYCLAVEDataGridView = New System.Windows.Forms.DataGridView()
        Me.ColClaveGridview = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTAZONASBYCLAVEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.CONSULTA_ZONASBYCLAVETableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ZONASBYCLAVETableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.ZonasTabConsulta.SuspendLayout()
        Me.TabParametros.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabResultados.SuspendLayout()
        CType(Me.CONSULTA_ZONASBYCLAVEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTAZONASBYCLAVEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ZonasTabConsulta
        '
        Me.ZonasTabConsulta.Controls.Add(Me.TabParametros)
        Me.ZonasTabConsulta.Controls.Add(Me.TabResultados)
        Me.ZonasTabConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZonasTabConsulta.Location = New System.Drawing.Point(0, 0)
        Me.ZonasTabConsulta.Name = "ZonasTabConsulta"
        Me.ZonasTabConsulta.SelectedIndex = 0
        Me.ZonasTabConsulta.Size = New System.Drawing.Size(471, 281)
        Me.ZonasTabConsulta.TabIndex = 0
        '
        'TabParametros
        '
        Me.TabParametros.Controls.Add(Me.TableLayoutPanel1)
        Me.TabParametros.Controls.Add(Me.Label1)
        Me.TabParametros.Location = New System.Drawing.Point(4, 22)
        Me.TabParametros.Name = "TabParametros"
        Me.TabParametros.Padding = New System.Windows.Forms.Padding(3)
        Me.TabParametros.Size = New System.Drawing.Size(463, 255)
        Me.TabParametros.TabIndex = 0
        Me.TabParametros.Text = "Parametros"
        Me.TabParametros.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.42787!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.57213!))
        Me.TableLayoutPanel1.Controls.Add(Me.EstadoTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AceptarBtn, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ClaveTxt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CanelarBtn, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 53)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(442, 194)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'EstadoTxt
        '
        Me.EstadoTxt.Location = New System.Drawing.Point(115, 65)
        Me.EstadoTxt.Name = "EstadoTxt"
        Me.EstadoTxt.Size = New System.Drawing.Size(87, 20)
        Me.EstadoTxt.TabIndex = 7
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.Location = New System.Drawing.Point(115, 34)
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(324, 20)
        Me.DescripcionTxt.TabIndex = 6
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
        Me.Label3.Location = New System.Drawing.Point(3, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Estado:"
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.AceptarBtn.Location = New System.Drawing.Point(3, 166)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(80, 25)
        Me.AceptarBtn.TabIndex = 3
        Me.AceptarBtn.Text = "&Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'ClaveTxt
        '
        Me.ClaveTxt.Location = New System.Drawing.Point(115, 3)
        Me.ClaveTxt.Name = "ClaveTxt"
        Me.ClaveTxt.Size = New System.Drawing.Size(87, 20)
        Me.ClaveTxt.TabIndex = 5
        '
        'CanelarBtn
        '
        Me.CanelarBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.CanelarBtn.Location = New System.Drawing.Point(361, 166)
        Me.CanelarBtn.Name = "CanelarBtn"
        Me.CanelarBtn.Size = New System.Drawing.Size(78, 25)
        Me.CanelarBtn.TabIndex = 4
        Me.CanelarBtn.Text = "&Cancelar"
        Me.CanelarBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Indique los parámetros de búsqueda"
        '
        'TabResultados
        '
        Me.TabResultados.AutoScroll = True
        Me.TabResultados.Controls.Add(Me.CONSULTA_ZONASBYCLAVEDataGridView)
        Me.TabResultados.Location = New System.Drawing.Point(4, 22)
        Me.TabResultados.Name = "TabResultados"
        Me.TabResultados.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResultados.Size = New System.Drawing.Size(463, 255)
        Me.TabResultados.TabIndex = 1
        Me.TabResultados.Text = "Resultados"
        Me.TabResultados.UseVisualStyleBackColor = True
        '
        'CONSULTA_ZONASBYCLAVEDataGridView
        '
        Me.CONSULTA_ZONASBYCLAVEDataGridView.AllowUserToAddRows = False
        Me.CONSULTA_ZONASBYCLAVEDataGridView.AllowUserToDeleteRows = False
        Me.CONSULTA_ZONASBYCLAVEDataGridView.AutoGenerateColumns = False
        Me.CONSULTA_ZONASBYCLAVEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_ZONASBYCLAVEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColClaveGridview, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CONSULTA_ZONASBYCLAVEDataGridView.DataSource = Me.CONSULTAZONASBYCLAVEBindingSource
        Me.CONSULTA_ZONASBYCLAVEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_ZONASBYCLAVEDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CONSULTA_ZONASBYCLAVEDataGridView.Name = "CONSULTA_ZONASBYCLAVEDataGridView"
        Me.CONSULTA_ZONASBYCLAVEDataGridView.ReadOnly = True
        Me.CONSULTA_ZONASBYCLAVEDataGridView.Size = New System.Drawing.Size(457, 249)
        Me.CONSULTA_ZONASBYCLAVEDataGridView.TabIndex = 0
        '
        'ColClaveGridview
        '
        Me.ColClaveGridview.DataPropertyName = "CLAVE"
        Me.ColClaveGridview.HeaderText = "CLAVE"
        Me.ColClaveGridview.Name = "ColClaveGridview"
        Me.ColClaveGridview.ReadOnly = True
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ESTATUS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ESTATUS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'CONSULTAZONASBYCLAVEBindingSource
        '
        Me.CONSULTAZONASBYCLAVEBindingSource.DataMember = "CONSULTA_ZONASBYCLAVE"
        Me.CONSULTAZONASBYCLAVEBindingSource.DataSource = Me.SapForecastDataSet
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTA_ZONASBYCLAVETableAdapter
        '
        Me.CONSULTA_ZONASBYCLAVETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTA_AGENTESTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Me.CONSULTA_ZONASBYCLAVETableAdapter
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FormZonasConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 281)
        Me.Controls.Add(Me.ZonasTabConsulta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormZonasConsulta"
        Me.Text = "Buscar"
        Me.ZonasTabConsulta.ResumeLayout(False)
        Me.TabParametros.ResumeLayout(False)
        Me.TabParametros.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabResultados.ResumeLayout(False)
        CType(Me.CONSULTA_ZONASBYCLAVEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTAZONASBYCLAVEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ZonasTabConsulta As System.Windows.Forms.TabControl
    Friend WithEvents TabParametros As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabResultados As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EstadoTxt As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents CanelarBtn As System.Windows.Forms.Button
    Friend WithEvents ClaveTxt As System.Windows.Forms.TextBox
    Friend WithEvents CONSULTAZONASBYCLAVEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_ZONASBYCLAVETableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ZONASBYCLAVETableAdapter
    Friend WithEvents CONSULTA_ZONASBYCLAVEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ColClaveGridview As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
