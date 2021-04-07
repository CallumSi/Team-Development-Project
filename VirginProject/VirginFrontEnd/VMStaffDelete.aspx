<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMStaffDelete.aspx.cs" Inherits="VirginFrontEnd.VMStaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteConfirmation" runat="server" style="z-index: 1; left: 172px; top: 58px; position: absolute; width: 515px; text-align: center;" Text="Are you sure you want to delete this staff?" BorderStyle="None" Font-Bold="True" ForeColor="Red"></asp:Label>
        <asp:Button ID="btnYes" runat="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 271px; top: 137px; position: absolute; width: 111px" Text="YES" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 471px; top: 137px; position: absolute; width: 111px" Text="NO" OnClick="btnNo_Click" />
    </form>
</body>
</html>
