<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHStaffList.aspx.cs" Inherits="VirginFrontEnd.VCHStaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="VirginProject2.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaff" runat="server" style="z-index: 1; left: 15px; top: 23px; position: absolute" Text="Staff"></asp:Label>
        </div>
        <asp:Button ID="btnApply" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 15px; top: 490px; position: absolute" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" Height="40px" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 35px; top: 490px; position: absolute; left: 114px;" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" Height="40px" Width="75px" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 540px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 115px; top: 540px; position: absolute; right: 1272px;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 215px; top: 540px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:TextBox ID="txtBxSearch" runat="server" Height="30px" style="z-index: 1; left: 15px; top: 440px; position: absolute"></asp:TextBox>
        <p>
        <asp:ListBox ID="lstStaff" runat="server" Height="300px" Width="800px" style="z-index: 1; left: 15px; top: 60px; position: absolute"></asp:ListBox>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 15px; top: 365px; position: absolute" Text="Please Enter a Staff Username"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 405px; position: absolute" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
