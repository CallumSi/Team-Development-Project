<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCHospitalEdit.aspx.cs" Inherits="VirginFrontEnd.VHCHospitalEdit" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - Edit Section</title>
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
            <h4>EDIT HOSPITAL SECTION </h4>
            <%--LABEL:HOSPITAL NAME--%>
            <asp:Label ID="lblHospital_Name" runat="server" CssClass="lblHospital_Name" Text="HOSPITAL NAME : "></asp:Label>

            <%--LABEL:HOSPITAL PLACE--%>
            <asp:Label ID="lblHospital_Place" runat="server" CssClass="lblHospital_Place" Text="HOSPITAL PLACE : "></asp:Label>

            <%--TEXTBOX:HOSPITAL NAME--%>
            <asp:TextBox ID="txtHospital_Name" runat="server" CssClass="txtHospitalName">Enter Hospital Name</asp:TextBox>

            <%--DROPDOWNLIST:HOSPITAL PLACE--%>
            <asp:DropDownList ID="ddlHospitalPlace" runat="server" CssClass="ddlHospitalPlace">
                <asp:ListItem>London</asp:ListItem>
                <asp:ListItem>Leicester</asp:ListItem>
                <asp:ListItem>Manchester</asp:ListItem>
                <asp:ListItem>Birmingham</asp:ListItem>
                <asp:ListItem>Portsmouth</asp:ListItem>
                <asp:ListItem>Coventry</asp:ListItem>
                <asp:ListItem>Rugby</asp:ListItem>
                <asp:ListItem>Liverpool</asp:ListItem>
                <asp:ListItem>Newcastle</asp:ListItem>
                <asp:ListItem>Derby</asp:ListItem>
                <asp:ListItem>Peterborough</asp:ListItem>
            </asp:DropDownList>

            <%--BUTTON: UPDATE--%>
            <asp:Button ID="btnSubmit" runat="server" CssClass="btnSubmit" Text="UPDATE" />
            <asp:Button ID="btnClose" runat="server" CssClass="btnClose" Text="X" OnClick="btnClose_Click" />
        </article>

        <%--NAVIGATION SECTION--%>
        <nav>
            <%--BUTTON: HOME--%>
            <asp:Button ID="Home_Button_Edit" runat="server" CssClass="Home" Text="HOME" OnClick="Home_Button_Edit_Click" />
        </nav>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>
    </form>
</body>
</html>
