<%@ Page Title="Vendas" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormVenda.aspx.cs" Inherits="WebAppCrudsPrj.WebFormVenda"  Theme="Tema1"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <h1>Nova Venda</h1>
    <p>Preencha todos os campos</p>
        <br />
          <label for="cliente"><b>Procurar Cliente</b></label>
    <asp:TextBox runat="server" ID="cliente" />
    <asp:Button Text="Pesquisar" ID="buttonp" runat="server" style="margin-bottom: 10px;"/>
    <br />
    <label><b>Selecione um Cliente</b></label>
    <asp:ListBox ID="ListBox1" runat="server" DataSourceID="ObjectDataSource7" DataTextField="nome" DataValueField="id" Width="100%"></asp:ListBox>
        <asp:ObjectDataSource ID="ObjectDataSource7" runat="server" SelectMethod="Select" TypeName="WebAppCrudsPrj.DAL.DALClassClientes">
            <SelectParameters>
                <asp:ControlParameter ControlID="cliente" Name="nome" PropertyName="Text" Type="String" />
            </SelectParameters>
    </asp:ObjectDataSource>
         <br />
        
         
    <label for="pago"><b>Pagamento</b></label><br />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="nPago">A Prazo</asp:ListItem>
        <asp:ListItem Value="Pago">Pago</asp:ListItem>
    </asp:DropDownList>
    <br />
        <label for="data"><b>Data</b></label><br />
    <br />

    <asp:TextBox ID="TextBoxdate" runat="server" TextMode="Date"></asp:TextBox>

    <br />
    <br />
    <br />




    <div class="clearfix">
      
    <asp:Button ID="Button1" runat="server" Text="Próximo" OnClick="Button1_Click" />
    </div>
</div>


</asp:Content>
