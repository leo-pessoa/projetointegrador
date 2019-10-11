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

        protected void ObjectDataSource1_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            int codigo;
            Modelo.Fornecedores aFornecedores;
            DAL.DALClassFornecedores aDALClassFornecedores;

            // Copia o conteúdo da primeira célula da linha -> Código do Livro
            codigo = int.Parse(DetailsView1.Rows[0].Cells[1].Text);

            // Instancia um Objeto de Livro Vazio
            aFornecedores = new Modelo.Fornecedores();
            aFornecedores.id = codigo; ;// Atribui apenas o ID

            // Instancia objeto da camada de negocio
            aDALClassFornecedores = new DAL.DALClassFornecedores();

            // Chama metodo de delete passando o objeto apenas com o ID preenchido
            aDALClassFornecedores.Delete(aFornecedores);

            Response.Redirect("~\\WebFormCRUDFornecedores.aspx");
        }

       
    }
    
}