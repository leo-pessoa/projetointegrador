<%@ Page Title="" Language="C#" MasterPageFile="~/MestreDois.Master" AutoEventWireup="true" CodeBehind="WebFormMenu1.aspx.cs" Inherits="WebAppCrudsPrj.WebForm1" Theme="Tema1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/gridcss.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">
        <asp:Label ID="LabelCa" runat="server" Text="Consultar CPF: " ForeColor="White"></asp:Label><br />
        <asp:TextBox ID="TextBoxCa" runat="server" Width="300px" TextMode="SingleLine"></asp:TextBox><br />
        <asp:Button ID="ButtonCa" runat="server" Text="Consultar" OnClick="ButtonCa_Click" />
     </div>
</asp:Content>
