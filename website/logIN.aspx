<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logIN.aspx.cs" Inherits="WebApplication3.logIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="animation1.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="scripts/jquery-1.9.1.min.js"></script>
    <link href="animation.css" rel="stylesheet" />
    <script src="scripts/bootstrap.min.js"></script>
    <link href="home.css" rel="stylesheet" />
    <title></title>
    <script type="text/javascript" language="javascript">
function DisableBackButton() {
window.history.forward()
}
DisableBackButton();
window.onload = DisableBackButton;
window.onpageshow = function(evt) { if (evt.persisted) DisableBackButton() }
window.onunload = function() { void (0) }
</script>
   <style>
body, html {
    height: 100%;
    margin: 0;
}

.bg {
    /* The image used */
    background-image: url("pic/login.jpg");

    /* Full height */
    height: 100%; 

    /* Center and scale the image nicely */
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
}

</style>
</head>
<body>
     <div class="bg">
          <div class="row ">
            <div class="col-lg-6 ">
                <a href="hoome.aspx"><img src="pic/logo.png" /></a>
            </div>          
            <div class="col-lg-6">
                <div class="header-links">
                    <a href="https://www.facebook.com/" class="fa fa-facebook"></a>
                    <a href="https://twitter.com/" class="fa fa-twitter"></a>
                    <a href="https://plus.google.com/" class="fa fa-google"></a>
                    <a href="https://www.instagram.com/" class="fa fa-instagram"></a>
                    <a href="https://www.pinterest.com/" class="fa fa-pinterest"></a>
                </div>
            </div>
        </div>
   
     
        <form id="form1" runat="server" style="text-align:center; vertical-align: middle">
            <br />
        <asp:Label ID="usernamelbl" runat="server" Text="User Name" Font-Bold="true"></asp:Label>        
        <br/>
        <br />
        <asp:TextBox ID="usernametxt" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="passwordlbl" runat="server" Text="Password" Font-Bold="true"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="passwordtxt" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="loginbtn" runat="server" style="position:center" Text="Log In" Font-Bold="true" Width="99px" OnClick="loginbtn_Click" />  
        <br />
        <br />
        <br />
        <div class="row">
        <asp:Label ID="invite" runat="server" Text="Not a member yet ?" Font-Bold="true"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="regbtn" runat="server" OnClick="regbtn_Click" Text="Join Us" Font-Bold="true" Width="99px" />
       </div>
        <br />
        <br />
        <a href="hoome.aspx">
         <img border="0"  src="pic/holiday.jpg"width="80" height="80"/>
            <br />
        </a>
     </form>
   </div>  
</body>
</html>
