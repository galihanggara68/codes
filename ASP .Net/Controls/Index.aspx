<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ASPWebForm.Index" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--<asp:Label Text="Test Label" ID="labelTest" runat="server" AssociatedControlID="textBoxTest"/>
            <asp:Literal Text="Test Literal" ID="literalTest" runat="server"/>

            <asp:TextBox ID="textBoxTest" Text="Initial Text" runat="server"/>

            <asp:CheckBox ID="checkTest" Text="Agree" runat="server" TextAlign="Right"/>

            <asp:CheckBoxList ID="checkLists" runat="server">
                <asp:ListItem Text="Luar" Value="luar" />
                <asp:ListItem Text="Dalam" Value="dalam" Selected="True" />
            </asp:CheckBoxList>

            <%= textBoxTest.Text %>
            <%= checkLists.SelectedValue %>

            <asp:RadioButton ID="radioLaki" Text="Laki-laki" runat="server" GroupName="gender" />
            <asp:RadioButton ID="radioPerempuan" Text="Perempuan" runat="server" GroupName="gender" />

            <asp:RadioButtonList ID="radioGender" runat="server">
                <asp:ListItem Text="Laki-laki" Value="laki" />
                <asp:ListItem Text="Perempuan" Value="perempuan" Selected="True" />
            </asp:RadioButtonList>

            <%= radioGender.SelectedValue %>

            <asp:HyperLink ID="testHyperlink" Text="Google" NavigateUrl="google.com" runat="server" />

            <asp:TextBox ID="number1" runat="server" />
            <asp:DropDownList ID="dropDownOperator" runat="server">
            </asp:DropDownList>
            <asp:RadioButtonList ID="radioButtons" runat="server"></asp:RadioButtonList>
            <asp:TextBox ID="number2" runat="server" />
            <asp:Label ID="result" runat="server" />
            <asp:Button ID="hitung" Text="Hitung" runat="server" OnClick="hitung_Click" />--%>

               <asp:Table ID="table" runat="server">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell Text="No" />
                        <asp:TableHeaderCell Text="Nama" />
                        <asp:TableHeaderCell Text="Alamat" />
                    </asp:TableHeaderRow>
               </asp:Table>
        </div>
    </form>
</body>
</html>
