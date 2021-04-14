<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHAHire.aspx.cs" Inherits="VirginFrontEnd.VCHAHire" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblHireID" runat="server" style="position: absolute; z-index: 1; left: 10px; top: 100px" Text="Hire Identification:"></asp:Label>
        <span class="auto-style1">
        <asp:Label ID="lblCarID" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute" Text="Car Identification:"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 195px; position: absolute" Text="Customer Identification:"></asp:Label>
        <asp:Label ID="lblHireCollectionDate" runat="server" style="z-index: 1; left: 10px; top: 245px; position: absolute" Text="Car Collection Date:"></asp:Label>
        <asp:Label ID="lblHireReturnDate" runat="server" style="z-index: 1; left: 10px; top: 295px; position: absolute; bottom: 270px" Text="Car Return Date:"></asp:Label>
        <asp:Label ID="lblHireCollectionReturnLocation" runat="server" style="z-index: 1; left: 10px; top: 345px; position: absolute" Text="Car Collection & Return Address:"></asp:Label>
        <asp:Label ID="lblDriverAge" runat="server" style="z-index: 1; left: 10px; top: 390px; position: absolute" Text="Driver Age:"></asp:Label>
        <asp:Label ID="lblDriverLicenseNumber" runat="server" style="z-index: 1; left: 10px; top: 440px; position: absolute" Text="Driver's License Number:"></asp:Label>
        <asp:Label ID="lblHireIDInput" runat="server" style="z-index: 1; left: 370px; top: 100px; position: absolute" Text="[lblHireID]"></asp:Label>
        <asp:Label ID="lblCarIDInput" runat="server" style="z-index: 1; left: 370px; top: 150px; position: absolute" Text="[lblCarID]"></asp:Label>
            <asp:Label ID="lblCustomerIDInput" runat="server" style="z-index: 1; left: 370px; top: 195px; position: absolute" Text="[lblCustomerID]"></asp:Label>
        </span>
        <asp:TextBox ID="txtHireCollectionDate" runat="server" style="z-index: 1; left: 370px; top: 245px; position: absolute"></asp:TextBox>
        <%--<asp:DropDownList ID="ddlCarBody" runat="server" style="z-index: 1; left: 370px; top: 245px; position: absolute">
            <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="Coupe"></asp:ListItem>
            <asp:ListItem Value="Convertible"></asp:ListItem>
            <asp:ListItem Value="Hatchback"></asp:ListItem>
            <asp:ListItem Value="Estate"></asp:ListItem>
            <asp:ListItem Value="Saloon"></asp:ListItem>
            <asp:ListItem Value="SUV"></asp:ListItem>
        </asp:DropDownList>--%>
        <asp:TextBox ID="txtHireReturnDate" runat="server" style="z-index: 1; left: 370px; top: 295px; position: absolute"></asp:TextBox>
        <%--<asp:DropDownList ID="ddlFuelType" runat="server" style="z-index: 1; left: 370px; top: 345px; position: absolute; right: 1225px;">
            <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="Diesel"></asp:ListItem>
            <asp:ListItem Value="Electric"></asp:ListItem>
            <asp:ListItem Value="Hybrid"></asp:ListItem>
            <asp:ListItem Value="Petrol"></asp:ListItem>
        </asp:DropDownList>--%>
        <asp:TextBox ID="txtHireCollectionReturnLocation" runat="server" style="z-index: 1; left: 370px; top: 345px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDriverAge" runat="server" style="z-index: 1; left: 370px; top: 390px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDriverLicenseNumber" runat="server" style="z-index: 1; left: 370px; top: 440px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 495px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 545px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 65px; top: 545px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
