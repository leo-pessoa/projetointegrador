﻿<%@ Page Title="Vendas" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormVenda.aspx.cs" Inherits="WebAppCrudsPrj.WebFormVenda"  Theme="Tema1"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
    <h1>Nova Venda</h1>
    <p>Preencha todos os campos</p>
      
        <label for="id"><b>ID</b></label>
    <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>
         
    <label for="pago"><b>Pago</b></label><br />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="Pago">Sim</asp:ListItem>
        <asp:ListItem Value="nPago">Não</asp:ListItem>
    </asp:DropDownList>
    <br />
        <label for="data"><b>Data</b></label><br />
    <br />

    <asp:TextBox ID="TextBoxdate" runat="server" TextMode="Date"></asp:TextBox>

    <br />
    <br />
    <br />




    <div class="clearfix">
      
    <asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="Button1_Click" />
    </div>
</div>


</asp:Content>
