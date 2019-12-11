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
                
                codigo = Convert.ToInt32(Session["id"]);
                
                aVenda = new Modelo.Venda();
                aVenda.id = codigo; ;
                
                aDALClassVenda = new DAL.DalClassVendas();
                
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