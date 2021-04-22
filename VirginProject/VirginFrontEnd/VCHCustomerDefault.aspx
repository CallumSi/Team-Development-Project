<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHCustomerDefault.aspx.cs" Inherits="VirginFrontEnd.VCHCustomerHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Welcome</title>
    <link href="VCHStyleCustomer.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2> Welcome 
            </h2> 
        </header>

        <section>
        <asp:Label ID="lblWelcome" runat="server" style="position: absolute; z-index: 1; left: 425px; top: 175px" Text="Welcome to Virgin Car Hire. If this is your first time on the site, we need to collect more details from you. Please supply the correct information in order to fully utilise Virgin's Car Hire site" Width="550px"></asp:Label>
        <asp:Button ID="btnFirstTime" runat="server" style="z-index: 1; left: 850px; top: 355px; position: absolute" Text="First Time" OnClick="btnFirstTime_Click" />
        <asp:Button ID="btnReturningCustomer" runat="server" style="z-index: 1; left: 425px; top: 355px; position: absolute" Text="Returning Customer" OnClick="btnReturningCustomer_Click" />
        </section>
    </form>
</body>
</html>
