<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPCustomerDelete.aspx.cs" Inherits="VirginFrontEnd.VPCustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteCustomer" runat="server" style="z-index: 1; left: 26px; top: 63px; position: absolute" Text="Are you sure you want to delete this Customer?"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 22px; top: 99px; position: absolute; width: 60px" Text="Delete" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 102px; top: 99px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
