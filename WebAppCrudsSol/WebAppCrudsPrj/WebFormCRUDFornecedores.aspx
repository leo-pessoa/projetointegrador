<%@ Page Language="C#"  MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDFornecedores.aspx.cs" Inherits="WebAppCruds.WebFormCRUDFornecedores" Theme="Tema1" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/gridcss.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <div class="content">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                    <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                    <asp:BoundField DataField="email" HeaderText="E-mail" SortExpression="email" />
                    <asp:BoundField DataField="telefone" HeaderText="Telefone" SortExpression="telefone" />
                    <asp:BoundField DataField="produto_fornecido" HeaderText="Produto Fornecido" SortExpression="produto_fornecido" />
                    <asp:ButtonField CommandName="Editar" Text="Editar" />
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
                    <br />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebAppCruds.Modelo.Fornecedores" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="WebAppCruds.DAL.DALClassFornecedores" UpdateMethod="Update"></asp:ObjectDataSource>
            <a href="WebFormCRUDFornecedoresNew.aspx" class="button2">Novo Fornecedor</a>

        </div>
</asp:Content>


