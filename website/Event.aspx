<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Event.aspx.cs" Inherits="WebApplication3.Event" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        body {
            position: relative;
        }

        #All {
            height: 300px;
        }

        #section1 {
            height: 500px;
            text-decoration-color: #fff;
        }

        #section2 {
            height: 500px;
            text-decoration-color: #fff;
        }

        #section3 {
            height: 500px;
            text-decoration-color: #fff;
        }

        #section4 {
            height: 500px;
            text-decoration-color: #fff;
        }

        #section5 {
            height: 500px;
            text-decoration-color: #fff;
        }
        #toTop {
    display: none;
    text-decoration: none;
    position: fixed;
    bottom: 30px;
    right: 25px;
    overflow: hidden;
    z-index: 999;
    width: 32px;
    height: 32px;
    border: none;
    text-indent: 100%;
    background: url(../pic/arr.png) no-repeat 0px 0px;
}
#toTopHover {
    width: 32px;
    height: 32px;
	display: block;
	overflow: hidden;
	float: right;
	opacity: 0;
	-moz-opacity: 0;
	filter: alpha(opacity=0);
}
    </style>
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="lblSuccess" runat="server" Text=></asp:Label>
    <div id="container">
        <header>
              <nav>
                <div class="col-lg-12">
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="collapse navbar-collapse" id="myNavbar">
                                <ul class="nav navbar-nav">
                                    <li><a href="#ALL">ALL</a></li>
                                    <li><a href="#section1">Music Festival</a></li>
                                    <li><a href="#section2">Bithday party</a></li>
                                    <li><a href="#section3">Conference</a></li>
                                    <li><a href="#section4">Wedding party</a></li>
                                    <li><a href="#section5">Photo exhibition</a></li>
                                    <li>
                                     <asp:Button ID="btnevent" runat="server" class="btn btn-primary navbar-btn" Text="Want to book Hall?" OnClick="btnevent_Click" />
                                 
                                 </li>

                                </ul>

                            </div>
                        </div>
                       
                      </div>
                    </div>
               </nav>
        </header>

        <div id="ALL" class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel-heading" style="background-color:white;">
                        <div class="panel-body" style="height:100px"></div>
                    </div>
                </div>

            </div>
            <h1 class="text-center">Events</h1>
            <div class="panel-heading" style="background-color:white;">
                <div class="panel-body"></div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <img src="pic/music.jpg" width="304" height="200">
                    <img src="pic/birthday.jpg" width="304" height="200">
                    <img src="pic/wedding1.jpg" width="304" height="200">
                    <img src="pic/conference1.jpg" width="304" height="200">


                </div>

            </div>
        </div>
        <div id="section1" class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel-heading" style="background-color:white;">
                        <div class="panel-body" style="height:150px"></div>
                    </div>
                </div>

            </div>
            <h1 class="text-center">Music Festival</h1>
            <div class="panel-heading" style="background-color:white;">
                <div class="panel-body" style="height:80px"></div>
            </div>
            <div class="row">
                <div class="col-lg-4">
                    <img src="pic/music.jpg" class="img-circle" width="304" height="200">


                </div>
                <div class="col-lg-4">
                    <img src="pic/music1.jpg" class="img-circle" width="304" height="200">
                </div>
                <div class="col-lg-4">
                    <img src="pic/music2.jpg" class="img-circle" width="304" height="200">
                </div>

            </div>
        </div>
        <div id="section2" class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel-heading" style="background-color:white;">
                        <div class="panel-body" style="height:100px"></div>
                    </div>
                </div>

            </div>
            <h1 class="text-center">Bithday party</h1>
            <div class="panel-heading" style="background-color:white;">
                <div class="panel-body" style="height:50px"></div>
            </div>
            <div class="row">
                <div class="col-lg-4">
                    <img src="pic/birthday.jpg" class="img-circle" width="304"
                         height="200">
                </div>
                <div class="col-lg-4">

                </div>
                <div class="col-lg-4">
                </div>

            </div>
            <div class="panel-heading" style="background-color:white;">
                <div class="panel-body" style="height:50px"></div>
            </div>
        </div>
        <div id="section3" class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel-heading" style="background-color:white;">
                        <div class="panel-body" style="height:100px"></div>
                    </div>
                </div>

            </div>
            <h1 class="text-center">Conference</h1>
            <div class="panel-heading" style="background-color:white;">
                <div class="panel-body" style="height:50px"></div>
            </div>
            <div class="row">
                <div class="col-lg-4">
                    <img src="pic/Conference1.jpg" class="img-circle" width="304"
                         height="200">
                </div>
                <div class="col-lg-4">
                    <img src="pic/conference2.jpg" class="img-circle" width="304"
                         height="200">

                </div>
                <div class="col-lg-4">
                </div>

            </div>
            <div class="panel-heading" style="background-color:white;">
                <div class="panel-body" style="height:50px"></div>
            </div>
        </div>
        <div id="section4" class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel-heading" style="background-color:white;">
                        <div class="panel-body" style="height:100px"></div>
                    </div>
                </div>

            </div>
            <h1 class="text-center">Wedding party</h1>
            <div class="panel-heading" style="background-color:white;">
                <div class="panel-body" style="height:50px"></div>
            </div>
            <div class="row">
                <div class="col-lg-4">
                    <img src="pic/wedding1.jpg" class="img-circle" width="304"
                         height="200">
                </div>
                <div class="col-lg-4">
                    <img src="pic/wedding2.jpg" class="img-circle" width="304"
                         height="200">

                </div>
                <div class="col-lg-4">
                </div>

            </div>
            <div class="panel-heading" style="background-color:white;">
                <div class="panel-body" style="height:50px"></div>
            </div>
        </div>
        <div id="section5" class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel-heading" style="background-color:white;">
                        <div class="panel-body" style="height:100px"></div>
                    </div>
                </div>

            </div>
            <h1 class="text-center">Photo exhibition</h1>
            <div class="panel-heading" style="background-color:white;">
                <div class="panel-body" style="height:50px"></div>
            </div>
            <div class="row">
                <div class="col-lg-4">
                    <img src="pic/photo1.jpg" class="img-circle" width="304"
                         height="200">
                </div>
                <div class="col-lg-4">
                    <img src="pic/photo2.jpg" class="img-circle" width="304"
                         height="200">

                </div>
                <div class="col-lg-4">
                </div>

            </div>
            <div class="panel-heading" style="background-color:white;">
                <div class="panel-body" style="height:50px"></div>
            </div>

         <div class="arr-w3ls">
	      <a href="#Event" id="toTop" style="display: block;"> <span id="toTopHover" style="opacity: 1;"> </span></a>
	   </div>
        </div>
    </div>

</asp:Content>

