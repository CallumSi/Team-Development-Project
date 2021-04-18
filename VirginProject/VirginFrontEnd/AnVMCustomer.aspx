<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVMCustomer.aspx.cs" Inherits="VirginFrontEnd.AnVMCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movie Customer Information</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Virgin Movie Customer Details</h2>
        </header>
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
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnStaffHome" OnClick="btnHome_Click" />
            <asp:Button ID="btnCustomerList" CssClass="btnCustomerList" runat="server" Text="View Customer List" OnClick="btnCustomerList_Click" />
            <asp:Button ID="btnStaffMovie" runat="server" CssClass="btnStaffMovie" Text="View Movie List" OnClick="btnStaffMovie_Click" />
            <asp:Button ID="btnVMStaffList" runat="server" CssClass="btnStaffVMList" Text="View Staff List" OnClick="btnVMStaffList_Click" />
            <asp:Button ID="btnVMPaymentList" runat="server" Text="View Payment List" CssClass="btnVMPaymentList" OnClick="btnVMPaymentList_Click" />
            <asp:Button ID="btnLogOut" CssClass="btnVMStaffLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />

        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </form>
</body>
</html>
