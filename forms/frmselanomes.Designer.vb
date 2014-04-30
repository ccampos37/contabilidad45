<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmselanomes
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
    Public WithEvents cmdcancelar As System.Windows.Forms.Button
	Public WithEvents DTPperiodo As AxMSComCtl2.AxDTPicker
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdaceptar As System.Windows.Forms.Button
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmselanomes))
        Me.cmdcancelar = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.DTPperiodo = New AxMSComCtl2.AxDTPicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdaceptar = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        CType(Me.DTPperiodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdcancelar
        '
        Me.cmdcancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdcancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdcancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdcancelar.Location = New System.Drawing.Point(127, 44)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdcancelar.Size = New System.Drawing.Size(90, 22)
        Me.cmdcancelar.TabIndex = 3
        Me.cmdcancelar.Text = "&Cancelar"
        Me.cmdcancelar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.DTPperiodo)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(3, -2)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(239, 41)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'DTPperiodo
        '
        Me.DTPperiodo.Location = New System.Drawing.Point(122, 13)
        Me.DTPperiodo.Name = "DTPperiodo"
        Me.DTPperiodo.OcxState = CType(resources.GetObject("DTPperiodo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPperiodo.Size = New System.Drawing.Size(110, 19)
        Me.DTPperiodo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Periodo de Trabajo :"
        '
        'cmdaceptar
        '
        Me.cmdaceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdaceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdaceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdaceptar.Location = New System.Drawing.Point(30, 44)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdaceptar.Size = New System.Drawing.Size(90, 22)
        Me.cmdaceptar.TabIndex = 0
        Me.cmdaceptar.Text = "&Aceptar"
        Me.cmdaceptar.UseVisualStyleBackColor = False
        '
        'frmselanomes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(248, 71)
        Me.Controls.Add(Me.cmdcancelar)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdaceptar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmselanomes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "Seleccion Periodo de Trabajo"
        Me.Frame1.ResumeLayout(False)
        CType(Me.DTPperiodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class