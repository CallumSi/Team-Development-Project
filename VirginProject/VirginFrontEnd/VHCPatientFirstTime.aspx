<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCPatientFirstTime.aspx.cs" Inherits="VirginFrontEnd.VHCPatientFirstTime" %>

<!DOCTYPE html>
<%-- HEAD --%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Healthcare First Time </title>
    <link href="VHCPatient.css" rel="stylesheet" type="text/css" />
</head>

<%-- BODY --%>
<body>
    <form id="form1" runat="server">
        <%-- HEADER --%>
        <header>
            <h2>Virgin Healthcare System </h2>
        </header>

        <%-- ARTICLE --%>
        <article>
            <h4>WELCOME TO VIRGIN HEALTHCARE </h4>
            <%--BUTTON: CONTINUE--%>
            <asp:Button ID="btnContinueVHC" runat="server" Text="Appointment List" CssClass="btnContinue" OnClick="btnContinueVHC_Click" />

            <%--BUTTON: SIGN UP--%>
            <asp:Button ID="btnVHCNewComer" runat="server" Text="Sign Up" CssClass="btnSignUp" OnClick="btnVHCNewComer_Click" />

            <%--BUTTON: CLOSE--%>
            <asp:Button ID="btnClose" runat="server" Text="X" CssClass="btnClose" OnClick="btnClose_Click" />
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
