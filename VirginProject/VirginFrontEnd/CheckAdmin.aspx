<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckAdmin.aspx.cs" Inherits="VirginFrontEnd.CheckAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CheckAdmin</title>
    <link href="VHCStaff.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form2" runat="server">

        <header>
            <h2>Virgin Media </h2>

        </header>

        <article>
            <h1>Check Admin </h1>

            <asp:Label ID="lblPin" CssClass="lblConfirmPin" runat="server" Style="z-index: 1;" Text="Please enter your pin"></asp:Label>
            <asp:TextBox ID="txtPin" CssClass="txtStaffPin" runat="server" Style="z-index: 1;" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnOk" CssClass="btnConfirmPin" runat="server" OnClick="btnOk_Click" Style="z-index: 1;" Text="Ok" />
            <asp:Label ID="lblError"  CssClass="lblErrorMessage" runat="server" Style="z-index: 1;"></asp:Label>
        </article>

        <nav>
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>



    </form>
</body>
</html>
