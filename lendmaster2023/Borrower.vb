Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor
Public Class Borrower
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
    Private Sub Badhar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Badhar.KeyPress
        'Allow only numeric input and backspace key
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        'Allow only numeric input and backspace key
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        'Allow only numeric input and backspace key
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        'Allow only numeric input and backspace key
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Bphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Bphone.KeyPress
        'Allow only numeric input and backspace key
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Bsphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Bsphone.KeyPress
        'Allow only numeric input and backspace key
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Bname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Bname.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press if it is not a letter or a control character
        End If
    End Sub
    Private Sub Textbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press if it is not a letter or a control character
        End If
    End Sub
    Private Sub Populate()
        conn.Open()
        Dim query = "select * from borrower1"
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

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Borrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=#001;database=lendmaster"
        Populate()
    End Sub







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If Bname.Text = "" Then
            MessageBox.Show("Please Enter all the details")

        ElseIf Badhar.Text = "" Then
            MessageBox.Show("Please Enter all the details")



        ElseIf Baddress.Text = "" Then
            MessageBox.Show("Please Enter all the details")
        ElseIf Bemail.Text = "" Then
            MessageBox.Show("Please Enter all the details")
        ElseIf Bphone.TextLength < 10 Or Bphone.Textlength > 10 Then
            MessageBox.Show("invalid phone no.")
        ElseIf Bsphone.TextLength < 10 Or Bsphone.Textlength > 10 Then
            MessageBox.Show("invalid phone no.")
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("Please Enter all the details")
        ElseIf TextBox2.Text < 18 Then
            MessageBox.Show("Must BE ABOVE 18")
        ElseIf TextBox3.text < 50000 Then
            MessageBox.Show("salary is low must be more than 50000")
        ElseIf TextBox4.Text < 650 Then
            MessageBox.Show("borrower is not eligible ")
        ElseIf TextBox5.Text = "" Then
            MessageBox.Show("Please Enter all the details")
        Else
            sql = "INSERT into borrower1(
                            Name,
                            Adhar_no,
                            Adress,
                            Email,
                            phone,
                            Secondary_phone,
                            age,
                            salary,
                            cibil,
                            occupation,
                            collateral
                            ) 
                    values(
                        
                        '" & Bname.Text & "',
                        '" & Badhar.Text & "',
                        '" & Baddress.Text & "',
                        '" & Bemail.Text & "',
                        '" & Bphone.Text & "',
                        '" & Bsphone.Text & "',
                        '" & TextBox2.Text & "',
                        '" & TextBox3.Text & "',
                        '" & TextBox4.Text & "',
                        '" & TextBox1.Text & "',
                        '" & TextBox5.Text & "'
                    )  "

            connect()
            MessageBox.Show("Saved Succesfully")
            Bname.Text = ""
            Badhar.Text = ""
            Baddress.Text = ""
            Bemail.Text = ""
            Bphone.Text = ""
            Bsphone.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            conn.Close()
            Populate()


        End If
        conn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sql = "update borrower1 set Name='" & Bname.Text & "',
                            Adhar_no='" & Badhar.Text & "',
                            Adress='" & Baddress.Text & "',
                            Email='" & Bemail.Text & "',
                            phone='" & Bphone.Text & "',
                            Secondary_phone='" & Bsphone.Text & "' ,
                            age='" & TextBox2.Text & "',
                            salary='" & TextBox3.Text & "',
                            cibil='" & TextBox4.Text & "',
                            occupation='" & TextBox1.Text & "',
                            collateral='" & TextBox5.Text & "'

                            where Bid='" & Key & "'   "
        connect()

        If Bname.Text = "" Then
            MessageBox.Show("Please Enter all the details")

        ElseIf Badhar.Text = "" Then
            MessageBox.Show("Please Enter all the details")

        ElseIf Baddress.Text = "" Then
            MessageBox.Show("Please Enter all the details")
        ElseIf Bemail.Text = "" Then
            MessageBox.Show("Please Enter all the details")
        ElseIf Bphone.TextLength < 10 Or Bphone.Textlength > 10 Then
            MessageBox.Show("Please Enter the Correct Phone Number")
        ElseIf Bsphone.Text.Length < 10 Or Bsphone.Textlength > 10 Then
            MessageBox.Show("Please Enter all the details")
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("Please Enter all the details")
        ElseIf TextBox2.Text < 18 Then
            MessageBox.Show("Must BE ABOVE 18")
        ElseIf TextBox3.text < 50000 Then
            MessageBox.Show("Must be  more than 50000")
        ElseIf TextBox4.Text <= 650 Then
            MessageBox.Show("borrower is not eligible")
        ElseIf TextBox5.Text = "" Then
            MessageBox.Show("Please Enter all the details")
        Else
            MessageBox.Show("updated successfully")
            conn.Close()
            Populate()


        End If
    End Sub
    Dim Key = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        sql = "Delete from borrower1 where Bid=" & Key & ""

        connect()

        If Key = 0 Then
            MessageBox.Show("Select borrower information")




        Else
            MessageBox.Show("Deleted Succesfully")
            Bname.Text = ""
            Badhar.Text = ""
            Baddress.Text = ""
            Bemail.Text = ""
            Bphone.Text = ""
            Bsphone.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""

            conn.Close()
            Populate()


        End If
    End Sub


    Private Sub BorrowerDGV_CellMouseClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BorrowerDGV.CellMouseClick
        Dim row As DataGridViewRow = BorrowerDGV.Rows(e.RowIndex)
        Bname.Text = row.Cells(1).Value.ToString
        Badhar.Text = row.Cells(2).Value.ToString
        Baddress.Text = row.Cells(3).Value.ToString
        Bemail.Text = row.Cells(4).Value.ToString
        Bphone.Text = row.Cells(5).Value.ToString
        Bsphone.Text = row.Cells(6).Value.ToString

        TextBox1.Text = row.Cells(10).Value.ToString
        TextBox2.Text = row.Cells(7).Value.ToString
        TextBox3.Text = row.Cells(8).Value.ToString
        TextBox4.Text = row.Cells(9).Value.ToString
        TextBox5.Text = row.Cells(11).Value.ToString

        If Bname.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub BorrowerDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BorrowerDGV.CellContentClick

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Badhar_TextChanged(sender As Object, e As EventArgs) Handles Badhar.TextChanged

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Bphone_TextChanged(sender As Object, e As EventArgs) Handles Bphone.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class