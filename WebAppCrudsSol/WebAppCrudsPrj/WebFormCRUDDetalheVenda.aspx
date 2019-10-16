<%@ Page Title="" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDDetalheVenda.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCRUDDetalheVenda" Theme="Tema1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container">
                     <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="WebAppCrudsPrj.DAL.DalClassVendas"></asp:ObjectDataSource>
        <br />
           <label for="Produto"><b>Produto</b></label><br />
        <asp:dropdownlist ID="ddl1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="nome" DataValueField="id">
</asp:dropdownlist>
            <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="WebAppCrudsPrj.DAL.DALClassProdutos"></asp:ObjectDataSource>
        
              <label for="Quantidade"><b>Quantidade</b></label><br />
                <asp:TextBox ID="TextBoxQtd" runat="server" ></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Finalizar" OnClick="Button1_Click" />

    </div>
    </div>



    </asp:Content>
