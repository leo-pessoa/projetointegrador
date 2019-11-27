using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormCRUDVendas : System.Web.UI.Page
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
                if (e.CommandName == "Finalizar")
                {
                    int codigo;
                    DAL.DALClassConsultas aDALClassConsultas;
                    int index = Convert.ToInt32(e.CommandArgument);
                    codigo = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);
                    aDALClassConsultas = new DAL.DALClassConsultas();
                    aDALClassConsultas.UpdateDivida(codigo);

                    Response.Redirect("~\\WebFormCRUDVendas.aspx");
                }

                if (e.CommandName == "Detalhar")
                {
                    string codigo;
                    int index = Convert.ToInt32(e.CommandArgument);
                    codigo = GridView1.Rows[index].Cells[0].Text;
                    Session["id_de"] = codigo;
                    Response.Redirect("~\\WebFormCRUDDetalheVendaEdit.aspx");
                }



            }
            catch
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "none", "ErroTamanhoExagerado()", true);
            }

        }
    }
}