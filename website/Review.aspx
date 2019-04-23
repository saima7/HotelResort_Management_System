<%@ Page Language="C#" MasterPageFile="~/User.Master"  AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="WebApplication3.Review" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <br />
    <div class="container">
        <div class="form-horizontal">
            <h2>Do you have any questions? </h2>
            <h4>Please do not hesitate to contact us directly. </h4>
            <h4> Our team will come back to you within matter of hours to help you.</h4>
            <hr />
            <asp:Label ID="Label1" runat="server" Text="User ID"></asp:Label>&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <div class="form-group">
                <asp:Label ID="lblSub" runat="server" CssClass="col-md-2 control-label" Text="Subject"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtSub" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" CssClass="text-danger" runat="server" ErrorMessage="This field is Required !" ControlToValidate="txtSub"></asp:RequiredFieldValidator>
                </div>
            </div>
            
            <div class="form-group">
                <asp:Label ID="lblDet" runat="server" CssClass="col-md-2 control-label" Text="Detail"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtDet" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="text-danger" runat="server" ErrorMessage="This field is Required !" ControlToValidate="txtDet"></asp:RequiredFieldValidator>
                </div>
            </div>
    
            
            <div class="form-group">
                <div class="col-md-2"></div>
                <div class="col-md-6">
                    <asp:Button ID="btnAdd" runat="server" Text="SEND" class="btn btn-primary" OnClick="btnAdd_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
