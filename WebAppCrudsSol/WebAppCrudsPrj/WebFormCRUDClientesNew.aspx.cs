using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormCRUDClientesNew : System.Web.UI.Page
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
            Modelo.Clientes iClientes;
            DAL.DALClassClientes iDALClassClientes;


            iClientes = new Modelo.Clientes(int.Parse(TextBoxId.Text), TextBoxNome.Text, TextBoxCPF.Text, TextBoxPerfil.Text);


            iDALClassClientes = new DAL.DALClassClientes();


            iDALClassClientes.Insert(iClientes);


            Response.Redirect("~\\WebFormCRUDClientes.aspx");
        }
    }
}