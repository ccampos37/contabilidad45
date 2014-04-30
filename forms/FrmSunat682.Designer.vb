<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmSunat682
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
    Public WithEvents DataGrid1 As AxMSDataGridLib.AxDataGrid
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Transf As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmbNivel As System.Windows.Forms.ComboBox
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSunat682))
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.DataGrid1 = New AxMSDataGridLib.AxDataGrid()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Transf = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.cmbNivel = New System.Windows.Forms.ComboBox()
        Me.DTPicker1 = New AxMSComCtl2.AxDTPicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame3.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame4.SuspendLayout()
        CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.DataGrid1)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(8, 128)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(777, 193)
        Me.Frame3.TabIndex = 12
        Me.Frame3.TabStop = False
        '
        'DataGrid1
        '
        Me.DataGrid1.DataSource = Nothing
        Me.DataGrid1.Location = New System.Drawing.Point(16, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.OcxState = CType(resources.GetObject("DataGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DataGrid1.Size = New System.Drawing.Size(745, 161)
        Me.DataGrid1.TabIndex = 13
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Text1)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 56)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(441, 65)
        Me.Frame2.TabIndex = 9
        Me.Frame2.TabStop = False
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(128, 24)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(297, 27)
        Me.Text1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(105, 57)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Carpeta y Nombre del Archivo a Exportar"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Frame1.Controls.Add(Me.Transf)
        Me.Frame1.Controls.Add(Me.cmdOK)
        Me.Frame1.Controls.Add(Me.cmdCancel)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(456, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(329, 113)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        '
        'Transf
        '
        Me.Transf.BackColor = System.Drawing.SystemColors.Control
        Me.Transf.Cursor = System.Windows.Forms.Cursors.Default
        Me.Transf.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Transf.Image = CType(resources.GetObject("Transf.Image"), System.Drawing.Image)
        Me.Transf.Location = New System.Drawing.Point(112, 16)
        Me.Transf.Name = "Transf"
        Me.Transf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Transf.Size = New System.Drawing.Size(89, 65)
        Me.Transf.TabIndex = 8
        Me.Transf.Text = "Exportar a SUNAT"
        Me.Transf.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Transf.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.Color.White
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Image = CType(resources.GetObject("cmdOK.Image"), System.Drawing.Image)
        Me.cmdOK.Location = New System.Drawing.Point(16, 16)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(81, 65)
        Me.cmdOK.TabIndex = 7
        Me.cmdOK.Text = "&Genera Archivo"
        Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.White
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Niagara Engraved", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(216, 16)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(89, 65)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "&Salir"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.cmbNivel)
        Me.Frame4.Controls.Add(Me.DTPicker1)
        Me.Frame4.Controls.Add(Me.Label3)
        Me.Frame4.Controls.Add(Me.Label1)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(8, 7)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(438, 48)
        Me.Frame4.TabIndex = 0
        Me.Frame4.TabStop = False
        '
        'cmbNivel
        '
        Me.cmbNivel.BackColor = System.Drawing.SystemColors.Window
        Me.cmbNivel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbNivel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbNivel.Location = New System.Drawing.Point(69, 15)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNivel.Size = New System.Drawing.Size(128, 21)
        Me.cmbNivel.TabIndex = 1
        Me.cmbNivel.Text = "Combo1"
        '
        'DTPicker1
        '
        Me.DTPicker1.Location = New System.Drawing.Point(286, 17)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPicker1.Size = New System.Drawing.Size(127, 19)
        Me.DTPicker1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(224, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mes :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nivel :"
        '
        'FrmSunat682
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(798, 344)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 31)
        Me.Name = "FrmSunat682"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Formato 682"
        Me.Frame3.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class