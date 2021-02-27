<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceListingViewer.aspx.cs" Inherits="VirginFrontEnd.MarketplaceListingViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body class="lblPrice">
    <form id="form1" runat="server">
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 113px; top: 401px; position: absolute; width: 116px;" Text="Delivery Type:"></asp:Label>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 112px; top: 258px; position: absolute" Text="Price: £"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 323px; top: 214px; position: absolute; bottom: 444px;" Text="Available"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 115px; top: 435px; position: absolute; width: 69px; margin-top: 0px" Text="Description:"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 104px; top: 128px; position: absolute; right: 641px;" Text="Condition:"></asp:Label>
        <asp:Label ID="lblCategory" runat="server" style="z-index: 1; left: 395px; top: 91px; position: absolute"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 174px; top: 260px; position: absolute; width: 54px"></asp:Label>
        <asp:Image ID="imgListing" runat="server" style="z-index: 1; left: 523px; top: 137px; position: absolute; height: 200px; width: 303px" />
        <asp:Label ID="lblListingName" runat="server" style="z-index: 1; left: 394px; top: 54px; position: absolute" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 205px; top: 433px; position: absolute; height: 19px"></asp:Label>&nbsp;<asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 229px; position: absolute; top: 213px; width: 81px"></asp:Label>
        <asp:Label ID="label1" runat="server" style="z-index: 1; left: 105px; top: 157px; position: absolute; width: 75px" Text="Time Left:"></asp:Label>
        <asp:Label ID="lblCondition" runat="server" style="z-index: 1; left: 174px; top: 129px; position: absolute"></asp:Label>
        <asp:Label ID="label23" runat="server" style="z-index: 1; left: 105px; top: 214px; position: absolute; height: 23px; right: 906px;" Text="Quantity:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 174px; top: 214px; position: absolute; width: 33px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 111px; top: 321px; position: absolute" Text="Add to Cart" />
        <asp:Button ID="btnBuyNow" runat="server" style="z-index: 1; left: 110px; top: 283px; position: absolute; width: 99px" Text="Buy Now" />
        <asp:Button ID="btnFavorite" runat="server" style="z-index: 1; left: 111px; top: 360px; position: absolute; width: 97px; right: 415px" Text="Favorite" />
        <asp:Label ID="lblTimeLeft" runat="server" style="z-index: 1; left: 177px; top: 158px; position: absolute"></asp:Label>
        <asp:Label ID="lblDeliveryType" runat="server" style="z-index: 1; left: 209px; top: 399px; position: absolute"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 525px; top: 366px; position: absolute" Text="Seller:"></asp:Label>
        <asp:Label ID="lblSellerEmail" runat="server" style="z-index: 1; left: 579px; top: 367px; position: absolute"></asp:Label>
        <p>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 315px; top: 86px; position: absolute" Text="Category:"></asp:Label>
        </p>
    </form>
</body>
</html>
