﻿using System;
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
            if ((Session["msgErro1"] != null) && (Session["msgErro1"].ToString() != ""))
            {
                LabelMsgErro2.Text = Session["msgErro1"].ToString();
            }
        }

        protected void ButtonCca_Click(object sender, EventArgs e)
        {

            String cpfinfo;
            cpfinfo = TextBoxCa.Text;
            DAL.DALClassCPF aDALCPF = new DAL.DALClassCPF();
            List<Modelo.Clientes> aListCPF = aDALCPF.Select(cpfinfo);
            if (aListCPF.Count == 0)
            {
                Session["msgErro1"] = "Cliente não cadastrado";
                Response.Redirect("~\\WebFormConsultaCPF.aspx");
            }
            else
            {
                Session["msgErro1"] = "";
            }

        }
    }
}