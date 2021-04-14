<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHCustomerOrStaffSelection.aspx.cs" Inherits="VirginFrontEnd.VCHCustomerOrStaffSelection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" Text="Access Staff End" />
        <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" Text="Access Customer End" />
    </form>
</body>
</html>
