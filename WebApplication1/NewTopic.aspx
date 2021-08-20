<%@ Page Title="New Topic" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewTopic.aspx.cs" Inherits="WebApplication1.NewTopic" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Create Topic</h1>
    <p>
        <asp:Button ID="Button5" runat="server" Text="Submit" OnClick="submitTopic_Click"/>
    &nbsp;
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="week_label" runat="server" Text="Week Select"></asp:Label>
        <asp:DropDownList ID="week_select" runat="server">
            <asp:ListItem Value="1"></asp:ListItem>
            <asp:ListItem Value="2"></asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
            <asp:ListItem Value="4"></asp:ListItem>
            <asp:ListItem Value="5"></asp:ListItem>
            <asp:ListItem Value="6"></asp:ListItem>
            <asp:ListItem Value="7"></asp:ListItem>
            <asp:ListItem Value="8"></asp:ListItem>
            <asp:ListItem Value="9"></asp:ListItem>
            <asp:ListItem Value="10"></asp:ListItem>
            <asp:ListItem Value="11"></asp:ListItem>
            <asp:ListItem Value="12"></asp:ListItem>
            <asp:ListItem Value="13"></asp:ListItem>
            <asp:ListItem Value="14"></asp:ListItem>
            <asp:ListItem Value="15"></asp:ListItem>
        </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="NAA Topic?"></asp:Label>
    &nbsp;
        <asp:CheckBox ID="NAA_Topic_Check" runat="server" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label>
        <asp:TextBox ID="titleBox" runat="server" Width="633px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Contents"></asp:Label>
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="20px" Text="B" Width="28px" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Height="20px" Text="I" Width="28px" />
        <asp:Button ID="Button3" runat="server" Height="20px" Text="U" Width="28px" />
        <asp:Button ID="Button4" runat="server" Height="20px" Text="Change Color" Width="100px" />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:TextBox ID="contentBox" runat="server" Height="210px" Width="698px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label3" runat="server" Text="Files Upload"></asp:Label>
    </p>
        
            <INPUT id="oFile" type="file" runat="server" NAME="oFile" aria-multiselectable="True">
        
    </p>



</asp:Content>