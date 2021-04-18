<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCHospitalAdd.aspx.cs" Inherits="VirginFrontEnd.VHCHospitalAdd" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - Add Section</title>
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
            <h4>ADD HOSPITAL SECTION </h4>
            <%--LABEL:HOSPITAL NAME--%>
            <asp:Label ID="lblHospital_Name" runat="server" CssClass="lblHospital_Name" Text="HOSPITAL NAME : "></asp:Label>
            <%--LABEL:HOSPITAL PLACE--%>
            <asp:Label ID="lblHospital_Place" runat="server" CssClass="lblHospital_Place" Text="HOSPITAL PLACE : "></asp:Label>
            <%--TEXTBOX:HOSPITAL NAME--%>
            <asp:TextBox ID="txtHospital_Name" runat="server" CssClass="txtHospital_Name"></asp:TextBox>
            <%--TEXTBOX:HOSPITAL PLACE--%>
            <asp:TextBox ID="txtHospital_Place" runat="server" CssClass="txtHospital_Place"></asp:TextBox>
            <%--BUTTON: SUBMIT--%>
            <asp:Button ID="btnSubmit" runat="server" CssClass="btnSubmit" Text="SUBMIT" OnClick="btnSubmit_Click" />
            <%--BUTTON: CLOSE--%>
            <asp:Button ID="btnClose" runat="server" CssClass="btnClose" Text="X" OnClick="btnClose_Click" />
            <%--LABEL:ERROR MESSAGE--%>
            <asp:Label ID="lblError" runat="server" CssClass="lblErrorMessage" Text=""></asp:Label>
        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>
</html>
