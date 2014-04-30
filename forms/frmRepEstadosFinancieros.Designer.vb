<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepEstadosFinancieros
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
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents DTPicker_Fecha As AxMSComCtl2.AxDTPicker
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Check1 As System.Windows.Forms.CheckBox
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents optTipo3 As System.Windows.Forms.RadioButton
    Public WithEvents optTipo2 As System.Windows.Forms.RadioButton
    Public WithEvents optTipo1 As System.Windows.Forms.RadioButton
    Public WithEvents optTipo0 As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepEstadosFinancieros))
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.DTPicker_Fecha = New AxMSComCtl2.AxDTPicker()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Check1 = New System.Windows.Forms.CheckBox()
        Me.optTipo3 = New System.Windows.Forms.RadioButton()
        Me.optTipo2 = New System.Windows.Forms.RadioButton()
        Me.optTipo1 = New System.Windows.Forms.RadioButton()
        Me.optTipo0 = New System.Windows.Forms.RadioButton()
        Me.Frame2.SuspendLayout
        CType(Me.DTPicker_Fecha,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Frame1.SuspendLayout
        Me.Frame3.SuspendLayout
        Me.SuspendLayout
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(207, 271)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(89, 25)
        Me.cmdBotones1.TabIndex = 7
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = false
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(96, 271)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(89, 25)
        Me.cmdBotones0.TabIndex = 6
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = false
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.DTPicker_Fecha)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(0, 187)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(391, 54)
        Me.Frame2.TabIndex = 4
        Me.Frame2.TabStop = false
        Me.Frame2.Text = "Seleccionar Período"
        '
        'DTPicker_Fecha
        '
        Me.DTPicker_Fecha.Location = New System.Drawing.Point(8, 18)
        Me.DTPicker_Fecha.Name = "DTPicker_Fecha"
        Me.DTPicker_Fecha.OcxState = CType(resources.GetObject("DTPicker_Fecha.OcxState"),System.Windows.Forms.AxHost.State)
        Me.DTPicker_Fecha.Size = New System.Drawing.Size(260, 22)
        Me.DTPicker_Fecha.TabIndex = 5
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Frame3)
        Me.Frame1.Controls.Add(Me.optTipo3)
        Me.Frame1.Controls.Add(Me.optTipo2)
        Me.Frame1.Controls.Add(Me.optTipo1)
        Me.Frame1.Controls.Add(Me.optTipo0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(391, 157)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = false
        Me.Frame1.Text = "Seleccionar Estado Financiero"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Check1)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(207, 84)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(153, 73)
        Me.Frame3.TabIndex = 9
        Me.Frame3.TabStop = false
        Me.Frame3.Text = "Tipo de Balance"
        '
        'Check1
        '
        Me.Check1.BackColor = System.Drawing.SystemColors.Control
        Me.Check1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check1.Location = New System.Drawing.Point(16, 24)
        Me.Check1.Name = "Check1"
        Me.Check1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Check1.Size = New System.Drawing.Size(96, 33)
        Me.Check1.TabIndex = 10
        Me.Check1.Text = "Diferenciado por Afiliadas"
        Me.Check1.UseVisualStyleBackColor = false
        '
        'optTipo3
        '
        Me.optTipo3.BackColor = System.Drawing.SystemColors.Control
        Me.optTipo3.Cursor = System.Windows.Forms.Cursors.Default
        Me.optTipo3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTipo3.Location = New System.Drawing.Point(8, 112)
        Me.optTipo3.Name = "optTipo3"
        Me.optTipo3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optTipo3.Size = New System.Drawing.Size(298, 32)
        Me.optTipo3.TabIndex = 8
        Me.optTipo3.TabStop = true
        Me.optTipo3.Text = "Estados de Flujos de Efectivo"
        Me.optTipo3.UseVisualStyleBackColor = false
        '
        'optTipo2
        '
        Me.optTipo2.BackColor = System.Drawing.SystemColors.Control
        Me.optTipo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optTipo2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTipo2.Location = New System.Drawing.Point(8, 82)
        Me.optTipo2.Name = "optTipo2"
        Me.optTipo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optTipo2.Size = New System.Drawing.Size(170, 32)
        Me.optTipo2.TabIndex = 3
        Me.optTipo2.TabStop = true
        Me.optTipo2.Text = "Balance General"
        Me.optTipo2.UseVisualStyleBackColor = false
        '
        'optTipo1
        '
        Me.optTipo1.BackColor = System.Drawing.SystemColors.Control
        Me.optTipo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.optTipo1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTipo1.Location = New System.Drawing.Point(8, 49)
        Me.optTipo1.Name = "optTipo1"
        Me.optTipo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optTipo1.Size = New System.Drawing.Size(298, 32)
        Me.optTipo1.TabIndex = 2
        Me.optTipo1.TabStop = true
        Me.optTipo1.Text = "Estado de Ganancias y Pérdidas por Naturaleza"
        Me.optTipo1.UseVisualStyleBackColor = false
        '
        'optTipo0
        '
        Me.optTipo0.BackColor = System.Drawing.SystemColors.Control
        Me.optTipo0.Cursor = System.Windows.Forms.Cursors.Default
        Me.optTipo0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTipo0.Location = New System.Drawing.Point(8, 17)
        Me.optTipo0.Name = "optTipo0"
        Me.optTipo0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optTipo0.Size = New System.Drawing.Size(298, 32)
        Me.optTipo0.TabIndex = 1
        Me.optTipo0.TabStop = true
        Me.optTipo0.Text = "Estado de Ganancias y Pérdidas por Función"
        Me.optTipo0.UseVisualStyleBackColor = false
        '
        'frmRepEstadosFinancieros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(393, 308)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MinimizeBox = false
        Me.Name = "frmRepEstadosFinancieros"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Estados Financieros"
        Me.Frame2.ResumeLayout(false)
        CType(Me.DTPicker_Fecha,System.ComponentModel.ISupportInitialize).EndInit
        Me.Frame1.ResumeLayout(false)
        Me.Frame3.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
#End Region 
End Class