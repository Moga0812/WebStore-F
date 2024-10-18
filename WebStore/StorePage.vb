'-------------------------------------------------
'Prgoram: Game Store
'Autther: Massimo Gambardella
'Purpose: To display and purchase games
'-------------------------------------------------

Imports System.IO
Imports System.Xml.Serialization

Public Class StorePage

    ' In-memory list to store available games in the store
    Dim storeGames As New List(Of Game)
    Dim userLibrary As New List(Of Game)
    ' Example: Load games from a list
    ' Dim games As New List(Of Game) From {
    ' New Game With {.Title = "Game 1", .Description = "An exciting adventure.", .Price = 19.99D, .ImagePath = "game1.jpg", .Genre = "Adventure"},
    ' New Game With {.Title = "Game 2", .Description = "A thrilling puzzle game.", .Price = 29.99D, .ImagePath = "game2.jpg", .Genre = "Puzzle"}
    ' }

    Private Const XmlFilePath As String = "games.xml"


    Private Sub StorePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadGamesFromXml("games.xml")

        lstGames.Items.Clear()


        For Each game In storeGames
            lstGames.Items.Add(game.Title & " - $" & game.Price.ToString("F2"))
        Next

        ' Populate the ComboBox with filter options
        cmbFilter.Items.Add("All")
        cmbFilter.Items.Add("Action")
        cmbFilter.Items.Add("Adventure")
        cmbFilter.Items.Add("RPG")
        cmbFilter.Items.Add("Indie")
        cmbFilter.Items.Add("Strategy")
        cmbFilter.Items.Add("Puzzle")
        cmbFilter.SelectedIndex = 0

        ' Load the games initially
        LoadStoreGames()
    End Sub

    Private Sub LoadGamesFromXml(filePath As String)
        Try
            If File.Exists(filePath) Then
                Dim serializer As New XmlSerializer(GetType(List(Of Game)))
                Using fileStream As New FileStream(filePath, FileMode.Open)
                    storeGames = CType(serializer.Deserialize(fileStream), List(Of Game))
                End Using
            Else
                MessageBox.Show("The file " & filePath & " could not be found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading games: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub lstGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGames.SelectedIndexChanged
        If lstGames.SelectedItem IsNot Nothing Then
            Dim selectedGameTitle As String = lstGames.SelectedItem.ToString().Split("-"c)(0).Trim()
            Dim selectedGame As Game = storeGames.FirstOrDefault(Function(g) g.Title = selectedGameTitle)

            If selectedGame IsNot Nothing Then
                lblTitle.Text = selectedGame.Title
                lblDescription.Text = selectedGame.Description
                lblPrice.Text = "$" & selectedGame.Price.ToString("F2")
                picGameImage.Image = Image.FromFile(selectedGame.ImagePath)
            End If
        End If
    End Sub
    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        ' Ensure a game is selected from the store
        If lstGames.SelectedItem IsNot Nothing Then
            ' Get the selected game title
            Dim selectedGameTitle As String = lstGames.SelectedItem.ToString().Split("-"c)(0).Trim()

            ' Find the selected game in the store
            Dim selectedGame As Game = storeGames.FirstOrDefault(Function(g) g.Title = selectedGameTitle)

            If selectedGame IsNot Nothing Then
                ' Check if the game is already in the user's library
                If Not userLibrary.Any(Function(g) g.Title = selectedGame.Title) Then
                    ' Add the selected game to the user's library
                    userLibrary.Add(selectedGame)
                    MessageBox.Show($"{selectedGame.Title} has been added to your library!", "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("You already own this game!", "Purchase Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("Please select a game to purchase.", "Purchase Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Call the search function when the user clicks the search button
        SearchGames(txtSearch.Text)
    End Sub

    Private Sub SearchGames(searchTerm As String)
        ' Clear the current items in the list
        lstGames.Items.Clear()

        ' Filter and display games that match the search term
        For Each game In storeGames
            ' Match games based on title or description
            If game.Title.ToLower().Contains(searchTerm.ToLower()) OrElse game.Description.ToLower().Contains(searchTerm.ToLower()) Then
                lstGames.Items.Add(game.Title & " - $" & game.Price.ToString("F2"))
            End If
        Next
    End Sub


    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        ' Filter the games list based on the selected filter option
        LoadStoreGames()
    End Sub

    Private Sub LoadStoreGames()
        ' Clear the current items in the list
        lstGames.Items.Clear()

        ' Get the selected filter option
        Dim selectedFilter As String = cmbFilter.SelectedItem.ToString()

        ' Filter and display games based on the selected filter option
        For Each game In storeGames
            If selectedFilter = "All" OrElse game.Genre = selectedFilter Then
                lstGames.Items.Add(game.Title & " - $" & game.Price.ToString("F2"))
            End If
        Next
    End Sub

    Private Sub btnLibrary_Click(sender As Object, e As EventArgs) Handles btnLibrary.Click
        Dim libraryForm As New Library()
        libraryForm.Show()
        Me.Hide()
    End Sub
End Class

<Serializable>
Public Class Game
    Public Property Title As String
    Public Property Description As String
    Public Property Price As Decimal
    Public Property ImagePath As String
    Public Property Genre As String

End Class

<Serializable>
Public Class GamesList
    Public Property Games As List(Of Game)
End Class


