<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHAHire.aspx.cs" Inherits="VirginFrontEnd.VCHAHire" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Hire Details</title>
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

        <span class="auto-style1">
        <asp:Label ID="lblCarID" runat="server" style="z-index: 1; left: 200px; top: 150px; position: absolute" Text="Car Identification:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 200px; top: 195px; position: absolute" Text="Customer Identification:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblHireCollectionDate" runat="server" style="z-index: 1; left: 200px; top: 245px; position: absolute" Text="Car Collection Date:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblHireReturnDate" runat="server" style="z-index: 1; left: 200px; top: 295px; position: absolute; bottom: 270px" Text="Car Return Date:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblHireCollectionReturnLocation" runat="server" style="z-index: 1; left: 200px; top: 345px; position: absolute" Text="Car Collection & Return Address:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblHireStatus" runat="server" style="z-index: 1; left: 200px; top: 390px; position: absolute" Text="Hire Status:" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtCarID" runat="server" style="z-index: 1; left: 560px; top: 150px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 560px; top: 195px; position: absolute"></asp:TextBox>
        </span>
        <asp:TextBox ID="txtHireCollectionDate" runat="server" style="z-index: 1; left: 560px; top: 245px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHireReturnDate" runat="server" style="z-index: 1; left: 560px; top: 295px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlHireLocation" runat="server" style="z-index: 1; left: 560px; top: 345px; position: absolute; right: 1225px;">
            <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="14-16 Gulliard Lane, Leicester, LE2 5RE"></asp:ListItem>
            <asp:ListItem Value="Park Road, Loughborough, LE11 2HE"></asp:ListItem>
            <asp:ListItem Value="30 Glaxon Street, Shropshire, SH7 3FG"></asp:ListItem>
            <asp:ListItem Value="1 Byron Street, Leicester, LE1 3QD"></asp:ListItem>
            <asp:ListItem Value="107-115 Attleborough Road, Nuneaton, CV11 4JQ"></asp:ListItem>
            <asp:ListItem Value="127-139 Foleshill Road, Coventry, CV1 4LF"></asp:ListItem>
            <asp:ListItem Value="St Andrew's Road, Northampton, NN1 2PQ"></asp:ListItem>
            <asp:ListItem Value="1 Crucible Road, Corby, NN17 5TS"></asp:ListItem>
            <asp:ListItem Value="1 Royal Scot Road, Derby, DE24 8AJ"></asp:ListItem>
            <asp:ListItem Value="5 Tamworth Road, Tamworth, STS B783RH"></asp:ListItem>
            <asp:ListItem Value="London Road, Daventry, NN11 4NR"></asp:ListItem>
            <asp:ListItem Value="Crossfield Road, Lichfield, WS13 6RJ"></asp:ListItem>
            <asp:ListItem Value="Unit 17a St Marys Road, Leamington Spa, CV31 1PR"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlHireStatus" runat="server" style="z-index: 1; left: 560px; top: 390px; position: absolute; right: 1225px;">
            <asp:ListItem Value="Pending Confirmation"></asp:ListItem>
            <asp:ListItem Value="Accepted"></asp:ListItem>
            <asp:ListItem Value="Declined"></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 450px; position: absolute" Text="Car and Customer identification data must pertain to active records, failure to supply correct data will result in the failure of system functionality." ForeColor="White"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 200px; top: 555px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 255px; top: 555px; position: absolute; right: 1240px;" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
