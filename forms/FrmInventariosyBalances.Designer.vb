<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmInventariosyBalances
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
    Public WithEvents Option1 As System.Windows.Forms.RadioButton
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Option3 As System.Windows.Forms.RadioButton
	Public WithEvents Option2 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Option3 = New System.Windows.Forms.RadioButton()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Option1)
        Me.Frame1.Controls.Add(Me.Command2)
        Me.Frame1.Controls.Add(Me.Command1)
        Me.Frame1.Controls.Add(Me.Option3)
        Me.Frame1.Controls.Add(Me.Option2)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(40, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(417, 177)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'Option1
        '
        Me.Option1.BackColor = System.Drawing.SystemColors.Control
        Me.Option1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option1.Location = New System.Drawing.Point(48, 24)
        Me.Option1.Name = "Option1"
        Me.Option1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option1.Size = New System.Drawing.Size(81, 33)
        Me.Option1.TabIndex = 5
        Me.Option1.TabStop = True
        Me.Option1.Text = "Analitico"
        Me.Option1.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(224, 88)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(105, 49)
        Me.Command2.TabIndex = 4
        Me.Command2.Text = "Salir"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(72, 88)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(105, 49)
        Me.Command1.TabIndex = 3
        Me.Command1.Text = "Imprimir"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Option3
        '
        Me.Option3.BackColor = System.Drawing.SystemColors.Control
        Me.Option3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option3.Location = New System.Drawing.Point(304, 24)
        Me.Option3.Name = "Option3"
        Me.Option3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option3.Size = New System.Drawing.Size(81, 33)
        Me.Option3.TabIndex = 2
        Me.Option3.TabStop = True
        Me.Option3.Text = "Resumido"
        Me.Option3.UseVisualStyleBackColor = False
        '
        'Option2
        '
        Me.Option2.BackColor = System.Drawing.SystemColors.Control
        Me.Option2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option2.Location = New System.Drawing.Point(192, 24)
        Me.Option2.Name = "Option2"
        Me.Option2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option2.Size = New System.Drawing.Size(81, 33)
        Me.Option2.TabIndex = 1
        Me.Option2.TabStop = True
        Me.Option2.Text = "Detalaldo"
        Me.Option2.UseVisualStyleBackColor = False
        '
        'FrmInventariosyBalances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(471, 222)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmInventariosyBalances"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Inventarios y Balances"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class