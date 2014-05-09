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
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.Jck_Txt1 = New Jck_txt.Jck_Txt()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_cmdBotones_1
        '
        Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdBotones_1.Location = New System.Drawing.Point(365, 12)
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
        Me.CmdImprimir.Location = New System.Drawing.Point(12, 12)
        Me.CmdImprimir.Name = "CmdImprimir"
        Me.CmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdImprimir.Size = New System.Drawing.Size(89, 25)
        Me.CmdImprimir.TabIndex = 10
        Me.CmdImprimir.Text = "&Aceptar"
        Me.CmdImprimir.UseVisualStyleBackColor = False
        '
        'Jck_Txt1
        '
        Me.Jck_Txt1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Jck_Txt1.BackColor = System.Drawing.Color.White
        Me.Jck_Txt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Jck_Txt1.decimales = 2
        Me.Jck_Txt1.formato = "9,999,999.99"
        Me.Jck_Txt1.Location = New System.Drawing.Point(142, 17)
        Me.Jck_Txt1.longitud = 12
        Me.Jck_Txt1.Name = "Jck_Txt1"
        Me.Jck_Txt1.negativos = False
        Me.Jck_Txt1.Requerido = True
        Me.Jck_Txt1.Size = New System.Drawing.Size(190, 20)
        Me.Jck_Txt1.TabIndex = 12
        Me.Jck_Txt1.tipoCaracter = 3
        Me.Jck_Txt1.tipoletra = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(550, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 89)
        Me.Panel1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 268)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Jck_Txt1)
        Me.Controls.Add(Me._cmdBotones_1)
        Me.Controls.Add(Me.CmdImprimir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
    Public WithEvents CmdImprimir As System.Windows.Forms.Button
    Friend WithEvents PerformanceCounter1 As System.Diagnostics.PerformanceCounter
    Friend WithEvents Jck_Txt1 As Jck_txt.Jck_Txt
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
