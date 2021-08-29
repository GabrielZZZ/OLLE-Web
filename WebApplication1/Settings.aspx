<%@ Page Title="Account Setting" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="WebApplication1.Settings" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Account Setting</h1>
    <p>&nbsp;</p>
    <p>
        <asp:Image ID="profile_photo" runat="server" />
        <asp:Label ID="username" runat="server" Text="Username"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Change Password" OnClick="Button1_Click" />
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="Change Profile Photo" />
    </p>

</asp:Content>