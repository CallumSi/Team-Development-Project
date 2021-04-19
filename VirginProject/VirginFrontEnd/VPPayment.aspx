<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPPayment.aspx.cs" Inherits="VirginFrontEnd.VPPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCardNo" runat="server" style="z-index: 1; left: 311px; top: 122px; position: absolute" Text="CardNo"></asp:Label>
        <asp:TextBox ID="txtCardNo" runat="server" style="z-index: 1; left: 393px; top: 121px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblExpiryDate" runat="server" style="z-index: 1; left: 302px; top: 174px; position: absolute" Text="Expiry Date"></asp:Label>
        <asp:Label ID="lblSecurityNo" runat="server" style="z-index: 1; left: 304px; top: 226px; position: absolute" Text="SecurityNo"></asp:Label>
        <asp:TextBox ID="txtExpiryDate" runat="server" style="z-index: 1; left: 395px; top: 173px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSecurityNo" runat="server" style="z-index: 1; left: 395px; top: 224px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnPlaceOrder" runat="server" style="z-index: 1; left: 447px; top: 304px; position: absolute; right: 933px;" Text="Place Order" OnClick="btnPlaceOrder_Click1" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 571px; top: 305px; position: absolute; width: 70px" Text="Cancel " OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 310px; top: 274px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnCustomerHome" runat="server" OnClick="btnCustomerHome_Click" style="z-index: 1; left: 80px; top: 105px; position: absolute; height: 74px; width: 155px" Text="Home" />
        <asp:Button ID="btnViewCart" runat="server" OnClick="btnViewCart_Click" style="z-index: 1; left: 81px; top: 236px; position: absolute; height: 75px; width: 147px" Text="View Cart" />
        <asp:Button ID="btnEditAccount" runat="server" OnClick="btnEditAccount_Click" style="z-index: 1; left: 83px; top: 374px; position: absolute; height: 83px; width: 146px" Text="Edit Account" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 83px; top: 586px; position: absolute; height: 65px; width: 136px" Text="Log Out" />
    </form>
</body>
</html>
