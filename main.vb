'Program name: Double A Delivery
'Members: Anthony Cob, Adimir Gongora
'Course: CS206 Programming II
Public Class main
    'variable will store what option user chooses
    Public strchoice As String
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = LogIn.strUsername
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnOrderBurger_Click(sender As Object, e As EventArgs) Handles btnOrderBurger.Click
        strchoice = "Burger"
        Me.Hide()
        address.Show()
    End Sub
    Private Sub btnOrderPizza_Click(sender As Object, e As EventArgs) Handles btnOrderPizza.Click
        strchoice = "Pizza"
        Me.Hide()
        address.Show()
    End Sub
End Class