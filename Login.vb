Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_OK.Click
        If Txt_username.Text = "admin" And Txt_password.Text = "admin" Then
            MDI_Home.Show()
            Me.Hide()
            Txt_username.Clear()
            Txt_password.Clear()

        ElseIf Txt_username.Text = "employer1" And Txt_password.Text = "employer1" Then
            Frm_checkin.Show()
            Me.Hide()
            Txt_username.Clear()
            Txt_password.Clear()

        Else

            MsgBox("votre mote de pass est incorrect")
            Txt_password.Clear()

        End If




    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
