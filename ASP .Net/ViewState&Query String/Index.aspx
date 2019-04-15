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
                    <% List<string> lists = (List<string>)ViewState["nama"]; %>
                    <table border="1">
                        <thead>
                            <tr>
                                <th>Nama</th>
                            </tr>
                        </thead>
                        <tbody>
                            <% foreach(string list in lists)
                                                            { %>
                                <tr>
                                    <td><%= list %></td>
                                </tr>
                            <% } %>
                        </tbody>
                    </table>
                    <asp:TextBox ID="txtNama" runat="server" />
                    <asp:Button ID="btn" runat="server" Text="Click" OnClick="btn_Click" />
                    <a href='<%= string.Format("~/Index.aspx?username={0}", txtNama.Text) %>'>Test</a>
                <% } %>
            </div>
        </div>
    </form>
</body>
</html>
