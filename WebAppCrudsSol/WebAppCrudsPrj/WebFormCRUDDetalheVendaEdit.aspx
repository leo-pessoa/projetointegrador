<%@ Page Title="" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormCRUDDetalheVendaEdit.aspx.cs" Inherits="WebAppCrudsPrj.WebFormCRUDDetalheVendaEdit" Theme="Tema1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
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
        <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectDetalhe" TypeName="WebAppCrudsPrj.DAL.DALClassConsultas">
        <SelectParameters>
            <asp:SessionParameter Name="id" SessionField="id_de" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:GridView ID="GridView2" runat="server" DataSourceID="ObjectDataSource2" CellPadding="4" ForeColor="#333333" GridLines="None"  CssClass="mydatagrid2" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows2" Width="154px">
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
        </div>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectVtotal" TypeName="WebAppCrudsPrj.DAL.DALClassConsultas">
        <SelectParameters>
            <asp:SessionParameter Name="id" SessionField="id_de" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
