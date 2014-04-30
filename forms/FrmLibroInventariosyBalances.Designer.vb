<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmLibroInventariosyBalances
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
    Public WithEvents Check1 As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Check1 = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Framecuentas = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Frame1.SuspendLayout
        Me.Frame2.SuspendLayout
        Me.Framecuentas.SuspendLayout
        Me.SuspendLayout
        '
        'Check1
        '
        Me.Check1.BackColor = System.Drawing.SystemColors.Control
        Me.Check1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check1.Location = New System.Drawing.Point(31, 12)
        Me.Check1.Name = "Check1"
        Me.Check1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Check1.Size = New System.Drawing.Size(69, 21)
        Me.Check1.TabIndex = 7
        Me.Check1.Text = "Imprimir"
        Me.Check1.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Framecuentas)
        Me.Frame1.Controls.Add(Me.Frame2)
        Me.Frame1.Controls.Add(Me.Check1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(735, 477)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Command1)
        Me.Frame2.Controls.Add(Me.Command2)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(567, 34)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(143, 305)
        Me.Frame2.TabIndex = 8
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Opciones"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(24, 59)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(116, 48)
        Me.Command1.TabIndex = 4
        Me.Command1.Text = "Impprimir"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(24, 178)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(116, 48)
        Me.Command2.TabIndex = 3
        Me.Command2.Text = "Salir"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Framecuentas
        '
        Me.Framecuentas.Controls.Add(Me.ListView1)
        Me.Framecuentas.Location = New System.Drawing.Point(14, 39)
        Me.Framecuentas.Name = "Framecuentas"
        Me.Framecuentas.Size = New System.Drawing.Size(547, 300)
        Me.Framecuentas.TabIndex = 5
        Me.Framecuentas.TabStop = False
        Me.Framecuentas.Text = "Libros"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.CheckBoxes = True
        Me.ListView1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView1.LabelEdit = True
        Me.ListView1.Location = New System.Drawing.Point(17, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(524, 275)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = false
        '
        'FrmLibroInventariosyBalances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(759, 501)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmLibroInventariosyBalances"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Libro de Inventarios y Balances"
        Me.Frame1.ResumeLayout(false)
        Me.Frame2.ResumeLayout(false)
        Me.Framecuentas.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Command2 As System.Windows.Forms.Button
    Friend WithEvents Framecuentas As System.Windows.Forms.GroupBox
    Public WithEvents ListView1 As System.Windows.Forms.ListView
#End Region 
End Class