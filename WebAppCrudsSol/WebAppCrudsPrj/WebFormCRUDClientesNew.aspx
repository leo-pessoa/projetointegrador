﻿<%@ Page Language="C#"  MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDClientesNew.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCRUDClientesNew" Theme="Tema1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/gridcss.css" rel="stylesheet" />
            <script>
        function ErroTamanhoExagerado() {
            alert("Informações inválidas");
            return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form class="content">
        <div class="container">
          <h1>Novo Cliente</h1>
          <p>Preencha todos os campos</p>
         
            <label for="name"><b>Nome</b></label>
           <asp:TextBox ID="TextBoxNome" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
          
          <label for="cpf"><b>CPF</b></label>
            <asp:TextBox ID="TextBoxCPF" runat="server" MaxLength="11" AutoCompleteType="Disabled"></asp:TextBox>
      
           <label for="profile"><b>Perfil</b></label>
           <asp:TextBox ID="TextBoxPerfil" runat="server" ReadOnly="True" AutoCompleteType="Disabled">cliente</asp:TextBox>
      
      
          <div class="clearfix">
      
            <asp:Button ID="Button2" runat="server" Text="Salvar" OnClick="Button1_Click" />
          </div>
        </div>
      </form>
</asp:Content>




