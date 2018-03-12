Public Class MainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MiscEdit.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _2K18Misc.Show()
    End Sub

    Private Sub Button_Show_Click(sender As Object, e As EventArgs) Handles Button_Show.Click
        ShowEditor.Show()
    End Sub

    Private Sub Button_Color_Click(sender As Object, e As EventArgs) Handles Button_Color.Click
        LightColors.Show()
    End Sub
End Class