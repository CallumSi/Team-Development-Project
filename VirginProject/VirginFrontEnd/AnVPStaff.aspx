<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVPStaff.aspx.cs" Inherits="VirginFrontEnd.AnVPStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffFirstName" runat="server" style="z-index: 1; left: 31px; top: 73px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblStaffLastName" runat="server" style="z-index: 1; left: 33px; top: 118px; position: absolute" Text="LastName"></asp:Label>
        <asp:Label ID="lblStaffStreet" runat="server" style="z-index: 1; left: 32px; top: 165px; position: absolute" Text="Street"></asp:Label>
        <asp:Label ID="lblStaffAddres" runat="server" style="z-index: 1; left: 32px; top: 208px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblStaffPostcode" runat="server" style="z-index: 1; left: 40px; top: 260px; position: absolute" Text="Postcode"></asp:Label>
        <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 43px; top: 311px; position: absolute; bottom: 327px" Text="Email"></asp:Label>
        <asp:Label ID="lblStaffTelephone" runat="server" style="z-index: 1; left: 41px; top: 362px; position: absolute" Text="Telephone"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 44px; top: 420px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 114px; top: 445px; position: absolute; width: 42px;" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 174px; top: 444px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:TextBox ID="txtStaffFirstName" runat="server" style="z-index: 1; left: 111px; top: 72px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffLastName" runat="server" style="z-index: 1; left: 112px; top: 120px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffStreet" runat="server" style="z-index: 1; left: 115px; top: 165px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 114px; top: 211px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffPostcode" runat="server" style="z-index: 1; left: 114px; top: 257px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 115px; top: 310px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffTelephone" runat="server" style="z-index: 1; left: 119px; top: 359px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
