<%@ Page Language="C#"  MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDProdutos.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCRUDProdutos" Theme="Tema1"%>



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
    <div class="content">
        <a href="WebFormCRUDProdutosNew.aspx" class="button2">Novo Produto</a>
       <br />
            <asp:GridView  runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource2" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" ID="Grid1">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                    <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                    <asp:BoundField DataField="valor" DataFormatString="R$: {0:f2}" HeaderText="Valor" SortExpression="valor" />
                    <asp:BoundField DataField="descricao" HeaderText="Descrição" SortExpression="descricao" />
                    <asp:BoundField DataField="quantidade" HeaderText="Quantidade" SortExpression="quantidade" />
                    <asp:BoundField DataField="fornecedor_id" HeaderText="Código Fornecedor" SortExpression="fornecedor_id" />
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
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="WebAppCrudsPrj.DAL.DALClassProdutos"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebAppCrudsPrj.Modelo.Produtos" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="WebAppCrudsPrj.DAL.DALClassProdutos" UpdateMethod="Update"></asp:ObjectDataSource>
            <br />
            



        </div>            
</asp:Content>





