<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="WebApplication3.Booking" %>

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
    background-image: url("pic/book2.jpg");

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
    <form id="form1" runat="server"  style="text-align:center; vertical-align: middle; height: 235px;">
        
      
         <br />
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Choose Payment Method :" Font-Bold="true"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Height="32px" Width="140px">
            <asp:ListItem>Bkash</asp:ListItem>
            <asp:ListItem>DBBL</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter TransactionID :" Font-Bold="true" ></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TrxInput" runat="server" Height="20px" Width="174px"></asp:TextBox>
        <p>
            <asp:Button ID="Trxbtn" runat="server" Font-Bold="true" Text="Confirm" OnClick="Button1_Click" />
        </p>
    </form>
        </div>
</body>
</html>
