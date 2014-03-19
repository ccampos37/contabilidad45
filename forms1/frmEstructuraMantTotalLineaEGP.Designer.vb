<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEstructuraMantTotalLineaEGP
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
	Public ToolTip1 As System.Windows.Forms.ToolTip
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mTablaBasica1 = New TablasBasicas.TablasBasicas
        Me.SuspendLayout()
        '
        'mTablaBasica1
        '
        Me.mTablaBasica1.Location = New System.Drawing.Point(0, 4)
        Me.mTablaBasica1.Name = "mTablaBasica1"
        Me.mTablaBasica1.Size = New System.Drawing.Size(473, 425)
        Me.mTablaBasica1.TabIndex = 0
        '
        'frmEstructuraMantTotalLineaEGP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(476, 432)
        Me.Controls.Add(Me.mTablaBasica1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEstructuraMantTotalLineaEGP"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Totalizador Ganacias y Pérdidas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mTablaBasica1 As TablasBasicas.TablasBasicas
#End Region 
End Class