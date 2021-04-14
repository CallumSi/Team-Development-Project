<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHACar.aspx.cs" Inherits="VirginFrontEnd.VCHACar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCarMake" runat="server" style="position: absolute; z-index: 1; left: 10px; top: 100px" Text="Make:"></asp:Label>
        <span class="auto-style1">
        <asp:Label ID="lblCarModel" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute" Text="Model:"></asp:Label>
        <asp:Label ID="lblCarEngine" runat="server" style="z-index: 1; left: 10px; top: 195px; position: absolute" Text="Engine Size (L):"></asp:Label>
        <asp:Label ID="lblCarBody" runat="server" style="z-index: 1; left: 10px; top: 245px; position: absolute" Text="Body Type:"></asp:Label>
        <asp:Label ID="lblCarColour" runat="server" style="z-index: 1; left: 10px; top: 295px; position: absolute; bottom: 270px" Text="Colour:"></asp:Label>
        <asp:Label ID="lblCarFuel" runat="server" style="z-index: 1; left: 10px; top: 345px; position: absolute" Text="Fuel Type:"></asp:Label>
        <asp:Label ID="lblCarPrice" runat="server" style="z-index: 1; left: 10px; top: 390px; position: absolute" Text="Hire Price (£):"></asp:Label>
        <asp:Label ID="lblCarRegistration" runat="server" style="z-index: 1; left: 10px; top: 440px; position: absolute" Text="Registration:"></asp:Label>
        <asp:TextBox ID="txtCarMake" runat="server" style="z-index: 1; left: 170px; top: 100px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 170px; top: 150px; position: absolute"></asp:TextBox>
        </span>
        <asp:TextBox ID="txtCarEngine" runat="server" style="z-index: 1; left: 170px; top: 195px; position: absolute"></asp:TextBox>
        <%--<asp:TextBox ID="txtCarBody" runat="server" style="z-index: 1; left: 170px; top: 245px; position: absolute"></asp:TextBox>--%>
        <asp:DropDownList ID="ddlCarBody" runat="server" style="z-index: 1; left: 170px; top: 245px; position: absolute">
            <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="Coupe"></asp:ListItem>
            <asp:ListItem Value="Convertible"></asp:ListItem>
            <asp:ListItem Value="Hatchback"></asp:ListItem>
            <asp:ListItem Value="Estate"></asp:ListItem>
            <asp:ListItem Value="Saloon"></asp:ListItem>
            <asp:ListItem Value="SUV"></asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtCarColour" runat="server" style="z-index: 1; left: 170px; top: 295px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlFuelType" runat="server" style="z-index: 1; left: 170px; top: 345px; position: absolute; right: 1225px;">
            <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="Diesel"></asp:ListItem>
            <asp:ListItem Value="Electric"></asp:ListItem>
            <asp:ListItem Value="Hybrid"></asp:ListItem>
            <asp:ListItem Value="Petrol"></asp:ListItem>
        </asp:DropDownList>
        <%--<asp:TextBox ID="txtCarFuel" runat="server" style="z-index: 1; left: 170px; top: 345px; position: absolute"></asp:TextBox>--%>
        <asp:TextBox ID="txtCarPrice" runat="server" style="z-index: 1; left: 170px; top: 390px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarRegistration" runat="server" style="z-index: 1; left: 170px; top: 440px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 495px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 545px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 65px; top: 545px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
