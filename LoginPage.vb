Public Class LoginPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginBttn.Click
        SwitchTableLayout(AdminHome.MaintableLayout)
    End Sub

    Private Sub CreateAccount(sender As Object, e As EventArgs) Handles CreateAccLabel.Click
        SwitchTableLayout(SignupPage.MaintableLayout)
    End Sub
End Class