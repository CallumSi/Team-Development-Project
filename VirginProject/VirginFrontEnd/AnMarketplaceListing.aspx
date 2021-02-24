﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnMarketplaceListing.aspx.cs" Inherits="VirginFrontEnd.AnMarketplaceListing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 78px; top: 78px; position: absolute" Text="Marketplace Listing Details"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 77px; top: 130px; position: absolute" Text="Listing Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 77px; top: 158px; position: absolute" Text="Img Path"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 64px; top: 325px; position: absolute" Text="Delivery Type"></asp:Label>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 80px; top: 191px; position: absolute" Text="Price"></asp:Label>
        <asp:TextBox ID="txtListingName" runat="server" style="z-index: 1; left: 182px; top: 128px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 76px; top: 229px; position: absolute" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 184px; top: 195px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtImg" runat="server" style="z-index: 1; left: 183px; top: 161px; position: absolute; height: 21px"></asp:TextBox>
        <asp:TextBox ID="txtCategory" runat="server" style="z-index: 1; left: 185px; top: 265px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 184px; top: 229px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 68px; top: 297px; position: absolute; width: 69px; margin-top: 0px" Text="Description"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 76px; top: 260px; position: absolute" Text="Category"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 186px; top: 299px; position: absolute; right: 753px; margin-top: 0px"></asp:TextBox>
        <asp:TextBox ID="txtDeliveryType" runat="server" style="z-index: 1; left: 183px; top: 331px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 111px; top: 365px; position: absolute" Text="New?"></asp:Label>
        <asp:CheckBox ID="chkboxNew" runat="server" style="z-index: 1; left: 182px; top: 369px; position: absolute" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 393px; top: 305px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 262px; top: 475px; position: absolute" Text="Ok" OnClick="btnOk_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 166px; top: 476px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>