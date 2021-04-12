﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCHospital.aspx.cs" Inherits="VirginFrontEnd.VHCHospital" %>

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

            <%--ARTICLE SECTION--%>
            <article>
                <h3> WELCOME TO THE HOSPITAL SECTION </h3>
            </article>
            <%--NAVIGATION SECTION--%>
            <nav>
                <asp:Button ID="Home_Button" runat="server" CssClass="Home" Text="HOME" OnClick="Home_Button_Click"/>
                <asp:Button ID="Hospital_AddButton" runat="server" CssClass="AddHospital" Text="Add Hospital" OnClick="Button1_Click"/>
                <asp:Button ID="Button2" runat="server" CssClass="EditHospital" Text="Edit Hospital"/>
                <asp:Button ID="Button3" runat="server" CssClass="DeleteHospital" Text="Delete Hospital"/>
                <asp:Button ID="Button4" runat="server" CssClass="ListHospitals" Text="List Hospitals"/>
                <asp:Button ID="Button5" runat="server" CssClass="FilterHospitals" Text="Filter Hospital"/>
            </nav>
            <%--FOOTER SECTION--%>
            <footer>
                <div id="FooterText"> © 2021 Virgin Media | All Rights Reserved </div>
            </footer>
        </form>
    </body>
</html>