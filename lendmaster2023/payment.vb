Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor
Imports Mysqlx.Expect.Open.Types.Condition.Types
Imports Mysqlx.Notice

Public Class payment
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
        Dim query = "select loanno ,name,monthly, totalpayment from app "



        Dim adapter As MySqlDataAdapter

        adapter = New MySqlDataAdapter(query, conn)
        Dim builder As MySqlCommandBuilder
        builder = New MySqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        appDGV.DataSource = ds.Tables(0)


        conn.Close()
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

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
    Dim key = 0

    Private Sub appDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles appDGV.CellMouseClick
        Dim row As DataGridViewRow = appDGV.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(0).Value.ToString
        TextBox2.Text = row.Cells(1).Value.ToString


        Dim monthly As Integer
        conn.Open()
        sql = " SELECT monthly from app where loanno = '" & TextBox1.Text & "'"

        cmd = New MySqlCommand(sql, conn)
        monthly = cmd.ExecuteScalar
        Label19.Text = monthly
        conn.Close()




        If TextBox1.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox7.Text = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        sql = "INSERT into payment(
                            Bid,
                            name,
                            amount,
                            paymentdate
                            
                            ) 
                    values(
                        
                        '" & TextBox1.Text & "',
                        '" & TextBox2.Text & "',
                        '" & TextBox3.Text & "',
                        '" & TextBox7.Text & "'
                       
                    )  "
        connect()

        conn.Close()
        Populate()



        MessageBox.Show("payment successfull")




        sql = "update app  
                   SET totalpayment = Totalpayment-'" & TextBox3.Text & "' 
                   where loanno = '" & TextBox1.Text & "' 
               "
        connect()

        conn.Close()
        Populate()






        sql = " UPDATE app SET Status = 'Paid' WHERE totalpayment = 0;"
        connect()
        conn.Close()

        Populate()




    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=#001;database=lendmaster"
        Populate()

        Dim query As String = "select name from app where custid='" & TextBox1.Text & "' "
        Dim comand As New MySqlCommand(query, conn)
        conn.Open()
        Dim name As String = comand.ExecuteScalar()
        conn.Close()
        TextBox2.Text = name
        Populate()




        Dim monthly As Integer
        conn.Open()
        sql = " SELECT monthly from app where loanno = '" & TextBox1.Text & "'"

        cmd = New MySqlCommand(sql, conn)
        monthly = cmd.ExecuteScalar
        Label19.Text = monthly
        conn.Close()










    End Sub
End Class