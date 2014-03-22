Imports CrystalDecisions.Shared

Public Class Form1
    Inherits System.Windows.Forms.Form



    Private Sub CmdImprimir_Click(sender As Object, e As EventArgs) Handles CmdImprimir.Click

        Dim FrmRep As New FrmReports
        Dim Cry As New ct_DaoVentas
        Dim RSQL As New ADODB.Recordset
        Dim myDataSourceConnections As DataSourceConnections = Cry.DataSourceConnections
        Dim myConnectInfo As IConnectionInfo = myDataSourceConnections(0)
[C#]


        Try
            myConnectInfo.SetConnection("(local)", "marficenet", "sa", "12345")
            myConnectInfo.SetLogon("sa", "12345")

            RSQL = VGCNx.Execute(" SELECT * FROM ct_paramlibaux where paramlibauxtipo='CO'")

            Cry.SetParameterValue("@base", "dbrocaing")
            Cry.SetParameterValue("@empresa", VGParametros.empresacodigo)
            Cry.SetParameterValue("@anno", VGParamSistem.Anoproceso)
            Cry.SetParameterValue("@mes", VGParamSistem.Mesproceso)
            Cry.SetParameterValue("@asientosplan", RSQL.Fields("paramlibauxasiento").Value)
            Cry.SetParameterValue("@ctasplancomp", RSQL.Fields("paramlibauxcuenta").Value)
            Cry.SetParameterValue("@analitico", "%%")

            FrmRep.CRVPresentacion.ReportSource = Cry
            FrmRep.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class