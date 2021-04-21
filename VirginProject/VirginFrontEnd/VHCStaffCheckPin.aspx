<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCStaffCheckPin.aspx.cs" Inherits="VirginFrontEnd.VHCStaffCheckPin" %>

<!DOCTYPE html>

<%--HEAD SECTION--%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Healthcare Staff Check Pin</title>
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
              <h3>STAFF PIN CONFIRMATION SECTION</h3>
 
            <%--LABEL: CONFIRM PIN--%>
            <asp:Label ID="lblConfirmPin" runat="server" Text="CONFIRM PIN : " CssClass="lblConfirmPin"></asp:Label>

            <%--TEXTBOX: STAFF PIN--%>
            <asp:TextBox ID="txtStaffPin" runat="server" CssClass="txtStaffPin" TextMode="Password"></asp:TextBox>

            <%--BUTTON: CONFIRM PIN--%>
            <asp:Button ID="btnConfirmPin" runat="server" Text="CONFIRM" CssClass="btnConfirmPin" OnClick="btnConfirmPin_Click" />

            <%--BUTTON: CLOSE--%>
            <asp:Button ID="btnClose" runat="server" CssClass="btnClose" Text="X" OnClick="btnClose_Click" />

            <%--LABEL: ERROR--%>
            <asp:Label ID="lblError" runat="server" CssClass="lblErrorMessage" Text=""></asp:Label>
        </article>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
