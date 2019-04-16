<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ASPWebForm.Pages.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="EmployeeGrid" AutoGenerateColumns="false" runat="server" OnRowDeleting
                ="EmployeeGrid_RowDeleting" OnRowEditing="EmployeeGrid_RowEditing" OnRowCancelingEdit="EmployeeGrid_RowCancelingEdit" OnRowUpdating="EmployeeGrid_RowUpdating">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowEditButton="true" ShowDeleteButton="true" />
                    <asp:BoundField DataField="EmployeeId" HeaderText="ID" />
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                </Columns>
            </asp:GridView>

            <asp:TextBox ID="txtEmployeeId" runat="server" />
            <asp:CustomValidator ID="txtEmpValid" ControlToValidate="txtEmployeeId" runat="server" Text="Input Tidak Valid" OnServerValidate="txtEmpValid_ServerValidate" ErrorMessage="Input Tidak valid" />
            <asp:RequiredFieldValidator ControlToValidate="txtEmployeeId" Text="Harus diisi" ErrorMessage="Harus Diisi" runat="server" />
            <asp:TextBox ID="txtFirstName" runat="server" />
            <asp:TextBox ID="txtLastName" runat="server" />
            <asp:TextBox ID="txtEmail" runat="server" />
            <asp:Button ID="btnAdd" Text="Add" runat="server" OnClick="btnAdd_Click" />
        </div>
    </form>
</body>
</html>
