<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMntTipocambio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mTablaBasica1 = New TablasBasicas.TablasBasicas()
        Me.SuspendLayout
        '
        'mTablaBasica1
        '
        Me.mTablaBasica1.Location = New System.Drawing.Point(51, 12)
        Me.mTablaBasica1.Name = "mTablaBasica1"
        Me.mTablaBasica1.Size = New System.Drawing.Size(473, 425)
        Me.mTablaBasica1.TabIndex = 2
        '
        'FrmMntTipocambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 409)
        Me.Controls.Add(Me.mTablaBasica1)
        Me.Name = "FrmMntTipocambio"
        Me.Text = "FrmMntTipocambio"
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents mTablaBasica1 As TablasBasicas.TablasBasicas
End Class
