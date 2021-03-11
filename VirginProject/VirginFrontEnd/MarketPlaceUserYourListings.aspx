<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketPlaceUserYourListings.aspx.cs" Inherits="VirginFrontEnd.MarketPlaceUserYourListings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 119px; top: 44px; position: absolute; height: 19px;" Text="Your Listings"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 858px; top: 56px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 177px; top: 90px; position: absolute; margin-top: 9px; width: 169px;"></asp:TextBox>
        <asp:Button ID="btnClickHere" runat="server" style="z-index: 1; left: 254px; top: 133px; position: absolute; margin-top: 1px;" Text="Click Here" OnClick="btnClickHere_Click" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 122px; top: 98px; position: absolute" Text="Search"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 121px; top: 133px; position: absolute; right: 865px" Text="Want to sell a item"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 122px; top: 170px; position: absolute; width: 111px;" Text="Suggested for you"></asp:Label>
           <asp:ListBox ID="lstYourListings" runat="server" style="z-index: 1; left: 344px; top: 217px; position: absolute; height: 184px; width: 440px; margin-top: 0px"></asp:ListBox>
           <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 344px; top: 437px; position: absolute" Text="Edit" />
           <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 718px; top: 440px; position: absolute; margin-bottom: 0px" Text="Delete" />
           <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 339px; top: 503px; position: absolute"></asp:Label>
        
    </form>
</body>
</html>
