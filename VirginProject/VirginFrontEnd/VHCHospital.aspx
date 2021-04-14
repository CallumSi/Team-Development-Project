<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCHospital.aspx.cs" Inherits="VirginFrontEnd.VHCHospital" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare</title>
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
            <asp:Button ID="btnHome" runat="server" CssClass="Home" Text="HOME" OnClick="btnHome_Click" />
            <%--BUTTON: ADD HOSPITAL--%>
            <asp:Button ID="btnAddHospital" runat="server" CssClass="AddHospital" Text="Add Hospital" OnClick="btnAddHospital_Click" />
            <%--BUTTON: EDIT HOSPITAL--%>
            <asp:Button ID="btnEditHospital" runat="server" CssClass="EditHospital" Text="Edit Hospital" OnClick="btnEditHospital_Click" />
            <%--BUTTON: DELETE HOSPITAL--%>
            <asp:Button ID="btnDeleteHospital" runat="server" CssClass="DeleteHospital" Text="Delete Hospital" OnClick="btnDeleteHospital_Click" />
            <%--BUTTON: LIST HOSPITAL--%>
            <asp:Button ID="btnListHospital" runat="server" CssClass="ListHospitals" Text="List Hospitals" OnClick="btnListHospital_Click" />
        </nav>

        <%--ARTICLE SECTION--%>
        <article>
            <h3>WELCOME TO THE HOSPITAL SECTION</h3>
            <%--OPTION MESSAGE--%>
            <p id="OptionMessage">Please select one of the options on the left hand side </p>
            <%--VHC LOGO--%>
            <img src="VHCImages/VHCLogo.png" alt="VHCLogo">
        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>
</html>
