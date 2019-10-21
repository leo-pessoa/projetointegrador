using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormCRUDFornecedoresNew : System.Web.UI.Page
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

            try
            {
                Modelo.Fornecedores iFornecedores;
                DAL.DALClassFornecedores iDALClassFornecedores;


                iFornecedores = new Modelo.Fornecedores(0, TextBoxNome.Text, TextBoxEmail.Text, TextBoxTelefone.Text);


                iDALClassFornecedores = new DAL.DALClassFornecedores();


                iDALClassFornecedores.Insert(iFornecedores);


                Response.Redirect("~\\WebFormCRUDFornecedores.aspx");

            }

            catch
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "none", "ErroTamanhoExagerado()", true);
            }


        }

    }
}