<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmContabPagar
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
    Public WithEvents ChkRest As System.Windows.Forms.CheckBox
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdProcesar As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents CmdArchivo As System.Windows.Forms.Button
	Public WithEvents _Opt_1 As System.Windows.Forms.RadioButton
	Public WithEvents _Opt_0 As System.Windows.Forms.RadioButton
	Public WithEvents _Frame1_1 As System.Windows.Forms.GroupBox
	Public cmdg_archivoOpen As System.Windows.Forms.OpenFileDialog
    Public WithEvents _Frame1_0 As System.Windows.Forms.GroupBox
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContabPagar))
        Me._Frame1_0 = New System.Windows.Forms.GroupBox()
        Me.ChkRest = New System.Windows.Forms.CheckBox()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.CmdProcesar = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.DTPPerido = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdArchivo = New System.Windows.Forms.Button()
        Me._Frame1_1 = New System.Windows.Forms.GroupBox()
        Me._Opt_1 = New System.Windows.Forms.RadioButton()
        Me._Opt_0 = New System.Windows.Forms.RadioButton()
        Me.TxArchivo1 = New AxTextFer.AxTxFer()
        Me.cmdg_archivoOpen = New System.Windows.Forms.OpenFileDialog()
        Me.TxArchivo = New Jck_txt.Jck_Txt()
        Me._Frame1_0.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me._Frame1_1.SuspendLayout()
        CType(Me.TxArchivo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Frame1_0
        '
        Me._Frame1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Frame1_0.Controls.Add(Me.TxArchivo)
        Me._Frame1_0.Controls.Add(Me.ChkRest)
        Me._Frame1_0.Controls.Add(Me.CmdCancelar)
        Me._Frame1_0.Controls.Add(Me.CmdProcesar)
        Me._Frame1_0.Controls.Add(Me.Frame2)
        Me._Frame1_0.Controls.Add(Me.CmdArchivo)
        Me._Frame1_0.Controls.Add(Me._Frame1_1)
        Me._Frame1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame1_0.Location = New System.Drawing.Point(16, 24)
        Me._Frame1_0.Name = "_Frame1_0"
        Me._Frame1_0.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame1_0.Size = New System.Drawing.Size(557, 259)
        Me._Frame1_0.TabIndex = 0
        Me._Frame1_0.TabStop = False
        '
        'ChkRest
        '
        Me.ChkRest.BackColor = System.Drawing.SystemColors.Control
        Me.ChkRest.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkRest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkRest.Location = New System.Drawing.Point(25, 95)
        Me.ChkRest.Name = "ChkRest"
        Me.ChkRest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkRest.Size = New System.Drawing.Size(191, 16)
        Me.ChkRest.TabIndex = 10
        Me.ChkRest.Text = "Con Restauracion"
        Me.ChkRest.UseVisualStyleBackColor = False
        Me.ChkRest.Visible = False
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancelar.Location = New System.Drawing.Point(249, 143)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(116, 21)
        Me.CmdCancelar.TabIndex = 9
        Me.CmdCancelar.Text = "&Cancelar"
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'CmdProcesar
        '
        Me.CmdProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdProcesar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdProcesar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdProcesar.Location = New System.Drawing.Point(133, 143)
        Me.CmdProcesar.Name = "CmdProcesar"
        Me.CmdProcesar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdProcesar.Size = New System.Drawing.Size(116, 21)
        Me.CmdProcesar.TabIndex = 8
        Me.CmdProcesar.Text = "&Procesar"
        Me.CmdProcesar.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.DTPPerido)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(249, 24)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(210, 85)
        Me.Frame2.TabIndex = 5
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Periodo de Proceso"
        '
        'DTPPerido
        '
        Me.DTPPerido.CustomFormat = "mmm-yyyy"
        Me.DTPPerido.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPPerido.Location = New System.Drawing.Point(11, 13)
        Me.DTPPerido.Name = "DTPPerido"
        Me.DTPPerido.Size = New System.Drawing.Size(200, 20)
        Me.DTPPerido.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Periodo :"
        '
        'CmdArchivo
        '
        Me.CmdArchivo.BackColor = System.Drawing.SystemColors.Control
        Me.CmdArchivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdArchivo.Enabled = False
        Me.CmdArchivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdArchivo.Location = New System.Drawing.Point(463, 116)
        Me.CmdArchivo.Name = "CmdArchivo"
        Me.CmdArchivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdArchivo.Size = New System.Drawing.Size(25, 23)
        Me.CmdArchivo.TabIndex = 4
        Me.CmdArchivo.Text = "..."
        Me.CmdArchivo.UseVisualStyleBackColor = False
        '
        '_Frame1_1
        '
        Me._Frame1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Frame1_1.Controls.Add(Me._Opt_1)
        Me._Frame1_1.Controls.Add(Me._Opt_0)
        Me._Frame1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame1_1.Location = New System.Drawing.Point(25, 25)
        Me._Frame1_1.Name = "_Frame1_1"
        Me._Frame1_1.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame1_1.Size = New System.Drawing.Size(189, 65)
        Me._Frame1_1.TabIndex = 1
        Me._Frame1_1.TabStop = False
        Me._Frame1_1.Text = "Tipo de Generacion"
        '
        '_Opt_1
        '
        Me._Opt_1.BackColor = System.Drawing.SystemColors.Control
        Me._Opt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_1.Location = New System.Drawing.Point(11, 43)
        Me._Opt_1.Name = "_Opt_1"
        Me._Opt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Opt_1.Size = New System.Drawing.Size(168, 14)
        Me._Opt_1.TabIndex = 3
        Me._Opt_1.TabStop = True
        Me._Opt_1.Text = "Data Original"
        Me._Opt_1.UseVisualStyleBackColor = False
        '
        '_Opt_0
        '
        Me._Opt_0.BackColor = System.Drawing.SystemColors.Control
        Me._Opt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Opt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Opt_0.Location = New System.Drawing.Point(11, 20)
        Me._Opt_0.Name = "_Opt_0"
        Me._Opt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Opt_0.Size = New System.Drawing.Size(168, 14)
        Me._Opt_0.TabIndex = 2
        Me._Opt_0.TabStop = True
        Me._Opt_0.Text = "Desde Archivo"
        Me._Opt_0.UseVisualStyleBackColor = False
        '
        'TxArchivo1
        '
        Me.TxArchivo1.Enabled = True
        Me.TxArchivo1.Location = New System.Drawing.Point(52, 221)
        Me.TxArchivo1.Name = "TxArchivo1"
        Me.TxArchivo1.OcxState = CType(resources.GetObject("TxArchivo1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxArchivo1.Size = New System.Drawing.Size(436, 47)
        Me.TxArchivo1.TabIndex = 11
        Me.TxArchivo1.Visible = False
        '
        'TxArchivo
        '
        Me.TxArchivo.decimales = 2
        Me.TxArchivo.formato = "9,999,999.99"
        Me.TxArchivo.Location = New System.Drawing.Point(36, 115)
        Me.TxArchivo.longitud = 12
        Me.TxArchivo.Name = "TxArchivo"
        Me.TxArchivo.negativos = False
        Me.TxArchivo.Size = New System.Drawing.Size(421, 21)
        Me.TxArchivo.TabIndex = 11
        Me.TxArchivo.tipoCaracter = 3
        Me.TxArchivo.tipoletra = 3
        '
        'FrmContabPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(614, 295)
        Me.Controls.Add(Me.TxArchivo1)
        Me.Controls.Add(Me._Frame1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmContabPagar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilizacion de Planillas de Aplicaciones PAGAR"
        Me._Frame1_0.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me._Frame1_1.ResumeLayout(False)
        CType(Me.TxArchivo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTPPerido As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxArchivo As Jck_txt.Jck_Txt
    Public WithEvents TxArchivo1 As AxTextFer.AxTxFer
#End Region 
End Class