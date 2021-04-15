<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPDefault.aspx.cs" Inherits="VirginFrontEnd.VPDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" Text="Access Staff" />
        <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" Text="Access Customer" />
        <asp:Button ID="btnPhone" runat="server" OnClick="btnPhone_Click" Text="Access Phone" />
    </form>
</body>
</html>
