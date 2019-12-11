using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALClassConsultas aDALClassConsultas;

            if ((Session["log_in"] != null) && (Session["log_in"].ToString() != ""))
            {
                aDALClassConsultas = new DAL.DALClassConsultas();
                string nomelogin = aDALClassConsultas.SelectLogin(Session["log_in"].ToString()).Tables[0].Rows[0][0].ToString();
                LabelBoasVindas.Text = "<h1>Bem Vindo, " + nomelogin +"</h1>";
            }
            else
            {
                Response.Redirect("WebFormLogin.aspx");
            }
        }
    }
}