<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumPostList.aspx.cs" Inherits="VirginFrontEnd.ForumPostList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PostList</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media </h2>
        </header>

        <article>
            <h1>All Posts</h1>
            <ul>
                <li>
                    <asp:ListBox ID="lstPostlistbox" runat="server" Style="z-index: 1;" Height="231px" Width="419px"></asp:ListBox>
                </li>
                <li>
                    <asp:Label ID="lblFilterByPostTitle" runat="server" Style="z-index: 1;" Text="Please enter a title."></asp:Label>
                    <asp:TextBox ID="txtFilterByPostTitle" runat="server" Style="z-index: 1;" Width="283px"></asp:TextBox>
                </li>
                <li>
                    <asp:Button ID="btnApply" runat="server" Style="z-index: 1;" Text="Apply" OnClick="btnApply_Click" CssClass="navButton" />
                    <asp:Button ID="btnDisplayAll" runat="server" Style="z-index: 1;" Text="Display All" OnClick="btnDisplayAll_Click" CssClass="navButton" />
                </li>
                <li>
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Style="z-index: 1;" Text="Add Post" CssClass="navButton" />
                    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Style="z-index: 1;" Text="Edit Post" CssClass="navButton" />
                    <asp:Button ID="btnDelete" runat="server" Style="z-index: 1;" Text="Delete Post" OnClick="btnDelete_Click" CssClass="navButton" />
                    <asp:Button ID="btnComment" runat="server" OnClick="btnComment_Click" Style="z-index: 1;" Text="Comment" CssClass="navButton" />
                </li>
                <li>
                    <asp:Label ID="lblPostError" runat="server" Style="z-index: 1;"></asp:Label>
                </li>


            </ul>
        </article>

        <nav>
            <asp:Button ID="btnAccount" runat="server" OnClick="btnAccount_Click" Style="z-index: 1; position: absolute; top: 51px; left: 65px;" Text="User Account" CssClass="navButton" Font-Bold="True" Font-Size="Medium" ForeColor="Black" />
            <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" Style="z-index: 1; position: absolute; top: 146px; left: 102px;" Text="Log Out" CssClass="navButton" Font-Bold="True" Font-Size="Medium" ForeColor="Black" />

        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>

    </form>
</body>
</html>
