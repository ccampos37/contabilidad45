<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepLibrosAuxiliares
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
    Public WithEvents _optOpcionCajaBancos_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcionCajaBancos_0 As System.Windows.Forms.RadioButton
	Public WithEvents fraCajaBancos As System.Windows.Forms.GroupBox
	Public WithEvents cboLibroAuxiliar As System.Windows.Forms.ComboBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents DTPickerFecInicio As AxMSComCtl2.AxDTPicker
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents fraDetallado As System.Windows.Forms.GroupBox
	Public WithEvents Option1 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents chkAcumula As System.Windows.Forms.CheckBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents optOpcion As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    Public WithEvents optOpcionCajaBancos As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepLibrosAuxiliares))
        Me.fraCajaBancos = New System.Windows.Forms.GroupBox()
        Me._optOpcionCajaBancos_1 = New System.Windows.Forms.RadioButton()
        Me._optOpcionCajaBancos_0 = New System.Windows.Forms.RadioButton()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.cboLibroAuxiliar = New System.Windows.Forms.ComboBox()
        Me.fraDetallado = New System.Windows.Forms.GroupBox()
        Me.DTPicker1 = New AxMSComCtl2.AxDTPicker()
        Me.DTPickerFecInicio = New AxMSComCtl2.AxDTPicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me._optOpcion_3 = New System.Windows.Forms.RadioButton()
        Me._optOpcion_2 = New System.Windows.Forms.RadioButton()
        Me._optOpcion_1 = New System.Windows.Forms.RadioButton()
        Me._optOpcion_0 = New System.Windows.Forms.RadioButton()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.chkAcumula = New System.Windows.Forms.CheckBox()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.optOpcion = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.optOpcionCajaBancos = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.fraCajaBancos.SuspendLayout
        Me.Frame3.SuspendLayout
        Me.fraDetallado.SuspendLayout
        CType(Me.DTPicker1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DTPickerFecInicio,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Frame1.SuspendLayout
        Me.Frame2.SuspendLayout
        CType(Me.optOpcion,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.optOpcionCajaBancos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'fraCajaBancos
        '
        Me.fraCajaBancos.BackColor = System.Drawing.SystemColors.Control
        Me.fraCajaBancos.Controls.Add(Me._optOpcionCajaBancos_1)
        Me.fraCajaBancos.Controls.Add(Me._optOpcionCajaBancos_0)
        Me.fraCajaBancos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraCajaBancos.Location = New System.Drawing.Point(0, 169)
        Me.fraCajaBancos.Name = "fraCajaBancos"
        Me.fraCajaBancos.Padding = New System.Windows.Forms.Padding(0)
        Me.fraCajaBancos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraCajaBancos.Size = New System.Drawing.Size(308, 50)
        Me.fraCajaBancos.TabIndex = 15
        Me.fraCajaBancos.TabStop = false
        Me.fraCajaBancos.Text = "Para Caja Bancos"
        '
        '_optOpcionCajaBancos_1
        '
        Me._optOpcionCajaBancos_1.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcionCajaBancos_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcionCajaBancos_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcionCajaBancos.SetIndex(Me._optOpcionCajaBancos_1, CType(1,Short))
        Me._optOpcionCajaBancos_1.Location = New System.Drawing.Point(10, 32)
        Me._optOpcionCajaBancos_1.Name = "_optOpcionCajaBancos_1"
        Me._optOpcionCajaBancos_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcionCajaBancos_1.Size = New System.Drawing.Size(237, 18)
        Me._optOpcionCajaBancos_1.TabIndex = 17
        Me._optOpcionCajaBancos_1.TabStop = True
        Me._optOpcionCajaBancos_1.Text = "Registro Caja Resumido por Comprobante"
        Me._optOpcionCajaBancos_1.UseVisualStyleBackColor = False
        '
        '_optOpcionCajaBancos_0
        '
        Me._optOpcionCajaBancos_0.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcionCajaBancos_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcionCajaBancos_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcionCajaBancos.SetIndex(Me._optOpcionCajaBancos_0, CType(0, Short))
        Me._optOpcionCajaBancos_0.Location = New System.Drawing.Point(10, 15)
        Me._optOpcionCajaBancos_0.Name = "_optOpcionCajaBancos_0"
        Me._optOpcionCajaBancos_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcionCajaBancos_0.Size = New System.Drawing.Size(237, 17)
        Me._optOpcionCajaBancos_0.TabIndex = 16
        Me._optOpcionCajaBancos_0.TabStop = True
        Me._optOpcionCajaBancos_0.Text = "Registro Caja Resumido por Banco"
        Me._optOpcionCajaBancos_0.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.cboLibroAuxiliar)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(0, 120)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(308, 48)
        Me.Frame3.TabIndex = 13
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Seleccionar Libro Auxiliar"
        '
        'cboLibroAuxiliar
        '
        Me.cboLibroAuxiliar.BackColor = System.Drawing.SystemColors.Window
        Me.cboLibroAuxiliar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLibroAuxiliar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLibroAuxiliar.Location = New System.Drawing.Point(5, 18)
        Me.cboLibroAuxiliar.Name = "cboLibroAuxiliar"
        Me.cboLibroAuxiliar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLibroAuxiliar.Size = New System.Drawing.Size(249, 21)
        Me.cboLibroAuxiliar.TabIndex = 14
        '
        'fraDetallado
        '
        Me.fraDetallado.BackColor = System.Drawing.SystemColors.Control
        Me.fraDetallado.Controls.Add(Me.DTPicker1)
        Me.fraDetallado.Controls.Add(Me.DTPickerFecInicio)
        Me.fraDetallado.Controls.Add(Me.Label1)
        Me.fraDetallado.Controls.Add(Me.Label2)
        Me.fraDetallado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDetallado.Location = New System.Drawing.Point(0, 254)
        Me.fraDetallado.Name = "fraDetallado"
        Me.fraDetallado.Padding = New System.Windows.Forms.Padding(0)
        Me.fraDetallado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDetallado.Size = New System.Drawing.Size(309, 62)
        Me.fraDetallado.TabIndex = 7
        Me.fraDetallado.TabStop = False
        Me.fraDetallado.Text = "Diario General Detallado"
        '
        'DTPicker1
        '
        Me.DTPicker1.Location = New System.Drawing.Point(132, 39)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPicker1.Size = New System.Drawing.Size(172, 20)
        Me.DTPicker1.TabIndex = 18
        '
        'DTPickerFecInicio
        '
        Me.DTPickerFecInicio.Location = New System.Drawing.Point(132, 15)
        Me.DTPickerFecInicio.Name = "DTPickerFecInicio"
        Me.DTPickerFecInicio.OcxState = CType(resources.GetObject("DTPickerFecInicio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPickerFecInicio.Size = New System.Drawing.Size(172, 20)
        Me.DTPickerFecInicio.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha Inicial"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha Final"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Option1)
        Me.Frame1.Controls.Add(Me._optOpcion_3)
        Me.Frame1.Controls.Add(Me._optOpcion_2)
        Me.Frame1.Controls.Add(Me._optOpcion_1)
        Me.Frame1.Controls.Add(Me._optOpcion_0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, -5)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(308, 122)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        '
        'Option1
        '
        Me.Option1.BackColor = System.Drawing.SystemColors.Control
        Me.Option1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option1.Location = New System.Drawing.Point(9, 97)
        Me.Option1.Name = "Option1"
        Me.Option1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option1.Size = New System.Drawing.Size(120, 19)
        Me.Option1.TabIndex = 12
        Me.Option1.TabStop = True
        Me.Option1.Text = "Letras x Cobrar"
        Me.Option1.UseVisualStyleBackColor = False
        '
        '_optOpcion_3
        '
        Me._optOpcion_3.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcion_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcion_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion.SetIndex(Me._optOpcion_3, CType(3, Short))
        Me._optOpcion_3.Location = New System.Drawing.Point(9, 73)
        Me._optOpcion_3.Name = "_optOpcion_3"
        Me._optOpcion_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcion_3.Size = New System.Drawing.Size(143, 18)
        Me._optOpcion_3.TabIndex = 11
        Me._optOpcion_3.TabStop = True
        Me._optOpcion_3.Text = "Letras x Pagar"
        Me._optOpcion_3.UseVisualStyleBackColor = False
        '
        '_optOpcion_2
        '
        Me._optOpcion_2.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcion_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcion_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion.SetIndex(Me._optOpcion_2, CType(2, Short))
        Me._optOpcion_2.Location = New System.Drawing.Point(9, 54)
        Me._optOpcion_2.Name = "_optOpcion_2"
        Me._optOpcion_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcion_2.Size = New System.Drawing.Size(143, 18)
        Me._optOpcion_2.TabIndex = 10
        Me._optOpcion_2.TabStop = True
        Me._optOpcion_2.Text = "Registro de Ventas"
        Me._optOpcion_2.UseVisualStyleBackColor = False
        '
        '_optOpcion_1
        '
        Me._optOpcion_1.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcion_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcion_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion.SetIndex(Me._optOpcion_1, CType(1, Short))
        Me._optOpcion_1.Location = New System.Drawing.Point(9, 30)
        Me._optOpcion_1.Name = "_optOpcion_1"
        Me._optOpcion_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcion_1.Size = New System.Drawing.Size(143, 18)
        Me._optOpcion_1.TabIndex = 6
        Me._optOpcion_1.TabStop = True
        Me._optOpcion_1.Text = "Registro de Compras"
        Me._optOpcion_1.UseVisualStyleBackColor = False
        '
        '_optOpcion_0
        '
        Me._optOpcion_0.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcion_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcion_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion.SetIndex(Me._optOpcion_0, CType(0, Short))
        Me._optOpcion_0.Location = New System.Drawing.Point(9, 9)
        Me._optOpcion_0.Name = "_optOpcion_0"
        Me._optOpcion_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcion_0.Size = New System.Drawing.Size(150, 18)
        Me._optOpcion_0.TabIndex = 5
        Me._optOpcion_0.TabStop = true
        Me._optOpcion_0.Text = "Caja y Bancos"
        Me._optOpcion_0.UseVisualStyleBackColor = false
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.chkAcumula)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(0, 216)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(308, 33)
        Me.Frame2.TabIndex = 2
        Me.Frame2.TabStop = false
        '
        'chkAcumula
        '
        Me.chkAcumula.BackColor = System.Drawing.SystemColors.Control
        Me.chkAcumula.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAcumula.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAcumula.Location = New System.Drawing.Point(14, 12)
        Me.chkAcumula.Name = "chkAcumula"
        Me.chkAcumula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAcumula.Size = New System.Drawing.Size(115, 18)
        Me.chkAcumula.TabIndex = 3
        Me.chkAcumula.Text = "Acumulado"
        Me.chkAcumula.UseVisualStyleBackColor = false
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(159, 348)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(70, 23)
        Me.cmdBotones1.TabIndex = 1
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = false
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(69, 348)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(70, 23)
        Me.cmdBotones0.TabIndex = 0
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = false
        '
        'optOpcion
        '
        '
        'frmRepLibrosAuxiliares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(308, 379)
        Me.Controls.Add(Me.fraCajaBancos)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.fraDetallado)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmRepLibrosAuxiliares"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Libros Auxiliares"
        Me.fraCajaBancos.ResumeLayout(false)
        Me.Frame3.ResumeLayout(false)
        Me.fraDetallado.ResumeLayout(false)
        CType(Me.DTPicker1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DTPickerFecInicio,System.ComponentModel.ISupportInitialize).EndInit
        Me.Frame1.ResumeLayout(false)
        Me.Frame2.ResumeLayout(false)
        CType(Me.optOpcion,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.optOpcionCajaBancos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
#End Region 
End Class