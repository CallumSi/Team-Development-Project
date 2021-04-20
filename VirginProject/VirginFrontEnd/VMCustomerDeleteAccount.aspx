<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMCustomerDeleteAccount.aspx.cs" Inherits="VirginFrontEnd.VMCustomerDeleteAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movies Customer Delete</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Virgin Movie Delete Account </h2>
        </header>
        <asp:Label ID="lblVMDeleteCustomer" runat="server" Text="VIRIGN MOVIES DELETE ACCOUNT" CssClass="lblVMDeleteCustomer"></asp:Label>
        <asp:Label ID="lblDeleteVMCConfirmation" runat="server" Text="Are you sure you want to delete your account?" CssClass="lblDeleteVMCConfirmation"></asp:Label>
        <asp:Button ID="btnYes" runat="server" Text="YES" CssClass="btnYesDeleteCustomer" OnClick="btnYes_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="CANCEL" CssClass="btnCancelDeleteCustomer" OnClick="btnCancel_Click"  />
        <nav>
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnCustomerHome" OnClick="btnHome_Click" />
            <asp:Button ID="btnViewCart" CssClass="btnCustomerCart" runat="server" Text="View Shopping Cart" OnClick="btnViewCart_Click"  />
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
