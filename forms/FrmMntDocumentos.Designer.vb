<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMntDocumentos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMntDocumentos))
        Me.Framelinea = New System.Windows.Forms.GroupBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DbGrid1 = New AxMSDataGridLib.AxDataGrid()
        Me.frame5 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.CmdGrabar = New System.Windows.Forms.Button()
        Me.Cmdcancelar = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.CmdModificar = New System.Windows.Forms.Button()
        Me.CmdNuevo = New System.Windows.Forms.Button()
        Me.Cmdeliminar = New System.Windows.Forms.Button()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Frameactivo = New System.Windows.Forms.GroupBox()
        Me.CheckAnulado = New System.Windows.Forms.CheckBox()
        Me.TxtRefSunat = New System.Windows.Forms.TextBox()
        Me.Checkref = New System.Windows.Forms.CheckBox()
        Me.CheckNota = New System.Windows.Forms.CheckBox()
        Me.CheckcOMPRAS = New System.Windows.Forms.CheckBox()
        Me.CheckVTAS = New System.Windows.Forms.CheckBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Framelinea.SuspendLayout
        CType(Me.DbGrid1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.frame5.SuspendLayout
        Me.Frame1.SuspendLayout
        Me.Frame2.SuspendLayout
        Me.Frame3.SuspendLayout
        Me.Frameactivo.SuspendLayout
        Me.SuspendLayout
        '
        'Framelinea
        '
        Me.Framelinea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.Framelinea.Controls.Add(Me.txtcodigo)
        Me.Framelinea.Controls.Add(Me.Label2)
        Me.Framelinea.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Framelinea.Location = New System.Drawing.Point(16, 16)
        Me.Framelinea.Name = "Framelinea"
        Me.Framelinea.Padding = New System.Windows.Forms.Padding(0)
        Me.Framelinea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Framelinea.Size = New System.Drawing.Size(500, 57)
        Me.Framelinea.TabIndex = 12
        Me.Framelinea.TabStop = False
        '
        'txtcodigo
        '
        Me.txtcodigo.AcceptsReturn = True
        Me.txtcodigo.BackColor = System.Drawing.SystemColors.Window
        Me.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcodigo.Location = New System.Drawing.Point(155, 18)
        Me.txtcodigo.MaxLength = 10
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcodigo.Size = New System.Drawing.Size(41, 20)
        Me.txtcodigo.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Código             :"
        '
        'DbGrid1
        '
        Me.DbGrid1.DataSource = Nothing
        Me.DbGrid1.Location = New System.Drawing.Point(8, 43)
        Me.DbGrid1.Name = "DbGrid1"
        Me.DbGrid1.OcxState = CType(resources.GetObject("DbGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DbGrid1.Size = New System.Drawing.Size(527, 358)
        Me.DbGrid1.TabIndex = 10
        '
        'frame5
        '
        Me.frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.frame5.Controls.Add(Me.DbGrid1)
        Me.frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frame5.Location = New System.Drawing.Point(105, -30)
        Me.frame5.Name = "frame5"
        Me.frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame5.Size = New System.Drawing.Size(544, 407)
        Me.frame5.TabIndex = 14
        Me.frame5.TabStop = False
        Me.frame5.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Frame1.Controls.Add(Me.CmdGrabar)
        Me.Frame1.Controls.Add(Me.Cmdcancelar)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(97, 307)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(544, 85)
        Me.Frame1.TabIndex = 13
        Me.Frame1.TabStop = False
        Me.Frame1.Visible = False
        '
        'CmdGrabar
        '
        Me.CmdGrabar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdGrabar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdGrabar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdGrabar.Image = CType(resources.GetObject("CmdGrabar.Image"), System.Drawing.Image)
        Me.CmdGrabar.Location = New System.Drawing.Point(120, 14)
        Me.CmdGrabar.Name = "CmdGrabar"
        Me.CmdGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdGrabar.Size = New System.Drawing.Size(61, 55)
        Me.CmdGrabar.TabIndex = 8
        Me.CmdGrabar.Text = "&Grabar"
        Me.CmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdGrabar.UseVisualStyleBackColor = False
        '
        'Cmdcancelar
        '
        Me.Cmdcancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Cmdcancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmdcancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmdcancelar.Image = CType(resources.GetObject("Cmdcancelar.Image"), System.Drawing.Image)
        Me.Cmdcancelar.Location = New System.Drawing.Point(264, 14)
        Me.Cmdcancelar.Name = "Cmdcancelar"
        Me.Cmdcancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmdcancelar.Size = New System.Drawing.Size(61, 55)
        Me.Cmdcancelar.TabIndex = 7
        Me.Cmdcancelar.Text = "&Cancelar"
        Me.Cmdcancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmdcancelar.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Frame2.Controls.Add(Me.CmdModificar)
        Me.Frame2.Controls.Add(Me.CmdNuevo)
        Me.Frame2.Controls.Add(Me.Cmdeliminar)
        Me.Frame2.Controls.Add(Me.CmdSalir)
        Me.Frame2.Controls.Add(Me.cmdImprimir)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(114, 311)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(524, 73)
        Me.Frame2.TabIndex = 12
        Me.Frame2.TabStop = False
        '
        'CmdModificar
        '
        Me.CmdModificar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdModificar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdModificar.Image = CType(resources.GetObject("CmdModificar.Image"), System.Drawing.Image)
        Me.CmdModificar.Location = New System.Drawing.Point(136, 10)
        Me.CmdModificar.Name = "CmdModificar"
        Me.CmdModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdModificar.Size = New System.Drawing.Size(61, 55)
        Me.CmdModificar.TabIndex = 5
        Me.CmdModificar.Text = "&Modificar"
        Me.CmdModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdModificar.UseVisualStyleBackColor = False
        '
        'CmdNuevo
        '
        Me.CmdNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdNuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdNuevo.Image = CType(resources.GetObject("CmdNuevo.Image"), System.Drawing.Image)
        Me.CmdNuevo.Location = New System.Drawing.Point(32, 10)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdNuevo.Size = New System.Drawing.Size(61, 55)
        Me.CmdNuevo.TabIndex = 4
        Me.CmdNuevo.Text = "&Ingreso"
        Me.CmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdNuevo.UseVisualStyleBackColor = False
        '
        'Cmdeliminar
        '
        Me.Cmdeliminar.BackColor = System.Drawing.SystemColors.Control
        Me.Cmdeliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmdeliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmdeliminar.Image = CType(resources.GetObject("Cmdeliminar.Image"), System.Drawing.Image)
        Me.Cmdeliminar.Location = New System.Drawing.Point(232, 10)
        Me.Cmdeliminar.Name = "Cmdeliminar"
        Me.Cmdeliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmdeliminar.Size = New System.Drawing.Size(61, 55)
        Me.Cmdeliminar.TabIndex = 3
        Me.Cmdeliminar.Text = "&Eliminar"
        Me.Cmdeliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmdeliminar.UseVisualStyleBackColor = False
        '
        'CmdSalir
        '
        Me.CmdSalir.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSalir.Image = CType(resources.GetObject("CmdSalir.Image"), System.Drawing.Image)
        Me.CmdSalir.Location = New System.Drawing.Point(440, 10)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdSalir.Size = New System.Drawing.Size(61, 55)
        Me.CmdSalir.TabIndex = 2
        Me.CmdSalir.Text = "&Salir"
        Me.CmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdSalir.UseVisualStyleBackColor = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImprimir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(328, 10)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImprimir.Size = New System.Drawing.Size(61, 55)
        Me.cmdImprimir.TabIndex = 1
        Me.cmdImprimir.Text = "&Reporte"
        Me.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdImprimir.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Framelinea)
        Me.Frame3.Controls.Add(Me.Frameactivo)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(97, 13)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(546, 375)
        Me.Frame3.TabIndex = 15
        Me.Frame3.TabStop = False
        '
        'Frameactivo
        '
        Me.Frameactivo.BackColor = System.Drawing.Color.White
        Me.Frameactivo.Controls.Add(Me.CheckAnulado)
        Me.Frameactivo.Controls.Add(Me.TxtRefSunat)
        Me.Frameactivo.Controls.Add(Me.Checkref)
        Me.Frameactivo.Controls.Add(Me.CheckNota)
        Me.Frameactivo.Controls.Add(Me.CheckcOMPRAS)
        Me.Frameactivo.Controls.Add(Me.CheckVTAS)
        Me.Frameactivo.Controls.Add(Me.txtdescripcion)
        Me.Frameactivo.Controls.Add(Me.Label3)
        Me.Frameactivo.Controls.Add(Me.Label5)
        Me.Frameactivo.ForeColor = System.Drawing.Color.Blue
        Me.Frameactivo.Location = New System.Drawing.Point(16, 79)
        Me.Frameactivo.Name = "Frameactivo"
        Me.Frameactivo.Padding = New System.Windows.Forms.Padding(0)
        Me.Frameactivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frameactivo.Size = New System.Drawing.Size(500, 224)
        Me.Frameactivo.TabIndex = 15
        Me.Frameactivo.TabStop = False
        Me.Frameactivo.Text = "Datos"
        '
        'CheckAnulado
        '
        Me.CheckAnulado.BackColor = System.Drawing.Color.White
        Me.CheckAnulado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckAnulado.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckAnulado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckAnulado.Location = New System.Drawing.Point(27, 181)
        Me.CheckAnulado.Name = "CheckAnulado"
        Me.CheckAnulado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckAnulado.Size = New System.Drawing.Size(137, 25)
        Me.CheckAnulado.TabIndex = 37
        Me.CheckAnulado.Text = "Estado Anulado"
        Me.CheckAnulado.UseVisualStyleBackColor = False
        '
        'TxtRefSunat
        '
        Me.TxtRefSunat.AcceptsReturn = True
        Me.TxtRefSunat.BackColor = System.Drawing.Color.White
        Me.TxtRefSunat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtRefSunat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtRefSunat.Location = New System.Drawing.Point(147, 152)
        Me.TxtRefSunat.MaxLength = 3
        Me.TxtRefSunat.Name = "TxtRefSunat"
        Me.TxtRefSunat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtRefSunat.Size = New System.Drawing.Size(33, 20)
        Me.TxtRefSunat.TabIndex = 36
        '
        'Checkref
        '
        Me.Checkref.BackColor = System.Drawing.Color.White
        Me.Checkref.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Checkref.Cursor = System.Windows.Forms.Cursors.Default
        Me.Checkref.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Checkref.Location = New System.Drawing.Point(27, 120)
        Me.Checkref.Name = "Checkref"
        Me.Checkref.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Checkref.Size = New System.Drawing.Size(137, 25)
        Me.Checkref.TabIndex = 35
        Me.Checkref.Text = "Ingresa Nro. REFERENCIA"
        Me.Checkref.UseVisualStyleBackColor = False
        '
        'CheckNota
        '
        Me.CheckNota.BackColor = System.Drawing.Color.White
        Me.CheckNota.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckNota.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckNota.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckNota.Location = New System.Drawing.Point(27, 88)
        Me.CheckNota.Name = "CheckNota"
        Me.CheckNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckNota.Size = New System.Drawing.Size(137, 25)
        Me.CheckNota.TabIndex = 34
        Me.CheckNota.Text = "Documento NOTA CREDITO"
        Me.CheckNota.UseVisualStyleBackColor = False
        '
        'CheckcOMPRAS
        '
        Me.CheckcOMPRAS.BackColor = System.Drawing.Color.White
        Me.CheckcOMPRAS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckcOMPRAS.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckcOMPRAS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckcOMPRAS.Location = New System.Drawing.Point(27, 64)
        Me.CheckcOMPRAS.Name = "CheckcOMPRAS"
        Me.CheckcOMPRAS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckcOMPRAS.Size = New System.Drawing.Size(137, 25)
        Me.CheckcOMPRAS.TabIndex = 33
        Me.CheckcOMPRAS.Text = "Registro Compras"
        Me.CheckcOMPRAS.UseVisualStyleBackColor = False
        '
        'CheckVTAS
        '
        Me.CheckVTAS.BackColor = System.Drawing.Color.White
        Me.CheckVTAS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckVTAS.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckVTAS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckVTAS.Location = New System.Drawing.Point(27, 40)
        Me.CheckVTAS.Name = "CheckVTAS"
        Me.CheckVTAS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckVTAS.Size = New System.Drawing.Size(137, 25)
        Me.CheckVTAS.TabIndex = 32
        Me.CheckVTAS.Text = "Registro Ventas"
        Me.CheckVTAS.UseVisualStyleBackColor = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.AcceptsReturn = True
        Me.txtdescripcion.BackColor = System.Drawing.Color.White
        Me.txtdescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdescripcion.Location = New System.Drawing.Point(147, 16)
        Me.txtdescripcion.MaxLength = 40
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdescripcion.Size = New System.Drawing.Size(313, 20)
        Me.txtdescripcion.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(27, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Descripción     :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(27, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(113, 26)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Referencia SUNAT-Pagos"
        '
        'FrmMntDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 402)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.frame5)
        Me.Controls.Add(Me.Frame3)
        Me.Name = "FrmMntDocumentos"
        Me.Text = "Tabla de Documentos"
        Me.Framelinea.ResumeLayout(false)
        Me.Framelinea.PerformLayout
        CType(Me.DbGrid1,System.ComponentModel.ISupportInitialize).EndInit
        Me.frame5.ResumeLayout(false)
        Me.Frame1.ResumeLayout(false)
        Me.Frame2.ResumeLayout(false)
        Me.Frame3.ResumeLayout(false)
        Me.Frameactivo.ResumeLayout(false)
        Me.Frameactivo.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Public WithEvents Framelinea As System.Windows.Forms.GroupBox
    Public WithEvents DbGrid1 As AxMSDataGridLib.AxDataGrid
    Public WithEvents frame5 As System.Windows.Forms.GroupBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents CmdGrabar As System.Windows.Forms.Button
    Public WithEvents Cmdcancelar As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents CmdModificar As System.Windows.Forms.Button
    Public WithEvents CmdNuevo As System.Windows.Forms.Button
    Public WithEvents Cmdeliminar As System.Windows.Forms.Button
    Public WithEvents CmdSalir As System.Windows.Forms.Button
    Public WithEvents cmdImprimir As System.Windows.Forms.Button
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents txtcodigo As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frameactivo As System.Windows.Forms.GroupBox
    Public WithEvents CheckAnulado As System.Windows.Forms.CheckBox
    Public WithEvents TxtRefSunat As System.Windows.Forms.TextBox
    Public WithEvents Checkref As System.Windows.Forms.CheckBox
    Public WithEvents CheckNota As System.Windows.Forms.CheckBox
    Public WithEvents CheckcOMPRAS As System.Windows.Forms.CheckBox
    Public WithEvents CheckVTAS As System.Windows.Forms.CheckBox
    Public WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
End Class
