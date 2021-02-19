<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="VirginFrontEnd.UserList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label runat="server" style="z-index: 1; left: 140px; top: 91px; position: absolute" Text="Manage Users"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 143px; top: 132px; position: absolute" Text="Filter by Username"></asp:Label>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 214px; top: 171px; position: absolute" Text="DisplayAll" />
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 137px; top: 171px; position: absolute" Text="Apply" />
        <asp:ListBox ID="lstUser" runat="server" style="z-index: 1; left: 131px; top: 234px; position: absolute; width: 240px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 135px; top: 319px; position: absolute"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 134px; top: 368px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 214px; top: 369px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 300px; top: 371px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
