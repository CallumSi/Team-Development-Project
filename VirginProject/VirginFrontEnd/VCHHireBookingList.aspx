<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHHireBookingList.aspx.cs" Inherits="VirginFrontEnd.VCHHireBookingList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Hire Booking List</title>
    <link href="VCHStyleCustomer.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header>
            <h2> Hire Booking List
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" style="z-index: 1; left: 1355px; top: 40px; position: absolute; height: 35px; width: 100px;" />
            </h2> 
        </header>

        <nav>
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; top: 50px; position: absolute; height: 65px; width: 160px;" OnClick="btnHome_Click" Text="Home" />
            <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; top: 150px; position: absolute; height: 65px; width: 160px;" OnClick="btnCustomer_Click" Text="Access Customer" />
            <asp:Button ID="btnCar" runat="server" style="z-index: 1; top: 250px; position: absolute; height: 65px; width: 160px;" OnClick="btnCar_Click" Text="Access Cars" />
            <asp:Button ID="btnHire" runat="server" style="z-index: 1; top: 350px; position: absolute; height: 65px; width: 160px;" OnClick="btnHire_Click" Text="Access Hires" />
            <asp:Button ID="btnBooking" runat="server" style="z-index: 1; top: 450px; position: absolute; height: 65px; width: 160px;" OnClick="btnBooking_Click" Text="Access Booking" />
            <asp:Button ID="btnStaff" runat="server" style="z-index: 1; top: 550px; position: absolute; height: 65px; width: 160px;" OnClick="btnStaff_Click" Text="Access Staff" />
        </nav>

        <section>
        <asp:TextBox ID="txtHireDate" runat="server" style="z-index: 1; left: 200px; top: 100px; position: absolute; width: 325px;">20/05/2021</asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 550px; top: 100px; position: absolute;" OnClick="btnSearch_Click" Text="Search" />
        <asp:ListBox ID="lstHireBookings" runat="server" Height="300px" Width="800px" style="z-index: 1; left: 200px; top: 150px; position: absolute"></asp:ListBox>
        <asp:Button ID="btnBook" runat="server" style="z-index: 1; left: 550px; top: 515px; position: absolute;" OnClick="btnBook_Click" Text="Book Hire" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 470px; position: absolute" Text="[lblError]" ForeColor="White"></asp:Label>
        </section>
    </form>
</body>
</html>
