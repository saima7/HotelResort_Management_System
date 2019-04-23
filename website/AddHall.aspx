<%@ Page Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddHall.aspx.cs" Inherits="WebApplication3.AddHall" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    <div class="container">
        <div class="form-horizontal">
            <h2>Add Hall</h2>
            <hr />

            <label class="col-xs-11">Hall Name</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbHname" runat="server" Class="form-control" placeholder="HallName"></asp:TextBox>
            </div>
            <label class="col-xs-11">Category</label>
            <div class="form-group">
                <div class="col-xs-11">
                    <asp:DropDownList ID="ddlCat" AutoPostBack="True"   AppendDataBoundItems="true" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
            </div>
             <label class="col-xs-11">Price</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbPrice" runat="server" Class="form-control" placeholder="Price"></asp:TextBox>
            </div>
            <label class="col-xs-11">Purpose</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbPur" runat="server" Class="form-control" placeholder="Purpose"></asp:TextBox>
            </div>
            <label class="col-xs-11">Capacity</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbCap" runat="server" Class="form-control" placeholder="Capacity"></asp:TextBox>
            </div>
            <label class="col-xs-11">Description</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbDes" runat="server" Class="form-control" placeholder="Description"></asp:TextBox>
            </div>
            
            <label class="col-xs-11">Availability</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbDate" runat="server" Width="92px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" ImageUrl="~/pic/calender.png" OnClick="ImageButton1_Click" Width="31px" />
                <br />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" OnSelectionChanged="Calendar1_SelectionChanged">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
           </div>
              
            <div class="col-xs-11 space-vert">
                 <br />
                <asp:Button ID="btAdd" runat="server" Class="btn btn-success" Text="ADD" OnClick="btAdd_Click" />
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </div>

        </div>
        <!-- Hall add -->
       </div>
</asp:Content>