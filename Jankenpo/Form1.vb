Public Class Form1
    Const PAPER = 1
    Const ROCK = 2
    Const SCISSORS = 3
    Dim user_selection As Integer
    Private Function get_computer_selection()
        Return CInt(Int((3 * Rnd()) + 1))
    End Function

    Private Sub cmdPaper_Click(sender As Object, e As EventArgs) Handles cmdPaper.Click
        user_selection = 1
        evaluate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdRock.Click
        user_selection = 2
        evaluate()
    End Sub

    Private Sub cmdScissors_Click(sender As Object, e As EventArgs) Handles cmdScissors.Click
        user_selection = 3
        evaluate()
    End Sub

    Private Sub evaluate()
        Dim computer_selection As Integer
        computer_selection = get_computer_selection()

        If ((user_selection = PAPER And computer_selection = ROCK) Or (user_selection = ROCK And computer_selection = SCISSORS) Or (user_selection = SCISSORS And computer_selection = PAPER)) Then
            MsgBox("You win. Computer selected '" & get_string_computer_selection(computer_selection) & "'")
        ElseIf user_selection <> computer_selection Then
            MsgBox("Computer win. Computer selected '" & get_string_computer_selection(computer_selection) & "'")
        Else
            MsgBox("Draw. Computer selected '" & get_string_computer_selection(computer_selection) & "'")
        End If
    End Sub

    Private Function get_string_computer_selection(computer_selection As Integer)
        If computer_selection = ROCK Then
            Return "Rock"
        End If

        If computer_selection = PAPER Then
            Return "Paper"
        End If

        Return "Scissors"
    End Function
End Class
