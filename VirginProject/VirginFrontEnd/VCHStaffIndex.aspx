<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHStaffIndex.aspx.cs" Inherits="VirginFrontEnd.VCHStaffIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Welcome</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblWelcome" runat="server" style="position: absolute; z-index: 1; left: 425px; top: 175px" Text="Welcome to Virgin Car Hire Staff-End. If this is your first time on the site, we need to collect more details from you. Please supply the correct information in order to fully utilise Virgin's Car Hire Staff-End site." Width="550px"></asp:Label>
        <asp:Button ID="btnNewStaff" runat="server" style="z-index: 1; left: 850px; top: 355px; position: absolute" Text="New Staff Memeber" OnClick="btnNewStaff_Click" />
        <asp:Button ID="btnReturningStaff" runat="server" style="z-index: 1; left: 425px; top: 355px; position: absolute" Text="Returning Staff" OnClick="btnReturningStaff_Click" />
    </form>
</body>
</html>
