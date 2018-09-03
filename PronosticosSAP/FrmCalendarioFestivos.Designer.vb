<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalendarioFestivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalendarioFestivos))
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.CONSULTA_DIASFESTIVOSALLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTA_DIASFESTIVOSALLTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_DIASFESTIVOSALLTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CONSULTA_DIASFESTIVOSALLDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAnio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_DIASFESTIVOSALLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_DIASFESTIVOSALLBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.SuspendLayout()
        CType(Me.CONSULTA_DIASFESTIVOSALLDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTA_DIASFESTIVOSALLBindingSource
        '
        Me.CONSULTA_DIASFESTIVOSALLBindingSource.DataMember = "CONSULTA_DIASFESTIVOSALL"
        Me.CONSULTA_DIASFESTIVOSALLBindingSource.DataSource = Me.SapForecastDataSet
        '
        'CONSULTA_DIASFESTIVOSALLTableAdapter
        '
        Me.CONSULTA_DIASFESTIVOSALLTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTA_AGENTECLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTESTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_DIASFESTIVOSALLTableAdapter = Me.CONSULTA_DIASFESTIVOSALLTableAdapter
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        Me.TableAdapterManager.USP_CONSULTA_USUARIOTableAdapter = Nothing
        '
        'CONSULTA_DIASFESTIVOSALLBindingNavigator
        '
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.BindingSource = Me.CONSULTA_DIASFESTIVOSALLBindingSource
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.DeleteItem = Nothing
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem})
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.Name = "CONSULTA_DIASFESTIVOSALLBindingNavigator"
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.Size = New System.Drawing.Size(423, 25)
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.TabIndex = 0
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.PronosticosSAP.My.Resources.Resources.paste_plain
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem
        '
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem.Image = CType(resources.GetObject("CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem.Name = "CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem"
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CONSULTA_DIASFESTIVOSALLDataGridView
        '
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.AllowUserToAddRows = False
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.AllowUserToDeleteRows = False
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.AutoGenerateColumns = False
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.ColDia, Me.ColMes, Me.ColAnio})
        Me.TableLayoutPanel1.SetColumnSpan(Me.CONSULTA_DIASFESTIVOSALLDataGridView, 2)
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.DataSource = Me.CONSULTA_DIASFESTIVOSALLBindingSource
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.Location = New System.Drawing.Point(3, 33)
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.Name = "CONSULTA_DIASFESTIVOSALLDataGridView"
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.Size = New System.Drawing.Size(417, 293)
        Me.CONSULTA_DIASFESTIVOSALLDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'ColDia
        '
        Me.ColDia.DataPropertyName = "DIA"
        Me.ColDia.HeaderText = "DIA"
        Me.ColDia.Name = "ColDia"
        '
        'ColMes
        '
        Me.ColMes.DataPropertyName = "MES"
        Me.ColMes.HeaderText = "MES"
        Me.ColMes.Name = "ColMes"
        '
        'ColAnio
        '
        Me.ColAnio.DataPropertyName = "ANIO"
        Me.ColAnio.HeaderText = "ANIO"
        Me.ColAnio.Name = "ColAnio"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 354)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(423, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TsStatusLabel
        '
        Me.TsStatusLabel.Name = "TsStatusLabel"
        Me.TsStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CONSULTA_DIASFESTIVOSALLDataGridView, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.422492!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.57751!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(423, 329)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calendario de Dias Festivos"
        '
        'FrmCalendarioFestivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 376)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CONSULTA_DIASFESTIVOSALLBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCalendarioFestivos"
        Me.Text = "Calendario Dias Festivos"
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_DIASFESTIVOSALLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_DIASFESTIVOSALLBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.ResumeLayout(False)
        Me.CONSULTA_DIASFESTIVOSALLBindingNavigator.PerformLayout()
        CType(Me.CONSULTA_DIASFESTIVOSALLDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_DIASFESTIVOSALLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_DIASFESTIVOSALLTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_DIASFESTIVOSALLTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTA_DIASFESTIVOSALLBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CONSULTA_DIASFESTIVOSALLBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CONSULTA_DIASFESTIVOSALLDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAnio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TsStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
