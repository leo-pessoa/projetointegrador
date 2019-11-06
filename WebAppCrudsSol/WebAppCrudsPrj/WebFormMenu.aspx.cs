﻿using System;
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
            if ((Session["log_in"] != null) && (Session["log_in"].ToString() != ""))
            {
                LabelBoasVindas.Text = "<h1>Bem Vindo, " + Session["log_in"].ToString()+"</h1>";
            }
            else
            {
                Response.Redirect("WebFormLogin.aspx");
            }
        }
    }
}