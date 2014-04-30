<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepCentrodeCostosAcumulado
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
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents Option2 As System.Windows.Forms.RadioButton
	Public WithEvents Option1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Option3 As System.Windows.Forms.RadioButton
	Public WithEvents Option4 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepCentrodeCostosAcumulado))
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Option3 = New System.Windows.Forms.RadioButton()
        Me.Option4 = New System.Windows.Forms.RadioButton()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.DTPicker1 = New AxMSComCtl2.AxDTPicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(183, 150)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(85, 24)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAceptar.Location = New System.Drawing.Point(93, 150)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptar.Size = New System.Drawing.Size(85, 24)
        Me.CmdAceptar.TabIndex = 9
        Me.CmdAceptar.Text = "&Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Option2)
        Me.Frame1.Controls.Add(Me.Option1)
        Me.Frame1.ForeColor = System.Drawing.Color.Red
        Me.Frame1.Location = New System.Drawing.Point(201, 69)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(177, 77)
        Me.Frame1.TabIndex = 6
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Ordenado Por : "
        '
        'Option2
        '
        Me.Option2.BackColor = System.Drawing.SystemColors.Control
        Me.Option2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option2.Location = New System.Drawing.Point(24, 48)
        Me.Option2.Name = "Option2"
        Me.Option2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option2.Size = New System.Drawing.Size(137, 17)
        Me.Option2.TabIndex = 8
        Me.Option2.TabStop = True
        Me.Option2.Text = "Centro Costo"
        Me.Option2.UseVisualStyleBackColor = False
        '
        'Option1
        '
        Me.Option1.BackColor = System.Drawing.SystemColors.Control
        Me.Option1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option1.Location = New System.Drawing.Point(24, 24)
        Me.Option1.Name = "Option1"
        Me.Option1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option1.Size = New System.Drawing.Size(145, 17)
        Me.Option1.TabIndex = 7
        Me.Option1.TabStop = True
        Me.Option1.Text = "Cuenta / Ccentro Costo"
        Me.Option1.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Option3)
        Me.Frame2.Controls.Add(Me.Option4)
        Me.Frame2.ForeColor = System.Drawing.Color.Red
        Me.Frame2.Location = New System.Drawing.Point(7, 66)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(177, 77)
        Me.Frame2.TabIndex = 3
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Tipo de reporte"
        '
        'Option3
        '
        Me.Option3.BackColor = System.Drawing.SystemColors.Control
        Me.Option3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option3.Location = New System.Drawing.Point(24, 24)
        Me.Option3.Name = "Option3"
        Me.Option3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option3.Size = New System.Drawing.Size(121, 17)
        Me.Option3.TabIndex = 5
        Me.Option3.TabStop = True
        Me.Option3.Text = "Mensual/Acumulado"
        Me.Option3.UseVisualStyleBackColor = False
        '
        'Option4
        '
        Me.Option4.BackColor = System.Drawing.SystemColors.Control
        Me.Option4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option4.Location = New System.Drawing.Point(27, 48)
        Me.Option4.Name = "Option4"
        Me.Option4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option4.Size = New System.Drawing.Size(129, 17)
        Me.Option4.TabIndex = 4
        Me.Option4.TabStop = True
        Me.Option4.Text = "Mensualizado/Anual"
        Me.Option4.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.DTPicker1)
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(6, 18)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(361, 49)
        Me.Frame3.TabIndex = 0
        Me.Frame3.TabStop = False
        '
        'DTPicker1
        '
        Me.DTPicker1.Location = New System.Drawing.Point(94, 16)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPicker1.Size = New System.Drawing.Size(127, 19)
        Me.DTPicker1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(32, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mes :"
        '
        'frmRepCentrodeCostosAcumulado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(388, 192)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmRepCentrodeCostosAcumulado"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Acumulados de Cuentas de gastos"
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class