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

        <article>

                    <asp:Label ID="lblUsername" runat="server" CssClass="lblUsername"></asp:Label>

            <ul>
                <li>Please enter your details
                </li>
                <li>Credit card no
                    <asp:TextBox ID="txtCardNo" runat="server" CssClass="txtVMCardNo"></asp:TextBox>
                </li>
                <li>
                    <asp:Button ID="btnCheckout" CssClass="btnCheckout" runat="server" Text="Check Out" />
                </li>
                <li>
                    <asp:Label ID="lblError" runat="server" CssClass="lblCheckoutCardError"></asp:Label>
                </li>
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
