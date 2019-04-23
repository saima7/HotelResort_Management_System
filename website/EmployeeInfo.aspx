<%@ Page Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeInfo.aspx.cs" Inherits="WebApplication3.EmployeeInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblSuccess" runat="server" Text="Label"></asp:Label>
        <br />
         <br />
        <asp:Label ID="lblEmployeeDtls" runat="server" Text="Employee Details" Width="182px" Font-Bold="true"></asp:Label><br />
        <br />
         <br />
    <asp:Label ID="test" runat="server" Text="Label" Visible="False"></asp:Label>
        <table>
            <tr>
                <td style="height: 21px">
                    <asp:Label ID="Label2" runat="server" Text="Employee ID"></asp:Label></td>
                <td style="width: 498px; height: 21px">
                    <asp:Label ID="lblEmployeeID" runat="server" BorderColor="Black"></asp:Label></td>
                
            </tr>
            
            
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label></td>
                <td style="width: 498px">
                    <asp:TextBox ID="txtName" runat="server" MaxLength="50" ></asp:TextBox></td>
                
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Phone"></asp:Label></td>
                <td style="width: 498px">
                    <asp:TextBox ID="txtPhone" runat="server" MaxLength="10" ></asp:TextBox>
                    
                
            </tr>
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtAddress" runat="server" MaxLength="100" ></asp:TextBox>
                    </td>
                   
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblRole" runat="server" Text="Role"></asp:Label>
                </td>
                <td style="width: 498px">
                    <asp:DropDownList ID="lstRole" runat="server"
                       DataTextField="Role" 
                       DataValueField="JobId" >                     
                </asp:DropDownList>

               </td>
               
            </tr>
            
			 	<tr>
                <td style="height: 26px">
                    <asp:Label ID="Label7" runat="server" Text="Salary"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtSalary" runat="server" MaxLength="8" ></asp:TextBox>
                    
               
            </tr>
			 	
            
            
            
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label1" runat="server" Text="ManagerId"></asp:Label>
                </td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtMan" runat="server"></asp:TextBox>
                 </td>
               
            </tr>
            
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label6" runat="server" Text="Cell"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtCell" runat="server" MaxLength="11" ></asp:TextBox>
               
            </tr>
            
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtPassword" runat="server" MaxLength="6" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="Please enter password"></asp:RequiredFieldValidator></td>
               
            </tr>
            
            <tr>
                <td >
                </td>
                
                <td  style="width: 498px">
                    <br />
                    <asp:Button ID="cmdUpdate" runat="server" Text="Update" OnClick="cmdUpdate_Click" />
                    <asp:Button ID="cmdSuper" runat="server" Text="View Supervised Employees" Visible="false" Enabled="true" OnClick="cmdSuper_Click" />
                    <asp:Button ID="cmdDelete" runat="server" OnClick="cmdDelete_Click" Text="Delete" />
                </td>
                
            </tr>
        </table>

            
</asp:Content>           
	
