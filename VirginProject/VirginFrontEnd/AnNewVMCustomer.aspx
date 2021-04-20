<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnNewVMCustomer.aspx.cs" Inherits="VirginFrontEnd.AnNewVMCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movie New Customer Information</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Virgin Movie New Customer Details</h2>
        </header>
        <asp:Label ID="lblMVUsername" runat="server" CssClass="lblUsername"></asp:Label>
        <asp:Label ID="lblWelcomeUsername" runat="server" Text="Welcome: " CssClass="lblWelcomeUsername"></asp:Label>
        <asp:Label ID="lblAnVMCustomer" runat="server" Text="VIRGIN MOVIES CUSTOMER DETAILS" CssClass="lblAnVMCustomer"></asp:Label>
        <asp:Label ID="lblVMcustomerFirstname" runat="server" Text="CUSTOMER FIRSTNAME: " CssClass="lblVMcustomerFirstname"></asp:Label>
        <asp:Label ID="lblVMcustomerLastname" runat="server" Text="CUSTOMER LASTNAME: " CssClass="lblVMcustomerLastname"></asp:Label>
        <asp:Label ID="lblVMcustomerEmail" runat="server" Text="CUSTOMER EMAIL: " CssClass="lblVMcustomerEmail"></asp:Label>
        <asp:Label ID="lblVMcustomerUsername" runat="server" Text="CUSTOMER USERNAME: " CssClass="lblVMcustomerUsername"></asp:Label>
        <asp:Label ID="lblVMcustomerPassword" runat="server" Text="CUSTOMER PASSWORD: " CssClass="lblVMcustomerPassword"></asp:Label>
        <asp:TextBox ID="txtVMcustomerFirstname" runat="server" CssClass="txtVMcustomerFirstname"></asp:TextBox>
        <asp:TextBox ID="txtVMcustomerLastname" runat="server" CssClass="txtVMcustomerLastname"></asp:TextBox>
        <asp:TextBox ID="txtVMcustomerEmail" runat="server" CssClass="txtVMcustomerEmail"></asp:TextBox>
        <asp:TextBox ID="txtVMcustomerUsername" runat="server" CssClass="txtVMcustomerUsername"></asp:TextBox>
        <asp:TextBox ID="txtVMcustomerPassword" runat="server" CssClass="txtVMcustomerPassword"></asp:TextBox>
        <asp:Button ID="btnOkay" runat="server" Text="OKAY" CssClass="btnOkayVMCustomer" OnClick="btnOkay_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="CANCEL" CssClass="btnCancelVMCustomer" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="lblErrorVMCustomer"></asp:Label>
        <nav>

            <asp:Button ID="btnLogOut" CssClass="btnVMNCustomerLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
