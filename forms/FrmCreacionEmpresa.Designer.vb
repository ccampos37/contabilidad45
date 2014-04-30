<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmCreacionEmpresa
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
    Public WithEvents CmdModificar As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents DataGrid1 As AxMSDataGridLib.AxDataGrid
	Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Ctr_Ayuempresa As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Text4 As System.Windows.Forms.TextBox
	Public WithEvents cmdgrabar As System.Windows.Forms.Button
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreacionEmpresa))
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.CmdModificar = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.DataGrid1 = New AxMSDataGridLib.AxDataGrid()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ctr_Ayuempresa = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.Text4 = New System.Windows.Forms.TextBox()
        Me.cmdgrabar = New System.Windows.Forms.Button()
        Me.Command4 = New System.Windows.Forms.Button()
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage1.SuspendLayout()
        CType(Me.Ctr_Ayuempresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(23, 20)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 1
        Me.SSTab1.Size = New System.Drawing.Size(395, 281)
        Me.SSTab1.TabIndex = 0
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.CmdModificar)
        Me._SSTab1_TabPage0.Controls.Add(Me.Command2)
        Me._SSTab1_TabPage0.Controls.Add(Me.Command1)
        Me._SSTab1_TabPage0.Controls.Add(Me.DataGrid1)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(387, 255)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Lista de Empresas"
        '
        'CmdModificar
        '
        Me.CmdModificar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdModificar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdModificar.Location = New System.Drawing.Point(24, 232)
        Me.CmdModificar.Name = "CmdModificar"
        Me.CmdModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdModificar.Size = New System.Drawing.Size(81, 33)
        Me.CmdModificar.TabIndex = 16
        Me.CmdModificar.Text = "Modificar"
        Me.CmdModificar.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(288, 232)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(81, 33)
        Me.Command2.TabIndex = 10
        Me.Command2.Text = "Salir"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(192, 232)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Adicionar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'DataGrid1
        '
        Me.DataGrid1.DataSource = Nothing
        Me.DataGrid1.Location = New System.Drawing.Point(16, 32)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.OcxState = CType(resources.GetObject("DataGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DataGrid1.Size = New System.Drawing.Size(353, 185)
        Me.DataGrid1.TabIndex = 15
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.Label1)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label2)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label3)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label4)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label5)
        Me._SSTab1_TabPage1.Controls.Add(Me.Ctr_Ayuempresa)
        Me._SSTab1_TabPage1.Controls.Add(Me.Text1)
        Me._SSTab1_TabPage1.Controls.Add(Me.Text2)
        Me._SSTab1_TabPage1.Controls.Add(Me.Text3)
        Me._SSTab1_TabPage1.Controls.Add(Me.Text4)
        Me._SSTab1_TabPage1.Controls.Add(Me.cmdgrabar)
        Me._SSTab1_TabPage1.Controls.Add(Me.Command4)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(387, 255)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Datos de empresa"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Razon Social"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(24, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(24, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ruc"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(24, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Empresa Base"
        '
        'Ctr_Ayuempresa
        '
        Me.Ctr_Ayuempresa.Enabled = True
        Me.Ctr_Ayuempresa.Location = New System.Drawing.Point(136, 32)
        Me.Ctr_Ayuempresa.Name = "Ctr_Ayuempresa"
        Me.Ctr_Ayuempresa.OcxState = CType(resources.GetObject("Ctr_Ayuempresa.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuempresa.Size = New System.Drawing.Size(209, 21)
        Me.Ctr_Ayuempresa.TabIndex = 14
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Enabled = False
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(136, 72)
        Me.Text1.MaxLength = 2
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(33, 25)
        Me.Text1.TabIndex = 2
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(136, 104)
        Me.Text2.MaxLength = 50
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(241, 25)
        Me.Text2.TabIndex = 3
        '
        'Text3
        '
        Me.Text3.AcceptsReturn = True
        Me.Text3.BackColor = System.Drawing.SystemColors.Window
        Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text3.Location = New System.Drawing.Point(136, 136)
        Me.Text3.MaxLength = 50
        Me.Text3.Name = "Text3"
        Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text3.Size = New System.Drawing.Size(241, 25)
        Me.Text3.TabIndex = 4
        '
        'Text4
        '
        Me.Text4.AcceptsReturn = True
        Me.Text4.BackColor = System.Drawing.SystemColors.Window
        Me.Text4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text4.Location = New System.Drawing.Point(136, 168)
        Me.Text4.MaxLength = 11
        Me.Text4.Name = "Text4"
        Me.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text4.Size = New System.Drawing.Size(81, 25)
        Me.Text4.TabIndex = 5
        '
        'cmdgrabar
        '
        Me.cmdgrabar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdgrabar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdgrabar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdgrabar.Location = New System.Drawing.Point(192, 232)
        Me.cmdgrabar.Name = "cmdgrabar"
        Me.cmdgrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdgrabar.Size = New System.Drawing.Size(81, 33)
        Me.cmdgrabar.TabIndex = 11
        Me.cmdgrabar.Text = "Grabar"
        Me.cmdgrabar.UseVisualStyleBackColor = False
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.SystemColors.Control
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command4.Location = New System.Drawing.Point(288, 232)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(81, 33)
        Me.Command4.TabIndex = 12
        Me.Command4.Text = "Salir"
        Me.Command4.UseVisualStyleBackColor = False
        '
        'FrmCreacionEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(430, 313)
        Me.Controls.Add(Me.SSTab1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 30)
        Me.Name = "FrmCreacionEmpresa"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Creacion de empresas"
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        CType(Me.Ctr_Ayuempresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class