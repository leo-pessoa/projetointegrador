using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormCRUDVendasEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["log_in"] == null))
            {
                Response.Redirect("WebFormLogin.aspx");
            }
        }

        protected void ObjectDataSource1_Deleting1(object sender, ObjectDataSourceMethodEventArgs e)
        {
            try
            {
                int codigo;
                Modelo.Venda aVenda;
                DAL.DalClassVendas aDALClassVenda;

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = Convert.ToInt32(Session["id"]);

                // Instancia um Objeto de Livro Vazio
                aVenda = new Modelo.Venda();
                aVenda.id = codigo; ;// Atribui apenas o ID

                // Instancia objeto da camada de negocio
                aDALClassVenda = new DAL.DalClassVendas();

                // Chama metodo de delete passando o objeto apenas com o ID preenchido
                aDALClassVenda.Delete(aVenda);

                Response.Redirect("~\\WebFormCRUDVendas.aspx");

            }


            catch
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "none", "ErroTamanhoExagerado()", true);
            }

        }
    }
}