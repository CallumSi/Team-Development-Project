<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHCustomerDelete.aspx.cs" Inherits="VirginFrontEnd.VCHCustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteCustomer" runat="server" Text="Confirm deleting the selected Customer"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" Height="40px" Width="75px" OnClick="btnDelete_Click" style="z-index: 1; left: 10px; top: 90px; position: absolute" Text="Delete" />
        <asp:Button ID="btnCancel" runat="server" Height="40px" Width="75px" OnClick="btnCancel_Click" style="z-index: 1; left: 115px; top: 90px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
