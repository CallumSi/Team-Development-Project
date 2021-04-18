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
        <asp:Label ID="lblCardNo" runat="server" style="z-index: 1; left: 30px; top: 111px; position: absolute" Text="CardNo"></asp:Label>
        <asp:TextBox ID="txtCardNo" runat="server" style="z-index: 1; left: 105px; top: 110px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblExpiryDate" runat="server" style="z-index: 1; left: 26px; top: 173px; position: absolute" Text="Expiry Date"></asp:Label>
        <asp:Label ID="lblSecurityNo" runat="server" style="z-index: 1; left: 24px; top: 232px; position: absolute" Text="SecurityNo"></asp:Label>
        <asp:TextBox ID="txtExpiryDate" runat="server" style="z-index: 1; left: 106px; top: 173px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSecurityNo" runat="server" style="z-index: 1; left: 106px; top: 231px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnPlaceOrder" runat="server" style="z-index: 1; left: 36px; top: 294px; position: absolute; right: 645px;" Text="Place Order" OnClick="btnPlaceOrder_Click1" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 150px; top: 294px; position: absolute; width: 70px" Text="Cancel " OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 356px; position: absolute" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
