<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ASPWebForm.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="nama" HeaderText="Nama" />
                    <asp:BoundField DataField="alamat" HeaderText="Alamat" />
                    <asp:ButtonField HeaderText="Edit" ButtonType="Button" Text="Edit" />
                    <asp:HyperLinkField HeaderText="Delete" Text="X" NavigateUrl="http://google.com" />
                    <asp:CheckBoxField DataField="selesai" HeaderText="Pilih"  ReadOnly="false" />
                    <asp:TemplateField HeaderText="Test" >
                        <ItemTemplate>
                            <asp:RadioButtonList runat="server" ID="pilih">
                                <asp:ListItem Text="Satu" Value="1" />
                                <asp:ListItem Text="Dua" Value="2" />
                            </asp:RadioButtonList>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
