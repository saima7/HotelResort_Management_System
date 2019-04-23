<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="MyAccount.aspx.cs" Inherits="WebApplication3.MyAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblSuccess" runat="server" Text="Label"></asp:Label>
        <br />
         <br />
        <asp:Label ID="lblEmployeeDtls" runat="server" Text="My Account" Width="182px" Font-Bold="true"></asp:Label><br />
        <br />
         <br />
    
        <table>
            <tr>
                <td style="height: 21px; width:150px">
                    <asp:Label ID="Label2" runat="server" Text="User ID"></asp:Label></td>
                <td style="width: 498px; height: 21px">
                    <asp:Label ID="lblUserID" runat="server" BorderColor="Black"></asp:Label></td>               
            </tr>
            <tr>
                <td style="height: 10px">                   
                <td style="width: 498px; height: 10px">    
            </tr>
                      
            <tr>


                <td>
                    <asp:Label ID="Label3" runat="server" Text="User Name"></asp:Label></td>
                <td style="width: 498px">
                    <asp:Label ID="txtNam" runat="server" BorderColor="Black"></asp:Label> </td>                                                     
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Full Name"></asp:Label></td>
                <td style="width: 498px">
                    <asp:TextBox ID="txtFullName" runat="server" MaxLength="10" ></asp:TextBox>
                    
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Phone"></asp:Label></td>
                <td style="width: 498px">
                    <asp:TextBox ID="txtPhone" runat="server" MaxLength="10" ></asp:TextBox>
                    
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Email"></asp:Label></td>
                <td style="width: 498px">
                    <asp:TextBox ID="txtEmail" runat="server" MaxLength="10" ></asp:TextBox>
                    
                
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
                <td style="height: 26px">
                    <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label></td>
                <td style="width: 498px; height: 26px;">
                    <asp:TextBox ID="txtAddress" runat="server" MaxLength="100" ></asp:TextBox>
                    </td>
                   
            </tr>
                           
            <tr>
                <td >
                </td>
                
                <td  style="width: 498px">
                    <br />
                    <asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click" />
                </td>
                
            </tr>
        </table>

            
</asp:Content>           
	