<%@ Page MasterPageFile="~/Pages/Layout.Master" Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPWebForm.Pages.WebForm1" %>

<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <link href="../style.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="content" ContentPlaceHolderID="Header" runat="server">
    <h3>Welcome To Index Page</h3>
</asp:Content>

<asp:Content ID="content2" ContentPlaceHolderID="SecondContent" runat="server">
    <p>Wikipedia is a free online encyclopedia, created and edited by volunteers around the world and hosted by the Wikimedia Foundation.</p>
    <p>Wikipedia is a multilingual online encyclopedia with exclusively free content and no ads, based on open collaboration through a model of content edit by</p>
</asp:Content>