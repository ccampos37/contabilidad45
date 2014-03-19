<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmannos
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
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents RichCom As System.Windows.Forms.RichTextBox
	Public WithEvents ImageList1 As System.Windows.Forms.ImageList
	Public WithEvents cmdCancelar As System.Windows.Forms.Button
	Public WithEvents cmdEliminar As System.Windows.Forms.Button
	Public WithEvents cmdGenerar As System.Windows.Forms.Button
	Public WithEvents DTPanno As AxMSComCtl2.AxDTPicker
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _LV_Meses_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents LV_Meses As System.Windows.Forms.ListView
	Public WithEvents TDB_Anno As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmannos))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.CmdAceptar = New System.Windows.Forms.Button
		Me.RichCom = New System.Windows.Forms.RichTextBox
		Me.ImageList1 = New System.Windows.Forms.ImageList
		Me.cmdCancelar = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmdEliminar = New System.Windows.Forms.Button
		Me.cmdGenerar = New System.Windows.Forms.Button
		Me.DTPanno = New AxMSComCtl2.AxDTPicker
		Me.Label3 = New System.Windows.Forms.Label
		Me.LV_Meses = New System.Windows.Forms.ListView
		Me._LV_Meses_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
		Me.TDB_Anno = New AxTrueOleDBGrid70.AxTDBGrid
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.LV_Meses.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DTPanno, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TDB_Anno, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Aperturar Año"
		Me.ClientSize = New System.Drawing.Size(326, 377)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmannos"
		Me.CmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdAceptar.Text = "&Aceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(77, 20)
		Me.CmdAceptar.Location = New System.Drawing.Point(88, 352)
		Me.CmdAceptar.TabIndex = 11
		Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdAceptar.CausesValidation = True
		Me.CmdAceptar.Enabled = True
		Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdAceptar.TabStop = True
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.RichCom.Size = New System.Drawing.Size(35, 14)
		Me.RichCom.Location = New System.Drawing.Point(4, 347)
		Me.RichCom.TabIndex = 10
		Me.RichCom.Visible = False
		Me.RichCom.RTF = resources.GetString("RichCom.TextRTF")
		Me.RichCom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.RichCom.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
		Me.RichCom.Name = "RichCom"
		Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.ImageList1.Images.SetKeyName(0, "")
		Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancelar.Text = "&Cancelar"
		Me.cmdCancelar.Size = New System.Drawing.Size(77, 20)
		Me.cmdCancelar.Location = New System.Drawing.Point(172, 352)
		Me.cmdCancelar.TabIndex = 9
		Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancelar.CausesValidation = True
		Me.cmdCancelar.Enabled = True
		Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancelar.TabStop = True
		Me.cmdCancelar.Name = "cmdCancelar"
		Me.Frame1.Size = New System.Drawing.Size(319, 59)
		Me.Frame1.Location = New System.Drawing.Point(4, 287)
		Me.Frame1.TabIndex = 4
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdEliminar.Text = "&Eliminar"
		Me.cmdEliminar.Size = New System.Drawing.Size(74, 21)
		Me.cmdEliminar.Location = New System.Drawing.Point(227, 27)
		Me.cmdEliminar.TabIndex = 8
		Me.cmdEliminar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdEliminar.CausesValidation = True
		Me.cmdEliminar.Enabled = True
		Me.cmdEliminar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdEliminar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdEliminar.TabStop = True
		Me.cmdEliminar.Name = "cmdEliminar"
		Me.cmdGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdGenerar.Text = "&Generar"
		Me.cmdGenerar.Size = New System.Drawing.Size(74, 21)
		Me.cmdGenerar.Location = New System.Drawing.Point(148, 27)
		Me.cmdGenerar.TabIndex = 7
		Me.cmdGenerar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdGenerar.CausesValidation = True
		Me.cmdGenerar.Enabled = True
		Me.cmdGenerar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdGenerar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdGenerar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdGenerar.TabStop = True
		Me.cmdGenerar.Name = "cmdGenerar"
		DTPanno.OcxState = CType(resources.GetObject("DTPanno.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPanno.Size = New System.Drawing.Size(129, 21)
		Me.DTPanno.Location = New System.Drawing.Point(6, 27)
		Me.DTPanno.TabIndex = 5
		Me.DTPanno.Name = "DTPanno"
		Me.Label3.Text = "Año"
		Me.Label3.Size = New System.Drawing.Size(121, 11)
		Me.Label3.Location = New System.Drawing.Point(7, 13)
		Me.Label3.TabIndex = 6
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.LV_Meses.Size = New System.Drawing.Size(191, 265)
		Me.LV_Meses.Location = New System.Drawing.Point(133, 19)
		Me.LV_Meses.TabIndex = 1
		Me.LV_Meses.View = System.Windows.Forms.View.Details
		Me.LV_Meses.LabelEdit = False
		Me.LV_Meses.LabelWrap = True
		Me.LV_Meses.HideSelection = True
		Me.LV_Meses.Checkboxes = True
		Me.LV_Meses.GridLines = True
		Me.LV_Meses.LargeImageList = ImageList1
		Me.LV_Meses.SmallImageList = ImageList1
		Me.LV_Meses.ForeColor = System.Drawing.SystemColors.WindowText
		Me.LV_Meses.BackColor = System.Drawing.SystemColors.Window
		Me.LV_Meses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LV_Meses.Name = "LV_Meses"
		Me._LV_Meses_ColumnHeader_1.Text = "Meses"
		Me._LV_Meses_ColumnHeader_1.Width = 287
		TDB_Anno.OcxState = CType(resources.GetObject("TDB_Anno.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TDB_Anno.Size = New System.Drawing.Size(129, 262)
		Me.TDB_Anno.Location = New System.Drawing.Point(3, 21)
		Me.TDB_Anno.TabIndex = 0
		Me.TDB_Anno.Name = "TDB_Anno"
		Me.Label2.Text = " Lista de meses"
		Me.Label2.Size = New System.Drawing.Size(189, 17)
		Me.Label2.Location = New System.Drawing.Point(135, 1)
		Me.Label2.TabIndex = 3
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label2.Name = "Label2"
		Me.Label1.Text = " Años aperturados"
		Me.Label1.Size = New System.Drawing.Size(129, 17)
		Me.Label1.Location = New System.Drawing.Point(3, 1)
		Me.Label1.TabIndex = 2
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Name = "Label1"
		CType(Me.TDB_Anno, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPanno, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(CmdAceptar)
		Me.Controls.Add(RichCom)
		Me.Controls.Add(cmdCancelar)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(LV_Meses)
		Me.Controls.Add(TDB_Anno)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Frame1.Controls.Add(cmdEliminar)
		Me.Frame1.Controls.Add(cmdGenerar)
		Me.Frame1.Controls.Add(DTPanno)
		Me.Frame1.Controls.Add(Label3)
		Me.LV_Meses.Columns.Add(_LV_Meses_ColumnHeader_1)
		Me.Frame1.ResumeLayout(False)
		Me.LV_Meses.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class