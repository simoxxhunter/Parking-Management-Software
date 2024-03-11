Imports System.Data
Imports System.Data.OleDb

Public Class Frm_checkin

    Dim mabase As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\BD_gestion_parking.mdb"
    Dim maconection As New OleDbConnection(mabase)
    Dim dtset As New DataSet
    Dim savinto As New OleDbCommand
    Dim sql_checkin As String = "SELECT * FROM TB_checkin"

    Private Function GetMostRecentTicketNumber() As Integer
        Dim ticketNumber As Integer = 0
        Dim query As String = "SELECT MAX(ticket_id) FROM TB_checkin"

        Using connection As New OleDbConnection(mabase)
            Using command As New OleDbCommand(query, connection)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()

                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    ticketNumber = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return ticketNumber
    End Function


    Private Sub But_checkout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_checkout.Click
        Me.Hide()
        Frm_checkout.Show()
    End Sub

    Private Sub But_managesubs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_managesubs.Click
        Me.Hide()
        Frm_Managesubs.Show()

    End Sub

    Private Sub But_managereservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_managereservations.Click
        Me.Hide()
        Frm_Managereservations.Show()
    End Sub

    Private Sub But_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Logout.Click
        Me.Hide()
        MDI_Home.Hide()

        Login.Show()
    End Sub

    Private Sub But_print_ticket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_print_ticket.Click
        Dim plateNumber As String = Txt_plateNO.Text.Trim()
        Dim classType As String = Cmb_classtype.Text.Trim()
        Dim vehicleType As String = Cmb_vehtype.Text.Trim()
        Dim checkinDateTime As Date = Date.Now


        If String.IsNullOrEmpty(plateNumber) OrElse String.IsNullOrEmpty(classType) OrElse String.IsNullOrEmpty(vehicleType) Then
            MsgBox("Please enter all the required information.")
            Return
        End If


        Dim insertCmd As New OleDbCommand
        insertCmd.Connection = maconection
        insertCmd.CommandType = CommandType.Text
        insertCmd.CommandText = "INSERT INTO TB_checkin (Plate_number, Class_type, vehicle_type, Checkin_date_and_time) VALUES (?, ?, ?, ?)"
        insertCmd.Parameters.AddWithValue("@p1", plateNumber)
        insertCmd.Parameters.AddWithValue("@p2", classType)
        insertCmd.Parameters.AddWithValue("@p3", vehicleType)
        insertCmd.Parameters.AddWithValue("@p4", checkinDateTime.ToString("MM/dd/yyyy HH:mm:ss"))

        Try
            maconection.Open()
            Dim rowsAffected As Integer = insertCmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Check-in information registered successfully.")


                dtset.Tables("TB_checkin").Clear()
                Dim dtAdapter As New OleDbDataAdapter(sql_checkin, maconection)
                dtAdapter.Fill(dtset, "TB_checkin")
                Dim dataTable As DataTable = dtset.Tables("TB_checkin")
                If dataTable.Rows.Count > 0 Then
                    Dim lastRowIndex As Integer = dataTable.Rows.Count - 1
                    Txt_plateNO.Text = dataTable.Rows(lastRowIndex)("Plate_number").ToString()
                    Cmb_classtype.Text = dataTable.Rows(lastRowIndex)("Class_type").ToString()
                    Cmb_vehtype.Text = dataTable.Rows(lastRowIndex)("vehicle_type").ToString()
                End If

                DataGridView1.DataSource = dtset.Tables("TB_checkin")
            Else
                MsgBox("Failed to register check-in information.")
            End If
        Catch ex As Exception
            MsgBox("Error registering check-in information: " & ex.Message)
        Finally
            maconection.Close()
        End Try
        Dim ticketNumber As Integer = GetMostRecentTicketNumber()


        Dim printForm As New Frm_print_checkin(ticketNumber)
        printForm.ShowDialog()




    End Sub
    Private Sub Frm_employer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_gestion_parkingDataSet11.TB_checkin' table. You can move, or remove it, as needed.
        Me.TB_checkinTableAdapter2.Fill(Me.BD_gestion_parkingDataSet11.TB_checkin)

        Lab_Loggeduser.Text = Login.Txt_username.Text



        maconection.Open()
        Dim dtAdapter As New OleDbDataAdapter(sql_checkin, maconection)
        dtAdapter.Fill(dtset, "TB_checkin")
        maconection.Close()

        Cmb_vehtype.DataBindings.Add("Text", dtset, "TB_checkin.vehicle_type")
        Cmb_classtype.DataBindings.Add("Text", dtset, "TB_checkin.class_type")
        Txt_plateNO.DataBindings.Add("Text", dtset, "TB_checkin.Plate_number")



    End Sub

    Private Sub But_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_reset.Click
        Txt_plateNO.Clear()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Lab_Date_time.Text = Date.Now
    End Sub

    Private Sub But_logs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_logs.Click
        Frm_selfcheckin.Show()
    End Sub
End Class