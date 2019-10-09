<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCadastrar.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCadastrar" Theme="Tema1" MasterPageFile="~/Mestre.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/gridcss.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

  <%--  <script language="javascript" type="text/javascript">
        function validate() 
        {   //nome
            if (document.getElementById("<%=TextBoxNome.ClientID%>").value == "")
            {
                alert("Informe o nome.");
                document.getElementById("<%=TextBoxNome.ClientID%>").focus();
                return false;
            }
            //Alfanumerico e espaço(' '),nao aceita numeros e nem caracteres especiais min 5 e max 45 caracteres. 
            var ck_nome = /^[A-Za-z ]{5,45}$/;
            var tempNome = document.getElementById("<%=TextBoxNome.ClientID%>").value;
            var matchNome = tempNome.match(ck_nome);
            if (matchNome == null) {
                alert("Nome inválido : Não informe números,  ");
                document.getElementById("<%=TextBoxNome.ClientID %>").focus();
                return false;
            }
            //Email
            if (document.getElementById("<%=TextBoxLogin.ClientID %>").value == "") 
            {
                alert("O Email não pode estar vazio");
                document.getElementById("<%=TextBoxLogin.ClientID %>").focus();
                return false;
            }
            var emailPat = /^(\".*\"|[A-Za-z]\w*)@(\[\d{1,3}(\.\d{1,3}){3}]|[A-Za-z]\w*(\.[A-Za-z]\w*)+)$/;
            var emailid = document.getElementById("<%=TextBoxLogin.ClientID %>").value;
            var matchArray = emailid.match(emailPat);
            if (matchArray == null) {
                alert("O Email esta no formato incorreto. Tente novamente.");
                document.getElementById("<%=TextBoxLogin.ClientID %>").focus();
                return false;
            }
          
        }
</script> --%>

</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="content">
      





        <div class="container">
            <asp:Label ID="LabelMsgErro" runat="server" ForeColor="Red"></asp:Label>

            <label for="id"  ><b>Código</b></label>
                <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>

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

</asp:Content>

