<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPDeliveryList.aspx.cs" Inherits="VirginFrontEnd.VPDeliveryList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 448px; top: 113px; position: absolute" Text="Title"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 432px; top: 161px; position: absolute" Text="FirstName"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 431px; top: 215px; position: absolute" Text="LastName"></asp:Label>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 433px; top: 275px; position: absolute" Text="House No"></asp:Label>
        <asp:Label ID="lblDeliveryAddress" runat="server" style="z-index: 1; left: 433px; top: 339px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 433px; top: 400px; position: absolute" Text="Postcode"></asp:Label>
        <asp:Label ID="lblDeliveryDate" runat="server" style="z-index: 1; left: 429px; top: 463px; position: absolute" Text="Delivery Date"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 549px; top: 111px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 550px; top: 158px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 551px; top: 213px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 555px; top: 272px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 561px; top: 340px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 564px; top: 400px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDeliveryDate" runat="server" style="z-index: 1; left: 564px; top: 461px; position: absolute; bottom: 226px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 434px; top: 563px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnContinueToPayment" runat="server" OnClick="btnContinueToPayment_Click" style="z-index: 1; left: 435px; top: 525px; position: absolute; bottom: 158px" Text="Continue To Payment" />
        <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 39px; top: 103px; position: absolute; height: 51px; width: 132px;" Text="Home" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 639px; top: 525px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnLogOut" runat="server" style="z-index: 1; left: 44px; top: 577px; position: absolute; height: 55px; width: 135px" Text="Log Out" />
        <asp:Button ID="btnViewCart" runat="server" style="z-index: 1; left: 44px; top: 198px; position: absolute; height: 60px; width: 128px" Text="View Cart" />
    </form>
</body>
</html>
