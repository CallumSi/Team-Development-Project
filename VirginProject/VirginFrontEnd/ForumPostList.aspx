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
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <ul>
                <li>
                    <asp:ListBox ID="lstPostlistbox" runat="server" style="z-index: 1; " Height="231px" Width="328px"></asp:ListBox>
               </li>
               <li>
                    <asp:Label ID="lblFilterByPostTitle" runat="server" style="z-index: 1;" Text="Please enter a title."></asp:Label>
                    <asp:TextBox ID="txtFilterByPostTitle" runat="server" style="z-index: 1;"></asp:TextBox>
               </li>
               <li> 
                   <asp:Button ID="btnApply" runat="server" style="z-index: 1;" Text="Apply" OnClick="btnApply_Click" />
                   <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1;" Text="Display All" OnClick="btnDisplayAll_Click" />
               </li>
                <li>
                   <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1;" Text="Add Post" />
                   <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1;" Text="Edit Post" />
                   <asp:Button ID="btnDelete" runat="server" style="z-index: 1;" Text="Delete Post" OnClick="btnDelete_Click" />
                   <asp:Button ID="btnComment" runat="server" OnClick="btnComment_Click" style="z-index: 1;" Text="Comment" />
                </li>
                 <li>
                      <asp:Label ID="lblPostError" runat="server" style="z-index: 1;"></asp:Label>
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
