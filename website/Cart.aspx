<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebApplication3.Cart" %>

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
                            Food CART -
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
                                DataKeyNames="FOID" onrowdeleting="GridView1_RowDeleting" 
                                onrowupdating="GridView1_RowUpdating" ShowFooter="True">
                                <AlternatingRowStyle BackColor="White" />
                            <Columns>
                            
                            <asp:BoundField HeaderText="Food Name" DataField="FName" />
                            <asp:BoundField HeaderText="Price" DataField="FPrice" />
                            <asp:TemplateField HeaderText="Qnt">
                            <ItemTemplate>
                            <asp:TextBox runat="server" ID="txtq" Text='<%#Eval("Qnt")%>' Height="20px" Width="20px"></asp:TextBox>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="TotalPrice" DataField="totalprice" />
                            <asp:TemplateField HeaderText="Update">
                            <ItemTemplate>
                            <asp:LinkButton runat="server" Text="Update" ID="lnkupd" CommandName="update" ForeColor="Blue" CommandArgument='<%#Eval("FOID") %>'></asp:LinkButton>

                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Remove">
                            <ItemTemplate>
                            <asp:LinkButton runat="server" Text="Remove" ID="lnkrem" CommandName="Delete" ForeColor="Red" CommandArgument='<%#Eval("FOID") %>'></asp:LinkButton>

                            </ItemTemplate>
                            </asp:TemplateField>
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
            <td class="style4">
                            <asp:Button ID="Button1" runat="server" PostBackUrl="~/UserHome.aspx" 
                                Text="Continew Shopping" onclick="Button1_Click" />
&nbsp;<asp:Button ID="btnchckout" runat="server" Text="CheckOut" onclick="btnchckout_Click" />
            </td>
            <td>
                            &nbsp;</td>
        </tr>
    </table>
    <br />






    <table class="tbl">
        <tr>
            <td class="tblhead" colspan="3"  style="color: #663300; background-color: #FFFFCC; font-weight: bold; font-size: medium">
                            Hall CART -
                            <asp:Label ID="lbl2" runat="server"></asp:Label>
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
                            <asp:GridView ID="GridView2" runat="server" CellPadding="4" 
                    ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Width="902px" 
                                DataKeyNames="HOID" onrowdeleting="GridView2_RowDeleting" ShowFooter="True" >
                                <AlternatingRowStyle BackColor="White" />
                            <Columns>
                            
                            <asp:BoundField HeaderText="Hall Name" DataField="HallName" />
                            <asp:BoundField HeaderText="Price" DataField="Price" />
          
                            <asp:TemplateField HeaderText="Remove">
                            <ItemTemplate>
                            <asp:LinkButton runat="server" Text="Remove" ID="lnkrem" CommandName="Delete" ForeColor="Red" CommandArgument='<%#Eval("HOID") %>'></asp:LinkButton>

                            </ItemTemplate>
                            </asp:TemplateField>
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
            <td class="style4">
                            <asp:Button ID="Button2" runat="server" PostBackUrl="~/UserHome.aspx" 
                                Text="Continew Shopping" onclick="Button2_Click" />
                     &nbsp;<asp:Button ID="btn2chkout" runat="server" Text="CheckOut" onclick="btn2chkout_Click" />
            </td>
            <td>
                            &nbsp;</td>
        </tr>
    </table>
    <br />





     <table class="tbl">
        <tr>
            <td class="tblhead" colspan="3"  style="color: #663300; background-color: #FFFFCC; font-weight: bold; font-size: medium">
                            Table CART -
                            <asp:Label ID="lbl3" runat="server"></asp:Label>
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
                            <asp:GridView ID="GridView3" runat="server" CellPadding="4" 
                    ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Width="902px" 
                                DataKeyNames="TOID" onrowdeleting="GridView3_RowDeleting" ShowFooter="True" >
                                <AlternatingRowStyle BackColor="White" />
                            <Columns>
                            
                            <asp:BoundField HeaderText="No Of Seat" DataField="NoOfSeat" />
                            <asp:BoundField HeaderText="Time" DataField="time" />
                            <asp:BoundField HeaderText="Price" DataField="Price" />
          
                            <asp:TemplateField HeaderText="Remove">
                            <ItemTemplate>
                            <asp:LinkButton runat="server" Text="Remove" ID="lnkrem" CommandName="Delete" ForeColor="Red" CommandArgument='<%#Eval("TOID") %>'></asp:LinkButton>

                            </ItemTemplate>
                            </asp:TemplateField>
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
            <td class="style4">
                            <asp:Button ID="Button3" runat="server" PostBackUrl="~/UserHome.aspx" 
                                Text="Continew Shopping" onclick="Button3_Click" />
                     &nbsp;<asp:Button ID="btn3chkout" runat="server" Text="CheckOut" onclick="btn3chkout_Click" />
            </td>
            <td>
                            &nbsp;</td>
        </tr>
    </table>

    <br />



    
    <table class="tbl">
        <tr>
            <td class="tblhead" colspan="3"  style="color: #663300; background-color: #FFFFCC; font-weight: bold; font-size: medium">
                            Room CART -
                            <asp:Label ID="lbl4" runat="server"></asp:Label>
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
                            <asp:GridView ID="GridView4" runat="server" CellPadding="4" 
                    ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Width="902px" 
                                DataKeyNames="ROID" onrowdeleting="GridView4_RowDeleting" ShowFooter="True" >
                                <AlternatingRowStyle BackColor="White" />
                            <Columns>
                            
                            <asp:BoundField HeaderText="Room ID" DataField="room_id" />
                            <asp:BoundField HeaderText="Price" DataField="price" />
                            <asp:BoundField HeaderText="CheckIn Date" DataField="checkin" />
                            <asp:BoundField HeaderText="CheckOut Date" DataField="checkout" />
          
                            <asp:TemplateField HeaderText="Remove">
                            <ItemTemplate>
                            <asp:LinkButton runat="server" Text="Remove" ID="lnkrem" CommandName="Delete" ForeColor="Red" CommandArgument='<%#Eval("ROID") %>'></asp:LinkButton>

                            </ItemTemplate>
                            </asp:TemplateField>
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
            <td class="style4">
                            <asp:Button ID="Button4" runat="server" PostBackUrl="~/UserHome.aspx" 
                                Text="Continew Shopping" onclick="Button4_Click" />
                     &nbsp;<asp:Button ID="btn4chkout" runat="server" Text="CheckOut" onclick="btn4chkout_Click" />
            </td>
            <td>
                            &nbsp;</td>
        </tr>
    </table>

    <asp:Label ID="Label1" runat="server" Text="0" Visible="false"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="0" Visible="false"></asp:Label>
    <asp:Label ID="Label3" runat="server" Text="0" Visible="false"></asp:Label>
    <asp:Label ID="Label4" runat="server" Text="0" Visible="false"></asp:Label>
    <asp:Label ID="Label5" runat="server" Text="0" Visible="false"></asp:Label>
    <br />
    <br />
    <br />
    <br />
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <asp:Button ID="Button5" runat="server" PostBackUrl="~/UserHome.aspx" 
                                Text="Continew Shopping" onclick="Button5_Click" />
                     &nbsp;<asp:Button ID="btnAllchkout" runat="server" Text="ALL CheckOut" onclick="btnAllchkout_Click" />
</asp:Content>

