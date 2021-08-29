<%@ Page Title="MenuPage" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuPage.aspx.cs" Inherits="WebApplication1.MenuPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Menu</h1>
    <p>
        <asp:ImageButton ID="ImageButton1" runat="server" AlternateText="Forum" Height="73px" ImageUrl="~/Images/forum.png" Width="73px" OnClick="ImageButton1_Click" />
&nbsp;&nbsp;&nbsp; Forum</p>
    <p>&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" AlternateText="Forum" Height="73px" ImageUrl="~/Images/calendar.png" Width="73px" OnClick="ImageButton2_Click" />
        &nbsp;&nbsp;&nbsp; Calendar</p>
    <p>&nbsp;<asp:ImageButton ID="ImageButton3" runat="server" AlternateText="Forum" Height="73px" ImageUrl="~/Images/main_page.png" Width="73px" OnClick="ImageButton3_Click" />
        &nbsp;&nbsp;&nbsp; Training</p>
    <p>&nbsp;<asp:ImageButton ID="ImageButton4" runat="server" AlternateText="Forum" Height="73px" ImageUrl="~/Images/forum.png" Width="73px" OnClick="ImageButton4_Click" />
        &nbsp;&nbsp;&nbsp; Announcement</p>
    <p>&nbsp;<asp:ImageButton ID="ImageButton5" runat="server" AlternateText="Forum" Height="73px" ImageUrl="~/Images/setting.png" Width="73px" OnClick="ImageButton5_Click" />
        &nbsp;&nbsp;&nbsp; Troubleshoot</p>
    <p>&nbsp;<asp:ImageButton ID="ImageButton6" runat="server" AlternateText="Forum" Height="73px" ImageUrl="~/Images/forum.png" Width="73px" OnClick="ImageButton6_Click" />
        &nbsp;&nbsp;&nbsp; Feedback</p>
    <p>&nbsp;<asp:ImageButton ID="ImageButton7" runat="server" AlternateText="Forum" Height="73px" ImageUrl="~/Images/setting.png" Width="73px" OnClick="ImageButton7_Click" />
        &nbsp;&nbsp;&nbsp; Account Settings</p>






</asp:Content>
