<%@ Page Language="C#" %>



<!DOCTYPE html>



<script runat="server">

    Int32 UserID;
    VirginClassLibrary.clsMarketplaceListingCollection MyListings = new VirginClassLibrary.clsMarketplaceListingCollection();
    Boolean showEnded = false;

    VirginClassLibrary.clsMarketplaceCart MyCart = new VirginClassLibrary.clsMarketplaceCart();
    protected void Page_Load(object sender, EventArgs e)
    {

        //upon loading the page read the session object
        MyCart = (VirginClassLibrary.clsMarketplaceCart)Session["MyCart"];
        if (MyCart ==null)
        {
            MyCart = new VirginClassLibrary.clsMarketplaceCart();
        }
        //then you can display how many items are in your cart
        lblCartCount.Text = MyCart.Products.Count.ToString();


        //get the User Id
        UserID = Convert.ToInt32(Session["UserID"]);
        showEnded = Convert.ToBoolean(Session["ShowEnded"]);


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
    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //save the cart
        Session["MyCart"] = MyCart;
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


        //create instance of collection class
        VirginClassLibrary.clsMarketplaceListingCollection ListOfListings = new VirginClassLibrary.clsMarketplaceListingCollection();
        ListOfListings.FilterByListingName(txtSearch.Text);
        MyListings = ListOfListings;

    }

    protected void btnMyAccount_Click(object sender, EventArgs e)
    {
        //store data in session object so we can pass it to next page
        Session["UserID"] = UserID;
        //redirect to edit user details page
        Response.Redirect("MarketplaceUserProfile.aspx");
    }

    protected void btnhome_Click(object sender, EventArgs e)
    {
        //store data in session object so we can pass it to next page
        Session["UserID"] = UserID;
        //redirect to edit user details page
        Response.Redirect("MarketplaceHome2.aspx");
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


    protected void btnEnded_Click(object sender, EventArgs e)
    {
        if(  showEnded == true){
            showEnded = false;

        }
        else
        {
            showEnded = true;

        }


        Session["showEnded"] = showEnded;

    }


    protected void btnBuyItNow_Click(object sender, EventArgs e)
    {

        //create instance of collection class
        VirginClassLibrary.clsMarketplaceListingCollection ListOfListings = new VirginClassLibrary.clsMarketplaceListingCollection();
        ListOfListings.FilterByListingType(1);
        MyListings = ListOfListings;
    }

    protected void btnAuction_Click(object sender, EventArgs e)
    {

        //create instance of collection class
        VirginClassLibrary.clsMarketplaceListingCollection ListOfListings = new VirginClassLibrary.clsMarketplaceListingCollection();
        ListOfListings.FilterByListingType(2);
        MyListings = ListOfListings;
    }

    protected void btnAcceptsOffers_Click(object sender, EventArgs e)
    {

        //create instance of collection class
        VirginClassLibrary.clsMarketplaceListingCollection ListOfListings = new VirginClassLibrary.clsMarketplaceListingCollection();
        ListOfListings.FilterByListingType(3);
        MyListings = ListOfListings;

    }

    protected void btnAllListings_Click(object sender, EventArgs e)
    {

        //create instance of collection class
        VirginClassLibrary.clsMarketplaceListingCollection ListOfListings = new VirginClassLibrary.clsMarketplaceListingCollection();
        ListOfListings.FilterByListingName("");
        MyListings = ListOfListings;
    }

    protected void btnViewCart_Click(object sender, EventArgs e)
    {
        Response.Redirect("MarketplaceViewcart.aspx");
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
                 <ul class ="row">
       
                            <li>
                          <asp:Label ID="Label3" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                          <asp:Label ID="lblEmail" runat="server" style="z-index: 1;" Text="Welcome "></asp:Label>
                            </li>
                          <li>
                              <asp:Button ID="Button1" CssClass="navButton" runat="server" style="z-index: 1;" Text="Sell" OnClick="btnClickHere_Click" />
                              <asp:Button ID="Button6" CssClass="navButton" runat="server" style="z-index: 1;" Text="MyAccount" OnClick="btnMyAccount_Click" />
                              <asp:Button ID="btnhome" CssClass="navButton" runat="server" style="z-index: 1;" Text="home" OnClick="btnhome_Click" />
                              <asp:Button ID="btnViewCart" CssClass="navButton" runat="server" style="z-index: 1;" Text="ViewCart" OnClick="btnViewCart_Click" />
                              <asp:Label ID="lblCartCount" runat="server"></asp:Label>
                          </li>
                     
                    
                     
                 </ul>

                           <br />
                          <asp:Label ID="Label1" runat="server" style="z-index: 1;" Text="Marketplace home"></asp:Label>             
                          <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1;"></asp:TextBox>
                          <asp:Button ID="btnSearch" CssClass="navButton" runat="server" style="z-index: 1;" Text="Search" OnClick="btnSearch_Click" />
                            
                 <ul class ="row">
                    <li>
                     <asp:Button ID="btnAllListings" CssClass="navButton" runat="server" style="z-index: 1;" Text="All listings" OnClick="btnAllListings_Click" /></li> 
                     <li><asp:Button ID="btnAcceptsOffers" CssClass="navButton" runat="server" style="z-index: 1;" Text="Accepts offers" OnClick="btnAcceptsOffers_Click"/></li>
                     <li><asp:Button ID="btnAuction" CssClass="navButton" runat="server" style="z-index: 1;" Text="Auction" OnClick="btnAuction_Click" /></li>
                     <li><asp:Button ID="btnBuyItNow" CssClass="navButton" runat="server" style="z-index: 1;" Text="Buy it now" OnClick="btnBuyItNow_Click" /></li>
                     <li><asp:Button ID="btnEnded" CssClass="navButton" runat="server" style="z-index: 1;" Text="Toggle Ended Listings" OnClick="btnEnded_Click" /></li>
                     <li></li>
                 </ul>                            
                 <%
                   
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
                            DateTime todaydatetime =  DateTime.Now;
                            DateTime enddate = MyListings.ListingList[Index].CloseDate;
                            TimeSpan difference = enddate.Subtract(todaydatetime);
                            if (showEnded == false)
                            {
                            
                                                if (enddate > todaydatetime)
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
                                                                
                                                                                    if(enddate > todaydatetime)
                                                                                    {
                                                                                    Response.Write("Ends:" + MyListings.ListingList[Index].CloseDate);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                    Response.Write("Ended");
                                                                                    }  
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

                                                }            
                            }
                            else
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
                                                                
                                                                if(difference.Seconds > 0 )
                                                                {
                                                                Response.Write("Ends:" + MyListings.ListingList[Index].CloseDate);
                                                                }
                                                                else
                                                                {
                                                                Response.Write("Ended");
                                                                }  
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
                            }
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