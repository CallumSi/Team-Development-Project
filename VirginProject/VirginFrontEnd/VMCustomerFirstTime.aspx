<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMCustomerFirstTime.aspx.cs" Inherits="VirginFrontEnd.VMCustomerFirstTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movies First Time</title>
    <link href="VMAdmin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header><h2> Virgin Movies First Time</h2></header>

        <asp:Label ID="lblWelcomeVM" runat="server" Text="Welcome to Virgin Movies" CssClass="lblWelcomeVM"></asp:Label>
        <asp:Button ID="btnContinueVM" runat="server" Text="Continue to Virgin Movies" CssClass="btnContinueVM" OnClick="btnContinueVM_Click" />
        <asp:Button ID="btnVMNewComer" runat="server" Text="Need to sign up? Click Here" CssClass="btnVMNewComer" OnClick="btnVMNewComer_Click" />
        <nav>
            <asp:Button ID="btnLogOut" runat="server" Text="Log Out" CssClass="btnLogOut" OnClick="btnLogOut_Click" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

    </form>
</body>
</html>
