<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmMntIndicadorOportunidad
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
    Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Check1 As System.Windows.Forms.CheckBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents ListView2 As System.Windows.Forms.ListView
	Public WithEvents ListView1 As System.Windows.Forms.ListView
	Public WithEvents FrameCuentas As System.Windows.Forms.GroupBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Check1 = New System.Windows.Forms.CheckBox()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.FrameCuentas = New System.Windows.Forms.GroupBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.FrameCuentas.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Text2)
        Me.Frame1.Controls.Add(Me.Check1)
        Me.Frame1.Controls.Add(Me.Text1)
        Me.Frame1.Controls.Add(Me.FrameCuentas)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(793, 481)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Enabled = False
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(472, 16)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(145, 25)
        Me.Text2.TabIndex = 12
        '
        'Check1
        '
        Me.Check1.BackColor = System.Drawing.SystemColors.Control
        Me.Check1.CausesValidation = False
        Me.Check1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check1.Location = New System.Drawing.Point(664, 48)
        Me.Check1.Name = "Check1"
        Me.Check1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Check1.Size = New System.Drawing.Size(81, 13)
        Me.Check1.TabIndex = 11
        Me.Check1.Text = "Todos"
        Me.Check1.UseVisualStyleBackColor = False
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Enabled = False
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(88, 16)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(329, 25)
        Me.Text1.TabIndex = 7
        '
        'FrameCuentas
        '
        Me.FrameCuentas.BackColor = System.Drawing.SystemColors.Control
        Me.FrameCuentas.Controls.Add(Me.Frame2)
        Me.FrameCuentas.Controls.Add(Me.ListView2)
        Me.FrameCuentas.Controls.Add(Me.ListView1)
        Me.FrameCuentas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameCuentas.Location = New System.Drawing.Point(24, 48)
        Me.FrameCuentas.Name = "FrameCuentas"
        Me.FrameCuentas.Padding = New System.Windows.Forms.Padding(0)
        Me.FrameCuentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameCuentas.Size = New System.Drawing.Size(737, 433)
        Me.FrameCuentas.TabIndex = 1
        Me.FrameCuentas.TabStop = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Command2)
        Me.Frame2.Controls.Add(Me.Command1)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(176, 336)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(361, 81)
        Me.Frame2.TabIndex = 2
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Opciones"
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(200, 16)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(105, 41)
        Me.Command2.TabIndex = 4
        Me.Command2.Text = "Salir"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(24, 16)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(105, 41)
        Me.Command1.TabIndex = 3
        Me.Command1.Text = "Grabar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.Window
        Me.ListView2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView2.LabelEdit = True
        Me.ListView2.Location = New System.Drawing.Point(88, 104)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(2, 9)
        Me.ListView2.TabIndex = 5
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.CheckBoxes = True
        Me.ListView1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView1.LabelEdit = True
        Me.ListView1.Location = New System.Drawing.Point(8, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(705, 305)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(24, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Empresa"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(432, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "RUC"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(592, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'FrmMntIndicadorOportunidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(821, 502)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 31)
        Me.Name = "FrmMntIndicadorOportunidad"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Indicador de Oportunidad"
        Me.Frame1.ResumeLayout(False)
        Me.FrameCuentas.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class