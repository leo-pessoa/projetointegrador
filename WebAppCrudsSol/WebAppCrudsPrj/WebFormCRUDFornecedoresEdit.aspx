
<%@ Page Language="C#"  MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDFornecedoresEdit.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCRUDFornecedoresEdit" Theme="Tema1"%>



<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
            <script>
        function ErroTamanhoExagerado() {
            alert("Informações inválidas");
            return false;
        }
    </script>
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
             <div class="content">
<asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" CellPadding="4" DataSourceID="ObjectDataSource2" ForeColor="#333333" GridLines="None"  CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
                <AlternatingRowStyle BackColor="White" />
                <CommandRowStyle BackColor="#f9f9f9" Font-Bold="True" />
                <EditRowStyle BackColor="#dadada" />
                <FieldHeaderStyle BackColor="#dadada" Font-Bold="True" />
                <Fields>
                    <asp:TemplateField HeaderText="Código" SortExpression="id">
                        <EditItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id") %>'></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                    <asp:BoundField DataField="email" HeaderText="E-mail" SortExpression="email" />
                    <asp:BoundField DataField="telefone" HeaderText="Telefone" SortExpression="telefone" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Fields>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
            </asp:DetailsView>
                 <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="WebAppCrudsPrj.Modelo.Fornecedores" DeleteMethod="Delete" SelectMethod="Select" TypeName="WebAppCrudsPrj.DAL.DALClassFornecedores" UpdateMethod="Update">
                     <SelectParameters>
                         <asp:SessionParameter Name="id" SessionField="id" Type="Int32" />
                     </SelectParameters>
                 </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebAppCrudsPrj.Modelo.Fornecedores" DeleteMethod="Delete" InsertMethod="Insert" OnDeleted="ObjectDataSource1_Deleted" SelectMethod="Select" TypeName="WebAppCrudsPrj.DAL.DALClassFornecedores" UpdateMethod="Update">
                <SelectParameters>
                    <asp:SessionParameter Name="id" SessionField="id" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormCRUDFornecedores.aspx">Voltar</asp:HyperLink>
        </div>   
</asp:Content>