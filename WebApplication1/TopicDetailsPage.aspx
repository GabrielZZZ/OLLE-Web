<%@ Page Title="Forum" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TopicDetailsPage.aspx.cs" Inherits="WebApplication1.TopicDetailsPage" %>
<%@ Register Src="~/Reply.ascx" TagName="ReplyControl" TagPrefix="TReplyControl" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <asp:Image ID="author_image1" runat="server" class="img-responsive" Height="50px" Width="50px" />

    <asp:Label ID="author_name1" runat="server" Text="author_name" Font-Italic="True" ForeColor="Blue"></asp:Label>
&nbsp;<asp:Label ID="topic_date1" runat="server" Text="date"></asp:Label>

     <br />

    <asp:Label ID="topic_title1" runat="server" Text="topic title" Font-Bold="True" Font-Size="Large"></asp:Label>&nbsp;<br /><asp:Label ID="topic_details" runat="server" Text="No Content" BorderColor="Black" BorderStyle="Dashed"></asp:Label>

     <br />
     <br />

    <asp:PlaceHolder ID="reply_place" runat="server">
        
    </asp:PlaceHolder>

</asp:Content>