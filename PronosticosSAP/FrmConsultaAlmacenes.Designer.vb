<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaAlmacenes
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
        Me.CentroTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClaveAlmacenTxt = New System.Windows.Forms.TextBox()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CONSULTA_ALMACENDataGridView = New System.Windows.Forms.DataGridView()
        Me.CLAVECENTRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLAVEALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLAVEAGENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTA_ALMACENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.CONSULTA_ALMACENTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ALMACENTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.CONSULTA_ALMACENDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTA_ALMACENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Size = New System.Drawing.Size(659, 285)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(651, 259)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Opciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.CentroTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ClaveAlmacenTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AceptarBtn, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CancelarBtn, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(645, 253)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'CentroTxt
        '
        Me.CentroTxt.Location = New System.Drawing.Point(84, 26)
        Me.CentroTxt.Name = "CentroTxt"
        Me.CentroTxt.Size = New System.Drawing.Size(100, 20)
        Me.CentroTxt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Centro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clave:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción:"
        '
        'ClaveAlmacenTxt
        '
        Me.ClaveAlmacenTxt.Location = New System.Drawing.Point(84, 52)
        Me.ClaveAlmacenTxt.Name = "ClaveAlmacenTxt"
        Me.ClaveAlmacenTxt.Size = New System.Drawing.Size(100, 20)
        Me.ClaveAlmacenTxt.TabIndex = 4
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.Location = New System.Drawing.Point(84, 78)
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(189, 20)
        Me.DescripcionTxt.TabIndex = 6
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Location = New System.Drawing.Point(3, 104)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(75, 23)
        Me.AceptarBtn.TabIndex = 7
        Me.AceptarBtn.Text = "&Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelarBtn.Location = New System.Drawing.Point(84, 104)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelarBtn.TabIndex = 8
        Me.CancelarBtn.Text = "&Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label4, 3)
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(323, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Indique los criterios de búsqueda"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.CONSULTA_ALMACENDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(651, 259)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resultados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CONSULTA_ALMACENDataGridView
        '
        Me.CONSULTA_ALMACENDataGridView.AutoGenerateColumns = False
        Me.CONSULTA_ALMACENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTA_ALMACENDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLAVECENTRO, Me.CLAVEALMACEN, Me.CLAVEAGENTE, Me.DESCRIPCION})
        Me.CONSULTA_ALMACENDataGridView.DataSource = Me.CONSULTA_ALMACENBindingSource
        Me.CONSULTA_ALMACENDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONSULTA_ALMACENDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CONSULTA_ALMACENDataGridView.Name = "CONSULTA_ALMACENDataGridView"
        Me.CONSULTA_ALMACENDataGridView.Size = New System.Drawing.Size(645, 253)
        Me.CONSULTA_ALMACENDataGridView.TabIndex = 0
        '
        'CLAVECENTRO
        '
        Me.CLAVECENTRO.DataPropertyName = "CLAVECENTRO"
        Me.CLAVECENTRO.HeaderText = "CLAVECENTRO"
        Me.CLAVECENTRO.Name = "CLAVECENTRO"
        '
        'CLAVEALMACEN
        '
        Me.CLAVEALMACEN.DataPropertyName = "CLAVEALMACEN"
        Me.CLAVEALMACEN.HeaderText = "CLAVEALMACEN"
        Me.CLAVEALMACEN.Name = "CLAVEALMACEN"
        '
        'CLAVEAGENTE
        '
        Me.CLAVEAGENTE.DataPropertyName = "CLAVEAGENTE"
        Me.CLAVEAGENTE.HeaderText = "CLAVEAGENTE"
        Me.CLAVEAGENTE.Name = "CLAVEAGENTE"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        '
        'CONSULTA_ALMACENBindingSource
        '
        Me.CONSULTA_ALMACENBindingSource.DataMember = "CONSULTA_ALMACEN"
        Me.CONSULTA_ALMACENBindingSource.DataSource = Me.SapForecastDataSet
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTA_ALMACENTableAdapter
        '
        Me.CONSULTA_ALMACENTableAdapter.ClearBeforeFill = True
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
        '
        'FrmConsultaAlmacenes
        '
        Me.AcceptButton = Me.AceptarBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelarBtn
        Me.ClientSize = New System.Drawing.Size(659, 285)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmConsultaAlmacenes"
        Me.Text = "Almacenes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.CONSULTA_ALMACENDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTA_ALMACENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClaveAlmacenTxt As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTxt As System.Windows.Forms.TextBox
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents CentroTxt As System.Windows.Forms.TextBox
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents CONSULTA_ALMACENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTA_ALMACENTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.CONSULTA_ALMACENTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTA_ALMACENDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CLAVECENTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLAVEALMACEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLAVEAGENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
