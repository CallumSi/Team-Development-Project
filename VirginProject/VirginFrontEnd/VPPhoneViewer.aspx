<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPPhoneViewer.aspx.cs" Inherits="VirginFrontEnd.VPPhoneViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCapacity" runat="server" style="z-index: 1; left: 319px; top: 144px; position: absolute" Text="Capacity "></asp:Label>
        <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 54px; top: 120px; position: absolute; height: 62px; width: 134px" Text="Home" OnClick="btnHome_Click" />
        <asp:Button runat="server" style="z-index: 1; left: 53px; top: 250px; position: absolute; height: 66px; width: 132px" Text="View Cart" ID="btnViewCart" OnClick="btnViewCart_Click" />
        <asp:Button ID="btnEditAccount" runat="server" OnClick="btnEditAccount_Click" style="z-index: 1; left: 52px; top: 376px; position: absolute; height: 70px; width: 130px" Text="Edit Account" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 54px; top: 577px; position: absolute; height: 62px; width: 127px" Text="Log Out" />
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 320px; top: 224px; position: absolute" Text="Colour"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 320px; top: 298px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblMake" runat="server" style="z-index: 1; left: 319px; top: 378px; position: absolute" Text="Make"></asp:Label>
        <asp:Label ID="lblModel" runat="server" style="z-index: 1; left: 315px; top: 453px; position: absolute" Text="Model"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 317px; top: 535px; position: absolute" Text="Price"></asp:Label>
        <asp:Label ID="lblStockStatus" runat="server" style="z-index: 1; left: 310px; top: 617px; position: absolute" Text="Stock Status"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 315px; top: 697px; position: absolute; right: 939px" Text="Quantity"></asp:Label>
        <asp:Label ID="lblPhoneCapacity" runat="server" style="z-index: 1; left: 406px; top: 143px; position: absolute" Text="[lblCapacity]"></asp:Label>
        <asp:Label ID="lblPhoneColour" runat="server" style="z-index: 1; left: 406px; top: 225px; position: absolute" Text="[lblColour]"></asp:Label>
        <asp:Label ID="lblPhoneDescription" runat="server" style="z-index: 1; left: 421px; top: 299px; position: absolute" Text="[lblDescription]"></asp:Label>
        <asp:Label ID="lblPhoneMake" runat="server" style="z-index: 1; left: 407px; top: 378px; position: absolute" Text="[lblMake]"></asp:Label>
        <asp:Label ID="lblPhoneModel" runat="server" style="z-index: 1; left: 407px; top: 453px; position: absolute" Text="[lblModel]"></asp:Label>
        <asp:Label ID="lblPhonePrice" runat="server" style="z-index: 1; left: 405px; top: 533px; position: absolute" Text="[lblPrice]"></asp:Label>
        <asp:DropDownList ID="ddlQuantity" runat="server" style="z-index: 1; left: 399px; top: 697px; position: absolute">
        </asp:DropDownList>
        <asp:CheckBox ID="chkStockStatus" runat="server" style="z-index: 1; left: 404px; top: 616px; position: absolute" />
        <asp:Button ID="btnAddToCart" runat="server" OnClick="btnAddToCart_Click" style="z-index: 1; left: 745px; top: 548px; position: absolute" Text="Add To Cart" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 746px; top: 598px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 445px; top: 42px; position: absolute" Text="[lblCustomerFirstName]"></asp:Label>
    </form>
</body>
</html>
