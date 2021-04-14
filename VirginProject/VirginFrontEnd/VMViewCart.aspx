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
        <article>

                    <asp:Label ID="lblUsername" runat="server" CssClass="lblUsername" Text="Welcome "></asp:Label>

            <asp:ListBox ID="lstShoppingCart" runat="server" CssClass="lstShoppingCart" ></asp:ListBox>
            <ul>
                <asp:Button ID="btnContinueShopping" CssClass="btnContinueShopping" runat="server" Style="z-index: 1;" Text="Continue Shopping" OnClick="btnContinueShopping_Click" />
                <asp:Button ID="btnVMovieCheckout" CssClass="btnVMovieCheckout" runat="server" Style="z-index: 1;" Text="Go to Checkout" OnClick="btnVMovieCheckout_Click" />
                <asp:Label ID="lblError" runat="server" CssClass="lblCheckoutError" Text=""></asp:Label>
            </ul>
        </article>

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
