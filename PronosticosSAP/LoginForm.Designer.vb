<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StsLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkForgotPassword = New System.Windows.Forms.CheckBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.PasswordLabel, 2)
        Me.PasswordLabel.Location = New System.Drawing.Point(174, 49)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.UsernameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TableLayoutPanel1.SetColumnSpan(Me.UsernameTextBox, 2)
        Me.UsernameTextBox.Location = New System.Drawing.Point(174, 26)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.UsernameTextBox, "Clave de usuario asignado:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "El sistema diferencia entre mayúsculas y minúsculas")
        '
        'PasswordTextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.PasswordTextBox, 2)
        Me.PasswordTextBox.Location = New System.Drawing.Point(174, 75)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.PasswordTextBox, "Contraseña asignada:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "El sistema diferencia entre mayúsculas y minúsculas")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StsLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 220)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(433, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StsLabel
        '
        Me.StsLabel.Name = "StsLabel"
        Me.StsLabel.Size = New System.Drawing.Size(0, 17)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.ChkForgotPassword, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LogoPictureBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UsernameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PasswordLabel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PasswordTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.OK, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.UsernameLabel, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(433, 220)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'ChkForgotPassword
        '
        Me.ChkForgotPassword.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ChkForgotPassword, 2)
        Me.ChkForgotPassword.Location = New System.Drawing.Point(174, 101)
        Me.ChkForgotPassword.Name = "ChkForgotPassword"
        Me.ChkForgotPassword.Size = New System.Drawing.Size(126, 17)
        Me.ChkForgotPassword.TabIndex = 9
        Me.ChkForgotPassword.Text = "Olvide mi Contraseña"
        Me.ChkForgotPassword.UseVisualStyleBackColor = True
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.TableLayoutPanel1.SetRowSpan(Me.LogoPictureBox, 6)
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 144)
        Me.LogoPictureBox.TabIndex = 1
        Me.LogoPictureBox.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(274, 124)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 8
        Me.Cancel.Text = "&Cancelar"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(174, 124)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 7
        Me.OK.Text = "&Aceptar"
        '
        'UsernameLabel
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.UsernameLabel, 2)
        Me.UsernameLabel.Location = New System.Drawing.Point(174, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 2
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoginForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(433, 242)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inicio Version 2018"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StsLabel As ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ChkForgotPassword As CheckBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents UsernameLabel As Label
End Class
