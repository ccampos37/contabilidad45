<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class xxxfrmRepEstadoGP
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
    Public WithEvents mdBotones0 As System.Windows.Forms.Button
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents cboTipoReporte As System.Windows.Forms.ComboBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.mdBotones0 = New System.Windows.Forms.Button()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cboTipoReporte = New System.Windows.Forms.ComboBox()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mdBotones0
        '
        Me.mdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.mdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.mdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mdBotones0.Location = New System.Drawing.Point(88, 107)
        Me.mdBotones0.Name = "mdBotones0"
        Me.mdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mdBotones0.Size = New System.Drawing.Size(70, 23)
        Me.mdBotones0.TabIndex = 3
        Me.mdBotones0.Text = "&Aceptar"
        Me.mdBotones0.UseVisualStyleBackColor = False
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(178, 107)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(70, 23)
        Me.cmdBotones1.TabIndex = 2
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cboTipoReporte)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 21)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(335, 60)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Tipo de Reporte"
        '
        'cboTipoReporte
        '
        Me.cboTipoReporte.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoReporte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTipoReporte.Location = New System.Drawing.Point(3, 20)
        Me.cboTipoReporte.Name = "cboTipoReporte"
        Me.cboTipoReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTipoReporte.Size = New System.Drawing.Size(329, 21)
        Me.cboTipoReporte.TabIndex = 1
        '
        'xxxfrmRepEstadoGP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(336, 147)
        Me.Controls.Add(Me.mdBotones0)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "xxxfrmRepEstadoGP"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Estado de Ganancias y Pérdidas"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class