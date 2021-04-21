<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCAppointmentList.aspx.cs" Inherits="VirginFrontEnd.VHCAppointmentList" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - Appointment List </title>
    <link href="VHCAppointment.css" rel="stylesheet" type="text/css" />
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
            <h4>APPOINTMENT LIST </h4>

             <%--LABEL: WELCOME FIRSTNAME--%>
            <asp:Label ID="lblWelcomeFirstName" runat="server" CssClass="lblWelcomeFirstName"></asp:Label>

             <%--LABEL: WELCOME--%>
            <asp:Label ID="lblWelcome" runat="server" Text="👤 Welcome" CssClass="lblWelcome"></asp:Label>

            <%--LIST BOX: APPOINTMENT--%>
            <asp:ListBox ID="lstAppointment" runat="server" CssClass="lstAppointment"></asp:ListBox>

            <%--LABEL: ERROR--%>
            <asp:Label ID="lblError" runat="server" CssClass="lblErrorMessage" Text=""></asp:Label>

            <%--BUTTON: CLOSE--%>
            <asp:Button ID="BtnListClose" runat="server" CssClass="btnClose" Text="X" OnClick="BtnListClose_Click"/>

            <%--BUTTON: APPOINTMENT BOOK FILTER--%>
            <asp:Button ID="BtnAppointmentBook" runat="server" CssClass="btnAppointmentBook" Text="BOOK" OnClick="BtnAppointmentBook_Click" />

            <%--LABEL: APPOINTMENT START DATE--%>
            <asp:Label ID="lblAppointmentDate" runat="server" CssClass="lblAppointmentDate" Text="Appointment Date : "></asp:Label>

            <%--TEXTBOX: APPOINTMENT DATE SEARCH--%>
            <asp:TextBox ID="txtAppointmentDate" runat="server" CssClass="txtAppointmentDate">20/04/2021</asp:TextBox>

            <%--BUTTON: APPOINTMENT SEARCH--%>
            <asp:Button ID="BtnAppointmentSearch" runat="server" CssClass="btnAppointmentSearch" Text="Search" OnClick="BtnAppointmentSearch_Click" />
        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>
</html>
