<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceUserProfile.aspx.cs" Inherits="VirginFrontEnd.MarketplaceUserProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 119px; top: 44px; position: absolute" Text="Marketplace Home"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 858px; top: 56px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 177px; top: 90px; position: absolute; margin-top: 9px; width: 169px;"></asp:TextBox>
        <asp:Button ID="btnClickHere" runat="server" style="z-index: 1; left: 252px; top: 132px; position: absolute; margin-top: 1px;" Text="Click Here" OnClick="btnClickHere_Click" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 122px; top: 98px; position: absolute" Text="Search"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 121px; top: 133px; position: absolute; right: 871px" Text="Want to sell a item"></asp:Label>
        
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 770px; top: 57px; position: absolute" Text="Logged in as:"></asp:Label>
        
        <asp:Button ID="btnApplySearch" runat="server" OnClick="btnApplySearch_Click" style="z-index: 1; left: 363px; top: 99px; position: absolute" Text="Go" />
        
        <asp:Button ID="btnMyAccount" runat="server" OnClick="btnMyAccount_Click" style="z-index: 1; left: 769px; top: 112px; position: absolute" Text="Your Account" />
        
          <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 474px; top: 194px; position: absolute" Text="Where would you like to go?"></asp:Label>
          <asp:Button ID="btnFavoritedListings" runat="server" OnClick="btnFavoritedListings_Click" style="z-index: 1; left: 345px; top: 303px; position: absolute; height: 25px" Text="Favorited Listings" />
          <asp:Button ID="btnYourListings" runat="server" OnClick="btnYourListings_Click" style="z-index: 1; left: 688px; top: 309px; position: absolute" Text="Your Listings" />
        
    </form>
</body>
</html>
