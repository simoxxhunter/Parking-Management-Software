Imports System.Data
Imports System.Data.OleDb


Public Class Frm_employers

    Dim mabase As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\BD_gestion_parking.mdb"
    Dim maconection As New OleDbConnection(mabase)
    Dim dtset As New DataSet
    Dim savinto As New OleDbCommand
    Dim sql_employer As String = "SELECT * FROM TB_employer"
    Dim dataAdapter As New OleDbDataAdapter(sql_employer, maconection)
    Dim TB_employer As DataTable


   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butt_edit.Click

        Dim n As String = Trim(Txt_idemployer.Text)
        Dim Edit_into As New OleDb.OleDbCommand
        Dim dtAdapter As New OleDbDataAdapter(sql_employer, maconection)
        Edit_into.Connection = maconection
        Edit_into.CommandType = CommandType.Text
        Edit_into.CommandText = "UPDATE TB_employer SET emp_name='" & Trim(txt_empname.Text) & "', emp_tel='" & Trim(txt_emptel.Text) & "', emp_cin='" & Trim(txt_empcin.Text) & "', emp_adresse='" & Trim(txt_empadress.Text) & "' WHERE ID_employer=" & n


        maconection.Open()
        Edit_into.ExecuteNonQuery()
        MsgBox("you modification has been succesfull.")

        txt_empname.DataBindings.Clear()
        txt_empadress.DataBindings.Clear()
        txt_empcin.DataBindings.Clear()
        txt_emptel.DataBindings.Clear()

        dtset.Tables("TB_employer").Clear()
        dtAdapter.Fill(dtset, "TB_employer")
        DataGridView1.DataSource = dtset.Tables("TB_employer")
        maconection.Close()

    End Sub

    Private Sub but_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_add.Click
   


        Dim insertCmd As New OleDbCommand("INSERT INTO TB_employer (emp_name, emp_tel, emp_CIN, emp_adresse) VALUES (@Name, @Tel, @CIN, @Address)", maconection)
        insertCmd.Parameters.AddWithValue("@Name", txt_empname.Text.Trim())
        insertCmd.Parameters.AddWithValue("@Tel", txt_emptel.Text.Trim())
        insertCmd.Parameters.AddWithValue("@CIN", txt_empcin.Text.Trim())
        insertCmd.Parameters.AddWithValue("@Address", txt_empadress.Text.Trim())

        maconection.Open()
        insertCmd.ExecuteNonQuery()
        maconection.Close()
        dtset.Clear()
        dataAdapter.Fill(dtset, "TB_employer")
        DataGridView1.DataSource = dtset.Tables("TB_employer")

        MessageBox.Show("Employer added successfully.")
    End Sub

    Private Sub But_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_delete.Click
        Dim empid As String = Txt_idemployer.Text.Trim()

        If String.IsNullOrEmpty(empid) Then
            MsgBox("Please enter the employer id.")
            Return
        End If

        If MsgBox("Are you sure you want to delete this employer?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Return
        End If

        Dim del_cmd As New OleDb.OleDbCommand
        del_cmd.Connection = maconection
        del_cmd.CommandType = CommandType.Text
        del_cmd.CommandText = "DELETE FROM TB_employer WHERE id_employer = @empid"
        del_cmd.Parameters.AddWithValue("@empid", empid)

        Try
            maconection.Open()
            Dim rowsAffected As Integer = del_cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                Dim dataRow As DataRow = dtset.Tables("TB_employer").AsEnumerable().FirstOrDefault(Function(row) Convert.ToString(row.Field(Of Object)("id_employer")) = empid)
                If dataRow IsNot Nothing Then
                    dtset.Tables("TB_employer").Rows.Remove(dataRow)
                    dtset.Tables("TB_employer").AcceptChanges()
                    DataGridView1.DataSource = dtset.Tables("TB_employer")
                    MsgBox("Deleted Successfully")
                End If
            Else
                MsgBox("No subscriber found with the specified subscription number.")
            End If
        Catch ex As Exception
            MsgBox("Error deleting subscriber: " & ex.Message)
        Finally
            maconection.Close()
        End Try
    End Sub
    Private Sub Frm_employers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_gestion_parkingDataSet1.TB_employer' table. You can move, or remove it, as needed.
        Me.TB_employerTableAdapter.Fill(Me.BD_gestion_parkingDataSet1.TB_employer)

        Dim dataTable As New DataTable()
        dataAdapter.Fill(dataTable)
        maconection.Open()
        Dim dtAdapter As New OleDbDataAdapter(sql_employer, maconection)
        dtAdapter.Fill(dtset, "TB_employer")
        maconection.Close()
        Txt_idemployer.DataBindings.Add("text", dtset, "TB_employer.id_employer")
        txt_empname.DataBindings.Add("text", dtset, "TB_employer.emp_name")
        txt_empcin.DataBindings.Add("text", dtset, "TB_employer.emp_cin")
        txt_empadress.DataBindings.Add("text", dtset, "TB_employer.emp_adresse")
        txt_emptel.DataBindings.Add("text", dtset, "TB_employer.emp_tel")


    End Sub

End Class