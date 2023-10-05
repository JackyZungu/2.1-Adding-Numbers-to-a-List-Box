Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim counter As Integer  -- Adding Numbers to a List Box
        'For counter = 1 To 10
        'ListBox1.Items.Add(counter)
        'Next

        ' Dim counter, sum As Integer     Negative Increment in a For Next Loop
        'sum = 1000
        'For counter = 100 To 5 Step -5
        'sum -= counter
        'ListBox1.Items.Add(sum)
        'Next

        Dim range As Integer 'Exist for
        For n = 1 To 5
            range += 1
            MsgBox(range)
            If range = 4 Then
                Exit For
            End If
        Next
        MsgBox("It out of range")

    End Sub
End Class
