<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormLogin.aspx.cs" Inherits="WebAppCrudsPrj.WebFormLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelMsgErro" runat="server" ForeColor="Red"></asp:Label>   
             <label for="log_in"><b>Log_in</b></label>
                <asp:TextBox ID="TextBoxLogin" runat="server"></asp:TextBox>

             <label for="senha"><b>Senha</b></label>
                <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password"></asp:TextBox>

            <asp:Button ID="ButtonSalvar" runat="server" Text="Login" OnClick="ButtonSalvar_Click" />
        </div>
    </form>
</body>
</html>
