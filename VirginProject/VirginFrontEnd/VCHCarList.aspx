<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHCarList.aspx.cs" Inherits="VirginFrontEnd.VCHCarList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Cars</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:Label ID="lblCars" runat="server" style="z-index: 1; left: 205px; top: 25px; position: absolute" Text="Cars"></asp:Label>
        </div>
        <asp:Button ID="btnApply" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 205px; top: 490px; position: absolute" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" Height="40px" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 500px; top: 490px; position: absolute; left: 300px;" Text="Display All Cars" />
        <asp:Button ID="btnAdd" runat="server" Height="40px" Width="75px" OnClick="btnAdd_Click" style="z-index: 1; left: 205px; top: 540px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 300px; top: 540px; position: absolute; right: 1272px;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 395px; top: 540px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:TextBox ID="txtBxSearch" runat="server" Height="30px" style="z-index: 1; left: 470px; top: 440px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCarBody" runat="server" style="z-index: 1; left: 205px; top: 440px; position: absolute" Text="Filter Cars by Body Type:"></asp:Label>
        <p>
        <asp:ListBox ID="lstCars" runat="server" Height="300px" Width="800px" style="z-index: 1; left: 205px; top: 60px; position: absolute"></asp:ListBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 205px; top: 395px; position: absolute" Text="[lblError]"></asp:Label>
        </form>
</body>
</html>
