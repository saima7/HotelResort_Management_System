<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Allproduct.aspx.cs" Inherits="WebApplication3.Allproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        .hovereffect {
    width: 100%;
    height: 100%;
    float: left;
    overflow: hidden;
    position: relative;
    text-align: center;
    cursor: default;
}

    .hovereffect .overlay {
        width: 100%;
        height: 100%;
        position: absolute;
        overflow: hidden;
        top: 0;
        left: 0;
        opacity: 0;
        background-color: rgba(0,0,0,0.5);
        -webkit-transition: all .4s ease-in-out;
        transition: all .4s ease-in-out
    }

    .hovereffect img {
        display: block;
        position: relative;
        -webkit-transition: all .4s linear;
        transition: all .4s linear;
    }

    .hovereffect h2 {
        text-transform: uppercase;
        color: #fff;
        text-align: center;
        position: relative;
        font-size: 17px;
        padding: 10px;
        background: rgba(0, 0, 0, 0.6);
        -webkit-transform: translateY(45px);
        -ms-transform: translateY(45px);
        transform: translateY(45px);
        -webkit-transition: all 0.4s ease-in-out;
        transition: all 0.4s ease-in-out;
    }
        .hovereffect a.info {
        text-decoration: none;
        display: inline-block;
        text-transform: uppercase;
        color: #fff;
        border: 1px solid #fff;
        background-color: transparent;
        opacity: 0;
        filter: alpha(opacity=0);
        -webkit-transition: all .2s ease-in-out;
        transition: all .2s ease-in-out;
        margin: 50px 0 0;
        padding: 7px 14px;
    }

        .hovereffect a.info:hover {
            box-shadow: 0 0 5px #fff;
        }

    .hovereffect:hover img {
        -ms-transform: scale(1.2);
        -webkit-transform: scale(1.2);
        transform: scale(1.2);
    }

    .hovereffect:hover .overlay {
        opacity: 1;
        filter: alpha(opacity=100);
    }

    .hovereffect:hover h2, .hovereffect:hover a.info {
        opacity: 1;
        filter: alpha(opacity=100);
        -ms-transform: translatey(0);
        -webkit-transform: translatey(0);
        transform: translatey(0);
    }

    .hovereffect:hover a.info {
        -webkit-transition-delay: .2s;
        transition-delay: .2s;
    }
    * {
    margin: 0;
    padding: 0;
}

body {
    <!-- src: http://subtlepatterns.com/?p=1045 -->
    background: url('dark_geometric.png');
}

#container {
    width: 1140px;
    overflow: hidden;
    / margin: 50px auto;
    background: white;
}
/*header*/
header {
    width: 2249pz;
     //margin: 40px auto;
}

    header h1 {
        text-align: center;
        font: 100 60px/1.5 Helvetica, Verdana, sans-serif;
    }

    header p {
        font: 100 15px/1.5 Helvetica, Verdana, sans-serif;
        text-align: justify;
    }

/*photobanner*/

.photobanner {
    height: 233px;
    width: 3600px;
    margin-bottom: 80px;
}
/*keyframe animations*/
.first {
    -webkit-animation: bannermove 30s linear infinite;
    -moz-animation: bannermove 30s linear infinite;
    -ms-animation: bannermove 30s linear infinite;
    -o-animation: bannermove 30s linear infinite;
    animation: bannermove 30s linear infinite;
}

@keyframes

"bannermove" {
    0%

{
    margin-left: 0px;
}

100% {
    margin-left: -2125px;
}

}

@-moz-keyframes bannermove {
    0% {
        margin-left: 0px;
    }

    100% {
        margin-left: -2125px;
    }
}

@-webkit-keyframes

"bannermove" {
    0%

{
    margin-left: 0px;
}

100% {
    margin-left: -2125px;
}

}

@-ms-keyframes

"bannermove" {
    0%
        }
{
    margin-left: 0px;
}

100% {
    margin-left: -2125px;
}

}

@-o-keyframes

"bannermove" {
    0%

{
    margin-left: 0px;
}

100% {
    margin-left: 2125px;
}

}

.fa {
    padding: 20px;
    font-size: 30px;
    width: 50px;
    text-align: center;
    text-decoration: none;
    // margin: 5px 2px;
}

    .fa:hover {
        opacity: 0.7;
    }

.fa-facebook {
    background: #3B5998;
    color: white;
}

.fa-twitter {
    background: #55ACEE;
    color: white;
}

.fa-google {
    background: #dd4b39;
    color: white;
}


.fa-instagram {
    background: #125688;
    color: white;
}

.fa-pinterest {
    background: #cb2027;
    color: white;
}

