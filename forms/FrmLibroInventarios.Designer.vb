<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmLibroInventarios
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
    Public WithEvents Combo4 As System.Windows.Forms.ComboBox
	Public WithEvents Check2 As System.Windows.Forms.CheckBox
	Public WithEvents Check1 As System.Windows.Forms.CheckBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _Label1_3 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Combo4 = New System.Windows.Forms.ComboBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Check2 = New System.Windows.Forms.CheckBox()
        Me.Check1 = New System.Windows.Forms.CheckBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me.Frame3.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.White
        Me.Frame3.Controls.Add(Me.Combo4)
        Me.Frame3.Controls.Add(Me.Frame1)
        Me.Frame3.Controls.Add(Me.Frame2)
        Me.Frame3.Controls.Add(Me._Label1_3)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(16, 24)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(513, 265)
        Me.Frame3.TabIndex = 0
        Me.Frame3.TabStop = False
        '
        'Combo4
        '
        Me.Combo4.BackColor = System.Drawing.SystemColors.Window
        Me.Combo4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Combo4.Location = New System.Drawing.Point(122, 136)
        Me.Combo4.Name = "Combo4"
        Me.Combo4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo4.Size = New System.Drawing.Size(180, 21)
        Me.Combo4.TabIndex = 7
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.Check2)
        Me.Frame1.Controls.Add(Me.Check1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(40, 24)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(369, 97)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        '
        'Check2
        '
        Me.Check2.BackColor = System.Drawing.Color.White
        Me.Check2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check2.Location = New System.Drawing.Point(32, 56)
        Me.Check2.Name = "Check2"
        Me.Check2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Check2.Size = New System.Drawing.Size(257, 33)
        Me.Check2.TabIndex = 6
        Me.Check2.Text = "Detalle de los movimeintos VALORIZADOS"
        Me.Check2.UseVisualStyleBackColor = False
        '
        'Check1
        '
        Me.Check1.BackColor = System.Drawing.Color.White
        Me.Check1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check1.Location = New System.Drawing.Point(32, 24)
        Me.Check1.Name = "Check1"
        Me.Check1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Check1.Size = New System.Drawing.Size(241, 33)
        Me.Check1.TabIndex = 5
        Me.Check1.Text = "Detalle de los movimientos FISICOS"
        Me.Check1.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.Command2)
        Me.Frame2.Controls.Add(Me.Command1)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(88, 176)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(265, 73)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(144, 24)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(81, 33)
        Me.Command2.TabIndex = 3
        Me.Command2.Text = "Salir"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(16, 24)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 2
        Me.Command1.Text = "Imprimir"
        Me.Command1.UseVisualStyleBackColor = False
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = True
        Me._Label1_3.BackColor = System.Drawing.Color.Transparent
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.ForeColor = System.Drawing.Color.Black
        Me._Label1_3.Location = New System.Drawing.Point(48, 139)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(66, 13)
        Me._Label1_3.TabIndex = 8
        Me._Label1_3.Text = "Pto.  Venta :"
        '
        'FrmLibroInventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(555, 306)
        Me.Controls.Add(Me.Frame3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmLibroInventarios"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
         Me.ResumeLayout(False)

    End Sub
#End Region 
End Class