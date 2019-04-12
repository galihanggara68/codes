<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPWebForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formLogin" action="Proses.aspx" method="post" runat="server">
        <div>
            <div>
                <asp:Label ID="labelEmail" Text="Email : " runat="server" AssociatedControlID="textBoxEmail" />
                <asp:TextBox ID="textBoxEmail" TextMode="Email" runat="server" />
            </div>
            <div>
                <asp:Label ID="labelPassword" Text="Password : " runat="server" AssociatedControlID="textBoxPassword" />
                <asp:TextBox ID="textBoxPassword" TextMode="Password" runat="server" />
            </div>
            <div>
                <asp:Button ID="buttonLogin" Text="Login" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
