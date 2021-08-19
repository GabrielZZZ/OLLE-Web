<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    
    <h1><%: Title %>.</h1>
        <h2>Login Page</h2>
        <label>Username</label> <asp:TextBox ID="username" runat="server"></asp:TextBox>
        <br />
        <label>Password</label> <asp:TextBox ID="password" runat="server" Width="122px"></asp:TextBox>
    

    

    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
    

    

    <asp:Button ID="Button2" runat="server" Text="Sign up" />
    

    

</asp:Content>
