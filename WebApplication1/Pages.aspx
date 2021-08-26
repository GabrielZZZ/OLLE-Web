<%@ Page Title="Pages" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pages.aspx.cs" Inherits="WebApplication1.Pages" %>

<%@ Register Src="~/PageItem.ascx" TagName="PageItemControl" TagPrefix="TPageItemControl" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Training</h1>

    <br />
    <asp:Button ID="NewTopic" runat="server" Text="New Topic" OnClick="newTopic_Click"/>
    <br />
    <asp:PlaceHolder ID="PageList" runat="server"></asp:PlaceHolder>

</asp:Content>