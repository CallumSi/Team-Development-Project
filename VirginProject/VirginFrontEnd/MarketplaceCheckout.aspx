<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceCheckout.aspx.cs" Inherits="VirginFrontEnd.MarketplaceCheckout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Payment details are typically captured here - leave it blank to see what might happen if payment details are not valid<br />
        <br />
        Credit card no <asp:TextBox ID="txtCardNo" runat="server" Width="257px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnCheckout" runat="server" OnClick="btnCheckout_Click" Text="Check Out" />
    
    </div>
    </form>
</body>
</html>
