<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FileIcon.ascx.cs" Inherits="WebApplication1.FileIcon" %>


<asp:ImageButton ID="fileImage" runat="server" Height="72px" OnClick="fileImage_Click" OnClientClick="return false;"/>
<br />
<asp:Label ID="fileName" runat="server" Text="Label"></asp:Label>



