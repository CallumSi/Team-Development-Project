<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHCarDelete.aspx.cs" Inherits="VirginFrontEnd.VCHCarDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Delete Car Confirmation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblDeleteCar" runat="server" style="z-index: 1; left: 560px; top: 325px; position: absolute; width: 335px; margin-bottom: 10px;" Text="Confirm deleting the selected Car"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" Height="40px" Width="75px" OnClick="btnDelete_Click" style="z-index: 1; left: 630px; top: 380px; position: absolute" Text="Delete" />
        <asp:Button ID="btnCancel" runat="server" Height="40px" Width="75px" OnClick="btnCancel_Click" style="z-index: 1; left: 750px; top: 380px; position: absolute" Text="Cancel" />
        </div>
    </form>
</body>
</html>
