<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCHospitalList.aspx.cs" Inherits="VirginFrontEnd.VHCHospitalList" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - List </title>
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
            <asp:Button ID="btnListHome" runat="server" CssClass="Home" Text="HOME" OnClick="btnListHome_Click" />
        </nav>

        <%--ARTICLE SECTION--%>
        <article>
            <h4>LIST & FILTER HOSPITAL SECTION </h4>
            <%--LIST BOX: HOSPITAL--%>
            <asp:ListBox ID="lstHospital" runat="server" CssClass="lstHospital"></asp:ListBox>
            <%--LABEL: ERROR--%>
            <asp:Label ID="lblError" runat="server" CssClass="lblErrorMessage" Text="⚠️ SYSTEM MESSAGES "></asp:Label>
            <%--TEXTBOX: HOSPITAL SEARCH--%>
            <asp:TextBox ID="txtHospitalSearch" runat="server" CssClass="txtHospitalSearch"></asp:TextBox>
            <%--BUTTON: CLOSE--%>
            <asp:Button ID="btnListClose" runat="server" CssClass="btnClose" Text="X" OnClick="btnListClose_Click" />
            <%--BUTTON: DISPLAY ALL HOSPITALS--%>
            <asp:Button ID="btnDisplayAllHospitals" runat="server" CssClass="btnDisplayAllHospitals" Text="Display Full Details" OnClick="btnDisplayAllHospitals_Click" />
            <%--BUTTON: APPLY HOSPITAL FILTER--%>
            <asp:Button ID="btnHospitalApplyFilter" runat="server" CssClass="btnHospitalApplyFilter" Text="Apply Filter" OnClick="btnHospitalApplyFilter_Click" />
            <%--LABEL: FILTER HOSPITAL--%>
            <asp:Label ID="lblFilterHospital" runat="server" CssClass="lblFilterHospital" Text="Filter By Location : "></asp:Label>
             <%--BUTTON: TOTAL NUMBER OF RECORD/S--%>
            <asp:Button ID="btnTotalRecords" runat="server" CssClass="btnTotalRecords" Text="No.Record/s" OnClick="btnTotalRecords_Click" />
        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>
</html>
