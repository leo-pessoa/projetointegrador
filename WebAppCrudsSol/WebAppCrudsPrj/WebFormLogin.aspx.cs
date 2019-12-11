using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["msgErro"] != null) && (Session["msgErro"].ToString() != ""))
            {
                LabelMsgErro.Text = Session["msgErro"].ToString();
            }
        }

        protected void ButtonSalvar_Click(object sender, EventArgs e)
        {
            DAL.DALClassUsuarios aDALUsuario = new DAL.DALClassUsuarios();
            List<Modelo.Usuarios> aListUsuarios = aDALUsuario.Select(TextBoxLogin.Text);
            if (aListUsuarios.Count == 0)
            {
                Session["msgErro"] = "Usuário não cadastrado";
                Response.Redirect("~\\WebFormLogin.aspx");
            }
            Modelo.Usuarios aUsuario = aListUsuarios[0];
            if (aUsuario.senha != TextBoxSenha.Text)
            {
                Session["msgErro"] = "Senha Inválida";
                Response.Redirect("~\\WebFormLogin.aspx");
            }
            Session["msgErro"] = "";
            Session["log_in"] = aUsuario.log_in;
            Response.Redirect("~\\WebFormMenu.aspx");

        }
    }
}