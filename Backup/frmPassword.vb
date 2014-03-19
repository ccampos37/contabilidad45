Option Strict Off
Option Explicit On
Friend Class frmPassword
	Inherits System.Windows.Forms.Form
	
	Dim m_Form As System.Windows.Forms.Form
	
	Private Sub frmPassword_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Width = VB6.TwipsToPixelsX(3840)
		Me.Height = VB6.TwipsToPixelsY(1920)
	End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Hide()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		'  If txtPassword = "1542" Then
		'      Unload Me
		FrmMntTipoCambio.Show()
		'  Else
		'      MsgBox "La contraseña no es válida. Vuelva a intentarlo", , Caption
		'      txtPassword.SetFocus
		'      SendKeys "{Home}+{End}"
		'  End If
	End Sub
	
	Private Sub txtPassword_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If KeyCode = 13 Then
			Call cmdOK_Click(cmdOK, New System.EventArgs())
		End If
	End Sub
End Class