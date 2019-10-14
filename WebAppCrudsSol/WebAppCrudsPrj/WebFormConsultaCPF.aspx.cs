using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrudsPrj
{

    public partial class WebFormConsultaCPF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["msgErro"] != null) && (Session["msgErro"].ToString() != ""))
            {
                LabelMsgErro.Text = Session["msgErro"].ToString();
            }
        }

        protected void ButtonCca_Click(object sender, EventArgs e)
        {

            String cpfinfo;
            cpfinfo = TextBoxCa.Text;
            DAL.DALClassCPF aDALCPF = new DAL.DALClassCPF();
            List<Modelo.Clientes> aListCPF = aDALCPF.Select(cpfinfo);
            if (aListCPF.Count == 0)
            {
                Session["msgErro"] = "Usuário não cadastrado";
                Response.Redirect("~\\WebFormConsultaCPF.aspx");
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["SGEDConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(" SELECT dv.venda_id AS Codigo_Venda, p.nome AS Nome_Produto, dv.quantidadeprod AS Quantidade, SUM(p.valor*dv.quantidadeprod) AS Valor, v.data_venda AS [Data] FROM Detalhe_Venda dv INNER JOIN Venda v ON v.id = dv.venda_id INNER JOIN Produtos p ON p.id = dv.produto_id INNER JOIN Usuario us ON v.usuario_id = us.id WHERE us.cpf = "+cpfinfo+" GROUP BY dv.produto_id, dv.venda_id, p.nome, dv.quantidadeprod, v.data_venda ORDER BY v.data_venda ASC", conn);
                conn.Close();
            }

        }
    }
}