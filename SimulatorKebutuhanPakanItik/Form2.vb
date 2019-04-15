Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim b = 0
        For a As Integer = 0 To 20

            ListBox1.Items.Add(b)
            b += 7

        Next



    End Sub
End Class