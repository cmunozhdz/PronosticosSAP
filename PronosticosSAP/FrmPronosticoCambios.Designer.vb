<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPronosticoCambios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.CONSULTA_HISTORICOCAMBIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTA_HISTORICOCAMBIOSTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_HISTORICOCAMBIOSTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.RegresarBtn = New System.Windows.Forms.ToolStripButton()
        Me.ActualizarBtn = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMCANTIDADALTERNA_OLD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_HISTORICOCAMBIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CONSULTA_HISTORICOCAMBIOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTA_HISTORICOCAMBIOSBindingSource
        '
        Me.CONSULTA_HISTORICOCAMBIOSBindingSource.DataMember = "CONSULTA_HISTORICOCAMBIOS"
        Me.CONSULTA_HISTORICOCAMBIOSBindingSource.DataSource = Me.SapForecastDataSet
        '
        'CONSULTA_HISTORICOCAMBIOSTableAdapter
        '
        Me.CONSULTA_HISTORICOCAMBIOSTableAdapter.ClearBeforeFill = True
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
        'CONSULTA_HISTORICOCAMBIOSBindingNavigator
        '
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.AddNewItem = Nothing
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.BindingSource = Me.CONSULTA_HISTORICOCAMBIOSBindingSource
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.CountItem = Nothing
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.DeleteItem = Nothing
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarBtn, Me.ActualizarBtn})
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.MoveFirstItem = Nothing
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.MoveLastItem = Nothing
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.MoveNextItem = Nothing
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.MovePreviousItem = Nothing
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.Name = "CONSULTA_HISTORICOCAMBIOSBindingNavigator"
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.PositionItem = Nothing
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.Size = New System.Drawing.Size(681, 25)
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.TabIndex = 0
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.Text = "BindingNavigator1"
        '
        'RegresarBtn
        '
        Me.RegresarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegresarBtn.Image = Global.PronosticosSAP.My.Resources.Resources.arrow_left_24
        Me.RegresarBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RegresarBtn.Name = "RegresarBtn"
        Me.RegresarBtn.Size = New System.Drawing.Size(23, 22)
        Me.RegresarBtn.Text = "ToolStripButton1"
        Me.RegresarBtn.ToolTipText = "Regresar"
        '
        'ActualizarBtn
        '
        Me.ActualizarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActualizarBtn.Image = Global.PronosticosSAP.My.Resources.Resources.table_refresh
        Me.ActualizarBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ActualizarBtn.Name = "ActualizarBtn"
        Me.ActualizarBtn.Size = New System.Drawing.Size(23, 22)
        Me.ActualizarBtn.Text = "Actualizar"
        Me.ActualizarBtn.ToolTipText = "Actualizar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CONSULTA_HISTORICOCAMBIOSDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(681, 269)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'CONSULTA_HISTORICOCAMBIOSDataGridView
        '
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.AllowUserToAddRows = False
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.AllowUserToDeleteRows = False
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.AllowUserToOrderColumns = True
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.AutoGenerateColumns = False
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.NUMCANTIDADALTERNA_OLD})
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.DataSource = Me.CONSULTA_HISTORICOCAMBIOSBindingSource
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.Location = New System.Drawing.Point(3, 21)
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.Name = "CONSULTA_HISTORICOCAMBIOSDataGridView"
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.ReadOnly = True
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.Size = New System.Drawing.Size(675, 245)
        Me.CONSULTA_HISTORICOCAMBIOSDataGridView.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Historial de Cambios Realizados"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_MOVIMIENTO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID. MOVIMIENTO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SMDTIMESTAMP"
        DataGridViewCellStyle1.Format = "dd-MMM-yyyy hh:mm:ss"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn11.HeaderText = "FECHA TRANSACCION"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.ToolTipText = "Fecha en que se realizo el cambio."
        Me.DataGridViewTextBoxColumn11.Width = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDPRONOSTICO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PRONOSTICO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "INTPERIODO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "INTPERIODO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DTFECHAINICIO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Periodo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CLAVECENTRO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CENTRO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CLAVEPRODUCTO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CLAVE PRODUCTO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CLAVECLIENTE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CLAVE CLIENTE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NUMCANTIDADBASE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CANT. BASE NUEVO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NUMCANTIDADBASE_OLD"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CANT. BASE ANTERIOR"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NUMCANTIDADALTERNA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CANT. ALTERNA "
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'NUMCANTIDADALTERNA_OLD
        '
        Me.NUMCANTIDADALTERNA_OLD.DataPropertyName = "NUMCANTIDADALTERNA_OLD"
        Me.NUMCANTIDADALTERNA_OLD.HeaderText = "CANT. ALTERNA ANTERIOR"
        Me.NUMCANTIDADALTERNA_OLD.Name = "NUMCANTIDADALTERNA_OLD"
        Me.NUMCANTIDADALTERNA_OLD.ReadOnly = True
        '
        'FrmPronosticoCambios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 294)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPronosticoCambios"
        Me.Text = "Cambios en el pronóstico"
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_HISTORICOCAMBIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.ResumeLayout(False)
        Me.CONSULTA_HISTORICOCAMBIOSBindingNavigator.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.CONSULTA_HISTORICOCAMBIOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_HISTORICOCAMBIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_HISTORICOCAMBIOSTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_HISTORICOCAMBIOSTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTA_HISTORICOCAMBIOSBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents RegresarBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ActualizarBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CONSULTA_HISTORICOCAMBIOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMCANTIDADALTERNA_OLD As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
