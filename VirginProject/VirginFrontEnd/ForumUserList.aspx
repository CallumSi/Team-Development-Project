<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumUserList.aspx.cs" Inherits="VirginFrontEnd.ForumUserList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstUserListBox" runat="server" style="z-index: 1; left: 267px; top: 203px; position: absolute; height: 244px; width: 307px"></asp:ListBox>
        <asp:Label ID="lblUserFilter" runat="server" style="z-index: 1; left: 272px; top: 464px; position: absolute; margin-top: 0px" Text="Please filter by user name."></asp:Label>
        <asp:TextBox ID="txtFilterbyusername" runat="server" style="z-index: 1; left: 274px; top: 513px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 273px; top: 577px; position: absolute" Text="Add" OnClick="btnAdd_Click1" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 371px; top: 575px; position: absolute; margin-top: 1px" Text="Edit" OnClick="btnEdit_Click1" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 456px; top: 576px; position: absolute" Text="Delete" OnClick="btnDelete_Click1" />
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 503px; top: 508px; position: absolute" Text="Apply" OnClick="btnApply_Click1" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 625px; top: 508px; position: absolute" Text="Display All" OnClick="btnDisplayAll_Click1" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 267px; top: 632px; position: absolute" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
