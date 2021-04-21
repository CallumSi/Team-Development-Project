<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckAdmin.aspx.cs" Inherits="VirginFrontEnd.CheckAdmin" %>

<!DOCTYPE html>
<%-- HEAD --%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CheckAdmin</title>
    <link href="VHCStaff.css" rel="stylesheet" type="text/css" />
</head>

<%--BODY--%>
<body>
    <form id="form2" runat="server">
        <%-- HEADER --%>
        <header>
            <h2>VIRGIN SERVICES </h2>
        </header>
        <%-- ARTICLE --%>
        <article>
            <h4>CHECK ADMIN </h4>
            <%-- LABEL: CONFIRM PIN --%>
            <asp:Label ID="lblPin" CssClass="lblConfirmPin" runat="server" Text="Please enter your pin: "></asp:Label>
            <%-- TEXTBOX: PASSWORD --%>
            <asp:TextBox ID="txtPin" CssClass="txtStaffPin" runat="server" TextMode="Password"></asp:TextBox>
            <%-- BUTTON: OK --%>
            <asp:Button ID="btnOk" CssClass="btnConfirmPin" runat="server" OnClick="btnOk_Click" Text="OK" />
            <%-- LABEL:ERROR --%>
            <asp:Label ID="lblError" CssClass="lblErrorMessage" runat="server"></asp:Label>
        </article>

        <%-- FOOTER --%>
        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
