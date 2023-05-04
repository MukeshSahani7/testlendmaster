Imports System.Data.SqlTypes
Imports MySql.Data.MySqlClient

Public Class Dashboard


    Dim conn As MySqlConnection = New MySqlConnection

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim obj As New Dashboard()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim obj As New Borrower()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim obj As New loan()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim obj As New application()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim obj As New payment()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim obj As New report()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=#001;database=lendmaster"
        Dim borrowernum As Integer
        conn.Open()
        Dim sql = "select COUNT(Bid) from borrower1"
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(sql, conn)
        borrowernum = cmd.ExecuteScalar
        borrowerlbl.Text = borrowernum
        conn.Close()






        Dim loannum As Integer
        conn.Open()
        sql = "select COUNT(typeid) from loans1"

        cmd = New MySqlCommand(sql, conn)
        loannum = cmd.ExecuteScalar
        Label12.Text = loannum
        conn.Close()



        Dim appnum As Integer
        conn.Open()
        sql = "select COUNT(loanno) from app"

        cmd = New MySqlCommand(sql, conn)
        appnum = cmd.ExecuteScalar
        Label14.Text = appnum
        conn.Close()


        Dim actnum As Integer
        conn.Open()
        sql = " SELECT COUNT(status) FROM app WHERE status = 'Active' "

        cmd = New MySqlCommand(sql, conn)
        actnum = cmd.ExecuteScalar
        Label16.Text = actnum
        conn.Close()

        Dim paidnum As Integer
        conn.Open()
        sql = " SELECT COUNT(status) FROM app WHERE status = 'paid' "

        cmd = New MySqlCommand(sql, conn)
        paidnum = cmd.ExecuteScalar
        Label19.Text = paidnum
        conn.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim obj As New Borrower()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class