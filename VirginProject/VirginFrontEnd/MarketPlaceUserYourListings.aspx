﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketPlaceUserYourListings.aspx.cs" Inherits="VirginFrontEnd.MarketPlaceUserYourListings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

        <head id="Head1" runat="server">
        <title>Sample Master Page</title>
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
                          <asp:Label ID="Label7" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                          <asp:Label ID="Label4" runat="server" style="z-index: 1;"></asp:Label>
                       </li>
                       <li><asp:Button ID="Button1" CssClass="navButton" runat="server" style="z-index: 1;" Text="Sell" OnClick="btnClickHere_Click" />
                           <asp:Button ID="Button2" CssClass="navButton" runat="server" style="z-index: 1;" Text="MyAccount" OnClick="btnMyAccount_Click" />
                       </li>
                                      
                    
                 </ul>
              
               <asp:Label ID="Label1" runat="server" style="z-index: 1; " Text="Your Listings"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1;"></asp:Label>
     
      
                <br />
           <asp:ListBox ID="lstYourListings" runat="server" style="z-index: 1; height: 184px; width: 440px; margin-top: 0px"></asp:ListBox>
                <br />
           <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1;" Text="Edit" />
           <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1;" Text="Delete" />
           <asp:Label ID="lblError" runat="server" style="z-index: 1;"></asp:Label>
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
