using System;
using System.Collections.Generic;
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
                iDet = new Modelo.DetalheVenda(id, int.Parse(ddl1.Text), Convert.ToInt32(TextBoxQtd.Text));

                iDALClassDet = new DAL.DalClassDetalheVendas();

                iDALClassDet.Insert(iDet);

                Response.Redirect("~\\WebFormCRUDDetalheVenda.aspx");
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
                    iDet = new Modelo.DetalheVenda(id, int.Parse(ddl1.Text), Convert.ToInt32(TextBoxQtd.Text));

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

        protected void ObjectDataSource4_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            int codigo;
            Modelo.DetalheVenda aDVendas;
            DAL.DalClassDetalheVendas aDALClassDVendas;
            int index = Convert.ToInt32(e);
            codigo = Convert.ToInt32(GridView2.Rows[index].Cells[0].Text);
            aDVendas = new Modelo.DetalheVenda();
            aDVendas.produto_id = codigo;
            aDALClassDVendas = new DAL.DalClassDetalheVendas();
            aDALClassDVendas.Delete(codigo, Convert.ToInt32(LabelIDA.Text));
            GridView2.DataBind();
        }
    }
}