<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHCustomerList.aspx.cs" Inherits="VirginFrontEnd.VCHCustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomer" runat="server" Height="300px" Width="300px"></asp:ListBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 14px; top: 359px; position: absolute" Text="Please Enter a Customers First Name"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 396px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 10px; top: 488px; position: absolute" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 97px; top: 488px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 7px; top: 539px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 77px; top: 540px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 142px; top: 539px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:TextBox ID="txtBxSearch" runat="server" style="z-index: 1; left: 13px; top: 434px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
