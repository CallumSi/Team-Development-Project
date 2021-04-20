<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPViewCart.aspx.cs" Inherits="VirginFrontEnd.VPViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstShoppingCart" runat="server" style="z-index: 1; left: 373px; top: 77px; position: absolute; height: 361px; width: 513px"></asp:ListBox>
        <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 75px; top: 87px; position: absolute; height: 82px; width: 150px;" Text="Home" OnClick="btnHome_Click" />
        <asp:Button ID="btnDelivery" runat="server" style="z-index: 1; left: 556px; top: 483px; position: absolute" Text="Continue to Delivery" OnClick="btnPayment_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 382px; top: 452px; position: absolute" Text=""></asp:Label>
        <asp:Button ID="btnViewCart" runat="server" OnClick="btnViewCart_Click" style="z-index: 1; left: 71px; top: 199px; position: absolute; height: 76px; width: 159px;" Text="View Cart" />
        <asp:Button ID="btnEditAccount" runat="server" style="z-index: 1; left: 72px; top: 312px; position: absolute; height: 73px; width: 158px" Text="Edit Account" />
        <asp:Button ID="btnLogOut" runat="server" style="z-index: 1; left: 73px; top: 419px; position: absolute; height: 82px; width: 156px" Text="Log Out" />
        <asp:Button ID="btnContinueShopping" runat="server" OnClick="btnContinueShopping_Click" style="z-index: 1; left: 381px; top: 483px; position: absolute; height: 25px; width: 159px" Text="Continue Shopping" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 745px; top: 482px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
