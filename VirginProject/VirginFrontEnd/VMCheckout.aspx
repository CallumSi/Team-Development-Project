<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMCheckout.aspx.cs" Inherits="VirginFrontEnd.VMCheckout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
    <div>
        <br />
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
