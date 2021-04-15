<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMThanks.aspx.cs" Inherits="VirginFrontEnd.VMThanks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
    <title>Virgin Movie</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />


</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media Order Confirmation</h2>
        </header>

        <div class="MovieThanks">
            Thanks for your order!
        </div>
        <nav>
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnCustomerHome" OnClick="btnHome_Click" />
            <asp:Button ID="btnViewCart" CssClass="btnCustomerCart" runat="server" Text="View Shopping Cart" OnClick="btnViewCart_Click" />
            <asp:Button ID="btnEditAccount" CssClass="btnEditAccount" runat="server" Text="Edit Account Details" OnClick="btnEditAccount_Click" />
            <asp:Button ID="btnLogOut" CssClass="btnCustomerLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
