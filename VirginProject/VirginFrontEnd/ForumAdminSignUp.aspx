<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAdminSignUp.aspx.cs" Inherits="VirginFrontEnd.ForumAdminSignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdminSignUp</title>
    <link href="VirginTeamLogin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media </h2>
           
        </header>

        <article>
             <h1>Admin Sign Up</h1>
            <asp:Label ID="lblUserName" CssClass="lblUserName" runat="server" Style="z-index: 1;" Text="User Name"></asp:Label>

            <asp:TextBox ID="txtUsername" CssClass="txtUsername" runat="server" Style="z-index: 1;"></asp:TextBox>

            <asp:Label ID="lblPassword"  CssClass="lblPassword" runat="server" Style="z-index: 1;" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" CssClass="txtPassword" runat="server" Style="z-index: 1;" TextMode="Password"></asp:TextBox>

            <asp:Label ID="lblPasswordConfirm" CssClass="lblPasswordConfirm" runat="server" Style="z-index: 1;" Text="Password Confirm"></asp:Label>
            <asp:TextBox ID="txtPasswordConfirm" CssClass="txtPasswordConfirm" runat="server" Style="z-index: 1;" TextMode="Password"></asp:TextBox>

            <asp:Label ID="lblSecret" runat="server"  CssClass="lblSecret"  Style="z-index: 1;" Text="Secret"></asp:Label>
            <asp:TextBox ID="txtSecret" runat="server"  CssClass="txtSecret" Style="z-index: 1"></asp:TextBox>

            <asp:Label ID="lblError" runat="server"  CssClass="lblErrorMessage" Style="z-index: 1;"></asp:Label>

            <asp:Button ID="btnSignUp" CssClass="btnSignUp" runat="server" OnClick="btnSignUp_Click" Style="z-index: 1;" Text="Sign Up" Height="46px" />

        </article>

        <nav>
            Navigation links here
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

    </form>
</body>
</html>
