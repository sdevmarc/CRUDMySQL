Imports MySql.Data.MySqlClient
Module SQLModule
    Dim constring As String = "server=localhost; user=root; password=1234; database=dbcrud_attendance;"
    Dim conn As New MySqlConnection(constring)
    Dim cmd As MySqlCommand

    Sub ConnectDB(userin As String)
        If (userin = "con") Then
            conn.Open()
        ElseIf ("dis") Then
            conn.Close()
        End If
    End Sub

    'TEXTBOX DB RETRIEVAL
    Sub RetrieveTxt(ID As Object)
        cmd = New MySqlCommand("select * from tbl_students WHERE id_number like '%" & ID & "%'", conn)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            Main.txtID.Text = read.GetString("id_number")
            Main.txtLN.Text = read.GetString("lastname")
            Main.txtFN.Text = read.GetString("firstname")
            Main.txtCOURSE.Text = read.GetString("course")
            Main.txtYEAR.Text = read.GetString("year")
            Main.txtADD.Text = read.GetString("address")
        End While
        read.Close()
    End Sub

    'SEARCH / READ
    Sub SearchData(ID As Object, grid As Object)
        grid.Rows.Clear()
        cmd = New MySqlCommand("select * from tbl_students WHERE id_number like '%" & ID & "%'", conn)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.Rows.Add(read("id"), read("id_number"), read("lastname"), read("firstname"), read("course"), read("year"), read("address"))
        End While
        read.Close()
    End Sub

    'INSERT
    Sub AddFields(ID As String, LN As String, FN As String, CO As String, YR As String, ADD As String)
        cmd = New MySqlCommand("Insert into tbl_students (id_number, lastname, firstname, course, year, address) values (@id, @ln, @fn, @cr, @year, @add)", conn)
        cmd.Parameters.AddWithValue("@id", ID)
        cmd.Parameters.AddWithValue("@ln", LN)
        cmd.Parameters.AddWithValue("@fn", FN)
        cmd.Parameters.AddWithValue("@cr", CO)
        cmd.Parameters.AddWithValue("@year", YR)
        cmd.Parameters.AddWithValue("@add", ADD)

        Dim i As Integer = cmd.ExecuteNonQuery
        If (i = 1) Then
            MessageBox.Show("The student has been registered!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'READ
    Sub ShowData(grid As Object)
        grid.Rows.Clear()
        cmd = New MySqlCommand("Select * from tbl_students", conn)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.Rows.Add(read("id"), read("id_number"), read("lastname"), read("firstname"), read("course"), read("year"), read("address"))
        End While
        read.Close()
    End Sub

    'UPDATE
    Sub UpdateData()
        cmd = New MySqlCommand("Update tbl_students set id_number = @theStud, lastname = @ln, firstname = @fn, course = @cr, year = @yr, address = @add where id_number = @studID", conn)
        cmd.Parameters.AddWithValue("@theStud", Main.txtID.Text)
        cmd.Parameters.AddWithValue("@ln", Main.txtLN.Text)
        cmd.Parameters.AddWithValue("@fn", Main.txtFN.Text)
        cmd.Parameters.AddWithValue("@cr", Main.txtCOURSE.Text)
        cmd.Parameters.AddWithValue("@yr", Main.txtYEAR.Text)
        cmd.Parameters.AddWithValue("@add", Main.txtADD.Text)
        cmd.Parameters.AddWithValue("@studID", Main.txtSEARCH.Text)
        cmd.ExecuteNonQuery()
    End Sub

    'DELETE
    Sub DeleteData()
        cmd = New MySqlCommand("delete from tbl_students where id_number = @studID", conn)
        cmd.Parameters.AddWithValue("studID", Main.txtSEARCH.Text)
        cmd.ExecuteNonQuery()
    End Sub
End Module
