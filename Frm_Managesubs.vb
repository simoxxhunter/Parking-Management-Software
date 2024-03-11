Imports System.Data
Imports System.Data.OleDb

Public Class Frm_Managesubs


    Dim mabase As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Application.StartupPath & "\BD_gestion_parking.mdb"
    Dim maconection As New OleDbConnection(mabase)
    Dim dtset As New DataSet
    Dim savinto As New OleDbCommand
    Dim sql_subscribers As String = "select * from TB_subscriptions"

    Private Sub Frm_Managesubs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_gestion_parkingDataSet1.TB_subscriptions' table. You can move, or remove it, as needed.
        Me.TB_subscriptionsTableAdapter.Fill(Me.BD_gestion_parkingDataSet1.TB_subscriptions)


        Lab_Loggeduser.Text = (Frm_checkin.Lab_Loggeduser.Text)
        Lab_Date_time.Text = Date.Now

        maconection.Open()
        Dim dtAdapter As New OleDbDataAdapter(sql_subscribers, maconection)
        dtAdapter.Fill(dtset, "TB_subscriptions")
        maconection.Close()

        Txt_fullname.DataBindings.Add("text", dtset, "TB_subscriptions.full_name")

        Cmb_cartype.DataBindings.Add("text", dtset, "TB_subscriptions.vehicle_type")

        Cmb_classtype.DataBindings.Add("text", dtset, "TB_subscriptions.class_type")

        datetime_resstartdate.DataBindings.Add("text", dtset, "TB_subscriptions.start_date")

        datetime_resenddate.DataBindings.Add("text", dtset, "TB_subscriptions.end_date")

        Txt_sub.DataBindings.Add("text", dtset, "TB_subscriptions.N_subscription")

        Txt_nmatricule.DataBindings.Add("text", dtset, "TB_subscriptions.N_Plate")


    End Sub

    Private Sub But_print_subscription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_print_subscription.Click
        Dim fullName As String = Txt_fullname.Text
        Dim vehicleType As String = Cmb_cartype.Text
        Dim classType As String = Cmb_classtype.Text
        Dim startDate As Date = datetime_resstartdate.Value
        Dim endDate As Date = datetime_resenddate.Value
        Dim subscriptionNumber As String = Txt_sub.Text
        Dim plateNumber As String = Txt_nmatricule.Text.Replace("-", "").Replace("_", "")

        Try
            maconection.Open()

            Dim duration As Integer = (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month
            Dim total As Integer
            Select Case duration
                Case 1
                    total = 350
                Case 3
                    total = 800
                Case 6
                    total = 1300
                Case 12
                    total = 1900
                Case Else
                    MsgBox("please enter a correct duration 1/3/6/12 months")
                    Exit Sub
            End Select

            Dim insertCmd As New OleDbCommand
            insertCmd.Connection = maconection
            insertCmd.CommandType = CommandType.Text
            insertCmd.CommandText = "INSERT INTO TB_subscriptions (full_name, vehicle_type, class_type, start_date, end_date, N_Plate, Total) " &
                                    "VALUES (@FullName, @VehicleType, @ClassType, @StartDate, @EndDate, @PlateNumber, @Total)"
            insertCmd.Parameters.AddWithValue("@FullName", fullName)
            insertCmd.Parameters.AddWithValue("@VehicleType", vehicleType)
            insertCmd.Parameters.AddWithValue("@ClassType", classType)
            insertCmd.Parameters.AddWithValue("@StartDate", startDate)
            insertCmd.Parameters.AddWithValue("@EndDate", endDate)
            insertCmd.Parameters.AddWithValue("@PlateNumber", plateNumber)
            insertCmd.Parameters.AddWithValue("@Total", total)
            insertCmd.ExecuteNonQuery()
            MsgBox("Subscriber added successfully.")

            dtset.Tables("TB_subscriptions").Clear()
            Dim dtAdapter As New OleDbDataAdapter(sql_subscribers, maconection)
            dtAdapter.Fill(dtset, "TB_subscriptions")
            DataGridView1.DataSource = dtset.Tables("TB_subscriptions")

            Txt_fullname.Text = fullName
            Cmb_cartype.Text = vehicleType
            Cmb_classtype.Text = classType
            datetime_resstartdate.Value = startDate
            datetime_resenddate.Value = endDate
            Txt_sub.Text = subscriptionNumber
            Txt_nmatricule.Text = plateNumber

            Frm_print_subscriptions.Lab_subduration.Text = duration.ToString() & " months"
        Finally
            maconection.Close()
        End Try

        Frm_print_subscriptions.Show()
    End Sub


    Private Sub But_checkin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_checkin.Click
        Me.Close()
        Frm_checkin.Show()
    End Sub

    Private Sub But_checkout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_checkout.Click
        Me.Hide()
        Frm_checkout.Show()
    End Sub

    Private Sub But_managereservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_managereservations.Click
        Me.Hide()
        Frm_Managereservations.Show()
    End Sub

    Private Sub But_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Logout.Click
        Me.Close()
        MDI_Home.Hide()
        Login.Show()
    End Sub


    Private Sub But_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_edit.Click
        Dim n As String = Trim(Txt_sub.Text)
        Dim Edit_into As New OleDb.OleDbCommand
        Dim dtAdapter As New OleDbDataAdapter(sql_subscribers, maconection)
        Edit_into.Connection = maconection
        Edit_into.CommandType = CommandType.Text
        Dim endDate As String = datetime_resenddate.Value.ToString("M/dd/yyyy h:mm:ss tt")
        Dim startDate As String = datetime_resstartdate.Value.ToString("M/dd/yyyy h:mm:ss tt")

        Edit_into.CommandText = "UPDATE TB_subscriptions SET full_name='" & Trim(Txt_fullname.Text) & "', N_Plate='" & Trim(Txt_nmatricule.Text) & "', vehicle_type='" & Trim(Cmb_cartype.Text) & "', CLASS_TYPE='" & Trim(Cmb_classtype.Text) & "', end_date='" & endDate & "', start_date='" & startDate & "' WHERE N_subscription=" & n

        Try
            maconection.Open()
            Edit_into.ExecuteNonQuery()
            MsgBox("Votre enregistrement a été modifié.")
            Txt_fullname.DataBindings.Clear()
            Cmb_cartype.DataBindings.Clear()
            Cmb_classtype.DataBindings.Clear()
            datetime_resstartdate.DataBindings.Clear()
            datetime_resenddate.DataBindings.Clear()
            Txt_sub.DataBindings.Clear()
            Txt_nmatricule.DataBindings.Clear()
            dtset.Tables("TB_subscriptions").Clear()
            dtAdapter.Fill(dtset, "TB_subscriptions")

            DataGridView1.DataSource = dtset.Tables("TB_subscriptions")
        Catch ex As Exception
            MsgBox("Error modifying record: " & ex.Message)
        Finally
            maconection.Close()
        End Try
    End Sub

    Private Sub But_deletesub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_deletesub.Click
        Dim subscriptionNumber As String = Txt_sub.Text.Trim()

        If String.IsNullOrEmpty(subscriptionNumber) Then
            MsgBox("Please enter a subscription number.")
            Return
        End If

        If MsgBox("Are you sure you want to delete this subscriber?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Return
        End If

        Dim del_cmd As New OleDb.OleDbCommand
        del_cmd.Connection = maconection
        del_cmd.CommandType = CommandType.Text
        del_cmd.CommandText = "DELETE FROM TB_subscriptions WHERE N_Subscription = @SubscriptionNumber"
        del_cmd.Parameters.AddWithValue("@SubscriptionNumber", subscriptionNumber)

        Try
            maconection.Open()
            Dim rowsAffected As Integer = del_cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                Dim dataRow As DataRow = dtset.Tables("TB_subscriptions").AsEnumerable().FirstOrDefault(Function(row) Convert.ToString(row.Field(Of Object)("N_Subscription")) = subscriptionNumber)
                If dataRow IsNot Nothing Then
                    dtset.Tables("TB_subscriptions").Rows.Remove(dataRow)
                    dtset.Tables("TB_subscriptions").AcceptChanges()
                    DataGridView1.DataSource = dtset.Tables("TB_subscriptions")
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
End Class