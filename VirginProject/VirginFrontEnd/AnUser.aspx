﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnUser.aspx.cs" Inherits="VirginFrontEnd.AnUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 182px; top: 112px; position: absolute; height: 19px; width: 47px" Text="SignUp"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 182px; top: 156px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 183px; top: 198px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 182px; top: 261px; position: absolute" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 246px; top: 258px; position: absolute" Text="Cancel" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 98px; top: 153px; position: absolute" Text="Username"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 111px; top: 201px; position: absolute" Text="Password"></asp:Label>
    </form>
</body>
</html>
