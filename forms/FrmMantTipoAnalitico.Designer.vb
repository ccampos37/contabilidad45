<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmMantTipoAnalitico
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
	Public ToolTip1 As System.Windows.Forms.ToolTip
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TablasBasicas1 = New TablasBasicas.TablasBasicas()
        Me.SuspendLayout
        '
        'TablasBasicas1
        '
        Me.TablasBasicas1.Location = New System.Drawing.Point(2, 12)
        Me.TablasBasicas1.Name = "TablasBasicas1"
        Me.TablasBasicas1.Size = New System.Drawing.Size(568, 425)
        Me.TablasBasicas1.TabIndex = 2
        '
        'FrmMantTipoAnalitico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(582, 466)
        Me.Controls.Add(Me.TablasBasicas1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 31)
        Me.Name = "FrmMantTipoAnalitico"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TablasBasicas1 As TablasBasicas.TablasBasicas
#End Region 
End Class