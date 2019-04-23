<%@ Page Language="C#"  MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="RoomConfirmation.aspx.cs" Inherits="WebApplication3.RoomConfirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="lblSuccess" runat="server" Text="Label"></asp:Label>
    <div class="container">
        <div class="form-horizontal">
            <h2>Confirm Room</h2>
            <hr />
            <label class="col-xs-11">Room ID</label>
            <div class="col-xs-11">
                <asp:Label ID="rID" runat="server" Text="Label"></asp:Label>
            </div>
            <label class="col-xs-11">Custome Name</label>
            <div class="col-xs-11">
                <asp:Label ID="CusName" runat="server" Text="Label"></asp:Label>
            </div>
            <label class="col-xs-11">Custome Mail</label>
            <div class="col-xs-11">
            <asp:Label ID="CusMail" runat="server" Text="Label"></asp:Label>
              </div>
             <label class="col-xs-11">Phone</label>
            <div class="col-xs-11">
                <asp:Label ID="CusPhn" runat="server" Text="Label"></asp:Label>
            </div>

            <label class="col-xs-11">Rent</label>
            <br />
            <div class="col-xs-11">
            <asp:Label ID="Rent" runat="server" Text="Label"></asp:Label>
             </div>
            <br /> 

            <div>
            <label class="col-xs-11">CheckIN Date</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbDate" runat="server" Width="92px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" ImageUrl="~/pic/calender.png" OnClick="ImageButton1_Click" Width="31px" />
                <br />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" OnDayRender=" Calendar1DayRender" OnSelectionChanged="Calendar1_SelectionChanged">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
                <b><span style="color: Red">Red</span></b><span> - Booked</span>
           </div>
             </div>
            
            <div>
            <label class="col-xs-11">CheckOut Date</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbDate2" runat="server" Width="92px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton2" runat="server" Height="22px" ImageUrl="~/pic/calender.png" OnClick="ImageButton2_Click" Width="31px" />
                <br />
            <asp:Calendar ID="Calendar2" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" OnDayRender="Calendar2DayRender" OnSelectionChanged="Calendar2_SelectionChanged">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
                <b><span style="color: Red">Red</span></b><span> - Booked</span>
           </div>
          </div>
            
            <div class="col-xs-11 space-vert">
                 <br />
                <asp:Button ID="btAdd" runat="server" Class="btn btn-success" Text="Cart" OnClick="btAdd_Click" />
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </div>

        </div>
        <!-- Hall add -->
       </div>
     <asp:Label ID="checkin" runat="server" visible="false" Text="Label"></asp:Label>
    <asp:Label ID="checkout" runat="server" visible="false" Text="Label"></asp:Label>
     <asp:Label ID="checkin1" runat="server" visible="false" Text="Label"></asp:Label>
    <asp:Label ID="checkout1" runat="server" visible="false" Text="Label"></asp:Label>
     <asp:Label ID="checkin2" runat="server" visible="false" Text="Label"></asp:Label>
    <asp:Label ID="checkout2" runat="server" visible="false" Text="Label"></asp:Label>
     <asp:Label ID="checkin3" runat="server" visible="false" Text="Label"></asp:Label>
    <asp:Label ID="checkout3" runat="server" visible="false" Text="Label"></asp:Label>


</asp:Content>
