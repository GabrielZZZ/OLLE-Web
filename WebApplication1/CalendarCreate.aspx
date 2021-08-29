<%@ Page Title="Create Event" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalendarCreate.aspx.cs" Inherits="WebApplication1.CalendarCreate" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<h1>Create Event</h1>
    <p>&nbsp;</p>
    <p>Title
        <asp:TextBox ID="title_box" runat="server"></asp:TextBox>
    </p>
    <p>Description
        <asp:TextBox ID="description_box" runat="server"></asp:TextBox>
    </p>
    <p>Start Time<asp:TextBox ID="start_time_picker" runat="server" textmode="DateTimeLocal"></asp:TextBox>
    </p>
    <p>End Time<asp:TextBox ID="end_time_picker" runat="server" textmode="DateTimeLocal"></asp:TextBox></p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Publish" OnClick="Button1_Click" />
    </p>



</asp:Content>
