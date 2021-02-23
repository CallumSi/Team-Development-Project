<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAnAdmin.aspx.cs" Inherits="VirginFrontEnd.ForumAnAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 311px; top: 171px; position: absolute; height: 28px"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 312px; top: 233px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1; left: 311px; top: 293px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 313px; top: 353px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 191px; top: 176px; position: absolute" Text="FirstName"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 184px; top: 226px; position: absolute; height: 27px" Text="Last Name"></asp:Label>
        <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 156px; top: 291px; position: absolute" Text="Email Address"></asp:Label>
        <asp:Label ID="lblPassowrd" runat="server" style="z-index: 1; left: 191px; top: 354px; position: absolute" Text="Password"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 256px; top: 425px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 366px; top: 425px; position: absolute; margin-top: 0px" Text="Cancel" />
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 316px; top: 121px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 191px; top: 122px; position: absolute" Text="Username"></asp:Label>
    </form>
</body>
</html>
