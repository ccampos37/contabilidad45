<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmImportDataFac
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
    Public WithEvents cboSerie As System.Windows.Forms.ComboBox
	Public WithEvents ChkRest As System.Windows.Forms.CheckBox
	Public cmdg_archivoOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdProcesar As System.Windows.Forms.Button
	Public WithEvents DTPPerido As AxMSComCtl2.AxDTPicker
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents CmdArchivo As System.Windows.Forms.Button
    Public WithEvents TxArchivo1 As AxTextFer.AxTxFer
    Public WithEvents _Opt_1 As System.Windows.Forms.RadioButton
    Public WithEvents _Opt_0 As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportDataFac))
        Me.cboSerie = New System.Windows.Forms.ComboBox()
        Me.ChkRest = New System.Windows.Forms.CheckBox()
        Me.cmdg_archivoOpen = New System.Windows.Forms.OpenFileDialog()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.CmdProcesar = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.DTPPerido = New AxMSComCtl2.AxDTPicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdArchivo = New System.Windows.Forms.Button()
        Me.TxArchivo1 = New AxTextFer.AxTxFer()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._Opt_1 = New System.Windows.Forms.RadioButton()
        Me._Opt_0 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Jck_Txt1 = New Jck_txt.Jck_Txt()
        Me.Frame2.SuspendLayout()
        CType(Me.DTPPerido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxArchivo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboSerie
        '
        Me.cboSerie.BackColor = System.Drawing.SystemColors.Info
        Me.cboSerie.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboSerie.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSerie.Location = New System.Drawing.Point(4, 135)
        Me.cboSerie.Name = "cboSerie"
        Me.cboSerie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSerie.Size = New System.Drawing.Size(255, 21)
        Me.cboSerie.TabIndex = 11
        '
        'ChkRest
        '
        Me.ChkRest.BackColor = System.Drawing.SystemColors.Control
        Me.ChkRest.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkRest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkRest.Location = New System.Drawing.Point(4, 77)
        Me.ChkRest.Name = "ChkRest"
        Me.ChkRest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkRest.Size = New System.Drawing.Size(191, 16)
        Me.ChkRest.TabIndex = 10
        Me.ChkRest.Text = "Con Restauracion"
        Me.ChkRest.UseVisualStyleBackColor = False
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancelar.Location = New System.Drawing.Point(236, 205)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(107, 23)
        Me.CmdCancelar.TabIndex = 7
        Me.CmdCancelar.Text = "&Cancelar"
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'CmdProcesar
        '
        Me.CmdProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdProcesar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdProcesar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdProcesar.Location = New System.Drawing.Point(128, 205)
        Me.CmdProcesar.Name = "CmdProcesar"
        Me.CmdProcesar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdProcesar.Size = New System.Drawing.Size(107, 23)
        Me.CmdProcesar.TabIndex = 6
        Me.CmdProcesar.Text = "&Procesar"
        Me.CmdProcesar.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.DTPPerido)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(228, 6)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(234, 66)
        Me.Frame2.TabIndex = 5
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Periodo de Proceso"
        '
        'DTPPerido
        '
        Me.DTPPerido.Location = New System.Drawing.Point(67, 28)
        Me.DTPPerido.Name = "DTPPerido"
        Me.DTPPerido.OcxState = CType(resources.GetObject("DTPPerido.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPPerido.Size = New System.Drawing.Size(160, 21)
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
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Periodo :"
        '
        'CmdArchivo
        '
        Me.CmdArchivo.BackColor = System.Drawing.SystemColors.Control
        Me.CmdArchivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdArchivo.Enabled = False
        Me.CmdArchivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdArchivo.Location = New System.Drawing.Point(442, 172)
        Me.CmdArchivo.Name = "CmdArchivo"
        Me.CmdArchivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdArchivo.Size = New System.Drawing.Size(25, 23)
        Me.CmdArchivo.TabIndex = 4
        Me.CmdArchivo.Text = "..."
        Me.CmdArchivo.UseVisualStyleBackColor = False
        '
        'TxArchivo1
        '
        Me.TxArchivo1.Enabled = True
        Me.TxArchivo1.Location = New System.Drawing.Point(4, 91)
        Me.TxArchivo1.Name = "TxArchivo1"
        Me.TxArchivo1.OcxState = CType(resources.GetObject("TxArchivo1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxArchivo1.Size = New System.Drawing.Size(436, 24)
        Me.TxArchivo1.TabIndex = 3
        Me.TxArchivo1.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._Opt_1)
        Me.Frame1.Controls.Add(Me._Opt_0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(4, 7)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(189, 65)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Tipo de Generacion"
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
        Me._Opt_1.TabIndex = 2
        Me._Opt_1.TabStop = True
        Me._Opt_1.Text = "Servidor Local"
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
        Me._Opt_0.TabIndex = 1
        Me._Opt_0.TabStop = True
        Me._Opt_0.Text = "Puntos Remotos"
        Me._Opt_0.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(5, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(249, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Seleccionar Punto Remoto"
        '
        'Jck_Txt1
        '
        Me.Jck_Txt1.decimales = 2
        Me.Jck_Txt1.formato = "9,999,999.99"
        Me.Jck_Txt1.Location = New System.Drawing.Point(4, 172)
        Me.Jck_Txt1.longitud = 75
        Me.Jck_Txt1.Name = "Jck_Txt1"
        Me.Jck_Txt1.negativos = False
        Me.Jck_Txt1.Size = New System.Drawing.Size(432, 20)
        Me.Jck_Txt1.TabIndex = 13
        Me.Jck_Txt1.tipoCaracter = 3
        Me.Jck_Txt1.tipoletra = 3
        '
        'FrmImportDataFac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(471, 240)
        Me.Controls.Add(Me.Jck_Txt1)
        Me.Controls.Add(Me.cboSerie)
        Me.Controls.Add(Me.ChkRest)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdProcesar)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.CmdArchivo)
        Me.Controls.Add(Me.TxArchivo1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportDataFac"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Importacion de datos y Generacion de Asiento Factura"
        Me.Frame2.ResumeLayout(False)
        CType(Me.DTPPerido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxArchivo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Jck_Txt1 As Jck_txt.Jck_Txt
#End Region 
End Class