'Program name: Double A Delivery
'Members: Anthony Cob, Adimir Gongora
'Course: CS206 Programming II
Public Class address
    'varibles (Address)
    Public strType As String
    Public strStAdd As String
    Public strAptNum As String
    Public strCity As String
    Public strDistrict As String
    Public strZip As String

    Private Sub address_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = LogIn.strUsername
    End Sub

    'open form depending on user choice
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'check if *required fields are empty
        If String.IsNullOrEmpty(txtStrAdd.Text.Trim) Then
            errStAdd.SetError(txtStrAdd, "This field is required")
        Else 'if empty prompt error message
            errStAdd.SetError(txtStrAdd, String.Empty)
            strStAdd = txtStrAdd.Text
        End If
        If String.IsNullOrEmpty(txtCity.Text.Trim) Then
            errCity.SetError(txtCity, "This field is required")
        Else
            errCity.SetError(txtCity, String.Empty)
            strCity = txtCity.Text
        End If
        If String.IsNullOrEmpty(txtDistrict.Text.Trim) Then
            errDistrict.SetError(txtDistrict, "This field is required")
        Else
            errDistrict.SetError(txtDistrict, String.Empty)
            strDistrict = txtDistrict.Text
        End If
        If String.IsNullOrEmpty(txtZip.Text.Trim) Then
            errZip.SetError(txtZip, "This field is required")
        Else
            errZip.SetError(txtZip, String.Empty)
            strZip = txtZip.Text
        End If
        If txtStrAdd.Text <> "" And txtCity.Text <> "" And txtDistrict.Text <> "" And txtZip.Text <> "" Then
            Me.Hide()
            If main.strchoice = "Pizza" Then
                Me.Hide()
                pizza.Show()
            ElseIf main.strchoice = "Burger" Then
                Me.Hide()
                burger.Show()
            ElseIf main.strchoice = "Pasta" Then
                Me.Hide()
                pasta.Show()
            End If
        End If
        strType = txtAddType.Text
        strAptNum = txtApt.Text
        strDistrict = txtDistrict.Text
    End Sub
    'make textbox accept numbers only
    Private Sub txtZip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtZip.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAddType.Text = ""
        txtApt.Text = ""
        txtCity.Text = ""
        txtDistrict.Text = ""
        txtStrAdd.Text = ""
        txtZip.Text = ""
    End Sub
End Class