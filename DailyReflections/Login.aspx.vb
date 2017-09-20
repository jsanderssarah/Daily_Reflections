
Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub Login1_LoggedIn(sender As Object, e As EventArgs) Handles Login1.LoggedIn
        Session("UserName") = Login1.UserName
        If Login1.UserName = "admin" Then
            Server.Transfer("~/MembersPages/AdminData.aspx")
        ElseIf Login1.UserName = "AdminUsers" Then
            Server.Transfer("~/MembersPages/Register.aspx")
        End If
    End Sub
End Class
