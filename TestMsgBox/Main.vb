Public Class Main
    'Exclamation button : On click, shows the MsgBox
    Private Sub Exclamation_Click(sender As Object, e As EventArgs) Handles Exclamation.Click
        MsgBox("This is an Exclamation Box", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Exclamation")
    End Sub
    'Information button : On click, shows the MsgBox
    Private Sub Information_Click(sender As Object, e As EventArgs) Handles Information.Click
        MsgBox("This is an Information Box", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
    End Sub
    'Critical button : On click, shows the MsgBox
    Private Sub Critical_Click(sender As Object, e As EventArgs) Handles Critical.Click
        MsgBox("This is an Critical Box", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Critical")
    End Sub
    'Question button : On click, shows the MsgBox
    Private Sub Question_Click(sender As Object, e As EventArgs) Handles Question.Click
        MsgBox("This is an Question Box", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, "Question")
    End Sub
    'About button : On click, shows the about Window "About.vb"
    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        Dim About As New About
        About.Show()
    End Sub
    'Quit button : On click, shows the MsgBox asking if you really want to close the app and show a Goodbye MsgBox
    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Dim QUIT
        QUIT = MsgBox("Exit application ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Exit")
        If QUIT = MsgBoxResult.Yes Then
            MsgBox("Goodbye !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "TestMsgBox")
            Application.Exit()
        End If
    End Sub
End Class
