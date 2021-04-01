<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHDefault.aspx.cs" Inherits="VirginFrontEnd.VCHDefault" %>

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
    </form>
</body>
</html>
