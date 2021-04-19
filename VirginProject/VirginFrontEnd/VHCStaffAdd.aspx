<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCStaffAdd.aspx.cs" Inherits="VirginFrontEnd.VHCStaffAdd" %>

<!DOCTYPE html>
<html>
<%--HEAD SECTION--%>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare - Add Section</title>
    <link href="VHCStaff.css" rel="stylesheet" type="text/css" />
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
            <h4>REGISTER STAFF SECTION</h4>

            <%--STAFF TITLE--%>
            <asp:Label ID="lblStaff_Title" runat="server" CssClass="lblStaff_Title" Text="STAFF TITLE : "></asp:Label>
            <asp:TextBox ID="txtStaff_Title" runat="server" CssClass="txtStaff_Title" Font-Italic="False"></asp:TextBox>

            <%--STAFF FIRSTNAME--%>
            <asp:Label ID="lblStaff_Firstname" runat="server" CssClass="lblStaff_Firstname" Text="STAFF FIRSTNAME : "></asp:Label>
            <asp:TextBox ID="txtStaff_Firstname" runat="server" CssClass="txtStaff_Firstname" Font-Italic="False"></asp:TextBox>

            <%--STAFF LASTNAME--%>
            <asp:Label ID="lblStaff_Lastname" runat="server" CssClass="lblStaff_Lastname" Text="STAFF LASTNAME : "></asp:Label>
            <asp:TextBox ID="txtStaff_Lastname" runat="server" CssClass="txtStaff_Lastname" Font-Italic="False"></asp:TextBox>

            <%--STAFF EMAIL--%>
            <asp:Label ID="lblStaff_Email" runat="server" CssClass="lblStaff_Email" Text="STAFF EMAIL : "></asp:Label>
            <asp:TextBox ID="txtStaff_Email" runat="server" CssClass="txtStaff_Email" Font-Italic="False"></asp:TextBox>

            <%--STAFF USERNAME--%>
            <asp:Label ID="lblStaff_Username" runat="server" CssClass="lblStaff_Username" Text="STAFF USERNAME : "></asp:Label>
            <asp:TextBox ID="txtStaff_Username" runat="server" CssClass="txtStaff_Username" Font-Italic="False"></asp:TextBox>

            <%--STAFF PASSWORD--%>
            <asp:Label ID="lblStaff_Password" runat="server" CssClass="lblStaff_Password" Text="STAFF PASSWORD : "></asp:Label>
            <asp:TextBox ID="txtStaff_Password" runat="server" CssClass="txtStaff_Password" Font-Italic="False" MaxLength="50"></asp:TextBox>

            <%--STAFF ROLE--%>
            <asp:Label ID="lblStaff_Role" runat="server" CssClass="lblStaff_Role" Text="STAFF ROLE : "></asp:Label>
            <asp:TextBox ID="txtStaff_Role" runat="server" CssClass="txtStaff_Role" Font-Italic="False"></asp:TextBox>

            <%--STAFF STATUS--%>
            <asp:Label ID="lblStaff_Status" runat="server" CssClass="lblStaff_Status" Text="PLEASE TICK TO ACCEPT THE TERMS & CONDITIONS "></asp:Label>
            <asp:CheckBox ID="cbStaff_Status" runat="server" CssClass="cbStaff_Status" />

            <%--BUTTON: CLOSE--%>
            <asp:Button ID="btnClose" runat="server" CssClass="btnClose" Text="X" OnClick="btnClose_Click" />

            <%--LABEL:ERROR MESSAGE--%>
            <asp:Label ID="lblError" runat="server" CssClass="lblErrorMessage" Text=""></asp:Label>

            <%--BUTTON: SUBMIT--%>
            <asp:Button ID="btnSubmit" runat="server" CssClass="btnSubmit" Text="SUBMIT" OnClick="btnSubmit_Click" />

        </article>

        <%--FOOTER SECTION--%>
        <footer>
            <div id="FooterText">© 2021 Virgin Media | All Rights Reserved </div>
        </footer>

    </form>
</body>
</html>
