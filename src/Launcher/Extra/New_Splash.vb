Public Class New_Splash
    Private Sub New_Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionLBL.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        CopyrightLBL.Text = My.Application.Info.Copyright
    End Sub
End Class