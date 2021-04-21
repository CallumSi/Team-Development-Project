<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMAdminCheckPin.aspx.cs" Inherits="VirginFrontEnd.VMAdminCheckPin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movies Admin Check Pin</title>
    <link href="VMAdmin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Virgin Movies Check Pin </h2>

        </header>
        <asp:Label ID="lblCheckPin" runat="server" Text="Confirm Admin" CssClass="lblCheckPin"></asp:Label>
        <asp:Label ID="lblAdminPin" runat="server" Text="Confirm Pin: " CssClass="lblAdminPin"></asp:Label>
        <asp:TextBox ID="txtAdminPin" runat="server" CssClass="txtAdminPin" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnConfirmPin" runat="server" Text="Confirm" CssClass="btnConfirmPin" OnClick="btnConfirmPin_Click" />
        <asp:Button ID="btnBackHome" runat="server" Text="Back" CssClass="btnBackHome" OnClick="btnBackHome_Click" />
        <asp:Label ID="lblAdminPinError" runat="server" Text="" CssClass="lblAdminPinError"></asp:Label>
        <nav>
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
