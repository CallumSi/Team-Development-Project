<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAdminList.aspx.cs" Inherits="VirginFrontEnd.ForumAdminList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdminList</title>
    <link href="ForumStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
        <form id="form2" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <ul>
                    <li><asp:ListBox ID="lstForumAdmin" runat="server" OnSelectedIndexChanged="lstForumAdmin_SelectedIndexChanged" style="z-index: 1;" Height="202px" Width="442px"></asp:ListBox> </li>
                    <li>
                         <asp:Label ID="lblFilterUsername" runat="server" style="z-index: 1;" Text="Filter By User Name"></asp:Label>
                         <asp:TextBox ID="txtFilterFirstName" runat="server" style="z-index: 1;" Height="31px" Width="276px"></asp:TextBox>
                    </li>
                    <li> 
                        <asp:Button ID="btnApply" runat="server" style="z-index: 1;" Text="Apply" />
                        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1;" Text="Display All" />
                    </li>
                    <li>                   
                       <asp:Button ID="btnAdd" runat="server" style="z-index: 1; " Text="Add" OnClick="btnAdd_Click" />
                       <asp:Button ID="btnEdit" runat="server" style="z-index: 1; " Text="Edit" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; " Text="Delete" OnClick="btnDelete_Click" />
                    </li>
                    <li>
                         <asp:Label ID="lblError" runat="server" style="z-index: 1;" Text="[Error]"></asp:Label>
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
