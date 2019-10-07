<%@ Page Language="C#"  MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDProdutosEdit.aspx.cs" Inherits="WebAppCruds.WebFormCRUDProdutosEdit" Theme="Tema1"%>


<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/gridcss.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <div class="content">
            <asp:DetailsView ID="DetailsView3" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None"  CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
                <AlternatingRowStyle BackColor="White" />
                <CommandRowStyle BackColor="#f9f9f9" Font-Bold="True" />
                <EditRowStyle BackColor="#dadada" />
                <FieldHeaderStyle BackColor="#dadada" Font-Bold="True" />
                <Fields>
                    <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                    <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                    <asp:BoundField DataField="valor" DataFormatString="{0:f2}" HeaderText="Valor" SortExpression="valor" />
                    <asp:BoundField DataField="descricao" HeaderText="Descrição" SortExpression="descricao" />
                    <asp:BoundField DataField="quantidade" HeaderText="Quantidade" SortExpression="quantidade" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Fields>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
            </asp:DetailsView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebAppCruds.Modelo.Produtos" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="Select" TypeName="WebAppCruds.DAL.DALClassProdutos" UpdateMethod="Update" OnDeleted="ObjectDataSource1_Deleted">
                <InsertParameters>
                    <asp:Parameter DbType="Double" Name="valor" />
                </InsertParameters>
                <SelectParameters>
                    <asp:SessionParameter Name="id" SessionField="id" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter DbType="Double" Name="valor" />
                </UpdateParameters>
            </asp:ObjectDataSource>
        </div>         
</asp:Content>