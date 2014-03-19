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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmannos))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.RichCom = New System.Windows.Forms.RichTextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.DTPanno = New AxMSComCtl2.AxDTPicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LV_Meses = New System.Windows.Forms.ListView()
        Me._LV_Meses_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TDB_Anno = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        CType(Me.DTPanno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDB_Anno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAceptar.Location = New System.Drawing.Point(88, 352)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptar.Size = New System.Drawing.Size(77, 20)
        Me.CmdAceptar.TabIndex = 11
        Me.CmdAceptar.Text = "&Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'RichCom
        '
        Me.RichCom.Location = New System.Drawing.Point(4, 347)
        Me.RichCom.Name = "RichCom"
        Me.RichCom.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichCom.Size = New System.Drawing.Size(35, 14)
        Me.RichCom.TabIndex = 10
        Me.RichCom.Text = ""
        Me.RichCom.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(172, 352)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(77, 20)
        Me.cmdCancelar.TabIndex = 9
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdEliminar)
        Me.Frame1.Controls.Add(Me.cmdGenerar)
        Me.Frame1.Controls.Add(Me.DTPanno)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(4, 287)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(319, 59)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEliminar.Location = New System.Drawing.Point(227, 27)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEliminar.Size = New System.Drawing.Size(74, 21)
        Me.cmdEliminar.TabIndex = 8
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdGenerar
        '
        Me.cmdGenerar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGenerar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGenerar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGenerar.Location = New System.Drawing.Point(148, 27)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGenerar.Size = New System.Drawing.Size(74, 21)
        Me.cmdGenerar.TabIndex = 7
        Me.cmdGenerar.Text = "&Generar"
        Me.cmdGenerar.UseVisualStyleBackColor = False
        '
        'DTPanno
        '
        Me.DTPanno.Location = New System.Drawing.Point(6, 27)
        Me.DTPanno.Name = "DTPanno"
        Me.DTPanno.OcxState = CType(resources.GetObject("DTPanno.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPanno.Size = New System.Drawing.Size(129, 21)
        Me.DTPanno.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(7, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(121, 11)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Año"
        '
        'LV_Meses
        '
        Me.LV_Meses.BackColor = System.Drawing.SystemColors.Window
        Me.LV_Meses.CheckBoxes = True
        Me.LV_Meses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._LV_Meses_ColumnHeader_1})
        Me.LV_Meses.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LV_Meses.GridLines = True
        Me.LV_Meses.LargeImageList = Me.ImageList1
        Me.LV_Meses.Location = New System.Drawing.Point(133, 19)
        Me.LV_Meses.Name = "LV_Meses"
        Me.LV_Meses.Size = New System.Drawing.Size(191, 265)
        Me.LV_Meses.SmallImageList = Me.ImageList1
        Me.LV_Meses.TabIndex = 1
        Me.LV_Meses.UseCompatibleStateImageBehavior = False
        Me.LV_Meses.View = System.Windows.Forms.View.Details
        '
        '_LV_Meses_ColumnHeader_1
        '
        Me._LV_Meses_ColumnHeader_1.Text = "Meses"
        Me._LV_Meses_ColumnHeader_1.Width = 287
        '
        'TDB_Anno
        '
        Me.TDB_Anno.DataSource = Nothing
        Me.TDB_Anno.Location = New System.Drawing.Point(3, 21)
        Me.TDB_Anno.Name = "TDB_Anno"
        Me.TDB_Anno.OcxState = CType(resources.GetObject("TDB_Anno.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDB_Anno.Size = New System.Drawing.Size(129, 262)
        Me.TDB_Anno.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(135, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(189, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " Lista de meses"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = " Años aperturados"
        '
        'frmannos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(326, 377)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.RichCom)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.LV_Meses)
        Me.Controls.Add(Me.TDB_Anno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmannos"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Aperturar Año"
        Me.Frame1.ResumeLayout(False)
        CType(Me.DTPanno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDB_Anno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class