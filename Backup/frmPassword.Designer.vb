<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPassword
#Region "C�digo generado por el Dise�ador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Dise�ador de Windows Forms.
		InitializeComponent()
		'�ste es un formulario MDI secundario.
		'Este c�digo simula la funcionalidad de VB6 
		' de cargar autom�ticamente
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
	'Requerido por el Dise�ador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents _lblLabels_1 As System.Windows.Forms.Label
	Public WithEvents lblLabels As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Dise�ador de Windows Forms.
	'No lo modifique con el editor de c�digo.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPassword))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdOK = New System.Windows.Forms.Button
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me._lblLabels_1 = New System.Windows.Forms.Label
		Me.lblLabels = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Password"
		Me.ClientSize = New System.Drawing.Size(250, 103)
		Me.Location = New System.Drawing.Point(189, 232)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmPassword"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOK.Text = "Aceptar"
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.Size = New System.Drawing.Size(67, 23)
		Me.cmdOK.Location = New System.Drawing.Point(51, 66)
		Me.cmdOK.TabIndex = 2
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.Text = "Cancelar"
		Me.cmdCancel.Size = New System.Drawing.Size(67, 23)
		Me.cmdCancel.Location = New System.Drawing.Point(130, 66)
		Me.cmdCancel.TabIndex = 3
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.txtPassword.AutoSize = False
		Me.txtPassword.Size = New System.Drawing.Size(155, 23)
		Me.txtPassword.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtPassword.Location = New System.Drawing.Point(86, 22)
		Me.txtPassword.PasswordChar = ChrW(42)
		Me.txtPassword.TabIndex = 1
		Me.txtPassword.AcceptsReturn = True
		Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtPassword.CausesValidation = True
		Me.txtPassword.Enabled = True
		Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPassword.HideSelection = True
		Me.txtPassword.ReadOnly = False
		Me.txtPassword.Maxlength = 0
		Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPassword.MultiLine = False
		Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPassword.TabStop = True
		Me.txtPassword.Visible = True
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPassword.Name = "txtPassword"
		Me._lblLabels_1.Text = "&Contrase�a:"
		Me._lblLabels_1.Size = New System.Drawing.Size(72, 18)
		Me._lblLabels_1.Location = New System.Drawing.Point(7, 23)
		Me._lblLabels_1.TabIndex = 0
		Me._lblLabels_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_1.Enabled = True
		Me._lblLabels_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_1.UseMnemonic = True
		Me._lblLabels_1.Visible = True
		Me._lblLabels_1.AutoSize = False
		Me._lblLabels_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_1.Name = "_lblLabels_1"
		Me.lblLabels.SetIndex(_lblLabels_1, CType(1, Short))
		CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(txtPassword)
		Me.Controls.Add(_lblLabels_1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class