<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMPaymentDelete.aspx.cs" Inherits="VirginFrontEnd.VMPaymentDelete" %>

<!DOCTYPE html>
<html>
<head>
    <title>Virgin Movies Payment Delete</title>
    <link href="VMMovie.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Virgin Movies Payment Delete</h2>
        </header>

        <asp:Label ID="lblPaymentDelete" runat="server" Text="ARE YOU SURE YOU WANT TO DELETE THIS PAYMENT?" CssClass="lblVMPaymentDelete"></asp:Label>
        <asp:Button ID="btnYes" runat="server" Text="YES" CssClass="btnVMPaymentYes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" Text="NO" CssClass="btnVMPaymentNo" OnClick="btnNo_Click" />
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
            </div>
        </footer>
    </form>
</body>
</html>


