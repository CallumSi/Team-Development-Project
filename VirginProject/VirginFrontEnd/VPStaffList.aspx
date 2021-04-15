<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VPStaffList.aspx.cs" Inherits="VirginFrontEnd.VPStaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 6px; top: 47px; position: absolute; height: 276px; width: 484px"></asp:ListBox>
        <asp:Label ID="lblEnterFirstName" runat="server" style="z-index: 1; left: 14px; top: 324px; position: absolute" Text="Please enter the staff's first name "></asp:Label>
        <asp:TextBox ID="txtSearchFirstName" runat="server" style="z-index: 1; left: 15px; top: 351px; position: absolute; width: 206px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 389px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 20px; top: 432px; position: absolute; width: 65px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 92px; top: 432px; position: absolute" Text="DisplayAll" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 478px; position: absolute; width: 60px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 96px; top: 479px; position: absolute; width: 62px" Text="Edit" />
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 171px; top: 478px; position: absolute; width: 70px" Text="Delete" />
        </p>
    </form>
</body>
</html>
