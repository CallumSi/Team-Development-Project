<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VirginForgotPassword.aspx.cs" Inherits="VirginFrontEnd.VirginForgotPassword" %>

<!DOCTYPE html>
<%--HEAD SECTION--%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VirginForgotPassword</title>
    <link href="VirginTeamLogin.css" rel="stylesheet" type="text/css" />
</head>
<%--BODY SECTION--%>
<body>
    <form id="form1" runat="server">
        <%--HEADER SECTION--%>
        <header>
            <h2>Virgin Media </h2>
            <%--ARTICLE SECTION--%>
            <article>
                <h4>FORGOT PASSWORD </h4>
                <%--LABEL: USERNAME--%>
                <asp:Label ID="lblUserName" runat="server" CssClass="lblUserName" Text="USERNAME : "></asp:Label>
                <%--TEXTBOX: USERNAME--%>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="txtUsername"></asp:TextBox>
                <%--LABEL: PASSWORD--%>
                <asp:Label ID="lblPassword" runat="server" CssClass="lblPassword" Text="PASSWORD : "></asp:Label>
                <%--TEXTBOX: PASSWORD--%>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="txtPassword" TextMode="Password"></asp:TextBox>
                <%--LABEL: PASSWORD CONFIRM--%>
                <asp:Label ID="lblPasswordConfirm" runat="server" CssClass="lblPasswordConfirm" Text="PASSWORD CONFIRM : "></asp:Label>
                <%--TEXTBOX: PASSWORD CONFIRM--%>
                <asp:TextBox ID="txtPasswordConfirm" runat="server" CssClass="txtPasswordConfirm" TextMode="Password"></asp:TextBox>
                <%--LABEL: SECRET--%>
                <asp:Label ID="lblSecret" runat="server" CssClass="lblSecret" Text="SECRET : "></asp:Label>
                <%--TEXTBOX: SECRET--%>
                <asp:TextBox ID="txtSecret" runat="server" CssClass="txtSecret"></asp:TextBox>
                <%--LABEL: ERROR--%>
                <asp:Label ID="lblErrorMessage" runat="server" CssClass="lblErrorMessage"></asp:Label>
                <%--BUTTON: SUBMIT--%>
                <asp:Button ID="btnSubmit" CssClass="btnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit" />
                <%--BUTTON: CLOSE--%>
                <asp:Button ID="btnClose" runat="server" CssClass="btnClose" Text="X" OnClick="btnClose_Click" />
            </article>
        </header>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
