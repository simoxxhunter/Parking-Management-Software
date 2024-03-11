Imports System.Data
Imports System.Data.OleDb
Public Class Frm_Managereservations


    Dim mabase As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Application.StartupPath & "\BD_gestion_parking.mdb"
    Dim maconection As New OleDbConnection(mabase)
    Dim dtset As New DataSet
    Dim savinto As New OleDbCommand
    Dim sql_reservations As String = "select * from TB_reservations"

    

    Private Sub But_checkin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Frm_checkin.Show()
    End Sub

    Private Sub But_checkout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Frm_checkout.Show()

    End Sub

    Private Sub But_managesubs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Frm_Managesubs.Show()

    End Sub

    Private Sub But_managereservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub But_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

        Login.Show()
    End Sub




    Private Sub But_checkin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_checkin.Click
        Me.Close()
        Frm_checkin.Show()
    End Sub

    Private Sub But_checkout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_checkout.Click
        Me.Hide()
        Frm_checkout.Show()
    End Sub

    Private Sub But_managesubs_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_managesubs.Click
        Me.Hide()
        Frm_Managesubs.Show()
    End Sub

    Private Sub But_managereservations_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_managereservations.Click

    End Sub

    Private Sub But_Logout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Logout.Click
        Close()
        MDI_Home.Hide()
        Login.Show()
    End Sub

    Private Sub But_print_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_print_reservation.Click

        Dim fullName As String = Txt_fullname.Text
        Dim vehicleType As String = Cmb_cartype.Text
        Dim classType As String = Cmb_classtype.Text
        Dim startDate As Date = datetime_resstartdate.Value
        Dim endDate As Date = datetime_resenddate.Value
        Dim reservationNumber As String = Txt_nres.Text
        Dim plateNumber As String = Txt_nmatricule.Text.Replace("-", "").Replace("_", "")

        Try
            maconection.Open()

            Dim duration As Integer = CInt((endDate - startDate).TotalHours)
            Dim total As Integer
            Select Case duration
                Case Is <= 24
                    total = 40
                Case 24 To 72
                    total = 100
                Case 73 To 216
                    total = 300
                Case 217 To 432
                    total = 500
                Case Else
                    MsgBox("Please enter a correct duration.")
                    Exit Sub
            End Select


            Dim updateCmd As New OleDbCommand
            updateCmd.Connection = maconection
            updateCmd.CommandType = CommandType.Text
            updateCmd.CommandText = "UPDATE TB_reservations SET full_name = @FullName, vehicle_type = @VehicleType, class_type = @ClassType, " &
                                    "start_date = @StartDate, end_date = @EndDate, N_Plate = @PlateNumber, Total_payer = @Total " &
                                    "WHERE n_reservation = @ReservationNumber"
            updateCmd.Parameters.AddWithValue("@FullName", fullName)
            updateCmd.Parameters.AddWithValue("@VehicleType", vehicleType)
            updateCmd.Parameters.AddWithValue("@ClassType", classType)
            updateCmd.Parameters.AddWithValue("@StartDate", startDate)
            updateCmd.Parameters.AddWithValue("@EndDate", endDate)
            updateCmd.Parameters.AddWithValue("@PlateNumber", plateNumber)
            updateCmd.Parameters.AddWithValue("@Total", total)
            updateCmd.Parameters.AddWithValue("@ReservationNumber", reservationNumber)
            updateCmd.ExecuteNonQuery()

            MsgBox("Reservation updated successfully.")

            dtset.Tables("TB_reservations").Clear()
            Dim dtAdapter As New OleDbDataAdapter(sql_reservations, maconection)
            dtAdapter.Fill(dtset, "TB_reservations")
            DataGridView1.DataSource = dtset.Tables("TB_reservations")

        Catch ex As Exception
            MsgBox("Error updating reservation: " & ex.Message)
        Finally
            maconection.Close()
        End Try
        Frm_print_reservation.ShowDialog()

    End Sub


    Private Sub But_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_edit.Click




        Dim n As String = Trim(Txt_nres.Text)
        Dim Edit_into As New OleDb.OleDbCommand
        Dim dtAdapter As New OleDbDataAdapter(sql_reservations, maconection)
        Edit_into.Connection = maconection
        Edit_into.CommandType = CommandType.Text
        Dim endDate As String = datetime_resenddate.Value.ToString("M/dd/yyyy h:mm:ss tt")
        Dim startDate As String = datetime_resstartdate.Value.ToString("M/dd/yyyy h:mm:ss tt")

        Edit_into.CommandText = "UPDATE TB_reservations SET full_name='" & Trim(Txt_fullname.Text) & "', N_Plate='" & Trim(Txt_nmatricule.Text) & "', vehicle_type='" & Trim(Cmb_cartype.Text) & "', CLASS_TYPE='" & Trim(Cmb_classtype.Text) & "', end_date='" & endDate & "', start_date='" & startDate & "' WHERE N_reservation=" & n

        Try
            maconection.Open()
            Edit_into.ExecuteNonQuery()
            MsgBox("Votre enregistrement a été modifié.")
            Txt_fullname.DataBindings.Clear()
            Cmb_cartype.DataBindings.Clear()
            Cmb_classtype.DataBindings.Clear()
            datetime_resstartdate.DataBindings.Clear()
            datetime_resenddate.DataBindings.Clear()
            Txt_nres.DataBindings.Clear()
            Txt_nmatricule.DataBindings.Clear()
            dtset.Tables("TB_reservations").Clear()
            dtAdapter.Fill(dtset, "TB_reservations")

            DataGridView1.DataSource = dtset.Tables("TB_reservations")
        Catch ex As Exception
            MsgBox("Error modifying record: " & ex.Message)
        Finally
            maconection.Close()
        End Try



    End Sub
    Private Sub Frm_Managereservations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_gestion_parkingDataSet1.TB_Reservations' table. You can move, or remove it, as needed.
        Me.TB_ReservationsTableAdapter.Fill(Me.BD_gestion_parkingDataSet1.TB_Reservations)


        Lab_Loggeduser.Text = (Frm_checkin.Lab_Loggeduser.Text)
        Lab_Date_time.Text = Date.Now


        maconection.Open()
        Dim dtAdapter As New OleDbDataAdapter(sql_reservations, maconection)
        dtAdapter.Fill(dtset, "TB_reservations")
        maconection.Close()

        Txt_fullname.DataBindings.Add("text", dtset, "TB_reservations.full_name")

        Cmb_cartype.DataBindings.Add("text", dtset, "TB_reservations.vehicle_type")

        Cmb_classtype.DataBindings.Add("text", dtset, "TB_reservations.class_type")

        datetime_resstartdate.DataBindings.Add("text", dtset, "TB_reservations.start_date")

        datetime_resenddate.DataBindings.Add("text", dtset, "TB_reservations.end_date")

        Txt_nres.DataBindings.Add("text", dtset, "TB_reservations.N_reservation")

        Txt_nmatricule.DataBindings.Add("text", dtset, "TB_reservations.N_Plate")
    End Sub

    Private Sub But_logs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_logs.Click
        Frm_selfcheckin.Show()
    End Sub
End Class