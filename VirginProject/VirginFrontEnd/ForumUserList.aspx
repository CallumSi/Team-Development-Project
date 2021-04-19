<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumUserList.aspx.cs" Inherits="VirginFrontEnd.ForumUserList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User List page</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
        <form id="form1" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <ul>
                    <li><asp:ListBox ID="lstUserListBox" runat="server" style="z-index: 1;" Height="265px" Width="456px"></asp:ListBox> </li>
                    <li>
                        <asp:Label ID="lblUserFilter" runat="server" style="z-index: 1;" Text="Please filter by first name."></asp:Label>
                         <asp:TextBox ID="txtFilterbyuserfirstname" runat="server" style="z-index: 1;" Width="241px"></asp:TextBox>
                    </li>
                    <li>
                         <asp:Button ID="btnApply" runat="server" style="z-index: 1;" Text="Apply" OnClick="btnApply_Click1" />
                    </li>
                    <li>                   
                      <asp:Button ID="btnAdd" runat="server" style="z-index: 1;" Text="Add" OnClick="btnAdd_Click1" Visible="False" />
                      <asp:Button ID="btnEdit" runat="server" style="z-index: 1;" Text="Edit" OnClick="btnEdit_Click1" />
                      <asp:Button ID="btnDelete" runat="server" style="z-index: 1;" Text="Delete" OnClick="btnDelete_Click1" />
                    </li>
                    <li>
                         <asp:Label ID="lblError" runat="server" style="z-index: 1;"></asp:Label>
                    </li>

                </ul>
                    </article>
 
            <nav>
                Navigation links here
                <ul>
                <li>
                 <asp:Button ID="btnSignOut" runat="server" OnClick="btnSignOut_Click" style="z-index: 1;" Text="Sign Out" />
                    </li>
                <li>
                    <asp:Button ID="btnForumPost" runat="server" OnClick="btnForumPost_Click" style="z-index: 1;" Text="Forum" />
                </li>
                </ul>
            </nav>
 
            <footer>
                <div id ="FooterText">
                    © 2021 Virgin Media | All Rights Reserved
                </div>
            </footer>
             
        </form>
    </body>
</html>
