<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ASPWebForm.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <% if(ViewState["username"] != null){ %>
                    <h3>Welcome <%= ViewState["username"] %></h3>
                <% }else{ %>
                    <div>
                        <asp:TextBox ID="txtUsername" runat="server" />
                        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" />
                        <asp:Button ID="btnLogin" Text="Login" runat="server" />
                    </div>
                <% } %>
            </div>
        </div>
    </form>
</body>
</html>
