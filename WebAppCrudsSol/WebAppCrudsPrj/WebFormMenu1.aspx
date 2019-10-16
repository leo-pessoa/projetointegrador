<%@ Page Title="" Language="C#" MasterPageFile="~/MestreDois.Master" AutoEventWireup="true" CodeBehind="WebFormMenu1.aspx.cs" Inherits="WebAppCrudsPrj.WebForm1" Theme="Tema1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/gridcss.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">
         <h1 style="color:whitesmoke">Seja Bem-Vindo, à nossa Loja!</h1>
         <h4 style="color:whitesmoke">Nossa equipe preparou uma incrível lista de pordutos disponíveis no dia de Hoje</h4>
         <br />
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
             <Columns>
                 <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                 <asp:BoundField DataField="descricao" HeaderText="Descrição" SortExpression="descricao" />
             </Columns>
             <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#000000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#000000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#000000" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#eaeaea" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
         </asp:GridView>
         
         <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="WebAppCrudsPrj.DAL.DALClassProdutos"></asp:ObjectDataSource>
         
     </div>
</asp:Content>
