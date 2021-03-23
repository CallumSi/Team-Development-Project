<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketplaceHome.aspx.cs" Inherits="VirginFrontEnd.MarketplaceHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="VirginProject.css" rel="stylesheet" />

</head>
<body>
        
    <form id="form1" runat="server">
             <header>
               <h2> Virgin Media </h2> 
            </header>
          
          
             <article>
                 <ul>
       
                      <li>
                          <asp:Label ID="Label3" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                          <asp:Label ID="lblEmail" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                       </li>
                          <li><asp:Button ID="Button1" CssClass="navButton" runat="server" style="z-index: 1;" Text="Sell" OnClick="btnClickHere_Click" />
                              <asp:Button ID="Button6" CssClass="navButton" runat="server" style="z-index: 1;" Text="MyAccount" OnClick="btnMyAccount_Click" />
                              <asp:Button ID="btnHome" CssClass="navButton" runat="server" style="z-index: 1;" Text="Home" OnClick="btnHome_Click" />
                          </li>
                     
                    
                     
                 </ul>

                           <br />
                          <asp:Label ID="Label1" runat="server" style="z-index: 1;" Text="Marketplace Home"></asp:Label>             
                          <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1;"></asp:TextBox>
                          <asp:Button ID="btnSearch" CssClass="navButton" runat="server" style="z-index: 1;" Text="Search" OnClick="btnSearch_Click" />
                            
                 <ul>
                    <li>
                     <asp:Button ID="Button2" CssClass="navButton" runat="server" style="z-index: 1;" Text="All listings" /></li> 
                     <li><asp:Button ID="Button3" CssClass="navButton" runat="server" style="z-index: 1;" Text="Accepts offers"/></li>
                     <li><asp:Button ID="Button4" CssClass="navButton" runat="server" style="z-index: 1;" Text="Auction" /></li>
                     <li><asp:Button ID="Button5" CssClass="navButton" runat="server" style="z-index: 1;" Text="Buy it now" /></li>
                 </ul>                            
                 <%
                    //create an instance of the Listing Colleciton
                    VirginClassLibrary.clsMarketplaceListingCollection MyListings = new VirginClassLibrary.clsMarketplaceListingCollection();
                    //create an index variable
                    Int32 Index = 0;
                    //get the count of records
                    Int32 RecordCount = MyListings.Count;
                    //loop through each record
                    %>
                    <ul class="Listings">
                  
                    <%
                    while(Index < RecordCount)
                    {
                        %>
                        <li>
                            <%
                            //write a listing to the browser
                            Response.Write(MyListings.ListingList[Index].ListingName);
                            Response.Write("<br>");
                            Response.Write("<img src='" + MyListings.ListingList[Index].Img+ "'/>");
                            Response.Write("<br>");
                            Response.Write("Price: £" + MyListings.ListingList[Index].Price);
                            Response.Write("<br>");
                            Response.Write("Ends:" + MyListings.ListingList[Index].CloseDate);
                            Response.Write("<br>");
                            %>
                            
                            <a href="MarketplaceListingViewer.aspx?ListingID=<%Response.Write(MyListings.ListingList[Index].ListingID);%>" > View</a>
                              
                            <%
                            //increment the index
                            Index++;
                        %>
                        
                        </li>                
                            <%
                    }
              %>

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


