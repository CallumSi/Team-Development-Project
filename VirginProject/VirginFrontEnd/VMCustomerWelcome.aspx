<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VMCustomerWelcome.aspx.cs" Inherits="VirginFrontEnd.VMCustomerWelcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />

</head>
<body>


    <form id="form1" runat="server">
        <header>
            <h2>Virgin Movies </h2>
        </header>

        <article class="CustomerWelcome">
            <h1>Welcome To Virgin Movies </h1>
            <h2>Please select from the options below </h2>
        </article>
        <asp:Button ID="btnContinue" CssClass="btnContinue" runat="server" Text="Continue" OnClick="btnContinue_Click" />
        <asp:Button ID="btnFirstTime" CssClass="btnFirstTime" runat="server" Text="First Time?" OnClick="btnFirstTime_Click" />



        <nav>
            Navigation links here
        </nav>
        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
