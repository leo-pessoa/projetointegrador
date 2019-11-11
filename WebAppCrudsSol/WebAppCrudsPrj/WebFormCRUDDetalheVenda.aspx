<%@ Page Title="" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDDetalheVenda.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCRUDDetalheVenda" Theme="Tema1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function ErroTamanhoExagerado() {
            alert("Quantidade em estoque excedida");
            return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container">
                     <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="WebAppCrudsPrj.DAL.DalClassVendas"></asp:ObjectDataSource>
        
            <label for="Produto"><b>Código da Venda: </b></label>
            <asp:Label ID="LabelIDA" runat="server"></asp:Label>
        <br />
    <label for="cliente"><b>Selecionar Produto</b></label>
    <asp:TextBox runat="server" ID="cliente" />
    <asp:Button Text="Pesquisar" ID="buttonp" runat="server" />
    <br />
    <asp:ListBox ID="ListBox1" runat="server" DataSourceID="ObjectDataSource7" DataTextField="nome" DataValueField="id" Width="173px"></asp:ListBox>
        <asp:ObjectDataSource ID="ObjectDataSource7" runat="server" SelectMethod="Select" TypeName="WebAppCrudsPrj.DAL.DALClassProdutos">
            <SelectParameters>
                <asp:ControlParameter ControlID="cliente" Name="nome" PropertyName="Text" Type="String" />
            </SelectParameters>
    </asp:ObjectDataSource>
         <br />
         <br />
            <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="WebAppCrudsPrj.DAL.DALClassProdutos"></asp:ObjectDataSource>
        
              <label for="Quantidade"><b>Quantidade</b></label><br />
                <asp:TextBox ID="TextBoxQtd" runat="server" ></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Próximo Produto" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Finalizar Venda" OnClick="Button2_Click" />
    </div>
</div>
    <br />
<div class="mostragem">
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource4" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView2_RowDeleting" OnRowUpdating="GridView2_RowUpdating" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Produto" SortExpression="produto_id">
                <EditItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("produto_id") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("produto_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="quantidadeprod" HeaderText="Quantidade" SortExpression="quantidadeprod" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="Select" TypeName="WebAppCrudsPrj.DAL.DalClassDetalheVendas">
        
        <SelectParameters>
            <asp:ControlParameter ControlID="LabelIDA" Name="venda_id" PropertyName="Text" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:GridView ID="GridView3" runat="server" CellPadding="4" DataSourceID="ObjectDataSource3" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="SelectVtotal" TypeName="WebAppCrudsPrj.DAL.DALClassConsultas">
        <SelectParameters>
            <asp:ControlParameter ControlID="LabelIDA" Name="id" PropertyName="Text" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
</div>


    </asp:Content>
