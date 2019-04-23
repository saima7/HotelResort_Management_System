<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserRoom.aspx.cs" Inherits="WebApplication3.UserRoom" %>

<asp:content id="Content1" contentplaceholderid="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <br />
    <br />
     <asp:Label ID="Label2" runat="server" Text="You Can only Search By Type"></asp:Label>
    
    
    <div class="row" style="padding-top: 50px">
        <asp:Label ID="Label1" runat="server" Text="Enter the type of room"></asp:Label>
         &nbsp; &nbsp;
    <asp:TextBox ID="search" runat="server" Width="200px" height="30px"></asp:TextBox>
         &nbsp; &nbsp;
    <asp:Button ID="btnnSearch" runat="server" class="btn btn-primary navbar-btn" Text="Search"  Width="200px" height="50px" OnClick="btnnSearch_Click" />
   </div>
    <div class="row" style="padding-top: 50px">
        <asp:Repeater ID="rptrProducts" runat="server">
            <ItemTemplate>
                <div class="col-sm-3 col-md-3">
                    <table>
                    <a style="text-decoration:none;" href="RoomView.aspx?room_id=<%#Eval("room_id") %>">
                    
                     <div class="thumbnail">
                        <img src="pic\Room\<%#Eval("room_type")%><%#Eval("image_extension")%>" />
                        <div class="caption">
                            <div ><%#Eval("room_type") %></div>
                            <div><span><%#Eval("rent_fee") %></span></div>
                            <div><span><%#Eval("room_category") %></span></div>
                        </div>
                     </table>
                    </div>
                  </a
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:content>
