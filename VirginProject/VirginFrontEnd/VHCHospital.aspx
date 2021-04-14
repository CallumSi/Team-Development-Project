<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCHospital.aspx.cs" Inherits="VirginFrontEnd.VHCHospital" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare</title>
    <link href="VHCHospital.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            left: 0%;
            top: 0%;
            bottom: 696px;
        }
    </style>
</head>

<%--BODY SECTION--%>
<body>
    <form id="form1" runat="server">
        <%--HEADER SECTION--%>
        <header>
            <h2>Virgin Healthcare: Hospital</h2>
        </header>
        <%--ARTICLE SECTION--%>
        <article class="auto-style1">
            <h3>WELCOME TO THE HOSPITAL SECTION</h3>
            <%--OPTION MESSAGE--%>
            <p id="OptionMessage">Please select one of the options on the left hand side </p>

            <%--VHC LOGO--%>
            <img src="VHCImages/VHCLogo.png" alt="VHCLogo">
        </article>
        <%--NAVIGATION SECTION--%>
        <nav>
            <%--BUTTON: HOME--%>
            <asp:Button ID="Home_Button" runat="server" CssClass="Home" Text="HOME" OnClick="Home_Button_Click" />
            <%--BUTTON: ADD HOSPITAL--%>
            <asp:Button ID="Hospital_AddButton" runat="server" CssClass="AddHospital" Text="Add Hospital" OnClick="Button1_Click" />
            <%--BUTTON: EDIT HOSPITAL--%>
            <asp:Button ID="btnEditHospital" runat="server" CssClass="EditHospital" Text="Edit Hospital" OnClick="btnEditHospital_Click" />
            <%--BUTTON: DELETE HOSPITAL--%>
            <asp:Button ID="btnDeleteHospital" runat="server" CssClass="DeleteHospital" Text="Delete Hospital" />
            <%--BUTTON: LIST HOSPITAL--%>
            <asp:Button ID="btnHospitalList" runat="server" CssClass="ListHospitals" Text="List Hospitals" OnClick="btnHospitalList_Click"/>
        </nav>
        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>
    </form>
</body>
</html>
