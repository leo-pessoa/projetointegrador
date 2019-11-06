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
    public partial class WebFormCRUDFornecedoresEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["log_in"] == null))
            {
                Response.Redirect("WebFormLogin.aspx");
            }
        }

        protected void ObjectDataSource2_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            try
            {
                int codigo;
                Modelo.Fornecedores aFornecedores;
                DAL.DALClassFornecedores aDALClassFornecedores;
                codigo = int.Parse(DetailsView1.Rows[0].Cells[1].Text);
                aFornecedores = new Modelo.Fornecedores();
                aFornecedores.id = codigo; ;
                aDALClassFornecedores = new DAL.DALClassFornecedores();
                aDALClassFornecedores.Delete(aFornecedores);

                Response.Redirect("~\\WebFormCRUDFornecedores.aspx");
            }
            catch
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "none", "ErroTamanhoExagerado()", true);
            }
        }
    }
}