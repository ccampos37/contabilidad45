<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmLibroRegistrodeventas
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
    Public WithEvents CmbOrden As System.Windows.Forms.ComboBox
	Public WithEvents CmbTipo As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents axbAceptar As System.Windows.Forms.Button
	Public WithEvents axBCancelar As System.Windows.Forms.Button
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.CmbOrden = New System.Windows.Forms.ComboBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.axbAceptar = New System.Windows.Forms.Button()
        Me.axBCancelar = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.CmbOrden)
        Me.Frame1.Controls.Add(Me.CmbTipo)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(32, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(345, 77)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        '
        'CmbOrden
        '
        Me.CmbOrden.BackColor = System.Drawing.SystemColors.Window
        Me.CmbOrden.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOrden.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbOrden.Items.AddRange(New Object() {"Ordenar por Número Documento", "Ordenar por Comprobante contable", "Ordernar por Fecha de Emisión"})
        Me.CmbOrden.Location = New System.Drawing.Point(83, 42)
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
        Me.CmbTipo.Items.AddRange(New Object() {"Impresion Libros"})
        Me.CmbTipo.Location = New System.Drawing.Point(158, 17)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbTipo.Size = New System.Drawing.Size(180, 21)
        Me.CmbTipo.TabIndex = 3
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
        Me.Label2.TabIndex = 6
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
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipo de Registro de Ventas"
        '
        'axbAceptar
        '
        Me.axbAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.axbAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.axbAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.axbAceptar.Location = New System.Drawing.Point(122, 107)
        Me.axbAceptar.Name = "axbAceptar"
        Me.axbAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.axbAceptar.Size = New System.Drawing.Size(81, 24)
        Me.axbAceptar.TabIndex = 1
        Me.axbAceptar.Text = "&Aceptar"
        Me.axbAceptar.UseVisualStyleBackColor = False
        '
        'axBCancelar
        '
        Me.axBCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.axBCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.axBCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.axBCancelar.Location = New System.Drawing.Point(209, 107)
        Me.axBCancelar.Name = "axBCancelar"
        Me.axBCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.axBCancelar.Size = New System.Drawing.Size(81, 24)
        Me.axBCancelar.TabIndex = 0
        Me.axBCancelar.Text = "&Cancelar"
        Me.axBCancelar.UseVisualStyleBackColor = False
        '
        'FrmLibroRegistrodeventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(431, 173)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.axbAceptar)
        Me.Controls.Add(Me.axBCancelar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmLibroRegistrodeventas"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class