<%@ Page Language="C#"  MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDProdutosEdit.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCRUDProdutosEdit" Theme="Tema1"%>


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
          <div class="content">
            <asp:DetailsView ID="DetailsView3" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" CellPadding="4" DataSourceID="ObjectDataSource2" ForeColor="#333333" GridLines="None"  CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
                <AlternatingRowStyle BackColor="White" />
                <CommandRowStyle BackColor="#f9f9f9" Font-Bold="True" />
                <EditRowStyle BackColor="#dadada" />
                <FieldHeaderStyle BackColor="#dadada" Font-Bold="True" />
                <Fields>
                    <asp:TemplateField HeaderText="Código" SortExpression="id">
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id") %>'></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                    <asp:BoundField DataField="valor" HeaderText="Valor" SortExpression="valor" />
                    <asp:BoundField DataField="descricao" HeaderText="Descrição" SortExpression="descricao" />
                    <asp:BoundField DataField="quantidade" HeaderText="Quantidade" SortExpression="quantidade" />
                    <asp:TemplateField HeaderText="Fornecedor" SortExpression="fornecedor_id">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nome" DataValueField="id">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SGEDConnectionString %>" SelectCommand="SELECT [nome], [id] FROM [Fornecedor]"></asp:SqlDataSource>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("fornecedor_id") %>'></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("fornecedor_id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Fields>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
            </asp:DetailsView>
              <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="WebAppCrudsPrj.Modelo.Produtos" DeleteMethod="Delete" SelectMethod="Select" TypeName="WebAppCrudsPrj.DAL.DALClassProdutos" UpdateMethod="Update">
                  <SelectParameters>
                      <asp:SessionParameter Name="id" SessionField="id" Type="Int32" />
                  </SelectParameters>
              </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebAppCrudsPrj.Modelo.Produtos" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="Select" TypeName="WebAppCrudsPrj.DAL.DALClassProdutos" UpdateMethod="Update" OnDeleted="ObjectDataSource1_Deleted">
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
              <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormCRUDProdutos.aspx">Voltar</asp:HyperLink>

        </div>         
</asp:Content>