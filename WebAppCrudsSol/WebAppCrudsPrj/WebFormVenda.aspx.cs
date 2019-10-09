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
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Modelo.Venda iProdutos;
            DAL.DalClassVendas iDALClassProdutos;
            int pago;
            if(DropDownList1.SelectedValue == "Pago")
            {
                pago = '0'; 
            }
            else
            {
                pago = '1';
            }

            iProdutos = new Modelo.Venda(int.Parse(TextBoxId.Text), pago.ToString(), Convert.ToDateTime(TextBoxdate.Text));


            iDALClassProdutos = new DAL.DalClassVendas();


            iDALClassProdutos.Insert(iProdutos);


            Response.Redirect("~\\WebFormCRUDDetalheVendas.aspx");
        }

        protected void Button0_Click(object sender, EventArgs e)
        {

        }

    }
}