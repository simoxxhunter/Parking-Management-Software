Public Class Frm_print_reservation
    Dim g As Graphics
    Dim bmp As Bitmap

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Lab_ticket_time.Text = Date.Now
    End Sub

    Private Sub Frm_print_reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Lab_resstartdate.Text = Frm_Managereservations.datetime_resstartdate.Text
        Lab_resenddate.Text = Frm_Managereservations.datetime_resenddate.Text
        Lab_name.Text = Frm_Managereservations.Txt_fullname.Text

        Lab_cartype.Text = Frm_Managereservations.Cmb_cartype.Text
        Lab_classtype.Text = Frm_Managereservations.Cmb_classtype.Text
        Lab_matricule.Text = Frm_Managereservations.Txt_nmatricule.Text

        Lab_nres.Text = Frm_Managereservations.Txt_nres.Text


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