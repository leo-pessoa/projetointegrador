using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormCRUDProdutosNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["log_in"] == null)) 
            {
                Response.Redirect("WebFormLogin.aspx");
            }
        }
        protected void ButtonS_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Produtos iProdutos;
                DAL.DALClassProdutos iDALClassProdutos;


                iProdutos = new Modelo.Produtos(0, TextBoxNome.Text, double.Parse(TextBoxValor.Text), TextBoxDesc.Text, int.Parse(TextBoxQtd.Text), int.Parse(DropDownList1.Text));


                iDALClassProdutos = new DAL.DALClassProdutos();


                iDALClassProdutos.Insert(iProdutos);


                Response.Redirect("~\\WebFormCRUDProdutos.aspx");

            }
            catch
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "none", "ErroTamanhoExagerado()", true);
            }




        }
    }
}