<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepPlantillaSubAsientos
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
	Public WithEvents Ctr_Ayuda2 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepPlantillaSubAsientos))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayuda2 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Ctr_Ayuda1)
        Me.Frame1.Controls.Add(Me.Ctr_Ayuda2)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 22)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(381, 103)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Seleccionar"
        '
        'Ctr_Ayuda1
        '
        Me.Ctr_Ayuda1.Enabled = True
        Me.Ctr_Ayuda1.Location = New System.Drawing.Point(15, 26)
        Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
        Me.Ctr_Ayuda1.OcxState = CType(resources.GetObject("Ctr_Ayuda1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda1.Size = New System.Drawing.Size(349, 31)
        Me.Ctr_Ayuda1.TabIndex = 3
        '
        'Ctr_Ayuda2
        '
        Me.Ctr_Ayuda2.Enabled = True
        Me.Ctr_Ayuda2.Location = New System.Drawing.Point(15, 61)
        Me.Ctr_Ayuda2.Name = "Ctr_Ayuda2"
        Me.Ctr_Ayuda2.OcxState = CType(resources.GetObject("Ctr_Ayuda2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda2.Size = New System.Drawing.Size(348, 31)
        Me.Ctr_Ayuda2.TabIndex = 4
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(200, 165)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(81, 24)
        Me.cmdBotones1.TabIndex = 1
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(106, 164)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(81, 24)
        Me.cmdBotones0.TabIndex = 0
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = False
        '
        'frmRepPlantillaSubAsientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(386, 213)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmRepPlantillaSubAsientos"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Reporte de Plantillas de SubAsientos"
        Me.Frame1.ResumeLayout(False)
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class