Option Strict Off
Option Explicit On
Imports Func = Contabilidad.ModFuncionesGen
Friend Class FrmLibrosElectPrincipales
    Inherits System.Windows.Forms.Form
    Dim rs1 As New ADODB.Recordset
    Dim li_aRC As Short
    Private Sub LlenarLista()
        Dim I As Short
        Dim itmX As System.Windows.Forms.ListViewItem
        Dim rs2 As New ADODB.Recordset
        ListView1.Columns.Clear()
        ListView1.Items.Clear()
        ListView1.Columns.Add("", "Presentacion de Libro", CInt((ListView1.Width) / 1))
        ListView1.View = System.Windows.Forms.View.Details
        'UPGRADE_NOTE: El objeto rs1 no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rs1 = Nothing
        rs1 = VGCNx.Execute("select * from ct_librossunatcorrelativos where categorialibro=1 ")
        rs1.MoveFirst()
        I = 1
        Do While Not rs1.EOF
            itmX = ListView1.Items.Add(rs1.Fields("librocodigosunat").Value + "  " + rs1.Fields("libroCorrelativodescripcion").Value)
            If Check1.CheckState = 0 Then
                SQL = " select * from ct_librossunatxempresa where empresacodigo='" & VGParametros.empresacodigo & "'"
                SQL = SQL & " and librocodigosunat='" & rs1.Fields("librocodigosunat").Value & "'"
                rs2 = VGCNx.Execute(SQL)
                If rs2.RecordCount = 0 Then
                    'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    ListView1.Items.Item(I + 0).Checked = 0
                Else
                    'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    ListView1.Items.Item(I + 0).Checked = rs2.Fields("estadoregistro").Value
                End If
            Else
                'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                ListView1.Items.Item(I + 0).Checked = 1
            End If
            I = I + 1
            rs1.MoveNext()
        Loop
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim x As Short
        Dim libro As String
        x = 1
        rs1.MoveFirst()
        Do Until x > rs1.RecordCount
            'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If ListView1.Items.Item(x).Checked = True Then
                'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                libro = Func.Left(ListView1.Items.Item(x).Text, 6)
                If libro = "xx" Then
                ElseIf libro = "050100" Then
                    Call Generadiario("050100")
                ElseIf libro = "050200" Then
                    Call GeneradiarioSimplificado("050200")
                ElseIf libro = "060100" Then
                    Call GeneraMayor("060100")
60100:
                ElseIf libro = "080100" Then
                    Call GeneraCompras("080100")
                ElseIf libro = "140100" Then
                    Call GeneraVentas("140100")
                End If
            End If
            x = x + 1
        Loop
        Command1.Visible = False
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Me.Close()
    End Sub

    Private Sub FrmLibrosElectPrincipales_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Text1.Text = VGParametros.empresacodigo & " - " & VGParametros.NomEmpresa
        Text2.Text = VGParametros.RucEmpresa
        Call LlenarLista()
    End Sub
End Class