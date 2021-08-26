<%@ Page Title="Sign Up" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApplication1.SignUp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Sign Up</h1>

    <br />
    First Name


    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    Last Name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    Username<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    Email<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    Password<asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
    <br />
    <br />
    Language<br />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
        <asp:ListItem>Spanish</asp:ListItem>
        <asp:ListItem>French</asp:ListItem>
        <asp:ListItem>Japanese</asp:ListItem>
        <asp:ListItem>Italian</asp:ListItem>
        <asp:ListItem>Korean</asp:ListItem>
        <asp:ListItem>English</asp:ListItem>
        <asp:ListItem>Mandarian</asp:ListItem>
    </asp:CheckBoxList>

    <br />
    <br />
    <strong>Profile Photo</strong>
    


    <br />
        Select the file to upload to the server:
            <INPUT id="oFile" type="file" runat="server" NAME="oFile" multiple>

    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Sign Up" OnClick="Button2_Click" />

</asp:Content>
