<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepMovimientoCuentas
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
	Public WithEvents cmdAceptar As System.Windows.Forms.Button
	Public WithEvents txtCuenta As AxTextFer.AxTxFer
	Public WithEvents txtNivel As AxTextFer.AxTxFer
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepMovimientoCuentas))
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.txtCuenta = New AxTextFer.AxTxFer()
        Me.txtNivel = New AxTextFer.AxTxFer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(189, 124)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(84, 24)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Location = New System.Drawing.Point(86, 124)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAceptar.Size = New System.Drawing.Size(78, 24)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'txtCuenta
        '
        Me.txtCuenta.Enabled = True
        Me.txtCuenta.Location = New System.Drawing.Point(58, 31)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.OcxState = CType(resources.GetObject("txtCuenta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txtCuenta.Size = New System.Drawing.Size(281, 22)
        Me.txtCuenta.TabIndex = 1
        '
        'txtNivel
        '
        Me.txtNivel.Enabled = True
        Me.txtNivel.Location = New System.Drawing.Point(58, 65)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.OcxState = CType(resources.GetObject("txtNivel.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txtNivel.Size = New System.Drawing.Size(38, 21)
        Me.txtNivel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(11, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nivel"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(10, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta:"
        '
        'frmRepMovimientoCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(358, 174)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtNivel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmRepMovimientoCuentas"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Movimientos Cuentas"
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNivel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class