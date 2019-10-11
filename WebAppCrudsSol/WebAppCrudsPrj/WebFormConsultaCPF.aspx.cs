using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{

    public partial class WebFormConsultaCPF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["msgErro"] != null) && (Session["msgErro"].ToString() != ""))
            {
                LabelMsgErro.Text = Session["msgErro"].ToString();
            }
        }

        protected void ButtonCca_Click(object sender, EventArgs e)
        {
            String cpfinfo;
            cpfinfo = TextBoxCa.Text;
            DAL.DALClassClientes aDALClientes = new DAL.DALClassClientes();
            List<Modelo.Clientes> aListClientes = aDALClientes.Select(cpfinfo);
            if (aListClientes.Count == 0)
            {
                Session["msgErro"] = "Usuário não cadastrado";
                Response.Redirect("~\\WebFormConsultaCPF.aspx");
            }
            Modelo.Clientes aClientes = aListClientes[0];
        }
    }
}