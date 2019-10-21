<%@ Page Language="C#"  MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDFornecedoresNew.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCRUDFornecedoresNew" Theme="Tema1"%>



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
        <form class="content">
            <div class="container">
              <h1>Novo Fornecedor</h1>
              <p>Preencha todos os campos</p>
      
              <label for="id"><b>ID</b></label>
                <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>
         
              <label for="name"><b>Nome</b></label>
               <asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox>
          
              <label for="email"><b>Email </b></label>
                <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>

              <label for="telefone"><b>Telefone </b></label>
                <asp:TextBox ID="TextBoxTelefone" runat="server"></asp:TextBox>

      
      
  
                
      
      
  
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SGEDConnectionString %>" SelectCommand="SELECT [id], [nome] FROM [Produtos]"></asp:SqlDataSource>
      
      
  
                
      
      
  
          <div class="clearfix">
      
            <asp:Button ID="Button2" runat="server" Text="Salvar" OnClick="Button1_Click" />
          </div>
        </div>
      </form>
</asp:Content>


