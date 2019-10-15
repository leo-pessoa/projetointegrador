﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDVendasEdit.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCRUDVendasEdit" Theme="Tema1"%>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/gridcss.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <asp:DetailsView ID="DetailsView1" runat="server" Height="144px" Width="474px" AutoGenerateRows="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <CommandRowStyle BackColor="#f9f9f9" Font-Bold="True" />
                <EditRowStyle BackColor="#dadada" />
                <FieldHeaderStyle BackColor="#dadada" Font-Bold="True" />
            <Fields>
                <asp:TemplateField HeaderText="Verificação" SortExpression="pago">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Value="1">Sim</asp:ListItem>
                            <asp:ListItem Value="0">Não</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("pago") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("pago") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="data_venda" HeaderText="Data" SortExpression="data_venda" DataFormatString="{0:d}" />
                <asp:BoundField DataField="usuario_id" HeaderText="Usuário" SortExpression="usuario_id"/>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Fields>
                <FooterStyle BackColor="#000000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#000000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="black" HorizontalAlign="Center" />
                <RowStyle BackColor="#ffffff" />
        </asp:DetailsView>      
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="WebAppCrudsPrj.Modelo.Venda" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="WebAppCrudsPrj.DAL.DalClassVendas" UpdateMethod="Update">
            <UpdateParameters>
                <asp:Parameter DbType="Date" Name="data_venda" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>
