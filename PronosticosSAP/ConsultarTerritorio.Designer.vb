<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarTerritorio
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.EstadoTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.ClaveTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ResultadosDGW = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLAVE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ResultadosDGW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(521, 234)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.EstadoTxt)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.BtnCancelar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.DescripcionTxt)
        Me.TabPage1.Controls.Add(Me.ClaveTxt)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(513, 208)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Definición"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'EstadoTxt
        '
        Me.EstadoTxt.Location = New System.Drawing.Point(83, 100)
        Me.EstadoTxt.Name = "EstadoTxt"
        Me.EstadoTxt.Size = New System.Drawing.Size(100, 20)
        Me.EstadoTxt.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estado"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(105, 133)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(13, 133)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.Location = New System.Drawing.Point(83, 71)
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(411, 20)
        Me.DescripcionTxt.TabIndex = 5
        '
        'ClaveTxt
        '
        Me.ClaveTxt.Location = New System.Drawing.Point(83, 43)
        Me.ClaveTxt.Name = "ClaveTxt"
        Me.ClaveTxt.Size = New System.Drawing.Size(100, 20)
        Me.ClaveTxt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clave:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Indicar los criterios de Busqueda"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ResultadosDGW)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(513, 208)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resultados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ResultadosDGW
        '
        Me.ResultadosDGW.AllowUserToAddRows = False
        Me.ResultadosDGW.AllowUserToDeleteRows = False
        Me.ResultadosDGW.AllowUserToOrderColumns = True
        Me.ResultadosDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultadosDGW.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.CLAVE, Me.DESCRIPCION, Me.ESTATUS})
        Me.ResultadosDGW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultadosDGW.Location = New System.Drawing.Point(3, 3)
        Me.ResultadosDGW.Name = "ResultadosDGW"
        Me.ResultadosDGW.ReadOnly = True
        Me.ResultadosDGW.Size = New System.Drawing.Size(507, 202)
        Me.ResultadosDGW.TabIndex = 0
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'CLAVE
        '
        Me.CLAVE.HeaderText = "Clave"
        Me.CLAVE.Name = "CLAVE"
        Me.CLAVE.ReadOnly = True
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "Desc."
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        '
        'ESTATUS
        '
        Me.ESTATUS.HeaderText = "Estado"
        Me.ESTATUS.Name = "ESTATUS"
        Me.ESTATUS.ReadOnly = True
        '
        'ConsultarTerritorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(558, 267)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "ConsultarTerritorio"
        Me.Text = "ConsultarTerritorio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ResultadosDGW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents DescripcionTxt As System.Windows.Forms.TextBox
    Friend WithEvents ClaveTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ResultadosDGW As System.Windows.Forms.DataGridView
    Friend WithEvents EstadoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLAVE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
