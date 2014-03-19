<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmError
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
	Public WithEvents RichError As System.Windows.Forms.RichTextBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmError))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.RichError = New System.Windows.Forms.RichTextBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Error"
		Me.ClientSize = New System.Drawing.Size(361, 276)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
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
		Me.Name = "frmError"
		Me.RichError.Size = New System.Drawing.Size(348, 252)
		Me.RichError.Location = New System.Drawing.Point(7, 10)
		Me.RichError.TabIndex = 0
		Me.RichError.Enabled = True
		Me.RichError.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both
		Me.RichError.RTF = resources.GetString("RichError.TextRTF")
		Me.RichError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.RichError.Name = "RichError"
		Me.Controls.Add(RichError)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class