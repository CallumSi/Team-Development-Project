<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAdminList.aspx.cs" Inherits="VirginFrontEnd.ForumAdminList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstForumAdmin" runat="server" OnSelectedIndexChanged="lstForumAdmin_SelectedIndexChanged" style="z-index: 1; left: 486px; top: 142px; position: absolute; height: 226px; width: 270px; margin-top: 11px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 492px; top: 479px; position: absolute; margin-top: 0px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 589px; top: 480px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 679px; top: 480px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="lblFilterUsername" runat="server" style="z-index: 1; left: 275px; top: 413px; position: absolute" Text="Filter By User Name"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 799px; top: 405px; position: absolute" Text="Apply" OnClick="btnApply_Click" />
        <asp:TextBox ID="txtFilterFirstName" runat="server" style="z-index: 1; left: 493px; top: 412px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 915px; top: 406px; position: absolute" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 424px; top: 578px; position: absolute" Text="[Error]"></asp:Label>
    </form>
</body>
</html>
