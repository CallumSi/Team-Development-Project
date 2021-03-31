<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVMStaff.aspx.cs" Inherits="VirginFrontEnd.AnVMStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblAnVMStaff" runat="server" Font-Bold="True" ForeColor="#CC0000" style="z-index: 1; left: 371px; top: 83px; position: absolute" Text="VIRGIN MOVIES STAFF"></asp:Label>
        <asp:Label ID="lblVMStaffFirstname" runat="server" BorderStyle="None" Font-Bold="True" style="z-index: 1; left: 215px; top: 153px; position: absolute" Text="STAFF FIRSTNAME: "></asp:Label>
        <asp:Label ID="lblVMStaffLastname" runat="server" Font-Bold="True" style="z-index: 1; left: 215px; top: 203px; position: absolute" Text="STAFF LASTNAME: "></asp:Label>
        <asp:Label ID="lblVMStaffEmail" runat="server" Font-Bold="True" style="z-index: 1; left: 215px; top: 253px; position: absolute; width: 187px" Text="STAFF EMAIL: "></asp:Label>
        <asp:Label ID="lblVMStaffPassword" runat="server" Font-Bold="True" style="z-index: 1; left: 215px; top: 303px; position: absolute" Text="STAFF PASSWORD: "></asp:Label>
        <asp:Label ID="lblVMStaffPosition" runat="server" Font-Bold="True" style="z-index: 1; left: 215px; top: 353px; position: absolute" Text="STAFF POSITION: "></asp:Label>
        <asp:TextBox ID="txtVMStaffFirstname" runat="server" Font-Bold="True" style="z-index: 1; left: 383px; top: 153px; position: absolute; width: 274px"></asp:TextBox>
        <asp:TextBox ID="txtVMStaffLastname" runat="server" Font-Bold="True" style="z-index: 1; left: 383px; top: 208px; position: absolute; width: 274px"></asp:TextBox>
        <asp:TextBox ID="txtVMStaffEmail" runat="server" Font-Bold="True" style="z-index: 1; left: 383px; top: 258px; position: absolute; width: 274px"></asp:TextBox>
        <asp:TextBox ID="txtVMStaffPassword" runat="server" Font-Bold="True" style="z-index: 1; left: 383px; top: 303px; position: absolute; width: 274px"></asp:TextBox>
        <asp:TextBox ID="txtVMStaffPosition" runat="server" Font-Bold="True" style="z-index: 1; left: 383px; top: 351px; position: absolute; width: 274px"></asp:TextBox>
        <asp:Button ID="btnOkay" runat="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 383px; top: 420px; position: absolute; width: 136px; right: 848px" Text="OKAY" OnClick="btnOkay_Click" />
        <asp:Button ID="btnCancel" runat="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 533px; top: 419px; position: absolute; width: 136px" Text="CANCEL" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" style="z-index: 1; left: 217px; top: 486px; position: absolute; width: 517px"></asp:Label>
    </form>
</body>
</html>

