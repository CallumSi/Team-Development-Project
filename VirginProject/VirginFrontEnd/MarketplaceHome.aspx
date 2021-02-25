<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceHome.aspx.cs" Inherits="VirginFrontEnd.MarketplaceHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 120px; top: 73px; position: absolute" Text="Marketplace Home"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 921px; top: 70px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 254px; top: 175px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnClickHere" runat="server" style="z-index: 1; left: 260px; top: 210px; position: absolute" Text="Click Here" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 201px; top: 174px; position: absolute" Text="Search"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 128px; top: 211px; position: absolute; right: 779px" Text="Want to sell a item"></asp:Label>
        <asp:Label ID="listingname1" runat="server" style="z-index: 1; left: 121px; top: 375px; position: absolute"></asp:Label>
        <asp:Label ID="listingprice1" runat="server" style="z-index: 1; left: 123px; top: 407px; position: absolute; right: 872px;"></asp:Label>
        <asp:Image ID="listingimage5" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 119px; top: 478px; position: absolute; height: 90px; width: 103px" />
        <asp:Button ID="listingbutton6" runat="server" style="z-index: 1; left: 254px; top: 637px; position: absolute" Text="View" />
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 127px; top: 241px; position: absolute" Text="Suggested for you"></asp:Label>
        <asp:Image ID="listingimage2" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 257px; top: 270px; position: absolute; height: 90px; width: 103px" />
        <asp:Button ID="listingbutton5" runat="server" style="z-index: 1; left: 114px; top: 643px; position: absolute" Text="View" />
        <asp:Label ID="listingname2" runat="server" style="z-index: 1; left: 261px; top: 377px; position: absolute; right: 685px;"></asp:Label>
        <asp:Label ID="listingprice3" runat="server" style="z-index: 1; left: 395px; top: 406px; position: absolute"></asp:Label>
        <asp:Image ID="listingimage7" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 395px; top: 478px; position: absolute; height: 90px; width: 103px" />
        <asp:Button ID="listingbutton4" runat="server" style="z-index: 1; left: 515px; top: 436px; position: absolute" Text="View" />
        <asp:Label ID="listingname3" runat="server" style="z-index: 1; left: 393px; top: 372px; position: absolute"></asp:Label>
        <asp:Label ID="listingname6" runat="server" style="z-index: 1; left: 258px; top: 580px; position: absolute; height: 19px;"></asp:Label>
        <asp:Image ID="listingimage8" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 523px; top: 478px; position: absolute; height: 90px; width: 103px" />
        <asp:Button ID="listingbutton3" runat="server" style="z-index: 1; left: 398px; top: 435px; position: absolute" Text="View" />
        <asp:Label ID="listingname8" runat="server" style="z-index: 1; left: 528px; top: 574px; position: absolute"></asp:Label>
        <asp:Label ID="listingprice8" runat="server" style="z-index: 1; left: 533px; top: 600px; position: absolute"></asp:Label>
        <asp:Image ID="listingimage1" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 119px; top: 272px; position: absolute; height: 90px; width: 103px" />
        <asp:Button ID="listingbutton2" runat="server" style="z-index: 1; left: 256px; top: 436px; position: absolute" Text="View" />
        <asp:Label ID="listingprice5" runat="server" style="z-index: 1; left: 118px; top: 610px; position: absolute; right: 830px;"></asp:Label>
        <asp:Image ID="listingimage6" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 257px; top: 476px; position: absolute; height: 90px; width: 103px; right: 669px;" />
        <asp:Button ID="listingbutton1" runat="server" style="z-index: 1; left: 121px; top: 436px; position: absolute" Text="View" />
        <asp:Label ID="listingname5" runat="server" style="z-index: 1; left: 120px; top: 577px; position: absolute"></asp:Label>
        <asp:Label ID="listingprice7" runat="server" style="z-index: 1; left: 398px; top: 602px; position: absolute"></asp:Label>
        <asp:Image ID="listingimage3" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 384px; top: 270px; position: absolute; height: 90px; width: 103px" />
        <asp:Button ID="listingbutton8" runat="server" style="z-index: 1; left: 525px; top: 637px; position: absolute" Text="View" />
        <asp:Label ID="listingname7" runat="server" style="z-index: 1; left: 396px; top: 578px; position: absolute"></asp:Label>
        <asp:Label ID="listingprice2" runat="server" style="z-index: 1; left: 261px; top: 403px; position: absolute"></asp:Label>
        <asp:Image ID="listingimage4" runat="server" ImageUrl=" http://placekitten.com/200/300" style="z-index: 1; left: 513px; top: 269px; position: absolute; height: 90px; width: 103px" />
        <asp:Button ID="listingbutton7" runat="server" style="z-index: 1; left: 396px; top: 636px; position: absolute" Text="View" />
        <asp:Label ID="listingname4" runat="server" style="z-index: 1; left: 512px; top: 372px; position: absolute"></asp:Label>
        <asp:Label ID="listingprice4" runat="server" style="z-index: 1; left: 511px; top: 405px; position: absolute"></asp:Label>
        <asp:Label ID="listingprice6" runat="server" style="z-index: 1; left: 257px; top: 605px; position: absolute"></asp:Label>
    </form>
</body>
</html>
