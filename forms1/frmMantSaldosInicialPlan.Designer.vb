<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMantSaldosInicialPlan
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
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents txtBuscar As AxTextFer.AxTxFer
	Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
	Public WithEvents _txt_0 As AxTextFer.AxTxFer
	Public WithEvents _txt_1 As AxTextFer.AxTxFer
	Public WithEvents _txt_2 As AxTextFer.AxTxFer
	Public WithEvents _txt_3 As AxTextFer.AxTxFer
	Public WithEvents _lbl_2 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents _lbl_1 As System.Windows.Forms.Label
	Public WithEvents _lbl_0 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
	Public WithEvents TDBGrid1 As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents lbl As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txt As AxTxFerArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantSaldosInicialPlan))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtBuscar = New AxTextFer.AxTxFer()
        Me._cmdBotones_1 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._txt_0 = New AxTextFer.AxTxFer()
        Me._txt_1 = New AxTextFer.AxTxFer()
        Me._txt_2 = New AxTextFer.AxTxFer()
        Me._txt_3 = New AxTextFer.AxTxFer()
        Me._lbl_2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._lbl_1 = New System.Windows.Forms.Label()
        Me._lbl_0 = New System.Windows.Forms.Label()
        Me._cmdBotones_0 = New System.Windows.Forms.Button()
        Me.TDBGrid1 = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.lbl = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        CType(Me.txtBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me._txt_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._txt_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._txt_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._txt_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Enabled = True
        Me.txtBuscar.Location = New System.Drawing.Point(0, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.OcxState = CType(resources.GetObject("txtBuscar.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txtBuscar.Size = New System.Drawing.Size(417, 20)
        Me.txtBuscar.TabIndex = 12
        '
        '_cmdBotones_1
        '
        Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones.SetIndex(Me._cmdBotones_1, CType(1, Short))
        Me._cmdBotones_1.Location = New System.Drawing.Point(215, 327)
        Me._cmdBotones_1.Name = "_cmdBotones_1"
        Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_1.Size = New System.Drawing.Size(89, 24)
        Me._cmdBotones_1.TabIndex = 7
        Me._cmdBotones_1.Text = "&Cancelar"
        Me._cmdBotones_1.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._txt_0)
        Me.Frame1.Controls.Add(Me._txt_1)
        Me.Frame1.Controls.Add(Me._txt_2)
        Me.Frame1.Controls.Add(Me._txt_3)
        Me.Frame1.Controls.Add(Me._lbl_2)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me._lbl_1)
        Me.Frame1.Controls.Add(Me._lbl_0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(1, 193)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(417, 122)
        Me.Frame1.TabIndex = 6
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Editar Saldo Iniciales"
        '
        '_txt_0
        '
        Me._txt_0.Enabled = True
        Me._txt_0.Location = New System.Drawing.Point(192, 33)
        Me._txt_0.Name = "_txt_0"
        Me._txt_0.OcxState = CType(resources.GetObject("_txt_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me._txt_0.Size = New System.Drawing.Size(222, 20)
        Me._txt_0.TabIndex = 1
        '
        '_txt_1
        '
        Me._txt_1.Enabled = True
        Me._txt_1.Location = New System.Drawing.Point(192, 53)
        Me._txt_1.Name = "_txt_1"
        Me._txt_1.OcxState = CType(resources.GetObject("_txt_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me._txt_1.Size = New System.Drawing.Size(222, 20)
        Me._txt_1.TabIndex = 2
        '
        '_txt_2
        '
        Me._txt_2.Enabled = True
        Me._txt_2.Location = New System.Drawing.Point(193, 79)
        Me._txt_2.Name = "_txt_2"
        Me._txt_2.OcxState = CType(resources.GetObject("_txt_2.OcxState"), System.Windows.Forms.AxHost.State)
        Me._txt_2.Size = New System.Drawing.Size(222, 20)
        Me._txt_2.TabIndex = 3
        '
        '_txt_3
        '
        Me._txt_3.Enabled = True
        Me._txt_3.Location = New System.Drawing.Point(193, 99)
        Me._txt_3.Name = "_txt_3"
        Me._txt_3.OcxState = CType(resources.GetObject("_txt_3.OcxState"), System.Windows.Forms.AxHost.State)
        Me._txt_3.Size = New System.Drawing.Size(222, 20)
        Me._txt_3.TabIndex = 4
        '
        '_lbl_2
        '
        Me._lbl_2.BackColor = System.Drawing.SystemColors.Window
        Me._lbl_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl.SetIndex(Me._lbl_2, CType(2, Short))
        Me._lbl_2.Location = New System.Drawing.Point(5, 15)
        Me._lbl_2.Name = "_lbl_2"
        Me._lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_2.Size = New System.Drawing.Size(409, 17)
        Me._lbl_2.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(5, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(189, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Haber (Dolares)"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(5, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(189, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Debe (Dolares)"
        '
        '_lbl_1
        '
        Me._lbl_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._lbl_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_1.ForeColor = System.Drawing.Color.Yellow
        Me.lbl.SetIndex(Me._lbl_1, CType(1, Short))
        Me._lbl_1.Location = New System.Drawing.Point(6, 54)
        Me._lbl_1.Name = "_lbl_1"
        Me._lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_1.Size = New System.Drawing.Size(187, 18)
        Me._lbl_1.TabIndex = 9
        Me._lbl_1.Text = "Haber (Soles)"
        '
        '_lbl_0
        '
        Me._lbl_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._lbl_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_0.ForeColor = System.Drawing.Color.Yellow
        Me.lbl.SetIndex(Me._lbl_0, CType(0, Short))
        Me._lbl_0.Location = New System.Drawing.Point(6, 34)
        Me._lbl_0.Name = "_lbl_0"
        Me._lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_0.Size = New System.Drawing.Size(187, 19)
        Me._lbl_0.TabIndex = 8
        Me._lbl_0.Text = "Debe (Soles)"
        '
        '_cmdBotones_0
        '
        Me._cmdBotones_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones.SetIndex(Me._cmdBotones_0, CType(0, Short))
        Me._cmdBotones_0.Location = New System.Drawing.Point(111, 327)
        Me._cmdBotones_0.Name = "_cmdBotones_0"
        Me._cmdBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_0.Size = New System.Drawing.Size(89, 24)
        Me._cmdBotones_0.TabIndex = 5
        Me._cmdBotones_0.Text = "&Aceptar"
        Me._cmdBotones_0.UseVisualStyleBackColor = False
        '
        'TDBGrid1
        '
        Me.TDBGrid1.DataSource = Nothing
        Me.TDBGrid1.Location = New System.Drawing.Point(1, 32)
        Me.TDBGrid1.Name = "TDBGrid1"
        Me.TDBGrid1.OcxState = CType(resources.GetObject("TDBGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBGrid1.Size = New System.Drawing.Size(416, 141)
        Me.TDBGrid1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(201, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Buscar por Código / Descripción"
        '
        'cmdBotones
        '
        '
        'frmMantSaldosInicialPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(418, 364)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me._cmdBotones_1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._cmdBotones_0)
        Me.Controls.Add(Me.TDBGrid1)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMantSaldosInicialPlan"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Saldos Iniciales"
        CType(Me.txtBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        CType(Me._txt_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._txt_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._txt_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._txt_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class