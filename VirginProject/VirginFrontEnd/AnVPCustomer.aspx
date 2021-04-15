<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVPCustomer.aspx.cs" Inherits="VirginFrontEnd.AVPCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 39px; top: 69px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblCustomerLastName" runat="server" style="z-index: 1; left: 39px; top: 121px; position: absolute; height: 19px" Text="Last Name"></asp:Label>
        <asp:Label ID="lblCustomerStreet" runat="server" style="z-index: 1; left: 40px; top: 168px; position: absolute" Text="Street"></asp:Label>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 39px; top: 216px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblCustomerPostcode" runat="server" style="z-index: 1; left: 40px; top: 272px; position: absolute" Text="Postcode"></asp:Label>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 45px; top: 327px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="lblCustomerTelephone" runat="server" style="z-index: 1; left: 40px; top: 379px; position: absolute" Text="Telephone"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 42px; top: 436px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 122px; top: 437px; position: absolute; width: 55px" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 195px; top: 437px; position: absolute; width: 62px" Text="Cancel" />
        <asp:TextBox ID="txtCustomerFirstName" runat="server" style="z-index: 1; left: 127px; top: 69px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerLastName" runat="server" style="z-index: 1; left: 127px; top: 121px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerStreet" runat="server" style="z-index: 1; left: 128px; top: 168px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 129px; top: 219px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerPostcode" runat="server" style="z-index: 1; left: 127px; top: 274px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 125px; top: 327px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerTelephone" runat="server" style="z-index: 1; left: 127px; top: 379px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
