<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">
    //declare variable to store session object
    Int32 VMCustomerID;
    //create an instance of the movie collection class
    VirginClassLibrary.clsVMMovieCollection allMovies = new VirginClassLibrary.clsVMMovieCollection();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack == false)
        {
            {
                //display the Customer data
                DisplayCustomer();
            }
        }
    }
    void DisplayCustomer()
    {
        //create an instance of the user collection class
        VirginClassLibrary.clsVMCustomerCollection SomeCustomer = new VirginClassLibrary.clsVMCustomerCollection();
        //find the record to update
        SomeCustomer.ThisCustomer.Find(VMCustomerID);
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Virgin Movie</title>
    <link href="VMMovie.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">

        <header>
            <h2>Virgin Media Staff Movie </h2>
        </header>
        <asp:Label ID="lblCartCount" runat="server"></asp:Label>

        <%--<asp:ListBox ID="lstCustomerMovies" runat="server" CssClass="lstCustomerFilms"></asp:ListBox>--%>
        <%--<asp:Label ID="lblFilmDescription" runat="server" CssClass="lblFilmDescription" Text=""></asp:Label>--%>
        <%--<asp:Image ID="MovieImage" runat="server" />--%>
        <asp:Label ID="lblFilterGenre" runat="server" Text="Filter By Genre:" CssClass="lblFilterFilmGenre"></asp:Label>
        <asp:TextBox ID="txtFilterGenre" runat="server" CssClass="txtFilterFilmGenre"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" CssClass="btnApplyFilmFilter" />
        <%--<asp:Label ID="lblMovieCount" runat="server" CssClass="lblMovieCount" Text=""></asp:Label>--%>


        <%
            //create an index variable
            Int32 Index = 0;
            //get the count of records
            Int32 RecordCount = allMovies.Count;
            //loop through each record     
        %>
        <ul class="Movies">
            <%
                //while there are still listings to display
                while (Index < RecordCount)
                {
            %><li><%
                      //write a movie to the browser
                      Response.Write(allMovies.MovieList[Index].VMmovieTitle);
                      Response.Write("<br>");
                      Response.Write("<img src='" + allMovies.MovieList[Index].VMImage + "'/>");
                      Response.Write("<br>");
                      Response.Write("Movie Genre: " + allMovies.MovieList[Index].VMmovieGenre);
                      Response.Write("<br>");
                      Response.Write("Movie Duration: " + allMovies.MovieList[Index].VMmovieDuration);
                      Response.Write("<br>");
                      Response.Write("Movie Rating: " + allMovies.MovieList[Index].VMmovieRating);
                      Response.Write("<br>");
                      Response.Write("Movie Release Date: " + allMovies.MovieList[Index].VMmovieReleaseDate);
                      Response.Write("<br>");
            %>
                               <a href="VMMovieViewer.aspx?VMMovieID=<%Response.Write(allMovies.MovieList[Index].VMMovieID);%>">View</a>
                <%

                    }
                    //increment the index
                    Index++;
                %>
                        
            </li>
        </ul>
        <nav>
            <asp:Button ID="btnViewCart" CssClass="btnCustomerCart" runat="server" Text="View Shopping Cart" />
            <asp:Button ID="btnEditAccount" CssClass="btnEditAccount" runat="server" Text="Edit Account Details" />
            <asp:Button ID="btnLogOut" CssClass="btnCustomerLogOut" runat="server" Text="Log Out" />
        </nav>

        <footer>
            <div id="FooterText">
                © 2021 Virgin Media | All Rights Reserved
            </div>
        </footer>
    </form>
</body>
</html>
