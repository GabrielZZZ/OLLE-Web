<%@ Page Title="Calendar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalendarPage.aspx.cs" Inherits="WebApplication1.CalendarPage" %>

<%@ Register Src="~/CalendarEvent.ascx" TagName="CalendarEventControl" TagPrefix="TCalendarEventControl" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Calendar</h1>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Publish" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Calendar ID="monthCalendar1" runat="server" Height="267px" Width="376px" OnSelectionChanged="monthCalendar1_SelectionChanged"></asp:Calendar>


    <br />


    <asp:PlaceHolder ID="eventPanel" runat="server"></asp:PlaceHolder>


</asp:Content>