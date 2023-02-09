'Program name: Double A Delivery
'Members: Anthony Cob, Adimir Gongora
'Course: CS206 Programming II
Public Class pizza
    'variables
    Public rbPizzaType As String
    Public chbSides As String
    Public total As Double

    Private Sub pizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = LogIn.strUsername
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        'code for pizza type radio buttons
        If rbClasPep.Checked Then
            total += 14
        ElseIf rbThiCru.Checked Then
            total += 17
        ElseIf rbStufCPep.Checked Then
            total += 24
        ElseIf rbHulaHa.Checked Then
            total += 20
        ElseIf rbVeggie.Checked Then
            total += 24
        ElseIf rbMeat.Checked Then
            total += 22
        End If
        'code for sides check boxes
        If chBbq.Checked Then
            total += 10
        End If

        If chBuffalo.Checked Then
            total += 10
        End If

        If chRanch.Checked Then
            total += 3
        End If

        If chBuffRan.Checked Then
            total += 3
        End If
        If chBreSti.Checked Then
            total += 7
        End If

        If chBrow.Checked Then
            total += 5
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        address.Show()
    End Sub
End Class