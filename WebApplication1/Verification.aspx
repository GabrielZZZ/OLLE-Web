<%@ Page Title="Verification" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Verification.aspx.cs" Inherits="WebApplication1.Verification" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Type in your verification code...</h1>
    <p>The verification code has been sent to your email account. Please check it and type the code below. Note that if you cannot find the email in the inbox, plase check the junk box.</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Vefication Code"></asp:Label>

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>




    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Confirm" OnClick="Button1_Click" />




    </p>
</asp:Content>