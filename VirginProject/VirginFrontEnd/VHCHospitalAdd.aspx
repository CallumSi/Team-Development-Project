<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHCHospitalAdd.aspx.cs" Inherits="VirginFrontEnd.VHCHospitalAdd" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Virgin Healthcare</title>
    <link href="VHCHospital.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Healthcare: Hospital</h2>
        </header>

        <article>
            <asp:Label ID="lblAddHospitalSection" runat="server" CssClass="lblAddHospitalSection" Text="ADD HOSPITAL SECTION"></asp:Label>
        </article>

        <nav>
            <asp:Button ID="Home_Button" runat="server" CssClass="Home" Text="HOME" OnClick="Home_Button_Click"/>
        </nav>


        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>