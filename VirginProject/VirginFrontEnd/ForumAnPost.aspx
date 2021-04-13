<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumAnPost.aspx.cs" Inherits="VirginFrontEnd.ForumAnPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ForumAnPost</title>
     <link href="VirginProject.css" rel="stylesheet" type="text/css" />
</head>
<body>
        <form id="form1" runat="server">
 
             <header>
               <h2> Virgin Media </h2> 
            </header>
 
            <article>
                <ul>
             
                <li>
                    
                      <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 463px; top: 116px; position: absolute; height: 34px; width: 431px"></asp:TextBox>
              
                     <asp:TextBox ID="txtMessage" runat="server" style="z-index: 1; left: 464px; top: 194px; position: absolute; height: 188px; width: 443px; margin-top: 0px"></asp:TextBox>
                    
                     <asp:Label ID="lblPostError" runat="server" style="z-index: 1; left: 440px; top: 511px; position: absolute" Text="[lblError]"></asp:Label>
                   
               </li>
              
                 <li> 
                      <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 515px; top: 419px; position: absolute; height: 34px; width: 97px" Text="OK" />
                     <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 662px; top: 419px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
                </li>
                      
                 <li> 
                           <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 732px; top: 143px; position: absolute" Text="Title"></asp:Label>
                      <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 688px; position: absolute; top: 236px" Text="Message"></asp:Label>

                 </li>

                 <li>
                  
                </li>
                <li>
                   
          

               </li>
                    <li>                
                           
            

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
