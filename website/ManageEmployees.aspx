<%@ Page Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ManageEmployees.aspx.cs" Inherits="WebApplication3.ManageEmployees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <style type="text/css">
        .style2
        {
            width: 931px;
        }
        .style3
        {
            width: 40px;
        }
    </style>
        <br />
        <br />
        <br />
        <br />
       <asp:Label ID="lblSuccess" runat="server" Text="Label"></asp:Label>
       <br />
       <br />
        <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="Large" Text="Employee Management"></asp:Label><br />
        <br />
    <asp:Button ID="cmdMan" runat="server" Text="View Managers" OnClick="cmdMan_Click" />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <asp:Button ID="cmdRep" runat="server" Text="View Receptionists" OnClick="cmdRep_Click" />
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    <asp:Button ID="cmdMain" runat="server" Text="View Maintenance Workers" OnClick="cmdMain_Click" /><br />
        <br />
      
        
    <br />
    <br />
    <table class="tbl">
        <tr>
            <td class="tblhead">
                Employee ACCOUNT -
                <asp:Label ID="lbl" runat="server"></asp:Label>
            </td>
        </tr>
         <tr>
              <td class="style3">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <table class="style2">
                    <tr>
                        <td class="style3">&nbsp;</td>
                        <td>

                           <asp:GridView ID="grdEmployees" runat="server" AutoGenerateColumns="False" 
                                   
                                BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px"
                                DataKeyNames="EmployeeId"
                                CellPadding="4" ForeColor="Black" GridLines="None" Width="921px" 
                                onselectedindexchanged="grdUsers_SelectedIndexChanged">
                                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                                <Columns>
                                    <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeID" />
                                    <asp:BoundField DataField="Name" HeaderText="Name" />
                                    <asp:BoundField DataField="Address" HeaderText="Address" />
                                    <asp:BoundField DataField="Num" HeaderText="Num" />
                                    <asp:BoundField DataField="Role" HeaderText="Role" />
                                    <asp:CommandField SelectText="Edit/Delete" ShowSelectButton="True" />
                                 
                                   
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
            </td>
        </tr>
    </table>
            
</asp:Content>           
