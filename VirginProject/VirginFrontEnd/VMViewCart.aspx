<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMViewCart.aspx.cs" Inherits="VirginFrontEnd.VMViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>VIRGIN MOVIES SHOPPING CART</title>

    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form2" runat="server">
        <header>
            <h2>Virgin Movies Shopping Cart </h2>
        </header>

        <asp:Label ID="lblWelcomeUsername" runat="server" Text="Welcome: " CssClass="lblWelcomeUsername"></asp:Label>
        <asp:Label ID="lblMVUsername" runat="server" CssClass="lblUsername"></asp:Label>
        <asp:Label ID="lblVMAshoppingCart" runat="server" Text="YOUR SHOPPING CART" CssClass="lblVMAshoppingCart"></asp:Label>
        <asp:ListBox ID="lstShoppingCart" runat="server" CssClass="lstShoppingCart"></asp:ListBox>
        <asp:Button ID="btnContinueShopping" CssClass="btnContinueShopping" runat="server" Text="Continue Shopping" OnClick="btnContinueShopping_Click" />
        <asp:Button ID="btnVMovieCheckout" CssClass="btnVMovieCheckout" runat="server" Text="Go to Checkout" OnClick="btnVMovieCheckout_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="lblCheckoutError" Text=""></asp:Label>
        <nav>
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnCustomerHome" OnClick="btnHome_Click" />
            <asp:Button ID="btnViewCart" CssClass="btnCustomerCart" runat="server" Text="View Shopping Cart" OnClick="btnViewCart_Click" />
            <asp:Label ID="lblCartCount" runat="server" CssClass="lblCartCount" Text=""></asp:Label>
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
