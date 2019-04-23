<%@ Page Language="C#"  MasterPageFile="~/AdminMaster.Master"  AutoEventWireup="true" CodeBehind="AdminNewOrder.aspx.cs" Inherits="WebApplication3.AdminNewOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />

    <asp:Label ID="lblSuccess" runat="server" Text=></asp:Label>
    <table class="tbl">
        <tr>
            <td class="tblhead">
                NEW ORDER -
                <asp:Label ID="lbll" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
                                CellPadding="2" ForeColor="Black" GridLines="None" DataKeyNames="FOID" 
                                 Width="938px" onrowcommand="GridView1_RowCommand" >
                              
                                
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:BoundField DataField="userName" HeaderText="User Name" 
                                        SortExpression="userName" >
                    <ItemStyle Width="250px" />
                    </asp:BoundField>
                    
                    <asp:BoundField DataField="FName" HeaderText="FoodName" 
                                        SortExpression="FName" >
                    <ItemStyle Width="180px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FPrice" HeaderText="Price" SortExpression="FPrice" />
                    <asp:BoundField DataField="Qnt" HeaderText="Qnt" 
                                        SortExpression="FName" />
                    <asp:BoundField DataField="TotalPrice" HeaderText="Total Price" 
                                        SortExpression="TotalPrice" />
                    <asp:TemplateField HeaderText="Dispatch">
                        <ItemTemplate>
                            <asp:LinkButton Text="Dispatch" runat="server" ID="lnkclear" CommandArgument='<%#Eval("FOID") %>' ForeColor="Blue"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
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


