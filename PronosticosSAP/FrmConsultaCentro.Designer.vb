<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaCentro
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
        Me.SociedadTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CentroTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CentrosDG = New System.Windows.Forms.DataGridView()
        Me.GETCENTROBYVARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.GETCENTROBYVARIOSTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.GETCENTROBYVARIOSTableAdapter()
        Me.CLAVECENTROCELL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCIONCell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLAVESOCIEDADCell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.CentrosDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GETCENTROBYVARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Size = New System.Drawing.Size(770, 183)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(762, 157)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Parametros"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SociedadTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CentroTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(756, 151)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SociedadTxt
        '
        Me.SociedadTxt.Location = New System.Drawing.Point(381, 49)
        Me.SociedadTxt.Name = "SociedadTxt"
        Me.SociedadTxt.Size = New System.Drawing.Size(100, 20)
        Me.SociedadTxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sociedad:"
        '
        'CentroTxt
        '
        Me.CentroTxt.Location = New System.Drawing.Point(381, 23)
        Me.CentroTxt.Name = "CentroTxt"
        Me.CentroTxt.Size = New System.Drawing.Size(100, 20)
        Me.CentroTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Centro:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(381, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "&Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.Location = New System.Drawing.Point(381, 75)
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTxt.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label4, 2)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(302, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Indique los parametros de busqueda"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CentrosDG)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(762, 157)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resultados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CentrosDG
        '
        Me.CentrosDG.AllowUserToAddRows = False
        Me.CentrosDG.AllowUserToDeleteRows = False
        Me.CentrosDG.AutoGenerateColumns = False
        Me.CentrosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CentrosDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLAVECENTROCELL, Me.DESCRIPCIONCell, Me.CLAVESOCIEDADCell})
        Me.CentrosDG.DataSource = Me.GETCENTROBYVARIOSBindingSource
        Me.CentrosDG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CentrosDG.Location = New System.Drawing.Point(3, 3)
        Me.CentrosDG.Name = "CentrosDG"
        Me.CentrosDG.ReadOnly = True
        Me.CentrosDG.Size = New System.Drawing.Size(756, 151)
        Me.CentrosDG.TabIndex = 0
        '
        'GETCENTROBYVARIOSBindingSource
        '
        Me.GETCENTROBYVARIOSBindingSource.AllowNew = False
        Me.GETCENTROBYVARIOSBindingSource.DataMember = "GETCENTROBYVARIOS"
        Me.GETCENTROBYVARIOSBindingSource.DataSource = Me.SapForecastDataSet
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GETCENTROBYVARIOSTableAdapter
        '
        Me.GETCENTROBYVARIOSTableAdapter.ClearBeforeFill = True
        '
        'CLAVECENTROCELL
        '
        Me.CLAVECENTROCELL.DataPropertyName = "CLAVECENTRO"
        Me.CLAVECENTROCELL.HeaderText = "CLAVECENTRO"
        Me.CLAVECENTROCELL.Name = "CLAVECENTROCELL"
        Me.CLAVECENTROCELL.ReadOnly = True
        '
        'DESCRIPCIONCell
        '
        Me.DESCRIPCIONCell.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCIONCell.HeaderText = "DESCRIPCION"
        Me.DESCRIPCIONCell.Name = "DESCRIPCIONCell"
        Me.DESCRIPCIONCell.ReadOnly = True
        '
        'CLAVESOCIEDADCell
        '
        Me.CLAVESOCIEDADCell.DataPropertyName = "CLAVESOCIEDAD"
        Me.CLAVESOCIEDADCell.HeaderText = "CLAVESOCIEDAD"
        Me.CLAVESOCIEDADCell.Name = "CLAVESOCIEDADCell"
        Me.CLAVESOCIEDADCell.ReadOnly = True
        '
        'FrmConsultaCentro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 183)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmConsultaCentro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar  Centros"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.CentrosDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GETCENTROBYVARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DescripcionTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SociedadTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CentroTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CentrosDG As System.Windows.Forms.DataGridView
    Friend WithEvents GETCENTROBYVARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents GETCENTROBYVARIOSTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.GETCENTROBYVARIOSTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CLAVECENTROCELL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONCell As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLAVESOCIEDADCell As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
