<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmDaoVentas
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
    Public WithEvents Ctr_AyudaEntidad As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents CmdImprimir As System.Windows.Forms.Button
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents DataGrid1 As AxMSDataGridLib.AxDataGrid
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDaoVentas))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Ctr_AyudaEntidad = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.CmdImprimir = New System.Windows.Forms.Button()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.DataGrid1 = New AxMSDataGridLib.AxDataGrid()
        Me.Frame1.SuspendLayout()
        CType(Me.Ctr_AyudaEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.Ctr_AyudaEntidad)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 24)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(505, 65)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        '
        'Ctr_AyudaEntidad
        '
        Me.Ctr_AyudaEntidad.Enabled = True
        Me.Ctr_AyudaEntidad.Location = New System.Drawing.Point(96, 24)
        Me.Ctr_AyudaEntidad.Name = "Ctr_AyudaEntidad"
        Me.Ctr_AyudaEntidad.OcxState = CType(resources.GetObject("Ctr_AyudaEntidad.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_AyudaEntidad.Size = New System.Drawing.Size(379, 20)
        Me.Ctr_AyudaEntidad.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Proveedor"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.CmdAceptar)
        Me.Frame2.Controls.Add(Me.CmdImprimir)
        Me.Frame2.Controls.Add(Me.CmdCancelar)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(536, 24)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(113, 313)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAceptar.Location = New System.Drawing.Point(16, 24)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptar.Size = New System.Drawing.Size(81, 73)
        Me.CmdAceptar.TabIndex = 4
        Me.CmdAceptar.Text = "&Procesar"
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'CmdImprimir
        '
        Me.CmdImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdImprimir.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdImprimir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdImprimir.Location = New System.Drawing.Point(16, 120)
        Me.CmdImprimir.Name = "CmdImprimir"
        Me.CmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdImprimir.Size = New System.Drawing.Size(81, 73)
        Me.CmdImprimir.TabIndex = 3
        Me.CmdImprimir.Text = "&Imprimir"
        Me.CmdImprimir.UseVisualStyleBackColor = False
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancelar.Location = New System.Drawing.Point(16, 216)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(81, 73)
        Me.CmdCancelar.TabIndex = 2
        Me.CmdCancelar.Text = "&Salir"
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'DataGrid1
        '
        Me.DataGrid1.DataSource = Nothing
        Me.DataGrid1.Location = New System.Drawing.Point(16, 104)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.OcxState = CType(resources.GetObject("DataGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DataGrid1.Size = New System.Drawing.Size(505, 233)
        Me.DataGrid1.TabIndex = 0
        '
        'FrmDaoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 364)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 31)
        Me.Name = "FrmDaoVentas"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        Me.Frame1.ResumeLayout(False)
        CType(Me.Ctr_AyudaEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class