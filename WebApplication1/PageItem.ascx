<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PageItem.ascx.cs" Inherits="WebApplication1.PageItem" %>
<asp:Panel ID="Panel1" runat="server" BorderColor="Black" BorderStyle="Solid">
    Week <asp:Label ID="weekNum" runat="server" Text="1"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="mainPageTitle" runat="server" Text="Topic"></asp:Label>

    <br />
    <br />
    <asp:Button ID="detail" runat="server" Text="Details" OnClick="detail_Click" />

</asp:Panel>
