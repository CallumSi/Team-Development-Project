<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPCustomerFirstTime.aspx.cs" Inherits="VirginFrontEnd.VPCustomerFirstTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Phones Customer First Time</title>
    <link href="VPhoneStyleSheet.css" rel="stylesheet" type="text/css" />
 
</head>
<body>
    <form id="form1" runat="server">
        <header><h2> Virgin Phones Customer First Time</h2></header>

        <asp:Button ID="btnVPNewComer" runat="server" Text="Need to sign up? Click Here" style="z-index: 1; left: 909px; top: 273px; position: absolute; height: 30px; width: 341px;" CssClass="btnVPNewComer" OnClick="btnVPNewComer_Click" Font-Bold="True" Font-Size="Medium" ForeColor="Black" />
        
        <nav>
            <asp:Button ID="btnLogOut" runat="server" Text="Log Out" style="z-index: 1; left: 58px; top: 27px; position: absolute; height: 77px; width: 172px" CssClass="btnLogOut" OnClick="btnLogOut_Click" Font-Bold="True" ForeColor="Black" />

        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

        <p>
            &nbsp;</p>

        <asp:Label ID="lblWelcomeVP" runat="server" Text="Welcome to Virgin Phones" style="z-index: 1; left: 786px; top: 172px; position: absolute; height: 37px; width: 245px; margin-bottom: 1px;" CssClass="lblWelcomeVP" Font-Bold="True" Font-Size="Large" ForeColor="Black"></asp:Label>

        <asp:Button ID="btnContinueVP" runat="server" OnClick="btnContinueVP_Click1" style="z-index: 1; left: 609px; top: 273px; position: absolute; width: 267px; height: 30px;" Text="Continue To Virgin Phones" Font-Bold="True" Font-Size="Medium" ForeColor="Black" />

    </form>
</body>
</html>
