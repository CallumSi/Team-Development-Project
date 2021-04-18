<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCPatientList.aspx.cs" Inherits="VirginFrontEnd.VHCPatientList" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - List </title>
    <link href="VHCPatient.css" rel="stylesheet" type="text/css" />
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
            <h4>LIST & FILTER PATIENT SECTION </h4>
            <%--LIST BOX: PATIENT--%>
            <asp:ListBox ID="lstPatient" runat="server" CssClass="lstPatient"></asp:ListBox>

            <%--LABEL: ERROR--%>
            <asp:Label ID="lblError" runat="server" CssClass="lblErrorMessage" Text=""></asp:Label>

            <%--TEXTBOX: PATIENT SEARCH--%>
            <asp:TextBox ID="txtPatientSearch" runat="server" CssClass="txtPatientSearch"></asp:TextBox>

            <%--BUTTON: CLOSE--%>
            <asp:Button ID="btnListClose" runat="server" CssClass="btnClose" Text="X" OnClick="btnListClose_Click"/>

            <%--BUTTON: DISPLAY ALL PATIENTS--%>
            <asp:Button ID="btnDisplayAllPatients" runat="server" CssClass="btnDisplayAllPatients" Text="Display Full Details" OnClick="btnDisplayAllPatients_Click"/>

            <%--BUTTON: APPLY PATIENT FILTER--%>
            <asp:Button ID="btnPatientApplyFilter" runat="server" CssClass="btnPatientApplyFilter" Text="Apply Filter" OnClick="btnPatientApplyFilter_Click"/>

            <%--LABEL: FILTER PATIENT--%>
            <asp:Label ID="lblFilterPatient" runat="server" CssClass="lblFilterPatient" Text="Filter By Patient DOB : "></asp:Label>

            <%--BUTTON: EDIT PATIENT--%>
            <asp:Button ID="btnEditPatient" runat="server" CssClass="EditPatient" Text="Edit Record" OnClick="btnEditPatient_Click"/>

            <%--BUTTON: DELETE PATIENT--%>
            <asp:Button ID="btnDeletePatient" runat="server" CssClass="DeletePatient" Text="Delete Record" OnClick="btnDeletePatient_Click"/>
        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>
</html>
