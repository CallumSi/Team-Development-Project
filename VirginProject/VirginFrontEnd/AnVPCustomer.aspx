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
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 505px; top: 116px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblCustomerLastName" runat="server" style="z-index: 1; left: 506px; top: 179px; position: absolute; height: 19px" Text="Last Name"></asp:Label>
        <asp:Label ID="lblCustomerStreet" runat="server" style="z-index: 1; left: 506px; top: 244px; position: absolute" Text="Street"></asp:Label>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 506px; top: 315px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblCustomerPostcode" runat="server" style="z-index: 1; left: 507px; top: 391px; position: absolute; bottom: 247px;" Text="Postcode"></asp:Label>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 508px; top: 459px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="lblCustomerTelephone" runat="server" style="z-index: 1; left: 507px; top: 525px; position: absolute" Text="Telephone"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 505px; top: 577px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 590px; top: 576px; position: absolute; width: 55px" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 665px; top: 575px; position: absolute; width: 62px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:TextBox ID="txtCustomerFirstName" runat="server" style="z-index: 1; left: 653px; top: 116px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerLastName" runat="server" style="z-index: 1; left: 658px; top: 177px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerStreet" runat="server" style="z-index: 1; left: 658px; top: 247px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 656px; top: 316px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerPostcode" runat="server" style="z-index: 1; left: 656px; top: 391px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 644px; top: 458px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerTelephone" runat="server" style="z-index: 1; left: 637px; top: 523px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 50px; top: 103px; position: absolute; height: 58px; width: 134px" Text="Home" />
        <asp:Button ID="btnViewStaffList" runat="server" OnClick="btnViewStaffList_Click" style="z-index: 1; left: 48px; top: 201px; position: absolute; height: 58px; width: 136px" Text="View Staff List" />
        <asp:Button ID="btnViewCustomerList" runat="server" OnClick="btnViewCustomerList_Click" style="z-index: 1; left: 49px; top: 301px; position: absolute; height: 57px; width: 134px" Text="View Customer List" />
        <asp:Button ID="btnViewPhoneList" runat="server" OnClick="btnViewPhoneList_Click" style="z-index: 1; left: 48px; top: 403px; position: absolute; height: 57px; width: 138px" Text="View Phone List" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 47px; top: 559px; position: absolute; height: 60px; width: 137px" Text="Log Out" />
    </form>
</body>
</html>
