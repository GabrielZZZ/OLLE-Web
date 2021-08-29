<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalendarEvent.ascx.cs" Inherits="WebApplication1.CalendarEvent" %>

<asp:Panel ID="Panel1" runat="server" BorderColor="Black" BorderStyle="Solid" Height="126px" style="font-weight: 700">
    &nbsp;Event Name&nbsp;&nbsp;
    <asp:Label ID="event_name" runat="server" Text="Event Title"></asp:Label>
    &nbsp;&nbsp;<br /> &nbsp;<br /> &nbsp; Start Time&nbsp;&nbsp;
    <asp:Label ID="start_time" runat="server" Text="Start Time"></asp:Label>
    <br />
    &nbsp; End Time&nbsp;&nbsp;&nbsp;
    <asp:Label ID="end_time" runat="server" Text="End Time"></asp:Label>
    <br />
    &nbsp; Remining Time&nbsp;
    <asp:Label ID="remaining_time" runat="server" Text="Remaining Time"></asp:Label>
</asp:Panel>

<br />