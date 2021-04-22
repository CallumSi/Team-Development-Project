<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHAHireCE.aspx.cs" Inherits="VirginFrontEnd.VCHAHireCE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Hire Request</title>
    <link href="VCHStyleCustomer.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header>
            <h2> Create A Hire Request
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" style="z-index: 1; left: 1355px; top: 40px; position: absolute; height: 35px; width: 100px;" />
            </h2> 
        </header>

        <nav>
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; top: 50px; position: absolute; height: 65px; width: 160px;" OnClick="btnHome_Click" Text="Home" />
            <asp:Button ID="btnAccount" runat="server" style="z-index: 1; top: 150px; position: absolute; height: 65px; width: 160px;" OnClick="btnAccount_Click" Text="Access Account" />
        </nav>

        <section>
        <asp:Label ID="lblCarID" runat="server" style="z-index: 1; left: 200px; top: 150px; position: absolute" Text="Car Identification:"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 200px; top: 195px; position: absolute" Text="Customer Identification:"></asp:Label>
        <asp:Label ID="lblHireCollectionDate" runat="server" style="z-index: 1; left: 200px; top: 245px; position: absolute" Text="Car Collection Date:"></asp:Label>
        <asp:Label ID="lblHireReturnDate" runat="server" style="z-index: 1; left: 200px; top: 295px; position: absolute; bottom: 847px; width: 335px;" Text="Car Return Date:"></asp:Label>
        <asp:Label ID="lblHireCollectionReturnLocation" runat="server" style="z-index: 1; left: 200px; top: 345px; position: absolute" Text="Car Collection & Return Address:"></asp:Label>
        <asp:Label ID="lblHireStatus" runat="server" style="z-index: 1; left: 200px; top: 390px; position: absolute; width: 155px;" Text="Hire Status:"></asp:Label>
        <asp:Label ID="lblCarIDDisplay" runat="server" style="z-index: 1; left: 560px; top: 150px; position: absolute" Text="[CarID]"></asp:Label>
        <asp:label ID="lblCustomerIDDisplay" runat="server" style="z-index: 1; left: 560px; top: 195px; position: absolute" Text="[CustomerID]"></asp:label>
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
        <asp:label ID="lblHireStatusDisplay" runat="server" style="z-index: 1; left: 560px; top: 390px; position: absolute; right: 53px;" Text="Pending Confirmation"></asp:label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 450px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblInfo" runat="server" style="z-index: 1; left: 200px; top: 500px; position: absolute" Text="Car and Customer identification data must pertain to active records, failure to supply correct data will result in the failure of system functionality."></asp:Label>
        <asp:Label ID="lblInfo2" runat="server" style="z-index: 1; left: 200px; top: 555px; position: absolute" Text="You will be notified via Email and SMS regarding your Hire Requests Status."></asp:Label>
        <asp:Button ID="btnHire" runat="server" OnClick="btnHire_Click" style="z-index: 1; left: 200px; top: 605px; position: absolute" Text="Confirm Hire Request" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 380px; top: 605px; position: absolute; right: 1240px;" Text="Cancel" OnClick="btnCancel_Click" />
        </section>

    </form>
</body>
</html>
