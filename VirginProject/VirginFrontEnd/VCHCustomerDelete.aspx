<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHCustomerDelete.aspx.cs" Inherits="VirginFrontEnd.VCHCustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Delete Customer Confirmation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteCustomer" runat="server" style="z-index: 1; left: 560px; top: 320px; position: absolute; width: 414px; margin-bottom: 10px;" Text="Confirm deleting the selected Customer"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" Height="40px" Width="75px" OnClick="btnDelete_Click" style="z-index: 1; left: 630px; top: 380px; position: absolute" Text="Delete" />
        <asp:Button ID="btnCancel" runat="server" Height="40px" Width="75px" OnClick="btnCancel_Click" style="z-index: 1; left: 750px; top: 380px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
