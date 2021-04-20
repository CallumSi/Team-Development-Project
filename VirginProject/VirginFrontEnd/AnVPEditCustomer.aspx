<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVPEditCustomer.aspx.cs" Inherits="VirginFrontEnd.AnVPEditCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 59px; top: 125px; position: absolute; height: 59px; width: 145px" Text="Home"/>
        <asp:Button ID="btnViewCart" runat="server" OnClick="btnViewCart_Click" style="z-index: 1; left: 57px; top: 234px; position: absolute; height: 62px; width: 146px" Text="View Cart" />
        <asp:Button ID="btnEditAccount" runat="server" OnClick="btnEditAccount_Click" style="z-index: 1; left: 59px; top: 354px; position: absolute; height: 64px; width: 144px" Text="Edit Account" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 59px; top: 478px; position: absolute; height: 71px; width: 146px" Text="Log Out" />
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 337px; top: 143px; position: absolute; height: 25px; width: 84px" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtCustomerFirstName" runat="server" style="z-index: 1; left: 425px; top: 143px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerLastName" runat="server" style="z-index: 1; left: 338px; top: 218px; position: absolute" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtCustomerLastName" runat="server" style="z-index: 1; left: 424px; top: 217px; position: absolute; bottom: 418px;"></asp:TextBox>
        <asp:Label ID="lblCustomerStreet" runat="server" style="z-index: 1; left: 341px; top: 288px; position: absolute" Text="Street"></asp:Label>
        <asp:TextBox ID="txtCustomerStreet" runat="server" style="z-index: 1; left: 420px; top: 285px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 340px; top: 356px; position: absolute" Text="Address"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 419px; top: 353px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerPostcode" runat="server" style="z-index: 1; left: 342px; top: 428px; position: absolute" Text="Postcode"></asp:Label>
        <asp:TextBox ID="txtCustomerPostcode" runat="server" style="z-index: 1; left: 415px; top: 427px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 346px; top: 497px; position: absolute" Text="Email"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 413px; top: 496px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerTelephone" runat="server" style="z-index: 1; left: 346px; top: 569px; position: absolute" Text="Telephone"></asp:Label>
        <asp:TextBox ID="txtCustomerTelephone" runat="server" style="z-index: 1; left: 421px; top: 566px; position: absolute; right: 175px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 328px; top: 616px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 422px; top: 617px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 469px; top: 616px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
