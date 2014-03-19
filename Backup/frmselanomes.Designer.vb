<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmselanomes
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
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
	Public WithEvents cmdcancelar As System.Windows.Forms.Button
	Public WithEvents DTPperiodo As AxMSComCtl2.AxDTPicker
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdaceptar As System.Windows.Forms.Button
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmselanomes))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdcancelar = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.DTPperiodo = New AxMSComCtl2.AxDTPicker
		Me.Label1 = New System.Windows.Forms.Label
		Me.cmdaceptar = New System.Windows.Forms.Button
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DTPperiodo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Seleccion Periodo de Trabajo"
		Me.ClientSize = New System.Drawing.Size(248, 71)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmselanomes"
		Me.cmdcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdcancelar.Text = "&Cancelar"
		Me.cmdcancelar.Size = New System.Drawing.Size(90, 22)
		Me.cmdcancelar.Location = New System.Drawing.Point(127, 44)
		Me.cmdcancelar.TabIndex = 3
		Me.cmdcancelar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdcancelar.CausesValidation = True
		Me.cmdcancelar.Enabled = True
		Me.cmdcancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdcancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdcancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdcancelar.TabStop = True
		Me.cmdcancelar.Name = "cmdcancelar"
		Me.Frame1.Size = New System.Drawing.Size(239, 41)
		Me.Frame1.Location = New System.Drawing.Point(3, -2)
		Me.Frame1.TabIndex = 1
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		DTPperiodo.OcxState = CType(resources.GetObject("DTPperiodo.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPperiodo.Size = New System.Drawing.Size(110, 19)
		Me.DTPperiodo.Location = New System.Drawing.Point(122, 13)
		Me.DTPperiodo.TabIndex = 4
		Me.DTPperiodo.Name = "DTPperiodo"
		Me.Label1.Text = "Periodo de Trabajo :"
		Me.Label1.Size = New System.Drawing.Size(105, 19)
		Me.Label1.Location = New System.Drawing.Point(14, 15)
		Me.Label1.TabIndex = 2
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
		Me.cmdaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdaceptar.Text = "&Aceptar"
		Me.cmdaceptar.Size = New System.Drawing.Size(90, 22)
		Me.cmdaceptar.Location = New System.Drawing.Point(30, 44)
		Me.cmdaceptar.TabIndex = 0
		Me.cmdaceptar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdaceptar.CausesValidation = True
		Me.cmdaceptar.Enabled = True
		Me.cmdaceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdaceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdaceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdaceptar.TabStop = True
		Me.cmdaceptar.Name = "cmdaceptar"
		Me.Controls.Add(cmdcancelar)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cmdaceptar)
		Me.Frame1.Controls.Add(DTPperiodo)
		Me.Frame1.Controls.Add(Label1)
		CType(Me.DTPperiodo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class