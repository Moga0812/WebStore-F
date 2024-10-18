Imports System.IO

Imports System.IO.File

Public Class Library

    ' Example in-memory list for the library
    Dim userLibrary As New List(Of Game)

    ' Load the user's purchased games into the library
    Private Sub LibraryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear the current items in the list (if any)
        lstLibraryGames.Items.Clear()

        ' Populate the list with games from the user's library
        For Each game In userLibrary
            lstLibraryGames.Items.Add(game.Title)
        Next
    End Sub
    Private Sub lstOwnedGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLibraryGames.SelectedIndexChanged
        If lstLibraryGames.SelectedItem IsNot Nothing Then
            Dim selectedGameTitle As String = lstLibraryGames.SelectedItem.ToString()
            Dim selectedGame As Game = userLibrary.FirstOrDefault(Function(g) g.Title = selectedGameTitle)

            If selectedGame IsNot Nothing Then
                lblLibraryTitle.Text = selectedGame.Title
                picLibraryImage.Image = Image.FromFile(selectedGame.ImagePath)
            End If
        End If
    End Sub
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If lstLibraryGames.SelectedItem IsNot Nothing Then
            Dim selectedGameTitle As String = lstLibraryGames.SelectedItem.ToString()
            Dim selectedGame As Game = userLibrary.FirstOrDefault(Function(g) g.Title = selectedGameTitle)

            If selectedGame IsNot Nothing Then
                MessageBox.Show("Cant launch game cause this isnt a real app :)", "YAY!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a game to launch.")
        End If
    End Sub

    ' Example of saving to a text file (simple method)
    Private Sub SaveLibrary()
        Using writer As New StreamWriter("userLibrary.txt")
            For Each game In userLibrary
                writer.WriteLine(game.Title)
            Next
        End Using
    End Sub

    Private Sub btnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click
        Dim storeForm As New StorePage()
        storeForm.Show()
        Me.Hide()
    End Sub
End Class