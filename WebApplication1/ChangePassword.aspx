<%@ Page Title="Change Password" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="WebApplication1.ChangePassword" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Change Password</h1>
    <p>&nbsp;</p>
    <p>Old Password<asp:TextBox ID="password0" runat="server"></asp:TextBox>
    </p>
    <p>New Password<asp:TextBox ID="password1" runat="server"></asp:TextBox>
    </p>
    <p>Type Again<asp:TextBox ID="password2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Confirm" OnClick="Button1_Click" />
    </p>
    <p>&nbsp;</p>


</asp:Content>
