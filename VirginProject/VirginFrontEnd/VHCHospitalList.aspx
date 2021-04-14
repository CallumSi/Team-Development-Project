<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCHospitalList.aspx.cs" Inherits="VirginFrontEnd.VHCHospitalList" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - List </title>
    <link href="VHCHospital.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 500px;
            left: 301px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 185px;
            left: 618px;
            z-index: 1;
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
        <article>
            <h3> HOSPITAL LIST SECTION</h3>
           
            <asp:ListBox ID="lstHospital" runat="server" CssClass="lstHospital" Height="348px" Width="341px" BackColor="#E3E3E3"></asp:ListBox>

            <asp:Button ID="btnDisplayAllHospitals" runat="server" CssClass="btnDisplayAllHospitals" Text="Display All" OnClick="btnDisplayAllHospitals_Click" />
           
            <asp:Button ID="btnApplyHospital" runat="server" CssClass="btnApplyHospital" Text="Apply" OnClick="btnApplyHospital_Click" />
           
            <asp:Label ID="lblError" runat="server" CssClass="auto-style1" Text="MESSAGES"></asp:Label>
            <asp:TextBox ID="txtHospitalSearch" runat="server" CssClass="auto-style2"></asp:TextBox>
           
        </article>
        <%--NAVIGATION SECTION--%>
        <nav>
            <%--BUTTON: HOME--%>         
              <asp:Button ID="Home_Button_List" runat="server" CssClass="Home" Text="HOME" OnClick="Home_Button_List_Click"/>
        </nav>
        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>
    </form>
</body>
</html>
