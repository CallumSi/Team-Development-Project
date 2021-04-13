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
        <asp:Label ID="lblCarMake" runat="server" style="position: absolute; z-index: 1; left: 8px; top: 98px" Text="Car Make:"></asp:Label>
        <span class="auto-style1">
        <asp:Label ID="lblCarModel" runat="server" style="z-index: 1; left: 7px; top: 147px; position: absolute" Text="Car Model:"></asp:Label>
        <asp:Label ID="lblCarEngine" runat="server" style="z-index: 1; left: 6px; top: 195px; position: absolute" Text="Engine Size (L):"></asp:Label>
        <asp:Label ID="lblCarBody" runat="server" style="z-index: 1; left: 6px; top: 244px; position: absolute" Text="Body Type:"></asp:Label>
        <asp:Label ID="lblCarColour" runat="server" style="z-index: 1; left: 6px; top: 294px; position: absolute; bottom: 270px" Text="Colour:"></asp:Label>
        <asp:Label ID="lblCarFuel" runat="server" style="z-index: 1; left: 8px; top: 342px; position: absolute" Text="Fuel Type:"></asp:Label>
        <asp:Label ID="lblCarPrice" runat="server" style="z-index: 1; left: 5px; top: 391px; position: absolute" Text="Hire Price (£):"></asp:Label>
        <asp:Label ID="lblCarRegistration" runat="server" style="z-index: 1; left: 6px; top: 439px; position: absolute" Text="Car Registration:"></asp:Label>
        <asp:TextBox ID="txtCarMake" runat="server" style="z-index: 1; left: 172px; top: 100px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 172px; top: 149px; position: absolute"></asp:TextBox>
        </span>
        <asp:TextBox ID="txtCarEngine" runat="server" style="z-index: 1; left: 171px; top: 197px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarBody" runat="server" style="z-index: 1; left: 171px; top: 246px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarColour" runat="server" style="z-index: 1; left: 171px; top: 296px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarFuel" runat="server" style="z-index: 1; left: 172px; top: 344px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarPrice" runat="server" style="z-index: 1; left: 171px; top: 392px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarRegistration" runat="server" style="z-index: 1; left: 171px; top: 441px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 491px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 7px; top: 543px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 67px; top: 543px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
