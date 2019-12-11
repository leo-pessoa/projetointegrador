using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormCRUDFornecedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["log_in"] == null))
            {
                Response.Redirect("WebFormLogin.aspx");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Editar")
                {
                    string codigo;
                    
                    int index = Convert.ToInt32(e.CommandArgument);
                    
                    codigo = GridView1.Rows[index].Cells[0].Text;
                    
                    Session["id"] = codigo;
                    
                    Response.Redirect("~\\WebFormCRUDFornecedoresEdit.aspx");
                }

            }
            catch
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "none", "ErroTamanhoExagerado()", true);
            }



        }
    }
}