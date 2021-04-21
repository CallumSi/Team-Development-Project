<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAdminLogIn.aspx.cs" Inherits="VirginFrontEnd.ForumAdminLogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdminLogIn</title>
    <link href="VirginTeamLogin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>VIRGIN SERVICES</h2>
        </header>

        <article>
            <h4>ADMIN LOG IN</h4>

            <asp:Label ID="lblUserName" CssClass="lblUserName" runat="server" Style="z-index: 1;" Text="User Name : "></asp:Label>
            <asp:TextBox ID="txtUsername" CssClass="txtUsername" runat="server" Style="z-index: 1;"></asp:TextBox>
            <asp:Label ID="lblPassword" CssClass="lblPassword" runat="server" Style="z-index: 1;" Text="Password : "></asp:Label>
            <asp:TextBox ID="txtPassword" CssClass="txtPassword" runat="server" Style="z-index: 1;" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogIn" CssClass="btnLogIn" runat="server" Style="z-index: 1;" Text="Log In" OnClick="btnLogIn_Click" />
            <asp:Button ID="btnSignUp" CssClass="btnSignUp2" runat="server" Style="z-index: 1;" Text="Sign Up" OnClick="btnSignUp_Click1" />
            <asp:Button ID="btnForgotPassword" CssClass="btnForgotPassword" runat="server" Style="z-index: 1;" Text="Forgot Password" OnClick="btnForgotPassword_Click" />
            <asp:Label ID="lblError" CssClass="lblErrorMessage" runat="server" Style="z-index: 1;"></asp:Label>
        </article>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
