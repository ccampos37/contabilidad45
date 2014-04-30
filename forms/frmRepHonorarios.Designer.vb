<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepHonorarios
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
    Public WithEvents axbCancelar As System.Windows.Forms.Button
	Public WithEvents axbAceptar As System.Windows.Forms.Button
	Public WithEvents CmbOrden As System.Windows.Forms.ComboBox
	Public WithEvents Ctr_Ayuda2 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepHonorarios))
        Me.axbCancelar = New System.Windows.Forms.Button()
        Me.axbAceptar = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.CmbOrden = New System.Windows.Forms.ComboBox()
        Me.Ctr_Ayuda2 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'axbCancelar
        '
        Me.axbCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.axbCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.axbCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.axbCancelar.Location = New System.Drawing.Point(210, 115)
        Me.axbCancelar.Name = "axbCancelar"
        Me.axbCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.axbCancelar.Size = New System.Drawing.Size(85, 24)
        Me.axbCancelar.TabIndex = 4
        Me.axbCancelar.Text = "&Cancelar"
        Me.axbCancelar.UseVisualStyleBackColor = False
        '
        'axbAceptar
        '
        Me.axbAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.axbAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.axbAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.axbAceptar.Location = New System.Drawing.Point(115, 115)
        Me.axbAceptar.Name = "axbAceptar"
        Me.axbAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.axbAceptar.Size = New System.Drawing.Size(85, 24)
        Me.axbAceptar.TabIndex = 3
        Me.axbAceptar.Text = "&Aceptar"
        Me.axbAceptar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.CmbOrden)
        Me.Frame1.Controls.Add(Me.Ctr_Ayuda2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(409, 108)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'CmbOrden
        '
        Me.CmbOrden.BackColor = System.Drawing.SystemColors.Window
        Me.CmbOrden.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOrden.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbOrden.Items.AddRange(New Object() {"Ordenar por Comprobante Contable", "Ordenar por Fecha de Emisión", "Ordenar por Número Recibo", "Ordenar por Nombre"})
        Me.CmbOrden.Location = New System.Drawing.Point(77, 10)
        Me.CmbOrden.Name = "CmbOrden"
        Me.CmbOrden.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbOrden.Size = New System.Drawing.Size(255, 21)
        Me.CmbOrden.TabIndex = 1
        '
        'Ctr_Ayuda2
        '
        Me.Ctr_Ayuda2.Enabled = True
        Me.Ctr_Ayuda2.Location = New System.Drawing.Point(76, 45)
        Me.Ctr_Ayuda2.Name = "Ctr_Ayuda2"
        Me.Ctr_Ayuda2.OcxState = CType(resources.GetObject("Ctr_Ayuda2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda2.Size = New System.Drawing.Size(331, 22)
        Me.Ctr_Ayuda2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(9, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ordenar por :"
        '
        'frmRepHonorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(412, 155)
        Me.Controls.Add(Me.axbCancelar)
        Me.Controls.Add(Me.axbAceptar)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmRepHonorarios"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Reporte de Honoraios"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class