﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHCustomerHomeCE.aspx.cs" Inherits="VirginFrontEnd.VCHCustomerHomeCE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Car Hire - Home</title>
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
            Navigation links here
        </nav>

        <asp:ListBox ID="lstCars" runat="server" Height="300px" Width="800px" style="z-index: 1; left: 200px; top: 100px; position: absolute"></asp:ListBox>
        <asp:Button ID="btnApply" runat="server" Height="40px" style="z-index: 1; left: 200px; top: 485px; position: absolute; width: 173px;" Text="Apply Filter" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" Height="40px" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 500px; top: 485px; position: absolute; left: 400px;" Text="Display All Cars" />
        <asp:Button ID="btnView" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 200px; top: 540px; position: absolute"  Text="View" OnClick="btnView_Click" />
        <asp:Label ID="lblHire" runat="server" Height="40px" style="z-index: 1; left: 300px; top: 540px; position: absolute; right: 1000px; width: 495px;" Text="To request a car hire, select a car from the list and open it's view page." ForeColor="White"></asp:Label>
        <p>
        <asp:TextBox ID="txtBxSearch" runat="server" Height="30px" style="z-index: 1; left: 470px; top: 440px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCarBody" runat="server" style="z-index: 1; left: 200px; top: 440px; position: absolute" Text="Filter Cars by Body Type:" ForeColor="White"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 405px; position: absolute" Text="[lblError]" ForeColor="White"></asp:Label>
        <p>
        </p>
        <footer>
            <div id ="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>