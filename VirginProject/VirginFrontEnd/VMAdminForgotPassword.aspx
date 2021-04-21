<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMAdminForgotPassword.aspx.cs" Inherits="VirginFrontEnd.VMAdminForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movies Admin Forgot Password</title>
    <link href="VMAdmin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Movies Admin Forgot Password</h2>
        </header>
        <asp:Label ID="lblVMAdminFP" runat="server" Text="VIRGIN MOVIES ADMIN FORGOT PASSWORD" CssClass="lblVMASignUp"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" Text="User Name: " CssClass="lblVMAUsername"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="txtVMAUsername"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" Text="New Password: " CssClass="lblVMAPassword"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="txtVMAPassword"></asp:TextBox>
        <asp:Label ID="lblPasswordConfirm" runat="server" Text="New Password Confirm: " CssClass="lblVMAPasswordConfirm"></asp:Label>
        <asp:TextBox ID="txtPasswordConfirm" runat="server" TextMode="Password" CssClass="txtVMAPasswordConfirm"></asp:TextBox>
        <asp:Label ID="lblSecret" runat="server" Text="Secret: " CssClass="lblVMASecret"></asp:Label>
        <asp:TextBox ID="txtSecret" runat="server" CssClass="txtVMASecret" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" CssClass="lblVMAError"></asp:Label>
        <asp:Button ID="btnSignUp" CssClass="btnVMASignUp" runat="server" Text="Confirm" OnClick="btnSignUp_Click" />
        <asp:Button ID="btnBack" CssClass="btnVMABack" runat="server" Text="Back" OnClick="btnBack_Click" />

        <nav>

        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

    </form>
</body>
</html>
