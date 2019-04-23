<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserFood.aspx.cs" Inherits="WebApplication3.UserFood" %>


<asp:content id="Content1" contentplaceholderid="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="row" style="padding-top: 50px">
        <asp:Repeater ID="rptrProducts" runat="server">
            <ItemTemplate>
                <div class="col-sm-3 col-md-3">
                    <table>
                    <a style="text-decoration:none;" href="FoodView.aspx?FID=<%#Eval("FID") %>">
                    
                     <div class="thumbnail">
                        <img src="pic\Food\<%#Eval("FName")%><%#Eval("FExtention")%>" />
                        <div class="caption">
                            <div ><%#Eval("FName") %></div>
                            <div><span><%#Eval("FPrice") %></span></div>
                            <div><span><%#Eval("FCatName") %></span></div>
                        </div>
                     </table>
                    </div>
                  </a
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:content>

