<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmContabPagar
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
    Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdProcesar As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents CmdArchivo As System.Windows.Forms.Button
    Public cmdg_archivoOpen As System.Windows.Forms.OpenFileDialog
    Public WithEvents _Frame1_0 As System.Windows.Forms.GroupBox
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._Frame1_0 = New System.Windows.Forms.GroupBox()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.CmdProcesar = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.DTPPerido = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdArchivo = New System.Windows.Forms.Button()
        Me.cmdg_archivoOpen = New System.Windows.Forms.OpenFileDialog()
        Me._Frame1_0.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Frame1_0
        '
        Me._Frame1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Frame1_0.Controls.Add(Me.CmdCancelar)
        Me._Frame1_0.Controls.Add(Me.CmdProcesar)
        Me._Frame1_0.Controls.Add(Me.Frame2)
        Me._Frame1_0.Controls.Add(Me.CmdArchivo)
        Me._Frame1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame1_0.Location = New System.Drawing.Point(16, 24)
        Me._Frame1_0.Name = "_Frame1_0"
        Me._Frame1_0.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame1_0.Size = New System.Drawing.Size(266, 241)
        Me._Frame1_0.TabIndex = 0
        Me._Frame1_0.TabStop = False
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancelar.Location = New System.Drawing.Point(98, 143)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(116, 45)
        Me.CmdCancelar.TabIndex = 9
        Me.CmdCancelar.Text = "&Cancelar"
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'CmdProcesar
        '
        Me.CmdProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdProcesar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdProcesar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdProcesar.Location = New System.Drawing.Point(-18, 143)
        Me.CmdProcesar.Name = "CmdProcesar"
        Me.CmdProcesar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdProcesar.Size = New System.Drawing.Size(116, 45)
        Me.CmdProcesar.TabIndex = 8
        Me.CmdProcesar.Text = "&Procesar"
        Me.CmdProcesar.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.DTPPerido)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(3, 24)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(210, 85)
        Me.Frame2.TabIndex = 5
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Periodo de Proceso"
        '
        'DTPPerido
        '
        Me.DTPPerido.CustomFormat = "MMMM yyyy"
        Me.DTPPerido.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPPerido.Location = New System.Drawing.Point(11, 13)
        Me.DTPPerido.Name = "DTPPerido"
        Me.DTPPerido.Size = New System.Drawing.Size(200, 20)
        Me.DTPPerido.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Periodo :"
        '
        'CmdArchivo
        '
        Me.CmdArchivo.BackColor = System.Drawing.SystemColors.Control
        Me.CmdArchivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdArchivo.Enabled = False
        Me.CmdArchivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdArchivo.Location = New System.Drawing.Point(463, 116)
        Me.CmdArchivo.Name = "CmdArchivo"
        Me.CmdArchivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdArchivo.Size = New System.Drawing.Size(25, 23)
        Me.CmdArchivo.TabIndex = 4
        Me.CmdArchivo.Text = "..."
        Me.CmdArchivo.UseVisualStyleBackColor = False
        '
        'FrmContabPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(302, 279)
        Me.Controls.Add(Me._Frame1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmContabPagar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilizacion PAGAR"
        Me._Frame1_0.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTPPerido As System.Windows.Forms.DateTimePicker
#End Region
End Class