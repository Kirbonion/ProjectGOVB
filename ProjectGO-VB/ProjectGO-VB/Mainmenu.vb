Public Class Mainmenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Height = 10000
        Panel3.Top = 10000
        'Hides the menu selection identifier
    End Sub
    '------------------------------Buttons---------------------------------------------------------
    Private Sub ButtonJoinGame_Click(sender As Object, e As EventArgs) Handles ButtonJoinGame.Click
        Panel3.Height = ButtonJoinGame.Height
        Panel3.Top = ButtonJoinGame.Top
        'Brings menu selection identifier to button
    End Sub
    Private Sub ButtonLoadGame_Click(sender As Object, e As EventArgs) Handles ButtonLoadGame.Click
        Panel3.Height = ButtonLoadGame.Height
        Panel3.Top = ButtonLoadGame.Top
        'Brings menu selection identifier to button
    End Sub
    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click
        Panel3.Height = ButtonSettings.Height
        Panel3.Top = ButtonSettings.Top
        'Brings menu selection identifier to button
    End Sub
    Private Sub ButtonStatistics_Click(sender As Object, e As EventArgs) Handles ButtonStatistics.Click
        Panel3.Height = ButtonStatistics.Height
        Panel3.Top = ButtonStatistics.Top
        'Brings menu selection identifier to button
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
    '------------------------------Buttons---------------------------------------------------------

End Class
