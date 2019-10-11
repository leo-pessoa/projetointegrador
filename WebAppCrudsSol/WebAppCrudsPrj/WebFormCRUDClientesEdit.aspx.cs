using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormCRUDClientesEdit : System.Web.UI.Page
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
            Modelo.Clientes aClientes;
            DAL.DALClassClientes aDALClassClientes;

            codigo = int.Parse(DetailsView1.Rows[0].Cells[1].Text);

            aClientes = new Modelo.Clientes();
            aClientes.id = codigo; 

            aDALClassClientes = new DAL.DALClassClientes();

            aDALClassClientes.Delete(aClientes);

            Response.Redirect("~\\WebFormCRUDClientes.aspx");
        }
    }
}