<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumCommentList.aspx.cs" Inherits="VirginFrontEnd.ForumCommentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CommentList</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
        <form id="form1" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <ul>
                <li>
                   
                    <asp:ListBox ID="lstComment" runat="server" style="z-index: 1;" Height="278px" Width="593px"></asp:ListBox>
                   
               </li>
               <li>
                    <asp:Label ID="lblComment" runat="server" style="z-index: 1;" Text="Please enter a comment message"></asp:Label>
                    <asp:TextBox ID="txtFilterByComment" runat="server" style="z-index: 1;"></asp:TextBox>
               </li>
               <li>               
                    <asp:Button ID="btnApply" runat="server" style="z-index: 1;" Text="Apply" OnClick="btnApply_Click" />
                    <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1;" Text="DisplayAll" OnClick="btnDisplayAll_Click" />
               </li>
               <li>
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1;" Text="Add New Post" />
                    <asp:Button ID="btnEdit" runat="server" style="z-index: 1;" Text="Edit Comment" OnClick="btnEdit_Click" />
                   <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: " Text="Delete Comment" OnClick="btnDelete_Click" />
                </li>
                 <li>
                     <asp:Label ID="lblError" runat="server" style="z-index: 1; "></asp:Label>
                 </li>
                  
   
                </ul>
            </article>
 
            <nav>
                Navigation links here
            </nav>
 
            <footer>
                <div id ="FooterText">
                    © 2021 Virgin Media | All Rights Reserved
                </div>
            </footer>
             
        </form>
    </body>
</html>
