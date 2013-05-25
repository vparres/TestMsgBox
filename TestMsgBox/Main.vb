Public Class Main

    Private Sub Exclamation_Click(sender As Object, e As EventArgs) Handles Exclamation.Click
        MsgBox("This is an Exclamation Box", 48 + 0 + 0, "Exclamation")
    End Sub

    Private Sub Information_Click(sender As Object, e As EventArgs) Handles Information.Click
        MsgBox("This is an Information Box", 64 + 0 + 0, "Information")
    End Sub

    Private Sub Critical_Click(sender As Object, e As EventArgs) Handles Critical.Click
        MsgBox("This is an Critical Box", 16 + 0 + 0, "Critical")
    End Sub

    Private Sub Question_Click(sender As Object, e As EventArgs) Handles Question.Click
        MsgBox("This is an Question Box", 32 + 0 + 0, "Exclamation")
    End Sub

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        Dim About As New About
        About.Show()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Dim Sup
        Sup = MsgBox("Exit application ?", vbQuestion + vbYesNo + 256, "Exit")
        If Sup = vbYes Then
            MsgBox("Goodbye !", 64 + 0 + 0, "TestMsgBox")
            Application.Exit()
        End If
    End Sub
End Class
