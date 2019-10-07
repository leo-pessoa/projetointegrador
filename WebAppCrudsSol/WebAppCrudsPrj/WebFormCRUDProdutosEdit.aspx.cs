using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCruds
{
    public partial class WebFormCRUDProdutosEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["log_in"] == null))
            {
                Response.Redirect("WebFormLogin.aspx");
            }
        }

        protected void ObjectDataSource1_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            int codigo;
            Modelo.Produtos aProdutos;
            DAL.DALClassProdutos aDALClassProdutos;

            // Copia o conteúdo da primeira célula da linha -> Código do Livro
            codigo = int.Parse(DetailsView3.Rows[0].Cells[1].Text);

            // Instancia um Objeto de Livro Vazio
            aProdutos = new Modelo.Produtos();
            aProdutos.id = codigo; ;// Atribui apenas o ID

            // Instancia objeto da camada de negocio
            aDALClassProdutos = new DAL.DALClassProdutos();

            // Chama metodo de delete passando o objeto apenas com o ID preenchido
            aDALClassProdutos.Delete(aProdutos);

            Response.Redirect("~\\WebFormCRUDProdutos.aspx");

        }
    }
}