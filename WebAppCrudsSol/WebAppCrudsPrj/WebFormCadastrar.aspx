<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCadastrar.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand" >
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                    <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                    <asp:BoundField DataField="log_in" HeaderText="Log in" SortExpression="log_in" />
                    <asp:BoundField DataField="senha" HeaderText="Senha" SortExpression="senha" />
                    <asp:ButtonField CommandName="Excluir" Text="Excluir" />
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
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="WebAppCrudsPrj.DAL.DALClassUsuarios"></asp:ObjectDataSource>
        </div>
        <hr />
        <div class="cadastro">
            <asp:Label ID="LabelMsgErro" runat="server" ForeColor="Red"></asp:Label>

            <label for="id"><b>Código</b></label>
                <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>

            <label for="nome"><b>Nome</b></label>
                <asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox>

            <label for="log_in"><b>Log_in</b></label>
                <asp:TextBox ID="TextBoxLogin" runat="server"></asp:TextBox>

             <label for="senha"><b>Senha</b></label>
                <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password"></asp:TextBox>

            <label for="confirmasenha"><b>Confirmar Senha</b></label>
                <asp:TextBox ID="TextBoxConfirmaSenha" runat="server" TextMode="Password"></asp:TextBox>

             <label for="perfil"><b>Perfil</b></label>
                <asp:TextBox ID="TextBoxPerfil" runat="server" ReadOnly="True">sistema</asp:TextBox>

            <asp:Button ID="ButtonSalvar" runat="server" Text="Cadastrar" OnClick="ButtonSalvar_Click" />
        </div>
        <hr />
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Large" Font-Bold="True" ForeColor="#0033CC" NavigateUrl="~/WebFormMenu.aspx">Voltar</asp:HyperLink>
    </form>
</body>
</html>
