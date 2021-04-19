<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVMPayment.aspx.cs" Inherits="VirginFrontEnd.AnVMPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movie Payment Details</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Virgin Movie Customer Payment Details</h2>
        </header>
        <asp:Label ID="lblAnVMPayment" runat="server" Text="VIRGIN MOVIES PAYMENT" CssClass="lblAnVMPayment"></asp:Label>
        <asp:Label ID="lblPaymentStatus" runat="server" Text="PAYMENT STATUS: " CssClass="lblPaymentStatus"></asp:Label>
        <asp:Label ID="lblPaymentType" runat="server" Text="PAYMENT TYPE: " CssClass="lblVMcustomerEmail"></asp:Label>
        <asp:TextBox ID="txtPaymentType" runat="server" CssClass="txtPaymentType"></asp:TextBox>
        <asp:CheckBox ID="chkPaymentStatus" runat="server" OnCheckedChanged="chkPaymentStatus_CheckedChanged" CssClass="chkPaymentStatus" />
        <asp:Button ID="btnOkay" runat="server" Text="OKAY" CssClass="btnOKVMPayment" OnClick="btnOkay_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="CANCEL" CssClass="btnCancelVMPayment" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="lblErrorPayment"></asp:Label>
        <nav>
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnStaffHome" OnClick="btnHome_Click"/>
            <asp:Button ID="btnCustomerList" CssClass="btnCustomerList" runat="server" Text="View Customer List" OnClick="btnCustomerList_Click" />
            <asp:Button ID="btnStaffMovie" runat="server" CssClass="btnStaffMovie" Text="View Movie List" OnClick="btnStaffMovie_Click" />
            <asp:Button ID="btnVMStaffList" runat="server" CssClass="btnStaffVMList" Text="View Staff List" OnClick="btnVMStaffList_Click" />
            <asp:Button ID="btnVMPaymentList" runat="server" Text="View Payment List" CssClass="btnVMPaymentList" OnClick="btnVMPaymentList_Click" />
            <asp:Button ID="btnLogOut" CssClass="btnVMStaffLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />

        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
