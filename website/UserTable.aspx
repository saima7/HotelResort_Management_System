<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserTable.aspx.cs" Inherits="WebApplication3.UserTable" %>


<asp:content id="Content1" contentplaceholderid="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <br />
    <br />
     <asp:Label ID="Label2" runat="server" Text="You Can only Book Table for Tomorrow"></asp:Label>
    
    
    <div class="row" style="padding-top: 50px">
        <asp:Label ID="Label1" runat="server" Text="Enter the Number Of Seat or the time"></asp:Label>
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
                    <a style="text-decoration:none;" href="TableView.aspx?TableID=<%#Eval("TableID") %>">
                    
                     <div class="thumbnail">                
                        <div class="caption">                           
                            <div ><h4>No of Seat</h4><%#Eval("NoOfSeat") %></div>
                            <div><h4>Time</h4><span><%#Eval("time") %></span></div>
                            <div><h4>Category</h4><span><%#Eval("TableCatName") %></span></div>
                            <div><h4>Booking Money</h4><span><%#Eval("Price") %></span></div>
                        </div>
                     </table>
                    </div>
                  </a
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:content>