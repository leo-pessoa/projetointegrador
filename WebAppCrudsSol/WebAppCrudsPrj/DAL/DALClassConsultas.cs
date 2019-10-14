using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.DAL
{
    public class DALClassConsultas
    {
        private string connectionString = "";

        public DALClassConsultas()
        {
            connectionString = ConfigurationManager.ConnectionStrings ["SGEDConnectionString"].ConnectionString;
        }

        public DataSet SelectDividas(String cpf)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = ("SELECT  dv.venda_id AS Codigo_Venda, p.nome AS Nome_Produto, dv.quantidadeprod AS Quantidade, SUM(p.valor*dv.quantidadeprod) AS Valor, v.data_venda AS [Data] FROM Detalhe_Venda dv INNER JOIN Venda v ON v.id = dv.venda_id INNER JOIN Produtos p ON p.id = dv.produto_id INNER JOIN Usuario us ON v.usuario_id = us.id WHERE us.cpf = '" + cpf + "' GROUP BY dv.produto_id, dv.venda_id, p.nome, dv.quantidadeprod, v.data_venda ORDER BY v.data_venda ASC");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }
    }
}