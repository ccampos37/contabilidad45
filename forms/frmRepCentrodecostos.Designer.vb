<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepCentrodeCostos
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
    Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents Option4 As System.Windows.Forms.RadioButton
	Public WithEvents Option3 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Option1 As System.Windows.Forms.RadioButton
	Public WithEvents Option2 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents cmdCancelar As System.Windows.Forms.Button
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepCentrodeCostos))
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.DTPicker1 = New AxMSComCtl2.AxDTPicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Option4 = New System.Windows.Forms.RadioButton()
        Me.Option3 = New System.Windows.Forms.RadioButton()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Frame3.SuspendLayout()
        CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.DTPicker1)
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(24, 0)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(361, 49)
        Me.Frame3.TabIndex = 8
        Me.Frame3.TabStop = False
        '
        'DTPicker1
        '
        Me.DTPicker1.Location = New System.Drawing.Point(94, 16)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPicker1.Size = New System.Drawing.Size(127, 19)
        Me.DTPicker1.TabIndex = 9
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
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mes :"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Option4)
        Me.Frame2.Controls.Add(Me.Option3)
        Me.Frame2.ForeColor = System.Drawing.Color.Red
        Me.Frame2.Location = New System.Drawing.Point(208, 48)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(177, 77)
        Me.Frame2.TabIndex = 5
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Tipo de reporte"
        '
        'Option4
        '
        Me.Option4.BackColor = System.Drawing.SystemColors.Control
        Me.Option4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option4.Location = New System.Drawing.Point(24, 48)
        Me.Option4.Name = "Option4"
        Me.Option4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option4.Size = New System.Drawing.Size(81, 17)
        Me.Option4.TabIndex = 7
        Me.Option4.TabStop = True
        Me.Option4.Text = "Resumido"
        Me.Option4.UseVisualStyleBackColor = False
        '
        'Option3
        '
        Me.Option3.BackColor = System.Drawing.SystemColors.Control
        Me.Option3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option3.Location = New System.Drawing.Point(24, 24)
        Me.Option3.Name = "Option3"
        Me.Option3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option3.Size = New System.Drawing.Size(81, 17)
        Me.Option3.TabIndex = 6
        Me.Option3.TabStop = True
        Me.Option3.Text = "Detallado"
        Me.Option3.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Option1)
        Me.Frame1.Controls.Add(Me.Option2)
        Me.Frame1.ForeColor = System.Drawing.Color.Red
        Me.Frame1.Location = New System.Drawing.Point(24, 48)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(177, 77)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Ordenado Por : "
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
        Me.Option1.TabIndex = 4
        Me.Option1.TabStop = True
        Me.Option1.Text = "Centro Costo / Cuenta"
        Me.Option1.UseVisualStyleBackColor = False
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
        Me.Option2.TabIndex = 3
        Me.Option2.TabStop = True
        Me.Option2.Text = "Cuenta / Ccentro Costo"
        Me.Option2.UseVisualStyleBackColor = False
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAceptar.Location = New System.Drawing.Point(111, 132)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptar.Size = New System.Drawing.Size(85, 24)
        Me.CmdAceptar.TabIndex = 1
        Me.CmdAceptar.Text = "&Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(201, 132)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(85, 24)
        Me.cmdCancelar.TabIndex = 0
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'frmRepCentrodeCostos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(396, 161)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepCentrodeCostos"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class