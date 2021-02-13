<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnMarketplaceUser.aspx.cs" Inherits="VirginFrontEnd.AnMarketplaceUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Marketplace user Details"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 20px; top: 125px; position: absolute" Text="Admin"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 20px; top: 155px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 20px; top: 183px; position: absolute" Text="Password"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 20px; top: 211px; position: absolute" Text="Rating"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 21px; top: 98px; position: absolute" Text="UserID"></asp:Label>
        <asp:TextBox ID="txtboxUserID" runat="server" style="z-index: 1; left: 80px; top: 94px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 80px; top: 155px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAdmin" runat="server" style="z-index: 1; left: 92px; top: 183px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 87px; top: 214px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkboxAdmin" runat="server" style="z-index: 1; left: 87px; top: 123px; position: absolute" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 47px; top: 286px; position: absolute" Text="Label"></asp:Label>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 65px; top: 346px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 177px; top: 338px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
