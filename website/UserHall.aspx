<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserHall.aspx.cs" Inherits="WebApplication3.UserHall" %>

<asp:content id="Content1" contentplaceholderid="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Enter the maximum guest Number To choose your Hall"></asp:Label>
    <div class="row" style="padding-top: 50px">
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
                    <a style="text-decoration:none;" href="HallView.aspx?HallID=<%#Eval("HallID") %>">
                    
                     <div class="thumbnail">                
                        <div class="caption">                           
                            <div ><h4>HallName</h4><%#Eval("HallName") %></div>
                            <div><h4>Price</h4><span><%#Eval("price") %></span></div>
                            <div><h4>Category</h4><span><%#Eval("HallCatName") %></span></div>
                            <div><h4>AvaiableDate</h4><span><%#Eval("AvailableDate") %></span></div>
                        </div>
                     </table>
                    </div>
                  </a
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:content>