<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHACarViewerCE.aspx.cs" Inherits="VirginFrontEnd.VCHACarViewer" %>

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
            <h2> Car Viewer 
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" style="z-index: 1; left: 1355px; top: 40px; position: absolute; height: 35px; width: 100px;" />
            </h2> 
        </header>

        <nav>
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; top: 50px; position: absolute; height: 65px; width: 160px;" OnClick="btnHome_Click" Text="Home" />
            <asp:Button ID="btnAccount" runat="server" style="z-index: 1; top: 150px; position: absolute; height: 65px; width: 160px;" OnClick="btnAccount_Click" Text="Access Account" />
        </nav>

        <section>
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
        <asp:TextBox ID="txtCarBody" runat="server" style="z-index: 1; left: 445px; top: 245px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarColour" runat="server" style="z-index: 1; left: 445px; top: 295px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarFuel" runat="server" style="z-index: 1; left: 445px; top: 345px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarPrice" runat="server" style="z-index: 1; left: 445px; top: 390px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCarRegistration" runat="server" style="z-index: 1; left: 445px; top: 440px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 495px; position: absolute" Text="[lblError]" ForeColor="White"></asp:Label>
        <asp:Button ID="btnHire" runat="server" OnClick="btnHire_Click" style="z-index: 1; left: 200px; top: 545px; position: absolute" Text="Request Hire" />
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 400px; top: 545px; position: absolute" Text="Back" OnClick="btnBack_Click" />
        </section>
    </form>
</body>
</html>
