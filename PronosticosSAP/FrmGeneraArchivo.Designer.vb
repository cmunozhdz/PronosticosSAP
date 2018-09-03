<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGeneraArchivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGeneraArchivo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPronostico = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.FechaIniDtPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.EnviarTsLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FechaFinDtPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AgenteLbl = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BGWKEnvios = New System.ComponentModel.BackgroundWorker()
        Me.EnvioErrProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.EnvioErrProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Pronostico:"
        '
        'txtPronostico
        '
        Me.txtPronostico.Location = New System.Drawing.Point(89, 57)
        Me.txtPronostico.Name = "txtPronostico"
        Me.txtPronostico.Size = New System.Drawing.Size(76, 20)
        Me.txtPronostico.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.txtPronostico, "Pronostico a enviar")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripButton, Me.toolStripSeparator, Me.BtnSalir, Me.toolStripSeparator1, Me.TsProgressBar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(732, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton.Text = "&Guardar"
        Me.GuardarToolStripButton.ToolTipText = "Enviar a sistema central"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.PronosticosSAP.My.Resources.Resources.door_out
        Me.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(47, 22)
        Me.BtnSalir.Text = "Salir"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TsProgressBar
        '
        Me.TsProgressBar.Name = "TsProgressBar"
        Me.TsProgressBar.Size = New System.Drawing.Size(100, 22)
        Me.TsProgressBar.ToolTipText = "Proceso de aplicación"
        Me.TsProgressBar.Visible = False
        '
        'FechaIniDtPicker
        '
        Me.FechaIniDtPicker.Enabled = False
        Me.FechaIniDtPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaIniDtPicker.Location = New System.Drawing.Point(89, 89)
        Me.FechaIniDtPicker.MinDate = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.FechaIniDtPicker.Name = "FechaIniDtPicker"
        Me.FechaIniDtPicker.Size = New System.Drawing.Size(92, 20)
        Me.FechaIniDtPicker.TabIndex = 5
        Me.FechaIniDtPicker.Value = New Date(2012, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label2, 4)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(3, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(762, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seleccione el Pronóstico a enviar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnviarTsLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 210)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(732, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'EnviarTsLabel
        '
        Me.EnviarTsLabel.Name = "EnviarTsLabel"
        Me.EnviarTsLabel.Size = New System.Drawing.Size(0, 17)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label3, 4)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(762, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Para poder ejecutar este proceso se requiere una conexión activa de internet."
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FechaIniDtPicker, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPronostico, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnEnviar, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.DescripcionTxt, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaFinDtPicker, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.AgenteLbl, 1, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(732, 185)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'btnEnviar
        '
        Me.btnEnviar.Image = Global.PronosticosSAP.My.Resources.Resources.Buscar
        Me.btnEnviar.Location = New System.Drawing.Point(187, 57)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(26, 26)
        Me.btnEnviar.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.btnEnviar, "Buscar pronosticos")
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Periodo Inicial"
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.Enabled = False
        Me.DescripcionTxt.Location = New System.Drawing.Point(264, 57)
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(501, 20)
        Me.DescripcionTxt.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(187, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Periodo Final:"
        '
        'FechaFinDtPicker
        '
        Me.FechaFinDtPicker.Enabled = False
        Me.FechaFinDtPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFinDtPicker.Location = New System.Drawing.Point(264, 89)
        Me.FechaFinDtPicker.MinDate = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.FechaFinDtPicker.Name = "FechaFinDtPicker"
        Me.FechaFinDtPicker.Size = New System.Drawing.Size(92, 20)
        Me.FechaFinDtPicker.TabIndex = 7
        Me.FechaFinDtPicker.Value = New Date(2012, 1, 1, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Agente:"
        '
        'AgenteLbl
        '
        Me.AgenteLbl.AutoSize = True
        Me.AgenteLbl.Location = New System.Drawing.Point(89, 112)
        Me.AgenteLbl.Name = "AgenteLbl"
        Me.AgenteLbl.Size = New System.Drawing.Size(0, 13)
        Me.AgenteLbl.TabIndex = 12
        '
        'BGWKEnvios
        '
        Me.BGWKEnvios.WorkerReportsProgress = True
        Me.BGWKEnvios.WorkerSupportsCancellation = True
        '
        'EnvioErrProv
        '
        Me.EnvioErrProv.ContainerControl = Me
        '
        'FrmGeneraArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 232)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmGeneraArchivo"
        Me.Text = "Enviar Pronosticos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.EnvioErrProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPronostico As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents EnviarTsLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FechaIniDtPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents BGWKEnvios As System.ComponentModel.BackgroundWorker
    Friend WithEvents FechaFinDtPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents EnvioErrProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents DescripcionTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AgenteLbl As System.Windows.Forms.Label
End Class
