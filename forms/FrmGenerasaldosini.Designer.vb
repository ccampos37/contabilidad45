<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmGenerasaldosini
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
    Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Ctr_AyudaCuenta As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerasaldosini))
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Ctr_AyudaCuenta = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Ctr_AyudaCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(168, 88)
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
        Me.Command1.Location = New System.Drawing.Point(40, 88)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 2
        Me.Command1.Text = "Aceptar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Ctr_AyudaCuenta
        '
        Me.Ctr_AyudaCuenta.Enabled = True
        Me.Ctr_AyudaCuenta.Location = New System.Drawing.Point(24, 48)
        Me.Ctr_AyudaCuenta.Name = "Ctr_AyudaCuenta"
        Me.Ctr_AyudaCuenta.OcxState = CType(resources.GetObject("Ctr_AyudaCuenta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_AyudaCuenta.Size = New System.Drawing.Size(323, 24)
        Me.Ctr_AyudaCuenta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Menu
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(321, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cuenta de Resultados para el actual ejercicio"
        '
        'FrmGenerasaldosini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(364, 154)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Ctr_AyudaCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmGenerasaldosini"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        CType(Me.Ctr_AyudaCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class