Imports System.Data
Imports System.Data.OleDb
Public Class Frm_print_selfcheckticket
    Dim g As Graphics
    Dim bmp As Bitmap


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_print_ticket.Click

        bmp = New Bitmap(Panel1.Width, Panel1.Height)
        g = Graphics.FromImage(bmp)
        g.CopyFromScreen(Panel1.PointToScreen(New Point(0, 0)), New Point(0, 0), Panel1.Size)
        PrintPreviewDialog1.ShowDialog()

        g.Dispose()
        bmp.Dispose()
        Me.Close()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Lab_ticket_time.Text = Date.Now
    End Sub

    Private Sub Frm_print_ticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mabase As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\BD_gestion_parking.mdb"
        Dim sql As String = "SELECT TOP 1 ticket_id FROM TB_checkin ORDER BY checkin_date_and_time DESC"
        Dim connection As New OleDbConnection(mabase)
        Dim command As New OleDbCommand(sql, connection)


        Lab_vehicule_type.Text = vehicle
        Lab_class_type.Text = Class_type

        ' Pict_class_type.Image = Image.FromFile("")

        If Lab_vehicule_type.Text = "Van" Then
            Pict_vehicule.ImageLocation = ("van.png")
        ElseIf Lab_vehicule_type.Text = "Bike" Then
            Pict_vehicule.ImageLocation = ("bike.png")
        ElseIf Lab_vehicule_type.Text = "Car" Then
            Pict_vehicule.ImageLocation = ("Car.png")
        End If

        connection.Open()
        Dim ticketNumber As Object = command.ExecuteScalar()
        connection.Close()
        Lab_selfcheckticketno.Text = ticketNumber.ToString()



    End Sub

    Private Sub Lab_class_type_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lab_class_type.Click

    End Sub

    Private Sub PrintDocument1_printpage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Pict_vehicule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pict_vehicule.Click

    End Sub
End Class