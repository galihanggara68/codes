<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Proses.aspx.cs" Inherits="ASPWebForm.Proses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <% if(Request.Form["buttonRegister"] != null)
                { %>
                <div>
                    <asp:Label ID="labelNama" Text="Nama : " runat="server" AssociatedControlID="literalNama" />
                    <asp:Literal ID="literalNama" runat="server" />
                </div>
                <div>
                    <asp:Label ID="labelAlamat" Text="Alamat : " runat="server" AssociatedControlID="literalAlamat" />
                    <asp:Literal ID="literalAlamat" runat="server" />
                </div>
                <div>
                    <asp:Label ID="labelGender" Text="Jenis Kelamin : " runat="server" AssociatedControlID="literalGender" />
                    <asp:Literal ID="literalGender" runat="server" />
                </div>
                <div>
                    <asp:Label ID="labelTanggal" Text="Tanggal Lahir : " runat="server" AssociatedControlID="literalTanggal" />
                    <asp:Literal ID="literalTanggal" runat="server" />
                </div>
                <div>
                    <asp:Label ID="labelEmail" Text="Email : " runat="server" AssociatedControlID="literalEmail" />
                    <asp:Literal ID="literalEmail" runat="server" />
                </div>
                <div>
                    <asp:HyperLink NavigateUrl="~/Register.aspx" Text="Kembali" runat="server" />
                    <asp:HyperLink NavigateUrl="~/Login.aspx" Text="Login" runat="server" />
                </div>
            <% }
                else
                { %>

                Welcome <asp:Label ID="labelEmailLogin" runat="server" />

            <%} %>
        </div>
    </form>
</body>
</html>
