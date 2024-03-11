Imports System.Data
Imports System.Data.OleDb
Public Class Frm_checkout

    Dim mabase As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Application.StartupPath & "\BD_gestion_parking.mdb"
    Dim maconection As New OleDbConnection(mabase)
    Dim dtset As New DataSet
    Dim savinto As New OleDbCommand
    Dim sql_checkin As String = "select * from TB_checkin"
    Private Sub But_checkin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Frm_checkin.Show()
    End Sub

    Private Sub But_checkout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub But_managesubs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Frm_Managesubs.Show()
        Me.Hide()

    End Sub

    Private Sub But_managereservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Frm_Managereservations.Show()

    End Sub

    Private Sub But_Logout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()

        Login.Show()

    End Sub

    Private Sub Frm_checkout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_gestion_parkingDataSet1.TB_checkin' table. You can move, or remove it, as needed.
        Me.TB_checkinTableAdapter1.Fill(Me.BD_gestion_parkingDataSet1.TB_checkin)
        'TODO: This line of code loads data into the 'BD_gestion_parkingDataSet1.TB_checkin' table. You can move, or remove it, as needed.
        Me.TB_checkinTableAdapter1.Fill(Me.BD_gestion_parkingDataSet1.TB_checkin)

        Lab_Loggeduser.Text = (Frm_checkin.Lab_Loggeduser.Text)
        Lab_Date_time.Text = Date.Now

        maconection.Open()
        Dim dtAdapter As New OleDbDataAdapter(sql_checkin, maconection)
        dtAdapter.Fill(dtset, "TB_checkin")
        maconection.Close()

        txt_ticketno.DataBindings.Add("Text", dtset, "TB_checkin.ticket_id")
        txt_plateno.DataBindings.Add("Text", dtset, "TB_checkin.Plate_number")
        txt_checkindatetime.DataBindings.Add("Text", dtset, "TB_checkin.checkin_date_and_time")
        txt_vehtype.DataBindings.Add("Text", dtset, "TB_checkin.vehicle_type")
        txt_class_type.DataBindings.Add("Text", dtset, "TB_checkin.class_type")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_lostticket.Click
        frm_Lostticket.Show()
    End Sub

    Private Sub But_managesubs_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_managesubs.Click
        Frm_Managesubs.Show()
        Me.Close()
    End Sub

    Private Sub But_managereservations_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_managereservations.Click
        Frm_Managereservations.Show()
        Me.Hide()
    End Sub


    Private Sub But_checkout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_checkout.Click
        Me.Show()
    End Sub

    Private Sub But_checkin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_checkin.Click
        Me.Close()
        Frm_checkin.Show()
    End Sub

    Private Sub But_logs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_logs.Click

        Frm_selfcheckin.Show()
    End Sub

    Private Sub But_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Logout.Click
        MDI_Home.Hide()
        Me.Close()

        Login.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_printcheckout.Click

        Dim rech As String = ""
        rech = InputBox("Enter the ticket ID to search", "Search Program")
        Dim sql_rech As String = "SELECT * FROM TB_checkin WHERE Ticket_id = @TicketID"
        If maconection.State = ConnectionState.Closed Then
            maconection.Open()
        End If
        Dim cmd As New OleDbCommand(sql_rech, maconection)
        cmd.Parameters.AddWithValue("@TicketID", rech)

        Dim dtred As OleDbDataReader = cmd.ExecuteReader()
        If dtred.Read() Then
            txt_ticketno.Text = dtred.Item("Ticket_id").ToString()
            Frm_print_checkout.Lab_checkindate.Text = dtred.Item("checkin_date_and_time").ToString
            Frm_print_checkout.vehiclecost = dtred.Item("vehicle_type").ToString
            Frm_print_checkout.classtypecost = dtred.Item("Class_type").ToString
            maconection.Close()
            Frm_print_checkout.ShowDialog()

            Dim deleteCmd As New OleDbCommand("DELETE FROM TB_checkin WHERE Ticket_id = @TicketID", maconection)
            deleteCmd.Parameters.AddWithValue("@TicketID", rech)
            maconection.Open()
            deleteCmd.ExecuteNonQuery()
            maconection.Close()

            dtset.Tables("TB_checkin").Clear()
            Dim dtAdapter As New OleDbDataAdapter("SELECT * FROM TB_checkin", maconection)
            dtAdapter.Fill(dtset, "TB_checkin")
            DataGridView1.DataSource = dtset.Tables("TB_checkin")
        Else
            maconection.Close()

        End If


    End Sub

    Private Sub But_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_reset.Click
        txt_checkindatetime.Clear()
        txt_class_type.Clear()
        txt_plateno.Clear()
        txt_ticketno.Clear()
        txt_vehtype.Clear()

    End Sub
End Class