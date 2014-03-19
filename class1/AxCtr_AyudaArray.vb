'UPGRADE_WARNING: El proyecto entero se debe compilar una vez antes de poder mostrar una matriz de controles ActiveX

Imports System.ComponentModel

<ProvideProperty("Index",GetType(Axctrlayuda_f.AxCtr_Ayuda))> Public Class AxCtr_AyudaArray
	Inherits Microsoft.VisualBasic.Compatibility.VB6.BaseOcxArray
	Implements IExtenderProvider

	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal Container As IContainer)
		MyBase.New(Container)
	End Sub

	Public Shadows Event [ClickEvent] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [DblClick] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [KeyDownEvent] (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_KeyDownEvent)
	Public Shadows Event [KeyPressEvent] (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_KeyPressEvent)
	Public Shadows Event [KeyUpEvent] (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_KeyUpEvent)
	Public Shadows Event [MouseDownEvent] (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_MouseDownEvent)
	Public Shadows Event [MouseMoveEvent] (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_MouseMoveEvent)
	Public Shadows Event [MouseUpEvent] (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_MouseUpEvent)
	Public Shadows Event [AlDevolverDato] (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent)
	Public Shadows Event [AlNoDevolverNada] (ByVal sender As System.Object, ByVal e As System.EventArgs)

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Function CanExtend(ByVal target As Object) As Boolean Implements IExtenderProvider.CanExtend
		If TypeOf target Is Axctrlayuda_f.AxCtr_Ayuda Then
			Return BaseCanExtend(target)
		End If
	End Function

	Public Function GetIndex(ByVal o As Axctrlayuda_f.AxCtr_Ayuda) As Short
		Return BaseGetIndex(o)
	End Function

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Sub SetIndex(ByVal o As Axctrlayuda_f.AxCtr_Ayuda, ByVal Index As Short)
		BaseSetIndex(o, Index)
	End Sub

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Function ShouldSerializeIndex(ByVal o As Axctrlayuda_f.AxCtr_Ayuda) As Boolean
		Return BaseShouldSerializeIndex(o)
	End Function

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Sub ResetIndex(ByVal o As Axctrlayuda_f.AxCtr_Ayuda)
		BaseResetIndex(o)
	End Sub

	Default Public ReadOnly Property Item(ByVal Index As Short) As Axctrlayuda_f.AxCtr_Ayuda
		Get
			Item = CType(BaseGetItem(Index), Axctrlayuda_f.AxCtr_Ayuda)
		End Get
	End Property

	Protected Overrides Function GetControlInstanceType() As System.Type
		Return GetType(Axctrlayuda_f.AxCtr_Ayuda)
	End Function

	Protected Overrides Sub HookUpControlEvents(ByVal o As Object)
		Dim ctl As Axctrlayuda_f.AxCtr_Ayuda = CType(o, Axctrlayuda_f.AxCtr_Ayuda)
		MyBase.HookUpControlEvents(o)
		If Not ClickEventEvent Is Nothing Then
			AddHandler ctl.ClickEvent, New System.EventHandler(AddressOf HandleClickEvent)
		End If
		If Not DblClickEvent Is Nothing Then
			AddHandler ctl.DblClick, New System.EventHandler(AddressOf HandleDblClick)
		End If
		If Not KeyDownEventEvent Is Nothing Then
			AddHandler ctl.KeyDownEvent, New Axctrlayuda_f.__Ctr_Ayuda_KeyDownEventHandler(AddressOf HandleKeyDownEvent)
		End If
		If Not KeyPressEventEvent Is Nothing Then
			AddHandler ctl.KeyPressEvent, New Axctrlayuda_f.__Ctr_Ayuda_KeyPressEventHandler(AddressOf HandleKeyPressEvent)
		End If
		If Not KeyUpEventEvent Is Nothing Then
			AddHandler ctl.KeyUpEvent, New Axctrlayuda_f.__Ctr_Ayuda_KeyUpEventHandler(AddressOf HandleKeyUpEvent)
		End If
		If Not MouseDownEventEvent Is Nothing Then
			AddHandler ctl.MouseDownEvent, New Axctrlayuda_f.__Ctr_Ayuda_MouseDownEventHandler(AddressOf HandleMouseDownEvent)
		End If
		If Not MouseMoveEventEvent Is Nothing Then
			AddHandler ctl.MouseMoveEvent, New Axctrlayuda_f.__Ctr_Ayuda_MouseMoveEventHandler(AddressOf HandleMouseMoveEvent)
		End If
		If Not MouseUpEventEvent Is Nothing Then
			AddHandler ctl.MouseUpEvent, New Axctrlayuda_f.__Ctr_Ayuda_MouseUpEventHandler(AddressOf HandleMouseUpEvent)
		End If
		If Not AlDevolverDatoEvent Is Nothing Then
			AddHandler ctl.AlDevolverDato, New Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEventHandler(AddressOf HandleAlDevolverDato)
		End If
		If Not AlNoDevolverNadaEvent Is Nothing Then
			AddHandler ctl.AlNoDevolverNada, New System.EventHandler(AddressOf HandleAlNoDevolverNada)
		End If
	End Sub

	Private Sub HandleClickEvent (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [ClickEvent] (sender, e)
	End Sub

	Private Sub HandleDblClick (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [DblClick] (sender, e)
	End Sub

	Private Sub HandleKeyDownEvent (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_KeyDownEvent) 
		RaiseEvent [KeyDownEvent] (sender, e)
	End Sub

	Private Sub HandleKeyPressEvent (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_KeyPressEvent) 
		RaiseEvent [KeyPressEvent] (sender, e)
	End Sub

	Private Sub HandleKeyUpEvent (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_KeyUpEvent) 
		RaiseEvent [KeyUpEvent] (sender, e)
	End Sub

	Private Sub HandleMouseDownEvent (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_MouseDownEvent) 
		RaiseEvent [MouseDownEvent] (sender, e)
	End Sub

	Private Sub HandleMouseMoveEvent (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_MouseMoveEvent) 
		RaiseEvent [MouseMoveEvent] (sender, e)
	End Sub

	Private Sub HandleMouseUpEvent (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_MouseUpEvent) 
		RaiseEvent [MouseUpEvent] (sender, e)
	End Sub

	Private Sub HandleAlDevolverDato (ByVal sender As System.Object, ByVal e As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) 
		RaiseEvent [AlDevolverDato] (sender, e)
	End Sub

	Private Sub HandleAlNoDevolverNada (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [AlNoDevolverNada] (sender, e)
	End Sub

End Class

