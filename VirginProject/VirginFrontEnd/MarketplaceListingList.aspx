<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceListingList.aspx.cs" Inherits="VirginFrontEnd.MarketplaceListingList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
          <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 228px; top: 110px; position: absolute" Text="Marketplace Listings"></asp:Label>
        <asp:TextBox ID="txtListingName" runat="server" style="z-index: 1; left: 220px; top: 188px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 222px; top: 161px; position: absolute; height: 19px; width: 186px" Text="Filter By ListingName"></asp:Label>
        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 216px; top: 232px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 366px; top: 231px; position: absolute" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:ListBox ID="lstMarketplaceListing" runat="server" style="z-index: 1; left: 222px; top: 289px; position: absolute; width: 305px; height: 115px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 224px; top: 430px; position: absolute"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 215px; top: 477px; position: absolute" Text="Add user" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 341px; top: 478px; position: absolute; right: 860px;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 435px; top: 477px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
