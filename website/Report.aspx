<%@ Page Language="C#"  MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="WebApplication3.Report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />

    <asp:Label ID="lblSuccess" runat="server" Text=></asp:Label>
    <table class="tbl">
    <tr>
        <td class="tblhead">
            VIEW REPORT</td>
    </tr>
    <tr>
        <td class="tblhead">
            Select User :
            <asp:DropDownList ID="ddluser" runat="server" CssClass="txt" AppendDataBoundItems="true">
            </asp:DropDownList>
           

            <asp:Button ID="btnselect" runat="server" CssClass="btn" 
                onclick="btnselect_Click" Text="Select" />
&nbsp;</td>
    </tr>
    <tr>
        <td class="tblhead">
            <asp:Label ID="lbl" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
                                CellPadding="2" ForeColor="Black" GridLines="None" DataKeyNames="Order_ID" 
                                 Width="938px" >
                              
                                
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:BoundField DataField="user_name" HeaderText="User Name" 
                                        SortExpression="user_name" >
                    <ItemStyle Width="250px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="type" HeaderText="Product Type" 
                                        SortExpression="type" >
                    <ItemStyle Width="180px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" ><ItemStyle Width="250px" /></asp:BoundField>
                    <asp:BoundField DataField="date" HeaderText="Date" 
                                        SortExpression="date" ><ItemStyle Width="250px" /></asp:BoundField>
                    <asp:BoundField DataField="time" HeaderText="Time" 
                                        SortExpression="time" ><ItemStyle Width="250px" /></asp:BoundField>
                    <asp:BoundField DataField="paymentID" HeaderText="Payment ID" 
                                        SortExpression="paymentID" ><ItemStyle Width="250px" /></asp:BoundField>
                     <asp:BoundField DataField="paymentMethod" HeaderText="Payment Method" 
                                        SortExpression="paymentMethod" />
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                                    HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>
