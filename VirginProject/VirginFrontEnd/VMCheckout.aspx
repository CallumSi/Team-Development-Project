<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMCheckout.aspx.cs" Inherits="VirginFrontEnd.VMCheckout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>VIRGIN MOVIES CHECKOUT</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form2" runat="server">

        <header>
            <h2>Virgin Media </h2>
        </header>
        <asp:Label ID="lblWelcomeUsername" runat="server" Text="Welcome: " CssClass="lblWelcomeUsername"></asp:Label>
        <asp:Label ID="lblMVUsername" runat="server" CssClass="lblUsername"></asp:Label>
        <asp:Label ID="lblVMCheckOut" runat="server" Text="VIRGIN MOVIES CHECKOUT" CssClass="lblVMCheckOut"></asp:Label>
        <asp:Label ID="lblCardDetails" runat="server" Text="Please enter your details:" CssClass="lblCardDetails"></asp:Label>
        <asp:Label ID="lblVMCardNo" runat="server" Text="Credit Card No: " CssClass="lblVMCardNo"></asp:Label>
        <asp:TextBox ID="txtCardNo" runat="server" CssClass="txtVMCardNo"></asp:TextBox>
        <asp:Button ID="btnCheckout" runat="server" Text="Checkout" CssClass="btnVMCheckout" OnClick="btnCheckout_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="lblCheckoutCardError" BackColor="Black" ></asp:Label>

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
