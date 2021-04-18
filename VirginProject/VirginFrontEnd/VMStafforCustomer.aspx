<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMStafforCustomer.aspx.cs" Inherits="VirginFrontEnd.VMStafforCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movies Staff or Customer </title>
    <link href="VMAdmin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header>Virgin Movies Staff or Customer</header>

        <asp:Label ID="lblOption" runat="server" Text="Please select from the options below:" CssClass="lblOption"></asp:Label>
        <asp:Button ID="btnVMAStaff" runat="server" Text="Staff" CssClass="btnVMAStaffList" OnClick="btnVMAStaff_Click" />
        <asp:Button ID="btnVMACustomer" runat="server" Text="Customer" CssClass="btnVMACustomerMovie" OnClick="btnVMACustomer_Click" />
        <nav>
            <asp:Button ID="btnLogOut" runat="server" Text="Log Out" CssClass="btnLogOut" OnClick="btnLogOut_Click"/>
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

    </form>
</body>
</html>
