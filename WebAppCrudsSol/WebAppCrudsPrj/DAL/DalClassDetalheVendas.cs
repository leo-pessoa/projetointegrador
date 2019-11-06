using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.DAL
{
    public class DalClassDetalheVendas
    {


        string connectionString = "";

        public DalClassDetalheVendas()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SGEDConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.DetalheVenda obj)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Detalhe_Venda (venda_id, produto_id, quantidadeprod) VALUES(@venda_id, @produto_id, @quantidadeprod)", conn);
            cmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
            cmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
            cmd.Parameters.AddWithValue("@quantidadeprod", obj.quantidadeprod);


            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.DetalheVenda obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("UPDATE Detalhe_Venda SET quantidadeprod = @quantidadeprod  WHERE venda_id = @venda_id AND produto_id = @produto_id", conn);
            cmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
            cmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
            cmd.Parameters.AddWithValue("@quantidadeprod", obj.quantidadeprod);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.DetalheVenda> SelectAll()
        {

            Modelo.DetalheVenda aVenda;
            List<Modelo.DetalheVenda> aListVenda = new List<Modelo.DetalheVenda>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Detalhe_Venda";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aVenda = new Modelo.DetalheVenda(
                        Convert.ToInt32(dr["venda_id"]),
                        Convert.ToInt32(dr["produto_id"]),
                         Convert.ToInt32(dr["quantidadeprod"])
                        );
                    aListVenda.Add(aVenda);
                }

            }
            dr.Close();
            conn.Close();
            return aListVenda;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.DetalheVenda> Select(int venda_id)
        {

            Modelo.DetalheVenda aVenda;
            List<Modelo.DetalheVenda> aListVenda = new List<Modelo.DetalheVenda>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Detalhe_Venda WHERE venda_id = @venda_id";
            cmd.Parameters.AddWithValue("@venda_id", venda_id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aVenda = new Modelo.DetalheVenda(
                        Convert.ToInt32(dr["venda_id"]),
                        Convert.ToInt32(dr["produto_id"]),
                         Convert.ToInt32(dr["quantidadeprod"])
                        );
                    aListVenda.Add(aVenda);
                }

            }
            dr.Close();
            conn.Close();
            return aListVenda;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(int venda_id, int produto_id)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Detalhe_Venda WHERE venda_id = @venda_id and produto_id = @produto_id", conn);
            cmd.Parameters.AddWithValue("@venda_id", venda_id);
            cmd.Parameters.AddWithValue("@produto_id", produto_id);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }



    }
}