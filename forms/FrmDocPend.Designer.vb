<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmDocPend
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
    Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents TDBG_DocPend As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents lbnregdetalle As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocPend))
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.TDBG_DocPend = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.lbnregdetalle = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Picture1.SuspendLayout()
        CType(Me.TDBG_DocPend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancelar.Location = New System.Drawing.Point(302, 248)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(77, 22)
        Me.CmdCancelar.TabIndex = 5
        Me.CmdCancelar.Text = "&Cancelar"
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAceptar.Location = New System.Drawing.Point(225, 248)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptar.Size = New System.Drawing.Size(77, 22)
        Me.CmdAceptar.TabIndex = 4
        Me.CmdAceptar.Text = "&Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Controls.Add(Me.TDBG_DocPend)
        Me.Picture1.Controls.Add(Me.lbnregdetalle)
        Me.Picture1.Controls.Add(Me.Label7)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(3, 6)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(752, 237)
        Me.Picture1.TabIndex = 0
        Me.Picture1.TabStop = True
        '
        'TDBG_DocPend
        '
        Me.TDBG_DocPend.DataSource = Nothing
        Me.TDBG_DocPend.Location = New System.Drawing.Point(4, 4)
        Me.TDBG_DocPend.Name = "TDBG_DocPend"
        Me.TDBG_DocPend.OcxState = CType(resources.GetObject("TDBG_DocPend.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBG_DocPend.Size = New System.Drawing.Size(736, 195)
        Me.TDBG_DocPend.TabIndex = 1
        '
        'lbnregdetalle
        '
        Me.lbnregdetalle.BackColor = System.Drawing.Color.White
        Me.lbnregdetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbnregdetalle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbnregdetalle.Location = New System.Drawing.Point(517, 204)
        Me.lbnregdetalle.Name = "lbnregdetalle"
        Me.lbnregdetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbnregdetalle.Size = New System.Drawing.Size(70, 17)
        Me.lbnregdetalle.TabIndex = 3
        Me.lbnregdetalle.Text = "0 "
        Me.lbnregdetalle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(444, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Nº Registros :"
        '
        'FrmDocPend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(756, 274)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.Picture1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocPend"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Documentos Pendientes "
        Me.Picture1.ResumeLayout(False)
        Me.Picture1.PerformLayout()
        CType(Me.TDBG_DocPend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class