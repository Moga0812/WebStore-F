

Public Class Form1

    Private Sub StoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Example: Load games from a list
        Dim games As New List(Of Game) From {
            New Game With {.Title = "Game 1", .Description = "An exciting adventure.", .Price = 19.99D, .ImagePath = "game1.jpg"},
            New Game With {.Title = "Game 2", .Description = "A thrilling puzzle game.", .Price = 29.99D, .ImagePath = "game2.jpg"}
        }

        For Each game In games
            lstGames.Items.Add(game.Title & " - $" & game.Price.ToString("F2"))
        Next
    End Sub


End Class

