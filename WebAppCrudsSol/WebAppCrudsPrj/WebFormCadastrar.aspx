<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCadastrar.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCadastrar" Theme="Tema1" MasterPageFile="~/Mestre.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/gridcss.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="content">
      




        <div><asp:Label ID="LabelMsgErro" runat="server" ForeColor="Red"></asp:Label></div>
        <div class="container">

            <label for="nome"  ><b>Nome</b></label>
                <asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox>

            <label for="log_in"  ><b>Log_in</b></label>
                <asp:TextBox ID="TextBoxLogin" runat="server"></asp:TextBox>

             <label for="senha"  ><b>Senha</b></label>
                <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password"></asp:TextBox>

            <label for="confirmasenha"   ><b>Confirmar Senha</b></label>
                <asp:TextBox ID="TextBoxConfirmaSenha" runat="server" TextMode="Password"></asp:TextBox>

             <label for="perfil"  ><b>Perfil</b></label>
                <asp:TextBox ID="TextBoxPerfil" runat="server" ReadOnly="True">sistema</asp:TextBox>

            <asp:Button ID="ButtonSalvar" runat="server" Text="Cadastrar" OnClick="ButtonSalvar_Click" />
        </div>
           </div>
</asp:Content>

