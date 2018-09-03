<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportar))
        Me.TsMain = New System.Windows.Forms.ToolStrip()
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PegarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripPB = New System.Windows.Forms.ToolStripProgressBar()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LstErrores = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TablaCbo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RegistrosChk = New System.Windows.Forms.CheckBox()
        Me.Iniciarchk = New System.Windows.Forms.CheckBox()
        Me.SimularChk = New System.Windows.Forms.CheckBox()
        Me.ImportarBW = New System.ComponentModel.BackgroundWorker()
        Me.ImportOFD = New System.Windows.Forms.OpenFileDialog()
        Me.ImportarTP = New System.Windows.Forms.ToolTip(Me.components)
        Me.TsMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TsMain
        '
        Me.TsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripButton, Me.toolStripSeparator, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton, Me.ToolStripPB})
        Me.TsMain.Location = New System.Drawing.Point(0, 0)
        Me.TsMain.Name = "TsMain"
        Me.TsMain.Size = New System.Drawing.Size(555, 25)
        Me.TsMain.TabIndex = 0
        Me.TsMain.Text = "ToolStrip1"
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), System.Drawing.Image)
        Me.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        Me.AbrirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AbrirToolStripButton.Text = "&Abrir"
        Me.AbrirToolStripButton.ToolTipText = "Abrir archivoo a importar"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CopiarToolStripButton
        '
        Me.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), System.Drawing.Image)
        Me.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripButton.Name = "CopiarToolStripButton"
        Me.CopiarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopiarToolStripButton.Text = "&Copiar"
        Me.CopiarToolStripButton.ToolTipText = "Copiar bitacora de errores en portapapeles-"
        '
        'PegarToolStripButton
        '
        Me.PegarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PegarToolStripButton.Image = CType(resources.GetObject("PegarToolStripButton.Image"), System.Drawing.Image)
        Me.PegarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PegarToolStripButton.Name = "PegarToolStripButton"
        Me.PegarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PegarToolStripButton.Text = "&Pegar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AyudaToolStripButton
        '
        Me.AyudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), System.Drawing.Image)
        Me.AyudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaToolStripButton.Name = "AyudaToolStripButton"
        Me.AyudaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AyudaToolStripButton.Text = "Ay&uda"
        '
        'ToolStripPB
        '
        Me.ToolStripPB.Name = "ToolStripPB"
        Me.ToolStripPB.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.992416!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.00758!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LstErrores, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TablaCbo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(555, 329)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Importar Tablas"
        '
        'LstErrores
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.LstErrores, 2)
        Me.LstErrores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstErrores.FormattingEnabled = True
        Me.LstErrores.Location = New System.Drawing.Point(3, 156)
        Me.LstErrores.Name = "LstErrores"
        Me.LstErrores.Size = New System.Drawing.Size(549, 170)
        Me.LstErrores.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tabla:"
        Me.ImportarTP.SetToolTip(Me.Label1, "Selecione de la lista")
        '
        'TablaCbo
        '
        Me.TablaCbo.FormattingEnabled = True
        Me.TablaCbo.Location = New System.Drawing.Point(52, 23)
        Me.TablaCbo.Name = "TablaCbo"
        Me.TablaCbo.Size = New System.Drawing.Size(497, 21)
        Me.TablaCbo.TabIndex = 3
        '
        'GroupBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OPCIONES"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RegistrosChk, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Iniciarchk, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SimularChk, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(543, 81)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'RegistrosChk
        '
        Me.RegistrosChk.AutoSize = True
        Me.RegistrosChk.Checked = True
        Me.RegistrosChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RegistrosChk.Location = New System.Drawing.Point(274, 3)
        Me.RegistrosChk.Name = "RegistrosChk"
        Me.RegistrosChk.Size = New System.Drawing.Size(211, 17)
        Me.RegistrosChk.TabIndex = 1
        Me.RegistrosChk.Text = "Biracora Mostrar solo registros erroneos"
        Me.ImportarTP.SetToolTip(Me.RegistrosChk, "Indica si solo se mostraran los errores ")
        Me.RegistrosChk.UseVisualStyleBackColor = True
        '
        'Iniciarchk
        '
        Me.Iniciarchk.AutoSize = True
        Me.Iniciarchk.Location = New System.Drawing.Point(3, 3)
        Me.Iniciarchk.Name = "Iniciarchk"
        Me.Iniciarchk.Size = New System.Drawing.Size(229, 17)
        Me.Iniciarchk.TabIndex = 0
        Me.Iniciarchk.Text = "Borrar registros existentes antes de agregar"
        Me.ImportarTP.SetToolTip(Me.Iniciarchk, "Los registros preexistentes serán borrados antes de iniciar")
        Me.Iniciarchk.UseVisualStyleBackColor = True
        '
        'SimularChk
        '
        Me.SimularChk.AutoSize = True
        Me.SimularChk.Location = New System.Drawing.Point(3, 26)
        Me.SimularChk.Name = "SimularChk"
        Me.SimularChk.Size = New System.Drawing.Size(60, 17)
        Me.SimularChk.TabIndex = 2
        Me.SimularChk.Text = "Simular"
        Me.ImportarTP.SetToolTip(Me.SimularChk, "Ejecuta el proceso sin guardar los cambios")
        Me.SimularChk.UseVisualStyleBackColor = True
        '
        'ImportarBW
        '
        Me.ImportarBW.WorkerReportsProgress = True
        Me.ImportarBW.WorkerSupportsCancellation = True
        '
        'ImportOFD
        '
        Me.ImportOFD.FileName = "OpenFileDialog1"
        '
        'FrmImportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 354)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TsMain)
        Me.Name = "FrmImportar"
        Me.Text = "Importar Archivos"
        Me.TsMain.ResumeLayout(False)
        Me.TsMain.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents AbrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopiarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PegarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TablaCbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LstErrores As System.Windows.Forms.ListBox
    Friend WithEvents ImportarBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents ImportOFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RegistrosChk As System.Windows.Forms.CheckBox
    Friend WithEvents Iniciarchk As System.Windows.Forms.CheckBox
    Friend WithEvents SimularChk As System.Windows.Forms.CheckBox
    Friend WithEvents ImportarTP As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripPB As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents keyword As System.Windows.Forms.ToolStripTextBox
End Class
