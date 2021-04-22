<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHAStaff.aspx.cs" Inherits="VirginFrontEnd.VCHAStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Staff Details</title>
    <link href="VCHStyleCustomer.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header>
            <h2> Staff Viewer 
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
        <asp:Label ID="lblStaffFirstName" runat="server" style="position: absolute; z-index: 1; left: 200px; top: 100px" Text="First Name:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblStaffLastName" runat="server" style="z-index: 1; left: 200px; top: 150px; position: absolute" Text="Last Name:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 200px; top: 195px; position: absolute" Text="Address:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblStaffPostcode" runat="server" style="z-index: 1; left: 200px; top: 245px; position: absolute" Text="Postcode:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblStaffUsername" runat="server" style="z-index: 1; left: 200px; top: 295px; position: absolute; bottom: 270px" Text="Username:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 200px; top: 345px; position: absolute" Text="Email:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblStaffPassword" runat="server" style="z-index: 1; left: 200px; top: 390px; position: absolute" Text="Password:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblStaffPhoneNumber" runat="server" style="z-index: 1; left: 200px; top: 440px; position: absolute" Text="Phone Number:" ForeColor="White"></asp:Label>

        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 445px; top: 100px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 445px; top: 150px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 445px; top: 195px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 445px; top: 245px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 445px; top: 295px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 445px; top: 345px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 445px; top: 390px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhonenumber" runat="server" style="z-index: 1; left: 445px; top: 440px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 495px; position: absolute" Text="[lblError]" ForeColor="White"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 200px; top: 545px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 255px; top: 545px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </section>
    </form>
</body>
</html>
