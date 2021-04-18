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
        <asp:ListBox ID="lstShoppingCart" runat="server" style="z-index: 1; left: 18px; top: 46px; position: absolute; height: 361px; width: 513px"></asp:ListBox>
        <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 19px; top: 432px; position: absolute" Text="Home" OnClick="btnHome_Click" />
        <asp:Button ID="btnPayment" runat="server" style="z-index: 1; left: 87px; top: 433px; position: absolute" Text="Continue to Payment" OnClick="btnPayment_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 486px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnViewCart" runat="server" OnClick="btnViewCart_Click" style="z-index: 1; left: 98px; top: 482px; position: absolute" Text="View Cart" />
    </form>
</body>
</html>
