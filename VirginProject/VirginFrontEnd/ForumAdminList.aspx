﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAdminList.aspx.cs" Inherits="VirginFrontEnd.ForumAdminList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdminList</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form2" runat="server">

        <header>
            <h2>Virgin Media </h2>
        </header>

        <article>
            <h1>Admin page</h1>
            <ul>
                <li>
                    <asp:ListBox ID="lstForumAdmin" runat="server" OnSelectedIndexChanged="lstForumAdmin_SelectedIndexChanged" Style="z-index: 1;" Height="202px" Width="442px"></asp:ListBox>
                </li>
                <li>
                    <asp:Label ID="lblFilterFirstName" runat="server" Style="z-index: 1;" Text="Filter By First Name"></asp:Label>
                    <asp:TextBox ID="txtFilterFirstName" runat="server" Style="z-index: 1;" Height="31px" Width="298px"></asp:TextBox>
                </li>
                <li>
                    <asp:Button ID="btnApply" runat="server" Style="z-index: 1;" Text="Apply" OnClick="btnApply_Click1" CssClass="navButton" />
                </li>
                <li>
                    <asp:Button ID="btnAdd" runat="server" Style="z-index: 1;" Text="Add" OnClick="btnAdd_Click" CssClass="navButton" />
                    <asp:Button ID="btnEdit" runat="server" Style="z-index: 1;" Text="Edit" OnClick="btnEdit_Click" CssClass="navButton" />
                    <asp:Button ID="btnDelete" runat="server" Style="z-index: 1;" Text="Delete" OnClick="btnDelete_Click" CssClass="navButton" />
                </li>
                <li>
                    <asp:Label ID="lblError" runat="server" Style="z-index: 1;"></asp:Label>
                </li>

            </ul>
        </article>

        <nav>
            <asp:Button ID="btnAdminHome" runat="server" Style="z-index: 1;" Text="Admin Home" OnClick="btnAdminHome_Click" CssClass="Button" />
            <asp:Button runat="server" Style="z-index: 1;" Text="Sign Out" OnClick="Unnamed1_Click" CssClass="Button" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

    </form>
</body>
</html>
