<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCAppointmentBooking.aspx.cs" Inherits="VirginFrontEnd.VHCAppointmentBooking" %>

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
    <form id="form2" runat="server">
        <%--HEADER SECTION--%>
        <header>
            <h2>Virgin Healthcare System</h2>
        </header>

        <%--ARTICLE SECTION--%>
        <article>
            <h4>BOOK AN APPOINTMENT </h4>

            <%--LABEL: DATE --%>
            <asp:Label ID="lblDate" runat="server" CssClass="lblDate" Text="Booking Date : "></asp:Label>

            <%--TEXTBOX: DATE --%>
            <asp:TextBox ID="txtDate" runat="server" CssClass="txtDate"></asp:TextBox>

            <%--LABEL: TIME --%>
            <asp:Label ID="lblTime" runat="server" CssClass="lblTime" Text="Booking Time : "></asp:Label>

            <%--TEXTBOX: TIME --%>
            <asp:TextBox ID="txtTime" runat="server" CssClass="txtTime"></asp:TextBox>

            <%--LABEL: DESCRIPTION --%>
            <asp:Label ID="lblDescription" runat="server" CssClass="lblDescription" Text="Description : "></asp:Label>

            <%--TEXTBOX: DESCRIPTION --%>
            <asp:TextBox ID="txtDescription" runat="server" CssClass="txtDescription"></asp:TextBox>

            <%--BUTTON: OK --%>
            <asp:Button ID="btnOK" runat="server" CssClass="btnOK" OnClick="btnOK_Click" Text="OK" />

            <%--BUTTON: CLOSE--%>
            <asp:Button ID="btnClose" runat="server" CssClass="btnClose" Text="X" OnClick="btnClose_Click" />

        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>

</html>
