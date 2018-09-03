<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlanAnualConsulta
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.RefreshBtn = New System.Windows.Forms.ToolStripButton()
        Me.BtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PresupuestoDG = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AgenteTxt = New System.Windows.Forms.TextBox()
        Me.ProductoTxt = New System.Windows.Forms.TextBox()
        Me.MsgStatusLbl = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PresupuestoDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshBtn, Me.BtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(838, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshBtn.Image = Global.PronosticosSAP.My.Resources.Resources.table_refresh
        Me.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(23, 22)
        Me.RefreshBtn.Text = "ToolStripButton1"
        Me.RefreshBtn.ToolTipText = "Actualiizar ..."
        '
        'BtnSalir
        '
        Me.BtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSalir.Image = Global.PronosticosSAP.My.Resources.Resources.arrow_left_24
        Me.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(23, 22)
        Me.BtnSalir.Text = "ToolStripButton2"
        Me.BtnSalir.ToolTipText = "Regresar ..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 247)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(838, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.PresupuestoDG, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AgenteTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ProductoTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MsgStatusLbl, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(838, 222)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plan anual de Ventas"
        '
        'PresupuestoDG
        '
        Me.PresupuestoDG.AllowUserToAddRows = False
        Me.PresupuestoDG.AllowUserToDeleteRows = False
        Me.PresupuestoDG.AllowUserToOrderColumns = True
        Me.PresupuestoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.PresupuestoDG, 3)
        Me.PresupuestoDG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PresupuestoDG.Location = New System.Drawing.Point(3, 119)
        Me.PresupuestoDG.Name = "PresupuestoDG"
        Me.PresupuestoDG.ReadOnly = True
        Me.PresupuestoDG.Size = New System.Drawing.Size(832, 100)
        Me.PresupuestoDG.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Agente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Producto:"
        '
        'AgenteTxt
        '
        Me.AgenteTxt.Enabled = False
        Me.AgenteTxt.Location = New System.Drawing.Point(62, 35)
        Me.AgenteTxt.Name = "AgenteTxt"
        Me.AgenteTxt.Size = New System.Drawing.Size(100, 20)
        Me.AgenteTxt.TabIndex = 4
        '
        'ProductoTxt
        '
        Me.ProductoTxt.Enabled = False
        Me.ProductoTxt.Location = New System.Drawing.Point(62, 61)
        Me.ProductoTxt.Name = "ProductoTxt"
        Me.ProductoTxt.Size = New System.Drawing.Size(100, 20)
        Me.ProductoTxt.TabIndex = 5
        '
        'MsgStatusLbl
        '
        Me.MsgStatusLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.MsgStatusLbl, 3)
        Me.MsgStatusLbl.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgStatusLbl.Location = New System.Drawing.Point(3, 84)
        Me.MsgStatusLbl.Name = "MsgStatusLbl"
        Me.MsgStatusLbl.Size = New System.Drawing.Size(60, 32)
        Me.MsgStatusLbl.TabIndex = 6
        Me.MsgStatusLbl.Text = "xxx"
        '
        'FrmPlanAnualConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 269)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmPlanAnualConsulta"
        Me.Text = "Plan anual de ventas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PresupuestoDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RefreshBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents PresupuestoDG As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AgenteTxt As System.Windows.Forms.TextBox
    Friend WithEvents ProductoTxt As System.Windows.Forms.TextBox
    Friend WithEvents MsgStatusLbl As System.Windows.Forms.Label
End Class
