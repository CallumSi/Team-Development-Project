<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VirginLogIn.aspx.cs" Inherits="VirginFrontEnd.VirginLogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Virgin Log In </title>
    <link href="VirginTeamLogin.css" rel="stylesheet" type="text/css" />
</head>

<body>
    <form id="form1" runat="server">

        <header>
            <h2>VIRGIN SERVICES </h2>
        </header>

        <article>
           <h4>WELCOME </h4>
            <%--LABEL: USERNAME--%>
            <asp:Label ID="lblUserName" runat="server" CssClass="lblUserName" Text="USERNAME : "></asp:Label>
            <%--TEXTBOX: USERNAME--%>
            <asp:TextBox ID="txtUsername" runat="server" CssClass="txtUsername"></asp:TextBox>
            <%--LABEL: PASSWORD--%>
            <asp:Label ID="lblPassword" runat="server" CssClass="lblPassword" Text="PASSWORD : "></asp:Label>
            <%--TEXTBOX: PASSWORD--%>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="txtPassword" TextMode="Password"></asp:TextBox>
             <%--BUTTON: LOG IN--%>
            <asp:Button ID="btnLogIn" runat="server" CssClass="btnLogIn" Text="LOG IN" OnClick="btnLogIn_Click" />
             <%--BUTTON: SIGN UP--%>
            <asp:Button ID="btnSignUp2" runat="server" CssClass="btnSignUp2" Text="SIGN UP" OnClick="btnSignUp_Click1" />
             <%--BUTTON: FORGOT PASSWORD--%>
            <asp:Button ID="btnForgotPassword" runat="server" CssClass="btnForgotPassword" Text="FORGOT PASSWORD" OnClick="btnForgotPassword_Click" />
             <%--LABEL: ERROR--%>
            <asp:Label ID="lblErrorMessage" runat="server" CssClass="lblErrorMessage"></asp:Label>
            <%--BUTTON: FORUM ADMIN--%>
            <asp:Button ID="btnForumAdmin" runat="server"  CssClass="btnForumAdmin" OnClick="btnForumAdmin_Click" Text="ACCESS ADMIN" />
             <%--LABEL: OTHER--%>
            <asp:Label ID="lblOther" runat="server" CssClass="lblOther" Text="ADMINS"></asp:Label>

        </article>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>