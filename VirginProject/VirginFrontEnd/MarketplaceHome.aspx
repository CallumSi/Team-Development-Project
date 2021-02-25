<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceHome.aspx.cs" Inherits="VirginFrontEnd.MarketplaceHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 119px; top: 44px; position: absolute" Text="Marketplace Home"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 858px; top: 56px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 174px; top: 90px; position: absolute; margin-top: 9px; width: 169px;"></asp:TextBox>
        <asp:Button ID="btnClickHere" runat="server" style="z-index: 1; left: 252px; top: 132px; position: absolute; margin-top: 1px;" Text="Click Here" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 122px; top: 98px; position: absolute" Text="Search"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 121px; top: 133px; position: absolute; right: 767px" Text="Want to sell a item"></asp:Label>
        <asp:Label ID="listingname1" runat="server" style="z-index: 1; left: 123px; top: 357px; position: absolute"></asp:Label>
        <asp:Label ID="listingprice1" runat="server" style="z-index: 1; left: 124px; top: 383px; position: absolute; right: 799px; height: 19px;"></asp:Label>
        <asp:Image ID="listingimage5" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 118px; top: 426px; position: absolute; height: 125px; width: 177px" />
        <asp:Button ID="listingbutton6" runat="server" style="z-index: 1; left: 457px; top: 587px; position: absolute; width: 41px;" Text="View" />
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 122px; top: 170px; position: absolute; width: 111px;" Text="Suggested for you"></asp:Label>
        <asp:Image ID="listingimage2" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 324px; top: 210px; position: absolute; height: 136px; width: 179px" />
        <asp:Button ID="listingbutton5" runat="server" style="z-index: 1; left: 249px; top: 590px; position: absolute" Text="View" />
        <asp:Label ID="listingname2" runat="server" style="z-index: 1; left: 327px; top: 356px; position: absolute; right: 619px;"></asp:Label>
        <asp:Label ID="listingprice3" runat="server" style="z-index: 1; left: 541px; top: 389px; position: absolute"></asp:Label>
        <asp:Image ID="listingimage7" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 536px; top: 427px; position: absolute; height: 129px; width: 175px" />
        <asp:Button ID="listingbutton4" runat="server" style="z-index: 1; left: 875px; top: 373px; position: absolute" Text="View" />
        <asp:Label ID="listingname3" runat="server" style="z-index: 1; left: 541px; top: 354px; position: absolute"></asp:Label>
        <asp:Label ID="listingname6" runat="server" style="z-index: 1; left: 332px; top: 570px; position: absolute; height: 19px;"></asp:Label>
        <asp:Image ID="listingimage8" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 751px; top: 428px; position: absolute; height: 123px; width: 171px" />
        <asp:Button ID="listingbutton3" runat="server" style="z-index: 1; left: 662px; top: 373px; position: absolute; height: 26px;" Text="View" />
        <asp:Label ID="listingname8" runat="server" style="z-index: 1; left: 753px; top: 571px; position: absolute"></asp:Label>
        <asp:Label ID="listingprice8" runat="server" style="z-index: 1; left: 753px; top: 605px; position: absolute"></asp:Label>
        <asp:Image ID="listingimage1" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 123px; top: 213px; position: absolute; height: 126px; width: 170px; margin-top: 1px;" />
        <asp:Button ID="listingbutton2" runat="server" style="z-index: 1; left: 459px; top: 371px; position: absolute" Text="View" />
        <asp:Label ID="listingprice5" runat="server" style="z-index: 1; left: 118px; top: 610px; position: absolute; right: 830px;"></asp:Label>
        <asp:Image ID="listingimage6" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 331px; top: 431px; position: absolute; height: 122px; width: 175px; right: 639px; margin-top: 0px;" />
        <asp:Button ID="listingbutton1" runat="server" style="z-index: 1; left: 250px; top: 369px; position: absolute" Text="View" />
        <asp:Label ID="listingname5" runat="server" style="z-index: 1; left: 120px; top: 577px; position: absolute"></asp:Label>
        <asp:Label ID="listingprice7" runat="server" style="z-index: 1; left: 537px; top: 602px; position: absolute"></asp:Label>
        <asp:Image ID="listingimage3" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 537px; top: 213px; position: absolute; height: 127px; width: 171px" />
        <asp:Button ID="listingbutton8" runat="server" style="z-index: 1; left: 878px; top: 587px; position: absolute" Text="View" />
        <asp:Label ID="listingname7" runat="server" style="z-index: 1; left: 537px; top: 573px; position: absolute"></asp:Label>
        <asp:Label ID="listingprice2" runat="server" style="z-index: 1; left: 327px; top: 387px; position: absolute"></asp:Label>
        <asp:Image ID="listingimage4" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 745px; top: 213px; position: absolute; height: 125px; width: 174px; margin-top: 2px;" />
        <asp:Button ID="listingbutton7" runat="server" style="z-index: 1; left: 667px; top: 585px; position: absolute" Text="View" />
        <asp:Label ID="listingname4" runat="server" style="z-index: 1; left: 747px; top: 353px; position: absolute; bottom: 335px;"></asp:Label>
        <asp:Label ID="listingprice4" runat="server" style="z-index: 1; left: 748px; top: 383px; position: absolute"></asp:Label>
        <asp:Label ID="listingprice6" runat="server" style="z-index: 1; left: 333px; top: 604px; position: absolute"></asp:Label>
        
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 770px; top: 57px; position: absolute" Text="Logged in as:"></asp:Label>
        
    </form>
</body>
</html>
