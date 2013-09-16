Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click

        'Read the input from the user
        Dim fullname As String
        fullname = txtFullName.Text

        'Trim the input so as to remove leading spaces
        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        'Find the index of first space
        Dim idxSpace As Integer
        idxSpace = fullname.IndexOf(" ")

        'Extract the first name
        Dim firstname As String
        firstname = fullname.Substring(0, idxSpace)

        'Display the result to the user
        txtFirstName.Text = firstname


    End Sub

    Private Sub txtFullName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFullName.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged



    End Sub
End Class
