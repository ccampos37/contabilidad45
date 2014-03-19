<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepCajaBancos
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
	Public WithEvents Ctr_Ayuda1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents axbAceptar As System.Windows.Forms.Button
	Public WithEvents axbCancelar As System.Windows.Forms.Button
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepCajaBancos))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label1 = New System.Windows.Forms.Label
		Me.axbAceptar = New System.Windows.Forms.Button
		Me.axbCancelar = New System.Windows.Forms.Button
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Reporte de Caja y Bancos"
		Me.ClientSize = New System.Drawing.Size(418, 158)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmRepCajaBancos"
		Me.Frame1.Size = New System.Drawing.Size(415, 88)
		Me.Frame1.Location = New System.Drawing.Point(1, 0)
		Me.Frame1.TabIndex = 2
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Ctr_Ayuda1.OcxState = CType(resources.GetObject("Ctr_Ayuda1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_Ayuda1.Size = New System.Drawing.Size(352, 24)
		Me.Ctr_Ayuda1.Location = New System.Drawing.Point(57, 31)
		Me.Ctr_Ayuda1.TabIndex = 4
		Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
		Me.Label1.Text = "Cuenta:"
		Me.Label1.Size = New System.Drawing.Size(73, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 39)
		Me.Label1.TabIndex = 3
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.axbAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.axbAceptar.Text = "&Aceptar"
		Me.axbAceptar.Size = New System.Drawing.Size(85, 24)
		Me.axbAceptar.Location = New System.Drawing.Point(115, 115)
		Me.axbAceptar.TabIndex = 1
		Me.axbAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.axbAceptar.CausesValidation = True
		Me.axbAceptar.Enabled = True
		Me.axbAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.axbAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.axbAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.axbAceptar.TabStop = True
		Me.axbAceptar.Name = "axbAceptar"
		Me.axbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.axbCancelar.Text = "&Cancelar"
		Me.axbCancelar.Size = New System.Drawing.Size(85, 24)
		Me.axbCancelar.Location = New System.Drawing.Point(210, 115)
		Me.axbCancelar.TabIndex = 0
		Me.axbCancelar.BackColor = System.Drawing.SystemColors.Control
		Me.axbCancelar.CausesValidation = True
		Me.axbCancelar.Enabled = True
		Me.axbCancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.axbCancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.axbCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.axbCancelar.TabStop = True
		Me.axbCancelar.Name = "axbCancelar"
		CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(Frame1)
		Me.Controls.Add(axbAceptar)
		Me.Controls.Add(axbCancelar)
		Me.Frame1.Controls.Add(Ctr_Ayuda1)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class