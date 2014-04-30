<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._cmdBotones_1 = New System.Windows.Forms.Button()
        Me.CmdImprimir = New System.Windows.Forms.Button()
        Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.optTipo = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.Jck_Txt1 = New Jck_txt.Jck_Txt()
        CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_cmdBotones_1
        '
        Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones.SetIndex(Me._cmdBotones_1, CType(1, Short))
        Me._cmdBotones_1.Location = New System.Drawing.Point(262, 48)
        Me._cmdBotones_1.Name = "_cmdBotones_1"
        Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_1.Size = New System.Drawing.Size(89, 25)
        Me._cmdBotones_1.TabIndex = 11
        Me._cmdBotones_1.Text = "&Cancelar"
        Me._cmdBotones_1.UseVisualStyleBackColor = False
        '
        'CmdImprimir
        '
        Me.CmdImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.CmdImprimir.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones.SetIndex(Me.CmdImprimir, CType(0, Short))
        Me.CmdImprimir.Location = New System.Drawing.Point(107, 48)
        Me.CmdImprimir.Name = "CmdImprimir"
        Me.CmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdImprimir.Size = New System.Drawing.Size(89, 25)
        Me.CmdImprimir.TabIndex = 10
        Me.CmdImprimir.Text = "&Aceptar"
        Me.CmdImprimir.UseVisualStyleBackColor = False
        '
        'Jck_Txt1
        '
        Me.Jck_Txt1.decimales = 0
        Me.Jck_Txt1.formato = "99999"
        Me.Jck_Txt1.Location = New System.Drawing.Point(6, 86)
        Me.Jck_Txt1.longitud = 5
        Me.Jck_Txt1.Name = "Jck_Txt1"
        Me.Jck_Txt1.negativos = True
        Me.Jck_Txt1.Size = New System.Drawing.Size(112, 20)
        Me.Jck_Txt1.TabIndex = 12
        Me.Jck_Txt1.tipoCaracter = 1
        Me.Jck_Txt1.tipoletra = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 118)
        Me.Controls.Add(Me.Jck_Txt1)
        Me.Controls.Add(Me._cmdBotones_1)
        Me.Controls.Add(Me.CmdImprimir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
    Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents CmdImprimir As System.Windows.Forms.Button
    Public WithEvents optTipo As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    Friend WithEvents PerformanceCounter1 As System.Diagnostics.PerformanceCounter
    Friend WithEvents Jck_Txt1 As Jck_txt.Jck_Txt
End Class
