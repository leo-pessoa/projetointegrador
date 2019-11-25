<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormLogin.aspx.cs" Inherits="WebAppCrudsPrj.WebFormLogin" Theme="Tema1" MasterPageFile="~/MestreDois.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/gridcss.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container">
            <asp:Label ID="LabelMsgErro" runat="server" ForeColor="Red"></asp:Label>   
             <label for="log_in"><b>Usuário</b></label>
                <asp:TextBox ID="TextBoxLogin" runat="server" AutoCompleteType="Disabled"></asp:TextBox>

             <label for="senha"><b>Senha</b></label>
                <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password"></asp:TextBox>

            <asp:Button ID="ButtonSalvar" runat="server" Text="Login" OnClick="ButtonSalvar_Click" />
        </div>
</asp:Content>
