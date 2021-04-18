<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCStaffDelete.aspx.cs" Inherits="VirginFrontEnd.VHCStaffDelete" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - Delete Section</title>
    <link href="VHCStaff.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            width: 250px;
            height: 70px;
            font-size: 20pt;
            border-radius: 12px;
            transition-duration: 0.5s;
            position: fixed;
            top: 500px;
            left: 555px;
        }
    </style>
</head>

<%--BODY SECTION--%>
<body>
    <form id="form1" runat="server">
        <%--HEADER SECTION--%>
        <header>
            <h2>Virgin Healthcare System</h2>
        </header>

        <%--ARTICLE SECTION--%>
        <article>
            <h4>DELETE STAFF SECTION </h4>
            <%--BUTTON: YES--%>
            <asp:Button ID="btnYes" runat="server" CssClass="auto-style1" Text="YES" OnClick="btnYes_Click"/>
            <%--BUTTON: NO--%>
            <asp:Button ID="btnNo" runat="server" CssClass="btnNo" Text="NO" OnClick="btnNo_Click"/>
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