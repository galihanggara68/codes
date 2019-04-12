<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ASPWebForm.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Form Register</title>
</head>
<body>
    <form id="register" action="Proses.aspx" method="post" runat="server">
        <div>
            <div>
                <asp:Label ID="labelNama" Text="Nama : " runat="server" AssociatedControlID="textBoxNama" />
                <asp:TextBox ID="textBoxNama" runat="server" />
            </div>
            <div>
                <asp:Label ID="labelAlamat" Text="Alamat : " runat="server" AssociatedControlID="textBoxAlamat" />
                <asp:TextBox ID="textBoxAlamat" TextMode="MultiLine" runat="server" />
            </div>
            <div>
                <asp:Label ID="labelGender" Text="Jenis Kelamin : " runat="server" AssociatedControlID="gender" />
                <asp:DropDownList ID="gender" runat="server">
                </asp:DropDownList>
            </div>
            <div>
                <asp:Label ID="labelTanggal" Text="Tanggal Lahir : " runat="server" AssociatedControlID="textBoxTanggal" />
                <asp:TextBox ID="textBoxTanggal" TextMode="Date" runat="server" />
            </div>
            <div>
                <asp:Label ID="labelPassword" Text="Password : " runat="server" AssociatedControlID="textBoxPassword" />
                <asp:TextBox ID="textBoxPassword" TextMode="Password" runat="server" />
            </div>
            <div>
                <asp:Label ID="labelEmail" Text="Email : " runat="server" AssociatedControlID="textBoxEmail" />
                <asp:TextBox ID="textBoxEmail" TextMode="Email" runat="server" />
            </div>
            <div>
                <asp:Button ID="buttonRegister" Text="Register" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
