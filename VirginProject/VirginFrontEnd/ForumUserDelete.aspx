<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumUserDelete.aspx.cs" Inherits="VirginFrontEnd.ForumUserDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 328px; top: 180px; position: absolute; height: 34px; width: 68px" Text="Yes" />
        <asp:Label ID="lblUserDelete" runat="server" style="z-index: 1; left: 237px; top: 106px; position: absolute" Text="Are you sure you want to delete this user"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 483px; top: 182px; position: absolute; height: 37px; width: 76px" Text="No" />
    </form>
</body>
</html>
