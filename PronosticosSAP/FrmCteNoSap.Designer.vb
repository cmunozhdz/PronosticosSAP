<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCteNoSap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCteNoSap))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClaveTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 251)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(292, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.CortarToolStripButton, Me.CopiarToolStripButton, Me.PegarToolStripButton, Me.toolStripSeparator1, Me.AyudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(292, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ClaveTxt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(51, 69)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevoToolStripButton.Text = "&Nuevo"
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
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
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
        '
        'CopiarToolStripButton
        '
        Me.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), System.Drawing.Image)
        Me.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripButton.Name = "CopiarToolStripButton"
        Me.CopiarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopiarToolStripButton.Text = "&Copiar"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cve Cliente:"
        '
        'ClaveTxt
        '
        Me.ClaveTxt.Location = New System.Drawing.Point(103, 3)
        Me.ClaveTxt.Name = "ClaveTxt"
        Me.ClaveTxt.Size = New System.Drawing.Size(94, 20)
        Me.ClaveTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.Location = New System.Drawing.Point(103, 43)
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(94, 20)
        Me.DescripcionTxt.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(94, 14)
        Me.DataGridView1.TabIndex = 4
        '
        'FrmCteNoSap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FrmCteNoSap"
        Me.Text = "FrmCteNoSap"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
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
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClaveTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DescripcionTxt As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
