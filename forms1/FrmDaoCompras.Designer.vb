<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmDaoCompras
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
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents DataGrid1 As AxMSDataGridLib.AxDataGrid
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdImprimir As System.Windows.Forms.Button
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Ctr_AyudaEntidad As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmDaoCompras))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.DataGrid1 = New AxMSDataGridLib.AxDataGrid
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.CmdCancelar = New System.Windows.Forms.Button
		Me.CmdImprimir = New System.Windows.Forms.Button
		Me.CmdAceptar = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Ctr_AyudaEntidad = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_AyudaEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.ClientSize = New System.Drawing.Size(681, 346)
		Me.Location = New System.Drawing.Point(8, 31)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "FrmDaoCompras"
		DataGrid1.OcxState = CType(resources.GetObject("DataGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DataGrid1.Size = New System.Drawing.Size(505, 233)
		Me.DataGrid1.Location = New System.Drawing.Point(16, 88)
		Me.DataGrid1.TabIndex = 7
		Me.DataGrid1.Name = "DataGrid1"
		Me.Frame2.BackColor = System.Drawing.Color.White
		Me.Frame2.Size = New System.Drawing.Size(113, 313)
		Me.Frame2.Location = New System.Drawing.Point(536, 8)
		Me.Frame2.TabIndex = 1
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.CmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdCancelar.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.CmdCancelar.Text = "&Salir"
		Me.CmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdCancelar.Size = New System.Drawing.Size(81, 73)
		Me.CmdCancelar.Location = New System.Drawing.Point(16, 216)
		Me.CmdCancelar.TabIndex = 4
		Me.CmdCancelar.CausesValidation = True
		Me.CmdCancelar.Enabled = True
		Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdCancelar.TabStop = True
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdImprimir.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.CmdImprimir.Text = "&Imprimir"
		Me.CmdImprimir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdImprimir.Size = New System.Drawing.Size(81, 73)
		Me.CmdImprimir.Location = New System.Drawing.Point(16, 120)
		Me.CmdImprimir.TabIndex = 3
		Me.CmdImprimir.CausesValidation = True
		Me.CmdImprimir.Enabled = True
		Me.CmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdImprimir.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdImprimir.TabStop = True
		Me.CmdImprimir.Name = "CmdImprimir"
		Me.CmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdAceptar.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.CmdAceptar.Text = "&Procesar"
		Me.CmdAceptar.Size = New System.Drawing.Size(81, 73)
		Me.CmdAceptar.Location = New System.Drawing.Point(16, 24)
		Me.CmdAceptar.TabIndex = 2
		Me.CmdAceptar.CausesValidation = True
		Me.CmdAceptar.Enabled = True
		Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdAceptar.TabStop = True
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.Frame1.BackColor = System.Drawing.Color.White
		Me.Frame1.Size = New System.Drawing.Size(505, 65)
		Me.Frame1.Location = New System.Drawing.Point(16, 8)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Ctr_AyudaEntidad.OcxState = CType(resources.GetObject("Ctr_AyudaEntidad.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_AyudaEntidad.Size = New System.Drawing.Size(379, 20)
		Me.Ctr_AyudaEntidad.Location = New System.Drawing.Point(96, 24)
		Me.Ctr_AyudaEntidad.TabIndex = 6
		Me.Ctr_AyudaEntidad.Name = "Ctr_AyudaEntidad"
		Me.Label2.BackColor = System.Drawing.Color.White
		Me.Label2.Text = "Proveedor"
		Me.Label2.ForeColor = System.Drawing.Color.Blue
		Me.Label2.Size = New System.Drawing.Size(73, 25)
		Me.Label2.Location = New System.Drawing.Point(16, 24)
		Me.Label2.TabIndex = 5
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Controls.Add(DataGrid1)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Frame2.Controls.Add(CmdCancelar)
		Me.Frame2.Controls.Add(CmdImprimir)
		Me.Frame2.Controls.Add(CmdAceptar)
		Me.Frame1.Controls.Add(Ctr_AyudaEntidad)
		Me.Frame1.Controls.Add(Label2)
		CType(Me.Ctr_AyudaEntidad, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class