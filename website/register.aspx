<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication3.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
     #Text1 {
         width: 337px;
         margin-left: 29px;
     }
     #Text2 {
         height: 26px;
     }
         
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
     <form id="form1" runat="server" style="text-align:center; vertical-align: middle">
    <div>    
        <br />
        <asp:Label ID="userlbl" runat="server" Text="User Name" Font-Bold="true"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="usertxt" runat="server"></asp:TextBox>        
        <br />
        <br />
        <asp:Label ID="firstlbl" runat="server" Text="Full Name" Font-Bold="true"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="firsttxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lastlbl" runat="server" Text="Mobile No" Font-Bold="true"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="lasttxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="emaillbl" runat="server" Text="Email Address" Font-Bold="true"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="passlbl" runat="server" Text="Password" Font-Bold="true"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="passtxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="reg" runat="server"  Text="Sign Up" Font-Bold="true" Width="95px" OnClick="reg_Click" />
        <br />
        <br />
        <asp:Label ID="return_login" runat="server" Text=" Already a member ?" Font-Bold="true"></asp:Label>
        <br />
        <br />
        <asp:Button ID="signbtn" runat="server" OnClick="signbtn_Click" Text="Go & SignIN" Font-Bold="true" />
         <br />
        <br />
        <a href="hoome.aspx">
         <img border="0"  src="pic/holiday.jpg"width="80" height="80"/>
            <br />
        </a>
    
    </div>
    </form>
        </div>
</body>
</html>

