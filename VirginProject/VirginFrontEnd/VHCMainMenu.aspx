<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCMainMenu.aspx.cs" Inherits="VirginFrontEnd.VHCMainMenu" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - Main Menu</title>
    <link href="VHCMainMenu.css" rel="stylesheet" type="text/css" />
</head>

<%--BODY SECTION--%>
<body>
    <form id="form1" runat="server">

        <%--HEADER SECTION--%>
        <header>
            <h2>Virgin Healthcare System</h2>
        </header>

        <%--NAVIGATION SECTION--%>
        <nav>
            <%--BUTTON: PATIENT--%>
            <asp:Button ID="btnPatient" runat="server" CssClass="btnPatient" Text="PATIENT" OnClick="btnPatient_Click" />
            <%--BUTTON: STAFF--%>
            <asp:Button ID="btnStaff" runat="server" CssClass="btnStaff" Text="STAFF" OnClick="btnStaff_Click" />
            <%-- BUTTON LOG OUT --%>
            <asp:Button ID="btnLogOut" CssClass="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />

        </nav>

        <%--ARTICLE SECTION--%>
        <article>
            <h3>WELCOME TO VIRGIN HEALTHCARE</h3>
            <%--VHC LOGO--%>
            <img src="VHCImages/VHCLogo.png" alt="VHCLogo">
            <%--OPTION MESSAGE--%>
            <p id="OptionMessage">Please select one of the options</p>
        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>
</html>
