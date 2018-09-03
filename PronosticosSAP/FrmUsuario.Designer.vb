<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim PwdLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim EstatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.SapForecastDataSet = New PronosticosSAP.SapForecastDataSet()
        Me.USP_CONSULTA_USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USP_CONSULTA_USUARIOTableAdapter = New PronosticosSAP.SapForecastDataSetTableAdapters.USP_CONSULTA_USUARIOTableAdapter()
        Me.TableAdapterManager = New PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager()
        Me.USP_CONSULTA_USUARIOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.USP_CONSULTA_USUARIOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.UserIdToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.UserIdToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.UserIdTextBox = New System.Windows.Forms.TextBox()
        Me.PwdTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EstatusComboBox = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        UserIdLabel = New System.Windows.Forms.Label()
        PwdLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        EstatusLabel = New System.Windows.Forms.Label()
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USP_CONSULTA_USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USP_CONSULTA_USUARIOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.USP_CONSULTA_USUARIOBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(3, 0)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(44, 13)
        UserIdLabel.TabIndex = 2
        UserIdLabel.Text = "User Id:"
        '
        'PwdLabel
        '
        PwdLabel.AutoSize = True
        PwdLabel.Location = New System.Drawing.Point(3, 26)
        PwdLabel.Name = "PwdLabel"
        PwdLabel.Size = New System.Drawing.Size(31, 13)
        PwdLabel.TabIndex = 4
        PwdLabel.Text = "Pwd:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(3, 52)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "email:"
        '
        'EstatusLabel
        '
        EstatusLabel.AutoSize = True
        EstatusLabel.Location = New System.Drawing.Point(3, 78)
        EstatusLabel.Name = "EstatusLabel"
        EstatusLabel.Size = New System.Drawing.Size(44, 13)
        EstatusLabel.TabIndex = 8
        EstatusLabel.Text = "estatus:"
        '
        'SapForecastDataSet
        '
        Me.SapForecastDataSet.DataSetName = "SapForecastDataSet"
        Me.SapForecastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USP_CONSULTA_USUARIOBindingSource
        '
        Me.USP_CONSULTA_USUARIOBindingSource.DataMember = "USP_CONSULTA_USUARIO"
        Me.USP_CONSULTA_USUARIOBindingSource.DataSource = Me.SapForecastDataSet
        '
        'USP_CONSULTA_USUARIOTableAdapter
        '
        Me.USP_CONSULTA_USUARIOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTA_AGENTECLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_AGENTESTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_DETALLEPRONOSTICOSALMACENTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_PRODUCTOTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTA_ZONASBYCLAVETableAdapter = Nothing
        Me.TableAdapterManager.CONSULTAESTADOBYZONATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USP_CONSULTA_USUARIOTableAdapter = Me.USP_CONSULTA_USUARIOTableAdapter
        '
        'USP_CONSULTA_USUARIOBindingNavigator
        '
        Me.USP_CONSULTA_USUARIOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.USP_CONSULTA_USUARIOBindingNavigator.BindingSource = Me.USP_CONSULTA_USUARIOBindingSource
        Me.USP_CONSULTA_USUARIOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.USP_CONSULTA_USUARIOBindingNavigator.DeleteItem = Nothing
        Me.USP_CONSULTA_USUARIOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.USP_CONSULTA_USUARIOBindingNavigatorSaveItem})
        Me.USP_CONSULTA_USUARIOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.USP_CONSULTA_USUARIOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.USP_CONSULTA_USUARIOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.USP_CONSULTA_USUARIOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.USP_CONSULTA_USUARIOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.USP_CONSULTA_USUARIOBindingNavigator.Name = "USP_CONSULTA_USUARIOBindingNavigator"
        Me.USP_CONSULTA_USUARIOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.USP_CONSULTA_USUARIOBindingNavigator.Size = New System.Drawing.Size(561, 25)
        Me.USP_CONSULTA_USUARIOBindingNavigator.TabIndex = 0
        Me.USP_CONSULTA_USUARIOBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'USP_CONSULTA_USUARIOBindingNavigatorSaveItem
        '
        Me.USP_CONSULTA_USUARIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.USP_CONSULTA_USUARIOBindingNavigatorSaveItem.Image = CType(resources.GetObject("USP_CONSULTA_USUARIOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.USP_CONSULTA_USUARIOBindingNavigatorSaveItem.Name = "USP_CONSULTA_USUARIOBindingNavigatorSaveItem"
        Me.USP_CONSULTA_USUARIOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.USP_CONSULTA_USUARIOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserIdToolStripLabel, Me.UserIdToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(561, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'UserIdToolStripLabel
        '
        Me.UserIdToolStripLabel.Name = "UserIdToolStripLabel"
        Me.UserIdToolStripLabel.Size = New System.Drawing.Size(43, 22)
        Me.UserIdToolStripLabel.Text = "UserId:"
        '
        'UserIdToolStripTextBox
        '
        Me.UserIdToolStripTextBox.Name = "UserIdToolStripTextBox"
        Me.UserIdToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FillToolStripButton.Image = Global.PronosticosSAP.My.Resources.Resources.table_refresh
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.FillToolStripButton.ToolTipText = "Actualizar consulta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Para consultar todo el catalogo dejar vacio el campo User Id" & _
            "."
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USP_CONSULTA_USUARIOBindingSource, "UserId", True))
        Me.UserIdTextBox.Location = New System.Drawing.Point(143, 3)
        Me.UserIdTextBox.MaxLength = 15
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.Size = New System.Drawing.Size(121, 20)
        Me.UserIdTextBox.TabIndex = 3
        '
        'PwdTextBox
        '
        Me.PwdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USP_CONSULTA_USUARIOBindingSource, "Pwd", True))
        Me.PwdTextBox.Location = New System.Drawing.Point(143, 29)
        Me.PwdTextBox.MaxLength = 10
        Me.PwdTextBox.Name = "PwdTextBox"
        Me.PwdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PwdTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PwdTextBox.TabIndex = 5
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USP_CONSULTA_USUARIOBindingSource, "email", True))
        Me.EmailTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailTextBox.Location = New System.Drawing.Point(143, 55)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(415, 20)
        Me.EmailTextBox.TabIndex = 7
        '
        'EstatusComboBox
        '
        Me.EstatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USP_CONSULTA_USUARIOBindingSource, "estatus", True))
        Me.EstatusComboBox.FormattingEnabled = True
        Me.EstatusComboBox.Items.AddRange(New Object() {"A", "I"})
        Me.EstatusComboBox.Location = New System.Drawing.Point(143, 81)
        Me.EstatusComboBox.Name = "EstatusComboBox"
        Me.EstatusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EstatusComboBox.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(PwdLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PwdTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.UserIdTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(EmailLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(EstatusLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.EstatusComboBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(UserIdLabel, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 50)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(561, 113)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 163)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.USP_CONSULTA_USUARIOBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmUsuario"
        Me.Text = "Usuarios"
        CType(Me.SapForecastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USP_CONSULTA_USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USP_CONSULTA_USUARIOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.USP_CONSULTA_USUARIOBindingNavigator.ResumeLayout(False)
        Me.USP_CONSULTA_USUARIOBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SapForecastDataSet As PronosticosSAP.SapForecastDataSet
    Friend WithEvents USP_CONSULTA_USUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USP_CONSULTA_USUARIOTableAdapter As PronosticosSAP.SapForecastDataSetTableAdapters.USP_CONSULTA_USUARIOTableAdapter
    Friend WithEvents TableAdapterManager As PronosticosSAP.SapForecastDataSetTableAdapters.TableAdapterManager
    Friend WithEvents USP_CONSULTA_USUARIOBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents USP_CONSULTA_USUARIOBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents UserIdToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents UserIdToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PwdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
