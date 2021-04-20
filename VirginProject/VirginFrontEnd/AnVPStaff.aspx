<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVPStaff.aspx.cs" Inherits="VirginFrontEnd.AnVPStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffFirstName" runat="server" style="z-index: 1; left: 480px; top: 125px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblStaffLastName" runat="server" style="z-index: 1; left: 480px; top: 193px; position: absolute" Text="LastName"></asp:Label>
        <asp:Label ID="lblStaffStreet" runat="server" style="z-index: 1; left: 482px; top: 262px; position: absolute" Text="Street"></asp:Label>
        <asp:Label ID="lblStaffAddres" runat="server" style="z-index: 1; left: 483px; top: 333px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblStaffPostcode" runat="server" style="z-index: 1; left: 486px; top: 398px; position: absolute" Text="Postcode"></asp:Label>
        <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 488px; top: 458px; position: absolute; bottom: 180px" Text="Email"></asp:Label>
        <asp:Label ID="lblStaffTelephone" runat="server" style="z-index: 1; left: 486px; top: 521px; position: absolute" Text="Telephone"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 481px; top: 568px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 620px; top: 566px; position: absolute; width: 42px;" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 675px; top: 566px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:TextBox ID="txtStaffFirstName" runat="server" style="z-index: 1; left: 647px; top: 125px; position: absolute; width: 128px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffLastName" runat="server" style="z-index: 1; left: 647px; top: 192px; position: absolute; width: 131px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffStreet" runat="server" style="z-index: 1; left: 644px; top: 261px; position: absolute; width: 134px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 645px; top: 329px; position: absolute; width: 133px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffPostcode" runat="server" style="z-index: 1; left: 643px; top: 394px; position: absolute; width: 134px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 643px; top: 453px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffTelephone" runat="server" style="z-index: 1; left: 641px; top: 518px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 34px; top: 118px; position: absolute; height: 59px; width: 143px" Text="Home" />
        <asp:Button ID="btnViewStaffList" runat="server" OnClick="btnViewStaffList_Click" style="z-index: 1; left: 36px; top: 214px; position: absolute; height: 59px; width: 142px; bottom: 384px" Text="View Staff List" />
        <asp:Button ID="btnViewCustomerList" runat="server" OnClick="btnViewCustomerList_Click" style="z-index: 1; left: 37px; top: 316px; position: absolute; height: 57px; width: 140px" Text="View Customer List" />
        <asp:Button ID="btnViewPhoneList" runat="server" OnClick="btnViewPhoneList_Click" style="z-index: 1; left: 37px; top: 415px; position: absolute; height: 57px; width: 141px" Text="View Phone List" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 39px; top: 564px; position: absolute; height: 59px; width: 137px" Text="Log Out" />
    </form>
</body>
</html>
