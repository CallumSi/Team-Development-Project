<%@ Page Language="C#" %>



<!DOCTYPE html>



<script runat="server">

            Int32 UserID;
            VirginClassLibrary.clsMarketplaceListingCollection MyListings = new VirginClassLibrary.clsMarketplaceListingCollection();
            VirginClassLibrary.clsMarketplaceListingCollection filteredlist;
            bool trysearch = false;
            protected void Page_Load(object sender, EventArgs e)
            {

                //get the User Id
                UserID = Convert.ToInt32(Session["UserID"]);


                if (IsPostBack == false)
                {
                    {

                        //display the User data
                        DisplayUserData();
                        //display the Listings
                        //create an instance of the Listing Colleciton


                    }
                }
            }

            void DisplayUserData()
            {
                //create an instance of the user collection class
                VirginClassLibrary.clsMarketplaceUserCollection SomeUser = new VirginClassLibrary.clsMarketplaceUserCollection();
                //find the record to update
                SomeUser.ThisUser.Find(UserID);
                //display the data for this record
                lblEmail.Text = SomeUser.ThisUser.Email;


            }



            VirginClassLibrary.clsMarketplaceListingCollection FilterListing(string ListingNameFilter)
            {

                //create instance of collection class
                VirginClassLibrary.clsMarketplaceListingCollection ListOfListings = new VirginClassLibrary.clsMarketplaceListingCollection();
                ListOfListings.FilterByListingName(ListingNameFilter);
                return ListOfListings;

            }



            protected void btnClickHere_Click(object sender, EventArgs e)
            {
                //use session object to indicate new record
                Session["ListingID"] = -1;
                Session["UserID"] = UserID;
                //redirect to user data entry page
                Response.Redirect("MarketplaceListingType.aspx");
            }


            protected void Redirect_Click(object sender, EventArgs e)
            {
                //store data in session object so we can pass it to next page
                Session["ListingID"] = 2;
                //redirect to edit user details page
                Response.Redirect("MarketplaceListingViewer.aspx");
            }

            protected void btnSearch_Click(object sender, EventArgs e)
            {
                if (txtSearch.Text != "")
                {
                    filteredlist = FilterListing(txtSearch.Text);
                    trysearch = true;

                }
                else
                {
                    trysearch = false;
                }

            }

            protected void btnMyAccount_Click(object sender, EventArgs e)
            {
                //store data in session object so we can pass it to next page
                Session["UserID"] = UserID;
                //redirect to edit user details page
                Response.Redirect("MarketplaceUserProfile.aspx");
            }

            protected void btnHome_Click(object sender, EventArgs e)
            {
                //store data in session object so we can pass it to next page
                Session["UserID"] = UserID;
                //redirect to edit user details page
                Response.Redirect("MarketplaceHome.aspx");
            }

            decimal GetHighestBid(int ListingID)
            {

                //first establish connection 
                VirginClassLibrary.clsDataConnection DB = new VirginClassLibrary.clsDataConnection();
                //set the paramters for the sproc
                DB.AddParameter("@ListingID", ListingID);
                //execute the spoc
                DB.Execute("sproc_tblMarketplaceUserBids_FilterByListingID");
                //populate the array with the found data;
                //variables to loop through list
                Int32 RecordCount;
                Int32 Index = 0;
                decimal highestbid = 0;
                //get count of filtered list
                RecordCount = DB.Count;
                if (RecordCount != 0)
                {


                    //loop through the list adding them to the list box

                    while (Index < RecordCount)
                    {

                        decimal tempbid = Convert.ToDecimal(DB.DataTable.Rows[Index]["BidAmount"]);
                        if (tempbid > highestbid)
                        {
                            highestbid = tempbid;
                        }


                        Index++;
                    }

                }

                return highestbid;
            }
      
    
</script>



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
                   
                    //create an index variable
                    Int32 Index = 0;
                     Int32 Index2 = 0;
                    //get the count of records
                    Int32 RecordCount = MyListings.Count;
                    
                        //loop through each record
                       
                    %>
                    <ul class="Listings">
                    
                    <%
                     if (trysearch == true)
                        {
                          Int32 RecordCount2 = filteredlist.Count;
                          while(Index2 < RecordCount2)
                                
                    {
                        %>
                        <li>
                            <%
                                //write a listing to the browser
                                Response.Write(filteredlist.ListingList[Index2].ListingName);
                                Response.Write("<br>");
                                Response.Write("<img src='" + filteredlist.ListingList[Index2].Img+ "'/>");
                                Response.Write("<br>");
                                Response.Write("Start Price: £" + filteredlist.ListingList[Index2].Price);
                                Response.Write("<br>");
                                Response.Write("Ends:" + filteredlist.ListingList[Index2].CloseDate);
                                Response.Write("<br>");
                                if(MyListings.ListingList[Index].ListingType==1){
                                    Response.Write("Buy Now");
                                }
                                if(MyListings.ListingList[Index].ListingType==2){
                                    Response.Write("Bid Now");
                                    Response.Write("<br>");
                                    Response.Write("Current Bid : ");
                                    if(GetHighestBid(MyListings.ListingList[Index].ListingID)!= 0)
                                    {
                                        
                                        Response.Write("£");
                                        Response.Write(GetHighestBid(MyListings.ListingList[Index].ListingID));
                                    }
                                    else
                                    {
                                        Response.Write("No Bids yet");
                                    }


                                }
                                if(MyListings.ListingList[Index].ListingType==3){
                                    Response.Write("Offer Now");
                                }
                                Response.Write("<br>");
                            %>
                            
                            <a href="MarketplaceListingViewer.aspx?ListingID=<%Response.Write(filteredlist.ListingList[Index].ListingID);%>" > View</a>
                              
                            <%
                            //increment the index
                            Index2++;
                        %>
                        
                        </li>                
                            <%
                    }
                        }
                    if (trysearch == false)
                     {
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
                                Response.Write("Start Price: £" + MyListings.ListingList[Index].Price);
                                Response.Write("<br>");
                                Response.Write("Ends:" + MyListings.ListingList[Index].CloseDate);
                                Response.Write("<br>");
                                if(MyListings.ListingList[Index].ListingType==1){
                                    Response.Write("Buy Now");
                                }
                                if(MyListings.ListingList[Index].ListingType==2){
                                    Response.Write("Bid Now");
                                    Response.Write("<br>");
                                    Response.Write("Current Bid : ");
                                    if(GetHighestBid(MyListings.ListingList[Index].ListingID)!= 0)
                                    {
                                        Response.Write("£");
                                        Response.Write(GetHighestBid(MyListings.ListingList[Index].ListingID));
                                    }
                                    else
                                    {
                                        Response.Write("No Bids yet");
                                    }
                                }
                                if(MyListings.ListingList[Index].ListingType==3){
                                    Response.Write("Offer Now");
                                }
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