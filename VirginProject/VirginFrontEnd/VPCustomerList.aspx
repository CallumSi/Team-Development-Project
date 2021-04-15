<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPCustomerList.aspx.cs" Inherits="VirginFrontEnd.VPCustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomer" runat="server" style="z-index: 1; left: 16px; top: 58px; position: absolute; height: 280px; width: 448px; margin-top: 0px"></asp:ListBox>
        <asp:Label ID="lblEnterFirstName" runat="server" style="z-index: 1; left: 27px; top: 345px; position: absolute" Text="Please enter the customer's first name"></asp:Label>
        <asp:TextBox ID="txtSearchFirstName" runat="server" style="z-index: 1; left: 26px; top: 375px; position: absolute; width: 217px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 412px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 27px; top: 445px; position: absolute; width: 67px" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 116px; top: 444px; position: absolute" Text="DisplayAll" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 27px; top: 485px; position: absolute; width: 65px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 110px; top: 485px; position: absolute; width: 65px; right: 490px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 192px; top: 485px; position: absolute; width: 70px" Text="Delete" />
    </form>
</body>
</html>
