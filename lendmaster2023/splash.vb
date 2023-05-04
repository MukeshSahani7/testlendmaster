Public Class splash
    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyprogressBar1.Increment(5)
        PercentageLb1.Text = Convert.ToString(MyprogressBar1.Value) + "%"
        If MyprogressBar1.Value = 100 Then
            Me.Hide()
            Dim log = New Login
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles PercentageLb1.Click

    End Sub

    Private Sub MyprogressBar1_ValueChanged(sender As Object, e As EventArgs) Handles MyprogressBar1.ValueChanged

    End Sub
End Class