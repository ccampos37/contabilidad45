<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepCajaBancos
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
    Public WithEvents Ctr_Ayuda1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Aceptar As System.Windows.Forms.Button
    Public WithEvents Cancelar As System.Windows.Forms.Button
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepCajaBancos))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Ctr_Ayuda1)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(1, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(415, 88)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        '
        'Ctr_Ayuda1
        '
        Me.Ctr_Ayuda1.Enabled = True
        Me.Ctr_Ayuda1.Location = New System.Drawing.Point(57, 31)
        Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
        Me.Ctr_Ayuda1.OcxState = CType(resources.GetObject("Ctr_Ayuda1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda1.Size = New System.Drawing.Size(352, 24)
        Me.Ctr_Ayuda1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cuenta:"
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Aceptar.Location = New System.Drawing.Point(115, 115)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Aceptar.Size = New System.Drawing.Size(85, 24)
        Me.Aceptar.TabIndex = 1
        Me.Aceptar.Text = "&Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cancelar.Location = New System.Drawing.Point(210, 115)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cancelar.Size = New System.Drawing.Size(85, 24)
        Me.Cancelar.TabIndex = 0
        Me.Cancelar.Text = "&Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'frmRepCajaBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(418, 158)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Cancelar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmRepCajaBancos"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Reporte de Caja y Bancos"
        Me.Frame1.ResumeLayout(False)
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class