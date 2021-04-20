<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHACustomer.aspx.cs" Inherits="VirginFrontEnd.VCHACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Customer Details</title>
    <link href="VCHStyleCustomer.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" style="z-index: 1">
        <div>
        </div>
        
        <header>
            <h2> Virgin Media </h2> 
        </header>

        <nav>
            <asp:Button ID="btnStaff" runat="server" style="z-index: 1; top: 50px; position: absolute; height: 65px; width: 160px;" OnClick="btnStaff_Click" Text="Access Staff" />
            <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; top: 150px; position: absolute; height: 65px; width: 160px;" OnClick="btnCustomer_Click" Text="Access Customer" />
            <asp:Button ID="btnCar" runat="server" style="z-index: 1; top: 250px; position: absolute; height: 65px; width: 160px;" OnClick="btnCar_Click" Text="Access Cars" />
            <asp:Button ID="btnHire" runat="server" style="z-index: 1; top: 350px; position: absolute; height: 65px; width: 160px;" OnClick="btnHire_Click" Text="Access Hires" />
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; top: 450px; position: absolute; height: 65px; width: 160px;" OnClick="btnHome_Click" Text="Home" />
        </nav>

        <asp:Label ID="lblUserID" runat="server" style="z-index: 1; left: 200px; top: 45px; position: absolute" Text="Customer Details" ForeColor="White"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="position: absolute; z-index: 1; left: 200px; top: 98px" Text="First Name:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 200px; top: 150px; position: absolute" Text="Last Name:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblAge" runat="server" style="z-index: 1; left: 200px; top: 195px; position: absolute" Text="Driver Age:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblDriverLicenseNumber" runat="server" style="z-index: 1; left: 200px; top: 245px; position: absolute; right: 110px;" Text="Driver's License Number:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 200px; top: 295px; position: absolute" Text="Address:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 200px; top: 345px; position: absolute" Text="Postcode:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 200px; top: 390px; position: absolute; bottom: 270px" Text="Username:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 200px; top: 440px; position: absolute" Text="Email:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 200px; top: 480px; position: absolute" Text="Password:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 200px; top: 520px; position: absolute" Text="Phone Number:" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 445px; top: 100px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 445px; top: 150px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAge" runat="server" style="z-index: 1; left: 445px; top: 195px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDriverLicenseNumber" runat="server" style="z-index: 1; left: 455px; top: 245px; position: absolute"></asp:TextBox>
        </span>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 445px; top: 295px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 445px; top: 345px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 445px; top: 390px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 445px; top: 440px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 445px; top: 480px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhonenumber" runat="server" style="z-index: 1; left: 445px; top: 520px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 575px; position: absolute" Text="[lblError]" ForeColor="White"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 200px; top: 625px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 255px; top: 625px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
