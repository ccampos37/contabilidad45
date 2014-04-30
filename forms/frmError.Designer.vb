<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmError
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
    Public WithEvents RichError As System.Windows.Forms.RichTextBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RichError = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichError
        '
        Me.RichError.Location = New System.Drawing.Point(7, 10)
        Me.RichError.Name = "RichError"
        Me.RichError.Size = New System.Drawing.Size(348, 252)
        Me.RichError.TabIndex = 0
        Me.RichError.Text = ""
        '
        'frmError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(361, 276)
        Me.Controls.Add(Me.RichError)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmError"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Error"
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class