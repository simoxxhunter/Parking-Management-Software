Imports System.Data
Imports System.Data.OleDb
Public Class Frm_selfcheckin

    Dim mabase As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\BD_gestion_parking.mdb"
    Dim maconection As New OleDbConnection(mabase)
    Dim dtset As New DataSet
    Dim savinto As New OleDbCommand
    Dim sql_checkin As String = "SELECT * FROM TB_checkin"



    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Lab_datentime.Text = Date.Now
    End Sub

    Private Sub But_annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_annuler.Click
        Radbut_1stclass.Checked = False
        Radbut_2ndclass.Checked = False
        Radbut_bike.Checked = False
        Radbut_car.Checked = False
        Radbut_specialneeds.Checked = False
        Radbut_van.Checked = False


    End Sub

    Private Sub But_valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_valider.Click

        Radbut_1stclass.Checked = False
        Radbut_2ndclass.Checked = False
        Radbut_bike.Checked = False
        Radbut_car.Checked = False
        Radbut_specialneeds.Checked = False
        Radbut_van.Checked = False

        Dim vehicleType As String = vehicle
        Dim classType As String = Class_type


        maconection.Open()

        Dim insertCmd As New OleDbCommand
        insertCmd.Connection = maconection
        insertCmd.CommandType = CommandType.Text
        insertCmd.CommandText = "INSERT INTO TB_checkin (vehicle_type, class_type, checkin_date_and_time) " &
                                "VALUES (@VehicleType, @ClassType, @CheckinDateTime)"
        insertCmd.Parameters.AddWithValue("@VehicleType", vehicleType)
        insertCmd.Parameters.AddWithValue("@ClassType", classType)
        insertCmd.Parameters.AddWithValue("@CheckinDateTime", DateTime.Now.ToString)
        If vehicleType IsNot Nothing Then
            insertCmd.ExecuteNonQuery()

            maconection.Close()
        End If

        Frm_print_selfcheckticket.Show()
        maconection.Close()

    End Sub

    Private Sub Frm_selfcheckin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Lab_datentime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lab_datentime.Click

    End Sub

    Private Sub Radbut_car_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radbut_car.CheckedChanged
        vehicle = "Car"
    End Sub

    Private Sub Radbut_bike_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radbut_bike.CheckedChanged
        vehicle = "Bike"
    End Sub

    Private Sub Radbut_van_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radbut_van.CheckedChanged
        vehicle = "Van"
    End Sub

    Private Sub Radbut_1stclass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radbut_1stclass.CheckedChanged
        Class_type = "First class"
    End Sub

    Private Sub Radbut_2ndclass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radbut_2ndclass.CheckedChanged
        Class_type = "Second class"
    End Sub

    Private Sub Radbut_specialneeds_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radbut_specialneeds.CheckedChanged
        Class_type = "Special needs"
    End Sub
End Class
