<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHACarViewerCE.aspx.cs" Inherits="VirginFrontEnd.VCHACarViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Car Spec</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCarMake" runat="server" style="position: absolute; z-index: 1; left: 200px; top: 100px" Text="Make:"></asp:Label>
        <span class="auto-style1">
        <asp:Label ID="lblCarModel" runat="server" style="z-index: 1; left: 200px; top: 150px; position: absolute" Text="Model:"></asp:Label>
        <asp:Label ID="lblCarEngine" runat="server" style="z-index: 1; left: 200px; top: 195px; position: absolute" Text="Engine Size (L):"></asp:Label>
        <asp:Label ID="lblCarBody" runat="server" style="z-index: 1; left: 200px; top: 245px; position: absolute" Text="Body Type:"></asp:Label>
        <asp:Label ID="lblCarColour" runat="server" style="z-index: 1; left: 200px; top: 295px; position: absolute; bottom: 270px" Text="Colour:"></asp:Label>
        <asp:Label ID="lblCarFuel" runat="server" style="z-index: 1; left: 200px; top: 345px; position: absolute" Text="Fuel Type:"></asp:Label>
        <asp:Label ID="lblCarPrice" runat="server" style="z-index: 1; left: 200px; top: 390px; position: absolute" Text="Hire Price (£):"></asp:Label>
        <asp:Label ID="lblCarRegistration" runat="server" style="z-index: 1; left: 200px; top: 440px; position: absolute" Text="Registration:"></asp:Label>
        <asp:TextBox ID="txtCarMake" runat="server" style="z-index: 1; left: 360px; top: 100px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 360px; top: 150px; position: absolute"></asp:TextBox>
        </span>
        <asp:TextBox ID="txtCarEngine" runat="server" style="z-index: 1; left: 360px; top: 195px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarBody" runat="server" style="z-index: 1; left: 360px; top: 245px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarColour" runat="server" style="z-index: 1; left: 360px; top: 295px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarFuel" runat="server" style="z-index: 1; left: 360px; top: 345px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarPrice" runat="server" style="z-index: 1; left: 360px; top: 390px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarRegistration" runat="server" style="z-index: 1; left: 360px; top: 440px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 495px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnHire" runat="server" OnClick="btnHire_Click" style="z-index: 1; left: 200px; top: 545px; position: absolute" Text="Hire" />
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 275px; top: 545px; position: absolute" Text="Back" OnClick="btnBack_Click" />
    </form>
</body>
</html>
