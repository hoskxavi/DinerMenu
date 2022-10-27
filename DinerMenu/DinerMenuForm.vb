'Xavier Hoskins
'RCET 0265
'Fall 2022
'Diner Menu
'https://www.github.com/hoskxavi/DinerMenu

Public Class DinerMenuForm
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        SpecialsNameBox.Text = "~ Soup of the Day ~"
        SpecialsTextBox.Text = "Todays soup special is a Chicken Noodle with no chicken. Perfect for anyone who enjoys canned soup or just plain noodles."
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        SpecialsNameBox.Text = "~ Chef's Special ~"
        SpecialsTextBox.Text = "The chef's special is a bland salad composed of pure lettuce. The perfect salad for all you vegetarians and rabbits."
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        SpecialsNameBox.Text = "~ Fresh, Mediocre Fish ~"
        SpecialsTextBox.Text = "Today we have a fresh grilled salmon fillet with our own Secret Sauce, providing a lovely taste of failure and regret."
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        MsgBox("Ok then, enjoy your day without food.")
        Me.Close()
    End Sub
End Class
