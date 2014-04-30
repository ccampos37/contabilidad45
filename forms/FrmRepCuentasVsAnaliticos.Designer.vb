<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmRepCuentasVsAnaliticos
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
    Public WithEvents cmbNivel As System.Windows.Forms.ComboBox
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbNivel = New System.Windows.Forms.ComboBox()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbNivel
        '
        Me.cmbNivel.BackColor = System.Drawing.SystemColors.Window
        Me.cmbNivel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbNivel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbNivel.Location = New System.Drawing.Point(110, 26)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNivel.Size = New System.Drawing.Size(128, 21)
        Me.cmbNivel.TabIndex = 2
        Me.cmbNivel.Text = "Combo1"
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAceptar.Location = New System.Drawing.Point(60, 70)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptar.Size = New System.Drawing.Size(91, 24)
        Me.CmdAceptar.TabIndex = 1
        Me.CmdAceptar.Text = "&Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancelar.Location = New System.Drawing.Point(150, 70)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(91, 24)
        Me.CmdCancelar.TabIndex = 0
        Me.CmdCancelar.Text = "&Cancelar"
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        '_Label1_1
        '
        Me._Label1_1.AutoSize = True
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(68, 32)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(37, 13)
        Me._Label1_1.TabIndex = 3
        Me._Label1_1.Text = "Nivel :"
        '
        'FrmRepCuentasVsAnaliticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(300, 116)
        Me.Controls.Add(Me.cmbNivel)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me._Label1_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmRepCuentasVsAnaliticos"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ctas. Contables. vs Ctas. Analisis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class