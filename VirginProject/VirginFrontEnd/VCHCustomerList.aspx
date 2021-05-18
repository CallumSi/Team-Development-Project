<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHCustomerList.aspx.cs" Inherits="VirginFrontEnd.VCHCustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Customer List</title>
    <link href="VCHStyleCustomer.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2> Customer List
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

        <section><asp:Label ID="lblCustomers" runat="server" style="z-index: 1; left: 14px; top: 23px; position: absolute" Text="Customers"></asp:Label>
        <asp:Button ID="btnApply" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 15px; top: 490px; position: absolute" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" Height="40px" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 35px; top: 490px; position: absolute; left: 114px;" Text="Display All" />
        <%--<asp:Button ID="btnAdd" runat="server" Height="40px" Width="75px" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 540px; position: absolute" Text="Add" />--%>
        <asp:Button ID="btnEdit" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 115px; top: 540px; position: absolute; right: 1272px;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 215px; top: 540px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:TextBox ID="txtBxSearch" runat="server" Height="30px" style="z-index: 1; left: 15px; top: 440px; position: absolute"></asp:TextBox>
        <asp:ListBox ID="lstCustomer" runat="server" Height="300px" Width="800px" style="z-index: 1; left: 15px; top: 60px; position: absolute"></asp:ListBox>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 15px; top: 365px; position: absolute" Text="Please Enter a Customers Username"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 405px; position: absolute" Text="[lblError]"></asp:Label>
        </section>
    </form>
</body>
</html>
