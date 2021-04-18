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
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 41px; top: 94px; position: absolute" Text="Title"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 41px; top: 161px; position: absolute" Text="FirstName"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 41px; top: 226px; position: absolute" Text="LastName"></asp:Label>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 40px; top: 294px; position: absolute" Text="House No"></asp:Label>
        <asp:Label ID="lblDeliveryAddress" runat="server" style="z-index: 1; left: 40px; top: 359px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 42px; top: 423px; position: absolute" Text="Postcode"></asp:Label>
        <asp:Label ID="lblDeliveryDate" runat="server" style="z-index: 1; left: 41px; top: 487px; position: absolute" Text="Delivery Date"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 85px; top: 91px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 117px; top: 161px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 117px; top: 226px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 117px; top: 294px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 119px; top: 359px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 118px; top: 423px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDeliveryDate" runat="server" style="z-index: 1; left: 137px; top: 487px; position: absolute; bottom: 148px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 45px; top: 551px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnContinueToPayment" runat="server" OnClick="btnContinueToPayment_Click" style="z-index: 1; left: 153px; top: 548px; position: absolute; bottom: 83px" Text="Continue To Payment" />
        <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 23px; top: 48px; position: absolute" Text="Home" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 359px; top: 548px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
