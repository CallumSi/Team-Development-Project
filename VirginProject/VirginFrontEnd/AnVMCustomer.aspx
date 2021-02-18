<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnVMCustomer.aspx.cs" Inherits="VirginFrontEnd.AnVMCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblAnVMCustomer" runat="server" Font-Bold="True" ForeColor="#CC0000" style="z-index: 1; left: 371px; top: 60px; position: absolute" Text="VIRGIN MOVIES CUSTOMER"></asp:Label>
        <asp:Label ID="lblVMcustomerFirstname" runat="server" BorderStyle="None" Font-Bold="True" style="z-index: 1; left: 215px; top: 153px; position: absolute" Text="CUSTOMER FIRSTNAME: "></asp:Label>
        <asp:Label ID="lblVMcustomerLastname" runat="server" Font-Bold="True" style="z-index: 1; left: 215px; top: 203px; position: absolute" Text="CUSTOMER LASTNAME: "></asp:Label>
        <asp:Label ID="lblVMcustomerEmail" runat="server" Font-Bold="True" style="z-index: 1; left: 215px; top: 253px; position: absolute; width: 187px" Text="CUSTOMER EMAIL: "></asp:Label>
        <asp:Label ID="lblVMcustomerUsername" runat="server" Font-Bold="True" style="z-index: 1; left: 215px; top: 303px; position: absolute" Text="CUSTOMER USERNAME: "></asp:Label>
        <asp:Label ID="lblVMcustomerPassword" runat="server" Font-Bold="True" style="z-index: 1; left: 215px; top: 353px; position: absolute" Text="CUSTOMER PASSWORD: "></asp:Label>
        <asp:TextBox ID="txtVMcustomerFirstname" runat="server" Font-Bold="True" style="z-index: 1; left: 450px; top: 151px; position: absolute; width: 274px"></asp:TextBox>
        <asp:TextBox ID="txtVMcustomerLastname" runat="server" Font-Bold="True" style="z-index: 1; left: 450px; top: 208px; position: absolute; width: 274px"></asp:TextBox>
        <asp:TextBox ID="txtVMcustomerEmail" runat="server" Font-Bold="True" style="z-index: 1; left: 450px; top: 258px; position: absolute; width: 274px"></asp:TextBox>
        <asp:TextBox ID="txtVMcustomerUsername" runat="server" Font-Bold="True" style="z-index: 1; left: 450px; top: 303px; position: absolute; width: 274px"></asp:TextBox>
        <asp:TextBox ID="txtVMcustomerPassword" runat="server" Font-Bold="True" style="z-index: 1; left: 450px; top: 351px; position: absolute; width: 274px"></asp:TextBox>
        <asp:Button ID="btnOkay" runat="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 450px; top: 420px; position: absolute; width: 136px; right: 848px" Text="OKAY" />
        <asp:Button ID="btnCancel" runat="server" BorderStyle="Solid" Font-Bold="True" style="z-index: 1; left: 598px; top: 420px; position: absolute; width: 136px" Text="CANCEL" />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" style="z-index: 1; left: 217px; top: 486px; position: absolute; width: 517px"></asp:Label>
    </form>
</body>
</html>
