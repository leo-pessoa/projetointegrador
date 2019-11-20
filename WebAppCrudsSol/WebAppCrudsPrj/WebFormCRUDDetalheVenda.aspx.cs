using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{
    public partial class WebFormCRUDDetalheVenda : System.Web.UI.Page
    {



        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                id = Convert.ToInt32(Session["id"]);
            }

            LabelIDA.Text = Session["id"].ToString();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Modelo.DetalheVenda iDet;
            DAL.DalClassDetalheVendas iDALClassDet;
            try
            {
                iDet = new Modelo.DetalheVenda(id, int.Parse(ListBox1.SelectedValue.ToString()), Convert.ToInt32(TextBoxQtd.Text));

                iDALClassDet = new DAL.DalClassDetalheVendas();

                iDALClassDet.Insert(iDet);

                Response.Redirect("~\\WebFormCRUDDetalheVenda.aspx");

                GridView99.Visible = true;
                GridView3.Visible = true;

            }
            catch
            {
                ScriptManager.RegisterStartupScript(this.Page,this.GetType(),"none", "ErroTamanhoExagerado()", true);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Modelo.DetalheVenda iDet;
            DAL.DalClassDetalheVendas iDALClassDet;
            try
            {
                if(TextBoxQtd.Text != "")
                {
                    iDet = new Modelo.DetalheVenda(id, int.Parse(ListBox1.SelectedValue.ToString()), Convert.ToInt32(TextBoxQtd.Text));

                    iDALClassDet = new DAL.DalClassDetalheVendas();

                    iDALClassDet.Insert(iDet);

                    Response.Redirect("~\\WebFormCRUDVendas.aspx");
                }
                else
                {
                    Response.Redirect("~\\WebFormCRUDVendas.aspx");
                }
            }
            catch
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "none", "ErroTamanhoExagerado()", true);
            }

        }

        protected void GridView2_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            Response.Redirect("~\\WebFormCRUDDetalheVenda.aspx");
        }
    }
}