<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAdminDelete.aspx.cs" Inherits="VirginFrontEnd.ForumAdminDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 520px; top: 140px; position: absolute" Text="No" />
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 371px; top: 137px; position: absolute" Text="Yes" />
        <asp:Label ID="lblDeleteAdmin" runat="server" style="z-index: 1; left: 358px; top: 73px; position: absolute; margin-top: 0px" Text="Are you sure you want to delete this admin?"></asp:Label>
    </form>
</body>
</html>
