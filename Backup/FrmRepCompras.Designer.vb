<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmRepCompras
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
		'Éste es un formulario MDI secundario.
		'Este código simula la funcionalidad de VB6 
		' de cargar automáticamente
		' y mostrar el formulario primario de
		' un MDI secundario.
		Me.MDIParent = Contabilidad.MDIPrincipal
		Contabilidad.MDIPrincipal.Show
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents axBCancelar As System.Windows.Forms.Button
	Public WithEvents axbAceptar As System.Windows.Forms.Button
	Public WithEvents CmbOrden As System.Windows.Forms.ComboBox
	Public WithEvents CmbTipo As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepCompras))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.axBCancelar = New System.Windows.Forms.Button
		Me.axbAceptar = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.CmbOrden = New System.Windows.Forms.ComboBox
		Me.CmbTipo = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Registro de Compras"
		Me.ClientSize = New System.Drawing.Size(351, 113)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "FrmRepCompras"
		Me.axBCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.axBCancelar.Text = "&Cancelar"
		Me.axBCancelar.Size = New System.Drawing.Size(85, 24)
		Me.axBCancelar.Location = New System.Drawing.Point(180, 84)
		Me.axBCancelar.TabIndex = 6
		Me.axBCancelar.BackColor = System.Drawing.SystemColors.Control
		Me.axBCancelar.CausesValidation = True
		Me.axBCancelar.Enabled = True
		Me.axBCancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.axBCancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.axBCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.axBCancelar.TabStop = True
		Me.axBCancelar.Name = "axBCancelar"
		Me.axbAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.axbAceptar.Text = "&Aceptar"
		Me.axbAceptar.Size = New System.Drawing.Size(85, 24)
		Me.axbAceptar.Location = New System.Drawing.Point(90, 84)
		Me.axbAceptar.TabIndex = 5
		Me.axbAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.axbAceptar.CausesValidation = True
		Me.axbAceptar.Enabled = True
		Me.axbAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.axbAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.axbAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.axbAceptar.TabStop = True
		Me.axbAceptar.Name = "axbAceptar"
		Me.Frame1.Size = New System.Drawing.Size(345, 77)
		Me.Frame1.Location = New System.Drawing.Point(3, 0)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.CmbOrden.Size = New System.Drawing.Size(255, 21)
		Me.CmbOrden.Location = New System.Drawing.Point(83, 43)
		Me.CmbOrden.Items.AddRange(New Object(){"Ordenar por Fecha de Documento", "Ordenar por Comprobante contable", "Ordenar por Numero Auxiliar (Provisión)"})
		Me.CmbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CmbOrden.TabIndex = 4
		Me.CmbOrden.BackColor = System.Drawing.SystemColors.Window
		Me.CmbOrden.CausesValidation = True
		Me.CmbOrden.Enabled = True
		Me.CmbOrden.ForeColor = System.Drawing.SystemColors.WindowText
		Me.CmbOrden.IntegralHeight = True
		Me.CmbOrden.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmbOrden.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmbOrden.Sorted = False
		Me.CmbOrden.TabStop = True
		Me.CmbOrden.Visible = True
		Me.CmbOrden.Name = "CmbOrden"
		Me.CmbTipo.Size = New System.Drawing.Size(180, 21)
		Me.CmbTipo.Location = New System.Drawing.Point(158, 17)
		Me.CmbTipo.Items.AddRange(New Object(){"Agrupado por Documento", "Agrupado por Proveedor", "Presentacion Sunat"})
		Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CmbTipo.TabIndex = 1
		Me.CmbTipo.BackColor = System.Drawing.SystemColors.Window
		Me.CmbTipo.CausesValidation = True
		Me.CmbTipo.Enabled = True
		Me.CmbTipo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.CmbTipo.IntegralHeight = True
		Me.CmbTipo.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmbTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmbTipo.Sorted = False
		Me.CmbTipo.TabStop = True
		Me.CmbTipo.Visible = True
		Me.CmbTipo.Name = "CmbTipo"
		Me.Label2.Text = "Ordenar por :"
		Me.Label2.Size = New System.Drawing.Size(62, 13)
		Me.Label2.Location = New System.Drawing.Point(9, 48)
		Me.Label2.TabIndex = 3
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = True
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Tipo de Registro de Compras :"
		Me.Label1.Size = New System.Drawing.Size(143, 13)
		Me.Label1.Location = New System.Drawing.Point(7, 21)
		Me.Label1.TabIndex = 2
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(axBCancelar)
		Me.Controls.Add(axbAceptar)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(CmbOrden)
		Me.Frame1.Controls.Add(CmbTipo)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class