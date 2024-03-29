﻿<%@ Page Language="C#"  MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDProdutosNew.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCRUDProdutosNew" Theme="Tema1"%>



<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
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


<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
            <form class="content">
        <div class="container">
          <h1>Novo Produto</h1>
          <p>Preencha todos os campos</p>

         
                         <label for="name"><b>Nome</b></label>
            <asp:TextBox ID="TextBoxNome" runat="server" AutoCompleteType="Disabled"></asp:TextBox>

            <label for="value"><b>Valor</b></label>
           <asp:TextBox ID="TextBoxValor" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
          
          <label for="desc"><b>Descrição </b></label>
            <asp:TextBox ID="TextBoxDesc" runat="server" AutoCompleteType="Disabled"></asp:TextBox>

            <label for="quantity"><b>Quantidade </b></label>
            <asp:TextBox ID="TextBoxQtd" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
      
            <label for="fornecedor"><b>Fornecedor</b></label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="nome" DataValueField="id"></asp:DropDownList>
      
  
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="WebAppCrudsPrj.DAL.DALClassFornecedores"></asp:ObjectDataSource>
      
  
          <div class="clearfix">
      
            <asp:Button ID="Button2" runat="server" Text="Salvar" OnClick="ButtonS_Click" />
          </div>
        </div>
      </form>




</asp:Content>
