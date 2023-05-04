Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor
Public Class report
    Dim conn As MySqlConnection = New MySqlConnection
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sql, sql2, User As String
    Dim dt As DataTable
    Public Sub connect()

        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        conn.Open()
        dr = cmd.ExecuteReader
    End Sub
    Private Sub Populate()
        conn.Open()
        Dim query = "select loanno,name,status from app"
        Dim adapter As MySqlDataAdapter
        adapter = New MySqlDataAdapter(query, conn)
        Dim builder As MySqlCommandBuilder
        builder = New MySqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)


        conn.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

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

    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=#001;database=lendmaster"
        Populate()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox1.Text = Format(DateTimePicker1.Value, "yyyy/MM/dd")

        Dim connection As MySqlConnection = New MySqlConnection()
        connection.ConnectionString = "server=localhost;user id=root;port=3306;password=#001;database=lendmaster"
        connection.Open()
        Dim adp2 As MySqlDataAdapter = New MySqlDataAdapter("select * from payment where paymentdate= '" & TextBox1.Text & "' order by paymentid ", connection)
        Dim dt2 As DataTable = New DataTable()
        adp2.Fill(dt2)
        DataGridView2.DataSource = dt2


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class