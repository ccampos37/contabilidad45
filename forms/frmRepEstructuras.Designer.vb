<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepEstructuras
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
    Public WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
	Public WithEvents cboTipoReporte As System.Windows.Forms.ComboBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cboTipoReporte = New System.Windows.Forms.ComboBox()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout
        Me.SuspendLayout
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(55, 129)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(228, 13)
        Me.ProgressBar1.TabIndex = 4
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cboTipoReporte)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(338, 56)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = false
        Me.Frame1.Text = "Seleccionar Tipo"
        '
        'cboTipoReporte
        '
        Me.cboTipoReporte.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoReporte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTipoReporte.Location = New System.Drawing.Point(3, 29)
        Me.cboTipoReporte.Name = "cboTipoReporte"
        Me.cboTipoReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTipoReporte.Size = New System.Drawing.Size(332, 21)
        Me.cboTipoReporte.TabIndex = 3
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(55, 70)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(93, 41)
        Me.cmdBotones0.TabIndex = 1
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = false
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(190, 70)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(93, 41)
        Me.cmdBotones1.TabIndex = 0
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = false
        '
        'frmRepEstructuras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(338, 150)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmRepEstructuras"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Estructuras"
        Me.Frame1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
#End Region 
End Class