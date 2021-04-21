<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHACar.aspx.cs" Inherits="VirginFrontEnd.VCHACar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Car Details</title>
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
            <asp:Button ID="btnStaff" runat="server" style="z-index: 1; top: 50px; position: absolute; height: 65px; width: 160px;" OnClick="btnStaff_Click" Text="Access Staff" />
            <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; top: 150px; position: absolute; height: 65px; width: 160px;" OnClick="btnCustomer_Click" Text="Access Customer" />
            <asp:Button ID="btnCar" runat="server" style="z-index: 1; top: 250px; position: absolute; height: 65px; width: 160px;" OnClick="btnCar_Click" Text="Access Cars" />
            <asp:Button ID="btnHire" runat="server" style="z-index: 1; top: 350px; position: absolute; height: 65px; width: 160px;" OnClick="btnHire_Click" Text="Access Hires" />
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; top: 450px; position: absolute; height: 65px; width: 160px;" OnClick="btnHome_Click" Text="Home" />
        </nav>

        <asp:Label ID="lblCarMake" runat="server" style="position: absolute; z-index: 1; left: 200px; top: 100px" Text="Make:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblCarModel" runat="server" style="z-index: 1; left: 200px; top: 150px; position: absolute" Text="Model:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblCarEngine" runat="server" style="z-index: 1; left: 200px; top: 195px; position: absolute" Text="Engine Size (L):" ForeColor="White"></asp:Label>
        <asp:Label ID="lblCarBody" runat="server" style="z-index: 1; left: 200px; top: 245px; position: absolute" Text="Body Type:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblCarColour" runat="server" style="z-index: 1; left: 200px; top: 295px; position: absolute; bottom: 270px" Text="Colour:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblCarFuel" runat="server" style="z-index: 1; left: 200px; top: 345px; position: absolute" Text="Fuel Type:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblCarPrice" runat="server" style="z-index: 1; left: 200px; top: 390px; position: absolute" Text="Hire Price (£):" ForeColor="White"></asp:Label>
        <asp:Label ID="lblCarRegistration" runat="server" style="z-index: 1; left: 200px; top: 440px; position: absolute" Text="Registration:" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtCarMake" runat="server" style="z-index: 1; left: 445px; top: 100px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 445px; top: 150px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarEngine" runat="server" style="z-index: 1; left: 445px; top: 195px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlCarBody" runat="server" style="z-index: 1; left: 445px; top: 245px; position: absolute">
            <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="Coupe"></asp:ListItem>
            <asp:ListItem Value="Convertible"></asp:ListItem>
            <asp:ListItem Value="Hatchback"></asp:ListItem>
            <asp:ListItem Value="Estate"></asp:ListItem>
            <asp:ListItem Value="Saloon"></asp:ListItem>
            <asp:ListItem Value="SUV"></asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtCarColour" runat="server" style="z-index: 1; left: 445px; top: 295px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlFuelType" runat="server" style="z-index: 1; left: 445px; top: 345px; position: absolute; right: 1225px;">
            <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="Diesel"></asp:ListItem>
            <asp:ListItem Value="Electric"></asp:ListItem>
            <asp:ListItem Value="Hybrid"></asp:ListItem>
            <asp:ListItem Value="Petrol"></asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtCarPrice" runat="server" style="z-index: 1; left: 445px; top: 390px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarRegistration" runat="server" style="z-index: 1; left: 445px; top: 440px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 495px; position: absolute" Text="[lblError]" ForeColor="White"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 200px; top: 545px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 255px; top: 545px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
