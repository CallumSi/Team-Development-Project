<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAnUser.aspx.cs" Inherits="VirginFrontEnd.ForumAnUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 191px; top: 401px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 316px; top: 403px; position: absolute" Text="Cancel" />
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 208px; top: 95px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 209px; top: 154px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 210px; top: 214px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1; left: 207px; top: 278px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 203px; top: 332px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 87px; top: 94px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 89px; top: 150px; position: absolute; margin-top: 0px" Text="Last Name"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 49px; top: 219px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 48px; top: 274px; position: absolute" Text="Email Address"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 95px; top: 331px; position: absolute" Text="Password"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 85px; top: 50px; position: absolute" Text="Username"></asp:Label>
        <asp:Label ID="lblUserError" runat="server" style="z-index: 1; left: 143px; top: 494px; position: absolute" Text="[Error]"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 205px; top: 49px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
