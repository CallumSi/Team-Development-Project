<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCHCustomerHomeCE.aspx.cs" Inherits="VirginFrontEnd.VCHCustomerHomeCE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virgin Car Hire - Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCars" runat="server" Height="300px" Width="800px" style="z-index: 1; left: 200px; top: 100px; position: absolute"></asp:ListBox>
        <asp:Button ID="btnApply" runat="server" Height="40px" style="z-index: 1; left: 200px; top: 485px; position: absolute; width: 173px;" Text="Apply Filter" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" Height="40px" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 500px; top: 485px; position: absolute; left: 400px;" Text="Display All Cars" />
        <asp:Button ID="btnView" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 200px; top: 540px; position: absolute"  Text="Veiw" OnClick="btnView_Click" />
        <asp:Button ID="btnHire" runat="server" Height="40px" Width="75px" style="z-index: 1; left: 300px; top: 540px; position: absolute; right: 1270px;" Text="Hire" OnClick="btnHire_Click" />
        <p>
        <asp:TextBox ID="txtBxSearch" runat="server" Height="30px" style="z-index: 1; left: 470px; top: 440px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCarBody" runat="server" style="z-index: 1; left: 200px; top: 440px; position: absolute" Text="Filter Cars by Body Type:"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 405px; position: absolute" Text="[lblError]"></asp:Label>
        <p>
        </p>
    </form>
</body>
</html>
