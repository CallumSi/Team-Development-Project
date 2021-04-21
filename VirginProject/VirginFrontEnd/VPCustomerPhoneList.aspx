<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPCustomerPhoneList.aspx.cs" Inherits="VirginFrontEnd.VPCustomerPhoneList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 82px; top: 130px; position: absolute; height: 68px; width: 119px" Text="Home" />
        <asp:Button ID="btnViewCart" runat="server" OnClick="btnViewCart_Click" style="z-index: 1; left: 84px; top: 244px; position: absolute; height: 69px; width: 119px" Text="View Cart" />
        <asp:Button ID="btnEditAccount" runat="server" OnClick="btnEditAccount_Click" style="z-index: 1; left: 85px; top: 366px; position: absolute; height: 69px; width: 122px; margin-bottom: 5px" Text="Edit Account" />
        <asp:Button ID="btnLogOut" runat="server" style="z-index: 1; left: 86px; top: 552px; position: absolute; height: 59px; width: 125px" Text="Log Out" />
        <asp:ListBox ID="lstPhones" runat="server" style="z-index: 1; left: 315px; top: 128px; position: absolute; height: 330px; width: 616px"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 324px; top: 478px; position: absolute" Text="Filter By Make"></asp:Label>
        <asp:Button ID="btnViewPhone" runat="server" OnClick="btnViewPhone_Click" style="z-index: 1; left: 817px; top: 470px; position: absolute" Text="View Phone" />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 325px; top: 508px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 326px; top: 544px; position: absolute; width: 100px" Text="Display All" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 328px; top: 580px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblCartCount" runat="server" style="z-index: 1; left: 209px; top: 267px; position: absolute" Text="[lblCartCount]"></asp:Label>
        <asp:TextBox ID="txtFilterPhoneMake" runat="server" style="z-index: 1; left: 443px; top: 477px; position: absolute; width: 221px"></asp:TextBox>
    </form>
</body>
</html>
