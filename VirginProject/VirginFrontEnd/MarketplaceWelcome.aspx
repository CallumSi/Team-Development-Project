<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceWelcome.aspx.cs" Inherits="VirginFrontEnd.MarketplaceWelcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" BackColor="#0066FF" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="Larger" style="z-index: 1; left: 396px; top: 82px; position: absolute; width: 279px" Text="Welcome to the Online Marketplace"></asp:Label>
        <asp:Button ID="btnFirstTime" runat="server" OnClick="btnFirstTime_Click" style="z-index: 1; left: 575px; top: 339px; position: absolute" Text="First Time?" />
        <asp:Button ID="btnContinue" runat="server" style="z-index: 1; left: 413px; top: 341px; position: absolute" Text="Continue " OnClick="btnContinue_Click" />
    </form>
</body>
</html>
