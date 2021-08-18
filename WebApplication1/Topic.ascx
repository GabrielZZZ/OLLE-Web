<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Topic.ascx.cs" Inherits="WebApplication1.Topic" %>
<asp:Panel ID="Panel2" runat="server" BorderColor="Black" BorderStyle="Solid">
    <asp:Image ID="author_image1" runat="server" class="img-responsive" Height="50px" Width="50px" />

    <asp:Label ID="author_name1" runat="server" Text="author_name" Font-Italic="True" ForeColor="Blue"></asp:Label>
&nbsp;<asp:Label ID="topic_date1" runat="server" Text="date"></asp:Label>
<asp:Panel ID="Panel1" runat="server" Height="70px" style="margin-left: 0px" BorderColor="Black" BorderStyle="Dotted">
    <asp:Label ID="topic_title1" runat="server" Text="topic title" Font-Bold="True" Font-Size="Large"></asp:Label>&nbsp;<br /><asp:Label ID="topic_details" runat="server" Text="No Content"></asp:Label>

</asp:Panel>


<asp:Button ID="view_details" runat="server" Text="Details" OnClick="view_details_Click" />
</asp:Panel>




<asp:Panel ID="Panel3" runat="server" Height="10px">
</asp:Panel>





