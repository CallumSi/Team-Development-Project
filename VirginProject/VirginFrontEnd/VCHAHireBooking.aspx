<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHAHireBooking.aspx.cs" Inherits="VirginFrontEnd.VCHAHireBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>VCH - Hire Booking</title>
    <link href="VCHStyleCustomer.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header>
            <h2> Hire Booking
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
        <asp:Label ID="lblHireID" runat="server" style="z-index: 1; left: 200px; top: 150px; position: absolute" Text="Hire Identification:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblHireDate" runat="server" style="z-index: 1; left: 200px; top: 195px; position: absolute" Text="Hire Date:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblHireTime" runat="server" style="z-index: 1; left: 200px; top: 245px; position: absolute" Text="Hire Time:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblHireDescription" runat="server" style="z-index: 1; left: 200px; top: 295px; position: absolute; bottom: 270px" Text="Description & Info:" ForeColor="White"></asp:Label>
        
        <asp:TextBox ID="txtHireID" runat="server" style="z-index: 1; left: 560px; top: 150px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHireDate" runat="server" style="z-index: 1; left: 560px; top: 195px; position: absolute">20/05/2021</asp:TextBox>
        <asp:TextBox ID="txtHireTime" runat="server" style="z-index: 1; left: 560px; top: 245px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHireDescription" runat="server" style="z-index: 1; left: 560px; top: 295px; position: absolute; height: 134px; width: 595px;">Upon collection of the hired vehicle, payment will be required.</asp:TextBox>

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 470px; position: absolute" Text="Hire identification data must pertain to an active record, failure to supply correct data will result in the failure of system functionality." ForeColor="White"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 200px; top: 515px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 255px; top: 515px; position: absolute; right: 1240px;" Text="Cancel" OnClick="btnCancel_Click" />
            
        </section>
    </form>
</body>
</html>
