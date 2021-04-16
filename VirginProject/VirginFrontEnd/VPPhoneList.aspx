<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPPhoneList.aspx.cs" Inherits="VirginFrontEnd.VPPhoneList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstPhone" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 281px; width: 505px"></asp:ListBox>
        <asp:Label ID="lblEnterAPhone" runat="server" style="z-index: 1; left: 17px; top: 331px; position: absolute" Text="Please enter a phone"></asp:Label>
        <asp:TextBox ID="txtSearchPhone" runat="server" style="z-index: 1; left: 18px; top: 353px; position: absolute; width: 212px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 23px; top: 427px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 131px; top: 427px; position: absolute" Text="DisplayAll" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 25px; top: 464px; position: absolute; width: 55px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 95px; top: 464px; position: absolute; width: 56px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 166px; top: 464px; position: absolute" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 397px; position: absolute" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
