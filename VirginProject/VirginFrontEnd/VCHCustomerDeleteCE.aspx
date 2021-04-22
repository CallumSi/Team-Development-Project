<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHCustomerDeleteCE.aspx.cs" Inherits="VirginFrontEnd.VCHCustomerDeleteCE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Customer Delete Confirmation</title>
    <link href="VCHStyleCustomer.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header>
            <h2> Delete Your Account Confirmation
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" style="z-index: 1; left: 1355px; top: 40px; position: absolute; height: 35px; width: 100px;" />
            </h2> 
        </header>

        <nav>
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; top: 50px; position: absolute; height: 65px; width: 160px;" OnClick="btnHome_Click" Text="Home" />
            <asp:Button ID="btnAccount" runat="server" style="z-index: 1; top: 150px; position: absolute; height: 65px; width: 160px;" OnClick="btnAccount_Click" Text="Access Account" />
        </nav>

        <section>
        <asp:Label ID="lblDeleteCustomer" runat="server" style="z-index: 1; left: 325px; top: 290px; position: absolute" Text="Confirm deleting your customer account"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" Height="40px" Width="75px" OnClick="btnDelete_Click" style="z-index: 1; left: 360px; top: 360px; position: absolute" Text="Delete" />
        <asp:Button ID="btnCancel" runat="server" Height="40px" Width="75px" OnClick="btnCancel_Click" style="z-index: 1; left: 500px; top: 360px; position: absolute" Text="Cancel" />
        </section>

    </form>
</body>
</html>
