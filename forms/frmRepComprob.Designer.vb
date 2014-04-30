<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepComprob
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
    Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxCompIni = New Jck_txt.Jck_Txt()
        Me.Txcomprfin = New Jck_txt.Jck_Txt()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(136, 127)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(76, 24)
        Me.Command2.TabIndex = 2
        Me.Command2.Text = "&Aceptar"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(56, 127)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(76, 24)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "&Aceptar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Txcomprfin)
        Me.Frame1.Controls.Add(Me.TxCompIni)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(6, 5)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(257, 114)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Rango de Comprobantes"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(146, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Comprobante Final :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(146, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Comprobante Inicial :"
        '
        'TxCompIni
        '
        Me.TxCompIni.decimales = 2
        Me.TxCompIni.formato = "9,999,999.99"
        Me.TxCompIni.Location = New System.Drawing.Point(19, 36)
        Me.TxCompIni.longitud = 12
        Me.TxCompIni.Name = "TxCompIni"
        Me.TxCompIni.negativos = False
        Me.TxCompIni.Size = New System.Drawing.Size(220, 20)
        Me.TxCompIni.TabIndex = 8
        Me.TxCompIni.tipoCaracter = 3
        Me.TxCompIni.tipoletra = 3
        '
        'Txcomprfin
        '
        Me.Txcomprfin.decimales = 2
        Me.Txcomprfin.formato = "9,999,999.99"
        Me.Txcomprfin.Location = New System.Drawing.Point(19, 80)
        Me.Txcomprfin.longitud = 12
        Me.Txcomprfin.Name = "Txcomprfin"
        Me.Txcomprfin.negativos = False
        Me.Txcomprfin.Size = New System.Drawing.Size(220, 20)
        Me.Txcomprfin.TabIndex = 9
        Me.Txcomprfin.tipoCaracter = 3
        Me.Txcomprfin.tipoletra = 3
        '
        'frmRepComprob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(268, 156)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepComprob"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Reporte de Comprobantes"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Txcomprfin As Jck_txt.Jck_Txt
    Friend WithEvents TxCompIni As Jck_txt.Jck_Txt
#End Region 
End Class