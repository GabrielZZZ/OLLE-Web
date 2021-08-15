<%@ Page Title="Forum" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="WebApplication1.Forum" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />

    <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" Font-Size="Larger"></asp:Label>



&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:CheckBox ID="NAAenable" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="NAA" />
&nbsp;<asp:Button ID="Refresh" runat="server" Text="Refresh" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="NewTopic" runat="server" Text="New Topic" />
    <br />
    <br />
&nbsp;<asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
&nbsp;



</asp:Content>


