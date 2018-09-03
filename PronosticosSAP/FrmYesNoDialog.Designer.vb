<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmYesNoDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.MensajeLbl = New System.Windows.Forms.Label()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CancelarBtn, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MensajeLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AceptarBtn, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(747, 172)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelarBtn.Location = New System.Drawing.Point(509, 132)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(214, 37)
        Me.CancelarBtn.TabIndex = 2
        Me.CancelarBtn.Text = "&Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'MensajeLbl
        '
        Me.MensajeLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.MensajeLbl, 3)
        Me.MensajeLbl.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajeLbl.Location = New System.Drawing.Point(3, 0)
        Me.MensajeLbl.Name = "MensajeLbl"
        Me.MensajeLbl.Size = New System.Drawing.Size(272, 23)
        Me.MensajeLbl.TabIndex = 0
        Me.MensajeLbl.Text = "Defina el mensaje a mostrar"
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AceptarBtn.Location = New System.Drawing.Point(3, 132)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(214, 37)
        Me.AceptarBtn.TabIndex = 1
        Me.AceptarBtn.Text = "&Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'FrmYesNoDialog
        '
        Me.AcceptButton = Me.AceptarBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelarBtn
        Me.ClientSize = New System.Drawing.Size(747, 172)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmYesNoDialog"
        Me.Text = "FrmYesNoDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents MensajeLbl As System.Windows.Forms.Label
    Friend WithEvents AceptarBtn As System.Windows.Forms.Button
End Class
