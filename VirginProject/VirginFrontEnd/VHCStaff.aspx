<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCStaff.aspx.cs" Inherits="VirginFrontEnd.VHCHospital" %>

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
            <h2>Virgin Healthcare System</h2>
        </header>

        <%--ARTICLE SECTION--%>
        <article>
            <h3>WELCOME TO VIRGIN HEALTHCARE</h3>
            <%--BUTTON: LOG OUT--%>
            <asp:Button ID="btnLogout" runat="server" CssClass="btnLogout" Text="☜ Log Out" OnClick="btnLogout_Click" />

            <%--BUTTON: ADD HOSPITAL--%>
            <asp:Button ID="btnAddHospital" runat="server" CssClass="AddHospital" Text="Add Hospital" OnClick="btnAddHospital_Click"/>

            <%--BUTTON: LIST HOSPITAL--%>
            <asp:Button ID="btnListHospital" runat="server" CssClass="ListHospitals" Text="List Hospitals" OnClick="btnListHospital_Click" />
            
            <%--BUTTON: ADD PATIENT--%>
            <asp:Button ID="btnAddPatient" runat="server" CssClass="btnAddPatient" Text="Add Patient" OnClick="btnAddPatient_Click" />

            <%--BUTTON: LIST PATIENTS--%>
            <asp:Button ID="btnListPatients" runat="server" CssClass="btnListPatients" Text="List Patients" OnClick="btnListPatients_Click" />
        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>
</html>
