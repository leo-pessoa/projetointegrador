using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormCadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["msgErro"] != null) && (Session["msgErro"].ToString() != ""))
            {
                LabelMsgErro.Text = Session["msgErro"].ToString();
            }

            if ((Session["log_in"] == null))
            {
                Response.Redirect("WebFormLogin.aspx");
            }

        }

        protected void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (TextBoxSenha.Text != TextBoxConfirmaSenha.Text)
            {
                Session["msgErro"] = "Senha não confere";
                Response.Redirect("~\\WebFormCadastrar.aspx");
            }
            Session["msgErro"] = "";

            DAL.DALClassUsuarios aDALClassUsuarios = new DAL.DALClassUsuarios();
            Modelo.Usuarios aUsuario = new Modelo.Usuarios(0, TextBoxNome.Text, TextBoxLogin.Text, TextBoxSenha.Text, TextBoxPerfil.Text);
            aDALClassUsuarios.Insert(aUsuario);
            Response.Redirect("~\\WebFormCadastrar.aspx");

        }

        
    }
}
