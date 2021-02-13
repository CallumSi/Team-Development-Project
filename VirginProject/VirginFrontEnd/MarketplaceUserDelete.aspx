<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceUserDelete.aspx.cs" Inherits="VirginFrontEnd.MarketplaceUserDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Delete user"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 11px; top: 60px; position: absolute; height: 22px" Text="Are you sure you want to delete the selected user?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 88px; top: 116px; position: absolute" Text="No" />
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 22px; top: 116px; position: absolute" Text="Yes" />
    </form>
</body>
</html>
