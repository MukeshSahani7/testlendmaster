Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor
Imports Mysqlx.Expect.Open.Types.Condition.Types
Imports Mysqlx.Notice

Public Class loan
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
        Dim query = "select * from loans1"
        Dim adapter As MySqlDataAdapter
        adapter = New MySqlDataAdapter(query, conn)
        Dim builder As MySqlCommandBuilder
        builder = New MySqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        BorrowerDGV.DataSource = ds.Tables(0)


        conn.Close()
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        'Allow only numeric input and backspace key
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press if it is not a letter or a control character
        End If
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
    Dim Key = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "Delete from loans1 where typeid=" & Key & ""

        connect()

        If Key = 0 Then
            MessageBox.Show("Select borrower information")




        Else
            MessageBox.Show("Deleted Succesfully")
            TextBox1.Text = ""
            TextBox2.Text = ""
            conn.Close()
            Populate()
        End If
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "INSERT into loans1(
                            loantype,
                            interest
                           
                            
                            ) 
                    values(
                        
                        '" & TextBox1.Text & "',
                        '" & TextBox2.Text & "'
                      
                    )  "
        connect()

        If TextBox1.Text = "" Then
            MessageBox.Show("Please Enter all the details")

        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Please Enter all the details")


        Else
            MessageBox.Show("Saved Succesfully")
            TextBox1.Text = ""
            TextBox2.Text = ""
            conn.Close()
            Populate()



        End If
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sql = "update loans1 set loantype='" & TextBox1.Text & "',
                            interest='" & TextBox2.Text & "' where typeid ='" & Key & "'  
                               "

        connect()

        If TextBox1.Text = "" Then
            MessageBox.Show("Please Enter all the details")

        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Please Enter all the details")


        Else
            MessageBox.Show("updated successfully")
            TextBox1.Text = ""
            TextBox2.Text = ""
            conn.Close()

            Populate()



        End If
        conn.Close()
    End Sub

    Private Sub BorrowerDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BorrowerDGV.CellMouseClick
        Dim row As DataGridViewRow = BorrowerDGV.Rows(e.RowIndex)
        TextBox1.Text = row.Cells(1).Value.ToString
        TextBox2.Text = row.Cells(2).Value.ToString

        If TextBox1.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub BorrowerDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BorrowerDGV.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=#001;database=lendmaster"
        Populate()
    End Sub
End Class