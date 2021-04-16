<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnPhone.aspx.cs" Inherits="VirginFrontEnd.AnPhone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCapacity" runat="server" style="z-index: 1; left: 30px; top: 67px; position: absolute" Text="Capacity"></asp:Label>
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 32px; top: 122px; position: absolute" Text="Colour"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 31px; top: 173px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblMake" runat="server" style="z-index: 1; left: 33px; top: 217px; position: absolute" Text="Make"></asp:Label>
        <asp:Label ID="lblModel" runat="server" style="z-index: 1; left: 33px; top: 265px; position: absolute" Text="Model"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 31px; top: 314px; position: absolute" Text="Price"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 31px; top: 412px; position: absolute" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtCapacity" runat="server" style="z-index: 1; left: 101px; top: 68px; position: absolute; width: 139px"></asp:TextBox>
        <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; left: 101px; top: 122px; position: absolute; width: 140px"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 116px; top: 172px; position: absolute; width: 150px"></asp:TextBox>
        <asp:TextBox ID="txtMake" runat="server" style="z-index: 1; left: 88px; top: 216px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtModel" runat="server" style="z-index: 1; left: 94px; top: 264px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 79px; top: 313px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlQuantity" runat="server" style="z-index: 1; left: 101px; top: 412px; position: absolute">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
            <asp:ListItem Value="4"></asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 35px; top: 470px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 498px; position: absolute; left: 167px; width: 56px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 96px; top: 500px; position: absolute; width: 51px" Text="OK" OnClick="btnOK_Click" />
        <asp:Label ID="lblStockStatus" runat="server" style="z-index: 1; left: 31px; top: 362px; position: absolute" Text="StockStatus"></asp:Label>
        <asp:CheckBox ID="chkStockStatus" runat="server" style="z-index: 1; left: 115px; top: 361px; position: absolute; width: 120px" />
    </form>
</body>
</html>
