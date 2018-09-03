<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaPronosticoGlobal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaPronosticoGlobal))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PegarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PronosticosContextMnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TsConsulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.QryErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.QryBgWk = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.EstatusBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.EstatusTxt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.CboDivision = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AnioTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PronosticosDgr = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGAgentes = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1.SuspendLayout()
        Me.PronosticosContextMnu.SuspendLayout()
        CType(Me.QryErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PronosticosDgr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGAgentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.CortarToolStripButton, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(840, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevoToolStripButton.Text = "&Nuevo"
        Me.NuevoToolStripButton.Visible = False
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), System.Drawing.Image)
        Me.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        Me.AbrirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AbrirToolStripButton.Text = "&Abrir"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton.Text = "&Guardar"
        Me.GuardarToolStripButton.Visible = False
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        Me.ImprimirToolStripButton.Visible = False
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CortarToolStripButton
        '
        Me.CortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CortarToolStripButton.Image = CType(resources.GetObject("CortarToolStripButton.Image"), System.Drawing.Image)
        Me.CortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CortarToolStripButton.Name = "CortarToolStripButton"
        Me.CortarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CortarToolStripButton.Text = "Cort&ar"
        Me.CortarToolStripButton.Visible = False
        '
        'CopiarToolStripButton
        '
        Me.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), System.Drawing.Image)
        Me.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripButton.Name = "CopiarToolStripButton"
        Me.CopiarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopiarToolStripButton.Text = "&Copiar"
        Me.CopiarToolStripButton.Visible = False
        '
        'PegarToolStripButton
        '
        Me.PegarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PegarToolStripButton.Image = CType(resources.GetObject("PegarToolStripButton.Image"), System.Drawing.Image)
        Me.PegarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PegarToolStripButton.Name = "PegarToolStripButton"
        Me.PegarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PegarToolStripButton.Text = "&Pegar"
        Me.PegarToolStripButton.Visible = False
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
        'PronosticosContextMnu
        '
        Me.PronosticosContextMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsConsulta})
        Me.PronosticosContextMnu.Name = "PronosticosContextMnu"
        Me.PronosticosContextMnu.Size = New System.Drawing.Size(132, 26)
        Me.PronosticosContextMnu.Text = "Ver Detalles"
        '
        'TsConsulta
        '
        Me.TsConsulta.Name = "TsConsulta"
        Me.TsConsulta.Size = New System.Drawing.Size(131, 22)
        Me.TsConsulta.Text = "Consultar"
        '
        'QryErrProvider
        '
        Me.QryErrProvider.ContainerControl = Me
        '
        'QryBgWk
        '
        Me.QryBgWk.WorkerReportsProgress = True
        Me.QryBgWk.WorkerSupportsCancellation = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstatusBar, Me.EstatusTxt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 335)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(840, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'EstatusBar
        '
        Me.EstatusBar.Name = "EstatusBar"
        Me.EstatusBar.Size = New System.Drawing.Size(100, 16)
        '
        'EstatusTxt
        '
        Me.EstatusTxt.Name = "EstatusTxt"
        Me.EstatusTxt.Size = New System.Drawing.Size(0, 17)
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.CboDivision)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.AnioTxt)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(840, 310)
        Me.SplitContainer2.SplitterDistance = 76
        Me.SplitContainer2.TabIndex = 15
        '
        'CboDivision
        '
        Me.CboDivision.FormattingEnabled = True
        Me.CboDivision.Location = New System.Drawing.Point(194, 45)
        Me.CboDivision.Name = "CboDivision"
        Me.CboDivision.Size = New System.Drawing.Size(121, 21)
        Me.CboDivision.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "División:"
        '
        'AnioTxt
        '
        Me.AnioTxt.Location = New System.Drawing.Point(56, 48)
        Me.AnioTxt.Name = "AnioTxt"
        Me.AnioTxt.Size = New System.Drawing.Size(41, 20)
        Me.AnioTxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Año:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(3, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(698, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Para ejecutar este proceso requiere una conexion activa de internet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Consultar Pronostico del sistema central"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PronosticosDgr)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGAgentes)
        Me.SplitContainer1.Size = New System.Drawing.Size(840, 220)
        Me.SplitContainer1.SplitterDistance = 93
        Me.SplitContainer1.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Pronóstico División"
        '
        'PronosticosDgr
        '
        Me.PronosticosDgr.AllowUserToAddRows = False
        Me.PronosticosDgr.AllowUserToDeleteRows = False
        Me.PronosticosDgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PronosticosDgr.ContextMenuStrip = Me.PronosticosContextMnu
        Me.PronosticosDgr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PronosticosDgr.Location = New System.Drawing.Point(0, 0)
        Me.PronosticosDgr.Name = "PronosticosDgr"
        Me.PronosticosDgr.ReadOnly = True
        Me.PronosticosDgr.Size = New System.Drawing.Size(840, 93)
        Me.PronosticosDgr.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Pronostico por agente."
        '
        'DGAgentes
        '
        Me.DGAgentes.AllowUserToAddRows = False
        Me.DGAgentes.AllowUserToDeleteRows = False
        Me.DGAgentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAgentes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGAgentes.Location = New System.Drawing.Point(0, -27)
        Me.DGAgentes.Name = "DGAgentes"
        Me.DGAgentes.ReadOnly = True
        Me.DGAgentes.Size = New System.Drawing.Size(840, 150)
        Me.DGAgentes.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 220)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 10)
        Me.Panel2.TabIndex = 15
        '
        'FrmConsultaPronosticoGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 357)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmConsultaPronosticoGlobal"
        Me.Text = "Consulta Pronosticos del Sistema Global"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PronosticosContextMnu.ResumeLayout(False)
        CType(Me.QryErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PronosticosDgr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGAgentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AbrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CortarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopiarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PegarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents QryErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents QryBgWk As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents EstatusBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents EstatusTxt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PronosticosContextMnu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TsConsulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents AnioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PronosticosDgr As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DGAgentes As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
