<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHHireList.aspx.cs" Inherits="VirginFrontEnd.VCHHireList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VCH - Hire List</title>
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

        <asp:Button ID="btnApply" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 200px; top: 485px; position: absolute; width: 173px;" Text="Apply Filter" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" Height="40px" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 400px; top: 485px; position: absolute;" Text="Display All Locations" />
        <asp:Button ID="btnAdd" runat="server" Height="40px" Width="75px" OnClick="btnAdd_Click" style="z-index: 1; left: 200px; top: 540px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 300px; top: 540px; position: absolute; right: 1272px;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 400px; top: 540px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:TextBox ID="txtBxSearch" runat="server" Height="30px" style="z-index: 1; left: 520px; top: 440px;  position: absolute"></asp:TextBox>
        <p>
        <asp:ListBox ID="lstHires" runat="server" Height="300px" Width="1250px" style="z-index: 1; left: 200px; top: 100px; position: absolute"></asp:ListBox>
        <asp:Label ID="lblHireLocation" runat="server" style="z-index: 1; left: 200px; top: 440px; position: absolute" Text="Please Enter a Virgin Car Hire Location" ForeColor="White"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 405px; position: absolute" Text="[lblError]" ForeColor="White"></asp:Label>
    </form>
</body>
</html>
