using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCruds
{
    public partial class WebFormMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["log_in"] != null) && (Session["log_in"].ToString() != ""))
            {
                LabelBoasVindas.Text = "Bem Vindo, " + Session["log_in"].ToString();
            }
            else
            {
                Response.Redirect("WebFormLogin.aspx");
            }
        }
    }
}