.panel-heading {
    color: white;
}

.carousel slide {
    top: 4px;
}

.btn btn-info {
    background-color: #7bc143;
    border-color: #7bc143;
    color: #FFF;
}

body .btn-primary:hover, body .btn-primary:focus {
    border-color: #6fb03a;
    background-color: #6fb03a;
    color: #FFF;
}

body .btn-primary:active, body .btn-primary:visited, body .btn-primary:active:focus, body .btn-primary:active:hover {
    border-color: #639d34;
    background-color: #639d34;
    color: #FFF;
}

.main-menu hidden-xs {
    overflow: hidden;
    color: white;
    width: 100%;
    height: 100em;
    font-weight: bold;
    position: fixed;
    top: 0;
    z-index:10;
    box-shadow: 0 5px 10px rgba(0,0,0,9.0);
}

.nav {
    //background-color: #000000;
    color: white;
    list-style: none;
    text-align: right;
   // padding: 20px 0 20px 0;
    font-weight: bold;
}

    .nav > li {
        display: inline-block;
       // padding: 0 25px 0 25px;
        font-size: 10px
    }

        .nav > li > a {
            text-decoration: none;
            color: white;
            font-style: italic;
            font-size: 15px;
        }

            .nav > li > a:hover {
                color: #10e5fe;
            }

.dropdown-content {
    display: none;
    position: absolute;
    background-color: #f9f9f9;
    min-width: 160px;
    box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.3);
    z-index: 1;
}

    .dropdown-content a {
        color: white;
        background-color: black;
         padding: 12px 16px;
        text-decoration: none;
        display: block;
        text-align: left;
        font-size: 15px;
    }

        .dropdown-content a:hover {
            color: #10e5fe;
        }

