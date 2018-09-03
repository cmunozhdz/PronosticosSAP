<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfig))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkWindows = New System.Windows.Forms.CheckBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.TxtUid = New System.Windows.Forms.TextBox()
        Me.txtBd = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkIndustrialesFestivos = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAgricola = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIndustrial = New System.Windows.Forms.TextBox()
        Me.ChkAgricolasFestivos = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NumAutoSave = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtDirApp = New System.Windows.Forms.TextBox()
        Me.OpcionesTp = New System.Windows.Forms.ToolTip(Me.components)
        Me.CtrlErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsLabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumAutoSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.CtrlErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ChkWindows)
        Me.GroupBox1.Controls.Add(Me.txtPwd)
        Me.GroupBox1.Controls.Add(Me.TxtUid)
        Me.GroupBox1.Controls.Add(Me.txtBd)
        Me.GroupBox1.Controls.Add(Me.txtServer)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 115)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conexion Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Base de datos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Servidor:"
        '
        'ChkWindows
        '
        Me.ChkWindows.AutoSize = True
        Me.ChkWindows.Location = New System.Drawing.Point(16, 74)
        Me.ChkWindows.Name = "ChkWindows"
        Me.ChkWindows.Size = New System.Drawing.Size(157, 17)
        Me.ChkWindows.TabIndex = 9
        Me.ChkWindows.Text = "Usar Autenticidad Windows"
        Me.ChkWindows.UseVisualStyleBackColor = True
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(183, 121)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(100, 20)
        Me.txtPwd.TabIndex = 8
        '
        'TxtUid
        '
        Me.TxtUid.Location = New System.Drawing.Point(183, 95)
        Me.TxtUid.Name = "TxtUid"
        Me.TxtUid.Size = New System.Drawing.Size(100, 20)
        Me.TxtUid.TabIndex = 7
        '
        'txtBd
        '
        Me.txtBd.Location = New System.Drawing.Point(158, 41)
        Me.txtBd.Name = "txtBd"
        Me.txtBd.Size = New System.Drawing.Size(194, 20)
        Me.txtBd.TabIndex = 6
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(158, 18)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(194, 20)
        Me.txtServer.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 115)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reglas Negocio"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.ChkIndustrialesFestivos, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAgricola, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtIndustrial, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ChkAgricolasFestivos, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(16, 28)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(314, 72)
        Me.TableLayoutPanel2.TabIndex = 16
        '
        'ChkIndustrialesFestivos
        '
        Me.ChkIndustrialesFestivos.AutoSize = True
        Me.ChkIndustrialesFestivos.Location = New System.Drawing.Point(106, 29)
        Me.ChkIndustrialesFestivos.Name = "ChkIndustrialesFestivos"
        Me.ChkIndustrialesFestivos.Size = New System.Drawing.Size(89, 17)
        Me.ChkIndustrialesFestivos.TabIndex = 17
        Me.ChkIndustrialesFestivos.Text = "Solo Festivos"
        Me.ChkIndustrialesFestivos.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dia cierre agricola"
        '
        'txtAgricola
        '
        Me.txtAgricola.Location = New System.Drawing.Point(201, 3)
        Me.txtAgricola.MaxLength = 2
        Me.txtAgricola.Name = "txtAgricola"
        Me.txtAgricola.Size = New System.Drawing.Size(42, 20)
        Me.txtAgricola.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Dia cierre Industrial"
        '
        'txtIndustrial
        '
        Me.txtIndustrial.Location = New System.Drawing.Point(201, 29)
        Me.txtIndustrial.MaxLength = 2
        Me.txtIndustrial.Name = "txtIndustrial"
        Me.txtIndustrial.Size = New System.Drawing.Size(42, 20)
        Me.txtIndustrial.TabIndex = 15
        '
        'ChkAgricolasFestivos
        '
        Me.ChkAgricolasFestivos.AutoSize = True
        Me.ChkAgricolasFestivos.Location = New System.Drawing.Point(106, 3)
        Me.ChkAgricolasFestivos.Name = "ChkAgricolasFestivos"
        Me.ChkAgricolasFestivos.Size = New System.Drawing.Size(89, 17)
        Me.ChkAgricolasFestivos.TabIndex = 16
        Me.ChkAgricolasFestivos.Text = "Solo Festivos"
        Me.ChkAgricolasFestivos.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripButton, Me.toolStripSeparator, Me.toolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(729, 25)
        Me.ToolStrip1.TabIndex = 8
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
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(729, 350)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NumAutoSave)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(367, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Autoguardado"
        '
        'NumAutoSave
        '
        Me.NumAutoSave.Location = New System.Drawing.Point(69, 25)
        Me.NumAutoSave.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.NumAutoSave.Name = "NumAutoSave"
        Me.NumAutoSave.Size = New System.Drawing.Size(120, 20)
        Me.NumAutoSave.TabIndex = 1
        Me.OpcionesTp.SetToolTip(Me.NumAutoSave, "0:No guarda automaticamente, Max:3600 (1hr)")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tiempo (s)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtDirApp)
        Me.GroupBox4.Location = New System.Drawing.Point(367, 178)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Directorio Aplicación"
        '
        'TxtDirApp
        '
        Me.TxtDirApp.Location = New System.Drawing.Point(1, 39)
        Me.TxtDirApp.Name = "TxtDirApp"
        Me.TxtDirApp.ReadOnly = True
        Me.TxtDirApp.Size = New System.Drawing.Size(193, 20)
        Me.TxtDirApp.TabIndex = 0
        '
        'CtrlErrPrv
        '
        Me.CtrlErrPrv.ContainerControl = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsLabelStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 353)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(729, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TsLabelStatus
        '
        Me.TsLabelStatus.Name = "TsLabelStatus"
        Me.TsLabelStatus.Size = New System.Drawing.Size(0, 17)
        '
        'FrmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 375)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmConfig"
        Me.Text = "Configuración"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NumAutoSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.CtrlErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkWindows As System.Windows.Forms.CheckBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents TxtUid As System.Windows.Forms.TextBox
    Friend WithEvents txtBd As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIndustrial As System.Windows.Forms.TextBox
    Friend WithEvents txtAgricola As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents NumAutoSave As System.Windows.Forms.NumericUpDown
    Friend WithEvents OpcionesTp As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDirApp As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ChkIndustrialesFestivos As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAgricolasFestivos As System.Windows.Forms.CheckBox
    Friend WithEvents CtrlErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TsLabelStatus As System.Windows.Forms.ToolStripStatusLabel
End Class
