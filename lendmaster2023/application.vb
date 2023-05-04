Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor
Imports Mysqlx.Expect.Open.Types.Condition.Types
Imports Mysqlx.Notice


Public Class application
    Dim numberofYear As Integer
    Dim iMonthlyPayment, iTotalPayment As String
    Dim InterestRate, monthlyInterestRate, loanAmount, MonthlyPayment, TotalPayment As Double

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
        Dim query = "select Bid,name from borrower1"
        Dim adapter As MySqlDataAdapter
        adapter = New MySqlDataAdapter(query, conn)
        Dim builder As MySqlCommandBuilder
        builder = New MySqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        BorrowerDVG.DataSource = ds.Tables(0)


        conn.Close()
    End Sub
    Private Sub loan()
        conn.Open()
        Dim query = "select typeid,loantype,interest from loans1"
        Dim adapter As MySqlDataAdapter
        adapter = New MySqlDataAdapter(query, conn)
        Dim builder As MySqlCommandBuilder
        builder = New MySqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        loanDGV.DataSource = ds.Tables(0)


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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=#001;database=lendmaster"

        Populate()
        loan()





    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        InterestRate = Convert.ToDouble(TextBox1.Text)
        monthlyInterestRate = InterestRate / 1200
        numberofYear = Convert.ToInt32(TextBox4.Text)
        loanAmount = Convert.ToDouble(TextBox3.Text)
        MonthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberofYear))
        iMonthlyPayment = Convert.ToString(MonthlyPayment)






        Label19.Text = MonthlyPayment


        TotalPayment = loanAmount * numberofYear / 12 * InterestRate / 100
        iTotalPayment = (TotalPayment + loanAmount)
        Label26.Text = (iTotalPayment)

        


    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)

    End Sub
    Dim key = 0

    Private Sub BorrowerDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Dim row As DataGridViewRow = BorrowerDVG.Rows(e.RowIndex)
        TextBox6.Text = row.Cells(0).Value.ToString
        TextBox2.Text = row.Cells(1).Value.ToString
        If TextBox2.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub loanDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles loanDGV.CellMouseClick
        Dim row As DataGridViewRow = loanDGV.Rows(e.RowIndex)

        TextBox5.Text = row.Cells(1).Value.ToString
        TextBox1.Text = row.Cells(2).Value.ToString
        If TextBox5.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub Label13_Click_1(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        Label26.Text = ""
        Label19.Text = ""
        TextBox7.Text = ""


    End Sub

    Private Sub BorrowerDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub BorrowerDVG_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BorrowerDVG.CellMouseClick
        Dim row As DataGridViewRow = BorrowerDVG.Rows(e.RowIndex)
        TextBox6.Text = row.Cells(0).Value.ToString
        TextBox2.Text = row.Cells(1).Value.ToString
        If TextBox2.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub loanDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles loanDGV.CellContentClick

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub



    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox7.Text = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        If TextBox2.Text = "" Then

            MessageBox.Show("Please select borrower")

        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Please Enter all the details")
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("Please Enter all the details")

        ElseIf DateTimePicker1.Value = Nothing Then

            MessageBox.Show("Please Enter all the details")
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("please enter details")
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("please enter details")


        Else
            sql = "INSERT into app(
                            custid,
                            name,
                            loantype,
                            loaninterest,
                            loanamnt,
                            issuedate,
                            periodyear,
                           
                            totalpayment,
                            monthly
                            ) 
                    values(
                        '" & TextBox6.Text & "',
                        '" & TextBox2.Text & "',
                        '" & TextBox5.Text & "',
                        '" & TextBox1.Text & "',
                        '" & TextBox3.Text & "',
                        '" & TextBox7.Text & "',
                        '" & TextBox4.Text & "',
                       
                        '" & Label26.Text & "',
                        '" & Label19.Text & "'
                              
                    )  "


            connect()
            MessageBox.Show("Saved Succesfully")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            Label26.Text = ""
            Label19.Text = ""
            TextBox7.Text = ""
            conn.Close()




        End If


    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub




End Class