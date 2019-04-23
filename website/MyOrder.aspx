<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="MyOrder.aspx.cs" Inherits="WebApplication3.MyOrder" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
        .style3
        {
         width: 151px;
     }
        .style4
        {
     }
        </style>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    
    <table class="tbl">
        <tr>
            <td class="tblhead" colspan="3"  style="color: #663300; background-color: #FFFFCC; font-weight: bold; font-size: medium">
                           Order History -
                            <asp:Label ID="lbl1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                            &nbsp;</td>
            <td class="style4">
                            &nbsp;</td>
            <td>
                            &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                            &nbsp;</td>
            <td class="style4" colspan="2">
                            <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
                    ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Width="902px" 
                                DataKeyNames="Order_ID">
                                <AlternatingRowStyle BackColor="White" />
                            <Columns>
                            
                            <asp:BoundField HeaderText="Order Type" DataField="type" />
                            <asp:BoundField HeaderText="Price" DataField="price" />
                            <asp:BoundField HeaderText="Date" DataField="date" />
                            <asp:BoundField HeaderText="Time" DataField="time" />
                            <asp:BoundField HeaderText="PaymentID" DataField="paymentID" />
                            <asp:BoundField HeaderText="PaymentMethod" DataField="paymentMethod" />
                            </Columns>
                                <FooterStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                <SortedDescendingHeaderStyle BackColor="#820000" />
                            </asp:GridView>
            </td>
        </tr>
       
    </table>
    <br />
   
</asp:Content>

