<%@ Page Title="Forum" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="WebApplication1.Forum" %>

<%@ Register Src="~/Topic.ascx" TagName="TopicControl" TagPrefix="TTopicControl" %>

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
&nbsp;
    <asp:PlaceHolder ID="ph1" runat="server">
        
    </asp:PlaceHolder>
&nbsp;



</asp:Content>


