﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHACustomer.aspx.cs" Inherits="VirginFrontEnd.VCHACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1116px;
            height: 27px;
            left: 10px;
            top: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="z-index: 1">
        <div>
        </div>
        <asp:Label ID="lblFirstName" runat="server" style="position: absolute; z-index: 1; left: 8px; top: 98px" Text="First Name:"></asp:Label>
        <span class="auto-style1">
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 7px; top: 147px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 6px; top: 195px; position: absolute" Text="Address:"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 6px; top: 244px; position: absolute" Text="Postcode:"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 6px; top: 294px; position: absolute; bottom: 270px" Text="Username:"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 8px; top: 342px; position: absolute" Text="Email:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 5px; top: 391px; position: absolute" Text="Password:"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 6px; top: 439px; position: absolute" Text="Phone Number:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 172px; top: 100px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 172px; top: 149px; position: absolute"></asp:TextBox>
        </span>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 171px; top: 197px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 171px; top: 246px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 171px; top: 296px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 172px; top: 344px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 171px; top: 392px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhonenumber" runat="server" style="z-index: 1; left: 171px; top: 441px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 491px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 7px; top: 543px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 67px; top: 543px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
