<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCHospitalDelete.aspx.cs" Inherits="VirginFrontEnd.VHCHospitalDelete" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - Delete Section</title>
    <link href="VHCHospital.css" rel="stylesheet" type="text/css" />
</head>

<%--BODY SECTION--%>
<body>
    <form id="form1" runat="server">
        <%--HEADER SECTION--%>
        <header>
            <h2>Virgin Healthcare: Hospital</h2>
        </header>

        <%--NAVIGATION SECTION--%>
        <nav>
            <%--BUTTON: HOME--%>
            <asp:Button ID="Home_Button" runat="server" CssClass="Home" Text="HOME" OnClick="Home_Button_Click" />
        </nav>

        <%--ARTICLE SECTION--%>
        <article>
            <h4>DELETE HOSPITAL SECTION </h4>
            <%--BUTTON: YES--%>
            <asp:Button ID="btnYes" runat="server" CssClass="btnYes" Text="YES" OnClick="btnYes_Click" />
            <%--BUTTON: NO--%>
            <asp:Button ID="btnNo" runat="server" CssClass="btnNo" Text="NO" OnClick="btnNo_Click" />
            <%--LABEL: DELETE CONFIRM--%>
            <asp:Label ID="lblDeleteConfirm" runat="server" CssClass="lblDeleteErrorMessage" Text=" ⚠️ ARE YOU SURE YOU WANT TO DELETE THIS RECORD?"></asp:Label>
        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>
</html>
