<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmRepCompras
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
		'Éste es un formulario MDI secundario.
		'Este código simula la funcionalidad de VB6 
		' de cargar automáticamente
		' y mostrar el formulario primario de
		' un MDI secundario.
		Me.MDIParent = Contabilidad.MDIPrincipal
		Contabilidad.MDIPrincipal.Show
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
    Public WithEvents axBCancelar As System.Windows.Forms.Button
	Public WithEvents axbAceptar As System.Windows.Forms.Button
	Public WithEvents CmbOrden As System.Windows.Forms.ComboBox
	Public WithEvents CmbTipo As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.axBCancelar = New System.Windows.Forms.Button()
        Me.axbAceptar = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.CmbOrden = New System.Windows.Forms.ComboBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'axBCancelar
        '
        Me.axBCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.axBCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.axBCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.axBCancelar.Location = New System.Drawing.Point(180, 84)
        Me.axBCancelar.Name = "axBCancelar"
        Me.axBCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.axBCancelar.Size = New System.Drawing.Size(85, 24)
        Me.axBCancelar.TabIndex = 6
        Me.axBCancelar.Text = "&Cancelar"
        Me.axBCancelar.UseVisualStyleBackColor = False
        '
        'axbAceptar
        '
        Me.axbAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.axbAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.axbAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.axbAceptar.Location = New System.Drawing.Point(90, 84)
        Me.axbAceptar.Name = "axbAceptar"
        Me.axbAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.axbAceptar.Size = New System.Drawing.Size(85, 24)
        Me.axbAceptar.TabIndex = 5
        Me.axbAceptar.Text = "&Aceptar"
        Me.axbAceptar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.CmbOrden)
        Me.Frame1.Controls.Add(Me.CmbTipo)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(3, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(345, 77)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'CmbOrden
        '
        Me.CmbOrden.BackColor = System.Drawing.SystemColors.Window
        Me.CmbOrden.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOrden.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbOrden.Items.AddRange(New Object() {"Ordenar por Fecha de Documento", "Ordenar por Comprobante contable", "Ordenar por Numero Auxiliar (Provisión)"})
        Me.CmbOrden.Location = New System.Drawing.Point(83, 43)
        Me.CmbOrden.Name = "CmbOrden"
        Me.CmbOrden.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbOrden.Size = New System.Drawing.Size(255, 21)
        Me.CmbOrden.TabIndex = 4
        '
        'CmbTipo
        '
        Me.CmbTipo.BackColor = System.Drawing.SystemColors.Window
        Me.CmbTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbTipo.Items.AddRange(New Object() {"Agrupado por Documento", "Agrupado por Proveedor", "Presentacion Sunat"})
        Me.CmbTipo.Location = New System.Drawing.Point(158, 17)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbTipo.Size = New System.Drawing.Size(180, 21)
        Me.CmbTipo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ordenar por :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de Registro de Compras :"
        '
        'FrmRepCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(351, 113)
        Me.Controls.Add(Me.axBCancelar)
        Me.Controls.Add(Me.axbAceptar)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRepCompras"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Registro de Compras"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class