﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMntEstructuraGana_perd
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
        Me.TablasBasicas1 = New TablasBasicas.TablasBasicas()
        Me.SuspendLayout()
        '
        'TablasBasicas1
        '
        Me.TablasBasicas1.Location = New System.Drawing.Point(21, 20)
        Me.TablasBasicas1.Name = "TablasBasicas1"
        Me.TablasBasicas1.Size = New System.Drawing.Size(580, 445)
        Me.TablasBasicas1.TabIndex = 3
        '
        'FrmMntEstructuraGana_perd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 478)
        Me.Controls.Add(Me.TablasBasicas1)
        Me.Name = "FrmMntEstructuraGana_perd"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TablasBasicas1 As TablasBasicas.TablasBasicas
End Class
