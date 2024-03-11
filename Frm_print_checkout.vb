Imports System.Globalization

Public Class Frm_print_checkout
    Dim g As Graphics
    Dim bmp As Bitmap
    Dim spenttime As Integer
    Dim costveh As Integer
    Dim costclass As Integer

    Public classtypecost As String
    Public vehiclecost As String
    

    Private Sub Frm_print_checkout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      
        Lab_todaysdate.Text = Date.Today.ToString("MM/dd/yyyy")
        Lab_checkouttime.Text = DateTime.Now.ToString("M/dd/yyyy h:mm:ss tt")
        Lab_todaysdate.Text = Date.Today.ToString("MM/dd/yyyy")
        Lab_checkouttime.Text = DateTime.Now.ToString("M/dd/yyyy h:mm:ss tt")

        Dim format As String = "M/dd/yyyy h:mm:ss tt"
        Dim checkinDate As DateTime

        If DateTime.TryParseExact(Lab_checkindate.Text.Trim(), format, CultureInfo.InvariantCulture, DateTimeStyles.None, checkinDate) Then
            Dim checkoutDate As DateTime = DateTime.ParseExact(Lab_checkouttime.Text.Trim(), format, CultureInfo.InvariantCulture)
            Console.WriteLine("Check-in Date: " & checkinDate.ToString())
            Console.WriteLine("Check-out Date: " & checkoutDate.ToString())

            Dim timeSpent As TimeSpan = checkoutDate - checkinDate
            spenttime = CInt(timeSpent.TotalMinutes)


            ElseIf vehiclecost = "Van" Then
            costveh = 7
            ElseIf vehiclecost = "Car" Then
                costveh = 4 / 60
            ElseIf vehiclecost = "bike" Then
                costveh = 2 / 60
            End If

            If classtypecost = "1 ére class" Then
                costclass = 1.2
            ElseIf classtypecost = "2 éme class" Then
                costclass = 1
            ElseIf classtypecost = "Speciale" Then
                costclass = 0
            End If

            Lab_total.Text = (spenttime * (costclass * costveh)).ToString()

    End Sub

    Private Sub but_print_ticket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_print_ticket.Click
        bmp = New Bitmap(Panel1.Width, Panel1.Height)
        g = Graphics.FromImage(bmp)
        g.CopyFromScreen(Panel1.PointToScreen(New Point(0, 0)), New Point(0, 0), Panel1.Size)
        PrintPreviewDialog1.ShowDialog()

        g.Dispose()
        bmp.Dispose()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub


End Class