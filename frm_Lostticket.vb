Public Class frm_Lostticket

    Dim g As Graphics
    Dim bmp As Bitmap


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Lab_ticket_time.Text = Date.Now
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub frm_Lostticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
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

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class