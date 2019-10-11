<%@ Page Language="C#" MasterPageFile="~/MestreDois.Master" AutoEventWireup="true" CodeBehind="WebFormConsultaCPF.aspx.cs" Inherits="WebAppCrudsPrj.WebFormConsultaCPF" Theme="Tema1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/gridcss.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <asp:Label ID="LabelMsgErro" runat="server" ForeColor="Red"></asp:Label>
        <asp:Label ID="LabelCa" runat="server" Text="Consultar Dívidas: " ForeColor="White"></asp:Label><br />
        <asp:TextBox ID="TextBoxCa" runat="server" Width="300px" TextMode="SingleLine" placeholder="Digite o CPF" MaxLength="11"></asp:TextBox><br />
        <asp:Button ID="ButtonCca" runat="server" Text="Consultar" OnClick="ButtonCca_Click" />
        <br />
        <asp:Label ID="labelca2" runat="server" />
    </div>
</asp:Content>

