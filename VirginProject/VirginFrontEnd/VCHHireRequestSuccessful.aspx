<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHHireRequestSuccessful.aspx.cs" Inherits="VirginFrontEnd.VCHHireRequestSuccessful" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Hire Request Submitted</title>
    <link href="VCHStyleCustomer.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header>
            <h2> Hire Request Submitted 
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" style="z-index: 1; left: 1355px; top: 40px; position: absolute; height: 35px; width: 100px;" />
            </h2> 
        </header>

        <nav>
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; top: 50px; position: absolute; height: 65px; width: 160px;" OnClick="btnHome_Click" Text="Home" />
            <asp:Button ID="btnAccount" runat="server" style="z-index: 1; top: 150px; position: absolute; height: 65px; width: 160px;" OnClick="btnAccount_Click" Text="Access Account" />
        </nav>

        <section>
        <asp:Label ID="lblRequestSuccess" runat="server" style="z-index: 1; left: 325px; top: 290px; position: absolute" Text="Your Hire Request has been successfully submitted and is in queue to be processed. You will be kept up to date via Email and SMS. Until your request has been completely processed, you will not be able to delete your Virgin Car Hire account."></asp:Label>
        <asp:Button ID="btnBackHome" runat="server" Height="40px" OnClick="btnBackHome_Click" style="z-index: 1; left: 360px; top: 360px; position: absolute; width: 266px;" Text="Back to Home Page" />
        </section>

    </form>
</body>
</html>
