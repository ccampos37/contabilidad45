<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmContabCobrar
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
    Public cmdg_archivoOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdProcesar As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdg_archivoOpen = New System.Windows.Forms.OpenFileDialog()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.CmdProcesar = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.DTPPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancelar.Location = New System.Drawing.Point(223, 131)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(102, 45)
        Me.CmdCancelar.TabIndex = 7
        Me.CmdCancelar.Text = "&Cancelar"
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'CmdProcesar
        '
        Me.CmdProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdProcesar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdProcesar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdProcesar.Location = New System.Drawing.Point(12, 131)
        Me.CmdProcesar.Name = "CmdProcesar"
        Me.CmdProcesar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdProcesar.Size = New System.Drawing.Size(104, 45)
        Me.CmdProcesar.TabIndex = 6
        Me.CmdProcesar.Text = "&Procesar"
        Me.CmdProcesar.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.DTPPeriodo)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(12, 33)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(313, 79)
        Me.Frame2.TabIndex = 5
        Me.Frame2.TabStop = False
        '
        'DTPPeriodo
        '
        Me.DTPPeriodo.CustomFormat = "MMMM yyyy"
        Me.DTPPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPPeriodo.Location = New System.Drawing.Point(110, 26)
        Me.DTPPeriodo.Name = "DTPPeriodo"
        Me.DTPPeriodo.Size = New System.Drawing.Size(130, 20)
        Me.DTPPeriodo.TabIndex = 10
        Me.DTPPeriodo.Value = New Date(2014, 4, 30, 16, 54, 8, 0)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(41, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Periodo :"
        '
        'FrmContabCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(367, 236)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdProcesar)
        Me.Controls.Add(Me.Frame2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 22)
        Me.Name = "FrmContabCobrar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importacion de Datos y Generacion de Asientos de Cobranzas"
        Me.Frame2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTPPeriodo As System.Windows.Forms.DateTimePicker
    Public WithEvents Label1 As System.Windows.Forms.Label
#End Region
End Class