Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb


Public Class MDI_Home

    Dim mabase As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Application.StartupPath & "\BD_gestion_parking.mdb"
    Dim maconection As New OleDbConnection(mabase)
    Dim dtset As New DataSet
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub SubscribersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubscribersToolStripMenuItem.Click
        Frm_Managesubs.Show()
    End Sub

    Private Sub CheckinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckinToolStripMenuItem.Click
        Frm_checkin.Show()

    End Sub

    Private Sub CheckoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckoutToolStripMenuItem.Click
        Frm_checkout.Show()

    End Sub

    Private Sub ReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationToolStripMenuItem.Click
        Frm_Managereservations.Show()
    End Sub

    Private Sub SELFCHECKINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SELFCHECKINToolStripMenuItem.Click
        Frm_selfcheckin.Show()
    End Sub

    Private Sub MDI_Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lab_loggeduser.Text = (Login.Txt_username.Text)

        maconection.Open()

        Dim countCmd As New OleDbCommand("SELECT COUNT(*) FROM TB_subscriptions", maconection)
        Dim totalCount As Integer = CInt(countCmd.ExecuteScalar())
        lab_subs_num.Text = totalCount.ToString()


        Dim earningsQuery As String = "SELECT SUM(Total) FROM TB_subscriptions"
        Using earningsCommand As New OleDbCommand(earningsQuery, maconection)
            Dim totalEarnings As Object = earningsCommand.ExecuteScalar()
            If Not IsDBNull(totalEarnings) Then
                lab_subearnings.Text = Convert.ToString(totalEarnings)
            Else
                lab_subearnings.Text = "0"
            End If
        End Using
        '--------------------
        Dim SQL_countres As New OleDbCommand("SELECT COUNT(*) FROM TB_reservations", maconection)
        Dim totalCountres As Integer = CInt(SQL_countres.ExecuteScalar())
        Lab_resnumber.Text = totalCountres.ToString()

        Dim SQL_earningsres As String = "SELECT SUM(Total_payer) FROM TB_reservations"
        Using earningsres As New OleDbCommand(SQL_earningsres, maconection)
            Dim totalEarningres As Object = earningsres.ExecuteScalar()
            Lab_researnings.Text = totalEarningres
        End Using
        '-----------------------------------------

        Dim SQL_countcheckin As New OleDbCommand("SELECT COUNT(*) FROM TB_ticketscheckin", maconection)
        Dim totalCountcheckin As Integer = CInt(SQL_countcheckin.ExecuteScalar())
        Lab_totalcheckin.Text = totalCountcheckin.ToString()


        Dim SQL_checkoutcount As String = "SELECT SUM(Total_paid) FROM TB_ticketscheckout"
        Using earningcheckout As New OleDbCommand(SQL_checkoutcount, maconection)
            Dim totalEarningcheckout As Object = earningcheckout.ExecuteScalar()
            Lab_totalearnings.Text = totalEarningcheckout.ToString
        End Using


        maconection.Close()

    End Sub
    Private Sub EmployersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployersToolStripMenuItem.Click
        Frm_employers.ShowDialog()
    End Sub
End Class
