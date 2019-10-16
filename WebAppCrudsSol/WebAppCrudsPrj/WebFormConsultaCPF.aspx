<%@ Page Language="C#" MasterPageFile="~/MestreDois.Master" AutoEventWireup="true" CodeBehind="WebFormConsultaCPF.aspx.cs" Inherits="WebAppCrudsPrj.WebFormConsultaCPF" Theme="Tema1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/gridcss.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <asp:Label ID="LabelMsgErro" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="LabelCa" runat="server" Text="Consultar Dívidas: " ForeColor="White"></asp:Label><br />
        <asp:TextBox ID="TextBoxCa" runat="server" Width="300px" TextMode="SingleLine" placeholder="Digite o CPF" MaxLength="11"></asp:TextBox><br />
        <asp:Button ID="ButtonCca" runat="server" Text="Consultar" OnClick="ButtonCca_Click" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" Width="1000px">
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#000000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#000000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#000000" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#eaeaea" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectDividas" TypeName="WebAppCrudsPrj.DAL.DALClassConsultas">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBoxCa" Name="cpf" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>

