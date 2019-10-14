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
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Modelo.DetalheVenda iDet;
            DAL.DalClassDetalheVendas iDALClassDet;
          
            iDet = new Modelo.DetalheVenda(id, int.Parse(ddl1.Text), Convert.ToInt32(TextBoxQtd.Text));
            
            iDALClassDet = new DAL.DalClassDetalheVendas();
            
            iDALClassDet.Insert(iDet);
            
            Response.Redirect("~\\WebFormCRUDDetalheVenda.aspx");
        }




    }
}