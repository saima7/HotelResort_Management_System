<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hoome.aspx.cs" Inherits="WebApplication3.hoome" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>hello</title>
     <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <script src="scripts/jquery-1.9.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <link href="animation.css" rel="stylesheet" />
    <link href="css/Custom-Cs.css" rel="stylesheet" />
    <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
    <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
     <script type="text/javascript" language="javascript">

</script>
    
       <style type="text/css">
        .Star {
            background-image: url(pic/Star.gif);
            height: 17px;
            width: 17px;
        }

        .WaitingStar {
            background-image: url(pic/WaitingStar.gif);
            height: 17px;
            width: 17px;
        }

        .FilledStar {
            background-image: url(pic/FilledStar.gif);
            height: 17px;
            width: 17px;
        }
        .SomeClass { font-family: "Times New Roman"; font-size: 4em; }
        </style>

</head>
    <body>
    <form id="form1" runat="server">
        <div>
            <div class="navbar navbar-default navbar-fixed-top" role="navigation">
                <div class="container">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="hoome.aspx"><span>
                            <img alt="Logo" src="pic/logo.png" height="30" /></span>SSTN</a>
                    </div>
                    <div class="navbar-collapse collapse">
                        <ul class="nav navbar-nav navbar-right">
                            <li><a href="UserHome.aspx">Home</a></li>
                            <li><a href="Allproduct.aspx">Products</a></li>
                            <li><a href="MyAccount.aspx">My Account</a></li>
                            <li><a href="Review.aspx">Contact</a></li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Products<b class="caret"></b></a>
                                <ul class="dropdown-menu">
                                    <li><a href="Allproduct.aspx">All Products</a></li>
                                    <li role="separator" class="divider"></li>
                                    <li><a href="RoomHome.aspx">Room</a></li>                                  
                                    <li role="separator" class="divider"></li>
                                     <li><a href="FoodHome.aspx">Food</a></li>    
                                    <li role="separator" class="divider"></li>
                                    <li><a href="UserHall.aspx">Hall</a></li>    
                                    <li role="separator" class="divider"></li>
                                    <li><a href="UserTable.aspx">Table</a></li>    
                                </ul>
                            </li>
                            <li><a href="MyOrder.aspx">My Order</a></li>
                            <li>
                                
                                    <asp:ImageButton ID="btnCart" runat="server" Height="50px" ImageUrl="~/pic/cart.gif" OnClick="btnCart_Click" Width="70px" />
                                 
         
                            </li>
                            <li id="btnSignup" runat="server"><a href="register.aspx">Sign Up</a></li>
                            <li id="btnSignin" runat="server"><a href="logIN.aspx">Sign In</a></li>
                            <li>
                                <asp:Button ID="btnSignOut" runat="server" Class="btn btn-default navbar-btn" Text="Sign out" OnClick="btnSignOut_Click" />
                            </li>
                        </ul>
                    </div>
                </div>
            </div>

            <!--- Carousel -->

             <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class="carousel-inner" role="listbox">
                    <div class="item active">
                        <img src="pic/pic11.jpg" alt="...">
                        <div class="carousel-caption">
                            <h3> Welcome</h3>
                            <p>Feel the peace!</</p>
                            <p><a class="btn btn-lg btn-primary" href="register.aspx" role="button">Join Us Today</a></p>
                        </div>
                    </div>
                    <div class="item">
                        <img src="pic/pic111.jpg" alt="...">
                        <div class="carousel-caption">
                            <h3>Welcome</h3>
                            <p>Feel the peace!</</p <p><a class="btn btn-lg btn-primary" href="register.aspx" role="button">Join Us Today</a></p>

                        </div>
                    </div>
                    <div class="item">
                        <img src="pic/pic1111.jpg" alt="...">
                        <div class="carousel-caption">
                            <h3>Welcome</h3>
                            <p>Feel the peace!</p>
                             <p><a class="btn btn-lg btn-primary" href="register.aspx" role="button">Join Us Today</a></p>
                        </div>
                    </div>
                </div>

                <!-- Controls -->
                <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>



            <!--- Carousel -->
          
                     </div>

       
        <br />
        <br />
              
      <p> <marquee behavior="scroll" direction="left" onmouseover="stop()" onmouseout="start()"><font color="#191970"><h3>30%off for Winter...Hurry!!!</h3></font><font color="#00CC99"><h4>ENJOY OUR AWESOME SERVICES</h4></font></marquee><br>  </p>
        <!--- Middle Contents -->
        <div class="container center">
            <div class="row">
                
                <div class="col-lg-4">
                    <img class="img-circle" src="pic/pic7.jpg" alt="thumb01" width="140" height="140" />
                    <br />
                    <h4>SWIMMING POOL</h4>
                    <br />
                    <div id="demo" class="collapse">
                     SSTN has indoor swimming pool with the dimension of 8m*14m has the state-of-art facilities including automatic windows on the roof to allow guests to enjoy fresh air and sunshine from outside when desired. Clean water, waterfalls massage, oxygen room, and ultraviolet ray room add more pleasure to swimming.
                     </div>
                    <button type="button" class="btn btn-default" data-toggle="collapse" data-target="#demo">View &raquo;</button>
                </div>
                <div class="col-lg-4">
                    <img class="img-circle" src="pic/spa.jpg" alt="thumb02" width="140" height="140" />
                    <br />
                    <h4>SPA-BEAUTY & HEALTH</h4>
                    <br />
                   <div id="demo1" class="collapse">
                     Relaxation and Healing with Massage and other Holistic Spa Services at  SSTN Health Center.
                     </div>
                    <button type="button" class="btn btn-default" data-toggle="collapse" data-target="#demo1">View &raquo;</button>
                </div>
                <div class="col-lg-4">
                    <img class="img-circle" src="pic/Conference1.jpg" alt="thumb03" width="140" height="140" />
                    <br />
                    <h4>CONFERENCE</h4>
                    <br />
                    <div id="demo2" class="collapse">
                    The multifunctional conference hall of the SSTN is an ideal place for holding: seminars; trainings; corporate events; banquets; and business meetings on a high level. Convenient, discreet interior and universal modern technical equipment allow you to convert the hall according to your individual needs.
                     </div>
                    <button type="button" class="btn btn-default" data-toggle="collapse" data-target="#demo2">View &raquo;</button>
                </div>
            </div>
        </div>
        <!--- Middle Contents -->

        <!--- Footer  -->
        <div class="row">        
            <div class="panel panel-success">
                      <div class="panel-heading"></div>
                     <div class="panel-body">          
                         <div class="col-lg-4">
                             <asp:Label ID="test" runat="server" Text=""></asp:Label>
                         </div>
                         <div class="col-lg-4">
                             <div class="SomeClass">
                             <asp:Label ID="test1" runat="server" Text=""></asp:Label>
                             </div>
                        </div>
                         <div class="col-lg-4">
                             <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                         </div>
                     </div>
              </div>
      </div>
       
        <div class="col-lg-12" style="background-color:black;"></div>
        <div class="col-lg-12" style="background-color:black;"></div>
            <div class="col-lg-12" style="background-color:white;">
                <div class="panel-body"></div>
            </div>
            <div class="row">
                <h1 class="text-center">Packages</h1>
                <h3 class="text-center">Contact with Us For these Offers</h3>
            </div>
            <div class="row">
                <div class="col-lg-4 col-md-4 col-sm-6 col-xs-12">
                    <div class="hovereffect">
                        <img class="img-responsive" src="pic/pic1.jpg" alt="">
                        <h2>SLIVER PACK</h2>
                        <div class="overlay">
                            <h2>SLIVER PACK</h2>
                            <h2>15000 Tk</h2>
                            <br />
                            <p style="color:white ; font-size:20px;">
                                Flight Ticket  <span class="glyphicon glyphicon-plane"></span>
                            </p>
                            <p style="color:white ; font-size:20px;">
                                Music Concert (30% Off)<span class="glyphicon glyphicon-music"></span>
                            </p>
                            <p style="color:white ; font-size:20px;">
                                Restaurant(lunch) <span class="glyphicon glyphicon-cutlery"></span>
                            </p>                          
                            <br />
                            <a class="info" href="#">DETAILS</a>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-4 col-sm-6 col-xs-12">
                    <div class="hovereffect">
                        <img class="img-responsive" src="pic/pic2.jpg" alt=""/>
                        <h2>GOLD PACK</h2>
                        <div class="overlay">
                            <h2>GOLD PACK</h2>
                            <h2>20000 Tk /per night</h2>
                            <br />
                            <p style="color:white ; font-size:20px;">
                                Flight Ticket  <span class="glyphicon glyphicon-plane"></span>
                            </p>
                            <p style="color:white ; font-size:20px;">
                                Music Concert (30% Off)<span class="glyphicon glyphicon-music"></span>
                            </p>
                            <p style="color:white ; font-size:20px;">
                                Restaurant <span class="glyphicon glyphicon-cutlery"></span>
                            </p>
                            <p style="color:white ; font-size:20px;">
                                Treatment <span class="glyphicon glyphicon-heart"></span>
                            </p>
                            
                            <br />
                            <a class="info" href="#">DETAILS</a>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-4 col-sm-6 col-xs-12">
                    <div class="hovereffect">
                        <img class="img-responsive" src="pic/pic7.jpg" alt="">
                        <h2>DIAMOND PACK</h2>
                        <div class="overlay">
                            <h2>DIAMOND PACK</h2>
                            <h2>30000 Tk /per night</h2>
                            <br />
                            <p style="color:white ; font-size:20px;">
                                Flight Ticket  <span class="glyphicon glyphicon-plane"></span>
                            </p>
                            <p style="color:white ; font-size:20px;">
                                Music Concert (30% Off)<span class="glyphicon glyphicon-music"></span>
                            </p>
                            <p style="color:white ; font-size:20px;">
                                Restaurant <span class="glyphicon glyphicon-cutlery"></span>
                            </p>
                            <p style="color:white ; font-size:20px;">
                                Treatment <span class="glyphicon glyphicon-heart"></span>
                            </p>
                            <p style="color:white ; font-size:20px;">
                                Spa<span class="glyphicon glyphicon-user"></span>
                            </p>
                            <br />
                            <a class="info" href="#">DETAILS</a>
                        </div>
                    </div>
                </div>
            </div>
        
        

            <div class="col-lg-12" style="background-color:black;"></div>
     <section class="contact-w3ls" id="contact">
	<div class="container">
		<div class="col-lg-6 col-md-6 col-sm-6 contact-w3-agile2" data-aos="flip-left">
			<div class="contact-agileits">
				<h4>Rating Us</h4>
				<p class="contact-agile2">Give us your review to improve Ourself</p>
				<form id="form2" >
                   <asp:ScriptManager ID="ToolkitScriptManager1" runat="server">
                                                        </asp:ScriptManager>
                     <asp:Rating ID="Rating1" runat="server" AutoPostBack="true"
                      StarCssClass="Star" WaitingStarCssClass="WaitingStar" EmptyStarCssClass="Star"
                       FilledStarCssClass="FilledStar">
                     </asp:Rating>
                    <br />
                     <asp:Label ID="lbresult" runat="server" Text=""></asp:Label>
                     <br />
                    <asp:TextBox runat="server" ID="txtreview" TextMode="MultiLine"></asp:TextBox>
                    <br />
                    <asp:Button runat="server" Text="Submit Review" ID="btnsubmit" OnClick="btnsubmit_Click" />
                </form>
				
				
			</div>
		</div>
		<div class="col-lg-6 col-md-6 col-sm-6 contact-w3-agile1" data-aos="flip-right">
			<h4>Connect With Us</h4>
			<p class="contact-agile1"><strong>Phone :</strong>+88 01677348014</p>
			<p class="contact-agile1"><strong>Email :</strong> <a href="mailto:name@example.com">SSTN.COM</a></p>
			<p class="contact-agile1"><strong>Address :</strong> Dhaka, Bangladesh</p>
																
			<div class="social-bnr-agileits footer-icons-agileinfo">
				<ul class="social-icons3">
								<li><a href="https://www.facebook.com" class="fa fa-facebook icon-border facebook"> </a></li>
								<li><a href="https://twitter.com/" class="fa fa-twitter icon-border twitter"> </a></li>
								<li><a href="https://plus.google.com/discover" class="fa fa-google-plus icon-border googleplus"> </a></li> 
								
							</ul>
			</div>
			<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1825.7703494622558!2d90.40579115809898!3d23.763752820450545!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3755c77decb5f845%3A0xc2eadd2f3b867792!2sAhsanullah+University+of+Science+and+Technology!5e0!3m2!1sen!2sbd!4v1542253718961" width="400" height="300" frameborder="0" style="border:0" allowfullscreen></iframe>
		</div>
		<div class="clearfix"></div>
	</div>
</section>
        <footer>
            <div class="container">
                <p class="pull-right"><a href="#">Back to top</a></p>
                <p>&copy; STNN.com &middot; <a href="hoome.aspx">Home</a> &middot; <a href="UserHome.aspx">About</a> &middot; <a href="Review.aspx">Contact</a> &middot; <a href="Allproduct.aspx">Products</a></p>
            </div>
        </footer>

        <!--- Footer -->

    </form>
    
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>

<%--  --%>