Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class Login
    Public conn As MySqlConnection = New MySqlConnection
    Public cmd As MySqlCommand = New MySqlCommand

    Public dr As MySqlDataReader
    Public sql, sql2, User As String
    Public dt As DataTable


    Public Sub connect()

        cmd.CommandText = sql

        cmd.CommandType = CommandType.Text

        cmd.Connection = conn

        conn.Open()
        dr = cmd.ExecuteReader



    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=#001;database=lendmaster"

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "SELECT * FROM admin WHERE UserName = '" & TextBox1.Text & "' AND Password= '" & TextBox2.Text & "' "

        connect()


        If dr.Read Then
            MsgBox("Login Successful")
            Me.Hide()
            Dashboard.Show()




        Else
            MsgBox("Invalid Username or Password")

        End If

        conn.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
