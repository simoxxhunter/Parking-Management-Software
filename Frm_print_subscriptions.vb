Public Class Frm_print_subscriptions

    Dim g, mg As Graphics
    Dim bmp As Bitmap

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Lab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Frm_print_subscriptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lab_class.Text = Frm_Managesubs.Cmb_classtype.Text
        Lab_name.Text = Frm_Managesubs.Txt_fullname.Text

        Lab_veh_type.Text = Frm_Managesubs.Cmb_cartype.Text
        Lab_startdate.Text = Frm_Managesubs.datetime_resstartdate.Text

        Lab_enddate.Text = Frm_Managesubs.datetime_resenddate.Text
        Lab_matricule.Text = Frm_Managesubs.Txt_nmatricule.Text

        Lab_nsub.Text = Frm_Managesubs.Txt_sub.Text


    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printWidth As Integer = e.PageBounds.Width
        Dim printHeight As Integer = e.PageBounds.Height

        Using bmp As New Bitmap(Panel1.Width, Panel1.Height)
            Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))


            Dim aspectRatio As Double = Math.Min(printWidth / bmp.Width, printHeight / bmp.Height)
            Dim scaledWidth As Integer = CInt(bmp.Width * aspectRatio)
            Dim scaledHeight As Integer = CInt(bmp.Height * aspectRatio)


            Dim x As Integer = (printWidth - scaledWidth) \ 2
            Dim y As Integer = (printHeight - scaledHeight) \ 2


            e.Graphics.DrawImage(bmp, x, y, scaledWidth, scaledHeight)
        End Using


    End Sub

    Private Sub but_print_ticket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_print_card.Click
        Dim printDocument As New Printing.PrintDocument()

        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        Using printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDocument
            printPreviewDialog.ShowDialog()
        End Using

        Me.Close()
    End Sub

    Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Dim printWidth As Integer = e.PageBounds.Width
        Dim printHeight As Integer = e.PageBounds.Height

        Using bmp As New Bitmap(Panel1.Width, Panel1.Height)
            Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))


            Dim aspectRatio As Double = Math.Min(printWidth / bmp.Width, printHeight / bmp.Height)
            Dim scaledWidth As Integer = CInt(bmp.Width * aspectRatio)
            Dim scaledHeight As Integer = CInt(bmp.Height * aspectRatio)


            Dim x As Integer = (printWidth - scaledWidth) \ 2
            Dim y As Integer = (printHeight - scaledHeight) \ 2


            e.Graphics.DrawImage(bmp, x, y, scaledWidth, scaledHeight)
        End Using
    End Sub

End Class