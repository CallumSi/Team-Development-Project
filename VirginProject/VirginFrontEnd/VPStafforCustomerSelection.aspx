<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPStafforCustomerSelection.aspx.cs" Inherits="VirginFrontEnd.VPStafforCustomerSelection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 64px; top: 109px; position: absolute; height: 72px; width: 153px" Text="Log Out" />
        <asp:Label ID="lblSelectAccount" runat="server" style="z-index: 1; left: 409px; top: 226px; position: absolute; height: 21px; width: 371px" Text="Please select below which account you would like to access"></asp:Label>
        <asp:Button ID="btnVPAStaff" runat="server" Font-Bold="True" OnClick="btnVPAStaff_Click" style="z-index: 1; left: 405px; top: 282px; position: absolute; height: 58px; width: 149px" Text="Staff" />
        <asp:Button ID="btnVPACustomer" runat="server" Font-Bold="True" OnClick="btnVPACustomer_Click" style="z-index: 1; left: 574px; top: 282px; position: absolute; height: 57px; width: 148px" Text="Customer" />
    </form>
</body>
</html>
