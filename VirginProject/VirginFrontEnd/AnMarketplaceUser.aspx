<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnMarketplaceUser.aspx.cs" Inherits="VirginFrontEnd.AnMarketplaceUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Please Update your details"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 20px; top: 155px; position: absolute" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 92px; top: 153px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 296px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 114px; top: 348px; position: absolute" Text="OK" OnClick="btnOk_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 210px; top: 347px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 16px; top: 187px; position: absolute; width: 94px" Text="Line One"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 20px; top: 221px; position: absolute" Text="Line Two"></asp:Label>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 17px; top: 257px; position: absolute" Text="PostCode"></asp:Label>
        <asp:TextBox ID="txtDeliveryAdressLineOne" runat="server" style="z-index: 1; left: 92px; top: 188px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDeliveryAdressLineTwo" runat="server" style="z-index: 1; left: 89px; top: 224px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 89px; top: 256px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
