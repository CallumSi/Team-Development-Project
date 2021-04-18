<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMAdminLogin.aspx.cs" Inherits="VirginFrontEnd.VMAdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Movies Admin LogIn</title>
    <link href="VMAdmin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Movies Admin Login </h2>
        </header>
        <asp:Label ID= "lblVMAdminLogIn" runat="server" Text="VIRGIN MOVIES ADMIN LOG IN" CssClass="lblVMAdminLogIn"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" Text="User Name: " CssClass="lblVMAdminUsername"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="txtVMAdminUsername"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" Text="Password: " CssClass="lblVMAdminPassword"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="txtVMAdminPassword"></asp:TextBox>
        <asp:Button ID="btnLogIn" runat="server" Text="Log In" CssClass="btnVMAdminLogIn" OnClick="btnLogIn_Click"/>
        <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" CssClass="btnVMAdminSignUp" OnClick="btnSignUp_Click" />
        <asp:Button ID="btnForgotPassword" runat="server" Text="Forgot Password" CssClass="btnVMAdminForgotPassword" OnClick="btnForgotPassword_Click"/>
        <asp:Label ID="lblError" runat="server" CssClass="lblErrorVMALogin"></asp:Label>

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
