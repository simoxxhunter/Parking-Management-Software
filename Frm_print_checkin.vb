Imports System.Data
Imports System.Data.OleDb


Public Class Frm_print_checkin
    Private ReadOnly ticketNumber As Integer
    Dim mabase As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\BD_gestion_parking.mdb"
    Dim maconection As New OleDbConnection(mabase)
    Dim dtset As New DataSet
    Dim savinto As New OleDbCommand
    Dim sql_ticketscheckin As String = "SELECT * FROM TB_ticketscheckin"


    Public Sub New(ByVal ticketNumber As Integer)
        InitializeComponent()

        Me.ticketNumber = ticketNumber
    End Sub

    Dim bmp As Bitmap
    Dim g As Graphics

    Private Sub Frm_print_checkin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_gestion_parkingDataSet1.TB_ticketscheckin' table. You can move, or remove it, as needed.
        Me.TB_ticketscheckinTableAdapter.Fill(Me.BD_gestion_parkingDataSet1.TB_ticketscheckin)
        lab_ticket_no.Text = ticketNumber.ToString()
        Lab_ticket_time.Text = Date.Now

        ' Pict_class_type.Image = Image.FromFile("")
        Lab_class_type.Text = Frm_checkin.Cmb_classtype.Text
        Lab_class_type.Text = Frm_checkin.Cmb_classtype.Text


        If Frm_checkin.Cmb_vehtype.Text = "Van" Then
            Pict_vehicule.ImageLocation = ("Van.png")
        ElseIf Frm_checkin.Cmb_vehtype.Text = "Bike" Then
            Pict_vehicule.ImageLocation = ("Bike.png")
        ElseIf Frm_checkin.Cmb_vehtype.Text = "Car" Then
            Pict_vehicule.ImageLocation = ("Car.png")
        End If

        'If (Frm_checkin.DataGridView1.RowCount > 1) And (Frm_checkin.DataGridView1.CurrentCell.Value IsNot Nothing) Then
        'Label2.Text = Frm_checkin.DataGridView1.CurrentCell.Value.ToString
        'End If


    End Sub


    Private Sub but_print_ticket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_print_ticket.Click
Try
            maconection = New OleDbConnection(mabase)
            maconection.Open()
            Dim ticketId As Integer
            Dim classType As String
            Dim vehicleType As String
            Dim checkinDateTime As DateTime
            Dim selectCmd As New OleDbCommand("SELECT ticket_id, class_type, vehicle_type, checkin_date_and_time FROM TB_checkin WHERE ticket_id = (SELECT MAX(ticket_id) FROM TB_checkin)", maconection)
            Dim reader As OleDbDataReader = selectCmd.ExecuteReader()

            If reader.Read() Then
                ticketId = reader.GetInt32(0)
                classType = reader.GetString(1)
                vehicleType = reader.GetString(2)
                checkinDateTime = reader.GetDateTime(3)

                Dim insertCmd As New OleDbCommand("INSERT INTO TB_ticketscheckin (ticket_id, class_type, vehicle_type, checkin_date) VALUES (?, ?, ?, ?)", maconection)
                insertCmd.Parameters.AddWithValue("@p1", ticketId)
                insertCmd.Parameters.AddWithValue("@p2", classType)
                insertCmd.Parameters.AddWithValue("@p3", vehicleType)
                insertCmd.Parameters.AddWithValue("@p4", checkinDateTime)

                insertCmd.ExecuteNonQuery()

                MsgBox("Ticket check-in data inserted successfully.")
            Else
                MsgBox("No data found in TB_checkin.")
            End If

            reader.Close()

        Catch ex As Exception
            MsgBox("An error occurred while inserting ticket check-in data: " & ex.Message)
        Finally
            maconection.Close()
        End Try
        bmp = New Bitmap(Panel1.Width, Panel1.Height)
        g = Graphics.FromImage(bmp)
        g.CopyFromScreen(Panel1.PointToScreen(New Point(0, 0)), New Point(0, 0), Panel1.Size)
        PrintPreviewDialog1.ShowDialog()

        g.Dispose()
        bmp.Dispose()
        Me.Close()

    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

End Class