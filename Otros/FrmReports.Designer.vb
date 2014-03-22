<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReports
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
        Me.CRVPresentacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVPresentacion
        '
        Me.CRVPresentacion.ActiveViewIndex = -1
        Me.CRVPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVPresentacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVPresentacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVPresentacion.Location = New System.Drawing.Point(0, 0)
        Me.CRVPresentacion.Name = "CRVPresentacion"
        Me.CRVPresentacion.Size = New System.Drawing.Size(533, 341)
        Me.CRVPresentacion.TabIndex = 0
        '
        'FrmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 341)
        Me.Controls.Add(Me.CRVPresentacion)
        Me.Name = "FrmReports"
        Me.Text = "FrmReports"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVPresentacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
