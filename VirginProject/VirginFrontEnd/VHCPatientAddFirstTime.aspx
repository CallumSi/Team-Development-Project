<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCPatientAddFirstTime.aspx.cs" Inherits="VirginFrontEnd.VHCPatientAddFirstTime" %>

<!DOCTYPE html>

<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - Add Section</title>
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
            <h4>REGISTER PATIENT SECTION</h4>

            <%--PATIENT TITLE--%>
            <asp:Label ID="lblPatient_Title" runat="server" CssClass="lblPatient_Title" Text="PATIENT TITLE : "></asp:Label>
            <asp:TextBox ID="txtPatient_Title" runat="server" CssClass="txtPatient_Title" Font-Italic="False"></asp:TextBox>

            <%--PATIENT FIRSTNAME--%>
            <asp:Label ID="lblPatient_Firstname" runat="server" CssClass="lblPatient_Firstname" Text="PATIENT FIRSTNAME : "></asp:Label>
            <asp:TextBox ID="txtPatient_Firstname" runat="server" CssClass="txtPatient_Firstname" Font-Italic="False"></asp:TextBox>

            <%--PATIENT LASTNAME--%>
            <asp:Label ID="lblPatient_Lastname" runat="server" CssClass="lblPatient_Lastname" Text="PATIENT LASTNAME : "></asp:Label>
            <asp:TextBox ID="txtPatient_Lastname" runat="server" CssClass="txtPatient_Lastname" Font-Italic="False"></asp:TextBox>

            <%--PATIENT ADDRESS--%>
            <asp:Label ID="lblPatient_Address" runat="server" CssClass="lblPatient_Address" Text="PATIENT ADDRESS : "></asp:Label>
            <asp:TextBox ID="txtPatient_Address" runat="server" CssClass="txtPatient_Address" Font-Italic="False"></asp:TextBox>

            <%--PATIENT DATE OF BIRTH--%>
            <asp:Label ID="lblPatient_DOB" runat="server" CssClass="lblPatient_DOB" Text="PATIENT DATE OF BIRTH : "></asp:Label>
            <asp:TextBox ID="txtPatient_DOB" runat="server" CssClass="txtPatient_DOB" Font-Italic="False"></asp:TextBox>

            <%--PATIENT EMAIL--%>
            <asp:Label ID="lblPatient_Email" runat="server" CssClass="lblPatient_Email" Text="PATIENT EMAIL : "></asp:Label>
            <asp:TextBox ID="txtPatient_Email" runat="server" CssClass="txtPatient_Email" Font-Italic="False"></asp:TextBox>

            <%--PATIENT USERNAME--%>
            <asp:Label ID="lblPatient_Username" runat="server" CssClass="lblPatient_Username" Text="PATIENT USERNAME : "></asp:Label>
            <asp:TextBox ID="txtPatient_Username" runat="server" CssClass="txtPatient_Username" Font-Italic="False"></asp:TextBox>

            <%--PATIENT PASSWORD--%>
            <asp:Label ID="lblPatient_Password" runat="server" CssClass="lblPatient_Password" Text="PATIENT PASSWORD : "></asp:Label>
            <asp:TextBox ID="txtPatient_Password" runat="server" CssClass="txtPatient_Password" Font-Italic="False"></asp:TextBox>

            <%--PATIENT TELEPHONE--%>
            <asp:Label ID="lblPatient_Telephone" runat="server" CssClass="lblPatient_Telephone" Text="PATIENT TELEPHONE : "></asp:Label>
            <asp:TextBox ID="txtPatient_Telephone" runat="server" CssClass="txtPatient_Telephone" Font-Italic="False"></asp:TextBox>

            <%--PATIENT STATUS--%>
            <asp:Label ID="lblPatient_Status" runat="server" CssClass="lblPatient_Status" Text="PLEASE TICK TO ACCEPT THE TERMS & CONDITIONS "></asp:Label>
            <asp:CheckBox ID="cbPatient_Status" runat="server" CssClass="cbPatient_Status" />

            <%--BUTTON: CLOSE--%>
            <asp:Button ID="BtnClose" runat="server" CssClass="BtnClose" Text="X" OnClick="BtnClose_Click" />

            <%--LABEL:ERROR MESSAGE--%>
            <asp:Label ID="lblError" runat="server" CssClass="lblErrorMessage" Text=""></asp:Label>

            <%--BUTTON: SUBMIT--%>
            <asp:Button ID="BtnSubmit" runat="server" CssClass="BtnSubmit" Text="Submit" OnClick="BtnSubmit_Click" />

        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>
</html>
