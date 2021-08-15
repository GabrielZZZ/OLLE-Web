<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Topic.ascx.cs" Inherits="WebApplication1.Topic" %>
<asp:Image ID="author_image1" runat="server" />

&nbsp;<asp:Label ID="author_name1" runat="server" Text="author_name"></asp:Label>
&nbsp;<asp:Label ID="topic_date1" runat="server" Text="date"></asp:Label>
<asp:Panel ID="Panel1" runat="server" Height="70px" style="margin-left: 0px">
    <asp:Label ID="topic_title1" runat="server" Text="topic title"></asp:Label>&nbsp;<br /><asp:Label ID="topic_details" runat="server" Text="tipic_details"></asp:Label>

</asp:Panel>


<asp:Button ID="view_details" runat="server" Text="Details" OnClick="view_details_Click" />



