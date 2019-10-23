using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            DAL.DALClassUsuarios aDALClassUsuarios = new DAL.DALClassUsuarios();
            Modelo.Usuarios aUsuario = new Modelo.Usuarios(0, TextBoxNome.Text, TextBoxLogin.Text, TextBoxSenha.Text, TextBoxPerfil.Text);

            try
            {
                aDALClassUsuarios.Insert(aUsuario);
            }
            catch (SqlException error) {
                if (error.Message.Contains("usuario incorreto")) Session["MsgErro"] = "usuario incorreto";
            }


            Response.Redirect("~\\WebFormCadastrar.aspx");
            

        }

        
    }
}