.ROOMS:hover .dropdown-content {
    display: block;
}


    </style>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="lblSuccess" runat="server" Text=></asp:Label>
    <div id="container">
        <header >
                <div class="panel-heading">Contact: 880-1677348014</div>
            <div class="row">
            <div class="col-lg-5" style="background-color:transparent;">
                <div class="header-links">
                    <a href="https://www.facebook.com/" class="fa fa-facebook"></a>
                    <a href="https://twitter.com/" class="fa fa-twitter"></a>
                    <a href="https://plus.google.com/" class="fa fa-google"></a>
                    <a href="https://www.instagram.com/" class="fa fa-instagram"></a>
                    <a href="https://www.pinterest.com/" class="fa fa-pinterest"></a>
                    <h3 style="color:#fff">SIGNED IN</h3>
                </div>
            </div>
          </div>
          
        </header>
        <div class="row">
        <div class="col-lg-12">
        <div class="photobanner">
            <img class="first" src="pic/bedroom_1.jpg" alt="" />
            <img src="pic/bedroom_2.jpg" alt="" />
            <img src="pic/bedroom_3.jpg" alt="" />
            <img src="pic/bedroom_4.jpg" alt="" />
            <img src="pic/bedroom_5.jpg" alt="" />
            <img src="pic/bedroom_6.jpg" alt="" />
            <img src="pic/bedroom_1.jpg" alt="" />
            <img src="pic/bedroom_2.jpg" alt="" />
            <img src="pic/bedroom_3.jpg" alt="" />
            <img src="pic/bedroom_4.jpg" alt="" />
        </div>
            </div>
            </div>
        <div class="col-lg-12" style="background-color:black;">
            <div class="panel-heading">
                <p> <marquee behavior="scroll" direction="left" onmouseover="stop()" onmouseout="start()"><font color="white"><h3>WELCOME TO HOTEL STNC !!!</h3></font><font color="darkslategrey"><h4>Enjoy the pleasure  with STNC...</h4></font></marquee><br> </p>
            </div>
        </div>
       

        </div>
       <br />
        <div class="col-lg-12" style="background-color:black;"></div>

        <div class="row">
            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/bedroom_2.jpg" alt="">
                    <div class="overlay">
                        <h2>4000 Tk per night</h2>
                        <a class="info" href="RoomHome.aspx">DETAILS</a>
                    </div>
                    <h2>ROYAL SUIT</h2>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/bedroom_3.jpg" alt="">
                    <div class="overlay">
                        <h2>3000 Tk per night</h2>
                        <a class="info" href="RoomHome.aspx">DETAILS</a>
                    </div>
                    <h2>DELUXE SUIT</h2>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/bedroom_4.jpg" alt="">
                    <div class="overlay">
                        <h2>2500 Tk per night</h2>
                        <a class="info" href="RoomHome.aspx">DETAILS</a>
                    </div>
                    <h2>Double ROOM</h2>
                </div>
            </div>


            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/bedroom_2.jpg" alt="">
                    <div class="overlay">
                        <h2>5000 Tk per night</h2>
                        <a class="info" href="RoomHome.aspx"">DETAILS</a>
                    </div>
                    <h2>SINGLE ROOM</h2>
                </div>

            </div>

            <div class="col-lg-12" style="background-color:black;"></div>
             <br />
        <div class="col-lg-12" style="background-color:black;"></div>

        <div class="row">
            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/food2.jpg" alt="">
                    <div class="overlay">
                        <h2>Taste Our Food</h2>
                        <a class="info" href="FoodHome.aspx">DETAILS</a>
                    </div>
                    <h2>Book Us</h2>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/food3.jpg" alt="">
                    <div class="overlay">
                        <h2>Taste Our Food</h2>
                        <a class="info" href="FoodHome.aspx">DETAILS</a>
                    </div>
                    <h2>Book Us</h2>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/food4.jpg" alt="">
                    <div class="overlay">
                        <h2>Taste Our Food</h2>
                        <a class="info" href="FoodHome.aspx">DETAILS</a>
                    </div>
                    <h2>Book Us</h2>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/food5.jpg" alt="">
                    <div class="overlay">
                        <h2>Taste Our Food</h2>
                        <a class="info" href="FoodHome.aspx">DETAILS</a>
                    </div>
                    <h2>Boook Us</h2>
                </div>

            </div>
            <div class="col-lg-12" style="background-color:black;"></div>
                <br />
        <div class="col-lg-12" style="background-color:black;"></div>

        <div class="row">
            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/birthday.jpg" alt="">
                    <div class="overlay">
                        <h2>Book US</h2>
                        <a class="info" href="Event.aspx">DETAILS</a>
                    </div>
                    <h2>On Your SPECIAL OCCASION</h2>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/Conference1.jpg" alt="">
                    <div class="overlay">
                        <h2>Book US</h2>
                        <a class="info" href="Event.aspx">DETAILS</a>
                    </div>
                    <h2>On Your SPECIAL OCCASION</h2>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/wedding2.jpg" alt="">
                    <div class="overlay">
                        <h2>Book US</h2>
                        <a class="info" href="Event.aspx">DETAILS</a>
                    </div>
                    <h2>On Your SPECIAL OCCASION</h2>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="hovereffect">
                    <img class="img-responsive" src="pic/music1.jpg" alt="">
                    <div class="overlay">
                        <h2>Book US</h2>
                        <a class="info" href="Event.aspx">DETAILS</a>
                    </div>
                    <h2>On Your SPECIAL OCCASION</h2>
                </div>
            </div>



            <div class="col-lg-12" style="background-color:black;"></div>
            <div class="row">
                <div class="panel-heading" style="background-color:white;">
                    <div class="panel-body"></div>
                </div>
                <div class="col-lg-6 col-lg-offset-3 text-center"><h4>OUR AWESOME SERVICES</h4></div>
                <div class="panel-heading" style="background-color:white;">
                    <div class="panel-body"></div>
                </div>

                <div class="col-lg-6" style="background-color:white;">
                    <div class="panel panel-default">
                        <div class="panel-heading">

                            <div class="panel-body">
                                <div>
                                    <span class="glyphicon glyphicon-heart"></span>
                                    <label for="inputState">SPA-BEAUTY & HEALTH</label>
                                </div>
                            </div>

                        </div>
                        <div class="panel-heading" style="background-color:white;"> </div>
                        <div class="panel-heading">
                            <div class="panel-body">
                                <div>
                                    <span class=" glyphicon glyphicon-tint"></span>
                                    <label for="inputState">SWIMMING POOL</label>
                                </div>
                            </div>

                        </div>
                        <div class="panel-heading" style="background-color:white;"> </div>
                        <div class="panel-heading">
                            <div class="panel-body">
                                <div>
                                    <span class="glyphicon glyphicon-glass"></span>
                                    <span class="glyphicon glyphicon-cutlery"></span>
                                    <label for="inputState">RESTAURANT</label>
                                </div>
                            </div>

                        </div>
                        <div class="panel-heading" style="background-color:white;"> </div>
                        <div class="panel-heading">
                            <div class="panel-body">
                                <div>
                                    <span class="glyphicon glyphicon-user"></span>
                                    <label for="inputState">CONFERENCE</label>
                                </div>
                            </div>

                        </div>

                    </div>
                </div>
                <div class="col-lg-6">
                    <img src="pic/pic7.jpg" class="img-circle" alt="Cinque Terre" width="604" height="425">
                </div>
            </div>
            
        </div>
    
</asp:Content>
