<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VirginSignUpSuccess.aspx.cs" Inherits="VirginFrontEnd.VirginSignUpSuccess" %>

<!DOCTYPE html>
<%-- HEAD --%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Sign Up Success</title>
    <link href="VirginTeamLogin.css" rel="stylesheet" type="text/css" />
</head>
<%-- BODY --%>
<body>
    <form id="form1" runat="server">

        <%-- HEADER --%>
        <header>
            <h2>VIRGIN SERVICES </h2>
        </header>

        <%-- ARTICLE --%>
        <article>
            <h5>CONGRATULATIONS!
                <br />
                YOU HAVE BEEN SUCCESSFULLY SIGNED UP TO VIRGIN SERVICES.<br />
                <br />
                Please press to continue
            </h5>
            <%-- BUTTON CONTINUE --%>
            <asp:Button ID="btnContinue" CssClass="btnContinue" runat="server" Text=" ☞ " OnClick="btnHome_Click" />
        </article>

        <%-- FOOTER --%>
        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
