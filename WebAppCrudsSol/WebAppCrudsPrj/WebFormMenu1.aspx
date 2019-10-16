<%@ Page Title="" Language="C#" MasterPageFile="~/MestreDois.Master" AutoEventWireup="true" CodeBehind="WebFormMenu1.aspx.cs" Inherits="WebAppCrudsPrj.WebForm1" Theme="Tema1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/gridcss.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">
         <h1>Seja Bem-Vindo, às nossa Loja!</h1>
         <h3>Nossa equipe preparou uma incrível lista de pordutos disponíveis no dia de Hoje</h3>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
             <Columns>
                 <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                 <asp:BoundField DataField="descricao" HeaderText="descricao" SortExpression="descricao" />
             </Columns>
         </asp:GridView>
         
         <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="WebAppCrudsPrj.DAL.DALClassProdutos"></asp:ObjectDataSource>
         
     </div>
</asp:Content>
