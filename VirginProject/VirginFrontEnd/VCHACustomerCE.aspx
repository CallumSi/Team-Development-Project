<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHACustomerCE.aspx.cs" Inherits="VirginFrontEnd.VCHACustomerCE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Your Details</title>
    <link href="VCHStyleCustomer.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header>
            <h2> Virgin Media </h2> 
        </header>

        <nav>
            Navigation links here
        </nav>

        <asp:Label ID="lblUserID" runat="server" style="z-index: 1; left: 285px; top: 45px; position: absolute" Text="Customer Details"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="position: absolute; z-index: 1; left: 285px; top: 100px" Text="First Name:"></asp:Label>
        <span class="auto-style1">
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 285px; top: 150px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblAge" runat="server" style="z-index: 1; left: 285px; top: 195px; position: absolute" Text="Driver Age:"></asp:Label>
        <asp:Label ID="lblDriverLicenseNumber" runat="server" style="z-index: 1; left: 285px; top: 245px; position: absolute" Text="Driver's License Number:"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 285px; top: 295px; position: absolute" Text="Address:"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 285px; top: 345px; position: absolute" Text="Postcode:"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 285px; top: 390px; position: absolute; bottom: 270px" Text="Re-Enter Username:"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 285px; top: 440px; position: absolute" Text="Email:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 285px; top: 480px; position: absolute" Text="Re-Enter Password:"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 285px; top: 520px; position: absolute" Text="Phone Number:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 500px; top: 100px; position: absolute; bottom: 575px;"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 500px; top: 151px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAge" runat="server" style="z-index: 1; left: 500px; top: 195px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDriverLicenseNumber" runat="server" style="z-index: 1; left: 500px; top: 245px; position: absolute"></asp:TextBox>
        </span>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 500px; top: 295px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 500px; top: 345px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 500px; top: 390px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 500px; top: 440px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 500px; top: 480px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhonenumber" runat="server" style="z-index: 1; left: 500px; top: 520px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 285px; top: 575px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 500px; top: 625px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 550px; top: 625px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />

        <footer>
            <div id ="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
        <p>
        <span class="auto-style1">
        
        </span>
        </p>
        <span class="auto-style1">
        
        </span>
    </form>
</body>
</html>
