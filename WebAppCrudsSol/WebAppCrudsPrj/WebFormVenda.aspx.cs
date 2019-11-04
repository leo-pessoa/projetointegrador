using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormVenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["log_in"] == null))
            {
                Response.Redirect("WebFormLogin.aspx");
            }

            TextBoxdate.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }


        protected void Button1_Click(object sender, EventArgs e)
        {



            Modelo.Venda iProdutos;
            DAL.DalClassVendas iDALClassProdutos;
            int pago;
            if(DropDownList1.SelectedValue == "Pago")
            {
                pago = 1; 
            }
            else
            {
                pago = 0;
            }

            iProdutos = new Modelo.Venda(0, pago, Convert.ToDateTime(TextBoxdate.Text).Date, int.Parse(ListBox1.Text));


            iDALClassProdutos = new DAL.DalClassVendas();


            iDALClassProdutos.Insert(iProdutos);


            int sessao = Convert.ToInt32(iDALClassProdutos.SelectId().ToString());
            Session["id"] = sessao;

            Response.Redirect("~\\WebFormCRUDDetalheVenda.aspx");
        }

        protected void Button0_Click(object sender, EventArgs e)
        {

        }

    }
}